using Microsoft.EntityFrameworkCore.Migrations;

namespace eManager.DataAccess.Migrations
{
    public partial class initnew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "2794e124-461c-4d63-8121-6197ee1683ef", "3912a6bc-f6c5-40cb-8ff1-5beeef3859f9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "185d64aa-db0d-4a7d-9a89-792bbf33b7ae", "f49f437a-6ca0-4ca7-a21f-9395b15bf5c3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "2e1976bf-93f8-4e2a-8ac7-e29a0e4a1ed8", "4f969c79-23bd-4ce8-8bf3-b4bd69309fd6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "31028a3e-3afb-4653-a5c7-758343683650", "3212517b-07bc-4b24-a6ae-c976e813dbf5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "4223e5d7-fc9b-4a90-b7bf-8a0e9daefa9e", "f944c33e-f5ec-401c-9141-37ad63561247" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "52cab57d-0802-4c34-8ea3-ea62eb77478b", "a6fa8965-4da2-44ab-940c-ce55deeb638d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "94fe86e7-c60f-4218-ac49-b67ec0c842a7", "d6da68ae-919b-4e3f-9282-766ab9502073" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "be6d7a8d-68a1-4909-b03c-9403e1b35df9", "067da460-f68c-4068-aea3-989c57b97dbe" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "e7208c3c-793b-40a3-aaaf-d328370151a9", "814104df-f5bf-4e2a-9661-e01ce8102652" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "eea0fa3c-f67e-45a9-bf76-0b6547481334", "f3710608-4fea-44c1-a4ef-d668444901cf" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "e84c5dc5-ab13-48f5-a5c7-139cb61e8aae", "f4618f2d-0540-45ac-93e3-a38280db6c60" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "067da460-f68c-4068-aea3-989c57b97dbe", "b5f07cfe-54c2-41c6-8365-3cd6e3102b28" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "3212517b-07bc-4b24-a6ae-c976e813dbf5", "688f9a5d-6bcf-49cd-960e-b33c084b4e6a" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "4f969c79-23bd-4ce8-8bf3-b4bd69309fd6", "ff4087ef-3dad-4471-a4ee-64b8ac1b3b20" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "814104df-f5bf-4e2a-9661-e01ce8102652", "486767a3-7435-43a0-be0c-fba8fe634f9d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "a6fa8965-4da2-44ab-940c-ce55deeb638d", "259bba5f-cb37-4486-855a-fa11b5f9df15" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "d6da68ae-919b-4e3f-9282-766ab9502073", "a1e675a5-4125-479e-946f-f2400473fbcf" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "f3710608-4fea-44c1-a4ef-d668444901cf", "b5bd6888-6223-41f8-ac53-f4e5e3c3191d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "f49f437a-6ca0-4ca7-a21f-9395b15bf5c3", "8fc6e163-0463-407b-9a14-31e429c4b29a" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "f944c33e-f5ec-401c-9141-37ad63561247", "0f38327a-7a35-4591-8441-33165ac5008a" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "185d64aa-db0d-4a7d-9a89-792bbf33b7ae", "94e1dd75-474c-4284-a96f-b448e7142c01" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "2e1976bf-93f8-4e2a-8ac7-e29a0e4a1ed8", "7e77618d-39bc-4c5b-96e4-9d30be4819ff" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "31028a3e-3afb-4653-a5c7-758343683650", "6352df2d-4645-4bdf-ac91-7b3430a4779f" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "4223e5d7-fc9b-4a90-b7bf-8a0e9daefa9e", "5b6413aa-f619-4c52-85fb-b8e2fc05157f" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "52cab57d-0802-4c34-8ea3-ea62eb77478b", "e1d00ffe-f0dd-4a47-91e3-8fce7bf25001" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "94fe86e7-c60f-4218-ac49-b67ec0c842a7", "818c5c48-9751-46c9-9e06-7a5411f69372" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "be6d7a8d-68a1-4909-b03c-9403e1b35df9", "73622af1-d05b-4f9a-90cc-47d683c17083" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "e7208c3c-793b-40a3-aaaf-d328370151a9", "424d940c-0b1c-4999-8552-a4c6bfd4018a" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "eea0fa3c-f67e-45a9-bf76-0b6547481334", "52914484-05a3-4cab-bb7a-4fa2b5485f95" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "eeaf85a8-3d14-41b6-a9d1-3c6caa3f00a1", "6c2cd49a-cfa0-4967-b0e6-635aaa4fe2a9", "userDR", "USERDR" },
                    { "a24b398c-9c99-4406-a484-3285f5fc8178", "59fb5034-b200-460e-85fe-18e4c0d681f4", "userGK", "USERGK" },
                    { "05d7ce41-42b4-4043-bcdc-8116a2b83146", "c62ce2af-9b29-4adf-876f-507b216e5f8a", "userSP", "USERSP" },
                    { "cf561a68-2e88-4762-879b-b951b59a234c", "ca689887-d521-4620-a87d-3a9986eed499", "userEN", "USEREN" },
                    { "9f318d62-c535-4233-a396-f1272fe94a21", "9ba99a48-75aa-4c4d-8138-d4818053b71c", "userAMG", "USERAMG" },
                    { "e2bee1ea-bfdf-46bf-829d-f7c1a815243c", "c1c696e2-cac1-41c2-8557-f5bb25935fc6", "userTP", "USERTP" },
                    { "3db1c953-9e5b-46c1-95e2-815e7c6db7c3", "aaf96334-dff0-43a3-be26-98e0b020fae1", "userSN", "USERSN" },
                    { "9f0043ba-190d-43ab-8c7f-31458b639be4", "aeb64680-6927-4b25-9679-18d5d50646a1", "userVP", "USERVP" },
                    { "8d3d2e83-932a-4228-a315-09f1636759e2", "6df06a83-de69-47bd-bc63-094bf48b2602", "admin", "ADMIN" },
                    { "99156a79-cc63-4ad4-8008-863e53736a8a", "712b86c2-abb3-457d-b25e-d32ee85cddf0", "userKK", "USERKK" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "bc213130-243f-4386-a421-3560e00edaf6", 0, "f07a4616-a346-4442-82f5-6c28967544f2", "kotev@ognootporno.com.mk", true, "Драге Ристевски", false, null, "kotev@ognootporno.com.mk", "DRAGERISTEVSKI", "AQAAAAEAACcQAAAAENW1fQz7M0tdhRdy9WggJgu1RB9zYwqyYWKGcBEAiRj73cYfIk4VlzAFa8hiTQ2Prw==", null, false, "", false, "DrageRistevski" },
                    { "46846f57-fd34-4135-a343-a65a072c8615", 0, "51a0c86e-6ce4-485d-a978-e8b1a91c3763", "kotev@ognootporno.com.mk", true, "Горан Котев", false, null, "kotev@ognootporno.com.mk", "GORANKOTEV", "AQAAAAEAACcQAAAAEOqnn8RaJw4hKn1W2P23goOsnbl928ZuZmnaUQLpZ1Dk/N3w9z1YZOH18m1nksSjtQ==", null, false, "", false, "GoranKotev" },
                    { "b3069995-cb18-4296-8444-9c59ccc74b99", 0, "621467b1-549c-46ae-b026-9ac04c4c8a71", "peshovski@ognootporno.com.mk", true, "Сашо Пешовски", false, null, "peshovski@ognootporno.com.mk", "SASHOPESHOVSKI", "AQAAAAEAACcQAAAAEKkt63EWX+cCHDsulr2KvDF76MNnn+MVgLPBHeQHWEMP4eEPf6xB+Lj7qSSMXCHCGw==", null, false, "", false, "SashoPeshovski" },
                    { "d223c8f5-2e1e-4c16-8633-a943b1126ae2", 0, "81940b53-cdd7-4dc4-82c5-e4150e84d33a", "nikolchov@ognootporno.com.mk", true, "Евтим Николчов", false, null, "nikolchov@ognootporno.com.mk", "EVTIMNIKOLCHOV", "AQAAAAEAACcQAAAAEBwrZrKNujByOcQnqFMxqm7rhjXOnoqreZkqmOyq7f+3SKAYtCSnIxnoH6+cfFCulA==", null, false, "", false, "EvtimNikolchov" },
                    { "a16b3554-05bf-4590-91bb-37133197427d", 0, "b900ccdc-51fb-4bc9-a5cb-abe8951807f0", "mirkovska@ognootporno.com.mk", true, "Ана Мирковска Гаврилов", false, null, "mirkovska@ognootporno.com.mk", "ANAMIRKOVSKAGAVRILOV", "AQAAAAEAACcQAAAAENf9i1Bj99B0tg+oHrEmerXeTt6rVmvWkIs93BTrP3NE2svhrYG4po62l3c1CEF+5Q==", null, false, "", false, "AnaMGavrilov" },
                    { "011b8b40-3b28-4c08-ace8-3198f5a9af43", 0, "96899208-6521-49db-aa74-d2eb414642dc", "peshovski@ognootporno.com.mk", true, "Тони Пешевски", false, null, "peshovski@ognootporno.com.mk", "TONIPESHEVSKI", "AQAAAAEAACcQAAAAEFRwrelnJQuWe8h3e35UoL5zOthMoeao5rGQVxnKsGXmoSCOc7WS65AmRYlQKqdG4g==", null, false, "", false, "ToniPeshevski" },
                    { "7980c992-92c4-449b-bb4b-06e95cd74e6e", 0, "7f18aea1-2bad-4dd4-8488-b55f929b8e71", "nikolchov@ognootporno.com.mk", true, "Сашо Николчов", false, null, "nikolchov@ognootporno.com.mk", "SASHONIKOLCHOV", "AQAAAAEAACcQAAAAEGfGMED/wk7C5TGxjjsMERrSlInIVynteb82PPJ9Tl/nu9HpvZvjP7xYwD9HpPHRxw==", null, false, "", false, "SashoNikolchov" },
                    { "948b430d-a8cb-4499-bdde-7df53d609f4e", 0, "a4fc570e-67f4-4b26-b24c-ebbe40e1d8f2", "planojevic@ognootporno.com.mk", true, "Владимир Планојевиќ", false, null, "PLANOJEVIC@OGNOOTPORNO.COM.MK", "VPLAN", "AQAAAAEAACcQAAAAEBfOf4ctWV7tr2RDUA9emzcKztFyMNxc1fuL5Go6/nGHwnPAXlQSQXIVl6HXqfMH1g==", null, false, "", false, "VPlan" },
                    { "074a2a26-1020-4217-a621-dfe56a20d0ed", 0, "2d995a8d-7126-4d0e-b3c2-0933c587a5db", "kotev@ognootporno.com.mk", true, "Коста Котев", false, null, "kotev@ognootporno.com.mk", "KOSTAKOTEV", "AQAAAAEAACcQAAAAEBRbUw4qvCgKi2dY59OPCa12ToH9iWovkjAT55JfuW/VmiUgDJZXSEfErUQv7cH1+g==", null, false, "", false, "KostaKotev" },
                    { "f39e18e4-4039-4abc-a0bc-326d6cf23601", 0, "f6d424db-9856-424f-ac5a-43508988a9e2", "supplier@mail.com", true, null, false, null, "supplier@mail.com", "OGNO2020", "AQAAAAEAACcQAAAAEKSjIk5PUMBAzCqLqSkoVvNXbyCZ4MSvR3UwE057GEFreyd2QA8/EyZlp80Y9ayfug==", null, false, "", false, "ogno2020" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "f39e18e4-4039-4abc-a0bc-326d6cf23601", "8d3d2e83-932a-4228-a315-09f1636759e2" },
                    { "948b430d-a8cb-4499-bdde-7df53d609f4e", "9f0043ba-190d-43ab-8c7f-31458b639be4" },
                    { "7980c992-92c4-449b-bb4b-06e95cd74e6e", "3db1c953-9e5b-46c1-95e2-815e7c6db7c3" },
                    { "011b8b40-3b28-4c08-ace8-3198f5a9af43", "e2bee1ea-bfdf-46bf-829d-f7c1a815243c" },
                    { "a16b3554-05bf-4590-91bb-37133197427d", "9f318d62-c535-4233-a396-f1272fe94a21" },
                    { "d223c8f5-2e1e-4c16-8633-a943b1126ae2", "cf561a68-2e88-4762-879b-b951b59a234c" },
                    { "46846f57-fd34-4135-a343-a65a072c8615", "a24b398c-9c99-4406-a484-3285f5fc8178" },
                    { "074a2a26-1020-4217-a621-dfe56a20d0ed", "99156a79-cc63-4ad4-8008-863e53736a8a" },
                    { "bc213130-243f-4386-a421-3560e00edaf6", "eeaf85a8-3d14-41b6-a9d1-3c6caa3f00a1" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "05d7ce41-42b4-4043-bcdc-8116a2b83146", "c62ce2af-9b29-4adf-876f-507b216e5f8a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "011b8b40-3b28-4c08-ace8-3198f5a9af43", "e2bee1ea-bfdf-46bf-829d-f7c1a815243c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "074a2a26-1020-4217-a621-dfe56a20d0ed", "99156a79-cc63-4ad4-8008-863e53736a8a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "46846f57-fd34-4135-a343-a65a072c8615", "a24b398c-9c99-4406-a484-3285f5fc8178" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "7980c992-92c4-449b-bb4b-06e95cd74e6e", "3db1c953-9e5b-46c1-95e2-815e7c6db7c3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "948b430d-a8cb-4499-bdde-7df53d609f4e", "9f0043ba-190d-43ab-8c7f-31458b639be4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a16b3554-05bf-4590-91bb-37133197427d", "9f318d62-c535-4233-a396-f1272fe94a21" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "bc213130-243f-4386-a421-3560e00edaf6", "eeaf85a8-3d14-41b6-a9d1-3c6caa3f00a1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "d223c8f5-2e1e-4c16-8633-a943b1126ae2", "cf561a68-2e88-4762-879b-b951b59a234c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "f39e18e4-4039-4abc-a0bc-326d6cf23601", "8d3d2e83-932a-4228-a315-09f1636759e2" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "b3069995-cb18-4296-8444-9c59ccc74b99", "621467b1-549c-46ae-b026-9ac04c4c8a71" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "3db1c953-9e5b-46c1-95e2-815e7c6db7c3", "aaf96334-dff0-43a3-be26-98e0b020fae1" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "8d3d2e83-932a-4228-a315-09f1636759e2", "6df06a83-de69-47bd-bc63-094bf48b2602" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "99156a79-cc63-4ad4-8008-863e53736a8a", "712b86c2-abb3-457d-b25e-d32ee85cddf0" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "9f0043ba-190d-43ab-8c7f-31458b639be4", "aeb64680-6927-4b25-9679-18d5d50646a1" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "9f318d62-c535-4233-a396-f1272fe94a21", "9ba99a48-75aa-4c4d-8138-d4818053b71c" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "a24b398c-9c99-4406-a484-3285f5fc8178", "59fb5034-b200-460e-85fe-18e4c0d681f4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "cf561a68-2e88-4762-879b-b951b59a234c", "ca689887-d521-4620-a87d-3a9986eed499" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "e2bee1ea-bfdf-46bf-829d-f7c1a815243c", "c1c696e2-cac1-41c2-8557-f5bb25935fc6" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "eeaf85a8-3d14-41b6-a9d1-3c6caa3f00a1", "6c2cd49a-cfa0-4967-b0e6-635aaa4fe2a9" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "011b8b40-3b28-4c08-ace8-3198f5a9af43", "96899208-6521-49db-aa74-d2eb414642dc" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "074a2a26-1020-4217-a621-dfe56a20d0ed", "2d995a8d-7126-4d0e-b3c2-0933c587a5db" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "46846f57-fd34-4135-a343-a65a072c8615", "51a0c86e-6ce4-485d-a978-e8b1a91c3763" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "7980c992-92c4-449b-bb4b-06e95cd74e6e", "7f18aea1-2bad-4dd4-8488-b55f929b8e71" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "948b430d-a8cb-4499-bdde-7df53d609f4e", "a4fc570e-67f4-4b26-b24c-ebbe40e1d8f2" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "a16b3554-05bf-4590-91bb-37133197427d", "b900ccdc-51fb-4bc9-a5cb-abe8951807f0" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "bc213130-243f-4386-a421-3560e00edaf6", "f07a4616-a346-4442-82f5-6c28967544f2" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "d223c8f5-2e1e-4c16-8633-a943b1126ae2", "81940b53-cdd7-4dc4-82c5-e4150e84d33a" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "f39e18e4-4039-4abc-a0bc-326d6cf23601", "f6d424db-9856-424f-ac5a-43508988a9e2" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "814104df-f5bf-4e2a-9661-e01ce8102652", "486767a3-7435-43a0-be0c-fba8fe634f9d", "userDR", "USERDR" },
                    { "067da460-f68c-4068-aea3-989c57b97dbe", "b5f07cfe-54c2-41c6-8365-3cd6e3102b28", "userGK", "USERGK" },
                    { "2794e124-461c-4d63-8121-6197ee1683ef", "3912a6bc-f6c5-40cb-8ff1-5beeef3859f9", "userSP", "USERSP" },
                    { "f3710608-4fea-44c1-a4ef-d668444901cf", "b5bd6888-6223-41f8-ac53-f4e5e3c3191d", "userEN", "USEREN" },
                    { "f944c33e-f5ec-401c-9141-37ad63561247", "0f38327a-7a35-4591-8441-33165ac5008a", "userAMG", "USERAMG" },
                    { "3212517b-07bc-4b24-a6ae-c976e813dbf5", "688f9a5d-6bcf-49cd-960e-b33c084b4e6a", "userTP", "USERTP" },
                    { "d6da68ae-919b-4e3f-9282-766ab9502073", "a1e675a5-4125-479e-946f-f2400473fbcf", "userSN", "USERSN" },
                    { "f49f437a-6ca0-4ca7-a21f-9395b15bf5c3", "8fc6e163-0463-407b-9a14-31e429c4b29a", "userVP", "USERVP" },
                    { "a6fa8965-4da2-44ab-940c-ce55deeb638d", "259bba5f-cb37-4486-855a-fa11b5f9df15", "admin", "ADMIN" },
                    { "4f969c79-23bd-4ce8-8bf3-b4bd69309fd6", "ff4087ef-3dad-4471-a4ee-64b8ac1b3b20", "userKK", "USERKK" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "e7208c3c-793b-40a3-aaaf-d328370151a9", 0, "424d940c-0b1c-4999-8552-a4c6bfd4018a", "kotev@ognootporno.com.mk", true, "Драге Ристевски", false, null, "kotev@ognootporno.com.mk", "DRAGERISTEVSKI", "AQAAAAEAACcQAAAAEHh5CaS5BJhOQ0ifFgxue2SI7VuxqM3NdeqysdDRSScOhX0D6/BLKtJwRyvjYR2JrA==", null, false, "", false, "DrageRistevski" },
                    { "be6d7a8d-68a1-4909-b03c-9403e1b35df9", 0, "73622af1-d05b-4f9a-90cc-47d683c17083", "kotev@ognootporno.com.mk", true, "Горан Котев", false, null, "kotev@ognootporno.com.mk", "GORANKOTEV", "AQAAAAEAACcQAAAAEIXpQweIdyZ/5KTzRiMFb/VkNwhmDmUQ1vzMMw7nEDC+491JcXesYVl7Bg5Q7wI4IQ==", null, false, "", false, "GoranKotev" },
                    { "e84c5dc5-ab13-48f5-a5c7-139cb61e8aae", 0, "f4618f2d-0540-45ac-93e3-a38280db6c60", "peshovski@ognootporno.com.mk", true, "Сашо Пешовски", false, null, "peshovski@ognootporno.com.mk", "SASHOPESHOVSKI", "AQAAAAEAACcQAAAAEL0VDvMMrsxaw7nJBtjfcwt2qxKgiPtuV02q2ufBuTOBemSQvmR6LLyauU+/tVmXow==", null, false, "", false, "SashoPeshovski" },
                    { "eea0fa3c-f67e-45a9-bf76-0b6547481334", 0, "52914484-05a3-4cab-bb7a-4fa2b5485f95", "nikolchov@ognootporno.com.mk", true, "Евтим Николчов", false, null, "nikolchov@ognootporno.com.mk", "EVTIMNIKOLCHOV", "AQAAAAEAACcQAAAAEOKuJ+Sp59kWtgNFbM56L8wyILT1fRVChj+2+B7tRHp6aJXH69pPf21QUV2RHJL7YQ==", null, false, "", false, "EvtimNikolchov" },
                    { "4223e5d7-fc9b-4a90-b7bf-8a0e9daefa9e", 0, "5b6413aa-f619-4c52-85fb-b8e2fc05157f", "mirkovska@ognootporno.com.mk", true, "Ана Мирковска Гаврилов", false, null, "mirkovska@ognootporno.com.mk", "ANAMIRKOVSKAGAVRILOV", "AQAAAAEAACcQAAAAELbbgj9uuZ6CjsB2cpXv7PWE5vpGHd1Kt/k/vajzLlxDK9M7bOKz6euKRYDn5/REsQ==", null, false, "", false, "AnaMGavrilov" },
                    { "31028a3e-3afb-4653-a5c7-758343683650", 0, "6352df2d-4645-4bdf-ac91-7b3430a4779f", "peshovski@ognootporno.com.mk", true, "Тони Пешевски", false, null, "peshovski@ognootporno.com.mk", "TONIPESHEVSKI", "AQAAAAEAACcQAAAAEKoVWDVDWJzHgDBpOwCTQSqPqLA862TyxEukq1/GMgnuoMppij2iQDa62FrFjU2x1g==", null, false, "", false, "ToniPeshevski" },
                    { "94fe86e7-c60f-4218-ac49-b67ec0c842a7", 0, "818c5c48-9751-46c9-9e06-7a5411f69372", "nikolchov@ognootporno.com.mk", true, "Сашо Николчов", false, null, "nikolchov@ognootporno.com.mk", "SASHONIKOLCHOV", "AQAAAAEAACcQAAAAEOGQ5YQ6KvbLfqFq4L78QY+F/1jQ4cXq4AQNfQfhDFofMo89z/x7pO3+N7TMxVgFsw==", null, false, "", false, "SashoNikolchov" },
                    { "185d64aa-db0d-4a7d-9a89-792bbf33b7ae", 0, "94e1dd75-474c-4284-a96f-b448e7142c01", "planojevic@ognootporno.com.mk", true, "Владимир Планојевиќ", false, null, "PLANOJEVIC@OGNOOTPORNO.COM.MK", "VPLAN", "AQAAAAEAACcQAAAAEDY0RzjPEf5O1qKNMhSTSMc4Xpvb5y2mAF9y2go6G/AqwIMFsJPqNepnrjHXkaZ47A==", null, false, "", false, "VPlan" },
                    { "2e1976bf-93f8-4e2a-8ac7-e29a0e4a1ed8", 0, "7e77618d-39bc-4c5b-96e4-9d30be4819ff", "kotev@ognootporno.com.mk", true, "Коста Котев", false, null, "kotev@ognootporno.com.mk", "KOSTAKOTEV", "AQAAAAEAACcQAAAAEF3QT1s0hyXFWVrHqF4jA39DNpyI3EPa2z88Tq6j5BJHTHb5Z7VwOjsp0FfJQeWNJw==", null, false, "", false, "KostaKotev" },
                    { "52cab57d-0802-4c34-8ea3-ea62eb77478b", 0, "e1d00ffe-f0dd-4a47-91e3-8fce7bf25001", "supplier@mail.com", true, null, false, null, "supplier@mail.com", "OGNO2020", "AQAAAAEAACcQAAAAEBMDpqud+ZfRZfiQDs902pHCnKctu7NLVhEJ1lXtCvpwc043KXQEeQuyd3RofZ1yxg==", null, false, "", false, "ogno2020" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "52cab57d-0802-4c34-8ea3-ea62eb77478b", "a6fa8965-4da2-44ab-940c-ce55deeb638d" },
                    { "185d64aa-db0d-4a7d-9a89-792bbf33b7ae", "f49f437a-6ca0-4ca7-a21f-9395b15bf5c3" },
                    { "94fe86e7-c60f-4218-ac49-b67ec0c842a7", "d6da68ae-919b-4e3f-9282-766ab9502073" },
                    { "31028a3e-3afb-4653-a5c7-758343683650", "3212517b-07bc-4b24-a6ae-c976e813dbf5" },
                    { "4223e5d7-fc9b-4a90-b7bf-8a0e9daefa9e", "f944c33e-f5ec-401c-9141-37ad63561247" },
                    { "eea0fa3c-f67e-45a9-bf76-0b6547481334", "f3710608-4fea-44c1-a4ef-d668444901cf" },
                    { "be6d7a8d-68a1-4909-b03c-9403e1b35df9", "067da460-f68c-4068-aea3-989c57b97dbe" },
                    { "2e1976bf-93f8-4e2a-8ac7-e29a0e4a1ed8", "4f969c79-23bd-4ce8-8bf3-b4bd69309fd6" },
                    { "e7208c3c-793b-40a3-aaaf-d328370151a9", "814104df-f5bf-4e2a-9661-e01ce8102652" }
                });
        }
    }
}
