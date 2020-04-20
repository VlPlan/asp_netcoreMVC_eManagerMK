using Microsoft.EntityFrameworkCore.Migrations;

namespace eManager.DataAccess.Migrations
{
    public partial class init1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "ef5f2352-0a90-416b-8c37-ce651819a571", "b19383d1-5a63-436c-ba22-c405f049e028" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "057e31dd-1d64-41b9-8e48-c6d1313c92b0", "135e3dd5-f528-4263-aa42-5533de1750c0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "2306f620-402c-4ae9-8bca-07ed69d0d05c", "01fb255f-5413-4d23-a317-2dae9b10a01d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "6fd2db35-3811-4c96-8faa-d051607abee3", "38e4a280-2606-4232-8b10-e82be5f39f99" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "b0add26f-840d-408f-982f-a38a74ea91a2", "14f21eb2-b3f5-423c-863e-0ac286f00043" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "b3a401b6-912d-4a70-b8e9-edc8ede1d86e", "c4f8f3df-a157-4ad1-964f-1d6fc8b6ba91" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "d6e29096-f531-4cc3-add3-1d7816666434", "55906089-17ea-4e20-b30b-33688daaff6d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "d7f35dd1-1d33-4649-a9ac-9fab2096b73b", "2d377119-95e9-4868-bfe4-ded2fe685b8f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "f1b4491f-aea9-4f1f-8d7e-84ebf323afa1", "d9cea0b9-3afd-4c47-8599-b528638c4e4b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "f75d290f-ae0d-4d88-ac83-4d1c13bf7db7", "6dde67a6-453c-4221-ba4a-e5c3038eda99" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "911a3508-feef-40f2-a9b2-87d70d404b89", "86b75347-99bd-459b-9d13-aadd2c5f2122" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "01fb255f-5413-4d23-a317-2dae9b10a01d", "5a3dbea6-dbd3-4ff0-b182-6e662a73e451" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "135e3dd5-f528-4263-aa42-5533de1750c0", "777fdf69-7992-4e5d-9f29-44e0005c3ca6" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "14f21eb2-b3f5-423c-863e-0ac286f00043", "6529a5d4-714b-422d-946c-e947a341710f" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "2d377119-95e9-4868-bfe4-ded2fe685b8f", "b6e36459-aaa3-4eda-907e-b077c025e772" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "38e4a280-2606-4232-8b10-e82be5f39f99", "15fd4df3-8e68-40bf-8e10-00ced617d66b" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "55906089-17ea-4e20-b30b-33688daaff6d", "6a1bc88a-5a43-497b-bc4c-e27f1a1983a9" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "6dde67a6-453c-4221-ba4a-e5c3038eda99", "8dcc9720-ebc4-4901-8dee-e8fa1e1e24bc" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "c4f8f3df-a157-4ad1-964f-1d6fc8b6ba91", "1b444aae-e73c-41bc-aa73-80e296a8f3bb" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "d9cea0b9-3afd-4c47-8599-b528638c4e4b", "4bbf69dc-7610-420b-b82b-3de4312541f5" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "057e31dd-1d64-41b9-8e48-c6d1313c92b0", "c5ddb9dd-c324-475d-b5ab-5aae6a072500" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "2306f620-402c-4ae9-8bca-07ed69d0d05c", "8087a677-052e-49f2-94dc-47273ceea012" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "6fd2db35-3811-4c96-8faa-d051607abee3", "23b84faa-c30e-4b0d-a107-db8758ce5ad9" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "b0add26f-840d-408f-982f-a38a74ea91a2", "a01445b0-33e2-477f-b6b8-0bd33d4533a9" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "b3a401b6-912d-4a70-b8e9-edc8ede1d86e", "85370fa5-b6e0-4d29-9bb9-8c99912bab30" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "d6e29096-f531-4cc3-add3-1d7816666434", "ef12cc7d-aa05-4086-bb68-8532ecd49a7f" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "d7f35dd1-1d33-4649-a9ac-9fab2096b73b", "21beb960-9e1c-4c10-8476-cbca4d929693" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "f1b4491f-aea9-4f1f-8d7e-84ebf323afa1", "94b5ff72-6ab0-4205-a397-75fc09c46bd3" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "f75d290f-ae0d-4d88-ac83-4d1c13bf7db7", "61611b77-40f6-4758-82a4-2ade294c761b" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
