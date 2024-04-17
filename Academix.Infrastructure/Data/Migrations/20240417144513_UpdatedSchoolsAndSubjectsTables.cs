using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Academix.Infrastructure.Migrations
{
    public partial class UpdatedSchoolsAndSubjectsTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SchoolId",
                table: "Subjects",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 17, 17, 45, 12, 300, DateTimeKind.Local).AddTicks(7149));

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 18, 17, 45, 12, 300, DateTimeKind.Local).AddTicks(7180));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7f92327f-b1c1-4fd0-b837-afc278f256b2",
                column: "ConcurrencyStamp",
                value: "f4739c42-f848-466a-a056-569c1926e49f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a550b411-e5c7-407f-aaba-35161bab127e",
                column: "ConcurrencyStamp",
                value: "711fe24d-11c7-4cae-8d85-fddb6cc58599");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e67d14b1-de35-47bd-96ac-a70fcc4c25be",
                column: "ConcurrencyStamp",
                value: "2fda2e9d-c68b-4edf-ac19-597e4dd2e37a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f67cd347-818b-4c3e-a1ce-ae76e1a2e31b",
                column: "ConcurrencyStamp",
                value: "6bf4d8d8-7375-4dd2-a33d-93a65815f9db");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fc1ee3a5-9b29-43ea-b038-2265c1806a75",
                column: "ConcurrencyStamp",
                value: "32feea21-b50d-4c50-8d25-1818e98741c7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11f2b8bd-a49a-42cd-b08b-ce067e430965",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6b01e6e8-18c3-4130-8cc4-8de5de6b678b", "AQAAAAEAACcQAAAAEF+e9dz2/3giwy0zeCYruVnOqGJXhepnC4uwzW3EHnJZtESyJOsuR6fsQ6uglDo9mQ==", "ba3c4383-0601-47d0-a96b-c1253e9b610a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1ae342a8-9fab-4c0a-bd5a-70b351717ecc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ae194f5c-801e-481a-91ca-10abcad2df0f", "AQAAAAEAACcQAAAAEGnqLRCa+fQuuBRHHZflIxXk17XHOjgTLL25IsZ3pBL5NO/j1x6uFzDJ+goIQrtj2Q==", "668f31e9-15d5-4695-9945-3e41f811b0b1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24a0fdf5-ca4f-4c0f-8120-f6c87448033c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7a5369d1-a58f-4d1b-af72-dda7c59ee488", "AQAAAAEAACcQAAAAENtbhkKUhPZXo3DxSfVkLJtE6cvI7MdIW4WgQWYVT+2/yb0TflPrdcidWLdAHlGk0Q==", "1785c8ea-5daf-4109-b653-9e8a372ad8ec" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5093413e-4acb-471a-9ce7-53df30689fc1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "765843f1-4ce2-4e10-9547-6f127d17a907", "AQAAAAEAACcQAAAAEDgHjPEbw1OnsFa/MrHNFuaaVogeFSYfPqHGKyE59Zw28Zf9H61bxt9cfePbFTejcw==", "fb21c28d-5a59-4c8b-bcb4-15514d6a2d3a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6c1ff15b-1853-4d20-98ff-9695affb432c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d813ca6b-e6e1-40ea-a594-761f4f94f13c", "AQAAAAEAACcQAAAAEH0faus/2Aqilw9HNmeD3k8F7QqQ4kN7p82m0Qu7f+v76Jk/iuTXCBfdjLJ5OoazSA==", "2847a45d-fa2f-462f-84f7-9b75d68aa824" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "925da918-5cd0-4b17-9b62-2f417aac0343",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a5820220-7b97-441c-8184-8dca6c6ac253", "AQAAAAEAACcQAAAAEDcKFeWXI11kzBZ3A/HFYvY7atTWCWHbgWdCFzXrE+nlQNnM6a2ilieIFBHxg6XMKQ==", "a76501f2-f2b9-42fa-a71d-1183b9edad24" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a171483f-6e48-446a-a5d7-36110d0c1443",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "26d3c48e-e7ba-4a3a-9c91-64af30946e68", "AQAAAAEAACcQAAAAEBx7JF5AtREHbIopHO9kFJo94uDAcq4pd6ZsnjeEnR7dv69hGMhBHlUO5UvwBCEAig==", "c55c9d37-d610-466f-8424-0a77c66523d8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a3717562-385e-41ce-9eff-0f1b994e5548",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d59eae6f-e177-4794-a27c-88a406697068", "AQAAAAEAACcQAAAAECc4ArP6zeD3Lmk0jEEJNBljzxxNh9jZYPVJyQHMX1I2wYlJ42CcQSD6EBnXo3NEPQ==", "8666f921-a1c9-413c-ae6d-5f104183d733" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2502a25-8341-4e5c-af74-cd0f889ede1b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5f0664cb-bb96-4a4b-9cec-69a1bc11094a", "AQAAAAEAACcQAAAAELx49A/hD9ThcKIXTxsmz7rcAzbRZFg/tu/EE7D2U0dtUEZjOw4s5C5+R7rOr867sA==", "337a579c-5824-4396-b950-a5086055163f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bd3e68c0-728b-44a0-ba3a-992d8ae683f9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cc4ddd92-8881-41d0-982c-777fa24c3640", "AQAAAAEAACcQAAAAEBr4z6vRW3tzZ5pi7Cu9JZRcfpeQDrWvbXJKOf0pG/n1EE8FAZAhVRGi6+bCQrLB7w==", "dce40056-5d31-4c54-a1f5-b0b2573dd735" });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 17, 17, 45, 12, 313, DateTimeKind.Local).AddTicks(4976));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 29, 17, 45, 12, 313, DateTimeKind.Local).AddTicks(5013));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 28, 17, 45, 12, 313, DateTimeKind.Local).AddTicks(5017));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 24, 17, 45, 12, 313, DateTimeKind.Local).AddTicks(5021));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1,
                column: "SchoolId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2,
                column: "SchoolId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3,
                column: "SchoolId",
                value: 1);

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_SchoolId",
                table: "Subjects",
                column: "SchoolId");

            migrationBuilder.AddForeignKey(
                name: "FK_Subjects_Schools_SchoolId",
                table: "Subjects",
                column: "SchoolId",
                principalTable: "Schools",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Subjects_Schools_SchoolId",
                table: "Subjects");

            migrationBuilder.DropIndex(
                name: "IX_Subjects_SchoolId",
                table: "Subjects");

            migrationBuilder.DropColumn(
                name: "SchoolId",
                table: "Subjects");

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 16, 17, 54, 13, 264, DateTimeKind.Local).AddTicks(3349));

            migrationBuilder.UpdateData(
                table: "Absences",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 17, 17, 54, 13, 264, DateTimeKind.Local).AddTicks(3378));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7f92327f-b1c1-4fd0-b837-afc278f256b2",
                column: "ConcurrencyStamp",
                value: "1650b990-11e4-468b-90c5-a3e366e240cf");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a550b411-e5c7-407f-aaba-35161bab127e",
                column: "ConcurrencyStamp",
                value: "02f79085-5f74-4da2-acf8-815ed155d08a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e67d14b1-de35-47bd-96ac-a70fcc4c25be",
                column: "ConcurrencyStamp",
                value: "722287ff-22c6-4050-bc57-f04cc21c5623");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f67cd347-818b-4c3e-a1ce-ae76e1a2e31b",
                column: "ConcurrencyStamp",
                value: "93bbec29-e56d-40ad-81bf-ddfb20dae8cc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fc1ee3a5-9b29-43ea-b038-2265c1806a75",
                column: "ConcurrencyStamp",
                value: "c0fc1df2-4595-4f88-ad0a-a0cac866e76a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11f2b8bd-a49a-42cd-b08b-ce067e430965",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a8f951ce-632e-445f-b1bf-6b7b282d34b1", "AQAAAAEAACcQAAAAENdMgs6CtL0U0bflxlMESFCmwqWcSzihv3iIWEfZLxhQB6tngNZA15pGizwuUtnvKg==", "6c06c4a4-3c20-4d4d-9424-abba4b0011ea" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1ae342a8-9fab-4c0a-bd5a-70b351717ecc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3a0cd09f-6b58-44a0-a707-042c035d03a8", "AQAAAAEAACcQAAAAEONTKTT2SDEeAQzXLmZQqlMGjqQa4nsXza8SxThCmpWADol2I0FDMh6YCK6Z/5yL1g==", "13e0d628-c2fa-49d8-abd6-6050969e8898" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24a0fdf5-ca4f-4c0f-8120-f6c87448033c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "51671e56-4e71-4475-a99b-b6c05840ae01", "AQAAAAEAACcQAAAAEElNdIEzcASLXuU4HCKTw/jf97nR0D/KK0bBH7ErMEFv9DNICE+1llxd5qreAbRTQg==", "58878b4c-6b1d-4a7e-84b9-d4c97466123d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5093413e-4acb-471a-9ce7-53df30689fc1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8ef7f28f-addf-4d61-ac7e-22d98bd3f58f", "AQAAAAEAACcQAAAAEMG08pd3SJbxBRq2ZpMx/ZCBQmSxZSQmzf3CSj8JnPfF+vmCeLt/FxVHEaFfGdcEjw==", "8637e8ad-448d-4385-9952-27136e0a0f52" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6c1ff15b-1853-4d20-98ff-9695affb432c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fd730eef-af91-4e21-ba9b-b08790ce6cf5", "AQAAAAEAACcQAAAAEMdQgYPz3X1cIhTOw8nG0ngLrhggN3Qs2D8Ss/WWWNDya4cIkTtn+im8K/T5I7uyPw==", "436bcb18-4054-4448-9c1e-79d227a6bb06" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "925da918-5cd0-4b17-9b62-2f417aac0343",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0ad1ee5f-353d-4f4b-bfb1-e2c62cde170a", "AQAAAAEAACcQAAAAEHcn0H5vDTJzEGNWhFPj6YuqXGG8nUUyOuvfgtVJkAipXAh/HEx5G8qj7PTiuMNJsA==", "420144a6-c6d8-4374-821e-74c6edbcf849" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a171483f-6e48-446a-a5d7-36110d0c1443",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ad9a8b72-9b8a-46c7-afea-6ed60e5f0f40", "AQAAAAEAACcQAAAAEJSu5RTM6DSxHGwMW1mIjs3yvApyGoaBT8PNWqsC/9MvoT0lYTvq5iKjfwr716vwdQ==", "f9d28f2d-7df1-4551-b1b8-46e2abc5016c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a3717562-385e-41ce-9eff-0f1b994e5548",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4052ce28-d759-49df-972d-c66eb526f133", "AQAAAAEAACcQAAAAEKXoCJNdSYhR1sZxqxfMwldTGtSsCXU41gcibWBAD/yrLc35k8w8Vk4x2fMeeNN9mQ==", "5e805337-15e9-4fb4-be66-926dc63d6b19" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2502a25-8341-4e5c-af74-cd0f889ede1b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4aa26d53-1f56-42c4-af4b-c033c5a47fbd", "AQAAAAEAACcQAAAAEBorHAdCtDdvrynBe6wmgxs4AfgU7brcL5VCct94pAMKBencD6YNvJV1cQfR8BJGLg==", "3162e621-2d61-4f58-81b1-acab9f1b9dfc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bd3e68c0-728b-44a0-ba3a-992d8ae683f9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8def38bf-44a0-4fea-8f2c-0ecb3b79d1ef", "AQAAAAEAACcQAAAAEPOR5v9Qp0ngfnkUmFW1rBSXLMmRH2Xzjjg3yU2X8OjdyQQjBshIzpVcbYy04IwtWg==", "52d38a3c-0b6e-46fe-9d3d-3373a3db095d" });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 16, 17, 54, 13, 275, DateTimeKind.Local).AddTicks(7893));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 28, 17, 54, 13, 275, DateTimeKind.Local).AddTicks(7926));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 27, 17, 54, 13, 275, DateTimeKind.Local).AddTicks(7928));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateAndTime",
                value: new DateTime(2024, 4, 23, 17, 54, 13, 275, DateTimeKind.Local).AddTicks(7931));
        }
    }
}
