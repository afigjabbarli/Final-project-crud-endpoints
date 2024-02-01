namespace Final_project_crud_endpoints.ApiHelper
{
    public class Gmail
    {
          public string From { get; set; } = string.Empty;
          public string To { get; set; } = string.Empty;    
          public string Body { get; set; } = string.Empty;  
          public DateTime MailDateTime { get; set; }
          public List<string> Attachments { get; set; } 
          public string MsgID { get; set; } = string.Empty; 
    }
}
