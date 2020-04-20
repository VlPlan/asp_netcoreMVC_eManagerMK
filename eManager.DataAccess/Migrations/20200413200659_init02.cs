using Microsoft.EntityFrameworkCore.Migrations;

namespace eManager.DataAccess.Migrations
{
    public partial class init02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "3dd730c7-99dc-4b96-abfb-2b43beb49ab6", "7218df06-1b80-4d9f-854a-427fd53f45c5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "04ae630f-f150-4376-8aa2-58ddbdff16f4", "654b93dd-94f6-4982-aa24-9829cb05d610" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "3bfa5fbc-9068-4c1c-bb40-17e06150cca9", "75f60987-fd94-4455-b856-29b0725fe15a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "408d1fa3-b202-4d88-942e-349b9124d770", "cd9da9f8-b54d-4948-b069-e3a9d914bb12" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "589892ea-599f-44b2-a18e-e6bd7a4c98c1", "25721278-4863-4b8c-aecb-d395e9dc1938" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "628e3958-277b-4810-ad1f-ec6cbb9f6543", "992210eb-ed3c-44d5-9f06-bfbd27d17cfb" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "8c3918bd-10bd-4dc5-ac0a-53fadf92e988", "5f8a6ce5-e648-496a-ba9a-8f0970072457" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "bffb94e1-8c6a-4ef0-b872-64dd1ec9cc74", "8f6dedc5-21a7-4b2a-b29e-be975ac725b1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "cd59e64a-bd79-49fd-9119-97ac7f7b9af3", "6f8c54d6-e093-4228-95c5-999303eb3fa2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "edb32e55-3157-47f8-a362-42b98742b03b", "f7e9146a-2cbd-4159-bd5e-cd55b86eb065" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "619a7138-26b0-4109-83e4-56791a324cf1", "db57be36-c242-4cf3-a840-88da8421f40e" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "25721278-4863-4b8c-aecb-d395e9dc1938", "6d7c4032-412d-49d3-9a4e-07e52382dcf8" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "5f8a6ce5-e648-496a-ba9a-8f0970072457", "6af09664-5800-4611-bcf5-232e808a79d6" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "654b93dd-94f6-4982-aa24-9829cb05d610", "83b65f3b-8d14-45e5-9e49-00791fae98e8" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "6f8c54d6-e093-4228-95c5-999303eb3fa2", "5321dfe0-dc0d-43e4-9010-47a90afc3205" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "75f60987-fd94-4455-b856-29b0725fe15a", "8d526a40-ec43-4c0a-8cdd-be18b884e551" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "8f6dedc5-21a7-4b2a-b29e-be975ac725b1", "41daf1b8-a46e-4fa1-9450-d4fd1c0ab740" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "992210eb-ed3c-44d5-9f06-bfbd27d17cfb", "0a119f7d-2fd1-4e0c-a06a-896745e86bee" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "cd9da9f8-b54d-4948-b069-e3a9d914bb12", "058321de-80fd-4129-91f1-889ce9f66187" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "f7e9146a-2cbd-4159-bd5e-cd55b86eb065", "1e4c0a5d-35fb-4e80-8ab5-c55b9a13dd11" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "04ae630f-f150-4376-8aa2-58ddbdff16f4", "8b1a67ed-7ee3-4a26-bebf-a55b7135855d" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "3bfa5fbc-9068-4c1c-bb40-17e06150cca9", "d306ea94-fb78-4c69-9695-e5717da45b77" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "408d1fa3-b202-4d88-942e-349b9124d770", "ab68713e-d31e-4564-b106-6bb39457b09c" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "589892ea-599f-44b2-a18e-e6bd7a4c98c1", "8d90920b-8723-4503-a860-14a37eb6126b" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "628e3958-277b-4810-ad1f-ec6cbb9f6543", "cb16cfc7-9483-4b0a-a5c1-19de43f0e508" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "8c3918bd-10bd-4dc5-ac0a-53fadf92e988", "b46d6d94-19b2-4d2b-97c8-53293b7e246e" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "bffb94e1-8c6a-4ef0-b872-64dd1ec9cc74", "19192b76-b5c7-46d4-b77e-dc602b07139a" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "cd59e64a-bd79-49fd-9119-97ac7f7b9af3", "f5a640ac-091f-406b-a70a-d2ea23993cf3" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "edb32e55-3157-47f8-a362-42b98742b03b", "38ac9bce-a2ba-49e6-aded-19924da46bca" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "75f60987-fd94-4455-b856-29b0725fe15a", "8d526a40-ec43-4c0a-8cdd-be18b884e551", "userDR", "USERDR" },
                    { "654b93dd-94f6-4982-aa24-9829cb05d610", "83b65f3b-8d14-45e5-9e49-00791fae98e8", "userGK", "USERGK" },
                    { "3dd730c7-99dc-4b96-abfb-2b43beb49ab6", "7218df06-1b80-4d9f-854a-427fd53f45c5", "userSP", "USERSP" },
                    { "992210eb-ed3c-44d5-9f06-bfbd27d17cfb", "0a119f7d-2fd1-4e0c-a06a-896745e86bee", "userEN", "USEREN" },
                    { "5f8a6ce5-e648-496a-ba9a-8f0970072457", "6af09664-5800-4611-bcf5-232e808a79d6", "userAMG", "USERAMG" },
                    { "25721278-4863-4b8c-aecb-d395e9dc1938", "6d7c4032-412d-49d3-9a4e-07e52382dcf8", "userTP", "USERTP" },
                    { "6f8c54d6-e093-4228-95c5-999303eb3fa2", "5321dfe0-dc0d-43e4-9010-47a90afc3205", "userSN", "USERSN" },
                    { "cd9da9f8-b54d-4948-b069-e3a9d914bb12", "058321de-80fd-4129-91f1-889ce9f66187", "userVP", "USERVP" },
                    { "8f6dedc5-21a7-4b2a-b29e-be975ac725b1", "41daf1b8-a46e-4fa1-9450-d4fd1c0ab740", "admin", "ADMIN" },
                    { "f7e9146a-2cbd-4159-bd5e-cd55b86eb065", "1e4c0a5d-35fb-4e80-8ab5-c55b9a13dd11", "userKK", "USERKK" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3bfa5fbc-9068-4c1c-bb40-17e06150cca9", 0, "d306ea94-fb78-4c69-9695-e5717da45b77", "kotev@ognootporno.com.mk", true, "Драге Ристевски", false, null, "kotev@ognootporno.com.mk", "DRAGERISTEVSKI", "AQAAAAEAACcQAAAAEAfSTRVY+cDSextKEAlag2JUXOQpG7w82EYNRazPaK4psrF3vm5wfhMRqc4VAKqhSQ==", null, false, "", false, "DrageRistevski" },
                    { "04ae630f-f150-4376-8aa2-58ddbdff16f4", 0, "8b1a67ed-7ee3-4a26-bebf-a55b7135855d", "kotev@ognootporno.com.mk", true, "Горан Котев", false, null, "kotev@ognootporno.com.mk", "GORANKOTEV", "AQAAAAEAACcQAAAAEKZd5k6EdI4d1IbNgFDY3BHKeGvZIhqeI5DHsiIp21OcNySRFL1JGBhVwgDHTKD6sA==", null, false, "", false, "GoranKotev" },
                    { "619a7138-26b0-4109-83e4-56791a324cf1", 0, "db57be36-c242-4cf3-a840-88da8421f40e", "peshovski@ognootporno.com.mk", true, "Сашо Пешовски", false, null, "peshovski@ognootporno.com.mk", "SASHOPESHOVSKI", "AQAAAAEAACcQAAAAEDUkZf8cjqoVN0qG/dqgXpXorBaccOW1tJePgsRwt97QW53JWBw2GNsYvzAXqbuk7Q==", null, false, "", false, "SashoPeshovski" },
                    { "628e3958-277b-4810-ad1f-ec6cbb9f6543", 0, "cb16cfc7-9483-4b0a-a5c1-19de43f0e508", "nikolchov@ognootporno.com.mk", true, "Евтим Николчов", false, null, "nikolchov@ognootporno.com.mk", "EVTIMNIKOLCHOV", "AQAAAAEAACcQAAAAEL3ns8qdnCzn7vgKpmyuxsycQdAnwAx1o80/ChORWOzjNXx45hhjPoY+TnjJY4qpKQ==", null, false, "", false, "EvtimNikolchov" },
                    { "8c3918bd-10bd-4dc5-ac0a-53fadf92e988", 0, "b46d6d94-19b2-4d2b-97c8-53293b7e246e", "mirkovska@ognootporno.com.mk", true, "Ана Мирковска Гаврилов", false, null, "mirkovska@ognootporno.com.mk", "ANAMIRKOVSKAGAVRILOV", "AQAAAAEAACcQAAAAENlRt7Q0HAshWen2FoGCprN/RiFbrepiBabe9l6FsO3l6Sr60XcClIbAC3bz7NGKvw==", null, false, "", false, "AnaMGavrilov" },
                    { "589892ea-599f-44b2-a18e-e6bd7a4c98c1", 0, "8d90920b-8723-4503-a860-14a37eb6126b", "peshovski@ognootporno.com.mk", true, "Тони Пешевски", false, null, "peshovski@ognootporno.com.mk", "TONIPESHEVSKI", "AQAAAAEAACcQAAAAEMVUgLqR6pL4Z9ewVi2djZ6se9FoefNTTz8/7CT4IxGUelkzS/h70l96d104ty1IHA==", null, false, "", false, "ToniPeshevski" },
                    { "cd59e64a-bd79-49fd-9119-97ac7f7b9af3", 0, "f5a640ac-091f-406b-a70a-d2ea23993cf3", "nikolchov@ognootporno.com.mk", true, "Сашо Николчов", false, null, "nikolchov@ognootporno.com.mk", "SASHONIKOLCHOV", "AQAAAAEAACcQAAAAEGOf4Em55GRMdXLs8zYt2s8+UQ17qfoEQ2Sc7ICF/Epn7dnvdlGjiMrMIQ6a81ny0g==", null, false, "", false, "SashoNikolchov" },
                    { "408d1fa3-b202-4d88-942e-349b9124d770", 0, "ab68713e-d31e-4564-b106-6bb39457b09c", "planojevic@ognootporno.com.mk", true, "Владимир Планојевиќ", false, null, "PLANOJEVIC@OGNOOTPORNO.COM.MK", "VPLAN", "AQAAAAEAACcQAAAAENEH/pWmzYrkj/V9xu2cOMD+4JWWvrxH5fdaMePVvtf09e4vbPS5/DTmRuJEEgCnKA==", null, false, "", false, "VPlan" },
                    { "edb32e55-3157-47f8-a362-42b98742b03b", 0, "38ac9bce-a2ba-49e6-aded-19924da46bca", "kotev@ognootporno.com.mk", true, "Коста Котев", false, null, "kotev@ognootporno.com.mk", "KOSTAKOTEV", "AQAAAAEAACcQAAAAEBZNBKGMJroSRFaxdR36Zt0W0GajQzZcOR09Jch/vB1ickl/uL5SomHoOZfovDnpqw==", null, false, "", false, "KostaKotev" },
                    { "bffb94e1-8c6a-4ef0-b872-64dd1ec9cc74", 0, "19192b76-b5c7-46d4-b77e-dc602b07139a", "supplier@mail.com", true, null, false, null, "supplier@mail.com", "DB_A57FCC_VPlan1985_admin", "AQAAAAEAACcQAAAAEFwfraClGiLELDNq4bW/jRp8+gBGuCptZDtrCWIZJShHBoaLAYAp/fOKeJum/mgGjg==", null, false, "", false, "DB_A57FCC_VPlan1985_admin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "bffb94e1-8c6a-4ef0-b872-64dd1ec9cc74", "8f6dedc5-21a7-4b2a-b29e-be975ac725b1" },
                    { "408d1fa3-b202-4d88-942e-349b9124d770", "cd9da9f8-b54d-4948-b069-e3a9d914bb12" },
                    { "cd59e64a-bd79-49fd-9119-97ac7f7b9af3", "6f8c54d6-e093-4228-95c5-999303eb3fa2" },
                    { "589892ea-599f-44b2-a18e-e6bd7a4c98c1", "25721278-4863-4b8c-aecb-d395e9dc1938" },
                    { "8c3918bd-10bd-4dc5-ac0a-53fadf92e988", "5f8a6ce5-e648-496a-ba9a-8f0970072457" },
                    { "628e3958-277b-4810-ad1f-ec6cbb9f6543", "992210eb-ed3c-44d5-9f06-bfbd27d17cfb" },
                    { "04ae630f-f150-4376-8aa2-58ddbdff16f4", "654b93dd-94f6-4982-aa24-9829cb05d610" },
                    { "edb32e55-3157-47f8-a362-42b98742b03b", "f7e9146a-2cbd-4159-bd5e-cd55b86eb065" },
                    { "3bfa5fbc-9068-4c1c-bb40-17e06150cca9", "75f60987-fd94-4455-b856-29b0725fe15a" }
                });
        }
    }
}
