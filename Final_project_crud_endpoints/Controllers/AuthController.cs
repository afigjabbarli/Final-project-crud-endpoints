using Final_project_crud_endpoints.Contracts;
using Final_project_crud_endpoints.Contracts.Templates;
using Final_project_crud_endpoints.CustomExceptions;
using Final_project_crud_endpoints.DataBase;
using Final_project_crud_endpoints.DataBase.DTOs.User;
using Final_project_crud_endpoints.DataBase.Entities.Identity;
using Final_project_crud_endpoints.Errors;
using Final_project_crud_endpoints.Services.Abstracts;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Final_project_crud_endpoints.Controllers
{
    [ApiController]
    [Route("api/v1/users")]
    public class UserController : ControllerBase
    {
        private readonly DataContext _data_context;
        private readonly IVerificationService _verification_service;
        private readonly IFileService _file_service;
        private readonly IActivationService _activation_service;
        private readonly INotificationService _notification_service;
        private readonly IUserService _user_service;
        public UserController(DataContext data_context, IVerificationService verification_service,
            IFileService file_service, IActivationService activation_service,
            INotificationService notification_service, IEmailService email_service, IUserService user_service)
        {
            _data_context = data_context;
            _verification_service = verification_service;
            _file_service = file_service;
            _activation_service = activation_service;
            _notification_service = notification_service;
            _user_service = user_service;
        }
        [HttpPost("auth/register")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> Register([FromForm] UserRegisterDTO DTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (await _data_context.Users.AnyAsync(u => u.Username.Equals(DTO.Username)))
            {
                ModelState.Clear();
                ModelState.AddModelError(CustomValidationErrors.Key.Username.ToString(),
                    CustomValidationErrors.Value.USERNAME_EXIST_ERROR);

                return BadRequest(ModelState);
            }

            if (await _data_context.Users.AnyAsync(u => u.Email.Equals(DTO.Email)))
            {
                ModelState.Clear();
                ModelState.AddModelError(CustomValidationErrors.Key.Email.ToString(),
                    CustomValidationErrors.Value.EMAIL_EXIST_ERROR);

                return BadRequest(ModelState);
            }

            if (await _data_context.Users.AnyAsync(u => u.PhoneNumber.Equals(DTO.PhoneNumber)))
            {
                ModelState.Clear();
                ModelState.AddModelError(CustomValidationErrors.Key.PhoneNumber.ToString(),
                    CustomValidationErrors.Value.PHONENUMBER_EXIST_ERROR);

                return BadRequest(ModelState);
            }

            User user = new()
            {
                Name = DTO.Name,
                Surname = DTO.Surname,
                Username = DTO.Username,
                Email = DTO.Email,
                Password = _verification_service
                .HashPassword(DTO.Password),
                PhoneNumber = DTO.PhoneNumber,
                CreatedAt = DateTime.UtcNow,
                LastUpdatedAt = DateTime.UtcNow,
                User_Code = _verification_service
                .RandomPasswordGenerator(Prefix.USER)
            };

            if (DTO.File is not null)
                user.PhisicalImageURL = await _file_service
                    .UploadAsync(CustomUploadDirectories.Users, DTO.File, user.User_Code);

            using (var transaction = await _data_context.Database.BeginTransactionAsync())
            {
                try
                {
                    await _data_context.Users.AddAsync(user);
                    await _data_context.SaveChangesAsync();

                    var activation_token = await _activation_service
                        .GenerateAndSendActivationURL(user, Guid.NewGuid().ToString());

                    Dictionary<string, string> OldAndNewValues = new Dictionary<string, string>();

                    OldAndNewValues.Add("{email}", user.Email);
                    OldAndNewValues.Add("{surname}", user.Surname);
                    OldAndNewValues.Add("{name}", user.Name);

                    await _notification_service
                        .PrepareAndSendSMSNotifcation(OldAndNewValues,
                        user.PhoneNumber, SMSTemplates.Value.activation_url);

                    await _data_context.ActivationTokens.AddAsync(activation_token);
                    await _data_context.SaveChangesAsync();

                    await transaction.CommitAsync();

                    var jsonOptions = new JsonSerializerOptions
                    {
                        ReferenceHandler = ReferenceHandler.Preserve
                    };

                    var URL = "https://localhost:7069/api/v1/users/details" + user.Id;
                    return Created(URL, JsonSerializer.Serialize(user, jsonOptions));
                }
                catch (Exception ex)
                {
                    await transaction.RollbackAsync();
                    throw new UserRegistrationFailedException("User registration failed. Please check your input.", ex);
                }
            }
        }

        [HttpGet("auth/verify")]
        public async Task<IActionResult> Verify([FromQuery(Name = "Id")] Guid Id, [FromQuery(Name = "Token")] string Token)
        {
            try
            {
                var token = await _data_context.ActivationTokens
                .SingleOrDefaultAsync(token => token.UserId.Equals(Id) && token.Unique_Activation_Token.Equals(Token));

                var user = await _data_context.Users.SingleOrDefaultAsync(u => u.Id.Equals(Id));

                if (user is null || token is null)
                {
                    throw new ActivationFailedException();
                }

                if (token.IsUsed is true && user.IsConfirmed is true)
                {
                    await _notification_service
                        .PrepareAndSendEmailNotifcation(user, EmailTemplates.Subject.Activation_Email,
                        EmailTemplates.Body.Already_Exist_Account);
                    throw new ActivationFailedException();
                }

                if (token.ExpireDate < DateTime.UtcNow)
                {
                    await _notification_service
                        .PrepareAndSendEmailNotifcation(user,
                        EmailTemplates.Subject.Expired_Token,
                        EmailTemplates.Body.Expired_Token);
                    _data_context.ActivationTokens.Remove(token);
                    await _data_context.SaveChangesAsync();
                    throw new ActivationFailedException();
                }

                user.IsConfirmed = true;
                user.ApplicationPassword = _verification_service.GenerateAppPassword();
                token.IsUsed = true;
                token.LastUpdatedAt = DateTime.UtcNow;
                user.LastUpdatedAt = DateTime.UtcNow;
                user.ConfirmedDate = DateTime.UtcNow;

                Dictionary<string, string> data = new Dictionary<string, string>();
                data.Add("{Name}", user.Name);
                data.Add("{Surname}", user.Surname);
                data.Add("{app_password}", user.ApplicationPassword);

                var email = await _notification_service
                    .PrepareAndSendEmailNotifcation(data,
                    user, EmailTemplates.Subject.Success_Activation,
                    EmailTemplates.Body.Success_Activation_Email);

                await _notification_service
                    .PrepareAndSendSMSNotifcation(data, user.PhoneNumber,
                    EmailTemplates.Body.Success_Activation_Email);

                _data_context.Emails.Add(email);
                _data_context.Update(user);
                _data_context.Update(token);
                await _data_context.SaveChangesAsync();
            }
            catch (Exception exception)
            {
                throw new ActivationFailedException("An attempt to activate the account failed! Please try again or contact an authorized person...", exception);
            }
            return Ok();
        }
        [HttpPost("auth/login")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Login([FromForm] UserLoginDTO DTO)
        {

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (!string.IsNullOrEmpty(DTO.Email) && !string.IsNullOrEmpty(DTO.Username))
            {
                ModelState.Clear();
                ModelState.AddModelError("Login-Error", "Username and email cannot be provided simultaneously!");
                return BadRequest(ModelState);
            }

            else if (string.IsNullOrEmpty(DTO.Email) && string.IsNullOrEmpty(DTO.Username))
            {
                ModelState.Clear();
                ModelState.AddModelError("Login", "Username or email must be provided.");
                return BadRequest(ModelState);
            }

            else if (!string.IsNullOrEmpty(DTO.Username))
            {
                var result = await _data_context.Users.SingleOrDefaultAsync(u => u.Username.Equals(DTO.Username));
                ModelState.Clear();
                ModelState.AddModelError("Username", "Username not found!");
                if (result is null) return BadRequest(ModelState);
            }

            else if (!string.IsNullOrEmpty(DTO.Email))
            {
                var result = await _data_context.Users.SingleOrDefaultAsync(u => u.Email.Equals(DTO.Email));
                ModelState.Clear();
                ModelState.AddModelError("Email", "Email not found!");
                if (result is null) return BadRequest(ModelState);
            }

            var password = _verification_service.HashPassword(DTO.Password);

            var user = await _data_context.Users.SingleOrDefaultAsync(u => u.Password.Equals(password));
            if (user is null)
            {
                ModelState.Clear();
                ModelState.AddModelError("Password", "The password you entered is incorrect, please try again!");
                return BadRequest(ModelState);
            }

            if (!user.IsConfirmed)
            {
                ModelState.Clear();
                ModelState.AddModelError("Login-Error", "Sorry dear user, your account has not been approved!");
                return BadRequest(ModelState);
            }

            var claims = new List<Claim>
            {
                 new Claim("Id", user.Id.ToString()),
            };

            claims.AddRange(_user_service.GetClaimsAccordingToRole(user));

            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var claimsPricipal = new ClaimsPrincipal(claimsIdentity);

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, claimsPricipal);

            return Ok(user);
        }

        [HttpGet("auth/logout")]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            return NoContent();
        }

    }




}

