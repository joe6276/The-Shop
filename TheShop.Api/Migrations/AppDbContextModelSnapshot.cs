﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TheShop.ApplicationDatabaseContext;

#nullable disable

namespace TheShop.Api.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TheShop.Entities.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Belgium"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Germany"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Netherlands"
                        },
                        new
                        {
                            Id = 4,
                            Name = "USA"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Japan"
                        },
                        new
                        {
                            Id = 6,
                            Name = "China"
                        },
                        new
                        {
                            Id = 7,
                            Name = "UK"
                        },
                        new
                        {
                            Id = 8,
                            Name = "France"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Brazil"
                        });
                });

            modelBuilder.Entity("TheShop.Entities.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("JobCategoryId")
                        .HasColumnType("int");

                    b.Property<double>("Latitude")
                        .HasColumnType("float");

                    b.Property<double>("Longitude")
                        .HasColumnType("float");

                    b.Property<int>("MaritalStatus")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("gender")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.HasIndex("JobCategoryId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "123, Atl",
                            City = "Atlanta",
                            CountryId = 1,
                            CreatedDate = new DateTime(2022, 12, 12, 9, 43, 35, 508, DateTimeKind.Local).AddTicks(6081),
                            Email = "john@gmail.com",
                            Image = "https://b.fssta.com/uploads/application/wwe/headshots/roman-reigns.png",
                            JobCategoryId = 3,
                            Latitude = 50.850299999999997,
                            Longitude = 4.3517000000000001,
                            MaritalStatus = 1,
                            Name = "John",
                            gender = 1
                        });
                });

            modelBuilder.Entity("TheShop.Entities.JobCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("JobCategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Pie research"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Sales"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Management"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Store staff"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Finance"
                        },
                        new
                        {
                            Id = 6,
                            Name = "QA"
                        },
                        new
                        {
                            Id = 7,
                            Name = "IT"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Cleaning"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Bakery"
                        });
                });

            modelBuilder.Entity("TheShop.Entities.Employee", b =>
                {
                    b.HasOne("TheShop.Entities.Country", "Country")
                        .WithMany("Employees")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TheShop.Entities.JobCategory", "JobCategory")
                        .WithMany("Employees")
                        .HasForeignKey("JobCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");

                    b.Navigation("JobCategory");
                });

            modelBuilder.Entity("TheShop.Entities.Country", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("TheShop.Entities.JobCategory", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
