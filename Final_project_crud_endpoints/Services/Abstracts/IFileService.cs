using Final_project_crud_endpoints.Contracts;

namespace Final_project_crud_endpoints.Services.Abstracts
{
    public interface IFileService
    {
        Task<string> UploadAsync(CustomUploadDirectories directories, IFormFile file, string password);
        Task<List<string>> UploadAsync(CustomUploadDirectories directories, IFormFileCollection files, string password);
        string ReadStaticFiles(string password, CustomUploadDirectories directories, string phisical_image_name);
        List<string> ReadStaticFiles(string password, CustomUploadDirectories directories, List<string> phisical_image_names);
        void RemoveStaticFiles(string password, CustomUploadDirectories directories,  string phisical_image_name);
        void RemoveStaticFiles(string password, CustomUploadDirectories directories, List<string> phisical_image_names);
    }
}
