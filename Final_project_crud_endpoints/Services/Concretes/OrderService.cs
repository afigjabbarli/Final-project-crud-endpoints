using Final_project_crud_endpoints.Contracts.Templates;
using Final_project_crud_endpoints.DataBase;
using Final_project_crud_endpoints.DataBase.DTOs.Order;
using Final_project_crud_endpoints.Services.Abstracts;

namespace Final_project_crud_endpoints.Services.Concretes
{
    public class OrderService : IOrderService   
    {
        private readonly IEmailService _email_service;
        private readonly IUserService _user_service;
        public OrderService(IEmailService email_service, IUserService user_service)
        {
            _email_service = email_service;
            _user_service = user_service;
        }

        public async Task<string> PrepareAndSendOrderInvoiceAsync(OrderDetailsDTO DTO)
        {
            var email_body = InvoiceTemplate.GenerateInvoiceHtml(DTO);

            await _email_service
                .SendEmailAsync(_user_service.CurrentUser.Email, EmailTemplates.Subject.Order_Invoice, email_body);

            return email_body;
        }
    }
}
