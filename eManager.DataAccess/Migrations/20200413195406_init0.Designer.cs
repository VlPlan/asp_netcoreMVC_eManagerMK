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
    [Migration("20200413195406_init0")]
    partial class init0
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
                        new { Id = "b85a5e20-284d-4d31-96ac-9c6871f49baa", AccessFailedCount = 0, ConcurrencyStamp = "a5c0598d-86b9-47e6-bee7-35bd2c14c928", Email = "supplier@mail.com", EmailConfirmed = true, LockoutEnabled = false, NormalizedEmail = "supplier@mail.com", NormalizedUserName = "OGNO2020", PasswordHash = "AQAAAAEAACcQAAAAEMXbEg63FTuLQO1Gh52/Y+ovxMOsjyB+3fORfMfAiB0BxICSbEiNCx1+z3KUDMvLWw==", PhoneNumberConfirmed = false, SecurityStamp = "", TwoFactorEnabled = false, UserName = "ogno2020" },
                        new { Id = "5a3af8a1-9e8f-46d1-a4bd-e79ef5df0cc6", AccessFailedCount = 0, ConcurrencyStamp = "cfe9e827-ee5c-4f55-809e-d50cbfccd3f7", Email = "planojevic@ognootporno.com.mk", EmailConfirmed = true, FullName = "Владимир Планојевиќ", LockoutEnabled = false, NormalizedEmail = "PLANOJEVIC@OGNOOTPORNO.COM.MK", NormalizedUserName = "VPLAN", PasswordHash = "AQAAAAEAACcQAAAAEIU64n2ru855MYX4TGcLLLL2XA+nkMefbvBTXB9xNsktjyQgIhPEve0yVVPu8/ke1Q==", PhoneNumberConfirmed = false, SecurityStamp = "", TwoFactorEnabled = false, UserName = "VPlan" },
                        new { Id = "c6e785ec-accf-48bb-950b-cb4ee54a5e24", AccessFailedCount = 0, ConcurrencyStamp = "06531ae7-1a6f-45c2-9a8c-c6182f7685f8", Email = "nikolchov@ognootporno.com.mk", EmailConfirmed = true, FullName = "Сашо Николчов", LockoutEnabled = false, NormalizedEmail = "nikolchov@ognootporno.com.mk", NormalizedUserName = "SASHONIKOLCHOV", PasswordHash = "AQAAAAEAACcQAAAAEMIVQe2NESOoCbvjX3QZhPgLEsW7qPX5MLwRYmG4V+Rp8Xk52E8Wp/fSpYVptndqEQ==", PhoneNumberConfirmed = false, SecurityStamp = "", TwoFactorEnabled = false, UserName = "SashoNikolchov" },
                        new { Id = "b7a1a72a-13c5-497b-891f-c29882dc87a6", AccessFailedCount = 0, ConcurrencyStamp = "84055947-8389-4822-9f1d-0a6c6d5576d3", Email = "peshovski@ognootporno.com.mk", EmailConfirmed = true, FullName = "Тони Пешевски", LockoutEnabled = false, NormalizedEmail = "peshovski@ognootporno.com.mk", NormalizedUserName = "TONIPESHEVSKI", PasswordHash = "AQAAAAEAACcQAAAAEERLg8QZAwdqQBuOWoZOCbZmt6oOax1N3Zn5OenXuStCZbxTc5F6P/pKosyvwblXww==", PhoneNumberConfirmed = false, SecurityStamp = "", TwoFactorEnabled = false, UserName = "ToniPeshevski" },
                        new { Id = "e30343f2-1b54-4fdb-865b-697d5a1c9152", AccessFailedCount = 0, ConcurrencyStamp = "b0cbdc40-e6ff-4a6e-ad6b-af7f74f58381", Email = "mirkovska@ognootporno.com.mk", EmailConfirmed = true, FullName = "Ана Мирковска Гаврилов", LockoutEnabled = false, NormalizedEmail = "mirkovska@ognootporno.com.mk", NormalizedUserName = "ANAMIRKOVSKAGAVRILOV", PasswordHash = "AQAAAAEAACcQAAAAEKO2wLO+F29xHGxsNMgBh10wTGy84b0gsa7J4KRWK58AFOfbDXq/YG9M1WdYVjqI7A==", PhoneNumberConfirmed = false, SecurityStamp = "", TwoFactorEnabled = false, UserName = "AnaMGavrilov" },
                        new { Id = "ddc4fd39-bebe-436d-8080-c663f4d46509", AccessFailedCount = 0, ConcurrencyStamp = "1ec2d30c-f705-42b2-88cc-222cfd4d01a8", Email = "nikolchov@ognootporno.com.mk", EmailConfirmed = true, FullName = "Евтим Николчов", LockoutEnabled = false, NormalizedEmail = "nikolchov@ognootporno.com.mk", NormalizedUserName = "EVTIMNIKOLCHOV", PasswordHash = "AQAAAAEAACcQAAAAEHClXoE/+Rm0ZejYFGCb9TvuEkXMAcIkmFj/J/pEYZLPKP2Y44VpeI3bXsFkGapWdQ==", PhoneNumberConfirmed = false, SecurityStamp = "", TwoFactorEnabled = false, UserName = "EvtimNikolchov" },
                        new { Id = "f9173038-f3e8-4b40-9939-35095e896790", AccessFailedCount = 0, ConcurrencyStamp = "df72ac0f-e141-4fe2-90d7-64cfdadcc826", Email = "peshovski@ognootporno.com.mk", EmailConfirmed = true, FullName = "Сашо Пешовски", LockoutEnabled = false, NormalizedEmail = "peshovski@ognootporno.com.mk", NormalizedUserName = "SASHOPESHOVSKI", PasswordHash = "AQAAAAEAACcQAAAAEFXcM0PrR3dos5eCmS6hK6RgnbqTTv+97m8o+ahuAuYkibJtvX4kvy9ZV2lU1E+v6Q==", PhoneNumberConfirmed = false, SecurityStamp = "", TwoFactorEnabled = false, UserName = "SashoPeshovski" },
                        new { Id = "1ff13a7b-6045-4ead-a57c-3b67d3324b61", AccessFailedCount = 0, ConcurrencyStamp = "29024d71-d377-423c-aa63-ee9886d850e9", Email = "kotev@ognootporno.com.mk", EmailConfirmed = true, FullName = "Горан Котев", LockoutEnabled = false, NormalizedEmail = "kotev@ognootporno.com.mk", NormalizedUserName = "GORANKOTEV", PasswordHash = "AQAAAAEAACcQAAAAEFko8Rvl+4Dh5S+jYVCoJ1NIeUGz272KfHU3DPVX/UWjiI0ze6Ilk88HihEgqsYDYw==", PhoneNumberConfirmed = false, SecurityStamp = "", TwoFactorEnabled = false, UserName = "GoranKotev" },
                        new { Id = "7114bd33-522c-41e2-aa72-c12d300e2e43", AccessFailedCount = 0, ConcurrencyStamp = "3a73e952-5d18-48ef-86c6-213487270457", Email = "kotev@ognootporno.com.mk", EmailConfirmed = true, FullName = "Коста Котев", LockoutEnabled = false, NormalizedEmail = "kotev@ognootporno.com.mk", NormalizedUserName = "KOSTAKOTEV", PasswordHash = "AQAAAAEAACcQAAAAEG7hlV+XnBHxppr1z+Jmt8nTLxM3F9QgMfdLRuQeXkaSlv6fso8I3D6QE/5lImjKQw==", PhoneNumberConfirmed = false, SecurityStamp = "", TwoFactorEnabled = false, UserName = "KostaKotev" },
                        new { Id = "73cd2d67-53f7-48cd-b566-c0936a822164", AccessFailedCount = 0, ConcurrencyStamp = "466bb4a5-cf38-4c6e-97fe-4f4943a5f923", Email = "kotev@ognootporno.com.mk", EmailConfirmed = true, FullName = "Драге Ристевски", LockoutEnabled = false, NormalizedEmail = "kotev@ognootporno.com.mk", NormalizedUserName = "DRAGERISTEVSKI", PasswordHash = "AQAAAAEAACcQAAAAEGplxfJ7j4PONPjtJyCemEH40Uw30GpFbSuWFG8DwATt9xOwlmyWeKVG79tlho5A9w==", PhoneNumberConfirmed = false, SecurityStamp = "", TwoFactorEnabled = false, UserName = "DrageRistevski" }
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
                        new { Id = "a7e868fc-9cf3-4439-8740-8825365805f6", ConcurrencyStamp = "fed1b692-4d1e-4e2f-8eb4-dc1ce05e28b4", Name = "admin", NormalizedName = "ADMIN" },
                        new { Id = "15102fea-4516-4a5a-aef7-fcbcf293588c", ConcurrencyStamp = "57539c98-6f11-43ed-8a5b-cfb5cac759de", Name = "userVP", NormalizedName = "USERVP" },
                        new { Id = "24874b6b-ac40-4135-8ab2-98ee5fadb8e7", ConcurrencyStamp = "0b5c776f-23cf-4d2d-8cce-92cdf2fa98da", Name = "userSN", NormalizedName = "USERSN" },
                        new { Id = "d21ecdfd-789f-4eb1-b685-d709c6cea6fb", ConcurrencyStamp = "1aca1466-44a5-4e6d-952f-c44649c7e7f1", Name = "userTP", NormalizedName = "USERTP" },
                        new { Id = "e7b75401-ff26-42ce-b621-35f326e80ed1", ConcurrencyStamp = "95276fd2-bdac-492d-ad14-f3d51d22dd82", Name = "userAMG", NormalizedName = "USERAMG" },
                        new { Id = "ee8d437e-8a8a-4ebf-b485-f0cc2cf27086", ConcurrencyStamp = "d5010a7a-485a-4e08-b564-edd95ade7f52", Name = "userEN", NormalizedName = "USEREN" },
                        new { Id = "ca8c2669-62c7-48b9-bd9b-8ee544649c8b", ConcurrencyStamp = "a7348700-0f53-4455-8178-cc224a13f7a6", Name = "userSP", NormalizedName = "USERSP" },
                        new { Id = "b6358d4a-2745-4a53-a0ff-ec2b9f10251f", ConcurrencyStamp = "31e0a14e-80fc-4195-8708-b846aa9a8312", Name = "userGK", NormalizedName = "USERGK" },
                        new { Id = "802b7ff0-0973-4330-ad7c-de7de6fbe5df", ConcurrencyStamp = "4874d029-91b0-4b04-a80c-23c4b4635155", Name = "userKK", NormalizedName = "USERKK" },
                        new { Id = "02eb606f-b090-40dd-ae82-9f96199edade", ConcurrencyStamp = "9af3801f-7765-4c1f-9f8e-9b88668fa7ac", Name = "userDR", NormalizedName = "USERDR" }
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
                        new { UserId = "b85a5e20-284d-4d31-96ac-9c6871f49baa", RoleId = "a7e868fc-9cf3-4439-8740-8825365805f6" },
                        new { UserId = "5a3af8a1-9e8f-46d1-a4bd-e79ef5df0cc6", RoleId = "15102fea-4516-4a5a-aef7-fcbcf293588c" },
                        new { UserId = "c6e785ec-accf-48bb-950b-cb4ee54a5e24", RoleId = "24874b6b-ac40-4135-8ab2-98ee5fadb8e7" },
                        new { UserId = "b7a1a72a-13c5-497b-891f-c29882dc87a6", RoleId = "d21ecdfd-789f-4eb1-b685-d709c6cea6fb" },
                        new { UserId = "e30343f2-1b54-4fdb-865b-697d5a1c9152", RoleId = "e7b75401-ff26-42ce-b621-35f326e80ed1" },
                        new { UserId = "ddc4fd39-bebe-436d-8080-c663f4d46509", RoleId = "ee8d437e-8a8a-4ebf-b485-f0cc2cf27086" },
                        new { UserId = "1ff13a7b-6045-4ead-a57c-3b67d3324b61", RoleId = "b6358d4a-2745-4a53-a0ff-ec2b9f10251f" },
                        new { UserId = "7114bd33-522c-41e2-aa72-c12d300e2e43", RoleId = "802b7ff0-0973-4330-ad7c-de7de6fbe5df" },
                        new { UserId = "73cd2d67-53f7-48cd-b566-c0936a822164", RoleId = "02eb606f-b090-40dd-ae82-9f96199edade" }
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