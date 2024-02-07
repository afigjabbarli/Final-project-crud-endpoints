using Final_project_crud_endpoints.Contracts;
using Final_project_crud_endpoints.DataBase;
using Final_project_crud_endpoints.DataBase.Entities.Identity;
using Final_project_crud_endpoints.Services.Abstracts;
using System.Security.Claims;

namespace Final_project_crud_endpoints.Services.Concretes
{
    public class UserService : IUserService
    {
        private readonly IHttpContextAccessor _http_context_accessor;
        private readonly DataContext _data_context;
        private User _current_user;
        public UserService(IHttpContextAccessor contextAccessor, DataContext data_context)
        {
            _http_context_accessor = contextAccessor;
            _data_context = data_context;
        }

        public bool IsCurrentUserAuthenticated()
        {
            return _http_context_accessor.HttpContext.User.Identity.IsAuthenticated;
        }

        public User CurrentUser
        {
            get
            {

                if (_current_user != null)
                {
                    return _current_user;
                }

                if (_http_context_accessor.HttpContext.User == null)
                {
                    throw new Exception("User is not authenticated");
                }

                var userIdClaim = _http_context_accessor.HttpContext.User.Claims.FirstOrDefault(c => c.Type == "Id");
                if (userIdClaim is null)
                {
                    throw new Exception("User is not authenticated");
                }

                var userId = userIdClaim.Value;
                var user = _data_context.Users.SingleOrDefault(u => u.Id.ToString() == userId);
                if (user is null)
                {
                    throw new Exception("User not found in system");
                }

                _current_user = user;

                return _current_user;
            }
        }

        public List<Claim> GetClaimsAccordingToRole(User user)
        {
            var claims = new List<Claim>();

            switch (user.Role)
            {
                case Role.Values.User:
                    claims.Add(new Claim(ClaimTypes.Role, Role.Names.User));
                    break;

                case Role.Values.Admin:
                    claims.Add(new Claim(ClaimTypes.Role, Role.Names.Admin));
                    break;

                default:
                    break;
            }

            return claims;
        }
    }
}
