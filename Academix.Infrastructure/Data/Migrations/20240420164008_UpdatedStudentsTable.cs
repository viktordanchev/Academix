using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Academix.Infrastructure.Migrations
{
    public partial class UpdatedStudentsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberInClass",
                table: "Students");

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 20, 19, 40, 7, 567, DateTimeKind.Local).AddTicks(5529));

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 21, 19, 40, 7, 567, DateTimeKind.Local).AddTicks(5557));

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 22, 19, 40, 7, 567, DateTimeKind.Local).AddTicks(5560));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7f92327f-b1c1-4fd0-b837-afc278f256b2",
                column: "ConcurrencyStamp",
                value: "2fcb0afb-6a6f-412d-8b96-9c05047956c0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a550b411-e5c7-407f-aaba-35161bab127e",
                column: "ConcurrencyStamp",
                value: "bae556a8-7628-4441-8e27-a2355bb46dd3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e67d14b1-de35-47bd-96ac-a70fcc4c25be",
                column: "ConcurrencyStamp",
                value: "3eb6d106-7d9b-40de-a46a-21115f930f6a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f67cd347-818b-4c3e-a1ce-ae76e1a2e31b",
                column: "ConcurrencyStamp",
                value: "b868a331-ed08-4fa2-9013-6bc7ad839438");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fc1ee3a5-9b29-43ea-b038-2265c1806a75",
                column: "ConcurrencyStamp",
                value: "f26d78d0-3d6b-4e2f-af70-17ee7c9f39de");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11f2b8bd-a49a-42cd-b08b-ce067e430965",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "51ed8e6e-fcf3-4074-baf4-f4d010a5048a", "AQAAAAEAACcQAAAAEP1l63fIFiGgspeCarb9e+w0avL1dL8GtZAZoCBzgfEIRqHP6tmuJKdyj+92o/Urlw==", "bae671d2-5132-4b67-9811-25e087405df0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1ae342a8-9fab-4c0a-bd5a-70b351717ecc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3964b921-0a67-43b6-be7c-23b89715e26c", "AQAAAAEAACcQAAAAEJFPnFSnNp9J9iz7Se9HrgmhIrRrs+LCfh6lAwppX6h09FLrTdkFiKDjIFhPeJb7Sw==", "0bf4c30c-c8d4-4fd9-84b4-a8fcfacc3dfa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "214ce248-b8b3-4832-8c3b-7f133e7a429e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fe69d50d-1245-4f19-883e-5b993fbf05e9", "AQAAAAEAACcQAAAAEJhijaD5bfxrFahte3K5nMf/IxN5NXlfphadNHatFClULnbSFL7sArsWl5JO6usa8A==", "43042409-a2ed-40a7-ac05-f22baa3f26a8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24a0fdf5-ca4f-4c0f-8120-f6c87448033c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4aab20c2-3ed8-4048-9d51-c99177c64ec1", "AQAAAAEAACcQAAAAEFOXdOJeLO6pfH4l4xVsZ1e7csiTTBWKB+LET7fSl72lIlZUWOYQZyuf9vm+j+WLQQ==", "90069753-e4f7-44c7-86e7-720004d640b0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5093413e-4acb-471a-9ce7-53df30689fc1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5e6d7c9b-e3ce-455c-bd14-0db1ce2c1f69", "AQAAAAEAACcQAAAAEEkFTMPyaXb/1SOlrblUzBP44BoPvacTrKX+0NivYlqJI0H2Kpn4lVv1AKkT/JKmZQ==", "babe538b-2830-437a-b6ee-61b5c2b3ce5b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6c1ff15b-1853-4d20-98ff-9695affb432c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a5abecfb-13f4-4ba0-8cd9-4b581d775234", "AQAAAAEAACcQAAAAEEkcRzhosanet63yvFoN25wQkJwuV0gyR0skZepCF4DA3ywUqvMkapE+PRohwQKRJg==", "321a1c5d-df09-4e56-a4b7-97848ef9c734" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "925da918-5cd0-4b17-9b62-2f417aac0343",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "32977a62-1459-43c5-a86b-18d2bfd5884f", "AQAAAAEAACcQAAAAEFql6Z7h5fDu7rX8jM9RFKBk/+Z2sQ/tPrClK5agN+M0L92BjkCEHjN+B9fWGS8Bwg==", "63987ea7-6cf7-4fd5-acfc-30ed25f1e0b0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a171483f-6e48-446a-a5d7-36110d0c1443",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "264eb355-0643-4717-aa05-5799025543f2", "AQAAAAEAACcQAAAAEOdKunnrianPFH6vNPU2e0ttkyy3YevvyN1FOg9ACktirGTTiaWly01wWdjQdviFGQ==", "ff6d8d17-1eea-42fb-9957-a3056eaddfae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a3717562-385e-41ce-9eff-0f1b994e5548",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6966b942-3cfb-4ad6-9abe-1704f11f8801", "AQAAAAEAACcQAAAAEOY8vEnH7i2qKX71ZLXuSyADcE7ozLGD3N/YeWUuZlQRq+2G7wJCEgt6Qj9lqQ9ryQ==", "7a0241fc-49e7-46d5-9df2-302d58ce3102" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2502a25-8341-4e5c-af74-cd0f889ede1b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b21a785d-254a-4ec0-bc66-2cef58ca7b92", "AQAAAAEAACcQAAAAEPqCWdawCptCRTnodMPHLcsUDlOLqQuraxQURUalN9NBwductbtk5a1mHOvLkjb9FA==", "8c55f8a9-af9d-4b0c-9aa2-97861498b640" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bd3e68c0-728b-44a0-ba3a-992d8ae683f9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ca2e9d7e-2744-417a-9957-323f28db484d", "AQAAAAEAACcQAAAAEKVATVpFhwqwGTajGTanezHb4h061M2d5PxXAGk7F+pvJsNbTPqNPdpLonBYm4Y4qQ==", "7bc167a9-a713-409a-84d6-105422bd2c55" });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 20, 19, 40, 7, 567, DateTimeKind.Local).AddTicks(6494));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAndTime",
                value: new DateTime(2024, 5, 2, 19, 40, 7, 567, DateTimeKind.Local).AddTicks(6503));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateAndTime",
                value: new DateTime(2024, 5, 1, 19, 40, 7, 567, DateTimeKind.Local).AddTicks(6506));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 27, 19, 40, 7, 567, DateTimeKind.Local).AddTicks(6508));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NumberInClass",
                table: "Students",
                type: "int",
                nullable: true);

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

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 21, 16, 58, 4, 24, DateTimeKind.Local).AddTicks(5357));

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

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "NumberInClass",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "NumberInClass",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                column: "NumberInClass",
                value: 15);
        }
    }
}
