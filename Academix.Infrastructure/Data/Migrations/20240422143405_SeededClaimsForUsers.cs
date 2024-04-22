using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Academix.Infrastructure.Migrations
{
    public partial class SeededClaimsForUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 22, 17, 34, 4, 658, DateTimeKind.Local).AddTicks(5530));

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 23, 17, 34, 4, 658, DateTimeKind.Local).AddTicks(5561));

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 24, 17, 34, 4, 658, DateTimeKind.Local).AddTicks(5563));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7f92327f-b1c1-4fd0-b837-afc278f256b2",
                column: "ConcurrencyStamp",
                value: "6106c8ac-62d4-4393-85dc-0fbde76e4d6f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a550b411-e5c7-407f-aaba-35161bab127e",
                column: "ConcurrencyStamp",
                value: "237c0201-c431-4a70-841c-a2c59676a125");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e67d14b1-de35-47bd-96ac-a70fcc4c25be",
                column: "ConcurrencyStamp",
                value: "9e3d9d92-25f2-4244-826b-a9542cf4a172");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f67cd347-818b-4c3e-a1ce-ae76e1a2e31b",
                column: "ConcurrencyStamp",
                value: "93e768b3-7bce-4c26-8cc5-d0144dcebea6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fc1ee3a5-9b29-43ea-b038-2265c1806a75",
                column: "ConcurrencyStamp",
                value: "5f9fe13d-ccbc-4f54-8c27-b64cf12a5aee");

            migrationBuilder.InsertData(
                table: "AspNetUserClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "UserId" },
                values: new object[,]
                {
                    { 1, "FullName", "Ivan Ivanov", "a3717562-385e-41ce-9eff-0f1b994e5548" },
                    { 2, "FullName", "Mitko Marinov", "1ae342a8-9fab-4c0a-bd5a-70b351717ecc" },
                    { 3, "FullName", "Drago Kirilov", "a171483f-6e48-446a-a5d7-36110d0c1443" },
                    { 4, "FullName", "Marta Kirilova", "b2502a25-8341-4e5c-af74-cd0f889ede1b" },
                    { 5, "FullName", "Vasil Marinov", "925da918-5cd0-4b17-9b62-2f417aac0343" },
                    { 6, "FullName", "Vanya Kirilova", "24a0fdf5-ca4f-4c0f-8120-f6c87448033c" },
                    { 7, "FullName", "Nikoleta Zakova", "5093413e-4acb-471a-9ce7-53df30689fc1" },
                    { 8, "FullName", "Dragan Milev", "6c1ff15b-1853-4d20-98ff-9695affb432c" },
                    { 9, "FullName", "Zara Draganova", "bd3e68c0-728b-44a0-ba3a-992d8ae683f9" },
                    { 10, "FullName", "admin Admin", "11f2b8bd-a49a-42cd-b08b-ce067e430965" },
                    { 11, "FullName", "admin2 Admin2", "214ce248-b8b3-4832-8c3b-7f133e7a429e" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11f2b8bd-a49a-42cd-b08b-ce067e430965",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "373e3e5e-d203-4639-ac63-90d680c411ab", "AQAAAAEAACcQAAAAEOfzxplj+20PGKHyBSpR8OeEQxIeVi93B6RlBxMiuISAZLOFLCEvDp1U27JTIg0ClQ==", "c364d671-e63d-4466-a9d4-0830d6dc1b84" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1ae342a8-9fab-4c0a-bd5a-70b351717ecc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0958d949-ca7f-4a1b-95ab-afc8e0d8c803", "AQAAAAEAACcQAAAAEGyMt7EjZ58bur3SCuNOrCYlPstEMb32sgUCC+mSvkndn2o68+giQmiH7ecP4QOymQ==", "e0a31e1d-69bd-4a31-81c1-b63504c0c506" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "214ce248-b8b3-4832-8c3b-7f133e7a429e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fa172c14-b31a-456a-9722-03ed7ae71d74", "AQAAAAEAACcQAAAAECVOhjPa5O3IDf/XjCGRv//1yagylq/m0pXTkmzZRPmaKGIpN5x9lUlIYAACNbbySg==", "5c02755e-6a1c-4b1f-94d6-836b470a1c66" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24a0fdf5-ca4f-4c0f-8120-f6c87448033c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "54916652-990e-40f9-9bae-c3ae4c6cb3bc", "AQAAAAEAACcQAAAAEBbCwursOwk565XLYhqHQY/hgNBfLWzbYbDlAxhBRZxnV6KXTx4rhkGRupjkf9FiCg==", "1ba29d80-b1d1-40ae-ac05-7b702021ffd5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5093413e-4acb-471a-9ce7-53df30689fc1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2010badf-1845-4c50-a35a-db21cb5e6827", "AQAAAAEAACcQAAAAEMF10zWUiOdd2DbrPp0GGj2wXCbS9Mtl5BvdfucNLtAJCU0tCr/SYaZRoGRc/hOzFw==", "bb416002-6e50-4713-b9ca-f59f94405a81" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6c1ff15b-1853-4d20-98ff-9695affb432c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "db3c47ea-bec9-4eb3-a0cc-f9b861580625", "AQAAAAEAACcQAAAAELNKaDv9X7V+giZZeIgO6Kzn7R+XgIZSVS5mxhJo9/svMfhpHa86FdTWde+zTjgHpg==", "f21ce92e-39d2-43d6-b624-15cc83884cc9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "925da918-5cd0-4b17-9b62-2f417aac0343",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0df26054-5d5a-44d7-98d4-d1c2a7f6604a", "AQAAAAEAACcQAAAAEMptjJNWeBx41M4f3fMHKF+bdzvpp/Gt0TaopPLrb1sjUyoprV25gBidhUXHyNJkNQ==", "f86fdf4a-bccd-4b9d-804c-60ee62b59e76" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a171483f-6e48-446a-a5d7-36110d0c1443",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d6643baf-c86f-4998-9373-6ea73bd25ccd", "AQAAAAEAACcQAAAAEJgYen9FdgqJYnUE1rb4xnAeyDpHJnrLDVeM6MZx6W+/XSLMp7lWKE62x3mdcZjVog==", "6833a08a-9f3f-4a4c-915d-27653ee64758" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a3717562-385e-41ce-9eff-0f1b994e5548",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b61eacbb-3fbd-4524-ba8e-3feefa1f1066", "AQAAAAEAACcQAAAAEJQu1YVW7U0B+GXEQVvOdk//fBcTIb7myVoRHvBFRitOINVPgeEL4kP2Fef25HiNZQ==", "572f91f4-d2cc-4c65-8d68-7fb47aa571c4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2502a25-8341-4e5c-af74-cd0f889ede1b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cf5ad05b-2037-4985-98dd-b2afd8d2f2fd", "AQAAAAEAACcQAAAAECnpR5Jy51VeSt8tGwxuOSn7gsrrTFJIV+/xIkFQ22dgjxY4/RESy/bxeV9cmC651Q==", "fec639a3-4657-4271-adb2-f1d7643a0554" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bd3e68c0-728b-44a0-ba3a-992d8ae683f9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "71221ec6-169a-480b-b997-7158711c44d8", "AQAAAAEAACcQAAAAEMqhaZAulcTZdRK36kCdTO9d+4Z54MFAqGYUge3Hbv2COZhGCkJHcNd6QgsuYm+Zeg==", "857f6f23-080f-4405-8fb8-53e23bb44366" });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 22, 17, 34, 4, 658, DateTimeKind.Local).AddTicks(6460));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAndTime",
                value: new DateTime(2024, 5, 4, 17, 34, 4, 658, DateTimeKind.Local).AddTicks(6468));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateAndTime",
                value: new DateTime(2024, 5, 3, 17, 34, 4, 658, DateTimeKind.Local).AddTicks(6470));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 29, 17, 34, 4, 658, DateTimeKind.Local).AddTicks(6472));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 20, 19, 40, 7, 567, DateTimeKind.Local).AddTicks(5529));

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 21, 19, 40, 7, 567, DateTimeKind.Local).AddTicks(5557));

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 22, 19, 40, 7, 567, DateTimeKind.Local).AddTicks(5560));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7f92327f-b1c1-4fd0-b837-afc278f256b2",
                column: "ConcurrencyStamp",
                value: "2fcb0afb-6a6f-412d-8b96-9c05047956c0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a550b411-e5c7-407f-aaba-35161bab127e",
                column: "ConcurrencyStamp",
                value: "bae556a8-7628-4441-8e27-a2355bb46dd3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e67d14b1-de35-47bd-96ac-a70fcc4c25be",
                column: "ConcurrencyStamp",
                value: "3eb6d106-7d9b-40de-a46a-21115f930f6a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f67cd347-818b-4c3e-a1ce-ae76e1a2e31b",
                column: "ConcurrencyStamp",
                value: "b868a331-ed08-4fa2-9013-6bc7ad839438");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fc1ee3a5-9b29-43ea-b038-2265c1806a75",
                column: "ConcurrencyStamp",
                value: "f26d78d0-3d6b-4e2f-af70-17ee7c9f39de");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11f2b8bd-a49a-42cd-b08b-ce067e430965",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "51ed8e6e-fcf3-4074-baf4-f4d010a5048a", "AQAAAAEAACcQAAAAEP1l63fIFiGgspeCarb9e+w0avL1dL8GtZAZoCBzgfEIRqHP6tmuJKdyj+92o/Urlw==", "bae671d2-5132-4b67-9811-25e087405df0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1ae342a8-9fab-4c0a-bd5a-70b351717ecc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3964b921-0a67-43b6-be7c-23b89715e26c", "AQAAAAEAACcQAAAAEJFPnFSnNp9J9iz7Se9HrgmhIrRrs+LCfh6lAwppX6h09FLrTdkFiKDjIFhPeJb7Sw==", "0bf4c30c-c8d4-4fd9-84b4-a8fcfacc3dfa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "214ce248-b8b3-4832-8c3b-7f133e7a429e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fe69d50d-1245-4f19-883e-5b993fbf05e9", "AQAAAAEAACcQAAAAEJhijaD5bfxrFahte3K5nMf/IxN5NXlfphadNHatFClULnbSFL7sArsWl5JO6usa8A==", "43042409-a2ed-40a7-ac05-f22baa3f26a8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24a0fdf5-ca4f-4c0f-8120-f6c87448033c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4aab20c2-3ed8-4048-9d51-c99177c64ec1", "AQAAAAEAACcQAAAAEFOXdOJeLO6pfH4l4xVsZ1e7csiTTBWKB+LET7fSl72lIlZUWOYQZyuf9vm+j+WLQQ==", "90069753-e4f7-44c7-86e7-720004d640b0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5093413e-4acb-471a-9ce7-53df30689fc1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5e6d7c9b-e3ce-455c-bd14-0db1ce2c1f69", "AQAAAAEAACcQAAAAEEkFTMPyaXb/1SOlrblUzBP44BoPvacTrKX+0NivYlqJI0H2Kpn4lVv1AKkT/JKmZQ==", "babe538b-2830-437a-b6ee-61b5c2b3ce5b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6c1ff15b-1853-4d20-98ff-9695affb432c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a5abecfb-13f4-4ba0-8cd9-4b581d775234", "AQAAAAEAACcQAAAAEEkcRzhosanet63yvFoN25wQkJwuV0gyR0skZepCF4DA3ywUqvMkapE+PRohwQKRJg==", "321a1c5d-df09-4e56-a4b7-97848ef9c734" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "925da918-5cd0-4b17-9b62-2f417aac0343",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "32977a62-1459-43c5-a86b-18d2bfd5884f", "AQAAAAEAACcQAAAAEFql6Z7h5fDu7rX8jM9RFKBk/+Z2sQ/tPrClK5agN+M0L92BjkCEHjN+B9fWGS8Bwg==", "63987ea7-6cf7-4fd5-acfc-30ed25f1e0b0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a171483f-6e48-446a-a5d7-36110d0c1443",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "264eb355-0643-4717-aa05-5799025543f2", "AQAAAAEAACcQAAAAEOdKunnrianPFH6vNPU2e0ttkyy3YevvyN1FOg9ACktirGTTiaWly01wWdjQdviFGQ==", "ff6d8d17-1eea-42fb-9957-a3056eaddfae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a3717562-385e-41ce-9eff-0f1b994e5548",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6966b942-3cfb-4ad6-9abe-1704f11f8801", "AQAAAAEAACcQAAAAEOY8vEnH7i2qKX71ZLXuSyADcE7ozLGD3N/YeWUuZlQRq+2G7wJCEgt6Qj9lqQ9ryQ==", "7a0241fc-49e7-46d5-9df2-302d58ce3102" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2502a25-8341-4e5c-af74-cd0f889ede1b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b21a785d-254a-4ec0-bc66-2cef58ca7b92", "AQAAAAEAACcQAAAAEPqCWdawCptCRTnodMPHLcsUDlOLqQuraxQURUalN9NBwductbtk5a1mHOvLkjb9FA==", "8c55f8a9-af9d-4b0c-9aa2-97861498b640" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bd3e68c0-728b-44a0-ba3a-992d8ae683f9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ca2e9d7e-2744-417a-9957-323f28db484d", "AQAAAAEAACcQAAAAEKVATVpFhwqwGTajGTanezHb4h061M2d5PxXAGk7F+pvJsNbTPqNPdpLonBYm4Y4qQ==", "7bc167a9-a713-409a-84d6-105422bd2c55" });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 20, 19, 40, 7, 567, DateTimeKind.Local).AddTicks(6494));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAndTime",
                value: new DateTime(2024, 5, 2, 19, 40, 7, 567, DateTimeKind.Local).AddTicks(6503));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateAndTime",
                value: new DateTime(2024, 5, 1, 19, 40, 7, 567, DateTimeKind.Local).AddTicks(6506));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 27, 19, 40, 7, 567, DateTimeKind.Local).AddTicks(6508));
        }
    }
}
