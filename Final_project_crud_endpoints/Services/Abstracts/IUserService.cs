using Final_project_crud_endpoints.DataBase.Entities.Identity;
using System.Security.Claims;

namespace Final_project_crud_endpoints.Services.Abstracts
{
    public interface IUserService
    {
        bool IsCurrentUserAuthenticated();
        List<Claim> GetClaimsAccordingToRole(User user);
    }
}
