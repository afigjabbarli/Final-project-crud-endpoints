using Final_project_crud_endpoints.Contracts;
using Final_project_crud_endpoints.Services.Abstracts;

namespace Final_project_crud_endpoints.Services.Concretes
{
    public class FileService : IFileService
    {
        private readonly IWebHostEnvironment _environment;
        private readonly IHttpContextAccessor _accessor;
        private readonly string _current_directory;
        private readonly string _web_root_path;
        private readonly string _hostURL;
        public FileService(IWebHostEnvironment environment, IHttpContextAccessor accessor)
        {
            _environment = environment;
            _accessor = accessor;
            _current_directory = Directory.GetCurrentDirectory();   
            _web_root_path = _environment.WebRootPath;
            _hostURL = Path.Combine($"{_accessor.HttpContext!.Request.Scheme}:", $"{_accessor.HttpContext.Request.Host}{_accessor.HttpContext.Request.PathBase}");
        }
        private string StaticFilesDirectory(CustomUploadDirectories directories, string password)
        {
            return $"{Path.Combine(_current_directory, _web_root_path, "Upload", "images", directories.ToString(), password)}";
        }

        public async Task<string> UploadAsync(CustomUploadDirectories directories, IFormFile file, string password)
        {
            string file_directory = StaticFilesDirectory(directories, password), unique_file_name = string.Empty;

            try
            {
                if (!System.IO.Directory.Exists(file_directory))
                {
                    System.IO.Directory.CreateDirectory(file_directory);
                }
                unique_file_name = await UploadAsync(directories, file_directory, file);
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
            return unique_file_name;    
        }

        public async Task<List<string>> UploadAsync(CustomUploadDirectories directories, IFormFileCollection files, string password)
        {
            string file_directory = StaticFilesDirectory(directories, password);
            List<string> unique_file_names = new List<string>();

            try
            {
                if (!System.IO.Directory.Exists(file_directory))
                {
                    System.IO.Directory.CreateDirectory(file_directory);
                }
                foreach (var file in files)
                {
                    unique_file_names.Add(await UploadAsync(directories, file_directory, file));
                }
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
            return unique_file_names;   
        }

        private async Task<string> UploadAsync(CustomUploadDirectories directories, string file_directory, IFormFile file)
        {
            string unique_file_name = $"{directories}---{Guid.NewGuid()}.{Path.GetExtension(file.FileName)}";
            string Full_Path = Path.Combine(file_directory, unique_file_name);
            try
            {
                if (System.IO.File.Exists(Full_Path))
                {
                    System.IO.File.Delete(Full_Path);
                }
                using (FileStream stream = new FileStream(Full_Path, FileMode.Create, FileAccess.Write))
                {
                    await file.CopyToAsync(stream);
                    await stream.FlushAsync();
                }
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }

            return unique_file_name;
        }

        public string ReadStaticFiles(string password, CustomUploadDirectories directories, string phisical_image_name)
        {
            string file_URL = string.Empty;
            try
            {
                if(System.IO.Directory.Exists(StaticFilesDirectory(directories, password)))
                {
                    DirectoryInfo info = new DirectoryInfo(StaticFilesDirectory(directories, password));
                    FileInfo[] files = info.GetFiles();
                    var file = files.SingleOrDefault(f => f.Name.Equals(phisical_image_name));
                    if (file is not null)
                    {
                        string image_path = Path.Combine(StaticFilesDirectory(directories, password), file.Name);
                        if(System.IO.File.Exists(image_path))
                        {
                            string image_URL = _hostURL + $"/Upload/images/{directories}/" + password + "/" + file.Name;
                            file_URL = image_URL;   
                        }
                        else
                        {
                            throw new FileNotFoundException("File not found!: " + image_path);
                        }
                    }
                }
                else
                {
                    throw new DirectoryNotFoundException("Directory not found!: " + StaticFilesDirectory(directories, password));
                }
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
            return file_URL;
        }

        public List<string> ReadStaticFiles(string password, CustomUploadDirectories directories, List<string> phisical_image_names)
        {
            List<string> file_URLs = new List<string>();
            try
            {
                if(System.IO.Directory.Exists(StaticFilesDirectory(directories, password)))
                {
                    DirectoryInfo directoryInfo = new DirectoryInfo(StaticFilesDirectory(directories, password));
                    FileInfo[] files = directoryInfo.GetFiles();
                    foreach(string phisical_image_name in phisical_image_names)
                    {
                        var file = files.SingleOrDefault(f => f.Name.Equals(phisical_image_name));
                        if(file is not null)
                        {
                            string image_path = Path.Combine(StaticFilesDirectory(directories, password), file.Name);
                            if (System.IO.File.Exists(image_path))
                            {
                                string image_URL = _hostURL + $"/Upload/images/{directories}/" + password + "/" + file.Name;
                                file_URLs.Add(image_URL);
                            }
                            else
                            {
                                throw new FileNotFoundException("File not found!: " + image_path);
                            }
                        }
                    }
                }
                else
                {
                    throw new DirectoryNotFoundException("Directory not found!: " + StaticFilesDirectory(directories, password));
                }
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
            return file_URLs;
        }

        public void RemoveStaticFiles(string password, CustomUploadDirectories directories, string phisical_image_name)
        {
            string file_path = StaticFilesDirectory(directories, password);
            try
            {
                if (System.IO.Directory.Exists(file_path))
                {
                    DirectoryInfo directoryInfo = new DirectoryInfo(file_path);
                    FileInfo[] files = directoryInfo.GetFiles();    
                    var file = files.SingleOrDefault(f => f.Equals(phisical_image_name));
                    if(file is not null)
                    {
                        file.Delete();
                    }
                }
                else
                {
                    throw new DirectoryNotFoundException($"Directory not found!: {file_path}");
                }
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        public void RemoveStaticFiles(string password, CustomUploadDirectories directories, List<string> phisical_image_names)
        {
            string file_path = StaticFilesDirectory(directories, password);
            try
            {
                if (System.IO.Directory.Exists(file_path))
                {
                    DirectoryInfo directoryInfo = new DirectoryInfo(file_path);
                    FileInfo[] files = directoryInfo.GetFiles();
                    foreach (var phisical_image_name in phisical_image_names)
                    {
                        var file = files.SingleOrDefault(f => f.Name.Equals(phisical_image_name));
                        if(file is not null)
                        {
                            file.Delete();
                        }
                    }
                }
                else
                {
                    throw new DirectoryNotFoundException($"Directory not found!: {file_path}");
                }
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
    }
}
