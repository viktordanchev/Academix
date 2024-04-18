using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Academix.Infrastructure.Migrations
{
    public partial class UpdatedRequestsReceiversTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RequestsReceivers_Requests_RequestId",
                table: "RequestsReceivers");

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 18, 10, 47, 25, 391, DateTimeKind.Local).AddTicks(70));

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 19, 10, 47, 25, 391, DateTimeKind.Local).AddTicks(107));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7f92327f-b1c1-4fd0-b837-afc278f256b2",
                column: "ConcurrencyStamp",
                value: "cd636d60-d76c-4e83-98b3-9d6b32d9e43c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a550b411-e5c7-407f-aaba-35161bab127e",
                column: "ConcurrencyStamp",
                value: "42da75f1-4a08-4e75-b006-f8d622a6445a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e67d14b1-de35-47bd-96ac-a70fcc4c25be",
                column: "ConcurrencyStamp",
                value: "5ce6cef3-38ad-4bd9-af82-7f8d4df8b801");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f67cd347-818b-4c3e-a1ce-ae76e1a2e31b",
                column: "ConcurrencyStamp",
                value: "25474186-b7ed-4422-8f5c-ef1a3f55907e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fc1ee3a5-9b29-43ea-b038-2265c1806a75",
                column: "ConcurrencyStamp",
                value: "2558cfaf-77c4-432d-a8ea-19c0969255f1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11f2b8bd-a49a-42cd-b08b-ce067e430965",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b019a72a-f94a-4965-9f2f-04bada21148f", "AQAAAAEAACcQAAAAEN3wrj3lTLiMuWbVhMyKImTplpvb4GR4f81J/+QJxgcbP1cjWV+2QuR0j/LoJ20EzQ==", "308443e7-e53f-4763-b123-719d25bbe842" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1ae342a8-9fab-4c0a-bd5a-70b351717ecc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2626a71e-e5e1-4909-838a-4296e30fc2b1", "AQAAAAEAACcQAAAAECQHgp7CjpcpZThfksQtpuGEYRlC/ON3oi8piclOnKKmsL5Ug6FMrSeRtzQJ99JQdw==", "599a9196-e453-4262-bcc8-86d4d04bfba6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24a0fdf5-ca4f-4c0f-8120-f6c87448033c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f46f1606-14bb-427d-93a6-a8ce130b93b7", "AQAAAAEAACcQAAAAEBxvuDnPeJhpzAfOSSh+QC5Iwk6ISmlzJ8YB6Q1pEEy2VrDmK6Lm8RErZ+HzthhLSA==", "511af493-7763-48ec-8949-99e5eaf9765f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5093413e-4acb-471a-9ce7-53df30689fc1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c770cbef-b871-40d3-a4d6-e032edb8417a", "AQAAAAEAACcQAAAAEA8FU5PZJ5my5OLuV2+fnjqcPbMRnSqsjA+Lapd751Xa9kHkk3nQ+4ENTT+P3YpSAw==", "0ef3cc1d-bfcd-42b5-9207-4c0cc2e0d90c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6c1ff15b-1853-4d20-98ff-9695affb432c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "68807c71-da75-41da-94c0-b62e7ae5253d", "AQAAAAEAACcQAAAAENDiS/3iQtXohqgMah4OoxMSw+7hHS4ODBvkkubysgja5QO8U2TVB+0MwP+IezpIRw==", "706a1856-f050-4b1f-8db3-5246d1320724" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "925da918-5cd0-4b17-9b62-2f417aac0343",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7617c746-d6e5-4e9a-8959-a6a008e7bf00", "AQAAAAEAACcQAAAAEF9zdrkzgFmqtkLDbDQn+PSlip5OBxhmaGdPPlq7DutF0yecipWr9PjtpuaulpSc7A==", "6df4b1b4-65f8-4eba-86ec-16f83da87d8e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a171483f-6e48-446a-a5d7-36110d0c1443",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3df95d21-1df4-45ba-ba31-45e228ae2a7b", "AQAAAAEAACcQAAAAEE5bBOShaf/F1rRN8pR0KKsYMY545RmAWNmlLYVSRgQvBS8DDZdNGv5h02gm/IsdJQ==", "b83b2489-1332-4126-a050-8171d74ea2a6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a3717562-385e-41ce-9eff-0f1b994e5548",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "12a0b924-1822-4803-b786-74c97122ab80", "AQAAAAEAACcQAAAAEBJgDLJvJOHZe7d1aXZAmQqoigPLOxkXi3EEvyYLnAj7M2OlY3wajQNK1qhcderSAA==", "4d87d3fb-9034-48dc-b293-f5f077f36f2d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2502a25-8341-4e5c-af74-cd0f889ede1b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "269db2b2-1d2a-40f6-9ee2-99354e357890", "AQAAAAEAACcQAAAAEI3DIlHn+TAKg6kIYsepnTXcXWJf7iLEUGsPvo34DRtqbaUybnB0nIQZvlGhCbLqpg==", "bb43cddd-2d03-443f-b978-edf8e76f1239" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bd3e68c0-728b-44a0-ba3a-992d8ae683f9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f5434f1b-580f-42e9-a4d3-ac07a5b1940b", "AQAAAAEAACcQAAAAEHawb4yTROyHImowfMMBZk+DKihsbNA3qB4TDtaF8954Lf5TOWOl7Bjlc1kawZBjHg==", "a19aea49-1b68-4750-a3c7-40dc58b72d31" });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 18, 10, 47, 25, 391, DateTimeKind.Local).AddTicks(1027));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 30, 10, 47, 25, 391, DateTimeKind.Local).AddTicks(1036));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 29, 10, 47, 25, 391, DateTimeKind.Local).AddTicks(1038));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 25, 10, 47, 25, 391, DateTimeKind.Local).AddTicks(1041));

            migrationBuilder.AddForeignKey(
                name: "FK_RequestsReceivers_Requests_RequestId",
                table: "RequestsReceivers",
                column: "RequestId",
                principalTable: "Requests",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RequestsReceivers_Requests_RequestId",
                table: "RequestsReceivers");

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 18, 10, 30, 2, 355, DateTimeKind.Local).AddTicks(1521));

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 19, 10, 30, 2, 355, DateTimeKind.Local).AddTicks(1550));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7f92327f-b1c1-4fd0-b837-afc278f256b2",
                column: "ConcurrencyStamp",
                value: "dfc1699d-031c-4f7e-88cf-d7688ce20836");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a550b411-e5c7-407f-aaba-35161bab127e",
                column: "ConcurrencyStamp",
                value: "07958f8c-bd71-4d41-a858-5b7b5639fa43");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e67d14b1-de35-47bd-96ac-a70fcc4c25be",
                column: "ConcurrencyStamp",
                value: "1169dfe6-955b-4c1d-b98b-2aefe373a4bd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f67cd347-818b-4c3e-a1ce-ae76e1a2e31b",
                column: "ConcurrencyStamp",
                value: "228a84d5-7636-4ed3-9b21-0a2a1b116ebb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fc1ee3a5-9b29-43ea-b038-2265c1806a75",
                column: "ConcurrencyStamp",
                value: "506538d8-b0c3-4908-bda2-2af9887e8cf2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11f2b8bd-a49a-42cd-b08b-ce067e430965",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "96b7e83d-d1cf-4c22-aab2-bdebc97db8ea", "AQAAAAEAACcQAAAAENTUkEuRk1gLphcr8ff5kMJiwuMzidXidkoKAsIdo7cMWO7xH6Yw40I5VBmOUMvuMg==", "8187cc7c-9a67-443b-b76c-87eb067ea88e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1ae342a8-9fab-4c0a-bd5a-70b351717ecc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "37f395ca-a14a-4e0c-bad0-cbd6da2bde45", "AQAAAAEAACcQAAAAEGjcAf0MwKrUrQtRjwMwpCy0WqjyFg77KwfmtQCCnIYtGEeYzriOjhbezt3T+kiKmQ==", "86360492-d123-4140-b580-348817443110" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24a0fdf5-ca4f-4c0f-8120-f6c87448033c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3635cee0-23f8-4e2c-bfe7-f2def58fed3c", "AQAAAAEAACcQAAAAEBe2mmLpy5VnsD7RUi+MNdm11OgzSgehC7pdpdyS40VyP6KC2wOLqSqKd3+VsaMMVg==", "e4f25458-e103-45fe-839d-5f35e23d82cc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5093413e-4acb-471a-9ce7-53df30689fc1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b1a1e703-b04b-436b-a504-799d9fdfcc09", "AQAAAAEAACcQAAAAEJbGwayqb6bufu8n7vgeEO8e7izeDv0KMWYzeWjtB2PEaDMfibIXMk4FZoDlN6IsTQ==", "5c1e5adf-9afc-4cca-88ec-fd0741a27c48" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6c1ff15b-1853-4d20-98ff-9695affb432c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4766490a-7538-4993-a291-5083207cf087", "AQAAAAEAACcQAAAAEI/sE1eE9kyZXb62REiK4cK7iVTc3+6tP6Aoc0RrJe25TCQfUg0MsL03zuObZJOT5Q==", "a835cbfd-123b-443d-9722-3683f698d899" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "925da918-5cd0-4b17-9b62-2f417aac0343",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "32de89ab-43c0-4d0e-89a2-a2d087a860df", "AQAAAAEAACcQAAAAEKnTxGJYPJA43bRPYh5YTGq+rvts60rxMcGJ3wlXdTYlLBpRlcgA79eripLlQ4fYRg==", "af405718-5a7e-421d-b599-9050120546e0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a171483f-6e48-446a-a5d7-36110d0c1443",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "63c87baf-018c-4653-97d6-709465c048c7", "AQAAAAEAACcQAAAAENJ2cUaF2dl6HD0FqG87JPDFW/0A0P11xKdi4V41jnsn+fZsun1Bv1P4bRyRuLy3Xg==", "51c7b1d6-649e-4352-8a2e-de48c4578fd0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a3717562-385e-41ce-9eff-0f1b994e5548",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5e6b6aec-ff84-4e8d-a28d-9f1bb4adcea9", "AQAAAAEAACcQAAAAEMiJVcixwNgDdFTOZ7RLuc0CG27a1rb5wBjZofpwwR7Z7qtmyxayd3FwnW7ZgBiOtw==", "2580bb08-2303-485f-bc9a-d3b71dc4333d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2502a25-8341-4e5c-af74-cd0f889ede1b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e537f147-86e2-4640-98aa-244ed7ed09c3", "AQAAAAEAACcQAAAAEAbpPAinLzpsfD+9QkKrGMLq+1PY0bbZUFigfP0O+G1f6+UThskS4qHMPDzhLWY4CQ==", "7f5d2c47-cf40-48f9-afc5-f34d2c480401" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bd3e68c0-728b-44a0-ba3a-992d8ae683f9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5a1ba777-3909-4edb-91e2-645b8ca9d7b6", "AQAAAAEAACcQAAAAECSOksfUhqsoIlK04fWjuvOQQI91kOYusyjMLwjJ0ez2rduAMxwatuEpPcthS2D74A==", "7cb6b945-93e0-4418-bbea-f8f5894a4d00" });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 18, 10, 30, 2, 355, DateTimeKind.Local).AddTicks(2459));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 30, 10, 30, 2, 355, DateTimeKind.Local).AddTicks(2469));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 29, 10, 30, 2, 355, DateTimeKind.Local).AddTicks(2472));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 25, 10, 30, 2, 355, DateTimeKind.Local).AddTicks(2474));

            migrationBuilder.AddForeignKey(
                name: "FK_RequestsReceivers_Requests_RequestId",
                table: "RequestsReceivers",
                column: "RequestId",
                principalTable: "Requests",
                principalColumn: "Id");
        }
    }
}
