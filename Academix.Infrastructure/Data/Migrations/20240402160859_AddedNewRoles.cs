using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Academix.Infrastructure.Migrations
{
    public partial class AddedNewRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "64bbe9d2-5b6f-4756-bae2-5d547be808f1", "6bac5b4d-3ad4-492a-9acc-227f8e53591f", "Parent", "PARENT" },
                    { "734c79a7-b6ef-48fa-a187-222cecf646c9", "5a85276d-8f4e-4663-b679-e620bd6a5ea5", "Administrator", "ADMINISTRATOR" },
                    { "bcd3c837-7631-4bff-ab0e-ecb2a374178a", "31428832-bf3e-4136-b628-fc178db00ec7", "Student", "STUDENT" },
                    { "cc3903b4-0314-4f5a-a4d4-494e218d9561", "3197ac81-3f71-45f8-b3bb-c28fb519c60a", "Director", "DIRECTOR" },
                    { "f9161756-7b39-405d-8e58-6929d8b2ffa8", "0035ce09-db7f-4b45-a2a0-5d97c2b0658f", "Teacher", "TEACHER" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "64bbe9d2-5b6f-4756-bae2-5d547be808f1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "734c79a7-b6ef-48fa-a187-222cecf646c9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bcd3c837-7631-4bff-ab0e-ecb2a374178a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc3903b4-0314-4f5a-a4d4-494e218d9561");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f9161756-7b39-405d-8e58-6929d8b2ffa8");
        }
    }
}
