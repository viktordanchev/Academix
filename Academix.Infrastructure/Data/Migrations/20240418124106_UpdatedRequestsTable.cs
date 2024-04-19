using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Academix.Infrastructure.Migrations
{
    public partial class UpdatedRequestsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 18, 15, 41, 6, 152, DateTimeKind.Local).AddTicks(6214));

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 19, 15, 41, 6, 152, DateTimeKind.Local).AddTicks(6246));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7f92327f-b1c1-4fd0-b837-afc278f256b2",
                column: "ConcurrencyStamp",
                value: "bc3988bc-dfec-4b97-af0e-3521656095d7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a550b411-e5c7-407f-aaba-35161bab127e",
                column: "ConcurrencyStamp",
                value: "4e032cc9-c1f9-453f-8d93-3c8f932aab05");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e67d14b1-de35-47bd-96ac-a70fcc4c25be",
                column: "ConcurrencyStamp",
                value: "0df6cd82-e6e5-4e35-ad67-7e3b6c3479b4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f67cd347-818b-4c3e-a1ce-ae76e1a2e31b",
                column: "ConcurrencyStamp",
                value: "6d6dbcc9-f7d6-40df-a321-180d3fbe48ba");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fc1ee3a5-9b29-43ea-b038-2265c1806a75",
                column: "ConcurrencyStamp",
                value: "0f6d7c6f-233d-448a-aefd-54108966fc58");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11f2b8bd-a49a-42cd-b08b-ce067e430965",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8641f235-1ae8-4805-b863-74ca8fa2bcc2", "AQAAAAEAACcQAAAAEDX/rLJZE/BXzZXXZ0d3pfCKy6778B5nVMhueRxo/mzV7DxKUlO4Vpn4+dHMaJYWzA==", "adebb6fd-b079-4b21-9e7f-2599d2b0459a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1ae342a8-9fab-4c0a-bd5a-70b351717ecc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0174fb04-3dcc-4ac6-8ecf-4b4fe9881b19", "AQAAAAEAACcQAAAAEBT2MjhJ6bwscJDrZvMQUr6Qa5o/am1Q29MGMaBSjbJKO6jBnEpL2YldhlePovIzaw==", "bc6cfeae-4d20-4cce-9d62-45156c91ce0f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "214ce248-b8b3-4832-8c3b-7f133e7a429e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f36e4d87-69ba-419b-8911-ea6b3ace1b73", "AQAAAAEAACcQAAAAELrHblpbjVzJmNYVmG3XEl6sxMHb+ehzUjNTQtfrY1pMPz38G1VVB+EZ7FSlICgYIw==", "0ab7f84b-8475-4711-bb72-03f7072696d7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24a0fdf5-ca4f-4c0f-8120-f6c87448033c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7a5bb2c7-9ded-4893-a2ee-55fc881f2801", "AQAAAAEAACcQAAAAEMGIGUQADcuAcu0c8sGcmdFPS8cK2k7Hcs7LuX/M6IKOC2ZJJ7YbXO+SCYnWmQEpbQ==", "ac51a037-649e-4554-b09e-6de318a1e532" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5093413e-4acb-471a-9ce7-53df30689fc1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "30e5a354-3343-4c0f-afe4-fdc009cf66df", "AQAAAAEAACcQAAAAEPiAdcLz2hX1fPPkXh0vKXf4edNDDW8fIXzLLcsBx2yVMjK1OseZD+VtUgJZ/ApGXg==", "98d337c5-0b9c-4327-a6a3-c1db077a2b57" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6c1ff15b-1853-4d20-98ff-9695affb432c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "20762a8b-7e5f-4654-be27-cf5156c10786", "AQAAAAEAACcQAAAAEDOFsWwKD1e9VefNEq/RK2B5CMZ+8srE4AamXgD5jZnTLEnm9PdAOuIiKEe6RdIdkw==", "2579ab93-cfef-48f6-a44a-5578d53c4448" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "925da918-5cd0-4b17-9b62-2f417aac0343",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "34f09d6f-5ed6-46c3-aaee-9523f2c022dc", "AQAAAAEAACcQAAAAEL9T8OXewOBlDtKJVYS922Mf49vHF5GHbrmCM+BZzrAa3c1OL+7H7Lq6ArYd1Z0hlg==", "89117fd1-a4eb-4791-88eb-035f2d325050" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a171483f-6e48-446a-a5d7-36110d0c1443",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0f3de9f7-169c-4bc6-a42e-4c6a869eb3b1", "AQAAAAEAACcQAAAAEI5ggwbZM/wwUwJrHQEIh9E7ZrGQyTk+SgiP0NHKru94ZOJ4d9m4HZG1uJQjJOa1QA==", "12295caf-873f-4773-85c1-0a1f2840d3da" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a3717562-385e-41ce-9eff-0f1b994e5548",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7ffc590f-d6ae-4707-a966-0cc8f0568d8e", "AQAAAAEAACcQAAAAEImjKYjVmzdnYUQ2sB0Np4HRRFuE/f/Jef6kfZbgnRxdZG7X/1Igf48SyLkvg8pjCA==", "1c0fec67-76d6-4a8b-8610-186cf3c2c2fb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2502a25-8341-4e5c-af74-cd0f889ede1b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eb672eef-e3bf-4250-bf6b-dc1d19909480", "AQAAAAEAACcQAAAAECYlxfbky5xGZ5AHzwjFUhiv8GPhlq7HvsQLHyKGaw/L5WWkLBYlTUz/vPlJYyOxxA==", "efc4fd95-2651-4873-806f-ff8cab4b749d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bd3e68c0-728b-44a0-ba3a-992d8ae683f9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3dfa51a3-5e15-419f-834e-87c39be9881a", "AQAAAAEAACcQAAAAELqQBpODDwyo8t2nkaQm91/PwSLDXwWhxR4WdNvnY6TXnu4A0UJEKziYuYN7uwFnnA==", "5a1020b0-fcb6-4e1b-b7b8-9f0058ad368d" });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 18, 15, 41, 6, 152, DateTimeKind.Local).AddTicks(7170));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 30, 15, 41, 6, 152, DateTimeKind.Local).AddTicks(7180));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 29, 15, 41, 6, 152, DateTimeKind.Local).AddTicks(7182));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 25, 15, 41, 6, 152, DateTimeKind.Local).AddTicks(7185));

            migrationBuilder.CreateIndex(
                name: "IX_Requests_ClassId",
                table: "Requests",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_SchoolId",
                table: "Requests",
                column: "SchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_StudentId",
                table: "Requests",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Requests_Classes_ClassId",
                table: "Requests",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Requests_Schools_SchoolId",
                table: "Requests",
                column: "SchoolId",
                principalTable: "Schools",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Requests_Students_StudentId",
                table: "Requests",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Requests_Classes_ClassId",
                table: "Requests");

            migrationBuilder.DropForeignKey(
                name: "FK_Requests_Schools_SchoolId",
                table: "Requests");

            migrationBuilder.DropForeignKey(
                name: "FK_Requests_Students_StudentId",
                table: "Requests");

            migrationBuilder.DropIndex(
                name: "IX_Requests_ClassId",
                table: "Requests");

            migrationBuilder.DropIndex(
                name: "IX_Requests_SchoolId",
                table: "Requests");

            migrationBuilder.DropIndex(
                name: "IX_Requests_StudentId",
                table: "Requests");

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
                keyValue: "214ce248-b8b3-4832-8c3b-7f133e7a429e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7cbda6b3-0159-4b1e-bb68-9592c255f5c4", "AQAAAAEAACcQAAAAEO6cTA7qD2KYjV+AQCR7y0BBQkTK3TkgCBAs4JNzZ4RIviTvqpyr9V/r4ce7i/RjjA==", "161b3e8f-068e-4c54-9f99-78765f001983" });

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
        }
    }
}
