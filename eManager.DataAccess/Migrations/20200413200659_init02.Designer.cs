﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using eManager.DataAccess;

namespace eManager.DataAccess.Migrations
{
    [DbContext(typeof(ManagerDbContext))]
    [Migration("20200413200659_init02")]
    partial class init02
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("eManager.Domain.Activity", b =>
                {
                    b.Property<int>("ActivityId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ActivityStatus");

                    b.Property<int?>("ClientId");

                    b.Property<string>("ClientName");

                    b.Property<int>("ClientSelected");

                    b.Property<DateTime>("Date");

                    b.Property<string>("Description");

                    b.Property<double>("Duration");

                    b.Property<string>("UserId");

                    b.HasKey("ActivityId");

                    b.HasIndex("ClientId");

                    b.HasIndex("UserId");

                    b.ToTable("Activities");
                });

            modelBuilder.Entity("eManager.Domain.ActivityEmployee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ActivityId");

                    b.Property<int>("EmployeeId");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("ActivityId", "EmployeeId");

                    b.ToTable("EmployeeActivities");
                });

            modelBuilder.Entity("eManager.Domain.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<long>("BankAccount");

                    b.Property<int?>("ClientInvoiceId");

                    b.Property<string>("Description");

                    b.Property<string>("Email");

                    b.Property<int>("InvoiceId");

                    b.Property<string>("LogoImage");

                    b.Property<string>("Name");

                    b.Property<long>("Phone");

                    b.Property<long>("TaxNumber");

                    b.HasKey("Id");

                    b.HasIndex("ClientInvoiceId");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("eManager.Domain.ClientInvoice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClientId");

                    b.Property<int>("Invoice_Id");

                    b.Property<int?>("ServiceId");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("ServiceId");

                    b.HasIndex("Invoice_Id", "ClientId");

                    b.ToTable("ClientInvoices");
                });

            modelBuilder.Entity("eManager.Domain.ClientServiceDTO", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("InvoiceId");

                    b.Property<int>("ServiceId");

                    b.HasKey("Id");

                    b.HasIndex("ServiceId");

                    b.HasIndex("InvoiceId", "ServiceId");

                    b.ToTable("InvoiceServices");
                });

            modelBuilder.Entity("eManager.Domain.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<long>("BankAccount");

                    b.Property<string>("ContactPerson");

                    b.Property<string>("Description");

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.Property<long>("Phone");

                    b.Property<long>("TaxNumber");

                    b.HasKey("Id");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("eManager.Domain.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ActivityId");

                    b.Property<string>("Address");

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<int>("Department");

                    b.Property<string>("EmployeeNumber");

                    b.Property<string>("FirstName");

                    b.Property<string>("HSafety");

                    b.Property<string>("IdCard");

                    b.Property<string>("LastName");

                    b.Property<string>("M1M2");

                    b.Property<string>("Medical");

                    b.Property<string>("Password");

                    b.Property<long>("Phone");

                    b.Property<long>("Salary");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.HasIndex("ActivityId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("eManager.Domain.Invoice", b =>
                {
                    b.Property<int>("InvoiceId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClientAddress");

                    b.Property<int>("ClientId");

                    b.Property<int?>("ClientId1");

                    b.Property<int?>("ClientInvoiceId");

                    b.Property<string>("ClientName");

                    b.Property<string>("Description");

                    b.Property<DateTime>("DueDate");

                    b.Property<DateTime>("InvoiceDate");

                    b.Property<string>("InvoiceNumber");

                    b.Property<double>("PaymentPeriod");

                    b.Property<double>("Price");

                    b.Property<string>("UserId");

                    b.HasKey("InvoiceId");

                    b.HasIndex("ClientId1");

                    b.HasIndex("ClientInvoiceId");

                    b.HasIndex("UserId");

                    b.ToTable("Invoices");
                });

            modelBuilder.Entity("eManager.Domain.Procurement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date");

                    b.Property<string>("Issuer");

                    b.Property<double>("Price");

                    b.Property<int>("ProcurementStatus");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Procurements");
                });

            modelBuilder.Entity("eManager.Domain.ProcurementProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ProcurementId");

                    b.Property<int>("ProductId");

                    b.HasKey("Id");

                    b.HasIndex("ProcurementId");

                    b.HasIndex("ProductId", "ProcurementId");

                    b.ToTable("ProcurementProducts");
                });

            modelBuilder.Entity("eManager.Domain.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompanyId");

                    b.Property<string>("ImageUrl");

                    b.Property<string>("Name");

                    b.Property<double>("Price");

                    b.Property<int>("Quantity");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("eManager.Domain.Service", b =>
                {
                    b.Property<int>("ServiceId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClientId");

                    b.Property<int>("Currency");

                    b.Property<double>("CurrencyRate");

                    b.Property<string>("Name");

                    b.Property<double>("Price");

                    b.Property<double>("Quantity");

                    b.HasKey("ServiceId");

                    b.HasIndex("ClientId");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("eManager.Domain.User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FullName");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new { Id = "128f5de6-d04b-42cf-8616-c91675271364", AccessFailedCount = 0, ConcurrencyStamp = "5a0a547a-d18a-4f98-b0ca-d45335f39e54", Email = "supplier@mail.com", EmailConfirmed = true, LockoutEnabled = false, NormalizedEmail = "supplier@mail.com", NormalizedUserName = "Ognootporno2020", PasswordHash = "AQAAAAEAACcQAAAAEAqKSBVLiojDq92EAWK8wO/o4MHVJ3GGhHiNezzo1XfQ1uz/cpKbw8fVCgv8JEy2cQ==", PhoneNumberConfirmed = false, SecurityStamp = "", TwoFactorEnabled = false, UserName = "ogno2020" },
                        new { Id = "4f8b9fc7-8d07-4c7c-90f5-c9e7b85f67f3", AccessFailedCount = 0, ConcurrencyStamp = "4b9206e7-ac9e-45ac-9afb-f9a418a0e252", Email = "planojevic@ognootporno.com.mk", EmailConfirmed = true, FullName = "Владимир Планојевиќ", LockoutEnabled = false, NormalizedEmail = "PLANOJEVIC@OGNOOTPORNO.COM.MK", NormalizedUserName = "VPLAN", PasswordHash = "AQAAAAEAACcQAAAAEGpsS7iJZtrizR2A4c63iKviQbn+5NFy7FxHYbvE4KRKCjBMyN2ifR15sQo8yn0juA==", PhoneNumberConfirmed = false, SecurityStamp = "", TwoFactorEnabled = false, UserName = "VPlan" },
                        new { Id = "17ebd250-7a46-4111-9f24-1eee819e1b27", AccessFailedCount = 0, ConcurrencyStamp = "553684cc-eac7-4921-9572-1e2ec53c12f7", Email = "nikolchov@ognootporno.com.mk", EmailConfirmed = true, FullName = "Сашо Николчов", LockoutEnabled = false, NormalizedEmail = "nikolchov@ognootporno.com.mk", NormalizedUserName = "SASHONIKOLCHOV", PasswordHash = "AQAAAAEAACcQAAAAEJ1YZ/2nbP6V3bNOZWfUV/jKNv94L1yIePnblLnCabvNT6CCy5S9HIDjLkR+nFKlcQ==", PhoneNumberConfirmed = false, SecurityStamp = "", TwoFactorEnabled = false, UserName = "SashoNikolchov" },
                        new { Id = "12124c1b-3b0c-490f-af6e-9162a0c9484b", AccessFailedCount = 0, ConcurrencyStamp = "1143c591-f97d-43d6-91cc-2b9634f9d19e", Email = "peshovski@ognootporno.com.mk", EmailConfirmed = true, FullName = "Тони Пешевски", LockoutEnabled = false, NormalizedEmail = "peshovski@ognootporno.com.mk", NormalizedUserName = "TONIPESHEVSKI", PasswordHash = "AQAAAAEAACcQAAAAENLJolSRSw+3gWnLQ3Kk/Y5c0f9PKn4DC89y9WJUyWR4mbmngcvXxSJb87Sg1I8ctg==", PhoneNumberConfirmed = false, SecurityStamp = "", TwoFactorEnabled = false, UserName = "ToniPeshevski" },
                        new { Id = "c2c0cbd3-d55a-4a25-a478-814e57803adb", AccessFailedCount = 0, ConcurrencyStamp = "cc0b6c46-2652-4519-915f-4189cc0c9e3e", Email = "mirkovska@ognootporno.com.mk", EmailConfirmed = true, FullName = "Ана Мирковска Гаврилов", LockoutEnabled = false, NormalizedEmail = "mirkovska@ognootporno.com.mk", NormalizedUserName = "ANAMIRKOVSKAGAVRILOV", PasswordHash = "AQAAAAEAACcQAAAAEOx0xbK6WmHJjSvmRQLE5xvvIRm2DWZMQtxeiNXBF9kz0Ps0wdAQ2pKlLJ+u8q3JtQ==", PhoneNumberConfirmed = false, SecurityStamp = "", TwoFactorEnabled = false, UserName = "AnaMGavrilov" },
                        new { Id = "fddf4df1-ebe0-43ee-b8c7-2b4d114a504a", AccessFailedCount = 0, ConcurrencyStamp = "e2de6d41-a475-44fc-b33f-9a9e15800f0e", Email = "nikolchov@ognootporno.com.mk", EmailConfirmed = true, FullName = "Евтим Николчов", LockoutEnabled = false, NormalizedEmail = "nikolchov@ognootporno.com.mk", NormalizedUserName = "EVTIMNIKOLCHOV", PasswordHash = "AQAAAAEAACcQAAAAENuq09kT+Ga9n8zXOqQIg/Ah6f3EBvnGx9JZlfqaCNptAYSuIkdtakfBQnw0lRBzrQ==", PhoneNumberConfirmed = false, SecurityStamp = "", TwoFactorEnabled = false, UserName = "EvtimNikolchov" },
                        new { Id = "ed9e55c7-e443-4fe3-a3e2-b5746a7e268d", AccessFailedCount = 0, ConcurrencyStamp = "cbf815f3-bfd2-4d06-99ac-db3a71760541", Email = "peshovski@ognootporno.com.mk", EmailConfirmed = true, FullName = "Сашо Пешовски", LockoutEnabled = false, NormalizedEmail = "peshovski@ognootporno.com.mk", NormalizedUserName = "SASHOPESHOVSKI", PasswordHash = "AQAAAAEAACcQAAAAEBeM5Lc/jq6zQVMb6xniDmsu31KhoI7pYKEKVf9Oc23mSNR7o5QPsVnHwNLG1C6cUQ==", PhoneNumberConfirmed = false, SecurityStamp = "", TwoFactorEnabled = false, UserName = "SashoPeshovski" },
                        new { Id = "82d1c380-d6d6-4218-b8aa-ebad408f31b7", AccessFailedCount = 0, ConcurrencyStamp = "194e128e-30e2-4605-8361-cfd0957f82d2", Email = "kotev@ognootporno.com.mk", EmailConfirmed = true, FullName = "Горан Котев", LockoutEnabled = false, NormalizedEmail = "kotev@ognootporno.com.mk", NormalizedUserName = "GORANKOTEV", PasswordHash = "AQAAAAEAACcQAAAAEGaYsMqfexQRAVdc0vhEFndjD9ouk666UYreKYDkwGJ8X6ePFawV8MY83rqEZF0Hcw==", PhoneNumberConfirmed = false, SecurityStamp = "", TwoFactorEnabled = false, UserName = "GoranKotev" },
                        new { Id = "bde5b814-f4ae-4f88-83f3-e2024bbf9fc0", AccessFailedCount = 0, ConcurrencyStamp = "26cc6f22-73ce-41a7-bb90-d8081e3286a1", Email = "kotev@ognootporno.com.mk", EmailConfirmed = true, FullName = "Коста Котев", LockoutEnabled = false, NormalizedEmail = "kotev@ognootporno.com.mk", NormalizedUserName = "KOSTAKOTEV", PasswordHash = "AQAAAAEAACcQAAAAEM9ectx0/Mp1TFJmCAZa2tb/yDshGA91GKXypEasB3MNaadiUCpjKYKG68RwhUCNBg==", PhoneNumberConfirmed = false, SecurityStamp = "", TwoFactorEnabled = false, UserName = "KostaKotev" },
                        new { Id = "c9405584-4c9d-4eb5-a6c0-c79bd495d29a", AccessFailedCount = 0, ConcurrencyStamp = "09d15a17-8278-40e3-8916-d4c0645c17fa", Email = "kotev@ognootporno.com.mk", EmailConfirmed = true, FullName = "Драге Ристевски", LockoutEnabled = false, NormalizedEmail = "kotev@ognootporno.com.mk", NormalizedUserName = "DRAGERISTEVSKI", PasswordHash = "AQAAAAEAACcQAAAAEDDisj4bI8a40YHbfmHmkflYy3X15KEXT20Gp462VVT+Vy9BpxfpgjVPQJpAC8Xdkg==", PhoneNumberConfirmed = false, SecurityStamp = "", TwoFactorEnabled = false, UserName = "DrageRistevski" }
                    );
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new { Id = "69970900-67d4-47b5-84cd-ed3473619502", ConcurrencyStamp = "2619f647-4701-4b30-a425-a6c12bbc2ea1", Name = "admin", NormalizedName = "ADMIN" },
                        new { Id = "21921981-1a02-427f-9936-6524a6049b0a", ConcurrencyStamp = "3276b2fe-7253-4b5f-b0bf-451273476c61", Name = "userVP", NormalizedName = "USERVP" },
                        new { Id = "a4be411b-93dd-43b7-90e2-4b6c7d161f1c", ConcurrencyStamp = "cdb64235-3859-46c5-a62d-4e231e02705d", Name = "userSN", NormalizedName = "USERSN" },
                        new { Id = "e7c8a46b-550c-4297-91cb-387cdc1687ca", ConcurrencyStamp = "a24b1b20-0d74-4f07-9ba0-305e2dfa3e11", Name = "userTP", NormalizedName = "USERTP" },
                        new { Id = "66c626a0-67e5-4682-ae0d-24e0283a05c6", ConcurrencyStamp = "8e2be5a2-1f87-478d-9e21-5833b97c7247", Name = "userAMG", NormalizedName = "USERAMG" },
                        new { Id = "b47bcb71-c566-47fc-a533-303f9f4cb5a5", ConcurrencyStamp = "6e4b4836-543e-4bb2-8229-3c9cdf1cad38", Name = "userEN", NormalizedName = "USEREN" },
                        new { Id = "3d60807a-ca2f-4f63-bde0-238db7a27e09", ConcurrencyStamp = "eb906938-6562-4392-9afa-c05de0c763b0", Name = "userSP", NormalizedName = "USERSP" },
                        new { Id = "52ecf43f-9631-4121-8926-69d1216c9563", ConcurrencyStamp = "db205776-4e29-4e7b-8105-bacc8c7e602d", Name = "userGK", NormalizedName = "USERGK" },
                        new { Id = "737092a9-f972-43dd-b35c-beede74b480b", ConcurrencyStamp = "669694eb-eaa5-4753-9325-47011d63c255", Name = "userKK", NormalizedName = "USERKK" },
                        new { Id = "92a77ff3-61d5-4d66-b2fd-8a020fec0223", ConcurrencyStamp = "f38c9604-e322-400f-9772-08d8fc72a717", Name = "userDR", NormalizedName = "USERDR" }
                    );
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");

                    b.HasData(
                        new { UserId = "128f5de6-d04b-42cf-8616-c91675271364", RoleId = "69970900-67d4-47b5-84cd-ed3473619502" },
                        new { UserId = "4f8b9fc7-8d07-4c7c-90f5-c9e7b85f67f3", RoleId = "21921981-1a02-427f-9936-6524a6049b0a" },
                        new { UserId = "17ebd250-7a46-4111-9f24-1eee819e1b27", RoleId = "a4be411b-93dd-43b7-90e2-4b6c7d161f1c" },
                        new { UserId = "12124c1b-3b0c-490f-af6e-9162a0c9484b", RoleId = "e7c8a46b-550c-4297-91cb-387cdc1687ca" },
                        new { UserId = "c2c0cbd3-d55a-4a25-a478-814e57803adb", RoleId = "66c626a0-67e5-4682-ae0d-24e0283a05c6" },
                        new { UserId = "fddf4df1-ebe0-43ee-b8c7-2b4d114a504a", RoleId = "b47bcb71-c566-47fc-a533-303f9f4cb5a5" },
                        new { UserId = "82d1c380-d6d6-4218-b8aa-ebad408f31b7", RoleId = "52ecf43f-9631-4121-8926-69d1216c9563" },
                        new { UserId = "bde5b814-f4ae-4f88-83f3-e2024bbf9fc0", RoleId = "737092a9-f972-43dd-b35c-beede74b480b" },
                        new { UserId = "c9405584-4c9d-4eb5-a6c0-c79bd495d29a", RoleId = "92a77ff3-61d5-4d66-b2fd-8a020fec0223" }
                    );
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("eManager.Domain.Activity", b =>
                {
                    b.HasOne("eManager.Domain.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId");

                    b.HasOne("eManager.Domain.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("eManager.Domain.ActivityEmployee", b =>
                {
                    b.HasOne("eManager.Domain.Activity", "Activity")
                        .WithMany("EmployeeActivities")
                        .HasForeignKey("ActivityId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("eManager.Domain.Employee", "Employee")
                        .WithMany("EmployeeActivities")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("eManager.Domain.Client", b =>
                {
                    b.HasOne("eManager.Domain.ClientInvoice")
                        .WithMany("Clients")
                        .HasForeignKey("ClientInvoiceId");
                });

            modelBuilder.Entity("eManager.Domain.ClientInvoice", b =>
                {
                    b.HasOne("eManager.Domain.Client", "Client")
                        .WithMany("ClientInvoices")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("eManager.Domain.Invoice", "Invoice")
                        .WithMany("ClientInvoices")
                        .HasForeignKey("Invoice_Id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("eManager.Domain.Service")
                        .WithMany("ClientInvoices")
                        .HasForeignKey("ServiceId");
                });

            modelBuilder.Entity("eManager.Domain.ClientServiceDTO", b =>
                {
                    b.HasOne("eManager.Domain.Invoice", "Invoice")
                        .WithMany("InvoiceServices")
                        .HasForeignKey("InvoiceId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("eManager.Domain.Service", "Service")
                        .WithMany("InvoiceServices")
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("eManager.Domain.Employee", b =>
                {
                    b.HasOne("eManager.Domain.Activity")
                        .WithMany("allEmployees")
                        .HasForeignKey("ActivityId");
                });

            modelBuilder.Entity("eManager.Domain.Invoice", b =>
                {
                    b.HasOne("eManager.Domain.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId1");

                    b.HasOne("eManager.Domain.ClientInvoice")
                        .WithMany("Invoices")
                        .HasForeignKey("ClientInvoiceId");

                    b.HasOne("eManager.Domain.User", "User")
                        .WithMany("Invoices")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("eManager.Domain.Procurement", b =>
                {
                    b.HasOne("eManager.Domain.User", "User")
                        .WithMany("Procurements")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("eManager.Domain.ProcurementProduct", b =>
                {
                    b.HasOne("eManager.Domain.Procurement", "Procurement")
                        .WithMany("ProcurementProducts")
                        .HasForeignKey("ProcurementId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("eManager.Domain.Product", "Product")
                        .WithMany("ProcurementProducts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("eManager.Domain.Product", b =>
                {
                    b.HasOne("eManager.Domain.Company", "Company")
                        .WithMany("CompanyProducts")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("eManager.Domain.Service", b =>
                {
                    b.HasOne("eManager.Domain.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("eManager.Domain.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("eManager.Domain.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("eManager.Domain.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("eManager.Domain.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
