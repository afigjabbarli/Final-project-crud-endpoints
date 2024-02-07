using Final_project_crud_endpoints.DataBase.DTOs.Email;
using Final_project_crud_endpoints.DataBase.Entities;
using Final_project_crud_endpoints.DataBase.Entities.Identity;
using Final_project_crud_endpoints.Services.Abstracts;
using System.Web;

namespace Final_project_crud_endpoints.Services.Concretes
{
    public class ActivationService : IActivationService 
    {
        private readonly IConfiguration _configuration;
        private readonly string _server;
        private readonly IEmailService _email_service;
        public ActivationService(IConfiguration configuration, IEmailService email_service)
        {
            _configuration = configuration;
            _server = _configuration.GetValue<string>("AppSettings:Server");
            _email_service = email_service;
        }
        public async Task<ActivationToken> GenerateAndSendActivationURL(User user, string token)
        {
            var activation_url = $"{_server}api/v1/users/auth/verify?Id={user.Id}&Token={HttpUtility.UrlEncode(token)}";


            var emailPostDTO = new EmailPostDTO
            {
                Subject = "Account activation URL - Walmart ECommerce Online Shopping",
                Recipients = new List<string>()
                {
                    user.Email
                },
                Body = $@"Hello dear {user.Surname} {user.Name},<br><br>
                     You can activate your account by clicking the button below:<br><br>
                     <div style=""text-align: center;"">
                     <a href=""{activation_url}"" style=""display: inline-block; padding: 15px 45px; border-radius: 16px; background-color: #4CAF50; color: white; text-align: center; text-decoration: none; font-size: 18px; margin: 4px 2px; cursor: pointer;"">Activate Account</a>
                     </div>"
            };

            await _email_service.SendEmailAsync(emailPostDTO.Recipients, emailPostDTO.Subject, emailPostDTO.Body);

            ActivationToken activation_token = new()
            {
                CreatedAt = DateTime.UtcNow,
                LastUpdatedAt = DateTime.UtcNow,
                ExpireDate = DateTime.UtcNow.AddHours(2),
                Unique_Activation_Token = token,
                UserId = user.Id,
            };

            return activation_token;
        }
    }
}
