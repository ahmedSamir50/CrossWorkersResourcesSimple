
using DataAccess.WorkersDbContext;
using DataAccess.Extentions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;
using System.Reflection;
using ReposAndServ.Repository;
using ReposAndServ.Interfaces;
using DataAccess.Entities;
using ReposAndServ.UWorks;
using ReposAndServ.UWorks.UWRepos;
using EmailService;

namespace BookingSampleAPIs.Helpers.Extensions
{
    public static class ReposExtentions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="services">extension</param>
        /// <param name="configuration">app config. dependency </param>
        public static void InjectingServices(this IServiceCollection services, IConfiguration configuration )
        {
            var provider = configuration.GetValue("Provider", "SQLite");

            string path = Directory.GetCurrentDirectory();   
            services.AddDbContext<ResourcesDbContext>((serviceProvider, optBuilder) =>
           {
               optBuilder.SwitchProviderAndContext(services, configuration , typeof(ResourcesDbContext));
           });

            services.AddScoped<IBookingRepo, BookingRepo>();
            services.AddScoped<IResourceRepo, ResourcesRepo>();
            services.AddTransient<IResourceBookingsUWork, ResourceBookingsUWork>();
            services.AddSingleton<IEmailService, MockedEmailService>();
        }
    }
}
