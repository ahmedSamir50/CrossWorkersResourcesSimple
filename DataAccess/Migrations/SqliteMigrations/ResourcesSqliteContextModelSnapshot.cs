// <auto-generated />
using System;
using DataAccess.WorkersDbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccess.Migrations.SqliteMigrations
{
    [DbContext(typeof(ResourcesSqliteContext))]
    partial class ResourcesSqliteContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.13");

            modelBuilder.Entity("DataAccess.Entities.Booking", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BookedQuantity")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateFrom")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateTo")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("LastModifiedAt")
                        .HasColumnType("TEXT");

                    b.Property<int>("ResourceId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.HasIndex("ResourceId");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("DataAccess.Entities.Resource", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("LastModifiedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.HasIndex("Name");

                    b.ToTable("Resources");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CreatedAt = new DateTime(2022, 1, 22, 18, 27, 20, 209, DateTimeKind.Local).AddTicks(1490),
                            IsActive = true,
                            LastModifiedAt = new DateTime(2022, 2, 6, 18, 27, 20, 208, DateTimeKind.Local).AddTicks(9605),
                            Name = "Resource {1}",
                            Quantity = 8
                        },
                        new
                        {
                            ID = 2,
                            CreatedAt = new DateTime(2022, 1, 26, 18, 27, 20, 209, DateTimeKind.Local).AddTicks(2112),
                            IsActive = true,
                            LastModifiedAt = new DateTime(2022, 2, 6, 18, 27, 20, 209, DateTimeKind.Local).AddTicks(2095),
                            Name = "Resource {2}",
                            Quantity = 9
                        },
                        new
                        {
                            ID = 3,
                            CreatedAt = new DateTime(2022, 1, 18, 18, 27, 20, 209, DateTimeKind.Local).AddTicks(2124),
                            IsActive = true,
                            LastModifiedAt = new DateTime(2022, 2, 6, 18, 27, 20, 209, DateTimeKind.Local).AddTicks(2120),
                            Name = "Resource {3}",
                            Quantity = 9
                        },
                        new
                        {
                            ID = 4,
                            CreatedAt = new DateTime(2022, 1, 18, 18, 27, 20, 209, DateTimeKind.Local).AddTicks(2129),
                            IsActive = true,
                            LastModifiedAt = new DateTime(2022, 2, 6, 18, 27, 20, 209, DateTimeKind.Local).AddTicks(2126),
                            Name = "Resource {4}",
                            Quantity = 7
                        },
                        new
                        {
                            ID = 5,
                            CreatedAt = new DateTime(2022, 1, 25, 18, 27, 20, 209, DateTimeKind.Local).AddTicks(2137),
                            IsActive = true,
                            LastModifiedAt = new DateTime(2022, 2, 6, 18, 27, 20, 209, DateTimeKind.Local).AddTicks(2131),
                            Name = "Resource {5}",
                            Quantity = 7
                        },
                        new
                        {
                            ID = 6,
                            CreatedAt = new DateTime(2022, 1, 18, 18, 27, 20, 209, DateTimeKind.Local).AddTicks(2152),
                            IsActive = true,
                            LastModifiedAt = new DateTime(2022, 2, 6, 18, 27, 20, 209, DateTimeKind.Local).AddTicks(2149),
                            Name = "Resource {6}",
                            Quantity = 5
                        },
                        new
                        {
                            ID = 7,
                            CreatedAt = new DateTime(2022, 1, 27, 18, 27, 20, 209, DateTimeKind.Local).AddTicks(2157),
                            IsActive = true,
                            LastModifiedAt = new DateTime(2022, 2, 6, 18, 27, 20, 209, DateTimeKind.Local).AddTicks(2155),
                            Name = "Resource {7}",
                            Quantity = 8
                        },
                        new
                        {
                            ID = 8,
                            CreatedAt = new DateTime(2022, 1, 24, 18, 27, 20, 209, DateTimeKind.Local).AddTicks(2163),
                            IsActive = true,
                            LastModifiedAt = new DateTime(2022, 2, 6, 18, 27, 20, 209, DateTimeKind.Local).AddTicks(2160),
                            Name = "Resource {8}",
                            Quantity = 5
                        },
                        new
                        {
                            ID = 9,
                            CreatedAt = new DateTime(2022, 1, 23, 18, 27, 20, 209, DateTimeKind.Local).AddTicks(2168),
                            IsActive = true,
                            LastModifiedAt = new DateTime(2022, 2, 6, 18, 27, 20, 209, DateTimeKind.Local).AddTicks(2165),
                            Name = "Resource {9}",
                            Quantity = 8
                        },
                        new
                        {
                            ID = 10,
                            CreatedAt = new DateTime(2022, 1, 19, 18, 27, 20, 209, DateTimeKind.Local).AddTicks(2175),
                            IsActive = true,
                            LastModifiedAt = new DateTime(2022, 2, 6, 18, 27, 20, 209, DateTimeKind.Local).AddTicks(2172),
                            Name = "Resource {10}",
                            Quantity = 9
                        },
                        new
                        {
                            ID = 11,
                            CreatedAt = new DateTime(2022, 1, 27, 18, 27, 20, 209, DateTimeKind.Local).AddTicks(2180),
                            IsActive = true,
                            LastModifiedAt = new DateTime(2022, 2, 6, 18, 27, 20, 209, DateTimeKind.Local).AddTicks(2177),
                            Name = "Resource {11}",
                            Quantity = 5
                        },
                        new
                        {
                            ID = 12,
                            CreatedAt = new DateTime(2022, 1, 25, 18, 27, 20, 209, DateTimeKind.Local).AddTicks(2185),
                            IsActive = true,
                            LastModifiedAt = new DateTime(2022, 2, 6, 18, 27, 20, 209, DateTimeKind.Local).AddTicks(2182),
                            Name = "Resource {12}",
                            Quantity = 3
                        },
                        new
                        {
                            ID = 13,
                            CreatedAt = new DateTime(2022, 1, 18, 18, 27, 20, 209, DateTimeKind.Local).AddTicks(2189),
                            IsActive = true,
                            LastModifiedAt = new DateTime(2022, 2, 6, 18, 27, 20, 209, DateTimeKind.Local).AddTicks(2187),
                            Name = "Resource {13}",
                            Quantity = 7
                        },
                        new
                        {
                            ID = 14,
                            CreatedAt = new DateTime(2022, 1, 20, 18, 27, 20, 209, DateTimeKind.Local).AddTicks(2194),
                            IsActive = true,
                            LastModifiedAt = new DateTime(2022, 2, 6, 18, 27, 20, 209, DateTimeKind.Local).AddTicks(2192),
                            Name = "Resource {14}",
                            Quantity = 7
                        },
                        new
                        {
                            ID = 15,
                            CreatedAt = new DateTime(2022, 1, 21, 18, 27, 20, 209, DateTimeKind.Local).AddTicks(2199),
                            IsActive = true,
                            LastModifiedAt = new DateTime(2022, 2, 6, 18, 27, 20, 209, DateTimeKind.Local).AddTicks(2197),
                            Name = "Resource {15}",
                            Quantity = 4
                        },
                        new
                        {
                            ID = 16,
                            CreatedAt = new DateTime(2022, 1, 23, 18, 27, 20, 209, DateTimeKind.Local).AddTicks(2204),
                            IsActive = true,
                            LastModifiedAt = new DateTime(2022, 2, 6, 18, 27, 20, 209, DateTimeKind.Local).AddTicks(2202),
                            Name = "Resource {16}",
                            Quantity = 3
                        },
                        new
                        {
                            ID = 17,
                            CreatedAt = new DateTime(2022, 1, 24, 18, 27, 20, 209, DateTimeKind.Local).AddTicks(2209),
                            IsActive = true,
                            LastModifiedAt = new DateTime(2022, 2, 6, 18, 27, 20, 209, DateTimeKind.Local).AddTicks(2206),
                            Name = "Resource {17}",
                            Quantity = 8
                        },
                        new
                        {
                            ID = 18,
                            CreatedAt = new DateTime(2022, 1, 20, 18, 27, 20, 209, DateTimeKind.Local).AddTicks(2215),
                            IsActive = true,
                            LastModifiedAt = new DateTime(2022, 2, 6, 18, 27, 20, 209, DateTimeKind.Local).AddTicks(2212),
                            Name = "Resource {18}",
                            Quantity = 5
                        },
                        new
                        {
                            ID = 19,
                            CreatedAt = new DateTime(2022, 1, 27, 18, 27, 20, 209, DateTimeKind.Local).AddTicks(2220),
                            IsActive = true,
                            LastModifiedAt = new DateTime(2022, 2, 6, 18, 27, 20, 209, DateTimeKind.Local).AddTicks(2218),
                            Name = "Resource {19}",
                            Quantity = 1
                        });
                });

            modelBuilder.Entity("DataAccess.Entities.Booking", b =>
                {
                    b.HasOne("DataAccess.Entities.Resource", "Resource")
                        .WithMany("Bookings")
                        .HasForeignKey("ResourceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Resource");
                });

            modelBuilder.Entity("DataAccess.Entities.Resource", b =>
                {
                    b.Navigation("Bookings");
                });
#pragma warning restore 612, 618
        }
    }
}
