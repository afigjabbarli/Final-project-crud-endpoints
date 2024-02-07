using Final_project_crud_endpoints.DataBase.Entities.Identity;
using Final_project_crud_endpoints.DataBase.Entities;

namespace Final_project_crud_endpoints.Services.Abstracts
{
    public interface IActivationService
    {
        Task<ActivationToken> GenerateAndSendActivationURL(User user, string token);
    }
}
