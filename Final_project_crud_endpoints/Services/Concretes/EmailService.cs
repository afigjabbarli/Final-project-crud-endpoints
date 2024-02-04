using Final_project_crud_endpoints.DataBase.DTOs.Email;
using Final_project_crud_endpoints.Services.Abstracts;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using MimeKit.Text;


namespace Final_project_crud_endpoints.Services.Concretes
{
    public class EmailService : IEmailService
    {
        private readonly IConfiguration _configuration;
        private readonly string _from;
        private readonly string _password;
        private readonly string _host;
        private readonly int _port;

        public EmailService(IConfiguration configuration)
        {
            _configuration = configuration;
            _from = _configuration.GetValue<string>("MailSettings:EmailAdress");
            _host = _configuration.GetValue<string>("MailSettings:Host");
            _port = _configuration.GetValue<int>("MailSettings:Port");
            _password = _configuration.GetValue<string>("MailSettings:Password");
        }

        public async Task SendEmailAsync(string reciepent, string subject, string body)
        {
             await SendEmailAsync(new List<string> { reciepent }, subject, body);   
        }

        public async Task SendEmailAsync(List<string> reciepents, string subject, string body)
        {
             var DTO = new EmailPostDTO(reciepents, subject, body); 
             var email = CreateEmailMessage(DTO);

             await AuthorizeAndSendEmailAsync(email);
        }

        private MimeMessage CreateEmailMessage(EmailPostDTO DTO)
        {
            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse(_from));
            foreach (var reciepent in DTO.Recipients)
            {
                email.To.Add(MailboxAddress.Parse(reciepent));
            }
            email.Subject = DTO.Subject;
            email.Body = new TextPart(TextFormat.Html) { Text = DTO.Body }; 

            return email;   
        }

        private async Task AuthorizeAndSendEmailAsync(MimeMessage email)
        {
            try
            {
                using (var smtp = new SmtpClient())
                {
                    await smtp.ConnectAsync(_host, _port, SecureSocketOptions.StartTls);
                    smtp.AuthenticationMechanisms.Remove("XOAUTH2");
                    await smtp.AuthenticateAsync(_from, _password);
                    await smtp.SendAsync(email);
                    await smtp.DisconnectAsync(true);
                }
            }
            catch (AuthenticationException authException)
            {
                Console.WriteLine($"Authentication failed: {authException.Message}");
            }
            catch (Exception exception)
            {
                Console.WriteLine($"An error occurred while sending email: {exception.Message}");
            }
        }

    }
}
