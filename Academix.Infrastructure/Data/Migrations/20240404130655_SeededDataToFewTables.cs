using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Academix.Infrastructure.Migrations
{
    public partial class SeededDataToFewTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0d528e32-834b-4a2c-8c30-45f02bc50e66");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7e07ae4e-1b0e-44ef-953e-6edc4199f885");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8679f400-9b07-4081-9c01-6fdfa9109514");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dba6d188-6dec-4d5c-a66f-2b4f63af5633");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e9a8e131-c448-47b7-9a1c-1427fdcf8450");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0d1fc518-beb2-444b-bb9f-6964c30d0c0d", "83653081-74bf-4ebb-a189-885b5f917f03", "Administrator", "ADMINISTRATOR" },
                    { "2e88e378-eb4d-4c7a-a878-3bce4acdb55b", "261e71c6-dfcb-43b0-a2ec-b6e9b4c3e354", "Teacher", "TEACHER" },
                    { "4570b49b-e006-4951-a901-611b50749d6d", "e735a2cb-67a2-4fbb-9375-0b008d06b697", "Director", "DIRECTOR" },
                    { "5a342eda-37cf-43b3-b975-f1e9247a5218", "cdcfa9a6-895f-4a02-8a9f-67d967234f5b", "Student", "STUDENT" },
                    { "6503eddd-76d0-4007-a14d-87c2eefa546c", "7a52d7e3-8c21-4c18-837f-e34b10522174", "Parent", "PARENT" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1ae342a8-9fab-4c0a-bd5a-70b351717ecc", 0, "ca41dd34-3147-402f-87e9-ecbb5451ef6b", "m.marinov@mail.com", false, "Mitko", "Marinov", false, null, "M.MARINOV@MAIL.COM", "M.MARINOV@MAIL.COM", "AQAAAAEAACcQAAAAEBv76VFebsLKsQCGfvus+/HCrc2JS7u3yyxZZxPzUVIshqlbcoRkF1aPMNeO/2rYYg==", null, false, "7511cccb-f1cc-496c-92eb-889ba1fe3770", false, "m.marinov@mail.com" },
                    { "24a0fdf5-ca4f-4c0f-8120-f6c87448033c", 0, "4c715aa5-8fa8-4548-863c-6097648e1aac", "v.kirilova@mail.com", false, "Vanya", "Kirilova", false, null, "V.KIRILOVA@MAIL.COM", "V.KIRILOVA@MAIL.COM", "AQAAAAEAACcQAAAAEIe9HCejI1DlEKQIycoPTEkphL5gfxf4VP/c6HvY8UL0yQrtD5TBxJi7CsdJGBzezQ==", null, false, "f66efcaf-ec4b-4ac4-aa58-407e758650c1", false, "v.kirilova@mail.com" },
                    { "5093413e-4acb-471a-9ce7-53df30689fc1", 0, "2fde9713-b005-4d74-8b2b-08465dde0930", "n.zakova@mail.com", false, "Nikoleta", "Zakova", false, null, "N.ZAKOVA@MAIL.COM", "N.ZAKOVA@MAIL.COM", "AQAAAAEAACcQAAAAEMWAhWwxnPQGx7ThQgONrW2PFurbjqlWvkNJXl5KKvFOdUP5SYDgQEW5/XWNq1UZdQ==", null, false, "3f989903-40b7-4e03-a3fe-7e776acb2121", false, "n.zakova@mail.com" },
                    { "6c1ff15b-1853-4d20-98ff-9695affb432c", 0, "e145bac6-820b-4528-8cb8-f65991a80bc7", "d.milev@mail.com", false, "Dragan", "Milev", false, null, "D.MILEV@MAIL.COM", "D.MILEV@MAIL.COM", "AQAAAAEAACcQAAAAEBoI7K921oWUSfWXfffFqhgB2xqGZItvJ8f0RXaDzFOO+ztH5Jxmvqk2Zv1ajDL1OA==", null, false, "70a8d502-2470-4127-b494-ec680049a7c6", false, "d.milev@mail.com" },
                    { "925da918-5cd0-4b17-9b62-2f417aac0343", 0, "e61e0669-1339-4782-952e-00c7d90f466c", "v.marinov@mail.com", false, "Vasil", "Marinov", false, null, "V.MARINOV@MAIL.COM", "V.MARINOV@MAIL.COM", "AQAAAAEAACcQAAAAEDBSYVXD/hNYsblUT9X+MC/mUSfeWtK4MWJ2RqlxoXCok808UixA8YYBYcL5KTh+qA==", null, false, "ba46419d-bc22-4247-9bc8-2d3964d522cb", false, "v.marinov@mail.com" },
                    { "a171483f-6e48-446a-a5d7-36110d0c1443", 0, "e21904bb-20b2-4b03-bf00-338bc290f511", "d.kirilov@mail.com", false, "Drago", "Kirilov", false, null, "D.KIRILOV@MAIL.COM", "D.KIRILOV@MAIL.COM", "AQAAAAEAACcQAAAAEA0WFMf2B+JIazVy1dDe2S2MoF+uVubiJzm/IOyMSJNrEyTfrzkcIHNqYssCZJOKqg==", null, false, "19590556-e170-4fef-a0ba-52ba1b63eee4", false, "d.kirilov@mail.com" },
                    { "a3717562-385e-41ce-9eff-0f1b994e5548", 0, "e84588ab-ef9a-4c44-b394-b06a40e7b88a", "i.ivanov@mail.com", false, "Ivan", "Ivanov", false, null, "I.IVANOV@MAIL.COM", "I.IVANOV@MAIL.COM", "AQAAAAEAACcQAAAAEL0n61FxxFhM987FuxLbQ5cZ7/FSfPQd/jylbM5ScvYwtVZjYLa1N8ynnSt9SxJeKg==", null, false, "4ca26553-07e8-4f5c-a411-0a2047818ff6", false, "i.ivanov@mail.com" },
                    { "b2502a25-8341-4e5c-af74-cd0f889ede1b", 0, "9a4e9258-a89e-49a2-9662-098a73363123", "m.kirilova@mail.com", false, "Marta", "Kirilova", false, null, "M.KIRILOVA@MAIL.COM", "M.KIRILOVA@MAIL.COM", "AQAAAAEAACcQAAAAEETuQ17rUm82JacCGuuQ7B72vClpBO7KDxaAkLsPWdpKkpQZvs7S09ZuAIjihxzR0Q==", null, false, "6e00ad85-3114-4c0a-997b-471834b4c238", false, "m.kirilova@mail.com" },
                    { "bd3e68c0-728b-44a0-ba3a-992d8ae683f9", 0, "61b84308-88d6-4b7f-9bfe-479b7bcddbb1", "z.draganova@mail.com", false, "Zara", "Draganova", false, null, "Z.DRAGANOVA@MAIL.COM", "Z.DRAGANOVA@MAIL.COM", "AQAAAAEAACcQAAAAEGB4PQ8/rxlOvI5wJsOqZWO3ZwINQAhVlVBGtCW1wZ4L0WfQczQ/NSkFRyTCFR+Bbg==", null, false, "9249121e-3add-415c-87d1-ac0a09ecf8d7", false, "z.draganova@mail.com" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Burgas" });

            migrationBuilder.InsertData(
                table: "Directors",
                columns: new[] { "Id", "DirectorIdentityId" },
                values: new object[] { 1, "a3717562-385e-41ce-9eff-0f1b994e5548" });

            migrationBuilder.InsertData(
                table: "Parents",
                columns: new[] { "Id", "ParentIdentityId" },
                values: new object[] { 1, "925da918-5cd0-4b17-9b62-2f417aac0343" });

            migrationBuilder.InsertData(
                table: "Parents",
                columns: new[] { "Id", "ParentIdentityId" },
                values: new object[] { 2, "24a0fdf5-ca4f-4c0f-8120-f6c87448033c" });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "CityId", "DirectorId", "Name" },
                values: new object[] { 1, 1, 1, "Vasil Levski" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "SchoolId", "TeacherIdentityId" },
                values: new object[] { 1, 1, "5093413e-4acb-471a-9ce7-53df30689fc1" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "SchoolId", "TeacherIdentityId" },
                values: new object[] { 2, 1, "6c1ff15b-1853-4d20-98ff-9695affb432c" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "SchoolId", "TeacherIdentityId" },
                values: new object[] { 3, 1, "bd3e68c0-728b-44a0-ba3a-992d8ae683f9" });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "ClassTeacherId", "Name", "SchoolId" },
                values: new object[,]
                {
                    { 1, 1, "12A", null },
                    { 2, 2, "8B", null }
                });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "Name", "TeacherId" },
                values: new object[,]
                {
                    { 1, "Mathematics", 1 },
                    { 2, "Physics", 2 },
                    { 3, "History", 3 }
                });

            migrationBuilder.InsertData(
                table: "Absences",
                columns: new[] { "Id", "AbsenceType", "DateAndTime", "ExcusedAbsence", "SubjectId" },
                values: new object[,]
                {
                    { 1, 0, new DateTime(2024, 4, 4, 16, 6, 55, 545, DateTimeKind.Local).AddTicks(8896), false, 1 },
                    { 2, 0, new DateTime(2024, 4, 5, 16, 6, 55, 545, DateTimeKind.Local).AddTicks(8926), false, 1 }
                });

            migrationBuilder.InsertData(
                table: "Grades",
                columns: new[] { "Id", "DateAndTime", "GradeNumber", "GradeType", "SubjectId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 4, 16, 6, 55, 556, DateTimeKind.Local).AddTicks(9455), 4, 0, 1 },
                    { 2, new DateTime(2024, 4, 16, 16, 6, 55, 556, DateTimeKind.Local).AddTicks(9483), 6, 0, 1 },
                    { 3, new DateTime(2024, 4, 15, 16, 6, 55, 556, DateTimeKind.Local).AddTicks(9485), 6, 1, 2 },
                    { 4, new DateTime(2024, 4, 11, 16, 6, 55, 556, DateTimeKind.Local).AddTicks(9488), 2, 0, 3 }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Address", "ClassId", "NumberInClass", "ParentId", "SchoolId", "StudentIdentityId" },
                values: new object[,]
                {
                    { 1, "Vasil Aprilov 5", 1, 5, 1, 1, "1ae342a8-9fab-4c0a-bd5a-70b351717ecc" },
                    { 2, "Krali Marko 12", 2, 3, 2, 1, "a171483f-6e48-446a-a5d7-36110d0c1443" },
                    { 3, "Kalimanci 13", 2, 15, 2, 1, "b2502a25-8341-4e5c-af74-cd0f889ede1b" }
                });

            migrationBuilder.InsertData(
                table: "SubjectsStudents",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "SubjectsStudents",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { 1, 2 });

            migrationBuilder.InsertData(
                table: "SubjectsStudents",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { 1, 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0d1fc518-beb2-444b-bb9f-6964c30d0c0d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e88e378-eb4d-4c7a-a878-3bce4acdb55b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4570b49b-e006-4951-a901-611b50749d6d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5a342eda-37cf-43b3-b975-f1e9247a5218");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6503eddd-76d0-4007-a14d-87c2eefa546c");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SubjectsStudents",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "SubjectsStudents",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "SubjectsStudents",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a171483f-6e48-446a-a5d7-36110d0c1443");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2502a25-8341-4e5c-af74-cd0f889ede1b");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1ae342a8-9fab-4c0a-bd5a-70b351717ecc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24a0fdf5-ca4f-4c0f-8120-f6c87448033c");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6c1ff15b-1853-4d20-98ff-9695affb432c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "925da918-5cd0-4b17-9b62-2f417aac0343");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bd3e68c0-728b-44a0-ba3a-992d8ae683f9");

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5093413e-4acb-471a-9ce7-53df30689fc1");

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a3717562-385e-41ce-9eff-0f1b994e5548");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0d528e32-834b-4a2c-8c30-45f02bc50e66", "4ceb1fbc-503b-4ca1-8333-81299b2fa748", "Director", "DIRECTOR" },
                    { "7e07ae4e-1b0e-44ef-953e-6edc4199f885", "0c8c51b1-d760-4810-a7f6-6d09677d9b32", "Administrator", "ADMINISTRATOR" },
                    { "8679f400-9b07-4081-9c01-6fdfa9109514", "fa62b6ea-cc0b-41f1-be54-98009b2500e8", "Parent", "PARENT" },
                    { "dba6d188-6dec-4d5c-a66f-2b4f63af5633", "1bf73414-db50-4154-8150-b67cdbf86d4e", "Teacher", "TEACHER" },
                    { "e9a8e131-c448-47b7-9a1c-1427fdcf8450", "5aa66b68-91dc-4a56-bf22-3698412e4b8e", "Student", "STUDENT" }
                });
        }
    }
}
