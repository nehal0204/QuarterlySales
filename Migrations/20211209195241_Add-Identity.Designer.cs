﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QuarterlySales.Models;

namespace QuarterlySales.Migrations
{
    [DbContext(typeof(SalesContext))]
    [Migration("20211209195241_Add-Identity")]
    partial class AddIdentity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("QuarterlySales.Models.DataAcccess.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("QuarterlySales.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DOB")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateOfHire")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("ManagerId")
                        .HasColumnType("int");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeId = 1,
                            DOB = new DateTime(1956, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfHire = new DateTime(1995, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Firstname = "Ada",
                            Lastname = "Lovelace",
                            ManagerId = 0
                        },
                        new
                        {
                            EmployeeId = 2,
                            DOB = new DateTime(1966, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfHire = new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Firstname = "Katherine",
                            Lastname = "Johnson",
                            ManagerId = 1
                        },
                        new
                        {
                            EmployeeId = 3,
                            DOB = new DateTime(1975, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfHire = new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Firstname = "Grace",
                            Lastname = "Hopper",
                            ManagerId = 1
                        },
                        new
                        {
                            EmployeeId = 4,
                            DOB = new DateTime(1960, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfHire = new DateTime(1996, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Firstname = "Homer",
                            Lastname = "Simpson",
                            ManagerId = 0
                        },
                        new
                        {
                            EmployeeId = 5,
                            DOB = new DateTime(1980, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfHire = new DateTime(2002, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Firstname = "Bart",
                            Lastname = "Simpson",
                            ManagerId = 4
                        },
                        new
                        {
                            EmployeeId = 6,
                            DOB = new DateTime(1962, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfHire = new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Firstname = "Marge",
                            Lastname = "Simpson",
                            ManagerId = 0
                        },
                        new
                        {
                            EmployeeId = 7,
                            DOB = new DateTime(1982, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfHire = new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Firstname = "Lisa",
                            Lastname = "Simpson",
                            ManagerId = 6
                        },
                        new
                        {
                            EmployeeId = 8,
                            DOB = new DateTime(2005, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfHire = new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Firstname = "Maggie",
                            Lastname = "Simpson",
                            ManagerId = 6
                        });
                });

            modelBuilder.Entity("QuarterlySales.Models.Sales", b =>
                {
                    b.Property<int>("SalesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double?>("Amount")
                        .IsRequired()
                        .HasColumnType("float");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int?>("Quarter")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("Year")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("SalesId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Sales");

                    b.HasData(
                        new
                        {
                            SalesId = 1,
                            Amount = 23456.0,
                            EmployeeId = 2,
                            Quarter = 4,
                            Year = 2019
                        },
                        new
                        {
                            SalesId = 2,
                            Amount = 34567.0,
                            EmployeeId = 2,
                            Quarter = 1,
                            Year = 2020
                        },
                        new
                        {
                            SalesId = 3,
                            Amount = 19876.0,
                            EmployeeId = 3,
                            Quarter = 4,
                            Year = 2019
                        },
                        new
                        {
                            SalesId = 4,
                            Amount = 31009.0,
                            EmployeeId = 3,
                            Quarter = 1,
                            Year = 2020
                        },
                        new
                        {
                            SalesId = 5,
                            Amount = 33476.0,
                            EmployeeId = 4,
                            Quarter = 3,
                            Year = 2019
                        },
                        new
                        {
                            SalesId = 6,
                            Amount = 24555.0,
                            EmployeeId = 5,
                            Quarter = 2,
                            Year = 2020
                        },
                        new
                        {
                            SalesId = 7,
                            Amount = 29123.0,
                            EmployeeId = 6,
                            Quarter = 3,
                            Year = 2019
                        },
                        new
                        {
                            SalesId = 8,
                            Amount = 21111.0,
                            EmployeeId = 7,
                            Quarter = 4,
                            Year = 2020
                        },
                        new
                        {
                            SalesId = 9,
                            Amount = 33456.0,
                            EmployeeId = 6,
                            Quarter = 2,
                            Year = 2019
                        },
                        new
                        {
                            SalesId = 10,
                            Amount = 14567.0,
                            EmployeeId = 5,
                            Quarter = 3,
                            Year = 2020
                        },
                        new
                        {
                            SalesId = 11,
                            Amount = 29876.0,
                            EmployeeId = 4,
                            Quarter = 4,
                            Year = 2019
                        },
                        new
                        {
                            SalesId = 12,
                            Amount = 21009.0,
                            EmployeeId = 3,
                            Quarter = 1,
                            Year = 2020
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("QuarterlySales.Models.DataAcccess.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("QuarterlySales.Models.DataAcccess.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QuarterlySales.Models.DataAcccess.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("QuarterlySales.Models.DataAcccess.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("QuarterlySales.Models.Sales", b =>
                {
                    b.HasOne("QuarterlySales.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });
#pragma warning restore 612, 618
        }
    }
}