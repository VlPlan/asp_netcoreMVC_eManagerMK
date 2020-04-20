using Microsoft.EntityFrameworkCore.Migrations;

namespace eManager.DataAccess.Migrations
{
    public partial class init01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "ca8c2669-62c7-48b9-bd9b-8ee544649c8b", "a7348700-0f53-4455-8178-cc224a13f7a6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "1ff13a7b-6045-4ead-a57c-3b67d3324b61", "b6358d4a-2745-4a53-a0ff-ec2b9f10251f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "5a3af8a1-9e8f-46d1-a4bd-e79ef5df0cc6", "15102fea-4516-4a5a-aef7-fcbcf293588c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "7114bd33-522c-41e2-aa72-c12d300e2e43", "802b7ff0-0973-4330-ad7c-de7de6fbe5df" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "73cd2d67-53f7-48cd-b566-c0936a822164", "02eb606f-b090-40dd-ae82-9f96199edade" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "b7a1a72a-13c5-497b-891f-c29882dc87a6", "d21ecdfd-789f-4eb1-b685-d709c6cea6fb" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "b85a5e20-284d-4d31-96ac-9c6871f49baa", "a7e868fc-9cf3-4439-8740-8825365805f6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "c6e785ec-accf-48bb-950b-cb4ee54a5e24", "24874b6b-ac40-4135-8ab2-98ee5fadb8e7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "ddc4fd39-bebe-436d-8080-c663f4d46509", "ee8d437e-8a8a-4ebf-b485-f0cc2cf27086" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "e30343f2-1b54-4fdb-865b-697d5a1c9152", "e7b75401-ff26-42ce-b621-35f326e80ed1" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "f9173038-f3e8-4b40-9939-35095e896790", "df72ac0f-e141-4fe2-90d7-64cfdadcc826" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "02eb606f-b090-40dd-ae82-9f96199edade", "9af3801f-7765-4c1f-9f8e-9b88668fa7ac" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "15102fea-4516-4a5a-aef7-fcbcf293588c", "57539c98-6f11-43ed-8a5b-cfb5cac759de" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "24874b6b-ac40-4135-8ab2-98ee5fadb8e7", "0b5c776f-23cf-4d2d-8cce-92cdf2fa98da" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "802b7ff0-0973-4330-ad7c-de7de6fbe5df", "4874d029-91b0-4b04-a80c-23c4b4635155" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "a7e868fc-9cf3-4439-8740-8825365805f6", "fed1b692-4d1e-4e2f-8eb4-dc1ce05e28b4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "b6358d4a-2745-4a53-a0ff-ec2b9f10251f", "31e0a14e-80fc-4195-8708-b846aa9a8312" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "d21ecdfd-789f-4eb1-b685-d709c6cea6fb", "1aca1466-44a5-4e6d-952f-c44649c7e7f1" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "e7b75401-ff26-42ce-b621-35f326e80ed1", "95276fd2-bdac-492d-ad14-f3d51d22dd82" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "ee8d437e-8a8a-4ebf-b485-f0cc2cf27086", "d5010a7a-485a-4e08-b564-edd95ade7f52" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "1ff13a7b-6045-4ead-a57c-3b67d3324b61", "29024d71-d377-423c-aa63-ee9886d850e9" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "5a3af8a1-9e8f-46d1-a4bd-e79ef5df0cc6", "cfe9e827-ee5c-4f55-809e-d50cbfccd3f7" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "7114bd33-522c-41e2-aa72-c12d300e2e43", "3a73e952-5d18-48ef-86c6-213487270457" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "73cd2d67-53f7-48cd-b566-c0936a822164", "466bb4a5-cf38-4c6e-97fe-4f4943a5f923" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "b7a1a72a-13c5-497b-891f-c29882dc87a6", "84055947-8389-4822-9f1d-0a6c6d5576d3" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "b85a5e20-284d-4d31-96ac-9c6871f49baa", "a5c0598d-86b9-47e6-bee7-35bd2c14c928" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "c6e785ec-accf-48bb-950b-cb4ee54a5e24", "06531ae7-1a6f-45c2-9a8c-c6182f7685f8" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "ddc4fd39-bebe-436d-8080-c663f4d46509", "1ec2d30c-f705-42b2-88cc-222cfd4d01a8" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "e30343f2-1b54-4fdb-865b-697d5a1c9152", "b0cbdc40-e6ff-4a6e-ad6b-af7f74f58381" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "02eb606f-b090-40dd-ae82-9f96199edade", "9af3801f-7765-4c1f-9f8e-9b88668fa7ac", "userDR", "USERDR" },
                    { "b6358d4a-2745-4a53-a0ff-ec2b9f10251f", "31e0a14e-80fc-4195-8708-b846aa9a8312", "userGK", "USERGK" },
                    { "ca8c2669-62c7-48b9-bd9b-8ee544649c8b", "a7348700-0f53-4455-8178-cc224a13f7a6", "userSP", "USERSP" },
                    { "ee8d437e-8a8a-4ebf-b485-f0cc2cf27086", "d5010a7a-485a-4e08-b564-edd95ade7f52", "userEN", "USEREN" },
                    { "e7b75401-ff26-42ce-b621-35f326e80ed1", "95276fd2-bdac-492d-ad14-f3d51d22dd82", "userAMG", "USERAMG" },
                    { "d21ecdfd-789f-4eb1-b685-d709c6cea6fb", "1aca1466-44a5-4e6d-952f-c44649c7e7f1", "userTP", "USERTP" },
                    { "24874b6b-ac40-4135-8ab2-98ee5fadb8e7", "0b5c776f-23cf-4d2d-8cce-92cdf2fa98da", "userSN", "USERSN" },
                    { "15102fea-4516-4a5a-aef7-fcbcf293588c", "57539c98-6f11-43ed-8a5b-cfb5cac759de", "userVP", "USERVP" },
                    { "a7e868fc-9cf3-4439-8740-8825365805f6", "fed1b692-4d1e-4e2f-8eb4-dc1ce05e28b4", "admin", "ADMIN" },
                    { "802b7ff0-0973-4330-ad7c-de7de6fbe5df", "4874d029-91b0-4b04-a80c-23c4b4635155", "userKK", "USERKK" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "73cd2d67-53f7-48cd-b566-c0936a822164", 0, "466bb4a5-cf38-4c6e-97fe-4f4943a5f923", "kotev@ognootporno.com.mk", true, "Драге Ристевски", false, null, "kotev@ognootporno.com.mk", "DRAGERISTEVSKI", "AQAAAAEAACcQAAAAEGplxfJ7j4PONPjtJyCemEH40Uw30GpFbSuWFG8DwATt9xOwlmyWeKVG79tlho5A9w==", null, false, "", false, "DrageRistevski" },
                    { "1ff13a7b-6045-4ead-a57c-3b67d3324b61", 0, "29024d71-d377-423c-aa63-ee9886d850e9", "kotev@ognootporno.com.mk", true, "Горан Котев", false, null, "kotev@ognootporno.com.mk", "GORANKOTEV", "AQAAAAEAACcQAAAAEFko8Rvl+4Dh5S+jYVCoJ1NIeUGz272KfHU3DPVX/UWjiI0ze6Ilk88HihEgqsYDYw==", null, false, "", false, "GoranKotev" },
                    { "f9173038-f3e8-4b40-9939-35095e896790", 0, "df72ac0f-e141-4fe2-90d7-64cfdadcc826", "peshovski@ognootporno.com.mk", true, "Сашо Пешовски", false, null, "peshovski@ognootporno.com.mk", "SASHOPESHOVSKI", "AQAAAAEAACcQAAAAEFXcM0PrR3dos5eCmS6hK6RgnbqTTv+97m8o+ahuAuYkibJtvX4kvy9ZV2lU1E+v6Q==", null, false, "", false, "SashoPeshovski" },
                    { "ddc4fd39-bebe-436d-8080-c663f4d46509", 0, "1ec2d30c-f705-42b2-88cc-222cfd4d01a8", "nikolchov@ognootporno.com.mk", true, "Евтим Николчов", false, null, "nikolchov@ognootporno.com.mk", "EVTIMNIKOLCHOV", "AQAAAAEAACcQAAAAEHClXoE/+Rm0ZejYFGCb9TvuEkXMAcIkmFj/J/pEYZLPKP2Y44VpeI3bXsFkGapWdQ==", null, false, "", false, "EvtimNikolchov" },
                    { "e30343f2-1b54-4fdb-865b-697d5a1c9152", 0, "b0cbdc40-e6ff-4a6e-ad6b-af7f74f58381", "mirkovska@ognootporno.com.mk", true, "Ана Мирковска Гаврилов", false, null, "mirkovska@ognootporno.com.mk", "ANAMIRKOVSKAGAVRILOV", "AQAAAAEAACcQAAAAEKO2wLO+F29xHGxsNMgBh10wTGy84b0gsa7J4KRWK58AFOfbDXq/YG9M1WdYVjqI7A==", null, false, "", false, "AnaMGavrilov" },
                    { "b7a1a72a-13c5-497b-891f-c29882dc87a6", 0, "84055947-8389-4822-9f1d-0a6c6d5576d3", "peshovski@ognootporno.com.mk", true, "Тони Пешевски", false, null, "peshovski@ognootporno.com.mk", "TONIPESHEVSKI", "AQAAAAEAACcQAAAAEERLg8QZAwdqQBuOWoZOCbZmt6oOax1N3Zn5OenXuStCZbxTc5F6P/pKosyvwblXww==", null, false, "", false, "ToniPeshevski" },
                    { "c6e785ec-accf-48bb-950b-cb4ee54a5e24", 0, "06531ae7-1a6f-45c2-9a8c-c6182f7685f8", "nikolchov@ognootporno.com.mk", true, "Сашо Николчов", false, null, "nikolchov@ognootporno.com.mk", "SASHONIKOLCHOV", "AQAAAAEAACcQAAAAEMIVQe2NESOoCbvjX3QZhPgLEsW7qPX5MLwRYmG4V+Rp8Xk52E8Wp/fSpYVptndqEQ==", null, false, "", false, "SashoNikolchov" },
                    { "5a3af8a1-9e8f-46d1-a4bd-e79ef5df0cc6", 0, "cfe9e827-ee5c-4f55-809e-d50cbfccd3f7", "planojevic@ognootporno.com.mk", true, "Владимир Планојевиќ", false, null, "PLANOJEVIC@OGNOOTPORNO.COM.MK", "VPLAN", "AQAAAAEAACcQAAAAEIU64n2ru855MYX4TGcLLLL2XA+nkMefbvBTXB9xNsktjyQgIhPEve0yVVPu8/ke1Q==", null, false, "", false, "VPlan" },
                    { "7114bd33-522c-41e2-aa72-c12d300e2e43", 0, "3a73e952-5d18-48ef-86c6-213487270457", "kotev@ognootporno.com.mk", true, "Коста Котев", false, null, "kotev@ognootporno.com.mk", "KOSTAKOTEV", "AQAAAAEAACcQAAAAEG7hlV+XnBHxppr1z+Jmt8nTLxM3F9QgMfdLRuQeXkaSlv6fso8I3D6QE/5lImjKQw==", null, false, "", false, "KostaKotev" },
                    { "b85a5e20-284d-4d31-96ac-9c6871f49baa", 0, "a5c0598d-86b9-47e6-bee7-35bd2c14c928", "supplier@mail.com", true, null, false, null, "supplier@mail.com", "OGNO2020", "AQAAAAEAACcQAAAAEMXbEg63FTuLQO1Gh52/Y+ovxMOsjyB+3fORfMfAiB0BxICSbEiNCx1+z3KUDMvLWw==", null, false, "", false, "ogno2020" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "b85a5e20-284d-4d31-96ac-9c6871f49baa", "a7e868fc-9cf3-4439-8740-8825365805f6" },
                    { "5a3af8a1-9e8f-46d1-a4bd-e79ef5df0cc6", "15102fea-4516-4a5a-aef7-fcbcf293588c" },
                    { "c6e785ec-accf-48bb-950b-cb4ee54a5e24", "24874b6b-ac40-4135-8ab2-98ee5fadb8e7" },
                    { "b7a1a72a-13c5-497b-891f-c29882dc87a6", "d21ecdfd-789f-4eb1-b685-d709c6cea6fb" },
                    { "e30343f2-1b54-4fdb-865b-697d5a1c9152", "e7b75401-ff26-42ce-b621-35f326e80ed1" },
                    { "ddc4fd39-bebe-436d-8080-c663f4d46509", "ee8d437e-8a8a-4ebf-b485-f0cc2cf27086" },
                    { "1ff13a7b-6045-4ead-a57c-3b67d3324b61", "b6358d4a-2745-4a53-a0ff-ec2b9f10251f" },
                    { "7114bd33-522c-41e2-aa72-c12d300e2e43", "802b7ff0-0973-4330-ad7c-de7de6fbe5df" },
                    { "73cd2d67-53f7-48cd-b566-c0936a822164", "02eb606f-b090-40dd-ae82-9f96199edade" }
                });
        }
    }
}
