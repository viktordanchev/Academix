using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Academix.Infrastructure.Migrations
{
    public partial class UpdatedFewTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "Grades",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "Absences",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateAndTime", "StudentId" },
                values: new object[] { new DateTime(2024, 4, 16, 17, 54, 13, 264, DateTimeKind.Local).AddTicks(3349), 1 });

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateAndTime", "StudentId" },
                values: new object[] { new DateTime(2024, 4, 17, 17, 54, 13, 264, DateTimeKind.Local).AddTicks(3378), 1 });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7f92327f-b1c1-4fd0-b837-afc278f256b2",
                column: "ConcurrencyStamp",
                value: "1650b990-11e4-468b-90c5-a3e366e240cf");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a550b411-e5c7-407f-aaba-35161bab127e",
                column: "ConcurrencyStamp",
                value: "02f79085-5f74-4da2-acf8-815ed155d08a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e67d14b1-de35-47bd-96ac-a70fcc4c25be",
                column: "ConcurrencyStamp",
                value: "722287ff-22c6-4050-bc57-f04cc21c5623");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f67cd347-818b-4c3e-a1ce-ae76e1a2e31b",
                column: "ConcurrencyStamp",
                value: "93bbec29-e56d-40ad-81bf-ddfb20dae8cc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fc1ee3a5-9b29-43ea-b038-2265c1806a75",
                column: "ConcurrencyStamp",
                value: "c0fc1df2-4595-4f88-ad0a-a0cac866e76a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11f2b8bd-a49a-42cd-b08b-ce067e430965",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a8f951ce-632e-445f-b1bf-6b7b282d34b1", "AQAAAAEAACcQAAAAENdMgs6CtL0U0bflxlMESFCmwqWcSzihv3iIWEfZLxhQB6tngNZA15pGizwuUtnvKg==", "6c06c4a4-3c20-4d4d-9424-abba4b0011ea" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1ae342a8-9fab-4c0a-bd5a-70b351717ecc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3a0cd09f-6b58-44a0-a707-042c035d03a8", "AQAAAAEAACcQAAAAEONTKTT2SDEeAQzXLmZQqlMGjqQa4nsXza8SxThCmpWADol2I0FDMh6YCK6Z/5yL1g==", "13e0d628-c2fa-49d8-abd6-6050969e8898" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24a0fdf5-ca4f-4c0f-8120-f6c87448033c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "51671e56-4e71-4475-a99b-b6c05840ae01", "AQAAAAEAACcQAAAAEElNdIEzcASLXuU4HCKTw/jf97nR0D/KK0bBH7ErMEFv9DNICE+1llxd5qreAbRTQg==", "58878b4c-6b1d-4a7e-84b9-d4c97466123d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5093413e-4acb-471a-9ce7-53df30689fc1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8ef7f28f-addf-4d61-ac7e-22d98bd3f58f", "AQAAAAEAACcQAAAAEMG08pd3SJbxBRq2ZpMx/ZCBQmSxZSQmzf3CSj8JnPfF+vmCeLt/FxVHEaFfGdcEjw==", "8637e8ad-448d-4385-9952-27136e0a0f52" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6c1ff15b-1853-4d20-98ff-9695affb432c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fd730eef-af91-4e21-ba9b-b08790ce6cf5", "AQAAAAEAACcQAAAAEMdQgYPz3X1cIhTOw8nG0ngLrhggN3Qs2D8Ss/WWWNDya4cIkTtn+im8K/T5I7uyPw==", "436bcb18-4054-4448-9c1e-79d227a6bb06" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "925da918-5cd0-4b17-9b62-2f417aac0343",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0ad1ee5f-353d-4f4b-bfb1-e2c62cde170a", "AQAAAAEAACcQAAAAEHcn0H5vDTJzEGNWhFPj6YuqXGG8nUUyOuvfgtVJkAipXAh/HEx5G8qj7PTiuMNJsA==", "420144a6-c6d8-4374-821e-74c6edbcf849" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a171483f-6e48-446a-a5d7-36110d0c1443",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ad9a8b72-9b8a-46c7-afea-6ed60e5f0f40", "AQAAAAEAACcQAAAAEJSu5RTM6DSxHGwMW1mIjs3yvApyGoaBT8PNWqsC/9MvoT0lYTvq5iKjfwr716vwdQ==", "f9d28f2d-7df1-4551-b1b8-46e2abc5016c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a3717562-385e-41ce-9eff-0f1b994e5548",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4052ce28-d759-49df-972d-c66eb526f133", "AQAAAAEAACcQAAAAEKXoCJNdSYhR1sZxqxfMwldTGtSsCXU41gcibWBAD/yrLc35k8w8Vk4x2fMeeNN9mQ==", "5e805337-15e9-4fb4-be66-926dc63d6b19" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2502a25-8341-4e5c-af74-cd0f889ede1b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4aa26d53-1f56-42c4-af4b-c033c5a47fbd", "AQAAAAEAACcQAAAAEBorHAdCtDdvrynBe6wmgxs4AfgU7brcL5VCct94pAMKBencD6YNvJV1cQfR8BJGLg==", "3162e621-2d61-4f58-81b1-acab9f1b9dfc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bd3e68c0-728b-44a0-ba3a-992d8ae683f9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8def38bf-44a0-4fea-8f2c-0ecb3b79d1ef", "AQAAAAEAACcQAAAAEPOR5v9Qp0ngfnkUmFW1rBSXLMmRH2Xzjjg3yU2X8OjdyQQjBshIzpVcbYy04IwtWg==", "52d38a3c-0b6e-46fe-9d3d-3373a3db095d" });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateAndTime", "StudentId" },
                values: new object[] { new DateTime(2024, 4, 16, 17, 54, 13, 275, DateTimeKind.Local).AddTicks(7893), 1 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateAndTime", "StudentId" },
                values: new object[] { new DateTime(2024, 4, 28, 17, 54, 13, 275, DateTimeKind.Local).AddTicks(7926), 1 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateAndTime", "StudentId" },
                values: new object[] { new DateTime(2024, 4, 27, 17, 54, 13, 275, DateTimeKind.Local).AddTicks(7928), 1 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateAndTime", "StudentId" },
                values: new object[] { new DateTime(2024, 4, 23, 17, 54, 13, 275, DateTimeKind.Local).AddTicks(7931), 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Grades_StudentId",
                table: "Grades",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Absences_StudentId",
                table: "Absences",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Absences_Students_StudentId",
                table: "Absences",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Grades_Students_StudentId",
                table: "Grades",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Absences_Students_StudentId",
                table: "Absences");

            migrationBuilder.DropForeignKey(
                name: "FK_Grades_Students_StudentId",
                table: "Grades");

            migrationBuilder.DropIndex(
                name: "IX_Grades_StudentId",
                table: "Grades");

            migrationBuilder.DropIndex(
                name: "IX_Absences_StudentId",
                table: "Absences");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Grades");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Absences");

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 12, 15, 53, 20, 899, DateTimeKind.Local).AddTicks(92));

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 13, 15, 53, 20, 899, DateTimeKind.Local).AddTicks(122));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7f92327f-b1c1-4fd0-b837-afc278f256b2",
                column: "ConcurrencyStamp",
                value: "c6c1a876-8bbd-4503-abd0-f111c1f4c847");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a550b411-e5c7-407f-aaba-35161bab127e",
                column: "ConcurrencyStamp",
                value: "30ca0993-4709-4410-82ab-f1b594db4ca3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e67d14b1-de35-47bd-96ac-a70fcc4c25be",
                column: "ConcurrencyStamp",
                value: "4b8006a1-8fbf-44e0-9f50-ca2ee4c57978");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f67cd347-818b-4c3e-a1ce-ae76e1a2e31b",
                column: "ConcurrencyStamp",
                value: "29587870-d8a0-4d68-b7ad-af28634ade12");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fc1ee3a5-9b29-43ea-b038-2265c1806a75",
                column: "ConcurrencyStamp",
                value: "c9cc5d2f-13e2-4f33-96c2-30dc5cf4190d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11f2b8bd-a49a-42cd-b08b-ce067e430965",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0d83cd7a-254e-40ca-ae41-d49dcfff3ef0", "AQAAAAEAACcQAAAAEECUO09+nuspMWUp3mMXfokEj9qM/RcfS+fk+vGrnpsjovY9ZA6KUqZ2FwOT3XfMkQ==", "36153b55-6fea-4434-a648-6e36eaf19e11" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1ae342a8-9fab-4c0a-bd5a-70b351717ecc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bd67cc3c-d00a-45c7-b14c-dcbdb1d5cdf7", "AQAAAAEAACcQAAAAEHIxD4/RNbqq2shqMMXv2nEpzNwApukZBQNJ42ay3PpIgur07J4FzEcnNktoLSY8PA==", "56deacb0-e27a-43c0-b832-e6b8ef9d0314" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24a0fdf5-ca4f-4c0f-8120-f6c87448033c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b338c2f0-ba9e-40f1-b9a5-84506ddf248a", "AQAAAAEAACcQAAAAEB3nUHltX/zxrqsd+mzfX5N4wzRi7qow6tOvj1gXm3DR7SwZ9ww0ESh92/CEePb8Kw==", "df5af0ed-9463-45e6-bf1c-028efd59ada5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5093413e-4acb-471a-9ce7-53df30689fc1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a54ee3be-72d5-413a-8722-294f71aac39d", "AQAAAAEAACcQAAAAEGpxbidxlaldj0bo9v74f+E16kqwcq9/LlQmkRkBOrKT+F0+HQRqbqvXyDTQmq7z/w==", "f97ded57-3a5d-4ec5-8cb2-bdfb692b387e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6c1ff15b-1853-4d20-98ff-9695affb432c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3bcd806e-afd1-42e4-af75-eb315bc3baac", "AQAAAAEAACcQAAAAELKApttN6c6RKbwfsnGWYB/1M8oa17Ipz/2Otd5ks/F3BpZDjQf7hoUfxcjElscbtg==", "2b6fe153-95fc-4d4b-9bf5-683d9769744f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "925da918-5cd0-4b17-9b62-2f417aac0343",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6f69cfc5-f6ae-4b11-b8d9-19291c5fd8ce", "AQAAAAEAACcQAAAAEPi7QtcxiYkZ+zEeOMjv4XAnX+JZbgeThQU3RTIupvfC25T1ucRrT9hwrNPeQD/7UA==", "352471b3-5ce5-4827-8a52-6fb21e72d0f1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a171483f-6e48-446a-a5d7-36110d0c1443",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ee0a03de-eea8-4f72-bf06-713faf1b1eee", "AQAAAAEAACcQAAAAEM46/HmSq6TPGL6c9gXF5Q7eWl/6TkSTjb9R7tsxP9c068zX+MsXZbyzrngBII3NsQ==", "b1106360-f5ab-483f-a9fb-54451c2f03ff" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a3717562-385e-41ce-9eff-0f1b994e5548",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "96cb08a5-0691-49c1-8ec7-0884f776492c", "AQAAAAEAACcQAAAAENN/KobaUGmNpI+hssepYP2zDRPmnCPY+8ZFduG+BQC6Gi4yp7dpdkx+Nqi8ykj1SA==", "1ea80ae1-ae89-41a2-b60d-2bec00af0012" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2502a25-8341-4e5c-af74-cd0f889ede1b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4df8e8c8-6d0e-44cc-9eb3-498ba174bd3e", "AQAAAAEAACcQAAAAEDY21Nyjl7Vnv10yCGjU+OLxJBI/moEOiM1GbVmM4tKC098V56qb20qddXUleq60Og==", "9bc2da95-38f7-4aac-b00e-02bb8cc414a1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bd3e68c0-728b-44a0-ba3a-992d8ae683f9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "401e89b5-0731-4749-8263-687d427d418d", "AQAAAAEAACcQAAAAEP9CUfe3FDIXCZzIPF1m/9oRfeX9b49ZsqPrelv+EC1bIiA2kU5ywMOsVlQimoT5tA==", "cf45d3eb-1572-48c7-aec3-f1941f658013" });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 12, 15, 53, 20, 911, DateTimeKind.Local).AddTicks(1380));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 24, 15, 53, 20, 911, DateTimeKind.Local).AddTicks(1417));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 23, 15, 53, 20, 911, DateTimeKind.Local).AddTicks(1420));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 19, 15, 53, 20, 911, DateTimeKind.Local).AddTicks(1422));
        }
    }
}
