using Infobip.Api.Client.Model;

namespace Final_project_crud_endpoints.Services.Abstracts
{
    public interface ISMSService
    {
        Task<List<SmsTextualMessage>> SendSMSAsync(string recipient, string sms);
        Task<List<SmsTextualMessage>> SendSMSAsync(List<string> recipients, string sms);
    }
}
