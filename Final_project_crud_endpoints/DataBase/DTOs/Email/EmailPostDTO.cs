using System.Text.Json.Serialization;

namespace Final_project_crud_endpoints.DataBase.DTOs.Email
{
    public class EmailPostDTO
    {
        [JsonConstructor]
        public EmailPostDTO(string recipient, string subject, string body)
        {
            Recipients = new List<string> { recipient };
            Subject = subject;
            Body = body;
        }
        [JsonConstructor]
        public EmailPostDTO(List<string> recipients, string subject, string body)
        {
            Recipients = recipients;
            Subject = subject;
            Body = body;
        }

        public EmailPostDTO(){}

        public List<string> Recipients { get; set; } = new List<string>();
        public string Subject { get; set; } = string.Empty;
        public string Body { get; set; } = string.Empty;
    }

}
