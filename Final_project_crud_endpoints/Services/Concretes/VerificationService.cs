using Final_project_crud_endpoints.DataBase;
using Final_project_crud_endpoints.DataBase.Entities;
using Final_project_crud_endpoints.Services.Abstracts;
using System.Security.Cryptography;
using System.Text;

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

        public string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
               
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hashedBytes.Length; i++)
                {
                    builder.Append(hashedBytes[i].ToString("x2"));
                }

                return builder.ToString();
            }
        }

        public bool VerifyPassword(string password, string hashedPassword)
        {
    
            string hashedInput = HashPassword(password);

            return hashedInput == hashedPassword;
        }

        public string GenerateRandomSymmetricSecurityKey(int keySizeInBits = 1024)
        {
            int byteSize = keySizeInBits / 8;

            using (var provider = new RNGCryptoServiceProvider())
            {
                byte[] keyData = new byte[byteSize];
                provider.GetBytes(keyData);
                return Convert.ToBase64String(keyData);
            }
        }



        public string GenerateAppPassword(int length = 16)
        {
            const string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

            using (var rng = new RNGCryptoServiceProvider())
            {
                byte[] tokenData = new byte[length];
                rng.GetBytes(tokenData);

                char[] chars = new char[length];
                int validCharCount = validChars.Length;

                for (int i = 0; i < length; i++)
                {
                    chars[i] = validChars[tokenData[i] % validCharCount];
                }

                return new string(chars);
            }
        }
    }
}
