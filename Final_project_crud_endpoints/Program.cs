using Final_project_crud_endpoints.DataBase;
using Final_project_crud_endpoints.Services.Abstracts;
using Final_project_crud_endpoints.Services.Concretes;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.CookiePolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
               options.LoginPath = "/api/v1/users/auth/login";
               options.LogoutPath = "/api/v1/users/auth/logout";
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
                options.AddPolicy("AllowReactApp",
                    builder =>
                    {
                        builder.WithOrigins("http://localhost:3000")
                               .AllowAnyMethod()
                               .AllowAnyHeader()
                               .AllowCredentials();
                    });
            });

            builder.Services.Configure<CookiePolicyOptions>(options =>
            {
                options.MinimumSameSitePolicy = SameSiteMode.None;
                options.HttpOnly = HttpOnlyPolicy.Always;
                options.Secure = CookieSecurePolicy.Always;
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

            app.UseCors("AllowReactApp");

            app.UseHttpsRedirection();


            app.MapControllers();

            app.Run();
        }
    }
}