using Microsoft.EntityFrameworkCore.Migrations;

namespace eManager.DataAccess.Migrations
{
    public partial class initVP : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "02928ea6-d28b-48ed-aeda-c63a437b95ce", "eb7d8a7f-9c22-4316-b04d-b5e06a626370", "userDR", "USERDR" },
                    { "5ea29778-e091-4c45-9d27-2ad5cac2108c", "ce1caad1-a69e-438b-8470-b468b6e5c346", "userGK", "USERGK" },
                    { "0bad4ec9-a6b9-4cef-adec-e8699f748522", "b6abb990-6d43-4798-bd12-3bb4dbafc8de", "userSP", "USERSP" },
                    { "4da32ba5-f1b4-46f9-85eb-2406ea24a9f5", "9d93926d-4ed9-4e20-974d-e65c945954c4", "userEN", "USEREN" },
                    { "de684694-6eb9-40f1-8f5a-0b7a35fbde2c", "26eb73e8-c1bb-4b70-8a2b-889e2c031659", "userAMG", "USERAMG" },
                    { "26855d8d-7830-4168-8056-ac5d44cca830", "37d3ce04-e227-4a33-a8b9-4de023fcb842", "userTP", "USERTP" },
                    { "445a2f60-56c3-4ed3-93aa-51eb639ee56a", "2e044ed9-1037-4c2d-bd84-ebcf01d76df3", "userSN", "USERSN" },
                    { "0da9f1d2-793c-4e74-9a11-9eb8936a7892", "cc310c59-01a8-4fdb-9bdc-50591ba83b39", "userVP", "USERVP" },
                    { "7881c850-e14d-4ec9-bbe6-8194b87bad6d", "e71a8f44-2035-44f3-a009-02c19c4004b5", "admin", "ADMIN" },
                    { "105fa72e-36a9-4df4-974d-52d66337409d", "c24c8bd3-ffdf-41b9-8f56-c91c3b5c9725", "userKK", "USERKK" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "52e3ebb6-8a62-47a7-8962-69fa83790d64", 0, "799b7588-2d96-4fa1-94ac-c0fee9718a07", "kotev@ognootporno.com.mk", true, "Драге Ристевски", false, null, "kotev@ognootporno.com.mk", "DRAGERISTEVSKI", "AQAAAAEAACcQAAAAEOy8fZPsQmMkBE6VtK2rBgzD4283IPvsXFQQ1ZfKAyXqC03LBdI5/qFUHoxwAqUyrA==", null, false, "", false, "DrageRistevski" },
                    { "76e71c29-8207-4331-a25f-33ded68b11cd", 0, "cc706f26-045f-442c-aea5-8742822946d3", "kotev@ognootporno.com.mk", true, "Горан Котев", false, null, "kotev@ognootporno.com.mk", "GORANKOTEV", "AQAAAAEAACcQAAAAEEN682dLC1bidxNkVYsOA7aBp7VC5+7IiW/sVOJKex59muidF5MDYLeKtdrEkS6EOw==", null, false, "", false, "GoranKotev" },
                    { "ac25ac17-c6f1-488e-9656-5d79d6597b1e", 0, "1a9af5d4-51f0-46c0-babe-0eb9cd407c7c", "peshovski@ognootporno.com.mk", true, "Сашо Пешовски", false, null, "peshovski@ognootporno.com.mk", "SASHOPESHOVSKI", "AQAAAAEAACcQAAAAELrlo0zx4k4SDJA9AFPBeDSCxXstIb6JKjAYo0WJKPSpMmS3usnGLSLCAuycIJrS9Q==", null, false, "", false, "SashoPeshovski" },
                    { "8df4b0fb-2c14-4145-bd0b-db8e4868e1b8", 0, "a0ea209b-d042-4827-a2f6-03fce551bb0a", "nikolchov@ognootporno.com.mk", true, "Евтим Николчов", false, null, "nikolchov@ognootporno.com.mk", "EVTIMNIKOLCHOV", "AQAAAAEAACcQAAAAEHMBxGMe3Ai9daqfHskVNlpPb6AlFNqzzSod7B2QoOgQ1ETRzUwzm+Xc+EtZUx5LEA==", null, false, "", false, "EvtimNikolchov" },
                    { "9059516b-b422-4318-bd67-81fc04f1e08d", 0, "c295cb7c-c481-4d10-a9b8-d1ac8273864e", "mirkovska@ognootporno.com.mk", true, "Ана Мирковска Гаврилов", false, null, "mirkovska@ognootporno.com.mk", "ANAMIRKOVSKAGAVRILOV", "AQAAAAEAACcQAAAAEAPlchfAPVQt7DYaAuEkt2EEzkFnCT0YWO0d6aSB5MLO9GcHp7YYSvPbUXcMBe/K1w==", null, false, "", false, "AnaMGavrilov" },
                    { "4c235923-67b7-4a55-b143-06aee6c5dbe6", 0, "18bbce31-a33d-4304-b4e5-b4b4628a0a53", "peshovski@ognootporno.com.mk", true, "Тони Пешевски", false, null, "peshovski@ognootporno.com.mk", "TONIPESHEVSKI", "AQAAAAEAACcQAAAAEAYOz5sJ7NcWxbGccpx66//Xzm/xL0bvHQ9kd5xo3AuLteCnmJ2jnhC8x9qcdeSEeg==", null, false, "", false, "ToniPeshevski" },
                    { "4fdbebc5-0630-4bf9-be03-af1c56bb71a6", 0, "a34ebb39-348d-4560-aec6-018432709aa0", "nikolchov@ognootporno.com.mk", true, "Сашо Николчов", false, null, "nikolchov@ognootporno.com.mk", "SASHONIKOLCHOV", "AQAAAAEAACcQAAAAEJhCjk0vLxMfLENfZPbzCqwVD4GvhWWZKrvVIS6qnYTpsJ7GEUU/LwuQp1PrB5xJuA==", null, false, "", false, "SashoNikolchov" },
                    { "6ae2bff4-400a-44ca-bccb-87427d6a7c5e", 0, "dad664a8-bc0e-4a08-b340-fc2bb030191f", "planojevic@ognootporno.com.mk", true, "Владимир Планојевиќ", false, null, "PLANOJEVIC@OGNOOTPORNO.COM.MK", "VPLAN", "AQAAAAEAACcQAAAAEFBpmSPvk3dVG2SquFjlCDdXUnb0eVEgbRvyYTXMXaSYocVUcXbHHEXwrwJD4NOnuQ==", null, false, "", false, "VPlan" },
                    { "ecf10134-b3f8-4ea2-aaa6-62615e83c5bc", 0, "2c9ef743-5d4d-4dfa-92f3-327f121971bd", "kotev@ognootporno.com.mk", true, "Коста Котев", false, null, "kotev@ognootporno.com.mk", "KOSTAKOTEV", "AQAAAAEAACcQAAAAEAKGR0cP5WAH8C35JJAe21p3CWUaywH4EDFJHp0KWzTB5EeDUbd/lQK0ZrZBindxVQ==", null, false, "", false, "KostaKotev" },
                    { "799aa214-726c-4e61-8033-5c10607fd0ee", 0, "aad29f8a-02b9-4146-acad-8bf154537830", "supplier@mail.com", true, null, false, null, "supplier@mail.com", "OGNO2020", "AQAAAAEAACcQAAAAEEToSbMsB8fhboKjKQDpFE3J0k+hh/huI5MxalruDRndWH5M/atrBDPBrXOVQVGjjw==", null, false, "", false, "ogno2020" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "799aa214-726c-4e61-8033-5c10607fd0ee", "7881c850-e14d-4ec9-bbe6-8194b87bad6d" },
                    { "6ae2bff4-400a-44ca-bccb-87427d6a7c5e", "0da9f1d2-793c-4e74-9a11-9eb8936a7892" },
                    { "4fdbebc5-0630-4bf9-be03-af1c56bb71a6", "445a2f60-56c3-4ed3-93aa-51eb639ee56a" },
                    { "4c235923-67b7-4a55-b143-06aee6c5dbe6", "26855d8d-7830-4168-8056-ac5d44cca830" },
                    { "9059516b-b422-4318-bd67-81fc04f1e08d", "de684694-6eb9-40f1-8f5a-0b7a35fbde2c" },
                    { "8df4b0fb-2c14-4145-bd0b-db8e4868e1b8", "4da32ba5-f1b4-46f9-85eb-2406ea24a9f5" },
                    { "76e71c29-8207-4331-a25f-33ded68b11cd", "5ea29778-e091-4c45-9d27-2ad5cac2108c" },
                    { "ecf10134-b3f8-4ea2-aaa6-62615e83c5bc", "105fa72e-36a9-4df4-974d-52d66337409d" },
                    { "52e3ebb6-8a62-47a7-8962-69fa83790d64", "02928ea6-d28b-48ed-aeda-c63a437b95ce" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "0bad4ec9-a6b9-4cef-adec-e8699f748522", "b6abb990-6d43-4798-bd12-3bb4dbafc8de" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "4c235923-67b7-4a55-b143-06aee6c5dbe6", "26855d8d-7830-4168-8056-ac5d44cca830" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "4fdbebc5-0630-4bf9-be03-af1c56bb71a6", "445a2f60-56c3-4ed3-93aa-51eb639ee56a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "52e3ebb6-8a62-47a7-8962-69fa83790d64", "02928ea6-d28b-48ed-aeda-c63a437b95ce" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "6ae2bff4-400a-44ca-bccb-87427d6a7c5e", "0da9f1d2-793c-4e74-9a11-9eb8936a7892" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "76e71c29-8207-4331-a25f-33ded68b11cd", "5ea29778-e091-4c45-9d27-2ad5cac2108c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "799aa214-726c-4e61-8033-5c10607fd0ee", "7881c850-e14d-4ec9-bbe6-8194b87bad6d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "8df4b0fb-2c14-4145-bd0b-db8e4868e1b8", "4da32ba5-f1b4-46f9-85eb-2406ea24a9f5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "9059516b-b422-4318-bd67-81fc04f1e08d", "de684694-6eb9-40f1-8f5a-0b7a35fbde2c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "ecf10134-b3f8-4ea2-aaa6-62615e83c5bc", "105fa72e-36a9-4df4-974d-52d66337409d" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "ac25ac17-c6f1-488e-9656-5d79d6597b1e", "1a9af5d4-51f0-46c0-babe-0eb9cd407c7c" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "02928ea6-d28b-48ed-aeda-c63a437b95ce", "eb7d8a7f-9c22-4316-b04d-b5e06a626370" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "0da9f1d2-793c-4e74-9a11-9eb8936a7892", "cc310c59-01a8-4fdb-9bdc-50591ba83b39" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "105fa72e-36a9-4df4-974d-52d66337409d", "c24c8bd3-ffdf-41b9-8f56-c91c3b5c9725" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "26855d8d-7830-4168-8056-ac5d44cca830", "37d3ce04-e227-4a33-a8b9-4de023fcb842" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "445a2f60-56c3-4ed3-93aa-51eb639ee56a", "2e044ed9-1037-4c2d-bd84-ebcf01d76df3" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "4da32ba5-f1b4-46f9-85eb-2406ea24a9f5", "9d93926d-4ed9-4e20-974d-e65c945954c4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "5ea29778-e091-4c45-9d27-2ad5cac2108c", "ce1caad1-a69e-438b-8470-b468b6e5c346" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "7881c850-e14d-4ec9-bbe6-8194b87bad6d", "e71a8f44-2035-44f3-a009-02c19c4004b5" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "de684694-6eb9-40f1-8f5a-0b7a35fbde2c", "26eb73e8-c1bb-4b70-8a2b-889e2c031659" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "4c235923-67b7-4a55-b143-06aee6c5dbe6", "18bbce31-a33d-4304-b4e5-b4b4628a0a53" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "4fdbebc5-0630-4bf9-be03-af1c56bb71a6", "a34ebb39-348d-4560-aec6-018432709aa0" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "52e3ebb6-8a62-47a7-8962-69fa83790d64", "799b7588-2d96-4fa1-94ac-c0fee9718a07" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "6ae2bff4-400a-44ca-bccb-87427d6a7c5e", "dad664a8-bc0e-4a08-b340-fc2bb030191f" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "76e71c29-8207-4331-a25f-33ded68b11cd", "cc706f26-045f-442c-aea5-8742822946d3" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "799aa214-726c-4e61-8033-5c10607fd0ee", "aad29f8a-02b9-4146-acad-8bf154537830" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "8df4b0fb-2c14-4145-bd0b-db8e4868e1b8", "a0ea209b-d042-4827-a2f6-03fce551bb0a" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "9059516b-b422-4318-bd67-81fc04f1e08d", "c295cb7c-c481-4d10-a9b8-d1ac8273864e" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "ecf10134-b3f8-4ea2-aaa6-62615e83c5bc", "2c9ef743-5d4d-4dfa-92f3-327f121971bd" });

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
    }
}
