using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Academix.Infrastructure.Migrations
{
    public partial class RemovedMessageColumnFromRequests : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Message",
                table: "Requests");

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 18, 16, 47, 32, 203, DateTimeKind.Local).AddTicks(8603));

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 19, 16, 47, 32, 203, DateTimeKind.Local).AddTicks(8637));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7f92327f-b1c1-4fd0-b837-afc278f256b2",
                column: "ConcurrencyStamp",
                value: "d71189c6-592d-42de-907e-b9c19d966abb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a550b411-e5c7-407f-aaba-35161bab127e",
                column: "ConcurrencyStamp",
                value: "1701c802-86c2-4fd5-a3a5-a78b431b766c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e67d14b1-de35-47bd-96ac-a70fcc4c25be",
                column: "ConcurrencyStamp",
                value: "fa28b43b-7d70-4830-816d-2653129f4511");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f67cd347-818b-4c3e-a1ce-ae76e1a2e31b",
                column: "ConcurrencyStamp",
                value: "7d066ce7-15dc-4e91-a6d9-3f65f9af6a05");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fc1ee3a5-9b29-43ea-b038-2265c1806a75",
                column: "ConcurrencyStamp",
                value: "5dae3ad9-93dd-4f70-8ee3-099f01fb6e36");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11f2b8bd-a49a-42cd-b08b-ce067e430965",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0997df3f-85d4-4108-838c-389500bd6974", "AQAAAAEAACcQAAAAELKDNpyJ3DhbzNW72j2TYLutXjuSAdGUAqow4WEoPkEAXAUY8pGpira0p2QKbZI4vg==", "8d652247-e162-462e-b167-93f64123f81a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1ae342a8-9fab-4c0a-bd5a-70b351717ecc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6742bb28-57fe-4cb3-a8a1-3a6289d1b8d7", "AQAAAAEAACcQAAAAEK9d343oHuVjzUmlmifXCpmPNCsWqqFPNN26/oe+mS4/yvyt25KHKAds/coZxuibcA==", "6675139e-409d-49dc-9b23-dd03fa2572c5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "214ce248-b8b3-4832-8c3b-7f133e7a429e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "965b19d5-ee87-4203-a757-0be4ba0c9379", "AQAAAAEAACcQAAAAENViTPYW+Rx1q668XXkqx1PeRROOFlLHyclD3+/E2jX3WZ2/Yz6nljlxqZIja9y+Xw==", "22cca93b-c65c-4c38-8d1b-c846769d9473" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24a0fdf5-ca4f-4c0f-8120-f6c87448033c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "361d90a4-6812-4545-8a2e-8ffd1cfcd733", "AQAAAAEAACcQAAAAEDY6ElTWQ5O+XKp1+S31xBrSn7K8BW+s9QPBAzCeJQAKYSwLb+fDl0tVo0Kd3E2YSQ==", "a39de51b-f84d-45a7-b039-2b0d19e10e1c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5093413e-4acb-471a-9ce7-53df30689fc1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6493a47e-7fb8-42dc-a09e-7f27257d8834", "AQAAAAEAACcQAAAAENshs/0AsmO91rAeJdadnqJYaYY+6qAUMrQ+h3ukIFHk0OFxK0oQRHY8kzE2AE51gA==", "c0781d8e-5785-473e-ad85-ecf5035ae503" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6c1ff15b-1853-4d20-98ff-9695affb432c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "46aa6c05-97d8-4beb-9782-d650424f9749", "AQAAAAEAACcQAAAAEGiZDFG/0hlsD2fY0n4dT7lKtw2Gb0ykWczKW4KCmFNeWCdn9Od9FQNCbm9Z0Uyjcg==", "953ef47e-a855-4b5a-a440-e7cbc13df226" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "925da918-5cd0-4b17-9b62-2f417aac0343",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1e6e2d05-fdc5-4ae2-8978-9eb57c2d1dd2", "AQAAAAEAACcQAAAAELCBvX+rUQ641sUVJ50DgN+gB2eqlLWqfgMg1g3V5liOyS000e//KxtOy792K9Vhgw==", "e9af2b0f-61e2-458d-89fb-9f21c29b6fd5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a171483f-6e48-446a-a5d7-36110d0c1443",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d774af22-c8e7-4c1b-814f-94dfdc4e677e", "AQAAAAEAACcQAAAAEPZXwFIindiRwFH6YTGRrfquITHRqe+Ho17JwtxNcBhSKQIQBq8nAE5ygOcMG5lmSg==", "9380fe47-921c-4e5a-ad67-462934303951" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a3717562-385e-41ce-9eff-0f1b994e5548",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8a78b915-2c32-4a30-baef-838bb32b99ca", "AQAAAAEAACcQAAAAEA/ZK08UO+/J42nZ9wjgdKa8cTF92O5A4L/GGWCBZj8Xd9ZjZj/QBrAw9GEQrbXemQ==", "df778c75-c4c4-4cf7-98e3-0b38320c686d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2502a25-8341-4e5c-af74-cd0f889ede1b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "128fe28f-cd6c-4c8c-b4d9-ce3c44b71086", "AQAAAAEAACcQAAAAEHRhzYDLNja0LMNAeLFG+yr+4EOnJ+T/gqC4eHTq6xhJK3Ja/8irwxDuCDJ4IcodsQ==", "07b7b638-0417-48dd-97ec-1aea1ace756c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bd3e68c0-728b-44a0-ba3a-992d8ae683f9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "01417184-24ce-40bb-99f1-c6ce9b0cd74a", "AQAAAAEAACcQAAAAEMoR+9pTWcrT/DKKyHDdJX1FBXanmP1q41MEDebREc438DA3XWuoig4x1OFL7WL9iw==", "d4a5b05f-d21b-43af-8f52-d959fe456fd8" });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 18, 16, 47, 32, 203, DateTimeKind.Local).AddTicks(9605));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 30, 16, 47, 32, 203, DateTimeKind.Local).AddTicks(9614));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 29, 16, 47, 32, 203, DateTimeKind.Local).AddTicks(9617));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 25, 16, 47, 32, 203, DateTimeKind.Local).AddTicks(9619));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Message",
                table: "Requests",
                type: "nvarchar(max)",
                nullable: true);

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
        }
    }
}
