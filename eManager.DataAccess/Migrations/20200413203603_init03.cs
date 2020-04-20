using Microsoft.EntityFrameworkCore.Migrations;

namespace eManager.DataAccess.Migrations
{
    public partial class init03 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "3d60807a-ca2f-4f63-bde0-238db7a27e09", "eb906938-6562-4392-9afa-c05de0c763b0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "12124c1b-3b0c-490f-af6e-9162a0c9484b", "e7c8a46b-550c-4297-91cb-387cdc1687ca" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "128f5de6-d04b-42cf-8616-c91675271364", "69970900-67d4-47b5-84cd-ed3473619502" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "17ebd250-7a46-4111-9f24-1eee819e1b27", "a4be411b-93dd-43b7-90e2-4b6c7d161f1c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "4f8b9fc7-8d07-4c7c-90f5-c9e7b85f67f3", "21921981-1a02-427f-9936-6524a6049b0a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "82d1c380-d6d6-4218-b8aa-ebad408f31b7", "52ecf43f-9631-4121-8926-69d1216c9563" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "bde5b814-f4ae-4f88-83f3-e2024bbf9fc0", "737092a9-f972-43dd-b35c-beede74b480b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "c2c0cbd3-d55a-4a25-a478-814e57803adb", "66c626a0-67e5-4682-ae0d-24e0283a05c6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "c9405584-4c9d-4eb5-a6c0-c79bd495d29a", "92a77ff3-61d5-4d66-b2fd-8a020fec0223" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "fddf4df1-ebe0-43ee-b8c7-2b4d114a504a", "b47bcb71-c566-47fc-a533-303f9f4cb5a5" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "ed9e55c7-e443-4fe3-a3e2-b5746a7e268d", "cbf815f3-bfd2-4d06-99ac-db3a71760541" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "21921981-1a02-427f-9936-6524a6049b0a", "3276b2fe-7253-4b5f-b0bf-451273476c61" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "52ecf43f-9631-4121-8926-69d1216c9563", "db205776-4e29-4e7b-8105-bacc8c7e602d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "66c626a0-67e5-4682-ae0d-24e0283a05c6", "8e2be5a2-1f87-478d-9e21-5833b97c7247" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "69970900-67d4-47b5-84cd-ed3473619502", "2619f647-4701-4b30-a425-a6c12bbc2ea1" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "737092a9-f972-43dd-b35c-beede74b480b", "669694eb-eaa5-4753-9325-47011d63c255" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "92a77ff3-61d5-4d66-b2fd-8a020fec0223", "f38c9604-e322-400f-9772-08d8fc72a717" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "a4be411b-93dd-43b7-90e2-4b6c7d161f1c", "cdb64235-3859-46c5-a62d-4e231e02705d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "b47bcb71-c566-47fc-a533-303f9f4cb5a5", "6e4b4836-543e-4bb2-8229-3c9cdf1cad38" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "e7c8a46b-550c-4297-91cb-387cdc1687ca", "a24b1b20-0d74-4f07-9ba0-305e2dfa3e11" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "12124c1b-3b0c-490f-af6e-9162a0c9484b", "1143c591-f97d-43d6-91cc-2b9634f9d19e" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "128f5de6-d04b-42cf-8616-c91675271364", "5a0a547a-d18a-4f98-b0ca-d45335f39e54" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "17ebd250-7a46-4111-9f24-1eee819e1b27", "553684cc-eac7-4921-9572-1e2ec53c12f7" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "4f8b9fc7-8d07-4c7c-90f5-c9e7b85f67f3", "4b9206e7-ac9e-45ac-9afb-f9a418a0e252" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "82d1c380-d6d6-4218-b8aa-ebad408f31b7", "194e128e-30e2-4605-8361-cfd0957f82d2" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "bde5b814-f4ae-4f88-83f3-e2024bbf9fc0", "26cc6f22-73ce-41a7-bb90-d8081e3286a1" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "c2c0cbd3-d55a-4a25-a478-814e57803adb", "cc0b6c46-2652-4519-915f-4189cc0c9e3e" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "c9405584-4c9d-4eb5-a6c0-c79bd495d29a", "09d15a17-8278-40e3-8916-d4c0645c17fa" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "fddf4df1-ebe0-43ee-b8c7-2b4d114a504a", "e2de6d41-a475-44fc-b33f-9a9e15800f0e" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "92a77ff3-61d5-4d66-b2fd-8a020fec0223", "f38c9604-e322-400f-9772-08d8fc72a717", "userDR", "USERDR" },
                    { "52ecf43f-9631-4121-8926-69d1216c9563", "db205776-4e29-4e7b-8105-bacc8c7e602d", "userGK", "USERGK" },
                    { "3d60807a-ca2f-4f63-bde0-238db7a27e09", "eb906938-6562-4392-9afa-c05de0c763b0", "userSP", "USERSP" },
                    { "b47bcb71-c566-47fc-a533-303f9f4cb5a5", "6e4b4836-543e-4bb2-8229-3c9cdf1cad38", "userEN", "USEREN" },
                    { "66c626a0-67e5-4682-ae0d-24e0283a05c6", "8e2be5a2-1f87-478d-9e21-5833b97c7247", "userAMG", "USERAMG" },
                    { "e7c8a46b-550c-4297-91cb-387cdc1687ca", "a24b1b20-0d74-4f07-9ba0-305e2dfa3e11", "userTP", "USERTP" },
                    { "a4be411b-93dd-43b7-90e2-4b6c7d161f1c", "cdb64235-3859-46c5-a62d-4e231e02705d", "userSN", "USERSN" },
                    { "21921981-1a02-427f-9936-6524a6049b0a", "3276b2fe-7253-4b5f-b0bf-451273476c61", "userVP", "USERVP" },
                    { "69970900-67d4-47b5-84cd-ed3473619502", "2619f647-4701-4b30-a425-a6c12bbc2ea1", "admin", "ADMIN" },
                    { "737092a9-f972-43dd-b35c-beede74b480b", "669694eb-eaa5-4753-9325-47011d63c255", "userKK", "USERKK" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "c9405584-4c9d-4eb5-a6c0-c79bd495d29a", 0, "09d15a17-8278-40e3-8916-d4c0645c17fa", "kotev@ognootporno.com.mk", true, "Драге Ристевски", false, null, "kotev@ognootporno.com.mk", "DRAGERISTEVSKI", "AQAAAAEAACcQAAAAEDDisj4bI8a40YHbfmHmkflYy3X15KEXT20Gp462VVT+Vy9BpxfpgjVPQJpAC8Xdkg==", null, false, "", false, "DrageRistevski" },
                    { "82d1c380-d6d6-4218-b8aa-ebad408f31b7", 0, "194e128e-30e2-4605-8361-cfd0957f82d2", "kotev@ognootporno.com.mk", true, "Горан Котев", false, null, "kotev@ognootporno.com.mk", "GORANKOTEV", "AQAAAAEAACcQAAAAEGaYsMqfexQRAVdc0vhEFndjD9ouk666UYreKYDkwGJ8X6ePFawV8MY83rqEZF0Hcw==", null, false, "", false, "GoranKotev" },
                    { "ed9e55c7-e443-4fe3-a3e2-b5746a7e268d", 0, "cbf815f3-bfd2-4d06-99ac-db3a71760541", "peshovski@ognootporno.com.mk", true, "Сашо Пешовски", false, null, "peshovski@ognootporno.com.mk", "SASHOPESHOVSKI", "AQAAAAEAACcQAAAAEBeM5Lc/jq6zQVMb6xniDmsu31KhoI7pYKEKVf9Oc23mSNR7o5QPsVnHwNLG1C6cUQ==", null, false, "", false, "SashoPeshovski" },
                    { "fddf4df1-ebe0-43ee-b8c7-2b4d114a504a", 0, "e2de6d41-a475-44fc-b33f-9a9e15800f0e", "nikolchov@ognootporno.com.mk", true, "Евтим Николчов", false, null, "nikolchov@ognootporno.com.mk", "EVTIMNIKOLCHOV", "AQAAAAEAACcQAAAAENuq09kT+Ga9n8zXOqQIg/Ah6f3EBvnGx9JZlfqaCNptAYSuIkdtakfBQnw0lRBzrQ==", null, false, "", false, "EvtimNikolchov" },
                    { "c2c0cbd3-d55a-4a25-a478-814e57803adb", 0, "cc0b6c46-2652-4519-915f-4189cc0c9e3e", "mirkovska@ognootporno.com.mk", true, "Ана Мирковска Гаврилов", false, null, "mirkovska@ognootporno.com.mk", "ANAMIRKOVSKAGAVRILOV", "AQAAAAEAACcQAAAAEOx0xbK6WmHJjSvmRQLE5xvvIRm2DWZMQtxeiNXBF9kz0Ps0wdAQ2pKlLJ+u8q3JtQ==", null, false, "", false, "AnaMGavrilov" },
                    { "12124c1b-3b0c-490f-af6e-9162a0c9484b", 0, "1143c591-f97d-43d6-91cc-2b9634f9d19e", "peshovski@ognootporno.com.mk", true, "Тони Пешевски", false, null, "peshovski@ognootporno.com.mk", "TONIPESHEVSKI", "AQAAAAEAACcQAAAAENLJolSRSw+3gWnLQ3Kk/Y5c0f9PKn4DC89y9WJUyWR4mbmngcvXxSJb87Sg1I8ctg==", null, false, "", false, "ToniPeshevski" },
                    { "17ebd250-7a46-4111-9f24-1eee819e1b27", 0, "553684cc-eac7-4921-9572-1e2ec53c12f7", "nikolchov@ognootporno.com.mk", true, "Сашо Николчов", false, null, "nikolchov@ognootporno.com.mk", "SASHONIKOLCHOV", "AQAAAAEAACcQAAAAEJ1YZ/2nbP6V3bNOZWfUV/jKNv94L1yIePnblLnCabvNT6CCy5S9HIDjLkR+nFKlcQ==", null, false, "", false, "SashoNikolchov" },
                    { "4f8b9fc7-8d07-4c7c-90f5-c9e7b85f67f3", 0, "4b9206e7-ac9e-45ac-9afb-f9a418a0e252", "planojevic@ognootporno.com.mk", true, "Владимир Планојевиќ", false, null, "PLANOJEVIC@OGNOOTPORNO.COM.MK", "VPLAN", "AQAAAAEAACcQAAAAEGpsS7iJZtrizR2A4c63iKviQbn+5NFy7FxHYbvE4KRKCjBMyN2ifR15sQo8yn0juA==", null, false, "", false, "VPlan" },
                    { "bde5b814-f4ae-4f88-83f3-e2024bbf9fc0", 0, "26cc6f22-73ce-41a7-bb90-d8081e3286a1", "kotev@ognootporno.com.mk", true, "Коста Котев", false, null, "kotev@ognootporno.com.mk", "KOSTAKOTEV", "AQAAAAEAACcQAAAAEM9ectx0/Mp1TFJmCAZa2tb/yDshGA91GKXypEasB3MNaadiUCpjKYKG68RwhUCNBg==", null, false, "", false, "KostaKotev" },
                    { "128f5de6-d04b-42cf-8616-c91675271364", 0, "5a0a547a-d18a-4f98-b0ca-d45335f39e54", "supplier@mail.com", true, null, false, null, "supplier@mail.com", "Ognootporno2020", "AQAAAAEAACcQAAAAEAqKSBVLiojDq92EAWK8wO/o4MHVJ3GGhHiNezzo1XfQ1uz/cpKbw8fVCgv8JEy2cQ==", null, false, "", false, "ogno2020" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "128f5de6-d04b-42cf-8616-c91675271364", "69970900-67d4-47b5-84cd-ed3473619502" },
                    { "4f8b9fc7-8d07-4c7c-90f5-c9e7b85f67f3", "21921981-1a02-427f-9936-6524a6049b0a" },
                    { "17ebd250-7a46-4111-9f24-1eee819e1b27", "a4be411b-93dd-43b7-90e2-4b6c7d161f1c" },
                    { "12124c1b-3b0c-490f-af6e-9162a0c9484b", "e7c8a46b-550c-4297-91cb-387cdc1687ca" },
                    { "c2c0cbd3-d55a-4a25-a478-814e57803adb", "66c626a0-67e5-4682-ae0d-24e0283a05c6" },
                    { "fddf4df1-ebe0-43ee-b8c7-2b4d114a504a", "b47bcb71-c566-47fc-a533-303f9f4cb5a5" },
                    { "82d1c380-d6d6-4218-b8aa-ebad408f31b7", "52ecf43f-9631-4121-8926-69d1216c9563" },
                    { "bde5b814-f4ae-4f88-83f3-e2024bbf9fc0", "737092a9-f972-43dd-b35c-beede74b480b" },
                    { "c9405584-4c9d-4eb5-a6c0-c79bd495d29a", "92a77ff3-61d5-4d66-b2fd-8a020fec0223" }
                });
        }
    }
}
