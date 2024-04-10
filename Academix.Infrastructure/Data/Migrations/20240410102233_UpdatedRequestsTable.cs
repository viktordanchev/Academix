using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Academix.Infrastructure.Migrations
{
    public partial class UpdatedRequestsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Requester",
                table: "Requests",
                newName: "Role");

            migrationBuilder.AddColumn<int>(
                name: "ClassId",
                table: "Requests",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RequesterId",
                table: "Requests",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "SchoolId",
                table: "Requests",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "Requests",
                type: "int",
                nullable: true);

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
                column: "ConcurrencyStamp",
                value: "3f3cc866-2f75-4b4f-a5d8-2c1d348f83b1");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Requests_AspNetUsers_RequesterId",
                table: "Requests");

            migrationBuilder.DropIndex(
                name: "IX_Requests_RequesterId",
                table: "Requests");

            migrationBuilder.DropColumn(
                name: "ClassId",
                table: "Requests");

            migrationBuilder.DropColumn(
                name: "RequesterId",
                table: "Requests");

            migrationBuilder.DropColumn(
                name: "SchoolId",
                table: "Requests");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Requests");

            migrationBuilder.RenameColumn(
                name: "Role",
                table: "Requests",
                newName: "Requester");

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 5, 13, 10, 19, 687, DateTimeKind.Local).AddTicks(7396));

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 6, 13, 10, 19, 687, DateTimeKind.Local).AddTicks(7430));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7f92327f-b1c1-4fd0-b837-afc278f256b2",
                column: "ConcurrencyStamp",
                value: "f4356e6a-2419-44c6-b9ea-2ce157b1c487");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a550b411-e5c7-407f-aaba-35161bab127e",
                column: "ConcurrencyStamp",
                value: "677baa7b-0b7b-46c0-993c-6a1a7fe4acea");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e67d14b1-de35-47bd-96ac-a70fcc4c25be",
                column: "ConcurrencyStamp",
                value: "79b43687-fa07-4c64-a2bd-61a44a1fe155");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f67cd347-818b-4c3e-a1ce-ae76e1a2e31b",
                column: "ConcurrencyStamp",
                value: "f798e6db-6f3c-4d54-838e-f06c5c17fc27");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fc1ee3a5-9b29-43ea-b038-2265c1806a75",
                column: "ConcurrencyStamp",
                value: "65097af9-7852-4aeb-b7e5-c8b31fbd8475");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1ae342a8-9fab-4c0a-bd5a-70b351717ecc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b699fbe0-5d0e-4774-95e6-9efe70cd696e", "AQAAAAEAACcQAAAAEOkb1kdZeKq4bdfS8RmV1nXRJyZcQo5MGWUxCptoVnmcSEW9lHC25IYZoEgnDaDBHA==", "6d4cad2b-e753-4737-88a9-29a713675b7b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24a0fdf5-ca4f-4c0f-8120-f6c87448033c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "15ee1966-d00f-4d8e-b121-862d674493d5", "AQAAAAEAACcQAAAAEPS+BFBBWfTVp8J2DSmZS/cIcfjQIa6HM9asS8wlTfmrpiFHm7LotO+WG1pOJq+Ztw==", "9257a7d3-53a9-4225-9bf5-14d2e955d6b4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5093413e-4acb-471a-9ce7-53df30689fc1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "27095658-4de9-4532-a53b-e0c593c4dc13", "AQAAAAEAACcQAAAAEGFaSy64pWb89ceNzeT4QXZy70cV5k9xYbdndJH873xTmS+byTtCpgJtN+Ret3f15g==", "ac51372b-eb8a-484d-80f6-4479b36b111e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6c1ff15b-1853-4d20-98ff-9695affb432c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8646f269-9cc6-4dab-9d85-c1a183c47d65", "AQAAAAEAACcQAAAAEFs/mLv/0rRx70nfqdUKmC0esO0t4nT/vaGDt5NEydSZkvp5vHh6l+xpaQGmiuIr9g==", "2fe74918-e82a-40cf-82f2-cf36b494b1c1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "925da918-5cd0-4b17-9b62-2f417aac0343",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "875d2dbe-352e-45bf-b724-04f6ffea5278", "AQAAAAEAACcQAAAAENiAP362AoBmFmfDO/ByBtMibxxBhUJFn2fNHuZlEQAyE8foeNtv4cl0U4P0cm/evQ==", "2f3b0ace-2ff6-485d-b670-402f381565d7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a171483f-6e48-446a-a5d7-36110d0c1443",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b17ad0a0-d38e-4c45-8bc6-a5d299a56f72", "AQAAAAEAACcQAAAAEHC7cGfhDXfubfu++WFJdfQB7Aa4hxORBwc83lq4b9Jp9nMdEThkl7T7sLhew7hVtA==", "bb81bfbb-fdfa-48ae-8216-30a3e0794e87" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a3717562-385e-41ce-9eff-0f1b994e5548",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1e7fa911-39ac-44cf-bb98-77b8b0fddffb", "AQAAAAEAACcQAAAAED7NWbsSB8ipUqAMrFOtPDbYo13Mb/Hhypac4Nh0OlscKtZDemf0+2cSACk1j+mCgw==", "e69b2717-ac7c-4e65-ad39-b4ac9eb39b7a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2502a25-8341-4e5c-af74-cd0f889ede1b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e3dd3a84-64cd-44ad-9e22-81e8e3026f51", "AQAAAAEAACcQAAAAEAbzCxRusOFXm0bOnPQXZrqWEZpzsfwkeMCmvmloAekB3KRtuzrwPVTTwLIQcFlfkg==", "93225aee-af68-4c75-87a5-f810e498fb0b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bd3e68c0-728b-44a0-ba3a-992d8ae683f9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "acf7de87-44db-45b3-b169-2b6dab63b3db", "AQAAAAEAACcQAAAAENI+MfE1lhwwxAjAXFRzZPbsOtgg2tP/82dOdJrNr1HuygdJXdzZgD0jxkWv/XuLEg==", "76a5984f-a6c4-4ecc-88fe-63da899132b8" });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 5, 13, 10, 19, 698, DateTimeKind.Local).AddTicks(4597));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 17, 13, 10, 19, 698, DateTimeKind.Local).AddTicks(4623));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 16, 13, 10, 19, 698, DateTimeKind.Local).AddTicks(4626));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 12, 13, 10, 19, 698, DateTimeKind.Local).AddTicks(4629));
        }
    }
}
