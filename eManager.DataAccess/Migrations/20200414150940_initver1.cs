using Microsoft.EntityFrameworkCore.Migrations;

namespace eManager.DataAccess.Migrations
{
    public partial class initver1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "833a0515-4258-40e0-92d1-8268b808e0c4", "fec2e855-45d7-41b7-8c13-d5fa01199599" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "07c5dde5-b557-499e-ad8c-1c4af39754c6", "ee6c9d74-1c50-4539-a893-9d69b931e218" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "0b8a0bc5-c6ab-46bb-823e-bd038e036569", "4e972688-a34c-482d-a183-8d9129c2ff7f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "37af963d-5907-4b78-89cb-460afe6fbec6", "c8aff7fd-aa41-4972-b24d-cfde2586fc09" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "3e64e5bc-1a0e-4634-9da4-f199e30e2429", "892da606-13d8-4138-a1db-ce9925b9e4ec" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "539080f8-ff27-4819-8b95-dd1a30d638a3", "c47c36b4-27b3-4e8e-abc7-40dfdf1850fc" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "5529b0e2-ac29-4eb1-bd0c-f3faada939e6", "cdc8c629-27ad-44cb-b102-ede7b2aa386c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "5b95efe5-c35e-4910-a59a-d2844b6b63eb", "a35a8d2d-6f91-43fb-9e9f-7162ffd82d09" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "62144fd6-b509-4621-a1a5-515dfc3431ef", "0be86b0a-f6ca-4c61-a2a4-9541ec6260ba" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "cc0fbab5-0d34-4e23-8e6a-0f2c6f17a679", "27307d0b-103d-41e9-84ce-32d42b5a5f71" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "4037c44a-8aa7-4820-af6d-06815637547c", "105dea6c-9db8-46ed-8c9f-e75259bd55f7" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "0be86b0a-f6ca-4c61-a2a4-9541ec6260ba", "bdfe6d0e-5b4c-4215-8f52-d2d5c1c2c832" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "27307d0b-103d-41e9-84ce-32d42b5a5f71", "40f26696-447c-4aef-8261-ae636855a909" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "4e972688-a34c-482d-a183-8d9129c2ff7f", "fbfeb854-33cf-4e14-bb17-c902de6e06bc" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "892da606-13d8-4138-a1db-ce9925b9e4ec", "f318eed3-c309-402c-b4de-4624e0fdd905" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "a35a8d2d-6f91-43fb-9e9f-7162ffd82d09", "12853cce-2aa2-4c26-8588-d382a51706fa" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "c47c36b4-27b3-4e8e-abc7-40dfdf1850fc", "e31c9397-aec6-4529-975d-af93186550df" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "c8aff7fd-aa41-4972-b24d-cfde2586fc09", "5d9a701f-92ae-490b-bd43-f4204771fcf3" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "cdc8c629-27ad-44cb-b102-ede7b2aa386c", "3c3b46bd-6c7f-4e99-bf4b-ca8855eb9c2d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "ee6c9d74-1c50-4539-a893-9d69b931e218", "dee68415-802e-4ede-8bd5-dc8c1bd5f3c6" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "07c5dde5-b557-499e-ad8c-1c4af39754c6", "2a5253cd-46f7-4e77-81b9-4f3eedcf3abe" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "0b8a0bc5-c6ab-46bb-823e-bd038e036569", "61e8367d-e2bd-4e6b-955f-a1397047e93c" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "37af963d-5907-4b78-89cb-460afe6fbec6", "61e86d08-73f9-4113-8eb0-4c49e8e209c5" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "3e64e5bc-1a0e-4634-9da4-f199e30e2429", "683d6043-90bc-4d17-bea7-f465b756394b" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "539080f8-ff27-4819-8b95-dd1a30d638a3", "d487c323-6b81-455a-84f2-8f4463482368" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "5529b0e2-ac29-4eb1-bd0c-f3faada939e6", "9e9c812b-3968-499c-bd71-668865d16938" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "5b95efe5-c35e-4910-a59a-d2844b6b63eb", "28f4da12-df66-4ed6-ad8f-5d892766b6a1" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "62144fd6-b509-4621-a1a5-515dfc3431ef", "c1b3a07a-50ed-4371-a461-3a6a5fec70d4" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "cc0fbab5-0d34-4e23-8e6a-0f2c6f17a679", "943008c6-d7b2-4d76-afcc-fc195c3ec6e9" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5472af89-bcd0-4480-824f-3f084790c5d1", "a388dde1-ea3c-41a7-8f80-009c348f4da7", "userDR", "USERDR" },
                    { "8c5773d8-418a-433d-b64f-95be2a0aa366", "02a1cf8c-16cf-48d4-9478-a8fe2dbcf62a", "userGK", "USERGK" },
                    { "34ffca2c-6e8c-4a2b-ab7c-1a4b6a67c842", "dfebeaf0-b374-4390-8d69-1a6a88ee8429", "userSP", "USERSP" },
                    { "4ad3a643-cdb8-46f2-b861-f6df9019c77e", "4fee370d-6706-431d-8f92-aab4194e48c3", "userEN", "USEREN" },
                    { "4d7c84ad-a7e7-4c05-9abe-68b6f46c9034", "8b1627e6-2272-42e1-95bb-65a88f72f44b", "userAMG", "USERAMG" },
                    { "fa4008ac-770c-4e1f-ad9d-6609c74e43a1", "cd062796-b296-44ca-9bbb-e1e3c5db3fd8", "userTP", "USERTP" },
                    { "23ab4f31-102b-497d-803e-60a42a9e18f7", "9f61915d-36e5-46b2-b204-1b97a1159c45", "userSN", "USERSN" },
                    { "c9961dde-29b4-40ed-be80-ec9896064400", "227bf72f-7864-456a-b291-f8b053b0ff43", "userVP", "USERVP" },
                    { "46285589-a51d-4963-9246-606e1fe59f89", "c0fbb8b9-dfd6-4f4a-a2e0-261c3cb66d26", "admin", "ADMIN" },
                    { "bc4a7998-f994-40e2-8ccd-d59824ae8d84", "3b976cf9-994f-4e7b-810b-e6694f9b0439", "userKK", "USERKK" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "83bfc651-4ffb-4fd3-a355-dc1ac9194038", 0, "bd4353ab-3c31-424c-92dc-e73dac2a52a6", "kotev@ognootporno.com.mk", true, "Драге Ристевски", false, null, "kotev@ognootporno.com.mk", "DRAGERISTEVSKI", "AQAAAAEAACcQAAAAEKZxErHsz1cEUEb4YzaGI0yfM1yX+H1eueSqqSNX7rDXs+kENZHQUc7R1n8TxipncA==", null, false, "", false, "DrageRistevski" },
                    { "2da1b146-35e6-4a5c-9efc-e9bbcf3c741b", 0, "7ad0881b-18e1-4228-ac14-9943c3036a6d", "kotev@ognootporno.com.mk", true, "Горан Котев", false, null, "kotev@ognootporno.com.mk", "GORANKOTEV", "AQAAAAEAACcQAAAAEFs3ExmNhfpZR5O0/5zhlPGlXQBMQ5JCnDOtPywEEj8KPDsgGtSE4YiPuGfO09oQ/w==", null, false, "", false, "GoranKotev" },
                    { "dfff74ec-1c78-46ed-84e9-09034145b31f", 0, "1c9e6a0d-c4fe-4ab9-9a10-1d110cf6e79b", "peshovski@ognootporno.com.mk", true, "Сашо Пешовски", false, null, "peshovski@ognootporno.com.mk", "SASHOPESHOVSKI", "AQAAAAEAACcQAAAAEM144w8NXGYIl5QS8WpIwhAtHQwTrv4ZM4MWm4No1XAh9rZPeYvwl3UGNRoi9itGKA==", null, false, "", false, "SashoPeshovski" },
                    { "f4889a60-62d0-48c0-87b3-5112f77e6a2c", 0, "f3226ea0-b6bd-4de6-983c-e03146728cc1", "nikolchov@ognootporno.com.mk", true, "Евтим Николчов", false, null, "nikolchov@ognootporno.com.mk", "EVTIMNIKOLCHOV", "AQAAAAEAACcQAAAAEJwWryS6x82hpdk76II7Z6l1QORSwHxB7UoH6No0WKrLPwpiBzZG1tgftiS4Ct78zA==", null, false, "", false, "EvtimNikolchov" },
                    { "8669871c-13d1-43f6-bbe2-b1eafa910798", 0, "94ef6bd7-6b86-456a-82c1-26886145a759", "mirkovska@ognootporno.com.mk", true, "Ана Мирковска Гаврилов", false, null, "mirkovska@ognootporno.com.mk", "ANAMIRKOVSKAGAVRILOV", "AQAAAAEAACcQAAAAEGZEhiYrTltp2gpH/GfEh370ZICaCnHpxiDQBDSiuOX4k95vcyJGbzvcCTa/hudpAw==", null, false, "", false, "AnaMGavrilov" },
                    { "34cfe811-fcb8-4d1b-8b7a-fe20a9e330ba", 0, "90c195e5-546c-485b-8d41-a82196db8277", "peshovski@ognootporno.com.mk", true, "Тони Пешевски", false, null, "peshovski@ognootporno.com.mk", "TONIPESHEVSKI", "AQAAAAEAACcQAAAAEJo/FPawCqL+MOVN9vU8h9DaFDpmoiD6Igp+6THHFHDoFsJrJXMCGQydSxK9W0yITg==", null, false, "", false, "ToniPeshevski" },
                    { "de8a9479-5b9e-4038-9b3f-8b02c44e8083", 0, "f982394a-8e9a-40fd-8371-f79f62c01acf", "nikolchov@ognootporno.com.mk", true, "Сашо Николчов", false, null, "nikolchov@ognootporno.com.mk", "SASHONIKOLCHOV", "AQAAAAEAACcQAAAAEDSKSxRIwj9X3NlTnK3Dn9Rk/GjdLDPgNkS28VBaXQr56unX2rQeYfIAOL7pSrgMSA==", null, false, "", false, "SashoNikolchov" },
                    { "703bae79-0f5f-4baa-a92b-286e383b3f10", 0, "d18efdf6-9a86-4fe3-86dc-bec6a410a5f4", "planojevic@ognootporno.com.mk", true, "Владимир Планојевиќ", false, null, "PLANOJEVIC@OGNOOTPORNO.COM.MK", "VPLAN", "AQAAAAEAACcQAAAAEMSjwdfg3GkMELBTYeGdSbR8/kkC7VzlLCgsYw/IcOYwKZ9QrtFC5oCP92/8p3A/+Q==", null, false, "", false, "VPlan" },
                    { "bc9b8438-ee3a-4ce8-87d0-5a390f3d0ba0", 0, "1932e854-1e67-4e52-88fd-25f844703763", "kotev@ognootporno.com.mk", true, "Коста Котев", false, null, "kotev@ognootporno.com.mk", "KOSTAKOTEV", "AQAAAAEAACcQAAAAEJn7LOqE69DpDrm4rHp+upgmjbQHdgvcokcMZ3Rm8lYPM7kxYHxf8++qPkI4neluzg==", null, false, "", false, "KostaKotev" },
                    { "66c62030-73d2-440d-aaba-d4fe6f141051", 0, "dd7b7ba3-4ab3-4d89-a56f-6a66aaeb6d57", "supplier@mail.com", true, null, false, null, "supplier@mail.com", "OGNO2020", "AQAAAAEAACcQAAAAEDqfqtBiGddN8JTeEV38a/FzN8uVEjhUEmqxR8brDbpagDmIV+Sh5R+/3a4VMgXm3Q==", null, false, "", false, "ogno2020" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "66c62030-73d2-440d-aaba-d4fe6f141051", "46285589-a51d-4963-9246-606e1fe59f89" },
                    { "703bae79-0f5f-4baa-a92b-286e383b3f10", "c9961dde-29b4-40ed-be80-ec9896064400" },
                    { "de8a9479-5b9e-4038-9b3f-8b02c44e8083", "23ab4f31-102b-497d-803e-60a42a9e18f7" },
                    { "34cfe811-fcb8-4d1b-8b7a-fe20a9e330ba", "fa4008ac-770c-4e1f-ad9d-6609c74e43a1" },
                    { "8669871c-13d1-43f6-bbe2-b1eafa910798", "4d7c84ad-a7e7-4c05-9abe-68b6f46c9034" },
                    { "f4889a60-62d0-48c0-87b3-5112f77e6a2c", "4ad3a643-cdb8-46f2-b861-f6df9019c77e" },
                    { "2da1b146-35e6-4a5c-9efc-e9bbcf3c741b", "8c5773d8-418a-433d-b64f-95be2a0aa366" },
                    { "bc9b8438-ee3a-4ce8-87d0-5a390f3d0ba0", "bc4a7998-f994-40e2-8ccd-d59824ae8d84" },
                    { "83bfc651-4ffb-4fd3-a355-dc1ac9194038", "5472af89-bcd0-4480-824f-3f084790c5d1" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "34ffca2c-6e8c-4a2b-ab7c-1a4b6a67c842", "dfebeaf0-b374-4390-8d69-1a6a88ee8429" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "2da1b146-35e6-4a5c-9efc-e9bbcf3c741b", "8c5773d8-418a-433d-b64f-95be2a0aa366" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "34cfe811-fcb8-4d1b-8b7a-fe20a9e330ba", "fa4008ac-770c-4e1f-ad9d-6609c74e43a1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "66c62030-73d2-440d-aaba-d4fe6f141051", "46285589-a51d-4963-9246-606e1fe59f89" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "703bae79-0f5f-4baa-a92b-286e383b3f10", "c9961dde-29b4-40ed-be80-ec9896064400" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "83bfc651-4ffb-4fd3-a355-dc1ac9194038", "5472af89-bcd0-4480-824f-3f084790c5d1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "8669871c-13d1-43f6-bbe2-b1eafa910798", "4d7c84ad-a7e7-4c05-9abe-68b6f46c9034" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "bc9b8438-ee3a-4ce8-87d0-5a390f3d0ba0", "bc4a7998-f994-40e2-8ccd-d59824ae8d84" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "de8a9479-5b9e-4038-9b3f-8b02c44e8083", "23ab4f31-102b-497d-803e-60a42a9e18f7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "f4889a60-62d0-48c0-87b3-5112f77e6a2c", "4ad3a643-cdb8-46f2-b861-f6df9019c77e" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "dfff74ec-1c78-46ed-84e9-09034145b31f", "1c9e6a0d-c4fe-4ab9-9a10-1d110cf6e79b" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "23ab4f31-102b-497d-803e-60a42a9e18f7", "9f61915d-36e5-46b2-b204-1b97a1159c45" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "46285589-a51d-4963-9246-606e1fe59f89", "c0fbb8b9-dfd6-4f4a-a2e0-261c3cb66d26" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "4ad3a643-cdb8-46f2-b861-f6df9019c77e", "4fee370d-6706-431d-8f92-aab4194e48c3" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "4d7c84ad-a7e7-4c05-9abe-68b6f46c9034", "8b1627e6-2272-42e1-95bb-65a88f72f44b" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "5472af89-bcd0-4480-824f-3f084790c5d1", "a388dde1-ea3c-41a7-8f80-009c348f4da7" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "8c5773d8-418a-433d-b64f-95be2a0aa366", "02a1cf8c-16cf-48d4-9478-a8fe2dbcf62a" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "bc4a7998-f994-40e2-8ccd-d59824ae8d84", "3b976cf9-994f-4e7b-810b-e6694f9b0439" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "c9961dde-29b4-40ed-be80-ec9896064400", "227bf72f-7864-456a-b291-f8b053b0ff43" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "fa4008ac-770c-4e1f-ad9d-6609c74e43a1", "cd062796-b296-44ca-9bbb-e1e3c5db3fd8" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "2da1b146-35e6-4a5c-9efc-e9bbcf3c741b", "7ad0881b-18e1-4228-ac14-9943c3036a6d" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "34cfe811-fcb8-4d1b-8b7a-fe20a9e330ba", "90c195e5-546c-485b-8d41-a82196db8277" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "66c62030-73d2-440d-aaba-d4fe6f141051", "dd7b7ba3-4ab3-4d89-a56f-6a66aaeb6d57" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "703bae79-0f5f-4baa-a92b-286e383b3f10", "d18efdf6-9a86-4fe3-86dc-bec6a410a5f4" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "83bfc651-4ffb-4fd3-a355-dc1ac9194038", "bd4353ab-3c31-424c-92dc-e73dac2a52a6" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "8669871c-13d1-43f6-bbe2-b1eafa910798", "94ef6bd7-6b86-456a-82c1-26886145a759" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "bc9b8438-ee3a-4ce8-87d0-5a390f3d0ba0", "1932e854-1e67-4e52-88fd-25f844703763" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "de8a9479-5b9e-4038-9b3f-8b02c44e8083", "f982394a-8e9a-40fd-8371-f79f62c01acf" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "f4889a60-62d0-48c0-87b3-5112f77e6a2c", "f3226ea0-b6bd-4de6-983c-e03146728cc1" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ee6c9d74-1c50-4539-a893-9d69b931e218", "dee68415-802e-4ede-8bd5-dc8c1bd5f3c6", "userDR", "USERDR" },
                    { "c47c36b4-27b3-4e8e-abc7-40dfdf1850fc", "e31c9397-aec6-4529-975d-af93186550df", "userGK", "USERGK" },
                    { "833a0515-4258-40e0-92d1-8268b808e0c4", "fec2e855-45d7-41b7-8c13-d5fa01199599", "userSP", "USERSP" },
                    { "27307d0b-103d-41e9-84ce-32d42b5a5f71", "40f26696-447c-4aef-8261-ae636855a909", "userEN", "USEREN" },
                    { "0be86b0a-f6ca-4c61-a2a4-9541ec6260ba", "bdfe6d0e-5b4c-4215-8f52-d2d5c1c2c832", "userAMG", "USERAMG" },
                    { "c8aff7fd-aa41-4972-b24d-cfde2586fc09", "5d9a701f-92ae-490b-bd43-f4204771fcf3", "userTP", "USERTP" },
                    { "892da606-13d8-4138-a1db-ce9925b9e4ec", "f318eed3-c309-402c-b4de-4624e0fdd905", "userSN", "USERSN" },
                    { "4e972688-a34c-482d-a183-8d9129c2ff7f", "fbfeb854-33cf-4e14-bb17-c902de6e06bc", "userVP", "USERVP" },
                    { "a35a8d2d-6f91-43fb-9e9f-7162ffd82d09", "12853cce-2aa2-4c26-8588-d382a51706fa", "admin", "ADMIN" },
                    { "cdc8c629-27ad-44cb-b102-ede7b2aa386c", "3c3b46bd-6c7f-4e99-bf4b-ca8855eb9c2d", "userKK", "USERKK" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "07c5dde5-b557-499e-ad8c-1c4af39754c6", 0, "2a5253cd-46f7-4e77-81b9-4f3eedcf3abe", "kotev@ognootporno.com.mk", true, "Драге Ристевски", false, null, "kotev@ognootporno.com.mk", "DRAGERISTEVSKI", "AQAAAAEAACcQAAAAEOA/fOZgMevCnpFQ3e5blGEXyn95HQIMglXUhIli3EGfuN2d3Z2uWYkfKO2hhAdjJQ==", null, false, "", false, "DrageRistevski" },
                    { "539080f8-ff27-4819-8b95-dd1a30d638a3", 0, "d487c323-6b81-455a-84f2-8f4463482368", "kotev@ognootporno.com.mk", true, "Горан Котев", false, null, "kotev@ognootporno.com.mk", "GORANKOTEV", "AQAAAAEAACcQAAAAEHHvpUaaMoJdasl/65/adCo/08Xcbqk6uKQ4S/LFxfHgQCJ64FeppSgsrTjMOqMP+Q==", null, false, "", false, "GoranKotev" },
                    { "4037c44a-8aa7-4820-af6d-06815637547c", 0, "105dea6c-9db8-46ed-8c9f-e75259bd55f7", "peshovski@ognootporno.com.mk", true, "Сашо Пешовски", false, null, "peshovski@ognootporno.com.mk", "SASHOPESHOVSKI", "AQAAAAEAACcQAAAAEBvPtSm7A75a4fw/eDiw1Zgw6vt57nVvOSa0su9Tnx+IMKacGAINRMIyRGGJck5ELQ==", null, false, "", false, "SashoPeshovski" },
                    { "cc0fbab5-0d34-4e23-8e6a-0f2c6f17a679", 0, "943008c6-d7b2-4d76-afcc-fc195c3ec6e9", "nikolchov@ognootporno.com.mk", true, "Евтим Николчов", false, null, "nikolchov@ognootporno.com.mk", "EVTIMNIKOLCHOV", "AQAAAAEAACcQAAAAEPf+ByElueV9netkkijYpMCoSRX9CZAL3HWdNdqf2aKBszbVihkC+vZ70y7aNWyxyQ==", null, false, "", false, "EvtimNikolchov" },
                    { "62144fd6-b509-4621-a1a5-515dfc3431ef", 0, "c1b3a07a-50ed-4371-a461-3a6a5fec70d4", "mirkovska@ognootporno.com.mk", true, "Ана Мирковска Гаврилов", false, null, "mirkovska@ognootporno.com.mk", "ANAMIRKOVSKAGAVRILOV", "AQAAAAEAACcQAAAAEMRB4qTGTzzvLFzf/cqKqt/rXhpod6fk+0JL3Cf8LKSkNbDox7R+pUnLmGCUCqsegA==", null, false, "", false, "AnaMGavrilov" },
                    { "37af963d-5907-4b78-89cb-460afe6fbec6", 0, "61e86d08-73f9-4113-8eb0-4c49e8e209c5", "peshovski@ognootporno.com.mk", true, "Тони Пешевски", false, null, "peshovski@ognootporno.com.mk", "TONIPESHEVSKI", "AQAAAAEAACcQAAAAEB/2WV86Ye/8kSErRm2VctcyJd/Y9VaY0CElfwt724iobZJCjIBJmW1rtcS4BI2T7w==", null, false, "", false, "ToniPeshevski" },
                    { "3e64e5bc-1a0e-4634-9da4-f199e30e2429", 0, "683d6043-90bc-4d17-bea7-f465b756394b", "nikolchov@ognootporno.com.mk", true, "Сашо Николчов", false, null, "nikolchov@ognootporno.com.mk", "SASHONIKOLCHOV", "AQAAAAEAACcQAAAAEDcXV96zVtEdnAMpA2Mw37AfeOtK69GymnqFtEsJzkNqSoGsg7K/nMe62xZu43U4/A==", null, false, "", false, "SashoNikolchov" },
                    { "0b8a0bc5-c6ab-46bb-823e-bd038e036569", 0, "61e8367d-e2bd-4e6b-955f-a1397047e93c", "planojevic@ognootporno.com.mk", true, "Владимир Планојевиќ", false, null, "PLANOJEVIC@OGNOOTPORNO.COM.MK", "VPLAN", "AQAAAAEAACcQAAAAEDhVKYbYud+JIWqhkIk9TR/PhnxQRo7IQbbOtYG0JaCN+KBGYsB69xJw0847iyDidg==", null, false, "", false, "VPlan" },
                    { "5529b0e2-ac29-4eb1-bd0c-f3faada939e6", 0, "9e9c812b-3968-499c-bd71-668865d16938", "kotev@ognootporno.com.mk", true, "Коста Котев", false, null, "kotev@ognootporno.com.mk", "KOSTAKOTEV", "AQAAAAEAACcQAAAAEBZWYnSxva3qg7OQOzarTPfz8jhbZ3fkCa+ciHc8tvzUrq5391s8S+gbE8TeRFZW+w==", null, false, "", false, "KostaKotev" },
                    { "5b95efe5-c35e-4910-a59a-d2844b6b63eb", 0, "28f4da12-df66-4ed6-ad8f-5d892766b6a1", "supplier@mail.com", true, null, false, null, "supplier@mail.com", "Ognootporno2020", "AQAAAAEAACcQAAAAEATrBSlyseA3ZfhEKMcB8VaWfj0z1fFIM0xpaVfFc9MioErHwl5v/7bq3bMPSvnVJQ==", null, false, "", false, "ogno2020" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "5b95efe5-c35e-4910-a59a-d2844b6b63eb", "a35a8d2d-6f91-43fb-9e9f-7162ffd82d09" },
                    { "0b8a0bc5-c6ab-46bb-823e-bd038e036569", "4e972688-a34c-482d-a183-8d9129c2ff7f" },
                    { "3e64e5bc-1a0e-4634-9da4-f199e30e2429", "892da606-13d8-4138-a1db-ce9925b9e4ec" },
                    { "37af963d-5907-4b78-89cb-460afe6fbec6", "c8aff7fd-aa41-4972-b24d-cfde2586fc09" },
                    { "62144fd6-b509-4621-a1a5-515dfc3431ef", "0be86b0a-f6ca-4c61-a2a4-9541ec6260ba" },
                    { "cc0fbab5-0d34-4e23-8e6a-0f2c6f17a679", "27307d0b-103d-41e9-84ce-32d42b5a5f71" },
                    { "539080f8-ff27-4819-8b95-dd1a30d638a3", "c47c36b4-27b3-4e8e-abc7-40dfdf1850fc" },
                    { "5529b0e2-ac29-4eb1-bd0c-f3faada939e6", "cdc8c629-27ad-44cb-b102-ede7b2aa386c" },
                    { "07c5dde5-b557-499e-ad8c-1c4af39754c6", "ee6c9d74-1c50-4539-a893-9d69b931e218" }
                });
        }
    }
}
