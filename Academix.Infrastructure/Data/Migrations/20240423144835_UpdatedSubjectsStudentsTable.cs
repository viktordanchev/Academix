using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Academix.Infrastructure.Migrations
{
    public partial class UpdatedSubjectsStudentsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubjectsStudents_Subjects_SubjectId",
                table: "SubjectsStudents");

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 23, 17, 48, 34, 832, DateTimeKind.Local).AddTicks(5048));

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 24, 17, 48, 34, 832, DateTimeKind.Local).AddTicks(5082));

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 25, 17, 48, 34, 832, DateTimeKind.Local).AddTicks(5084));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7f92327f-b1c1-4fd0-b837-afc278f256b2",
                column: "ConcurrencyStamp",
                value: "7cf51094-5a62-4c4d-b6c7-3044ce460b74");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a550b411-e5c7-407f-aaba-35161bab127e",
                column: "ConcurrencyStamp",
                value: "c5b84a70-c5e6-4329-8053-6405c713a7a5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e67d14b1-de35-47bd-96ac-a70fcc4c25be",
                column: "ConcurrencyStamp",
                value: "2da4a943-8bf0-46e0-8bb7-99f608879bae");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f67cd347-818b-4c3e-a1ce-ae76e1a2e31b",
                column: "ConcurrencyStamp",
                value: "631e2e09-a604-4aec-bc3e-7c8b9f124b10");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fc1ee3a5-9b29-43ea-b038-2265c1806a75",
                column: "ConcurrencyStamp",
                value: "ed788692-87ab-45a1-84fc-38db75f9ae2f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11f2b8bd-a49a-42cd-b08b-ce067e430965",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e2baaf67-a31f-43c4-973f-c7453b2cd39b", "AQAAAAEAACcQAAAAELGSpKEmHZOokupCmBHaKAe6dVXtS5fRFc2nWz54dp8Uw01RStBhZK2Oe6yfhHU4Tw==", "e30a607b-a214-48a2-a9f4-d71efa1ca46b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1ae342a8-9fab-4c0a-bd5a-70b351717ecc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e736984f-ff91-4c15-b211-f5d1005e3850", "AQAAAAEAACcQAAAAEGXddOMQSF4JnIexid9/56BDgs/MC18OgkuXB8iH23kXZvyxSsodRLBWxkki2ysCqA==", "e442737a-c4d4-48c2-8da9-64431fdc9eec" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "214ce248-b8b3-4832-8c3b-7f133e7a429e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4e8929fd-4506-415f-9eff-1b90048e14f8", "AQAAAAEAACcQAAAAECc6wT+kNbJhrYv04o0r30dngewLg6h8Yz0ndJQPsBcc6b8DNnDaSR/QJ21O2PjPvg==", "4f2add41-4602-469e-82e5-e54c09330f17" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24a0fdf5-ca4f-4c0f-8120-f6c87448033c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6240e20d-11ed-4d14-b29d-545489abb4a2", "AQAAAAEAACcQAAAAECfAluKkLissnc1+qhtLl0LXeHMhEpPTGVsMO1RL0PU4v1TG+Lcf3nauS66W1M4S8Q==", "fb296357-2165-4445-ac44-5be6a032ccbd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5093413e-4acb-471a-9ce7-53df30689fc1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c4679682-c567-4c7b-ba10-1c1836c129c7", "AQAAAAEAACcQAAAAEOX2qm/lmSwdhJo7FTF3CyBm4Nnh4Xac97iI2r1A6Vy0JG/wshuiiJBhI1crC89Vpw==", "1015ee81-ec2f-46ae-a5db-32f4f5a8aee1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6c1ff15b-1853-4d20-98ff-9695affb432c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cf4ef2a7-8100-46a7-9dd6-1da033fbb9d9", "AQAAAAEAACcQAAAAEBgo+dhhCLta/riVB8Dzu7Ud4J0UDzhZz51m9nwhAqOW5m5YpdlRsg8b1SZbX+EEtg==", "ff3c57af-3f20-4bc8-856a-1cfe08122344" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "925da918-5cd0-4b17-9b62-2f417aac0343",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "43761117-4ee3-4e47-bd38-2baed3ac9e0c", "AQAAAAEAACcQAAAAEKFJafxgFmMEfLUV31qe1V01JfTVb6Y+p5EpIgUBhVnq0re+5T22G/W+PTXAWeuEUA==", "20ac1349-5b2e-46bc-9c96-634db17b3cd6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a171483f-6e48-446a-a5d7-36110d0c1443",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "103f22e5-03fc-4639-8406-f4338d561598", "AQAAAAEAACcQAAAAEB+FzBH+gL/1gz6q0h1oGNXJ79p/k3DjtXDLFV6t+JiHoW7JXfAw909nJD+pvA7T7g==", "8f3ed2ae-e8c5-4407-aa23-32e12301f2ae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a3717562-385e-41ce-9eff-0f1b994e5548",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5e779399-25f3-4fe0-b29c-2a071e3b8042", "AQAAAAEAACcQAAAAENEz3UOFGHF6Cg24Pk5z9bN2vIJUdb0x40WLB757/SO3wA92IxTBCwowaeRmyqOKLw==", "4cfce1e8-aa78-4b5e-be10-5c63a261dfdd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2502a25-8341-4e5c-af74-cd0f889ede1b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e0f5add5-0a49-4a93-8569-687be186bb5b", "AQAAAAEAACcQAAAAELwp0aQGIevdK6m/MMzmM6D2eozangLpBZtf2FJS74bB1iUwS70SIDwq1uIvKuvNkA==", "d8f49445-0a9a-400d-b316-dfddc60a5d79" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bd3e68c0-728b-44a0-ba3a-992d8ae683f9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3cab1660-d7d0-4d0e-a5a2-5fdf881ae832", "AQAAAAEAACcQAAAAEK48hrNExl+s1cnnPWivYN0PX4B1V7xy5QZgRmv6T2C0//fG87o5P1pM5DjaVkOCpw==", "b789528c-581a-4e30-b5cd-1568a6e44318" });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 23, 17, 48, 34, 832, DateTimeKind.Local).AddTicks(6108));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAndTime",
                value: new DateTime(2024, 5, 5, 17, 48, 34, 832, DateTimeKind.Local).AddTicks(6116));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateAndTime",
                value: new DateTime(2024, 5, 4, 17, 48, 34, 832, DateTimeKind.Local).AddTicks(6119));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 30, 17, 48, 34, 832, DateTimeKind.Local).AddTicks(6121));

            migrationBuilder.AddForeignKey(
                name: "FK_SubjectsStudents_Subjects_SubjectId",
                table: "SubjectsStudents",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubjectsStudents_Subjects_SubjectId",
                table: "SubjectsStudents");

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

            migrationBuilder.AddForeignKey(
                name: "FK_SubjectsStudents_Subjects_SubjectId",
                table: "SubjectsStudents",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "Id");
        }
    }
}
