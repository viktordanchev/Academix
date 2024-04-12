using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Academix.Infrastructure.Migrations
{
    public partial class SeededOneMoreSchool : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "CityId", "DirectorId", "Name" },
                values: new object[] { 2, 1, null, "137 Georgi Asparuhov" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 11, 15, 48, 53, 454, DateTimeKind.Local).AddTicks(895));

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 12, 15, 48, 53, 454, DateTimeKind.Local).AddTicks(929));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7f92327f-b1c1-4fd0-b837-afc278f256b2",
                column: "ConcurrencyStamp",
                value: "db46a76a-4ea1-4528-ac5e-0ac2e73a0285");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a550b411-e5c7-407f-aaba-35161bab127e",
                column: "ConcurrencyStamp",
                value: "4bac75f8-cc7a-4082-bb59-774b5fafef84");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e67d14b1-de35-47bd-96ac-a70fcc4c25be",
                column: "ConcurrencyStamp",
                value: "2991a619-6ce2-445d-8c71-0e9ecc3e5336");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f67cd347-818b-4c3e-a1ce-ae76e1a2e31b",
                column: "ConcurrencyStamp",
                value: "de281f5e-5ea4-4ddc-b1ea-61537e49243e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fc1ee3a5-9b29-43ea-b038-2265c1806a75",
                column: "ConcurrencyStamp",
                value: "54607086-5dbf-4698-80c6-4f36ca0b5f74");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11f2b8bd-a49a-42cd-b08b-ce067e430965",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "81dad689-9475-40d7-ab7f-3457316e1f16", "AQAAAAEAACcQAAAAEP4LkyzfkIVaIiOsZqYYYXmVIgW1KUGw1UOerOswgOyIDUAUoatPvPCMW+BXilq4Eg==", "a0bae927-e5f3-401f-8d4e-094c9c1f0ae5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1ae342a8-9fab-4c0a-bd5a-70b351717ecc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c65b7aa6-fbfd-4438-b862-0a0dc0e5d3fb", "AQAAAAEAACcQAAAAEAl8cm+DDq6CupykPC6E7eGpdkzAzcAYsKNEufmrFtj1xsw4zjk+UwEpYA2BCYkY4A==", "ea7216da-0212-4295-b23a-3a63ec393db9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24a0fdf5-ca4f-4c0f-8120-f6c87448033c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "576205ed-03cc-4bde-bd69-bad28fa1777f", "AQAAAAEAACcQAAAAEL76AGBIcWHydPq5Ovd27ExL1HgaVfGBCt0LchWY/WM0z4EoHn9zjTwGcLed6yxKUQ==", "fc7a65ba-da15-49ce-ab36-1197e11dd343" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5093413e-4acb-471a-9ce7-53df30689fc1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "42786555-c461-48a0-8880-a6559193015e", "AQAAAAEAACcQAAAAEEKdjt5F8MG/YF8BKGSOPCRRh5IN5OyAlIQ86V2fFG2NL2gNMKPNMs/rm6p2rPnhpA==", "468f8db5-4e35-4028-ab58-99b50d4b5bfa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6c1ff15b-1853-4d20-98ff-9695affb432c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8bae2065-430b-4a21-ad8e-e26691ba079d", "AQAAAAEAACcQAAAAEHhjvQ1hdyTBtMy6xFrbjzvZ4iTMRyJ9j+f5vciH1xCRsoLbnL9IZikk+AieIjkFUQ==", "447a1af4-1b91-4ee2-b6e0-d709448f2651" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "925da918-5cd0-4b17-9b62-2f417aac0343",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ae7e5f66-2888-4834-8a37-3ffaa37e0ae9", "AQAAAAEAACcQAAAAELsVbdknVJtVP1MfLTul5XMQtavzqx/h8JGGPieJna7AUz9LyrHAdcqhp0g8rmbq4g==", "3132ff3e-35f2-4b00-a2f8-75d069433b8c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a171483f-6e48-446a-a5d7-36110d0c1443",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "282c52cb-f045-47cd-aee1-88f281879e6d", "AQAAAAEAACcQAAAAEJoFbUO7o+eVJlt/w2lJFjndo1/CikXokr/3u+Zku6b/LEpqN0Y/VRFj9JOg9E57QQ==", "69705b30-596b-4ee6-b741-ac5c9f7c3a2b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a3717562-385e-41ce-9eff-0f1b994e5548",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6209c52c-15e7-4efb-b18b-48eea0784704", "AQAAAAEAACcQAAAAEOBycGo27Z4Pmxl84GbD5Ze9UunQ8uuGjU4MvJpfRBQc7Rv2MV3DByR9tHb9tzcq1g==", "e4d7ac1f-b9ba-485c-8db7-af5bbbfe07e6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2502a25-8341-4e5c-af74-cd0f889ede1b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4a2dd961-c440-4ec1-ad01-bffad39ab0ba", "AQAAAAEAACcQAAAAELuk/8u/rbSnDdww9rIy3o6nVPL7aLOXYp+Au4BAbnkwT5vuqnx5vK1EzzpffPck9Q==", "b7cd8301-546e-4ac0-a86f-70aa969bf14c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bd3e68c0-728b-44a0-ba3a-992d8ae683f9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a3fec592-03ec-4b9e-a3d6-fe8593fd69bd", "AQAAAAEAACcQAAAAEDgZ1aFUyFmVL6eUs3DRvyuzDIzuR3S3hdMNPtvU5SQ9U8qIlnKiSPXiknsHEqcCaA==", "b7251de3-6952-4ade-b5c9-a450777162e7" });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 11, 15, 48, 53, 465, DateTimeKind.Local).AddTicks(4744));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 23, 15, 48, 53, 465, DateTimeKind.Local).AddTicks(4757));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 22, 15, 48, 53, 465, DateTimeKind.Local).AddTicks(4760));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 18, 15, 48, 53, 465, DateTimeKind.Local).AddTicks(4762));
        }
    }
}
