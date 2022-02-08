using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;

namespace DataAccess.Extentions
{
    public static class ContextBuilderExtention
    {
        /// <summary>
        /// switching database provider according to Provider value in app.json
        /// </summary>
        /// <param name="optBuilder">extension for db options builder </param>
        /// <param name="services">services IOC dependence to append to </param>
        /// <param name="configuration">app config dependency </param>
        /// <param name="migrationAssemplyType">migration assmbly type </param>
        /// <returns></returns>
        public static DbContextOptionsBuilder SwitchProviderAndContext(this DbContextOptionsBuilder optBuilder,
                                                                      IServiceCollection services,
                                                                      IConfiguration configuration , 
                                                                      Type migrationAssemplyType)
        {
            var provider = configuration.GetValue("Provider", "SQLite");
            string path = Directory.GetCurrentDirectory();
            switch (provider)
            {
                case "SQLite":
                    services.AddEntityFrameworkSqlite();
                    string connectionString = configuration.GetConnectionString("sqllite")
                                                             .Replace("|DataDirectory|", path);
                    optBuilder
                        .UseSqlite(
                            connectionString, x => x.MigrationsAssembly(migrationAssemplyType.Name));
                    break;
                case "SQLServer":
                    services.AddEntityFrameworkSqlServer();
                    optBuilder
                        .UseSqlServer(
                            configuration.GetConnectionString("sqlserver"),
                            x => x.MigrationsAssembly(migrationAssemplyType.Name));
                    break;
                case "PostgreSql":
                    services.AddEntityFrameworkNpgsql();
                    optBuilder
                        .UseNpgsql(
                            configuration.GetConnectionString("postgresql"),
                            x => x.MigrationsAssembly(migrationAssemplyType.Name));
                    break;
                default: throw new Exception($"Unsupported provider: {provider}");
            }

            return optBuilder;
        }
    }
}
