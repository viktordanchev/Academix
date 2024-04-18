using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Academix.Infrastructure.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Requests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RequesterId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SchoolId = table.Column<int>(type: "int", nullable: false),
                    ClassId = table.Column<int>(type: "int", nullable: true),
                    StudentId = table.Column<int>(type: "int", nullable: true),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Requests_AspNetUsers_RequesterId",
                        column: x => x.RequesterId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Schools",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    DirectorId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schools", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Schools_AspNetUsers_DirectorId",
                        column: x => x.DirectorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Schools_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RequestsReceivers",
                columns: table => new
                {
                    RequestId = table.Column<int>(type: "int", nullable: false),
                    ReceiverId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestsReceivers", x => new { x.RequestId, x.ReceiverId });
                    table.ForeignKey(
                        name: "FK_RequestsReceivers_AspNetUsers_ReceiverId",
                        column: x => x.ReceiverId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RequestsReceivers_Requests_RequestId",
                        column: x => x.RequestId,
                        principalTable: "Requests",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeacherIdentityId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SchoolId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teachers_AspNetUsers_TeacherIdentityId",
                        column: x => x.TeacherIdentityId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Teachers_Schools_SchoolId",
                        column: x => x.SchoolId,
                        principalTable: "Schools",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SchoolId = table.Column<int>(type: "int", nullable: false),
                    ClassTeacherId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Classes_Schools_SchoolId",
                        column: x => x.SchoolId,
                        principalTable: "Schools",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Classes_Teachers_ClassTeacherId",
                        column: x => x.ClassTeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TeacherId = table.Column<int>(type: "int", nullable: false),
                    SchoolId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subjects_Schools_SchoolId",
                        column: x => x.SchoolId,
                        principalTable: "Schools",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Subjects_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberInClass = table.Column<int>(type: "int", nullable: true),
                    StudentIdentityId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClassId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Students_AspNetUsers_StudentIdentityId",
                        column: x => x.StudentIdentityId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Students_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Absences",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateAndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExcusedAbsence = table.Column<bool>(type: "bit", nullable: false),
                    AbsenceType = table.Column<int>(type: "int", nullable: false),
                    SubjectId = table.Column<int>(type: "int", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Absences", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Absences_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Absences_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Grades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GradeNumber = table.Column<int>(type: "int", nullable: false),
                    DateAndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GradeType = table.Column<int>(type: "int", nullable: false),
                    SubjectId = table.Column<int>(type: "int", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Grades_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Grades_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentsParents",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    ParentId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentsParents", x => new { x.StudentId, x.ParentId });
                    table.ForeignKey(
                        name: "FK_StudentsParents_AspNetUsers_ParentId",
                        column: x => x.ParentId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StudentsParents_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SubjectsStudents",
                columns: table => new
                {
                    SubjectId = table.Column<int>(type: "int", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubjectsStudents", x => new { x.SubjectId, x.StudentId });
                    table.ForeignKey(
                        name: "FK_SubjectsStudents_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SubjectsStudents_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7f92327f-b1c1-4fd0-b837-afc278f256b2", "dfc1699d-031c-4f7e-88cf-d7688ce20836", "Admin", "ADMIN" },
                    { "a550b411-e5c7-407f-aaba-35161bab127e", "07958f8c-bd71-4d41-a858-5b7b5639fa43", "Director", "DIRECTOR" },
                    { "e67d14b1-de35-47bd-96ac-a70fcc4c25be", "1169dfe6-955b-4c1d-b98b-2aefe373a4bd", "Student", "STUDENT" },
                    { "f67cd347-818b-4c3e-a1ce-ae76e1a2e31b", "228a84d5-7636-4ed3-9b21-0a2a1b116ebb", "Teacher", "TEACHER" },
                    { "fc1ee3a5-9b29-43ea-b038-2265c1806a75", "506538d8-b0c3-4908-bda2-2af9887e8cf2", "Parent", "PARENT" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "11f2b8bd-a49a-42cd-b08b-ce067e430965", 0, "96b7e83d-d1cf-4c22-aab2-bdebc97db8ea", "admin@mail.com", false, "admin", "Admin", false, null, "ADMIN@MAIL.COM", "ADMIN@MAIL.COM", "AQAAAAEAACcQAAAAENTUkEuRk1gLphcr8ff5kMJiwuMzidXidkoKAsIdo7cMWO7xH6Yw40I5VBmOUMvuMg==", null, false, "8187cc7c-9a67-443b-b76c-87eb067ea88e", false, "admin@mail.com" },
                    { "1ae342a8-9fab-4c0a-bd5a-70b351717ecc", 0, "37f395ca-a14a-4e0c-bad0-cbd6da2bde45", "m.marinov@mail.com", false, "Mitko", "Marinov", false, null, "M.MARINOV@MAIL.COM", "M.MARINOV@MAIL.COM", "AQAAAAEAACcQAAAAEGjcAf0MwKrUrQtRjwMwpCy0WqjyFg77KwfmtQCCnIYtGEeYzriOjhbezt3T+kiKmQ==", null, false, "86360492-d123-4140-b580-348817443110", false, "m.marinov@mail.com" },
                    { "24a0fdf5-ca4f-4c0f-8120-f6c87448033c", 0, "3635cee0-23f8-4e2c-bfe7-f2def58fed3c", "v.kirilova@mail.com", false, "Vanya", "Kirilova", false, null, "V.KIRILOVA@MAIL.COM", "V.KIRILOVA@MAIL.COM", "AQAAAAEAACcQAAAAEBe2mmLpy5VnsD7RUi+MNdm11OgzSgehC7pdpdyS40VyP6KC2wOLqSqKd3+VsaMMVg==", null, false, "e4f25458-e103-45fe-839d-5f35e23d82cc", false, "v.kirilova@mail.com" },
                    { "5093413e-4acb-471a-9ce7-53df30689fc1", 0, "b1a1e703-b04b-436b-a504-799d9fdfcc09", "n.zakova@mail.com", false, "Nikoleta", "Zakova", false, null, "N.ZAKOVA@MAIL.COM", "N.ZAKOVA@MAIL.COM", "AQAAAAEAACcQAAAAEJbGwayqb6bufu8n7vgeEO8e7izeDv0KMWYzeWjtB2PEaDMfibIXMk4FZoDlN6IsTQ==", null, false, "5c1e5adf-9afc-4cca-88ec-fd0741a27c48", false, "n.zakova@mail.com" },
                    { "6c1ff15b-1853-4d20-98ff-9695affb432c", 0, "4766490a-7538-4993-a291-5083207cf087", "d.milev@mail.com", false, "Dragan", "Milev", false, null, "D.MILEV@MAIL.COM", "D.MILEV@MAIL.COM", "AQAAAAEAACcQAAAAEI/sE1eE9kyZXb62REiK4cK7iVTc3+6tP6Aoc0RrJe25TCQfUg0MsL03zuObZJOT5Q==", null, false, "a835cbfd-123b-443d-9722-3683f698d899", false, "d.milev@mail.com" },
                    { "925da918-5cd0-4b17-9b62-2f417aac0343", 0, "32de89ab-43c0-4d0e-89a2-a2d087a860df", "v.marinov@mail.com", false, "Vasil", "Marinov", false, null, "V.MARINOV@MAIL.COM", "V.MARINOV@MAIL.COM", "AQAAAAEAACcQAAAAEKnTxGJYPJA43bRPYh5YTGq+rvts60rxMcGJ3wlXdTYlLBpRlcgA79eripLlQ4fYRg==", null, false, "af405718-5a7e-421d-b599-9050120546e0", false, "v.marinov@mail.com" },
                    { "a171483f-6e48-446a-a5d7-36110d0c1443", 0, "63c87baf-018c-4653-97d6-709465c048c7", "d.kirilov@mail.com", false, "Drago", "Kirilov", false, null, "D.KIRILOV@MAIL.COM", "D.KIRILOV@MAIL.COM", "AQAAAAEAACcQAAAAENJ2cUaF2dl6HD0FqG87JPDFW/0A0P11xKdi4V41jnsn+fZsun1Bv1P4bRyRuLy3Xg==", null, false, "51c7b1d6-649e-4352-8a2e-de48c4578fd0", false, "d.kirilov@mail.com" },
                    { "a3717562-385e-41ce-9eff-0f1b994e5548", 0, "5e6b6aec-ff84-4e8d-a28d-9f1bb4adcea9", "i.ivanov@mail.com", false, "Ivan", "Ivanov", false, null, "I.IVANOV@MAIL.COM", "I.IVANOV@MAIL.COM", "AQAAAAEAACcQAAAAEMiJVcixwNgDdFTOZ7RLuc0CG27a1rb5wBjZofpwwR7Z7qtmyxayd3FwnW7ZgBiOtw==", null, false, "2580bb08-2303-485f-bc9a-d3b71dc4333d", false, "i.ivanov@mail.com" },
                    { "b2502a25-8341-4e5c-af74-cd0f889ede1b", 0, "e537f147-86e2-4640-98aa-244ed7ed09c3", "m.kirilova@mail.com", false, "Marta", "Kirilova", false, null, "M.KIRILOVA@MAIL.COM", "M.KIRILOVA@MAIL.COM", "AQAAAAEAACcQAAAAEAbpPAinLzpsfD+9QkKrGMLq+1PY0bbZUFigfP0O+G1f6+UThskS4qHMPDzhLWY4CQ==", null, false, "7f5d2c47-cf40-48f9-afc5-f34d2c480401", false, "m.kirilova@mail.com" },
                    { "bd3e68c0-728b-44a0-ba3a-992d8ae683f9", 0, "5a1ba777-3909-4edb-91e2-645b8ca9d7b6", "z.draganova@mail.com", false, "Zara", "Draganova", false, null, "Z.DRAGANOVA@MAIL.COM", "Z.DRAGANOVA@MAIL.COM", "AQAAAAEAACcQAAAAECSOksfUhqsoIlK04fWjuvOQQI91kOYusyjMLwjJ0ez2rduAMxwatuEpPcthS2D74A==", null, false, "7cb6b945-93e0-4418-bbea-f8f5894a4d00", false, "z.draganova@mail.com" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Sofia" },
                    { 2, "Varna" },
                    { 3, "Burgas" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "7f92327f-b1c1-4fd0-b837-afc278f256b2", "11f2b8bd-a49a-42cd-b08b-ce067e430965" },
                    { "e67d14b1-de35-47bd-96ac-a70fcc4c25be", "1ae342a8-9fab-4c0a-bd5a-70b351717ecc" },
                    { "fc1ee3a5-9b29-43ea-b038-2265c1806a75", "24a0fdf5-ca4f-4c0f-8120-f6c87448033c" },
                    { "f67cd347-818b-4c3e-a1ce-ae76e1a2e31b", "5093413e-4acb-471a-9ce7-53df30689fc1" },
                    { "f67cd347-818b-4c3e-a1ce-ae76e1a2e31b", "6c1ff15b-1853-4d20-98ff-9695affb432c" },
                    { "fc1ee3a5-9b29-43ea-b038-2265c1806a75", "925da918-5cd0-4b17-9b62-2f417aac0343" },
                    { "e67d14b1-de35-47bd-96ac-a70fcc4c25be", "a171483f-6e48-446a-a5d7-36110d0c1443" },
                    { "a550b411-e5c7-407f-aaba-35161bab127e", "a3717562-385e-41ce-9eff-0f1b994e5548" },
                    { "e67d14b1-de35-47bd-96ac-a70fcc4c25be", "b2502a25-8341-4e5c-af74-cd0f889ede1b" },
                    { "f67cd347-818b-4c3e-a1ce-ae76e1a2e31b", "bd3e68c0-728b-44a0-ba3a-992d8ae683f9" }
                });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "CityId", "DirectorId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "a3717562-385e-41ce-9eff-0f1b994e5548", "Vasil Levski" },
                    { 2, 1, null, "137 Georgi Asparuhov" }
                });

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
                columns: new[] { "Id", "Name", "SchoolId", "TeacherId" },
                values: new object[,]
                {
                    { 1, "Mathematics", 1, 1 },
                    { 2, "Physics", 1, 2 },
                    { 3, "History", 1, 3 }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Address", "ClassId", "NumberInClass", "StudentIdentityId" },
                values: new object[] { 1, "Vasil Aprilov 5", 1, 5, "1ae342a8-9fab-4c0a-bd5a-70b351717ecc" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Address", "ClassId", "NumberInClass", "StudentIdentityId" },
                values: new object[] { 2, "Krali Marko 12", 2, 3, "a171483f-6e48-446a-a5d7-36110d0c1443" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Address", "ClassId", "NumberInClass", "StudentIdentityId" },
                values: new object[] { 3, "Kalimanci 13", 2, 15, "b2502a25-8341-4e5c-af74-cd0f889ede1b" });

            migrationBuilder.InsertData(
                table: "Absences",
                columns: new[] { "Id", "AbsenceType", "DateAndTime", "ExcusedAbsence", "StudentId", "SubjectId" },
                values: new object[,]
                {
                    { 1, 0, new DateTime(2024, 4, 18, 10, 30, 2, 355, DateTimeKind.Local).AddTicks(1521), false, 1, 1 },
                    { 2, 0, new DateTime(2024, 4, 19, 10, 30, 2, 355, DateTimeKind.Local).AddTicks(1550), false, 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "Grades",
                columns: new[] { "Id", "DateAndTime", "GradeNumber", "GradeType", "StudentId", "SubjectId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 18, 10, 30, 2, 355, DateTimeKind.Local).AddTicks(2459), 4, 0, 1, 1 },
                    { 2, new DateTime(2024, 4, 30, 10, 30, 2, 355, DateTimeKind.Local).AddTicks(2469), 6, 0, 1, 1 },
                    { 3, new DateTime(2024, 4, 29, 10, 30, 2, 355, DateTimeKind.Local).AddTicks(2472), 6, 1, 1, 2 },
                    { 4, new DateTime(2024, 4, 25, 10, 30, 2, 355, DateTimeKind.Local).AddTicks(2474), 2, 0, 1, 3 }
                });

            migrationBuilder.InsertData(
                table: "StudentsParents",
                columns: new[] { "ParentId", "StudentId" },
                values: new object[,]
                {
                    { "925da918-5cd0-4b17-9b62-2f417aac0343", 1 },
                    { "24a0fdf5-ca4f-4c0f-8120-f6c87448033c", 2 },
                    { "24a0fdf5-ca4f-4c0f-8120-f6c87448033c", 3 }
                });

            migrationBuilder.InsertData(
                table: "SubjectsStudents",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Absences_StudentId",
                table: "Absences",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Absences_SubjectId",
                table: "Absences",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_ClassTeacherId",
                table: "Classes",
                column: "ClassTeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_SchoolId",
                table: "Classes",
                column: "SchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_Grades_StudentId",
                table: "Grades",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Grades_SubjectId",
                table: "Grades",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_RequesterId",
                table: "Requests",
                column: "RequesterId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestsReceivers_ReceiverId",
                table: "RequestsReceivers",
                column: "ReceiverId");

            migrationBuilder.CreateIndex(
                name: "IX_Schools_CityId",
                table: "Schools",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Schools_DirectorId",
                table: "Schools",
                column: "DirectorId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_ClassId",
                table: "Students",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_StudentIdentityId",
                table: "Students",
                column: "StudentIdentityId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentsParents_ParentId",
                table: "StudentsParents",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_SchoolId",
                table: "Subjects",
                column: "SchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_TeacherId",
                table: "Subjects",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_SubjectsStudents_StudentId",
                table: "SubjectsStudents",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_SchoolId",
                table: "Teachers",
                column: "SchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_TeacherIdentityId",
                table: "Teachers",
                column: "TeacherIdentityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Absences");

            migrationBuilder.DropTable(
                name: "Grades");

            migrationBuilder.DropTable(
                name: "RequestsReceivers");

            migrationBuilder.DropTable(
                name: "StudentsParents");

            migrationBuilder.DropTable(
                name: "SubjectsStudents");

            migrationBuilder.DropTable(
                name: "Requests");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Subjects");

            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "Schools");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7f92327f-b1c1-4fd0-b837-afc278f256b2", "11f2b8bd-a49a-42cd-b08b-ce067e430965" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e67d14b1-de35-47bd-96ac-a70fcc4c25be", "1ae342a8-9fab-4c0a-bd5a-70b351717ecc" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fc1ee3a5-9b29-43ea-b038-2265c1806a75", "24a0fdf5-ca4f-4c0f-8120-f6c87448033c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f67cd347-818b-4c3e-a1ce-ae76e1a2e31b", "5093413e-4acb-471a-9ce7-53df30689fc1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f67cd347-818b-4c3e-a1ce-ae76e1a2e31b", "6c1ff15b-1853-4d20-98ff-9695affb432c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fc1ee3a5-9b29-43ea-b038-2265c1806a75", "925da918-5cd0-4b17-9b62-2f417aac0343" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e67d14b1-de35-47bd-96ac-a70fcc4c25be", "a171483f-6e48-446a-a5d7-36110d0c1443" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a550b411-e5c7-407f-aaba-35161bab127e", "a3717562-385e-41ce-9eff-0f1b994e5548" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e67d14b1-de35-47bd-96ac-a70fcc4c25be", "b2502a25-8341-4e5c-af74-cd0f889ede1b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f67cd347-818b-4c3e-a1ce-ae76e1a2e31b", "bd3e68c0-728b-44a0-ba3a-992d8ae683f9" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7f92327f-b1c1-4fd0-b837-afc278f256b2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a550b411-e5c7-407f-aaba-35161bab127e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e67d14b1-de35-47bd-96ac-a70fcc4c25be");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f67cd347-818b-4c3e-a1ce-ae76e1a2e31b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fc1ee3a5-9b29-43ea-b038-2265c1806a75");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11f2b8bd-a49a-42cd-b08b-ce067e430965");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24a0fdf5-ca4f-4c0f-8120-f6c87448033c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "925da918-5cd0-4b17-9b62-2f417aac0343");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1ae342a8-9fab-4c0a-bd5a-70b351717ecc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a171483f-6e48-446a-a5d7-36110d0c1443");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2502a25-8341-4e5c-af74-cd0f889ede1b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bd3e68c0-728b-44a0-ba3a-992d8ae683f9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5093413e-4acb-471a-9ce7-53df30689fc1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6c1ff15b-1853-4d20-98ff-9695affb432c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a3717562-385e-41ce-9eff-0f1b994e5548");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");
        }
    }
}
