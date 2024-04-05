using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Academix.Infrastructure.Migrations
{
    public partial class UpdatedFewEntitiesAndSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Classes_Schools_SchoolId",
                table: "Classes");

            migrationBuilder.DropForeignKey(
                name: "FK_Schools_Directors_DirectorId",
                table: "Schools");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Schools_SchoolId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_SchoolId",
                table: "Students");

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

            migrationBuilder.DropColumn(
                name: "SchoolId",
                table: "Students");

            migrationBuilder.AlterColumn<int>(
                name: "NumberInClass",
                table: "Students",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "DirectorId",
                table: "Schools",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "SchoolId",
                table: "Classes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "09c1b655-b41f-400b-88e8-e37dd750139b", "568adc47-fe7d-46ea-bb26-34b105840e47", "Administrator", "ADMINISTRATOR" },
                    { "4ca64b77-c44b-43df-b10d-ba1ebd683338", "389dd8fb-dc9f-4811-bb36-01dc35395403", "Parent", "PARENT" },
                    { "bf188ced-d78b-4440-9478-32929b1d9e76", "e605b746-b4f2-4b13-825a-938def4f717f", "Teacher", "TEACHER" },
                    { "c573c7de-3275-4763-88db-c4512a1a97a5", "0466af58-79d9-4890-8540-0b719ff03b95", "Student", "STUDENT" },
                    { "e611f650-3ed8-4a40-995d-d7ab09d94eb1", "c801e625-6939-4469-ab56-a38ead851f9b", "Director", "DIRECTOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1ae342a8-9fab-4c0a-bd5a-70b351717ecc", 0, "c51ea7d7-b317-413c-b0d0-39ec0004d395", "m.marinov@mail.com", false, "Mitko", "Marinov", false, null, "M.MARINOV@MAIL.COM", "M.MARINOV@MAIL.COM", "AQAAAAEAACcQAAAAEOpnClYm/COxrjNaBG7I8GbMfyuDM16G9bzyXVv64gMpVHfxSmdQJS8Qp016laibHQ==", null, false, "4cb8efbf-d981-4003-930f-22d4cadd6f73", false, "m.marinov@mail.com" },
                    { "24a0fdf5-ca4f-4c0f-8120-f6c87448033c", 0, "e7e33dbb-e8d8-4570-b177-9eb0011ad7b5", "v.kirilova@mail.com", false, "Vanya", "Kirilova", false, null, "V.KIRILOVA@MAIL.COM", "V.KIRILOVA@MAIL.COM", "AQAAAAEAACcQAAAAECZNMRU+2iyaVUAsRq5+vLn0di5kPzcrVyTlUSYpouqv2qZ7mCflkK/pgFyI83x0VQ==", null, false, "d8e35936-abf9-40b2-8885-22f1f413688c", false, "v.kirilova@mail.com" },
                    { "5093413e-4acb-471a-9ce7-53df30689fc1", 0, "b2ad440a-9d16-43c3-8bc0-b99c12d983cc", "n.zakova@mail.com", false, "Nikoleta", "Zakova", false, null, "N.ZAKOVA@MAIL.COM", "N.ZAKOVA@MAIL.COM", "AQAAAAEAACcQAAAAELeCCumUESONuYFjDD2ujbgXkMGMf42XSzeOq88owbpAJTqLFsvG4jsyW1Uvu4OlPA==", null, false, "3bde6a3e-49ae-4f86-8d59-4587f7dc3d6e", false, "n.zakova@mail.com" },
                    { "6c1ff15b-1853-4d20-98ff-9695affb432c", 0, "c1fd0a59-4173-491b-9a36-ce8556893550", "d.milev@mail.com", false, "Dragan", "Milev", false, null, "D.MILEV@MAIL.COM", "D.MILEV@MAIL.COM", "AQAAAAEAACcQAAAAEMcrwvvPTh40KRco43qcWM+NbClnwNl4Sc7GyXXWFbxJr3YRdfSNqEh/FG0Fip5YFQ==", null, false, "31cd553e-3794-4f86-bf19-ed55a2b01fa2", false, "d.milev@mail.com" },
                    { "925da918-5cd0-4b17-9b62-2f417aac0343", 0, "dafbd786-3543-4af6-8b78-b411fc936f6a", "v.marinov@mail.com", false, "Vasil", "Marinov", false, null, "V.MARINOV@MAIL.COM", "V.MARINOV@MAIL.COM", "AQAAAAEAACcQAAAAEEz0ionNz+XGRjuRuWokOGS05hIS4ZTOerLT2UawF8GkZ5tNIVYB/CqaoyHbTCE7dQ==", null, false, "4cd199f5-a478-4cb4-86ec-0b0353fd5ce4", false, "v.marinov@mail.com" },
                    { "a171483f-6e48-446a-a5d7-36110d0c1443", 0, "2cc121fc-a164-4d80-a2f8-421e1bc52080", "d.kirilov@mail.com", false, "Drago", "Kirilov", false, null, "D.KIRILOV@MAIL.COM", "D.KIRILOV@MAIL.COM", "AQAAAAEAACcQAAAAECPS/8ynviDzapQz2ii3vKLa/mMW1MQo9cJ3N10NmyCMEJ3lrU4+Vjp1mJ6Tej8c3w==", null, false, "0bdaedfe-f9bc-41fd-b6ac-5ee32e6b59df", false, "d.kirilov@mail.com" },
                    { "a3717562-385e-41ce-9eff-0f1b994e5548", 0, "b98b6e8b-465e-4288-b31d-0402753470b4", "i.ivanov@mail.com", false, "Ivan", "Ivanov", false, null, "I.IVANOV@MAIL.COM", "I.IVANOV@MAIL.COM", "AQAAAAEAACcQAAAAEFukynf5C6iyUEFwNzTPfOgPZ5XO1/i11hqtDt5CHgq6nitKZeTfI9p8n8WukLdP4Q==", null, false, "fcbd5c6c-ad9a-4a3f-ae6d-e341a7f179a7", false, "i.ivanov@mail.com" },
                    { "b2502a25-8341-4e5c-af74-cd0f889ede1b", 0, "08b46611-5166-4cf8-8553-3663acfa7293", "m.kirilova@mail.com", false, "Marta", "Kirilova", false, null, "M.KIRILOVA@MAIL.COM", "M.KIRILOVA@MAIL.COM", "AQAAAAEAACcQAAAAEFbDd4GKe9LrpEnat0zsERKowxOWymg4bhf5OT9kD6k1PvT9mTPMaAE7JeBWZHGQ5w==", null, false, "1d957e96-d4d9-4539-815b-68c8606ca5a3", false, "m.kirilova@mail.com" },
                    { "bd3e68c0-728b-44a0-ba3a-992d8ae683f9", 0, "6cf6cd2d-a982-46a3-bd6a-48f5846b7ec5", "z.draganova@mail.com", false, "Zara", "Draganova", false, null, "Z.DRAGANOVA@MAIL.COM", "Z.DRAGANOVA@MAIL.COM", "AQAAAAEAACcQAAAAEPjwb8BvsxVdsLznDEDfsaljc6WVISuWWozAalABJpZWmlBb1fnLmw6Zvrk+/VJ6zA==", null, false, "8c8f0f6f-6b22-45b4-ad01-cf850a6ef82a", false, "z.draganova@mail.com" }
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
                    { 1, 1, "12A", 1 },
                    { 2, 2, "8B", 1 }
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
                    { 1, 0, new DateTime(2024, 4, 5, 11, 8, 36, 66, DateTimeKind.Local).AddTicks(5675), false, 1 },
                    { 2, 0, new DateTime(2024, 4, 6, 11, 8, 36, 66, DateTimeKind.Local).AddTicks(5703), false, 1 }
                });

            migrationBuilder.InsertData(
                table: "Grades",
                columns: new[] { "Id", "DateAndTime", "GradeNumber", "GradeType", "SubjectId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 5, 11, 8, 36, 77, DateTimeKind.Local).AddTicks(4999), 4, 0, 1 },
                    { 2, new DateTime(2024, 4, 17, 11, 8, 36, 77, DateTimeKind.Local).AddTicks(5025), 6, 0, 1 },
                    { 3, new DateTime(2024, 4, 16, 11, 8, 36, 77, DateTimeKind.Local).AddTicks(5028), 6, 1, 2 },
                    { 4, new DateTime(2024, 4, 12, 11, 8, 36, 77, DateTimeKind.Local).AddTicks(5030), 2, 0, 3 }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Address", "ClassId", "NumberInClass", "ParentId", "StudentIdentityId" },
                values: new object[,]
                {
                    { 1, "Vasil Aprilov 5", 1, 5, 1, "1ae342a8-9fab-4c0a-bd5a-70b351717ecc" },
                    { 2, "Krali Marko 12", 2, 3, 2, "a171483f-6e48-446a-a5d7-36110d0c1443" },
                    { 3, "Kalimanci 13", 2, 15, 2, "b2502a25-8341-4e5c-af74-cd0f889ede1b" }
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

            migrationBuilder.AddForeignKey(
                name: "FK_Classes_Schools_SchoolId",
                table: "Classes",
                column: "SchoolId",
                principalTable: "Schools",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Schools_Directors_DirectorId",
                table: "Schools",
                column: "DirectorId",
                principalTable: "Directors",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Classes_Schools_SchoolId",
                table: "Classes");

            migrationBuilder.DropForeignKey(
                name: "FK_Schools_Directors_DirectorId",
                table: "Schools");

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
                keyValue: "09c1b655-b41f-400b-88e8-e37dd750139b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4ca64b77-c44b-43df-b10d-ba1ebd683338");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf188ced-d78b-4440-9478-32929b1d9e76");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c573c7de-3275-4763-88db-c4512a1a97a5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e611f650-3ed8-4a40-995d-d7ab09d94eb1");

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

            migrationBuilder.AlterColumn<int>(
                name: "NumberInClass",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SchoolId",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "DirectorId",
                table: "Schools",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SchoolId",
                table: "Classes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

            migrationBuilder.CreateIndex(
                name: "IX_Students_SchoolId",
                table: "Students",
                column: "SchoolId");

            migrationBuilder.AddForeignKey(
                name: "FK_Classes_Schools_SchoolId",
                table: "Classes",
                column: "SchoolId",
                principalTable: "Schools",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Schools_Directors_DirectorId",
                table: "Schools",
                column: "DirectorId",
                principalTable: "Directors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Schools_SchoolId",
                table: "Students",
                column: "SchoolId",
                principalTable: "Schools",
                principalColumn: "Id");
        }
    }
}
