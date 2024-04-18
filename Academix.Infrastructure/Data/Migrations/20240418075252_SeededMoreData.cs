using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Academix.Infrastructure.Migrations
{
    public partial class SeededMoreData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 18, 10, 52, 51, 868, DateTimeKind.Local).AddTicks(1714));

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 19, 10, 52, 51, 868, DateTimeKind.Local).AddTicks(1750));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7f92327f-b1c1-4fd0-b837-afc278f256b2",
                column: "ConcurrencyStamp",
                value: "e33285e4-747f-49d6-93b6-45bc5a3b0e09");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a550b411-e5c7-407f-aaba-35161bab127e",
                column: "ConcurrencyStamp",
                value: "e3dfac96-3274-4c0a-b666-4af6738dec8d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e67d14b1-de35-47bd-96ac-a70fcc4c25be",
                column: "ConcurrencyStamp",
                value: "bda6ff06-c048-4e65-9dd7-02fdbcd8b82d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f67cd347-818b-4c3e-a1ce-ae76e1a2e31b",
                column: "ConcurrencyStamp",
                value: "6208d949-efe6-406f-ac98-97105f4c93c4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fc1ee3a5-9b29-43ea-b038-2265c1806a75",
                column: "ConcurrencyStamp",
                value: "bedbdda1-d597-4ad8-8b34-accaf2a48d93");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11f2b8bd-a49a-42cd-b08b-ce067e430965",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5f6c04f8-d3e4-4cf6-a585-9825cb4b9ddb", "AQAAAAEAACcQAAAAEKCGCzsJD2Eii+eustsOFIA64E0U3GVrq33C+zgRTtOyh8Oo1/CjecKC70TF3W5Cug==", "e3a0b0a6-4ca9-4c9b-b999-8c335beafee8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1ae342a8-9fab-4c0a-bd5a-70b351717ecc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e0f8988e-68a4-42ad-815f-d7629be8ecae", "AQAAAAEAACcQAAAAELsIKwPC/dhgJutrn9kkRurXrruvRUgIdswYGloBEOvPvy3OewybpQmJFpG2XQkB8w==", "dae21042-ae22-47d3-843c-ede0dd116e72" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24a0fdf5-ca4f-4c0f-8120-f6c87448033c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b2044fe7-b1bb-4c60-8e35-df7a368bc600", "AQAAAAEAACcQAAAAEPcQTs+25mUkO5hWPOPegq0iRND0VdWBo4Iz3JRFTf4zUSqjb7r3hf3v/5gKgA7XnQ==", "8e466f24-b86c-4f08-afe2-a46a9e3203d9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5093413e-4acb-471a-9ce7-53df30689fc1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ba732b8d-661c-45f7-9227-f356d8df52c8", "AQAAAAEAACcQAAAAEGGJCYpe2yWe/sgkkdTLO5wvBLn6qMVaTmJkGkI02cIH9+cizgELQl/r5ORLJ7aVYQ==", "927d4183-8396-4349-8bf8-81e548f129bf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6c1ff15b-1853-4d20-98ff-9695affb432c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4b4424cb-e615-478e-b8a0-4f6ca35afc5f", "AQAAAAEAACcQAAAAEESzqOFx7BT3xQ5T8vcJg1MFejgABUdNYcZeV0cKZ2pzweJB43CabZN+dPk02QNMoQ==", "80f12984-da28-456a-b09d-abc5774a1cf5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "925da918-5cd0-4b17-9b62-2f417aac0343",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "822835e0-facf-48b9-b6bc-6653ab399066", "AQAAAAEAACcQAAAAEJuLnsci7BBxzlSjRCdn8qTmsF8/8+6tYdVAkVUvvmw6oCnj8tRGBgy2WBs1A9OgVA==", "6057a9c1-6b69-44a3-8a2f-ab8f886c82b8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a171483f-6e48-446a-a5d7-36110d0c1443",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7ce0760b-5b2f-4599-a4f8-d8c2ccd872c0", "AQAAAAEAACcQAAAAEFccGX7+ZDHE8szW/CthbUiSUtnNtTvJfoIhUNwR1jWj0Fzl8/a2SCbWzTMeu+aIaw==", "ec9fa63b-2e55-4b55-b361-41bd78239d70" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a3717562-385e-41ce-9eff-0f1b994e5548",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b5cd0c0a-55b6-4923-927c-9a2b93399b81", "AQAAAAEAACcQAAAAEBoUve1X77yG//2FDQkAOvxTYV8jpAefxILXi5B6TOHdR4cDlR9awdzzAWXA39ZGKQ==", "114b0baa-72d1-4b0f-8472-aa49e658532e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2502a25-8341-4e5c-af74-cd0f889ede1b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b621d0ed-d5e8-4790-806a-865c99f4ff84", "AQAAAAEAACcQAAAAEHwHW6Vpi8bFbF9thdVSB5JQ6o/jd/pvAd8ilHzyoW2jiKusv7/FtzFvOu+a2dM6WQ==", "4ee8a7f4-2318-4ef2-b3da-1d48843dd54a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bd3e68c0-728b-44a0-ba3a-992d8ae683f9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cc4cb4c4-bd7d-40d9-9736-f945b346bf5f", "AQAAAAEAACcQAAAAEDrOBrauEhFx1rSYoL61saN8SoD3fLW8PwaRHRD4H8kKkmiZ4Umoi/Lt9BS7qB9v5w==", "37f068cf-90df-4d61-8191-625c650fe199" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "214ce248-b8b3-4832-8c3b-7f133e7a429e", 0, "7cbda6b3-0159-4b1e-bb68-9592c255f5c4", "admin2@mail.com", false, "admin2", "Admin2", false, null, "ADMIN2@MAIL.COM", "ADMIN2@MAIL.COM", "AQAAAAEAACcQAAAAEO6cTA7qD2KYjV+AQCR7y0BBQkTK3TkgCBAs4JNzZ4RIviTvqpyr9V/r4ce7i/RjjA==", null, false, "161b3e8f-068e-4c54-9f99-78765f001983", false, "admin2@mail.com" });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 18, 10, 52, 51, 868, DateTimeKind.Local).AddTicks(2723));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 30, 10, 52, 51, 868, DateTimeKind.Local).AddTicks(2733));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 29, 10, 52, 51, 868, DateTimeKind.Local).AddTicks(2736));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 25, 10, 52, 51, 868, DateTimeKind.Local).AddTicks(2738));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "7f92327f-b1c1-4fd0-b837-afc278f256b2", "214ce248-b8b3-4832-8c3b-7f133e7a429e" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7f92327f-b1c1-4fd0-b837-afc278f256b2", "214ce248-b8b3-4832-8c3b-7f133e7a429e" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "214ce248-b8b3-4832-8c3b-7f133e7a429e");

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
        }
    }
}
