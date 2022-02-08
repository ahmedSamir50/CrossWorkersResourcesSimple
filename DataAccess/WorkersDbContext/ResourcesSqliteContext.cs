using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;

namespace DataAccess.WorkersDbContext
{
    public class ResourcesSqliteContext : ResourcesDbContext
    {
        // this CTOR just for migrations 
        // public ResourcesSqliteContext() : base() { }
        public ResourcesSqliteContext(DbContextOptions opt) : base(opt) {
            Console.WriteLine("***************** SqliteContext" + "********");
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder opt)
        {
            string path = Directory.GetCurrentDirectory();
            _ = opt.UseSqlite(@"Data Source=|DataDirectory|\\Db\\SqLiteDb\\WorkersDb.db"
                             .Replace("|DataDirectory|", path)
                             .Replace("DataAccess", "BookingSampleAPIs"));
        }

        protected override void OnModelCreating(ModelBuilder mdBuilder)
        {
            base.OnModelCreating(mdBuilder);
            // seed for mock data in sqlite 
            List<Resource> seedResources = new List<Resource>();
            FillResourcesSeedData(seedResources);
            mdBuilder.Entity<Resource>()
                      .HasData(seedResources);
        }

        private static void FillResourcesSeedData(List<Resource> seedResources)
        {
            Random rand = new Random();
            for (int i = 1; i < 20; i++)
            {
                seedResources.Add(new Resource
                {
                    ID = i,
                    Name = $"Resource {{{i}}}",
                    Quantity = rand.Next(1, 10),
                    CreatedAt = DateTime.Now.AddDays(rand.Next(10, 20) * -1)
                });
            }
        }
    }
}
