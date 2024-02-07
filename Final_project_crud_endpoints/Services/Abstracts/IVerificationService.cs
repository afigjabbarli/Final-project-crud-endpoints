namespace Final_project_crud_endpoints.Services.Abstracts
{
    public interface IVerificationService
    {
        string RandomPasswordGenerator(string prefix);
        string HashPassword(string password);
        bool VerifyPassword(string password, string hashedPassword);
        string GenerateRandomSymmetricSecurityKey(int keySizeInBits = 1024);
        string GenerateAppPassword(int length = 16);
    }
}
