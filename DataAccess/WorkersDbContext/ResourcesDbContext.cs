using System;
using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.WorkersDbContext
{
    public class ResourcesDbContext : DbContext
    {
        // This CTOR just for migrations 
        //public ResourcesDbContext() { }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<Booking> Bookings{ get; set; }
        public ResourcesDbContext(DbContextOptions opt) : base(opt)
        {
            Console.WriteLine("*****************Cross Workers Context" + "********");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Resource>()
                        .HasMany(prop => prop.Bookings)
                        .WithOne(nav => nav.Resource);
            modelBuilder.Entity<Booking>()
                .HasOne(nav => nav.Resource)
                .WithMany(prop => prop.Bookings)
                .HasForeignKey(fk => fk.ResourceId);
        }
    }
}
