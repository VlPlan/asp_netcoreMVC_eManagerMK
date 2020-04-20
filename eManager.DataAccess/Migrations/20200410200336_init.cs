using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eManager.DataAccess.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    FullName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ContactPerson = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Phone = table.Column<long>(nullable: false),
                    TaxNumber = table.Column<long>(nullable: false),
                    BankAccount = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Procurements",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<DateTime>(nullable: false),
                    Issuer = table.Column<string>(nullable: true),
                    ProcurementStatus = table.Column<int>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Procurements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Procurements_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<double>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    ImageUrl = table.Column<string>(nullable: true),
                    CompanyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProcurementProducts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProductId = table.Column<int>(nullable: false),
                    ProcurementId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProcurementProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProcurementProducts_Procurements_ProcurementId",
                        column: x => x.ProcurementId,
                        principalTable: "Procurements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProcurementProducts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeActivities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ActivityId = table.Column<int>(nullable: false),
                    EmployeeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeActivities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EmployeeNumber = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Username = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Salary = table.Column<long>(nullable: false),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    Department = table.Column<int>(nullable: false),
                    Phone = table.Column<long>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    IdCard = table.Column<string>(nullable: true),
                    Medical = table.Column<string>(nullable: true),
                    M1M2 = table.Column<string>(nullable: true),
                    HSafety = table.Column<string>(nullable: true),
                    ActivityId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Activities",
                columns: table => new
                {
                    ActivityId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true),
                    ClientId = table.Column<int>(nullable: true),
                    ClientSelected = table.Column<int>(nullable: false),
                    ClientName = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    Duration = table.Column<double>(nullable: false),
                    ActivityStatus = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activities", x => x.ActivityId);
                    table.ForeignKey(
                        name: "FK_Activities_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Invoices",
                columns: table => new
                {
                    InvoiceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    InvoiceNumber = table.Column<string>(nullable: true),
                    ClientId1 = table.Column<int>(nullable: true),
                    ClientId = table.Column<int>(nullable: false),
                    ClientAddress = table.Column<string>(nullable: true),
                    InvoiceDate = table.Column<DateTime>(nullable: false),
                    PaymentPeriod = table.Column<double>(nullable: false),
                    DueDate = table.Column<DateTime>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    ClientName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ClientInvoiceId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoices", x => x.InvoiceId);
                    table.ForeignKey(
                        name: "FK_Invoices_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Phone = table.Column<long>(nullable: false),
                    TaxNumber = table.Column<long>(nullable: false),
                    BankAccount = table.Column<long>(nullable: false),
                    LogoImage = table.Column<string>(nullable: true),
                    InvoiceId = table.Column<int>(nullable: false),
                    ClientInvoiceId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    ServiceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<double>(nullable: false),
                    Quantity = table.Column<double>(nullable: false),
                    Currency = table.Column<int>(nullable: false),
                    ClientId = table.Column<int>(nullable: false),
                    CurrencyRate = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.ServiceId);
                    table.ForeignKey(
                        name: "FK_Services_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClientInvoices",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClientId = table.Column<int>(nullable: false),
                    Invoice_Id = table.Column<int>(nullable: false),
                    ServiceId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientInvoices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClientInvoices_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientInvoices_Invoices_Invoice_Id",
                        column: x => x.Invoice_Id,
                        principalTable: "Invoices",
                        principalColumn: "InvoiceId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientInvoices_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "ServiceId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InvoiceServices",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    InvoiceId = table.Column<int>(nullable: false),
                    ServiceId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceServices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InvoiceServices_Invoices_InvoiceId",
                        column: x => x.InvoiceId,
                        principalTable: "Invoices",
                        principalColumn: "InvoiceId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InvoiceServices_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "ServiceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "14f21eb2-b3f5-423c-863e-0ac286f00043", "6529a5d4-714b-422d-946c-e947a341710f", "userDR", "USERDR" },
                    { "6dde67a6-453c-4221-ba4a-e5c3038eda99", "8dcc9720-ebc4-4901-8dee-e8fa1e1e24bc", "userGK", "USERGK" },
                    { "ef5f2352-0a90-416b-8c37-ce651819a571", "b19383d1-5a63-436c-ba22-c405f049e028", "userSP", "USERSP" },
                    { "38e4a280-2606-4232-8b10-e82be5f39f99", "15fd4df3-8e68-40bf-8e10-00ced617d66b", "userEN", "USEREN" },
                    { "d9cea0b9-3afd-4c47-8599-b528638c4e4b", "4bbf69dc-7610-420b-b82b-3de4312541f5", "userAMG", "USERAMG" },
                    { "c4f8f3df-a157-4ad1-964f-1d6fc8b6ba91", "1b444aae-e73c-41bc-aa73-80e296a8f3bb", "userTP", "USERTP" },
                    { "2d377119-95e9-4868-bfe4-ded2fe685b8f", "b6e36459-aaa3-4eda-907e-b077c025e772", "userSN", "USERSN" },
                    { "135e3dd5-f528-4263-aa42-5533de1750c0", "777fdf69-7992-4e5d-9f29-44e0005c3ca6", "userVP", "USERVP" },
                    { "01fb255f-5413-4d23-a317-2dae9b10a01d", "5a3dbea6-dbd3-4ff0-b182-6e662a73e451", "admin", "ADMIN" },
                    { "55906089-17ea-4e20-b30b-33688daaff6d", "6a1bc88a-5a43-497b-bc4c-e27f1a1983a9", "userKK", "USERKK" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "b0add26f-840d-408f-982f-a38a74ea91a2", 0, "a01445b0-33e2-477f-b6b8-0bd33d4533a9", "kotev@ognootporno.com.mk", true, "Драге Ристевски", false, null, "kotev@ognootporno.com.mk", "DRAGERISTEVSKI", "AQAAAAEAACcQAAAAEDKCofOgPzbAP3t9hcUhXoYYXvSTeQuvyzvWafysmGmpJGdJk7N9pmOeAKf5fWbxSA==", null, false, "", false, "Drage.Ristevski" },
                    { "f75d290f-ae0d-4d88-ac83-4d1c13bf7db7", 0, "61611b77-40f6-4758-82a4-2ade294c761b", "kotev@ognootporno.com.mk", true, "Горан Котев", false, null, "kotev@ognootporno.com.mk", "GORANKOTEV", "AQAAAAEAACcQAAAAEE+whJGOKhyLKDbzfgIyAbe4K4sdYEfshNS2HpfL+25Yn/YwmZ2+yLFohtDldtMIHA==", null, false, "", false, "Goran.Kotev" },
                    { "911a3508-feef-40f2-a9b2-87d70d404b89", 0, "86b75347-99bd-459b-9d13-aadd2c5f2122", "peshovski@ognootporno.com.mk", true, "Сашо Пешовски", false, null, "peshovski@ognootporno.com.mk", "SASHOPESHOVSKI", "AQAAAAEAACcQAAAAEDP1UsLtDBD1gO3s0Iy6fa7ERMIpgPU6Q4mc5J01ErssxXIpte0MaMw53btGI4ZRSw==", null, false, "", false, "Sasho.Peshovski" },
                    { "6fd2db35-3811-4c96-8faa-d051607abee3", 0, "23b84faa-c30e-4b0d-a107-db8758ce5ad9", "nikolchov@ognootporno.com.mk", true, "Евтим Николчов", false, null, "nikolchov@ognootporno.com.mk", "EVTIMNIKOLCHOV", "AQAAAAEAACcQAAAAEPdLsTztQu+CU/bNR/9HHKFE0Fypm+A0kLO2mK+xpnpThwSZ6Otn05w3uiruKp1UXw==", null, false, "", false, "Evtim.Nikolchov" },
                    { "f1b4491f-aea9-4f1f-8d7e-84ebf323afa1", 0, "94b5ff72-6ab0-4205-a397-75fc09c46bd3", "mirkovska@ognootporno.com.mk", true, "Ана Мирковска Гаврилов", false, null, "mirkovska@ognootporno.com.mk", "ANAMIRKOVSKAGAVRILOV", "AQAAAAEAACcQAAAAELaXYQeSVNnDswNnpE38XMdWPm8WqMrCkQxsTz0LCXrC353BuvcJrQ4t/3tNXn8ejQ==", null, false, "", false, "Ana.M.Gavrilov" },
                    { "b3a401b6-912d-4a70-b8e9-edc8ede1d86e", 0, "85370fa5-b6e0-4d29-9bb9-8c99912bab30", "peshovski@ognootporno.com.mk", true, "Тони Пешевски", false, null, "peshovski@ognootporno.com.mk", "TONIPESHEVSKI", "AQAAAAEAACcQAAAAEDGD+7+ZMKjmnct3qtf0Bt2DQwF2NsrwmWsqpeYZU19eovc2WmxyTHXiHXFg7TYj1A==", null, false, "", false, "Toni.Peshevski" },
                    { "d7f35dd1-1d33-4649-a9ac-9fab2096b73b", 0, "21beb960-9e1c-4c10-8476-cbca4d929693", "nikolchov@ognootporno.com.mk", true, "Сашо Николчов", false, null, "nikolchov@ognootporno.com.mk", "SASHONIKOLCHOV", "AQAAAAEAACcQAAAAEGv1vcwds0IqeEqXsWFXJqgelO/HoaPGpPxOEM8+VqMALSuRsgFNJujpK/8HHZkNCQ==", null, false, "", false, "Sasho.Nikolchov" },
                    { "057e31dd-1d64-41b9-8e48-c6d1313c92b0", 0, "c5ddb9dd-c324-475d-b5ab-5aae6a072500", "planojevic@ognootporno.com.mk", true, "Владимир Планојевиќ", false, null, "PLANOJEVIC@OGNOOTPORNO.COM.MK", "VPLAN", "AQAAAAEAACcQAAAAENkbww8ZlqifF3f0/0e9JegHBh18erQ2HqbSn8553BidUZ7F4qxx9vCer6DkAag4iw==", null, false, "", false, "VPlan" },
                    { "d6e29096-f531-4cc3-add3-1d7816666434", 0, "ef12cc7d-aa05-4086-bb68-8532ecd49a7f", "kotev@ognootporno.com.mk", true, "Коста Котев", false, null, "kotev@ognootporno.com.mk", "KOSTAKOTEV", "AQAAAAEAACcQAAAAEF4kuCM4BZvIIkjSmhL6ETheySm7SadeJhc534+2j3i7KWutBgGajA8w1ASMsf7CpQ==", null, false, "", false, "Kosta.Kotev" },
                    { "2306f620-402c-4ae9-8bca-07ed69d0d05c", 0, "8087a677-052e-49f2-94dc-47273ceea012", "supplier@mail.com", true, null, false, null, "supplier@mail.com", "@OGNO2020", "AQAAAAEAACcQAAAAEADdzsCmFlpgCWivJu5JhyVnBxZdY3UBi3sSrh8TZziHArZCKfdgCJJlCjQoB8s7wA==", null, false, "", false, "@ogno2020" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "2306f620-402c-4ae9-8bca-07ed69d0d05c", "01fb255f-5413-4d23-a317-2dae9b10a01d" },
                    { "057e31dd-1d64-41b9-8e48-c6d1313c92b0", "135e3dd5-f528-4263-aa42-5533de1750c0" },
                    { "d7f35dd1-1d33-4649-a9ac-9fab2096b73b", "2d377119-95e9-4868-bfe4-ded2fe685b8f" },
                    { "b3a401b6-912d-4a70-b8e9-edc8ede1d86e", "c4f8f3df-a157-4ad1-964f-1d6fc8b6ba91" },
                    { "f1b4491f-aea9-4f1f-8d7e-84ebf323afa1", "d9cea0b9-3afd-4c47-8599-b528638c4e4b" },
                    { "6fd2db35-3811-4c96-8faa-d051607abee3", "38e4a280-2606-4232-8b10-e82be5f39f99" },
                    { "f75d290f-ae0d-4d88-ac83-4d1c13bf7db7", "6dde67a6-453c-4221-ba4a-e5c3038eda99" },
                    { "d6e29096-f531-4cc3-add3-1d7816666434", "55906089-17ea-4e20-b30b-33688daaff6d" },
                    { "b0add26f-840d-408f-982f-a38a74ea91a2", "14f21eb2-b3f5-423c-863e-0ac286f00043" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Activities_ClientId",
                table: "Activities",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Activities_UserId",
                table: "Activities",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ClientInvoices_ClientId",
                table: "ClientInvoices",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientInvoices_ServiceId",
                table: "ClientInvoices",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientInvoices_Invoice_Id_ClientId",
                table: "ClientInvoices",
                columns: new[] { "Invoice_Id", "ClientId" });

            migrationBuilder.CreateIndex(
                name: "IX_Clients_ClientInvoiceId",
                table: "Clients",
                column: "ClientInvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeActivities_EmployeeId",
                table: "EmployeeActivities",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeActivities_ActivityId_EmployeeId",
                table: "EmployeeActivities",
                columns: new[] { "ActivityId", "EmployeeId" });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_ActivityId",
                table: "Employees",
                column: "ActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_ClientId1",
                table: "Invoices",
                column: "ClientId1");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_ClientInvoiceId",
                table: "Invoices",
                column: "ClientInvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_UserId",
                table: "Invoices",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceServices_ServiceId",
                table: "InvoiceServices",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceServices_InvoiceId_ServiceId",
                table: "InvoiceServices",
                columns: new[] { "InvoiceId", "ServiceId" });

            migrationBuilder.CreateIndex(
                name: "IX_ProcurementProducts_ProcurementId",
                table: "ProcurementProducts",
                column: "ProcurementId");

            migrationBuilder.CreateIndex(
                name: "IX_ProcurementProducts_ProductId_ProcurementId",
                table: "ProcurementProducts",
                columns: new[] { "ProductId", "ProcurementId" });

            migrationBuilder.CreateIndex(
                name: "IX_Procurements_UserId",
                table: "Procurements",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CompanyId",
                table: "Products",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Services_ClientId",
                table: "Services",
                column: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeActivities_Activities_ActivityId",
                table: "EmployeeActivities",
                column: "ActivityId",
                principalTable: "Activities",
                principalColumn: "ActivityId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeActivities_Employees_EmployeeId",
                table: "EmployeeActivities",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Activities_ActivityId",
                table: "Employees",
                column: "ActivityId",
                principalTable: "Activities",
                principalColumn: "ActivityId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Activities_Clients_ClientId",
                table: "Activities",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_Clients_ClientId1",
                table: "Invoices",
                column: "ClientId1",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_ClientInvoices_ClientInvoiceId",
                table: "Invoices",
                column: "ClientInvoiceId",
                principalTable: "ClientInvoices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_ClientInvoices_ClientInvoiceId",
                table: "Clients",
                column: "ClientInvoiceId",
                principalTable: "ClientInvoices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClientInvoices_Clients_ClientId",
                table: "ClientInvoices");

            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_Clients_ClientId1",
                table: "Invoices");

            migrationBuilder.DropForeignKey(
                name: "FK_Services_Clients_ClientId",
                table: "Services");

            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_AspNetUsers_UserId",
                table: "Invoices");

            migrationBuilder.DropForeignKey(
                name: "FK_ClientInvoices_Invoices_Invoice_Id",
                table: "ClientInvoices");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "EmployeeActivities");

            migrationBuilder.DropTable(
                name: "InvoiceServices");

            migrationBuilder.DropTable(
                name: "ProcurementProducts");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Procurements");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Activities");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Invoices");

            migrationBuilder.DropTable(
                name: "ClientInvoices");

            migrationBuilder.DropTable(
                name: "Services");
        }
    }
}
