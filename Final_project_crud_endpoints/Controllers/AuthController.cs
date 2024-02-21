using Final_project_crud_endpoints.Contracts;
using Final_project_crud_endpoints.Contracts.Templates;
using Final_project_crud_endpoints.CustomExceptions;
using Final_project_crud_endpoints.DataBase;
using Final_project_crud_endpoints.DataBase.DTOs.User;
using Final_project_crud_endpoints.DataBase.Entities.Identity;
using Final_project_crud_endpoints.Errors;
using Final_project_crud_endpoints.Services.Abstracts;
using Final_project_crud_endpoints.Validations;
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
    public class AuthController : ControllerBase
    {
        private readonly DataContext _data_context;
        private readonly IVerificationService _verification_service;
        private readonly IFileService _file_service;
        private readonly IActivationService _activation_service;
        private readonly INotificationService _notification_service;
        private readonly IUserService _user_service;
        private readonly ILogger<AuthController> _logger;
        private readonly IBasketService _basket_service;
        public AuthController(DataContext data_context, IVerificationService verification_service,
            IFileService file_service, IActivationService activation_service,
            INotificationService notification_service, IEmailService email_service,
            IUserService user_service, ILogger<AuthController> logger, IBasketService basket_service)
        {
            _data_context = data_context;
            _verification_service = verification_service;
            _file_service = file_service;
            _activation_service = activation_service;
            _notification_service = notification_service;
            _user_service = user_service;
            _logger = logger;
            _basket_service = basket_service;
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
                user.Phisical_image_name = await _file_service
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

                    var URL = "https://localhost:7069/api/v1/users/details/" + user.Id;
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
                ModelState.AddModelError("LoginError", "Username and email cannot be provided simultaneously!");
                return BadRequest(ModelState);
            }

            else if (string.IsNullOrEmpty(DTO.Email) && string.IsNullOrEmpty(DTO.Username))
            {
                ModelState.Clear();
                ModelState.AddModelError("LoginError", "Username or email must be provided.");
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
                ModelState.AddModelError("LoginError", "Sorry dear user, your account has not been approved!");
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
            _basket_service.ClearBasketItems();
            _data_context.BasketItems.RemoveRange(_data_context.BasketItems
                .Where(bi => bi.Current_User_ID.Equals(_user_service.CurrentUser.Id)));
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            return NoContent();
        }

        [HttpGet("get-all")]
        [Produces(type: typeof(List<UserListItemDTO>))]
        [ProducesResponseType(statusCode: StatusCodes.Status200OK)]
        [ProducesResponseType(statusCode: StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Get()
        {
            try
            {
                var users = await _data_context.Users.Where(u => u.IsConfirmed == true && u.Role == Role.Values.User)
                   .Select(u => new UserListItemDTO
                   {
                       Name = u.Name,
                       Surname = u.Surname,
                       PhoneNumber = u.PhoneNumber,
                       Username = u.Username,
                       Email = u.Email,
                       CreatedAt = u.CreatedAt,
                       LastUpdatedAt = u.LastUpdatedAt,
                       IsBanned = u.IsBanned,
                       PhisicalImageURL = _file_service
                       .ReadStaticFiles(u.User_Code, CustomUploadDirectories.Users, u.Phisical_image_name)
                   }).OrderBy(u => u.Name).OrderBy(u => u.CreatedAt).ToListAsync();

                return Ok(users);

            }
            catch (Exception exception)
            {
                _logger.LogError(exception, "An error occurred while processing the request.");

                return StatusCode(500, "An error occurred while processing the request. Please try again later.");
            }
        }
        [HttpGet("get/{Id}")]
        [ProducesResponseType(statusCode: StatusCodes.Status404NotFound)]
        [ProducesResponseType(statusCode: StatusCodes.Status200OK)]
        [ProducesResponseType(statusCode: StatusCodes.Status500InternalServerError)]
        [Produces(type: typeof(UserListItemDTO))]
        public async Task<IActionResult> Get([FromRoute] Guid Id)
        {
            try
            {
                var user = await _data_context.Users.SingleOrDefaultAsync(u => u.Id.Equals(Id));
                if (user is null)
                    return NotFound($"The user with the << {Id} >> number you are looking for does not already exist in the database!");

                var response = new UserListItemDTO
                {
                    Name = user.Name,
                    Surname = user.Surname,
                    PhoneNumber = user.PhoneNumber,
                    Username = user.Username,
                    Email = user.Email,
                    CreatedAt = user.CreatedAt,
                    LastUpdatedAt = user.LastUpdatedAt,
                    IsBanned = user.IsBanned,
                    PhisicalImageURL = _file_service
                        .ReadStaticFiles(user.User_Code, CustomUploadDirectories.Users, user.Phisical_image_name)
                };

                return Ok(response);

            }
            catch (Exception exception)
            {
                _logger.LogError(exception, "An error occurred while processing the request.");

                return StatusCode(500, "An error occurred while processing the request. Please try again later.");
            }
        }
        [HttpDelete("delete/{appPassword}")]
        [ProducesResponseType(statusCode: StatusCodes.Status404NotFound)]
        [ProducesResponseType(statusCode: StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(statusCode: StatusCodes.Status204NoContent)]
        public async Task<IActionResult> Delete([FromRoute] string appPassword)
        {
            try
            {
                var user = await _data_context.Users.SingleOrDefaultAsync(u => u.ApplicationPassword.Equals(appPassword));
                if (user == null) return NotFound($"The user with this <<{appPassword}>> password was not found in the database!");

                if (user.Phisical_image_name is not null)
                {
                    _file_service.RemoveStaticFiles(user.User_Code,
                        CustomUploadDirectories.Users, user.Phisical_image_name);
                }

                _data_context.Users.Remove(user);
                await _data_context.SaveChangesAsync();
                return NoContent();
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, "An error occurred while processing the request.");

                return StatusCode(500, "An error occurred while processing the request. Please try again later.");
            }
        }
        [HttpPut("update/{appPassword}")]
        [ProducesResponseType(statusCode: StatusCodes.Status404NotFound)]
        [ProducesResponseType(statusCode: StatusCodes.Status400BadRequest)]
        [ProducesResponseType(statusCode: StatusCodes.Status200OK)]
        [ProducesResponseType(statusCode: StatusCodes.Status500InternalServerError)]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> Update([FromRoute] string appPassword, [FromForm] UserUpdateDTO DTO)
        {
            try
            {
                var user = await _data_context.Users.SingleOrDefaultAsync(u => u.ApplicationPassword.Equals(appPassword));
                if (user == null) return NotFound($"The user with this <<{appPassword}>> password was not found in the database!");

                if (!ModelState.IsValid) return BadRequest(ModelState);

                if (DTO.File is not null)
                {
                    _file_service.RemoveStaticFiles(user.User_Code, CustomUploadDirectories.Users, user.Phisical_image_name);
                    await _file_service.UploadAsync(CustomUploadDirectories.Users, DTO.File, user.User_Code);

                }
                user.Name = DTO.Name;
                user.Surname = DTO.Surname;
                user.PhoneNumber = DTO.PhoneNumber;
                user.LastUpdatedAt = DateTime.UtcNow;

                _data_context.Users.Update(user);
                await _data_context.SaveChangesAsync();

                return Ok(user);
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, "An error occurred while processing the request.");

                return StatusCode(500, "An error occurred while processing the request. Please try again later.");
            }
        }
        [ProducesResponseType(statusCode: StatusCodes.Status404NotFound)]
        [ProducesResponseType(statusCode: StatusCodes.Status200OK)]
        [ProducesResponseType(statusCode: StatusCodes.Status500InternalServerError)]
        [HttpPut("block-account/{Id}")]
        public async Task<IActionResult> Block([FromRoute] Guid Id)
        {
            try
            {
                var account = await _data_context.Users.SingleOrDefaultAsync(u => u.Id.Equals(Id));
                if (account is null) return NotFound($"The user with this <<{Id}>> Id was not found in the database!");

                account.IsBanned = true;

                _data_context.Users.Update(account);
                await _data_context.SaveChangesAsync();

                return Ok(account);
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, "An error occurred while processing the request.");

                return StatusCode(500, "An error occurred while processing the request. Please try again later.");
            }
        }
        [HttpGet("details/{Id}")]
        [ProducesResponseType(statusCode: StatusCodes.Status404NotFound)]
        [ProducesResponseType(statusCode: StatusCodes.Status200OK)]
        [ProducesResponseType(statusCode: StatusCodes.Status500InternalServerError)]
        [Produces(type: typeof(UserListItemDTO))]
        public async Task<IActionResult> Details([FromRoute] Guid Id)
        {
            try
            {
                var user = await _data_context.Users.SingleOrDefaultAsync(u => u.Id.Equals(Id));
                if (user is null)
                    return NotFound($"The user with the << {Id} >> Id number you are looking for does not already exist in the database!");

                var response = new UserDetailsDTO
                {
                    Name = user.Name,
                    Surname = user.Surname,
                    PhoneNumber = user.PhoneNumber,
                    Username = user.Username,
                    Password = user.Password,
                    Email = user.Email,
                    CreatedAt = user.CreatedAt,
                    ConfirmedDate = user.ConfirmedDate,
                    LastUpdatedAt = user.LastUpdatedAt,
                    ApplicationPassword = user.ApplicationPassword,
                    IsConfirmed = user.IsConfirmed,
                    PhisicalImageURL = _file_service
                        .ReadStaticFiles(user.User_Code, CustomUploadDirectories.Users, user.Phisical_image_name)
                };

                return Ok(response);
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, "An error occurred while processing the request.");

                return StatusCode(500, "An error occurred while processing the request. Please try again later.");
            }
        }
        [HttpGet("search")]
        [ProducesResponseType(statusCode: StatusCodes.Status200OK)]
        [ProducesResponseType(statusCode: StatusCodes.Status400BadRequest)]
        [Produces(type: typeof(List<UserListItemDTO>))]
        public async Task<IActionResult> Search([FromQuery(Name = "query")] string query)
        {
            if (!CustomValidations.IsValidQueryString(query))
                return BadRequest("The search query is invalid!");

            var users = await _data_context.Users.ToListAsync();

            if (users.Count == 0)
                return Ok(new List<UserListItemDTO>());

            var response = users.Where(u => (u.Name + u.Surname)
            .Contains(query, StringComparison.OrdinalIgnoreCase))
            .Select(u => new UserListItemDTO
            {

                Name = u.Name,
                Surname = u.Surname,
                PhoneNumber = u.PhoneNumber,
                Username = u.Username,
                Email = u.Email,
                CreatedAt = u.CreatedAt,
                LastUpdatedAt = u.LastUpdatedAt,
                IsBanned = u.IsBanned,
                PhisicalImageURL = _file_service
                .ReadStaticFiles(u.User_Code, CustomUploadDirectories.Users, u.Phisical_image_name)

            }).ToList();

            return Ok(response);
        }
        [HttpGet("get/current-user")]
        public IActionResult GetCurrentUser()
        {
            try
            {
                var current_user = _user_service.CurrentUser;

                var isAuthenticated = _user_service.IsCurrentUserAuthenticated();

                if (isAuthenticated is false || current_user is null)
                {
                    return BadRequest("The user was not authenticated!");
                }

                var userDetails = new AuthDetailsDTO
                {
                    Id = current_user.Id,
                    Name = current_user.Name,
                    Surname = current_user.Surname,
                    IsAuthenticated = isAuthenticated,
                    IsBanned = current_user.IsBanned,
                    Role = current_user.Role.ToString(),
                };

                return Ok(userDetails);
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, "An error occurred while processing the request.");

                return StatusCode(500, "An error occurred while processing the request. Please try again later.");
            }
        }


    }




}

