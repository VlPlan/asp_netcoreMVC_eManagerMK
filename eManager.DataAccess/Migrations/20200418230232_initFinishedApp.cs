using Microsoft.EntityFrameworkCore.Migrations;

namespace eManager.DataAccess.Migrations
{
    public partial class initFinishedApp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "d2460b08-b174-4fe3-b514-6ec438ab157b", "26670f44-475e-42c5-a167-1a514273e605" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "05fd744b-0ab2-4877-bd83-4f2298029991", "263e2430-9c1e-4d79-9a2b-103113cb62d0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "47fc68ef-6f43-4d48-b360-f9c9851b4b53", "e31b04e7-50d1-4fac-8373-93ce881b6502" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "60a13b30-65f3-48a2-a34c-88a818f3f9c8", "e765e497-766b-4308-ae00-d7a1126616d9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "740c079e-bca4-4a4f-a0ef-5021cab0b0fe", "75defc02-8b05-46ec-8449-ed64bd5141e6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a4a60e76-1303-4459-9261-67b851474db0", "00967429-1b84-4881-bf36-715154e3acaa" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "af876711-298e-4c84-8dd5-1a5eef2eaa4c", "f99f3c4d-8c06-4afc-9042-ca1a697449ce" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "b3743bbd-a69f-401b-8b87-3962d7a9f1a8", "4566f3dc-33e3-4fad-8060-5d6b3d630ede" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "e9204fc7-a98f-40be-8fc1-4efdafa56da7", "b8951702-d981-49de-a87c-ea927c8e7afe" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "ef7a1828-e219-42cc-b881-547e5a85acb0", "09def062-c59b-4dd9-b490-39f4e6fc22b6" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "7e8b0400-bf7d-4b82-8529-c34c4db933af", "0053e724-6605-4676-a9b0-5a9725f721f9" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "00967429-1b84-4881-bf36-715154e3acaa", "a47af132-6d79-4444-8e23-3a41a5863edc" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "09def062-c59b-4dd9-b490-39f4e6fc22b6", "63e92057-0225-4ef1-9869-faace8247d86" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "263e2430-9c1e-4d79-9a2b-103113cb62d0", "ab4ae0c4-a06b-4f8f-8bda-88bd40f2b4a4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "4566f3dc-33e3-4fad-8060-5d6b3d630ede", "e7a084db-07c4-4cdb-9374-9f51b4d9ab82" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "75defc02-8b05-46ec-8449-ed64bd5141e6", "2c822646-10a2-46ac-a6ec-2953ae816ab2" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "b8951702-d981-49de-a87c-ea927c8e7afe", "3fc7e8e9-152e-4787-af01-6c77e1ce0f2d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "e31b04e7-50d1-4fac-8373-93ce881b6502", "7c38e765-dd1d-460d-a563-b89f13db4189" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "e765e497-766b-4308-ae00-d7a1126616d9", "e13431c2-09ce-4408-93ab-d9e8f749f9ad" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "f99f3c4d-8c06-4afc-9042-ca1a697449ce", "54f4278f-2d1d-4a21-8585-fb324250749c" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "05fd744b-0ab2-4877-bd83-4f2298029991", "a4112e30-b24f-41f8-97e7-f459729f539c" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "47fc68ef-6f43-4d48-b360-f9c9851b4b53", "b7566e4e-834c-409e-bc5e-8f25b2dc1ba0" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "60a13b30-65f3-48a2-a34c-88a818f3f9c8", "5b3501fd-24b5-4e44-b720-6a5166fbef78" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "740c079e-bca4-4a4f-a0ef-5021cab0b0fe", "3f02f56e-4372-4fd9-85e1-490c5e5eed55" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "a4a60e76-1303-4459-9261-67b851474db0", "45124bca-8d8a-4e16-8be3-9d51bb04a8fb" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "af876711-298e-4c84-8dd5-1a5eef2eaa4c", "cc8beb11-384f-47d0-b7bf-0ed9a09f740d" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "b3743bbd-a69f-401b-8b87-3962d7a9f1a8", "b96f503d-a59c-44fc-b103-2dea88cc9f0c" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "e9204fc7-a98f-40be-8fc1-4efdafa56da7", "f29bc8fb-9b58-4f19-8271-14e758822d16" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "ef7a1828-e219-42cc-b881-547e5a85acb0", "5efffe13-84dd-4e55-9ad1-2490b2126dd8" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "22eff4a2-ff15-480f-aaf5-fd8073d04ead", "8eb0894e-c854-4f89-8633-df389865b50a", "userDR", "USERDR" },
                    { "7818b79d-46e9-452a-ac29-0ecbadbd7f4e", "0c9858d3-6af9-41be-aca7-cc0f088a117d", "userGK", "USERGK" },
                    { "5c35675c-d611-4cdd-8852-8cfe3311918e", "5e509672-385e-408a-bf87-37b6129a8706", "userSP", "USERSP" },
                    { "df9c93f9-1f8a-44a8-a5aa-0691d654d385", "1dd15ef9-991e-487f-9259-1ab0a191d184", "userEN", "USEREN" },
                    { "16d4fbb8-6fdd-40a7-89b7-a7b6f174b84f", "2cdbe82b-e5c8-4e36-af4a-8d8d249d0521", "userAMG", "USERAMG" },
                    { "837cd8ab-c342-4347-b161-69bc909f96d1", "3a88fdc4-4083-46a1-b4f5-d298f33de0de", "userTP", "USERTP" },
                    { "d65bdabc-96f2-428c-947b-63c26e2ef445", "24215527-9845-443e-8e0f-a34dc65a4470", "userSN", "USERSN" },
                    { "ca8029f4-34d8-43f7-9a07-38c0201bb1b7", "5dbd0f9c-60d5-4b82-99a6-f6fc2999305a", "userVP", "USERVP" },
                    { "e4d77800-25d4-44f3-8612-40998e4cc98d", "708adf6b-2d4d-401f-8a71-9c7f2a385a11", "admin", "ADMIN" },
                    { "1a55db48-9633-44db-9614-43885fcfa90b", "0377f7bd-44f6-4070-a3dc-d83cb550ce2e", "userKK", "USERKK" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "4d5a45df-24b0-474b-aaf3-bfafe60e1b7b", 0, "8a21b9a9-3b3b-4e98-ab58-63a5190c41e4", "kotev@ognootporno.com.mk", true, "Драге Ристевски", false, null, "kotev@ognootporno.com.mk", "DRAGERISTEVSKI", "AQAAAAEAACcQAAAAEAGF6o6jR+tNw7eIkBOiX/8UX2TkgiCZwORqbdiz5PqRMJJbKDEaPV0tqbxSuztoZg==", null, false, "", false, "DrageRistevski" },
                    { "f45b2d91-e407-4e8b-b102-fc40c5ff8551", 0, "a653a1cb-66c5-440a-a6ee-cd526ff9b109", "kotev@ognootporno.com.mk", true, "Горан Котев", false, null, "kotev@ognootporno.com.mk", "GORANKOTEV", "AQAAAAEAACcQAAAAEHe3QgjYONpvWDqJYAkHt+KOfO2NFv/5c7UIGozKlRamP7eQ60Jl9cVtuSGiDKMRFg==", null, false, "", false, "GoranKotev" },
                    { "e0f17503-c127-4f35-89fa-13eaf2101898", 0, "f193e62e-c084-404f-b217-e9cf38d2f6cb", "peshovski@ognootporno.com.mk", true, "Сашо Пешовски", false, null, "peshovski@ognootporno.com.mk", "SASHOPESHOVSKI", "AQAAAAEAACcQAAAAEO/9pJ4NzZL8F91am1h5GxY29101dXoKmCTNhQ4vMGllZTFi58Dg4vStw+Ep8CrImg==", null, false, "", false, "SashoPeshovski" },
                    { "70cabd54-a691-49c9-bd87-26927d75761e", 0, "88aa81b1-11d7-4e71-8a6b-d125eeb2b7b9", "nikolchov@ognootporno.com.mk", true, "Евтим Николчов", false, null, "nikolchov@ognootporno.com.mk", "EVTIMNIKOLCHOV", "AQAAAAEAACcQAAAAEAwKdTPHAqAZYaoUbKVOS06FWQjomW/72VXTGAg7xTNfRsB76oFJRkJurEf3UwRDNw==", null, false, "", false, "EvtimNikolchov" },
                    { "bc0151e0-df0a-4029-93b1-37575ce49164", 0, "c16e9cb4-fb20-48e1-8d6a-be83c5ab1812", "mirkovska@ognootporno.com.mk", true, "Ана Мирковска Гаврилов", false, null, "mirkovska@ognootporno.com.mk", "ANAMIRKOVSKAGAVRILOV", "AQAAAAEAACcQAAAAEAuqJU2Qb0S3zGp8eTGZsCn83b0d32a7Vm9oYdS8lp1F0QPja4ziwluH5Kfc08k5gA==", null, false, "", false, "AnaMGavrilov" },
                    { "96f31ecd-37db-418f-8bec-04827200aa87", 0, "2aae89da-560d-47ee-9c8e-90023de74025", "peshovski@ognootporno.com.mk", true, "Тони Пешевски", false, null, "peshovski@ognootporno.com.mk", "TONIPESHEVSKI", "AQAAAAEAACcQAAAAEDZz8OUNZ9PZCptqhwQe/Ym9zsJpUJgzUizSw/KF0s4RwvTRX7alynoi8ytcWU8Euw==", null, false, "", false, "ToniPeshevski" },
                    { "d9d5f664-5e12-4362-aeaf-caa613dde4c1", 0, "cff69510-5914-4d49-bc40-418097e58638", "nikolchov@ognootporno.com.mk", true, "Сашо Николчов", false, null, "nikolchov@ognootporno.com.mk", "SASHONIKOLCHOV", "AQAAAAEAACcQAAAAEEqyBEgBc6pkLOJcWmKrD7d1AiAS6dnbL/UA1B9XQsWtSRsJpvcXus+aCVNkJOBUVA==", null, false, "", false, "SashoNikolchov" },
                    { "c825e48a-b069-4600-b710-5e3683c52c50", 0, "1f7f908a-00d9-4470-b637-5e6c949e7cee", "planojevic@ognootporno.com.mk", true, "Владимир Планојевиќ", false, null, "PLANOJEVIC@OGNOOTPORNO.COM.MK", "VLADPLAN", "AQAAAAEAACcQAAAAEIQs7SCEDngFmrFoq+lSINX+Gn+3Renm8KliwWVvGy9P2GCyUA8Y8BFGBJ2tBDYDwQ==", null, false, "", false, "VladPlan" },
                    { "64d19830-fa1e-45df-9d47-a809774b5142", 0, "4acbcaaa-3841-483e-a8a3-cf09d290d5c2", "kotev@ognootporno.com.mk", true, "Коста Котев", false, null, "kotev@ognootporno.com.mk", "KOSTAKOTEV", "AQAAAAEAACcQAAAAECpeq9+z12uRrxYALt10MI2IndRMNlTfrVrNjAWMIyrVZqC9jskyepAxvfMCCgkJbw==", null, false, "", false, "KostaKotev" },
                    { "670b6e4b-1d2c-4bcd-9f0f-a885f9a95771", 0, "1e7932ed-354f-4580-9007-b264568f7a65", "supplier@mail.com", true, null, false, null, "supplier@mail.com", "OGNO2020", "AQAAAAEAACcQAAAAEFS3eVQ9ttqxW3IEn14M1vplMngcjpChZSyqxMSv2dtQy0Hnnpr8NzVCzmYC0dboyQ==", null, false, "", false, "ogno2020" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "670b6e4b-1d2c-4bcd-9f0f-a885f9a95771", "e4d77800-25d4-44f3-8612-40998e4cc98d" },
                    { "c825e48a-b069-4600-b710-5e3683c52c50", "ca8029f4-34d8-43f7-9a07-38c0201bb1b7" },
                    { "d9d5f664-5e12-4362-aeaf-caa613dde4c1", "d65bdabc-96f2-428c-947b-63c26e2ef445" },
                    { "96f31ecd-37db-418f-8bec-04827200aa87", "837cd8ab-c342-4347-b161-69bc909f96d1" },
                    { "bc0151e0-df0a-4029-93b1-37575ce49164", "16d4fbb8-6fdd-40a7-89b7-a7b6f174b84f" },
                    { "70cabd54-a691-49c9-bd87-26927d75761e", "df9c93f9-1f8a-44a8-a5aa-0691d654d385" },
                    { "f45b2d91-e407-4e8b-b102-fc40c5ff8551", "7818b79d-46e9-452a-ac29-0ecbadbd7f4e" },
                    { "64d19830-fa1e-45df-9d47-a809774b5142", "1a55db48-9633-44db-9614-43885fcfa90b" },
                    { "4d5a45df-24b0-474b-aaf3-bfafe60e1b7b", "22eff4a2-ff15-480f-aaf5-fd8073d04ead" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "5c35675c-d611-4cdd-8852-8cfe3311918e", "5e509672-385e-408a-bf87-37b6129a8706" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "4d5a45df-24b0-474b-aaf3-bfafe60e1b7b", "22eff4a2-ff15-480f-aaf5-fd8073d04ead" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "64d19830-fa1e-45df-9d47-a809774b5142", "1a55db48-9633-44db-9614-43885fcfa90b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "670b6e4b-1d2c-4bcd-9f0f-a885f9a95771", "e4d77800-25d4-44f3-8612-40998e4cc98d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "70cabd54-a691-49c9-bd87-26927d75761e", "df9c93f9-1f8a-44a8-a5aa-0691d654d385" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "96f31ecd-37db-418f-8bec-04827200aa87", "837cd8ab-c342-4347-b161-69bc909f96d1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "bc0151e0-df0a-4029-93b1-37575ce49164", "16d4fbb8-6fdd-40a7-89b7-a7b6f174b84f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "c825e48a-b069-4600-b710-5e3683c52c50", "ca8029f4-34d8-43f7-9a07-38c0201bb1b7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "d9d5f664-5e12-4362-aeaf-caa613dde4c1", "d65bdabc-96f2-428c-947b-63c26e2ef445" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "f45b2d91-e407-4e8b-b102-fc40c5ff8551", "7818b79d-46e9-452a-ac29-0ecbadbd7f4e" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "e0f17503-c127-4f35-89fa-13eaf2101898", "f193e62e-c084-404f-b217-e9cf38d2f6cb" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "16d4fbb8-6fdd-40a7-89b7-a7b6f174b84f", "2cdbe82b-e5c8-4e36-af4a-8d8d249d0521" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "1a55db48-9633-44db-9614-43885fcfa90b", "0377f7bd-44f6-4070-a3dc-d83cb550ce2e" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "22eff4a2-ff15-480f-aaf5-fd8073d04ead", "8eb0894e-c854-4f89-8633-df389865b50a" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "7818b79d-46e9-452a-ac29-0ecbadbd7f4e", "0c9858d3-6af9-41be-aca7-cc0f088a117d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "837cd8ab-c342-4347-b161-69bc909f96d1", "3a88fdc4-4083-46a1-b4f5-d298f33de0de" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "ca8029f4-34d8-43f7-9a07-38c0201bb1b7", "5dbd0f9c-60d5-4b82-99a6-f6fc2999305a" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "d65bdabc-96f2-428c-947b-63c26e2ef445", "24215527-9845-443e-8e0f-a34dc65a4470" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "df9c93f9-1f8a-44a8-a5aa-0691d654d385", "1dd15ef9-991e-487f-9259-1ab0a191d184" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "e4d77800-25d4-44f3-8612-40998e4cc98d", "708adf6b-2d4d-401f-8a71-9c7f2a385a11" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "4d5a45df-24b0-474b-aaf3-bfafe60e1b7b", "8a21b9a9-3b3b-4e98-ab58-63a5190c41e4" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "64d19830-fa1e-45df-9d47-a809774b5142", "4acbcaaa-3841-483e-a8a3-cf09d290d5c2" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "670b6e4b-1d2c-4bcd-9f0f-a885f9a95771", "1e7932ed-354f-4580-9007-b264568f7a65" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "70cabd54-a691-49c9-bd87-26927d75761e", "88aa81b1-11d7-4e71-8a6b-d125eeb2b7b9" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "96f31ecd-37db-418f-8bec-04827200aa87", "2aae89da-560d-47ee-9c8e-90023de74025" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "bc0151e0-df0a-4029-93b1-37575ce49164", "c16e9cb4-fb20-48e1-8d6a-be83c5ab1812" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "c825e48a-b069-4600-b710-5e3683c52c50", "1f7f908a-00d9-4470-b637-5e6c949e7cee" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "d9d5f664-5e12-4362-aeaf-caa613dde4c1", "cff69510-5914-4d49-bc40-418097e58638" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "f45b2d91-e407-4e8b-b102-fc40c5ff8551", "a653a1cb-66c5-440a-a6ee-cd526ff9b109" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "e31b04e7-50d1-4fac-8373-93ce881b6502", "7c38e765-dd1d-460d-a563-b89f13db4189", "userDR", "USERDR" },
                    { "b8951702-d981-49de-a87c-ea927c8e7afe", "3fc7e8e9-152e-4787-af01-6c77e1ce0f2d", "userGK", "USERGK" },
                    { "d2460b08-b174-4fe3-b514-6ec438ab157b", "26670f44-475e-42c5-a167-1a514273e605", "userSP", "USERSP" },
                    { "263e2430-9c1e-4d79-9a2b-103113cb62d0", "ab4ae0c4-a06b-4f8f-8bda-88bd40f2b4a4", "userEN", "USEREN" },
                    { "09def062-c59b-4dd9-b490-39f4e6fc22b6", "63e92057-0225-4ef1-9869-faace8247d86", "userAMG", "USERAMG" },
                    { "75defc02-8b05-46ec-8449-ed64bd5141e6", "2c822646-10a2-46ac-a6ec-2953ae816ab2", "userTP", "USERTP" },
                    { "4566f3dc-33e3-4fad-8060-5d6b3d630ede", "e7a084db-07c4-4cdb-9374-9f51b4d9ab82", "userSN", "USERSN" },
                    { "f99f3c4d-8c06-4afc-9042-ca1a697449ce", "54f4278f-2d1d-4a21-8585-fb324250749c", "userVP", "USERVP" },
                    { "00967429-1b84-4881-bf36-715154e3acaa", "a47af132-6d79-4444-8e23-3a41a5863edc", "admin", "ADMIN" },
                    { "e765e497-766b-4308-ae00-d7a1126616d9", "e13431c2-09ce-4408-93ab-d9e8f749f9ad", "userKK", "USERKK" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "47fc68ef-6f43-4d48-b360-f9c9851b4b53", 0, "b7566e4e-834c-409e-bc5e-8f25b2dc1ba0", "kotev@ognootporno.com.mk", true, "Драге Ристевски", false, null, "kotev@ognootporno.com.mk", "DRAGERISTEVSKI", "AQAAAAEAACcQAAAAECiNYZiaR+UpignrD8xOVaUcUNE493Ds1Qj6df6KLRs14+zujXfNv+WTSizm3HRRbA==", null, false, "", false, "DrageRistevski" },
                    { "e9204fc7-a98f-40be-8fc1-4efdafa56da7", 0, "f29bc8fb-9b58-4f19-8271-14e758822d16", "kotev@ognootporno.com.mk", true, "Горан Котев", false, null, "kotev@ognootporno.com.mk", "GORANKOTEV", "AQAAAAEAACcQAAAAEDRz0wUkkf661sO9gDsxzEZOlFCahC+iACH4hDJrmePgFCa0g7vG8k5Y7NvntzdSxQ==", null, false, "", false, "GoranKotev" },
                    { "7e8b0400-bf7d-4b82-8529-c34c4db933af", 0, "0053e724-6605-4676-a9b0-5a9725f721f9", "peshovski@ognootporno.com.mk", true, "Сашо Пешовски", false, null, "peshovski@ognootporno.com.mk", "SASHOPESHOVSKI", "AQAAAAEAACcQAAAAEJa604tDxwEK6hDgs8jttMP7mu16NglGB7mRuMycdV6tF++FrUuY6n+g+h2Dcp9UDA==", null, false, "", false, "SashoPeshovski" },
                    { "05fd744b-0ab2-4877-bd83-4f2298029991", 0, "a4112e30-b24f-41f8-97e7-f459729f539c", "nikolchov@ognootporno.com.mk", true, "Евтим Николчов", false, null, "nikolchov@ognootporno.com.mk", "EVTIMNIKOLCHOV", "AQAAAAEAACcQAAAAEPzpg61A5sUGw7SOGkJezTRShT9dSO4GkjCMusDaCdSn/sfb2ImzfLATknAGlkKefQ==", null, false, "", false, "EvtimNikolchov" },
                    { "ef7a1828-e219-42cc-b881-547e5a85acb0", 0, "5efffe13-84dd-4e55-9ad1-2490b2126dd8", "mirkovska@ognootporno.com.mk", true, "Ана Мирковска Гаврилов", false, null, "mirkovska@ognootporno.com.mk", "ANAMIRKOVSKAGAVRILOV", "AQAAAAEAACcQAAAAEOWQBC4OA4H73SIWzlPFmCyXBqxO/fgOUCHXS/A95cT7pjMqTWGI02x8dHzCORaulA==", null, false, "", false, "AnaMGavrilov" },
                    { "740c079e-bca4-4a4f-a0ef-5021cab0b0fe", 0, "3f02f56e-4372-4fd9-85e1-490c5e5eed55", "peshovski@ognootporno.com.mk", true, "Тони Пешевски", false, null, "peshovski@ognootporno.com.mk", "TONIPESHEVSKI", "AQAAAAEAACcQAAAAEICbu27pRRMxWzzz5cNMEEn/dRca3qkxojCz5Q1tLqWXuniPtEoE4gXDflS0xt+izA==", null, false, "", false, "ToniPeshevski" },
                    { "b3743bbd-a69f-401b-8b87-3962d7a9f1a8", 0, "b96f503d-a59c-44fc-b103-2dea88cc9f0c", "nikolchov@ognootporno.com.mk", true, "Сашо Николчов", false, null, "nikolchov@ognootporno.com.mk", "SASHONIKOLCHOV", "AQAAAAEAACcQAAAAEA6g0KYBw42rLAY7lo8nmR0TOBlsMl5ZOXLgIPO1zx9+L4NYTgcaYmeVQpOoc+w9fg==", null, false, "", false, "SashoNikolchov" },
                    { "af876711-298e-4c84-8dd5-1a5eef2eaa4c", 0, "cc8beb11-384f-47d0-b7bf-0ed9a09f740d", "planojevic@ognootporno.com.mk", true, "Владимир Планојевиќ", false, null, "PLANOJEVIC@OGNOOTPORNO.COM.MK", "VPLAN", "AQAAAAEAACcQAAAAEGkI6GQe0OcMHYgmF5+Bm9J5e+9sdm7tURcXR9YloTLZzKH3Q1TV+IJlMGPYsFezVw==", null, false, "", false, "VPlan" },
                    { "60a13b30-65f3-48a2-a34c-88a818f3f9c8", 0, "5b3501fd-24b5-4e44-b720-6a5166fbef78", "kotev@ognootporno.com.mk", true, "Коста Котев", false, null, "kotev@ognootporno.com.mk", "KOSTAKOTEV", "AQAAAAEAACcQAAAAEF6+CinqRExg/gOKvWmhbAZVfps/Qg4ddCXVAaSDLl507ibATbMPU7fzy+m4x6RMhg==", null, false, "", false, "KostaKotev" },
                    { "a4a60e76-1303-4459-9261-67b851474db0", 0, "45124bca-8d8a-4e16-8be3-9d51bb04a8fb", "supplier@mail.com", true, null, false, null, "supplier@mail.com", "OGNO2020", "AQAAAAEAACcQAAAAEFZV4i7fAzMENfxWcOLeDlLHomVWZ3ScLt0BVX61ER288W/CLMlButMrwZLN6NBf4Q==", null, false, "", false, "ogno2020" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "a4a60e76-1303-4459-9261-67b851474db0", "00967429-1b84-4881-bf36-715154e3acaa" },
                    { "af876711-298e-4c84-8dd5-1a5eef2eaa4c", "f99f3c4d-8c06-4afc-9042-ca1a697449ce" },
                    { "b3743bbd-a69f-401b-8b87-3962d7a9f1a8", "4566f3dc-33e3-4fad-8060-5d6b3d630ede" },
                    { "740c079e-bca4-4a4f-a0ef-5021cab0b0fe", "75defc02-8b05-46ec-8449-ed64bd5141e6" },
                    { "ef7a1828-e219-42cc-b881-547e5a85acb0", "09def062-c59b-4dd9-b490-39f4e6fc22b6" },
                    { "05fd744b-0ab2-4877-bd83-4f2298029991", "263e2430-9c1e-4d79-9a2b-103113cb62d0" },
                    { "e9204fc7-a98f-40be-8fc1-4efdafa56da7", "b8951702-d981-49de-a87c-ea927c8e7afe" },
                    { "60a13b30-65f3-48a2-a34c-88a818f3f9c8", "e765e497-766b-4308-ae00-d7a1126616d9" },
                    { "47fc68ef-6f43-4d48-b360-f9c9851b4b53", "e31b04e7-50d1-4fac-8373-93ce881b6502" }
                });
        }
    }
}
