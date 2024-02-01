using Final_project_crud_endpoints.DataBase;
using Final_project_crud_endpoints.DataBase.Entities;
using Final_project_crud_endpoints.Services.Abstracts;

namespace Final_project_crud_endpoints.Services.Concretes
{
    public class VerificationService : IVerificationService
    {
        private readonly Random _random;
        private readonly DataContext _data_context;
        public VerificationService(DataContext dataContext)
        {
            _random = new Random(); 
            _data_context = dataContext;
        }

        public string RandomPasswordGenerator(string prefix)
        {
            string random_password;
            do
            {
                decimal hash = _random.Next(1000000, 10000000);
                random_password = prefix + "---" + hash;
            }
            while (_data_context.Passwords.Any(p => p.Password.Equals(random_password)));
            var password = new RandomPassword
            {
                Password = random_password
            };
            _data_context.Passwords.Add(password);  
            return random_password;
        }
    }
}
