using Final_project_crud_endpoints.DataBase.DTOs.Order;

namespace Final_project_crud_endpoints.Services.Abstracts
{
    public interface IOrderService
    {
        Task<string> PrepareAndSendOrderInvoiceAsync(OrderDetailsDTO DTO);
    }
}
