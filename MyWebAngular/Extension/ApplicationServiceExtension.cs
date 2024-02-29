using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyWebAngular.Core.Entities;
using MyWebAngular.Infrastructure.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace MyWebAngular.Extension
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddIdentityService(this IServiceCollection services, IConfiguration config)
        {

            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
            services.AddDbContext<AppIdentityDbContext>(option =>
            {
                option.UseSqlite(config.GetConnectionString("Connection"));
            });

            services.AddIdentity<Users, IdentityRole>(opt =>
            {
                // add identity option                 
                opt.Password.RequiredLength = 8;
                opt.Password.RequireNonAlphanumeric = false;
                opt.Password.RequireDigit = false;
                opt.Password.RequireUppercase = false;

            })
           .AddEntityFrameworkStores<AppIdentityDbContext>()
           .AddUserManager<UserManager<Users>>()
           .AddSignInManager<SignInManager<Users>>()
           .AddDefaultTokenProviders();


            services.AddCors(Opt =>
            {

                Opt.AddDefaultPolicy(opt =>
                {
                    opt.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin();
                });

                // Opt.AddDefaultPolicy("CorsPolicy", policy =>
                //  {
                //      policy.AllowAnyHeader().AllowAnyMethod().WithOrigins("http://localhost:4200/");
                //  });
            });

            return services;
        }
    }
}
