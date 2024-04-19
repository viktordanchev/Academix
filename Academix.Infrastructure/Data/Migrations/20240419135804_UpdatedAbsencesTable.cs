using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Academix.Infrastructure.Migrations
{
    public partial class UpdatedAbsencesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AbsenceType",
                table: "Absences");

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 19, 16, 58, 4, 24, DateTimeKind.Local).AddTicks(5318));

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 20, 16, 58, 4, 24, DateTimeKind.Local).AddTicks(5354));

            migrationBuilder.InsertData(
                table: "Absences",
                columns: new[] { "Id", "DateAndTime", "ExcusedAbsence", "StudentId", "SubjectId" },
                values: new object[] { 3, new DateTime(2024, 4, 21, 16, 58, 4, 24, DateTimeKind.Local).AddTicks(5357), true, 1, 2 });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7f92327f-b1c1-4fd0-b837-afc278f256b2",
                column: "ConcurrencyStamp",
                value: "62eb529f-e8b0-40d4-bf9a-b8b8433c0418");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a550b411-e5c7-407f-aaba-35161bab127e",
                column: "ConcurrencyStamp",
                value: "911c9159-7853-4ddf-9456-e2954b6dfc4e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e67d14b1-de35-47bd-96ac-a70fcc4c25be",
                column: "ConcurrencyStamp",
                value: "3407821c-4759-4e47-877d-7e0c9ae21986");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f67cd347-818b-4c3e-a1ce-ae76e1a2e31b",
                column: "ConcurrencyStamp",
                value: "4c90e747-6dd0-4397-94fa-9b881252b124");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fc1ee3a5-9b29-43ea-b038-2265c1806a75",
                column: "ConcurrencyStamp",
                value: "362893e7-c560-46c5-95fb-f15f638419d3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11f2b8bd-a49a-42cd-b08b-ce067e430965",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c385f776-d8b7-45e5-a8c1-9c2db17c2039", "AQAAAAEAACcQAAAAEHJ5OIHGMU57hybJ5OE629iL70lmGgb2x9cJfYh/lWoh8c5bZCbMROZeJCSTGf6RoQ==", "ba719fe2-585c-41e5-bf67-b2adcecf75b9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1ae342a8-9fab-4c0a-bd5a-70b351717ecc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "91935237-1513-4967-9b86-5f079a916ff0", "AQAAAAEAACcQAAAAED/KW7MxFbdWk+O9MMjSXFhRoI6cy5yDiC6c7JnvO0lTyCyP3UmdkhAHeLrVWFMxjg==", "46fd2967-2c98-4b02-a38c-387a84dcfccb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "214ce248-b8b3-4832-8c3b-7f133e7a429e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "640a0e4c-4a0c-4ae3-81ff-3d82dee76e11", "AQAAAAEAACcQAAAAECI1ocV1v4eZaLT3QrSNJDt7I3EtnXWO5gva7YpV/2yd7KLsRa6GewA3pSw1Iyljvg==", "a5e3c23a-0280-41e5-9ba3-8614a76fff53" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24a0fdf5-ca4f-4c0f-8120-f6c87448033c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "14163280-cf1a-4b46-8a15-144131db4580", "AQAAAAEAACcQAAAAEAcw4AucP75/zbD6MRJ7PnQO/o2biBStCv6c3xh0N4x1sXpUTwPbe/HphEFz6xAjcQ==", "e0c84f71-faa3-47d7-8b38-1787ada1ccbb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5093413e-4acb-471a-9ce7-53df30689fc1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8df246ac-adf6-4613-9d22-1f2dbb0a8699", "AQAAAAEAACcQAAAAEKEJ/6LYeezNeybxYW/aESTWpDHFP1wGIOOWj6LRZaAj0nX/ylcULLp+pLNX8zTsvA==", "04620881-9dcf-4807-a156-ba87292d53b2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6c1ff15b-1853-4d20-98ff-9695affb432c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a0183259-1a7a-4d10-a240-a5401e514ccb", "AQAAAAEAACcQAAAAEDa7FYr/pAm5aLmLCoPp/sN2C7ptdUEm+yl6E2lAoRhS5EjCOrcALZYdFAKd9u2miA==", "ed82ab12-ad73-42b7-a2c8-42f35520be67" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "925da918-5cd0-4b17-9b62-2f417aac0343",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ce07b9b0-4659-4b7a-9bb2-a5a51f90b5f5", "AQAAAAEAACcQAAAAEOXoPexGAIX1T6vYxjXhELNXM5PXVEUePtym485vAtVqczP7NN6V4rCLiaduzw4uGg==", "4bef29cf-5efc-425f-907a-83db64b131eb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a171483f-6e48-446a-a5d7-36110d0c1443",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9aab9206-5ae6-4fc8-8240-b97c7a5bb060", "AQAAAAEAACcQAAAAENavYQ64hAjnmQJGUunusiFUF89/tA/pIBvoCPxHag20Br1LKaz8owMbENI5yLDhdA==", "1b471137-2740-400a-8746-46732601f6b0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a3717562-385e-41ce-9eff-0f1b994e5548",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a3cd27e2-c3a7-4b8e-a239-783239b063b6", "AQAAAAEAACcQAAAAEIBN+m8huznDb8jLYtVwJhFCLEGh4x4axxHxkdPhVtklIcATzEmrT006dQ9bgJ6FKw==", "4819b80d-45f5-4f85-93d5-6a8f9c11ae1a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2502a25-8341-4e5c-af74-cd0f889ede1b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9dbf2abc-84c8-484b-93e5-a30bfe41bf03", "AQAAAAEAACcQAAAAEH4T8ItxnZ+GfcX3ZuHWyP6rKZJymIClaHx6gJryki+VDNG6O+g0j7im+W5wNV+RBw==", "e909bcf2-2e0d-4d33-97b4-4ebfcdd0838c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bd3e68c0-728b-44a0-ba3a-992d8ae683f9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "528147f3-e306-441a-93c4-9c39248b4114", "AQAAAAEAACcQAAAAEGTpaBzN99Coch8tfD44aucHE/5mgLxBFNC3g0nev0jZdAY00qIRu8ni1PSD7QgHXg==", "ad5b9134-4042-4d64-8afd-09d5825f06f0" });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 19, 16, 58, 4, 24, DateTimeKind.Local).AddTicks(6295));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAndTime",
                value: new DateTime(2024, 5, 1, 16, 58, 4, 24, DateTimeKind.Local).AddTicks(6303));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 30, 16, 58, 4, 24, DateTimeKind.Local).AddTicks(6306));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 26, 16, 58, 4, 24, DateTimeKind.Local).AddTicks(6309));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AddColumn<int>(
                name: "AbsenceType",
                table: "Absences",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
    }
}
