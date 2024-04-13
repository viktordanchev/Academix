using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Academix.Infrastructure.Migrations
{
    public partial class AddedNewTableAndUpdatedParentsAndStudentsTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Parents_ParentId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_ParentId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "ParentId",
                table: "Students");

            migrationBuilder.CreateTable(
                name: "StudentsParents",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    ParentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentsParents", x => new { x.StudentId, x.ParentId });
                    table.ForeignKey(
                        name: "FK_StudentsParents_Parents_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Parents",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StudentsParents_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id");
                });

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

            migrationBuilder.InsertData(
                table: "StudentsParents",
                columns: new[] { "ParentId", "StudentId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 2, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentsParents_ParentId",
                table: "StudentsParents",
                column: "ParentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentsParents");

            migrationBuilder.AddColumn<int>(
                name: "ParentId",
                table: "Students",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 11, 18, 15, 40, 725, DateTimeKind.Local).AddTicks(8859));

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 12, 18, 15, 40, 725, DateTimeKind.Local).AddTicks(8889));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7f92327f-b1c1-4fd0-b837-afc278f256b2",
                column: "ConcurrencyStamp",
                value: "bfa50196-4651-49f5-bdc2-0b02f64ee068");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a550b411-e5c7-407f-aaba-35161bab127e",
                column: "ConcurrencyStamp",
                value: "228f174d-74fe-48a7-aa52-f865a69b2122");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e67d14b1-de35-47bd-96ac-a70fcc4c25be",
                column: "ConcurrencyStamp",
                value: "9dd264fc-930f-4918-97bc-a797ce78f68d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f67cd347-818b-4c3e-a1ce-ae76e1a2e31b",
                column: "ConcurrencyStamp",
                value: "160c0784-ee09-457b-b4e5-7ffda3d982b5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fc1ee3a5-9b29-43ea-b038-2265c1806a75",
                column: "ConcurrencyStamp",
                value: "8d454145-883a-4554-9bcc-ce3af10c4b09");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11f2b8bd-a49a-42cd-b08b-ce067e430965",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ed66220f-80e0-4bcc-aafa-a44481fe2649", "AQAAAAEAACcQAAAAEFfidT1yleT1yBy7c1xCxmPHtHW6IFbcNMtI3V0LrGgjmU3kSQPxZNhfxmP2cTloOg==", "952b56c8-6427-49ba-aa17-881068662f00" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1ae342a8-9fab-4c0a-bd5a-70b351717ecc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7042f849-7beb-445f-9a99-474dd60da957", "AQAAAAEAACcQAAAAENn12wylPqTlBIlZ2ERndmZ+x0cBz4Dx9BpO37LBrxpTz+8QUHaokhtix6xuoLrqQQ==", "8d8afd93-f7b2-4fdd-a018-1b68ed01e25b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24a0fdf5-ca4f-4c0f-8120-f6c87448033c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ad784a56-80b8-40d8-915e-0d6153d7c863", "AQAAAAEAACcQAAAAEJsrOSe4FbypuHmgU+MqkyNE0IRr2exabDUpgA3wikRnEZqtx3buZg4Qh7oaCc4vkQ==", "84f138c1-8af1-4f27-8af8-aa633754cd3d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5093413e-4acb-471a-9ce7-53df30689fc1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1e39c53f-ae6e-4121-b4f2-2502b94211c3", "AQAAAAEAACcQAAAAEBL+oEeaSyk1wsCPciF0ByigWOUTSBSy8Zh0IGNTfvrlB6e4WwaRGgkyGyql7xFbRw==", "6179f2fd-24da-4811-853b-bbbed45603c6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6c1ff15b-1853-4d20-98ff-9695affb432c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1b780875-d3fd-4d2a-bcd5-bf143a3c70ea", "AQAAAAEAACcQAAAAEC7aZzK085TZCZr7GXhuI9Jra9VmOynUIH1P0W0vnO5/3RcvZJuLFvk8nwc6uUtj5w==", "1f06d827-e099-42b8-9d58-014f6861b008" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "925da918-5cd0-4b17-9b62-2f417aac0343",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e06eb455-e28a-4390-a2e8-b05b38225ece", "AQAAAAEAACcQAAAAEJu451ajaDviOcBfdrs8C/yH5fyRcB5ETNpPEzk/hHXijvO32hfuS834IyKDn8uneQ==", "a17d3a7a-5741-43f7-bc90-cb94a393cd26" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a171483f-6e48-446a-a5d7-36110d0c1443",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "179504fa-2599-452b-abfd-c0dec5eb2d7d", "AQAAAAEAACcQAAAAENkU8GDgTK0AHKD2XYXA7quV5SiowiOaXryqOzXGY4CWhzi7LN6+C8/GgPKDFnMyLg==", "a59844c5-b0ba-4709-9c81-e62ed79e4e07" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a3717562-385e-41ce-9eff-0f1b994e5548",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "84b9bd41-5237-476e-88a3-18a72bc43b2f", "AQAAAAEAACcQAAAAEBgr4kIbOo+uWoQ3FqgCYtjBrjURrRZqxjewg0XxeidwNwZOuAH0Hi0vpgJwJZyG9g==", "d31cceb9-a156-4758-bd2f-36072624e4ad" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2502a25-8341-4e5c-af74-cd0f889ede1b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4e822b3f-9e97-4258-9a60-0bc181fbd710", "AQAAAAEAACcQAAAAEEsN3U6chBu8hWUn1SEQpD564fV41MkODPoElE8lhtALmu5xQhO6kVedzKjYY994OQ==", "d4632f3a-7418-4d86-ba22-61332683133a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bd3e68c0-728b-44a0-ba3a-992d8ae683f9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "278d228f-a5f9-4528-90b1-d6aa2713238f", "AQAAAAEAACcQAAAAEFcT4lOgGuhR5rih+yjWqlKZfij3TmG7N0UNPwq+1Q4CkFSys4v2XsAJ25fhzom1ow==", "79126071-6db2-4bd4-ba4d-620275ea3d84" });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 11, 18, 15, 40, 737, DateTimeKind.Local).AddTicks(9184));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 23, 18, 15, 40, 737, DateTimeKind.Local).AddTicks(9222));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 22, 18, 15, 40, 737, DateTimeKind.Local).AddTicks(9224));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 18, 18, 15, 40, 737, DateTimeKind.Local).AddTicks(9227));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "ParentId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "ParentId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                column: "ParentId",
                value: 2);

            migrationBuilder.CreateIndex(
                name: "IX_Students_ParentId",
                table: "Students",
                column: "ParentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Parents_ParentId",
                table: "Students",
                column: "ParentId",
                principalTable: "Parents",
                principalColumn: "Id");
        }
    }
}
