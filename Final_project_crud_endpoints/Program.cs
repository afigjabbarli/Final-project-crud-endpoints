using Final_project_crud_endpoints.DataBase;
using Final_project_crud_endpoints.DataBase.Entities;
using Final_project_crud_endpoints.Services.Abstracts;
using Final_project_crud_endpoints.Services.Concretes;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Twilio.Base;

namespace Final_project_crud_endpoints
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);


            builder.Services.AddControllers();

            builder.Services
           .AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
           .AddCookie(options =>
           {
                options.Cookie.Name = "MyCustomCookie";
                options.LoginPath = "/auth/login";
                options.LogoutPath = "/auth/logout";
                options.ExpireTimeSpan = TimeSpan.FromHours(48); 
           });

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddLogging();

            builder.Services
            .AddDbContext<DataContext>(ob =>
            {
                var connectionString = builder.Configuration.GetConnectionString("Default");

                ob.UseNpgsql(connectionString);
            })
             .AddScoped<IVerificationService, VerificationService>()
             .AddScoped<IFileService, FileService>()
             .AddScoped<IEmailService, EmailService>()  
             .AddScoped<ISMSService, SMSService>()
             .AddScoped<IActivationService, ActivationService>()    
             .AddScoped<INotificationService, NotificationService>()
             .AddScoped<IUserService, UserService>()
             .AddHttpContextAccessor()

            .AddCors(options =>
            {
                options.AddPolicy("AllowAll",
                    builder =>
                    {
                        builder.AllowAnyOrigin()
                               .AllowAnyMethod()
                               .AllowAnyHeader();
                    });
            });

            builder.Services.Configure<ApiBehaviorOptions>(c =>
            {
                c.SuppressModelStateInvalidFilter = true;
            });

            var app = builder.Build();
            
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseStaticFiles();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseCors("AllowAll");

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}