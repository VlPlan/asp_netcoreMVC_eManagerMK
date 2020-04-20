using Microsoft.EntityFrameworkCore.Migrations;

namespace eManager.DataAccess.Migrations
{
    public partial class init10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "b322daae-85ac-4c57-abff-5cff2f02b922", "a8ca4576-951d-4007-a28c-6c63c9cc5680" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "388a6f88-42e6-4af2-bc64-ef5143c49564", "6512343b-338d-41d6-9658-a6aa48bd0788" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "4c7ed83f-599c-451a-9aea-c3aaeba79816", "639a7c94-7266-4b17-a512-816be93c1cca" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "53f92718-277c-47ba-84a7-3d6155a4f253", "e4401253-863f-4f82-8801-bd5e5835aeb3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "5fb649d7-3b19-40dc-b019-99a33d6d6e52", "f8e46535-dc7f-4857-a281-bc9ed630e2a4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "95d08ab3-d295-4319-92cc-4e51d8fb1069", "5488f877-89c1-42f5-a836-b8a220631c8d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "963809f8-59ed-4dad-9538-375f8925fffe", "35d9684a-4135-4efa-a163-ba52bbd916fe" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a3e504ea-d87b-496e-9ac2-0a37e514ba01", "c3353d28-5fb6-40d1-9c77-87437ba4219b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "b0b2da75-737b-4fac-9777-5072ea4a04a0", "7544caa8-1951-4a74-901c-386c5d5a6d71" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "deced685-2f76-494a-9182-986271abfacb", "5b35a74f-bedb-44d9-a79a-5cc88a869017" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "947d3cf3-4e4c-4982-b942-6b0ec6b7b9c7", "bccd57bb-3b07-4bfe-930b-018ce9cae071" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "35d9684a-4135-4efa-a163-ba52bbd916fe", "afcb9cc6-2696-4ec2-b7a4-89bd7ddb1b55" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "5488f877-89c1-42f5-a836-b8a220631c8d", "160c304b-47ed-4321-83a0-883c26603f3d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "5b35a74f-bedb-44d9-a79a-5cc88a869017", "7178082f-e834-456c-b764-0300ed164245" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "639a7c94-7266-4b17-a512-816be93c1cca", "964f5876-bc19-4f88-905c-940f26957733" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "6512343b-338d-41d6-9658-a6aa48bd0788", "42c8736f-3f8f-4034-986d-084c8247381a" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "7544caa8-1951-4a74-901c-386c5d5a6d71", "8a0ef046-b6cc-43e2-9a3f-c82f13531da3" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "c3353d28-5fb6-40d1-9c77-87437ba4219b", "b6487f92-1c27-4575-b2ec-484548529b1d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "e4401253-863f-4f82-8801-bd5e5835aeb3", "6b7302a1-11da-4287-b2bb-91aecf7d9a65" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "f8e46535-dc7f-4857-a281-bc9ed630e2a4", "809e8a48-7d6b-4a24-a3f5-2028f3a1abff" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "388a6f88-42e6-4af2-bc64-ef5143c49564", "ab2cdaaf-39eb-4448-8b54-63cca589ca5e" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "4c7ed83f-599c-451a-9aea-c3aaeba79816", "2414365b-fba9-4e05-972b-76a732a94dff" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "53f92718-277c-47ba-84a7-3d6155a4f253", "4f4b5d34-b284-482b-893f-6979ccdfff8c" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "5fb649d7-3b19-40dc-b019-99a33d6d6e52", "b6eca586-0e73-46b4-995f-17d93b7796cb" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "95d08ab3-d295-4319-92cc-4e51d8fb1069", "eafb4510-64b6-4035-8df1-2a8309a6cce4" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "963809f8-59ed-4dad-9538-375f8925fffe", "f9408621-7bb2-4acc-8a93-d56195679cb4" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "a3e504ea-d87b-496e-9ac2-0a37e514ba01", "d858c6f5-8a51-4492-a52b-6223146771e8" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "b0b2da75-737b-4fac-9777-5072ea4a04a0", "aff4b84a-55c2-4535-bf48-d87f2ea8171a" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "deced685-2f76-494a-9182-986271abfacb", "9d26e6c0-cc6f-41b5-a1a4-fe338755f577" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "c3353d28-5fb6-40d1-9c77-87437ba4219b", "b6487f92-1c27-4575-b2ec-484548529b1d", "userDR", "USERDR" },
                    { "639a7c94-7266-4b17-a512-816be93c1cca", "964f5876-bc19-4f88-905c-940f26957733", "userGK", "USERGK" },
                    { "b322daae-85ac-4c57-abff-5cff2f02b922", "a8ca4576-951d-4007-a28c-6c63c9cc5680", "userSP", "USERSP" },
                    { "5b35a74f-bedb-44d9-a79a-5cc88a869017", "7178082f-e834-456c-b764-0300ed164245", "userEN", "USEREN" },
                    { "5488f877-89c1-42f5-a836-b8a220631c8d", "160c304b-47ed-4321-83a0-883c26603f3d", "userAMG", "USERAMG" },
                    { "f8e46535-dc7f-4857-a281-bc9ed630e2a4", "809e8a48-7d6b-4a24-a3f5-2028f3a1abff", "userTP", "USERTP" },
                    { "7544caa8-1951-4a74-901c-386c5d5a6d71", "8a0ef046-b6cc-43e2-9a3f-c82f13531da3", "userSN", "USERSN" },
                    { "35d9684a-4135-4efa-a163-ba52bbd916fe", "afcb9cc6-2696-4ec2-b7a4-89bd7ddb1b55", "userVP", "USERVP" },
                    { "6512343b-338d-41d6-9658-a6aa48bd0788", "42c8736f-3f8f-4034-986d-084c8247381a", "admin", "ADMIN" },
                    { "e4401253-863f-4f82-8801-bd5e5835aeb3", "6b7302a1-11da-4287-b2bb-91aecf7d9a65", "userKK", "USERKK" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "a3e504ea-d87b-496e-9ac2-0a37e514ba01", 0, "d858c6f5-8a51-4492-a52b-6223146771e8", "kotev@ognootporno.com.mk", true, "Драге Ристевски", false, null, "kotev@ognootporno.com.mk", "DRAGERISTEVSKI", "AQAAAAEAACcQAAAAEBjZ1wTYkYKUDYB1Ca2Cw+tdsgt1vJICPFFquGQBSy7Lve6NOrkWFLuCctb2jNf+uw==", null, false, "", false, "Drage.Ristevski" },
                    { "4c7ed83f-599c-451a-9aea-c3aaeba79816", 0, "2414365b-fba9-4e05-972b-76a732a94dff", "kotev@ognootporno.com.mk", true, "Горан Котев", false, null, "kotev@ognootporno.com.mk", "GORANKOTEV", "AQAAAAEAACcQAAAAEGm5Ur9eQfgG4ivcBNqvcZipK8PVvhRcKNoumF9bS3MPE9AbuL4hLMojXyANEbcXJg==", null, false, "", false, "Goran.Kotev" },
                    { "947d3cf3-4e4c-4982-b942-6b0ec6b7b9c7", 0, "bccd57bb-3b07-4bfe-930b-018ce9cae071", "peshovski@ognootporno.com.mk", true, "Сашо Пешовски", false, null, "peshovski@ognootporno.com.mk", "SASHOPESHOVSKI", "AQAAAAEAACcQAAAAEEtRVEO2JrR1qh3gzK11PHjDFPr6c84qfO8sCOUTsNaIwAh/3zjdr+9DtOVHxunmgA==", null, false, "", false, "Sasho.Peshovski" },
                    { "deced685-2f76-494a-9182-986271abfacb", 0, "9d26e6c0-cc6f-41b5-a1a4-fe338755f577", "nikolchov@ognootporno.com.mk", true, "Евтим Николчов", false, null, "nikolchov@ognootporno.com.mk", "EVTIMNIKOLCHOV", "AQAAAAEAACcQAAAAEMfitPFxryexLnMKn1HyCWqsQpqCcYwF+LsSg64ZE7qEz+0tqo0hjwjiIeITaBIgXA==", null, false, "", false, "Evtim.Nikolchov" },
                    { "95d08ab3-d295-4319-92cc-4e51d8fb1069", 0, "eafb4510-64b6-4035-8df1-2a8309a6cce4", "mirkovska@ognootporno.com.mk", true, "Ана Мирковска Гаврилов", false, null, "mirkovska@ognootporno.com.mk", "ANAMIRKOVSKAGAVRILOV", "AQAAAAEAACcQAAAAENPmCgYVKwLrh3J5DkL8HAzS3rfyGPQy0kQUe8y/GEvi1C64PFKSYjz/3o8zPvVLZg==", null, false, "", false, "Ana.M.Gavrilov" },
                    { "5fb649d7-3b19-40dc-b019-99a33d6d6e52", 0, "b6eca586-0e73-46b4-995f-17d93b7796cb", "peshovski@ognootporno.com.mk", true, "Тони Пешевски", false, null, "peshovski@ognootporno.com.mk", "TONIPESHEVSKI", "AQAAAAEAACcQAAAAEH9DzQHy6a+HbDcleSKVn59K1uJQduHV6dDnzkrEyXUOUSeu4Pq1x9G9Mh/aoZrMQg==", null, false, "", false, "Toni.Peshevski" },
                    { "b0b2da75-737b-4fac-9777-5072ea4a04a0", 0, "aff4b84a-55c2-4535-bf48-d87f2ea8171a", "nikolchov@ognootporno.com.mk", true, "Сашо Николчов", false, null, "nikolchov@ognootporno.com.mk", "SASHONIKOLCHOV", "AQAAAAEAACcQAAAAEM19Tyk1Ps8jfpEqUAEAR9T/bxLV7VstoNuEsb3uY2VPKBD5iTAnJ0fDddJvFqrjoA==", null, false, "", false, "Sasho.Nikolchov" },
                    { "963809f8-59ed-4dad-9538-375f8925fffe", 0, "f9408621-7bb2-4acc-8a93-d56195679cb4", "planojevic@ognootporno.com.mk", true, "Владимир Планојевиќ", false, null, "PLANOJEVIC@OGNOOTPORNO.COM.MK", "VPLAN", "AQAAAAEAACcQAAAAEFAbjL03bXbJUKDPnV13Hsgs873+PuV0MngHDNf/pkkSpBKESBYiI6PB8pv7WhCyaw==", null, false, "", false, "VPlan" },
                    { "53f92718-277c-47ba-84a7-3d6155a4f253", 0, "4f4b5d34-b284-482b-893f-6979ccdfff8c", "kotev@ognootporno.com.mk", true, "Коста Котев", false, null, "kotev@ognootporno.com.mk", "KOSTAKOTEV", "AQAAAAEAACcQAAAAEBMVrDCoW2wZgcnstyqJq793Z9xjS423ncmTqRLBXu6PT0CoD2BZxokIuzIkLGL/uw==", null, false, "", false, "Kosta.Kotev" },
                    { "388a6f88-42e6-4af2-bc64-ef5143c49564", 0, "ab2cdaaf-39eb-4448-8b54-63cca589ca5e", "supplier@mail.com", true, null, false, null, "supplier@mail.com", "@OGNO2020", "AQAAAAEAACcQAAAAELeKJMV6slLcD7E/fgFP4jXbPDNPIlpkrugFQPUcy06pHtWWMQy2Xa85uIYlayOJsA==", null, false, "", false, "@ogno2020" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "388a6f88-42e6-4af2-bc64-ef5143c49564", "6512343b-338d-41d6-9658-a6aa48bd0788" },
                    { "963809f8-59ed-4dad-9538-375f8925fffe", "35d9684a-4135-4efa-a163-ba52bbd916fe" },
                    { "b0b2da75-737b-4fac-9777-5072ea4a04a0", "7544caa8-1951-4a74-901c-386c5d5a6d71" },
                    { "5fb649d7-3b19-40dc-b019-99a33d6d6e52", "f8e46535-dc7f-4857-a281-bc9ed630e2a4" },
                    { "95d08ab3-d295-4319-92cc-4e51d8fb1069", "5488f877-89c1-42f5-a836-b8a220631c8d" },
                    { "deced685-2f76-494a-9182-986271abfacb", "5b35a74f-bedb-44d9-a79a-5cc88a869017" },
                    { "4c7ed83f-599c-451a-9aea-c3aaeba79816", "639a7c94-7266-4b17-a512-816be93c1cca" },
                    { "53f92718-277c-47ba-84a7-3d6155a4f253", "e4401253-863f-4f82-8801-bd5e5835aeb3" },
                    { "a3e504ea-d87b-496e-9ac2-0a37e514ba01", "c3353d28-5fb6-40d1-9c77-87437ba4219b" }
                });
        }
    }
}
