using Final_project_crud_endpoints.DataBase;
using Final_project_crud_endpoints.Services.Abstracts;
using Final_project_crud_endpoints.Services.Concretes;
using Microsoft.EntityFrameworkCore;

namespace Final_project_crud_endpoints
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services
            .AddDbContext<DataContext>(ob =>
            {
                var connectionString = builder.Configuration.GetConnectionString("Default");

                ob.UseNpgsql(connectionString);
            })
             .AddScoped<IVerificationService, VerificationService>()
             .AddScoped<IFileService, FileService>()
             .AddHttpContextAccessor();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}