using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Academix.Infrastructure.Migrations
{
    public partial class AddedNewTableAdminsAndUpdatedRequestsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Requests_AspNetUsers_RequesterId",
                table: "Requests");

            migrationBuilder.DropForeignKey(
                name: "FK_Requests_Directors_DirectorId",
                table: "Requests");

            migrationBuilder.DropIndex(
                name: "IX_Requests_RequesterId",
                table: "Requests");

            migrationBuilder.AlterColumn<int>(
                name: "DirectorId",
                table: "Requests",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "AdminId",
                table: "Requests",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminIdentityId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Admins_AspNetUsers_AdminIdentityId",
                        column: x => x.AdminIdentityId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                columns: new[] { "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "db46a76a-4ea1-4528-ac5e-0ac2e73a0285", "Admin", "ADMIN" });

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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "11f2b8bd-a49a-42cd-b08b-ce067e430965", 0, "81dad689-9475-40d7-ab7f-3457316e1f16", "admin@mail.com", false, "admin", "Admin", false, null, "ADMIN@MAIL.COM", "ADMIN@MAIL.COM", "AQAAAAEAACcQAAAAEP4LkyzfkIVaIiOsZqYYYXmVIgW1KUGw1UOerOswgOyIDUAUoatPvPCMW+BXilq4Eg==", null, false, "a0bae927-e5f3-401f-8d4e-094c9c1f0ae5", false, "admin@mail.com" });

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

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "AdminIdentityId" },
                values: new object[] { 1, "11f2b8bd-a49a-42cd-b08b-ce067e430965" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "7f92327f-b1c1-4fd0-b837-afc278f256b2", "11f2b8bd-a49a-42cd-b08b-ce067e430965" });

            migrationBuilder.CreateIndex(
                name: "IX_Requests_AdminId",
                table: "Requests",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_RequesterId",
                table: "Requests",
                column: "RequesterId");

            migrationBuilder.CreateIndex(
                name: "IX_Admins_AdminIdentityId",
                table: "Admins",
                column: "AdminIdentityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Requests_Admins_AdminId",
                table: "Requests",
                column: "AdminId",
                principalTable: "Admins",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Requests_AspNetUsers_RequesterId",
                table: "Requests",
                column: "RequesterId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Requests_Directors_DirectorId",
                table: "Requests",
                column: "DirectorId",
                principalTable: "Directors",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Requests_Admins_AdminId",
                table: "Requests");

            migrationBuilder.DropForeignKey(
                name: "FK_Requests_AspNetUsers_RequesterId",
                table: "Requests");

            migrationBuilder.DropForeignKey(
                name: "FK_Requests_Directors_DirectorId",
                table: "Requests");

            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropIndex(
                name: "IX_Requests_AdminId",
                table: "Requests");

            migrationBuilder.DropIndex(
                name: "IX_Requests_RequesterId",
                table: "Requests");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7f92327f-b1c1-4fd0-b837-afc278f256b2", "11f2b8bd-a49a-42cd-b08b-ce067e430965" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11f2b8bd-a49a-42cd-b08b-ce067e430965");

            migrationBuilder.DropColumn(
                name: "AdminId",
                table: "Requests");

            migrationBuilder.AlterColumn<int>(
                name: "DirectorId",
                table: "Requests",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 10, 13, 22, 32, 691, DateTimeKind.Local).AddTicks(8912));

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 11, 13, 22, 32, 691, DateTimeKind.Local).AddTicks(8946));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7f92327f-b1c1-4fd0-b837-afc278f256b2",
                columns: new[] { "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3f3cc866-2f75-4b4f-a5d8-2c1d348f83b1", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a550b411-e5c7-407f-aaba-35161bab127e",
                column: "ConcurrencyStamp",
                value: "18f86ba0-8f60-490b-83f5-ab97eb370ed3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e67d14b1-de35-47bd-96ac-a70fcc4c25be",
                column: "ConcurrencyStamp",
                value: "30824498-22dc-42db-8962-6a69dc43c296");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f67cd347-818b-4c3e-a1ce-ae76e1a2e31b",
                column: "ConcurrencyStamp",
                value: "ee077e51-3cda-41d9-8eb8-eef30cb74d02");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fc1ee3a5-9b29-43ea-b038-2265c1806a75",
                column: "ConcurrencyStamp",
                value: "b9281978-3825-4943-95b7-bca0ab8511ee");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1ae342a8-9fab-4c0a-bd5a-70b351717ecc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "db35c47d-33cd-4fcd-9a17-e40dd8d30348", "AQAAAAEAACcQAAAAEK2smOh4h1P3kkAuMHdfrgCP6gODA3M/6weZbfFZFqGJ/u3Pg301fU9ObiEgNRVhWQ==", "9b8d6a8c-702c-40dd-99dc-d0be7487e3a3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24a0fdf5-ca4f-4c0f-8120-f6c87448033c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9a7964da-e076-4649-b024-f316d3779d2b", "AQAAAAEAACcQAAAAEO+75CGMmcBZt3i4H0rShnRSwN8aQJv6/Q6ai4wKmzFDX2JVNbGDst/5Z3AhLuBYjg==", "71e6d333-1c34-4368-a73e-fea5b8d91b87" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5093413e-4acb-471a-9ce7-53df30689fc1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0f50190c-49e8-4b7f-8fb5-fa7fa9fa3849", "AQAAAAEAACcQAAAAEI/D2Rf7gAU6nxSkqs5c/b69E7WmcV3TKyXBRmrV00Culu5ptSw7ko+QPO7C2H/7jA==", "10480288-0e21-4fc1-9250-b1d5567ef73f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6c1ff15b-1853-4d20-98ff-9695affb432c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6818d693-cb73-4429-b0ff-dab93a0221d6", "AQAAAAEAACcQAAAAEKjMNAG784ACWBWGko7/1Xcb1qzgT6ZgIVDWy1Df90Gp6PoW+OdbvEPNreoi5+ipzg==", "d4534f37-7ab5-4bf9-87a9-05261fdfe33f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "925da918-5cd0-4b17-9b62-2f417aac0343",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "192181ca-3adb-4bed-ae19-98874b06b70c", "AQAAAAEAACcQAAAAEOXYNGHdQXbxV9sFw6zHQsjdd5UFu10+3dk/lK+2vMtdtdaRjKoeENzm/vRkHHgKeg==", "577b278d-8fb5-4a47-95b0-8a1ae45b3ac5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a171483f-6e48-446a-a5d7-36110d0c1443",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b89d212b-e2e3-4cb2-830d-564ad3ccc394", "AQAAAAEAACcQAAAAED6ooP/fX1GXzje6sgDiPD8gqflJKldHqcv++pQ6WuDL/x1MUfhsVq6hiFVb7vDrcw==", "7a0af354-8878-4427-b46d-be82410dd569" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a3717562-385e-41ce-9eff-0f1b994e5548",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "be269961-380f-438b-add4-81cfff1711ad", "AQAAAAEAACcQAAAAEK+B6xeE7RIk5N9eYnDmM4W7sDx0KGInENBq0pV+ehJATkcclIV75c5OiUgHEivsvA==", "2f0fd0cb-ea70-4a20-8169-66cf40805d2f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2502a25-8341-4e5c-af74-cd0f889ede1b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8af6b7c8-0681-4d29-8b00-9b8d413ed65b", "AQAAAAEAACcQAAAAECLlkOW0GuWdYQtEsSIdDYE6DNM5zZbebMBSAw5LJ+t85r1bqVPw1uQQZk/2es8RPw==", "d34f1ab4-08b9-4443-9e09-ec98a3a2962d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bd3e68c0-728b-44a0-ba3a-992d8ae683f9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ef111e6d-02cd-4bf4-a14a-1b58bb4b11ff", "AQAAAAEAACcQAAAAELooAbXVMQcNa12cesd/qorAMxLMEwKZxZSOxW0WeqqyHHFGC+dXW2jDoQZNdsSr7w==", "53928e03-abe1-49ed-9194-f926ce9c9d36" });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 10, 13, 22, 32, 702, DateTimeKind.Local).AddTicks(6491));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 22, 13, 22, 32, 702, DateTimeKind.Local).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 21, 13, 22, 32, 702, DateTimeKind.Local).AddTicks(6520));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 17, 13, 22, 32, 702, DateTimeKind.Local).AddTicks(6523));

            migrationBuilder.CreateIndex(
                name: "IX_Requests_RequesterId",
                table: "Requests",
                column: "RequesterId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Requests_AspNetUsers_RequesterId",
                table: "Requests",
                column: "RequesterId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Requests_Directors_DirectorId",
                table: "Requests",
                column: "DirectorId",
                principalTable: "Directors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
