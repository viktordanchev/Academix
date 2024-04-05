using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Academix.Infrastructure.Migrations
{
    public partial class UpdatedRoleIdsAndSeededData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "09c1b655-b41f-400b-88e8-e37dd750139b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4ca64b77-c44b-43df-b10d-ba1ebd683338");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf188ced-d78b-4440-9478-32929b1d9e76");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c573c7de-3275-4763-88db-c4512a1a97a5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e611f650-3ed8-4a40-995d-d7ab09d94eb1");

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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7f92327f-b1c1-4fd0-b837-afc278f256b2", "f4356e6a-2419-44c6-b9ea-2ce157b1c487", "Administrator", "ADMINISTRATOR" },
                    { "a550b411-e5c7-407f-aaba-35161bab127e", "677baa7b-0b7b-46c0-993c-6a1a7fe4acea", "Director", "DIRECTOR" },
                    { "e67d14b1-de35-47bd-96ac-a70fcc4c25be", "79b43687-fa07-4c64-a2bd-61a44a1fe155", "Student", "STUDENT" },
                    { "f67cd347-818b-4c3e-a1ce-ae76e1a2e31b", "f798e6db-6f3c-4d54-838e-f06c5c17fc27", "Teacher", "TEACHER" },
                    { "fc1ee3a5-9b29-43ea-b038-2265c1806a75", "65097af9-7852-4aeb-b7e5-c8b31fbd8475", "Parent", "PARENT" }
                });

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

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7f92327f-b1c1-4fd0-b837-afc278f256b2");

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

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 5, 11, 8, 36, 66, DateTimeKind.Local).AddTicks(5675));

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 6, 11, 8, 36, 66, DateTimeKind.Local).AddTicks(5703));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "09c1b655-b41f-400b-88e8-e37dd750139b", "568adc47-fe7d-46ea-bb26-34b105840e47", "Administrator", "ADMINISTRATOR" },
                    { "4ca64b77-c44b-43df-b10d-ba1ebd683338", "389dd8fb-dc9f-4811-bb36-01dc35395403", "Parent", "PARENT" },
                    { "bf188ced-d78b-4440-9478-32929b1d9e76", "e605b746-b4f2-4b13-825a-938def4f717f", "Teacher", "TEACHER" },
                    { "c573c7de-3275-4763-88db-c4512a1a97a5", "0466af58-79d9-4890-8540-0b719ff03b95", "Student", "STUDENT" },
                    { "e611f650-3ed8-4a40-995d-d7ab09d94eb1", "c801e625-6939-4469-ab56-a38ead851f9b", "Director", "DIRECTOR" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1ae342a8-9fab-4c0a-bd5a-70b351717ecc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c51ea7d7-b317-413c-b0d0-39ec0004d395", "AQAAAAEAACcQAAAAEOpnClYm/COxrjNaBG7I8GbMfyuDM16G9bzyXVv64gMpVHfxSmdQJS8Qp016laibHQ==", "4cb8efbf-d981-4003-930f-22d4cadd6f73" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24a0fdf5-ca4f-4c0f-8120-f6c87448033c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e7e33dbb-e8d8-4570-b177-9eb0011ad7b5", "AQAAAAEAACcQAAAAECZNMRU+2iyaVUAsRq5+vLn0di5kPzcrVyTlUSYpouqv2qZ7mCflkK/pgFyI83x0VQ==", "d8e35936-abf9-40b2-8885-22f1f413688c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5093413e-4acb-471a-9ce7-53df30689fc1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b2ad440a-9d16-43c3-8bc0-b99c12d983cc", "AQAAAAEAACcQAAAAELeCCumUESONuYFjDD2ujbgXkMGMf42XSzeOq88owbpAJTqLFsvG4jsyW1Uvu4OlPA==", "3bde6a3e-49ae-4f86-8d59-4587f7dc3d6e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6c1ff15b-1853-4d20-98ff-9695affb432c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c1fd0a59-4173-491b-9a36-ce8556893550", "AQAAAAEAACcQAAAAEMcrwvvPTh40KRco43qcWM+NbClnwNl4Sc7GyXXWFbxJr3YRdfSNqEh/FG0Fip5YFQ==", "31cd553e-3794-4f86-bf19-ed55a2b01fa2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "925da918-5cd0-4b17-9b62-2f417aac0343",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dafbd786-3543-4af6-8b78-b411fc936f6a", "AQAAAAEAACcQAAAAEEz0ionNz+XGRjuRuWokOGS05hIS4ZTOerLT2UawF8GkZ5tNIVYB/CqaoyHbTCE7dQ==", "4cd199f5-a478-4cb4-86ec-0b0353fd5ce4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a171483f-6e48-446a-a5d7-36110d0c1443",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2cc121fc-a164-4d80-a2f8-421e1bc52080", "AQAAAAEAACcQAAAAECPS/8ynviDzapQz2ii3vKLa/mMW1MQo9cJ3N10NmyCMEJ3lrU4+Vjp1mJ6Tej8c3w==", "0bdaedfe-f9bc-41fd-b6ac-5ee32e6b59df" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a3717562-385e-41ce-9eff-0f1b994e5548",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b98b6e8b-465e-4288-b31d-0402753470b4", "AQAAAAEAACcQAAAAEFukynf5C6iyUEFwNzTPfOgPZ5XO1/i11hqtDt5CHgq6nitKZeTfI9p8n8WukLdP4Q==", "fcbd5c6c-ad9a-4a3f-ae6d-e341a7f179a7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2502a25-8341-4e5c-af74-cd0f889ede1b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "08b46611-5166-4cf8-8553-3663acfa7293", "AQAAAAEAACcQAAAAEFbDd4GKe9LrpEnat0zsERKowxOWymg4bhf5OT9kD6k1PvT9mTPMaAE7JeBWZHGQ5w==", "1d957e96-d4d9-4539-815b-68c8606ca5a3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bd3e68c0-728b-44a0-ba3a-992d8ae683f9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6cf6cd2d-a982-46a3-bd6a-48f5846b7ec5", "AQAAAAEAACcQAAAAEPjwb8BvsxVdsLznDEDfsaljc6WVISuWWozAalABJpZWmlBb1fnLmw6Zvrk+/VJ6zA==", "8c8f0f6f-6b22-45b4-ad01-cf850a6ef82a" });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 5, 11, 8, 36, 77, DateTimeKind.Local).AddTicks(4999));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 17, 11, 8, 36, 77, DateTimeKind.Local).AddTicks(5025));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 16, 11, 8, 36, 77, DateTimeKind.Local).AddTicks(5028));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 12, 11, 8, 36, 77, DateTimeKind.Local).AddTicks(5030));
        }
    }
}
