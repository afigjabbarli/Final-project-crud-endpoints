using Final_project_crud_endpoints.DataBase.Entities;
using Final_project_crud_endpoints.DataBase.Entities.Identity;
using Final_project_crud_endpoints.Services.Abstracts;
using System.Text;

namespace Final_project_crud_endpoints.Services.Concretes
{
    public class NotificationService : INotificationService
    {
        private readonly ISMSService _smsService;
        private readonly IEmailService _emailService;
        public NotificationService(ISMSService smsService, IEmailService emailService)
        {
            _smsService = smsService;
            _emailService = emailService;
        }

        public async Task PrepareAndSendSMSNotifcation(Dictionary<string, string> OldAndNewValues, string recipient, string template)
        {
            if (OldAndNewValues == null || string.IsNullOrEmpty(template))
            {
                throw new ArgumentNullException("OldAndNewValues and template cannot be null or empty.");
            }

            StringBuilder templateBuilder = new StringBuilder(template);

            foreach (var keyValue in OldAndNewValues)
            {
                templateBuilder.Replace(keyValue.Key, keyValue.Value);
            }

            await _smsService.SendSMSAsync(recipient, templateBuilder.ToString());
        }

        public async Task PrepareAndSendSMSNotifcation(string recipient, string template)
        {
            if (string.IsNullOrEmpty(template))
            {
                throw new ArgumentNullException("Template cannot be null or empty.");
            }

            await _smsService.SendSMSAsync(recipient, template);
        }

        public async Task<Email> PrepareAndSendEmailNotifcation(User user, string subject, string body)
        {
            if (string.IsNullOrEmpty(body))
            {
                throw new ArgumentNullException("Template cannot be null or empty.");
            }

            var email = new Email()
            {
                Subject = subject,
                Body = body,
                Recipients = { user.Email },
                CreatedAt = DateTime.UtcNow,
                LastUpdatedAt = DateTime.UtcNow,
                UserId = user.Id
            };

            await _emailService.SendEmailAsync(user.Email, subject, body);    

            return email;
        }

        public async Task<Email> PrepareAndSendEmailNotifcation(Dictionary<string, string> OldAndNewValues, User user, string subject, string body)
        {
            if (OldAndNewValues == null || string.IsNullOrEmpty(body))
            {
                throw new ArgumentNullException("OldAndNewValues and template cannot be null or empty.");
            }

            var templateBuilder = new StringBuilder(body);

            foreach (var keyValue in OldAndNewValues)
            {
                templateBuilder.Replace(keyValue.Key, keyValue.Value);
            }

            var email = new Email()
            {
                Subject = subject,
                Body = templateBuilder.ToString(),
                Recipients = { user.Email },
                CreatedAt = DateTime.UtcNow,
                LastUpdatedAt = DateTime.UtcNow,
                UserId = user.Id
            };

            await _emailService.SendEmailAsync(user.Email, email.Subject, email.Body);

            return email;
        }

    }

}
