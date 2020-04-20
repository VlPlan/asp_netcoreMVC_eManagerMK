using Microsoft.EntityFrameworkCore.Migrations;

namespace eManager.DataAccess.Migrations
{
    public partial class init0 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
