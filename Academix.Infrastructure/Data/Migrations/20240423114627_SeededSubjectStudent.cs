using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Academix.Infrastructure.Migrations
{
    public partial class SeededSubjectStudent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 23, 14, 46, 27, 103, DateTimeKind.Local).AddTicks(3369));

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 24, 14, 46, 27, 103, DateTimeKind.Local).AddTicks(3401));

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 25, 14, 46, 27, 103, DateTimeKind.Local).AddTicks(3448));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7f92327f-b1c1-4fd0-b837-afc278f256b2",
                column: "ConcurrencyStamp",
                value: "cf917190-4b9b-4a30-bec1-fc3b0acf7319");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a550b411-e5c7-407f-aaba-35161bab127e",
                column: "ConcurrencyStamp",
                value: "806434a4-8ca3-43ab-8f49-2c7887f49393");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e67d14b1-de35-47bd-96ac-a70fcc4c25be",
                column: "ConcurrencyStamp",
                value: "a2b25ce7-1f95-42ff-911d-4a2fc6464421");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f67cd347-818b-4c3e-a1ce-ae76e1a2e31b",
                column: "ConcurrencyStamp",
                value: "5e11cc74-166d-4b2d-a9c4-5c50498be18b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fc1ee3a5-9b29-43ea-b038-2265c1806a75",
                column: "ConcurrencyStamp",
                value: "3cd10c27-f0f7-43f8-b882-1a330e001082");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11f2b8bd-a49a-42cd-b08b-ce067e430965",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e3431af1-3750-4cad-84bb-594e991c39a3", "AQAAAAEAACcQAAAAEDs7iQA7CQ/aHvdeGUJ/RuU9cltKasmkGzTJ4kygiMyAggtkCIp+I5MPdFgPAXJvoA==", "3e9dfbdb-a921-4e18-82f6-3c1d5d7bcec0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1ae342a8-9fab-4c0a-bd5a-70b351717ecc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a620f4cf-00a5-459f-87ea-55c99c78a11c", "AQAAAAEAACcQAAAAEGR77k05Xa6IM3q+9/+PViyjLSMhXkGhEM+EpFy5FznF36n0ZrI8zetwUw+81iVNKQ==", "05fa1f8d-dfa1-4772-a2e9-c105928e456c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "214ce248-b8b3-4832-8c3b-7f133e7a429e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fb334134-1b04-4e24-bc07-235a64cdd3b6", "AQAAAAEAACcQAAAAEMwN3rxLnoowarGOq1sDQCFZ2eEtLh6e3I8EYwBma3sNZvppm7ne8riC/SQ60KU+gA==", "59fc8ff5-c66b-43b7-864c-f5669a65e85f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24a0fdf5-ca4f-4c0f-8120-f6c87448033c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f82ff887-1985-4b6e-b163-a8c74e0b4cf6", "AQAAAAEAACcQAAAAEGy4ot6VimC2NREhlaWOaiZ237srURdBuRR2dYz4RHWhTZo/tXrAlekvZSpMmyMK3A==", "af52eab8-27d4-4164-b7a6-778917ad8978" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5093413e-4acb-471a-9ce7-53df30689fc1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c4264cd4-4aac-4fb0-bf5e-f50ee352f432", "AQAAAAEAACcQAAAAEFsAu0zFNHiwHyJhrx049gxYW8dWYmyVbYS5ocfzVjL4ucg5lWFtr/xEg+aE8F5Ddw==", "5d743410-4c4e-44f7-a6d8-0cef669b8f74" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6c1ff15b-1853-4d20-98ff-9695affb432c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "461df6a7-5f31-4525-b844-eec0f904cb09", "AQAAAAEAACcQAAAAEPa/ghJd378ix+7rkpyPGqSDLbAO74SImAPb+0Y0YeGWlwDTCZx1A9aVzQk0Rq6kjg==", "536aa3ac-3f3b-471d-a337-271071da226d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "925da918-5cd0-4b17-9b62-2f417aac0343",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e124dd2b-b49d-44d2-8581-26f76af25102", "AQAAAAEAACcQAAAAEIcBNmQr7NcuZqksH2wAGyFZOvQfdnQgnorkl9gImBnwabDQ9QQdjvIKQ3/UvDz53g==", "1f2e7bd8-b217-4923-8343-3ad180f2a452" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a171483f-6e48-446a-a5d7-36110d0c1443",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1a624edd-d4cf-4ced-932d-0534d3f2bce3", "AQAAAAEAACcQAAAAEH6ROm5docBRF9PZNj/TJXxOgCqaDEsnScfXHSd8u8a+YmU2t0kERE7MdkIxuciWgA==", "f2aaadc5-a598-4e23-8751-792064f1ad72" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a3717562-385e-41ce-9eff-0f1b994e5548",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5af1bb45-c310-4f33-b636-85f3b87835b4", "AQAAAAEAACcQAAAAEPlUVLnQJZWmk1qOBRsV740mciXi1P1q3ziI394SmIZqF8hCnM7Sw4szHVziCILSFw==", "92fcd683-e499-4e0c-8465-f2cab2279f89" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2502a25-8341-4e5c-af74-cd0f889ede1b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fb071d81-d270-49b1-b7c5-b5fa695c706a", "AQAAAAEAACcQAAAAEMtuQfpGTVZDeGFfYFrpgJ7aTPtCsZ5zOUM+zoIcIhqEKjJURPTHBItK263sxXRcTg==", "04afe81b-9a7d-422a-800c-f3f7d2c17035" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bd3e68c0-728b-44a0-ba3a-992d8ae683f9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "520ad8d0-8afd-4e5a-a525-6744aea40188", "AQAAAAEAACcQAAAAEJAXB5im8QWfOhLuZ25kz+4Kp4yGy7zXnt9faRSzRaLg+9jvVNCTMcFoe2pQQOFcIA==", "5a08cad0-c0d9-4031-b515-1791607bc068" });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 23, 14, 46, 27, 103, DateTimeKind.Local).AddTicks(4313));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAndTime",
                value: new DateTime(2024, 5, 5, 14, 46, 27, 103, DateTimeKind.Local).AddTicks(4321));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateAndTime",
                value: new DateTime(2024, 5, 4, 14, 46, 27, 103, DateTimeKind.Local).AddTicks(4324));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 30, 14, 46, 27, 103, DateTimeKind.Local).AddTicks(4326));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "ClassId",
                value: 1);

            migrationBuilder.InsertData(
                table: "SubjectsStudents",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { 2, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SubjectsStudents",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 2, 1 });

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

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "ClassId",
                value: 2);
        }
    }
}
