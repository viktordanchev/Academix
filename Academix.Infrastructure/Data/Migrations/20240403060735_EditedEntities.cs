using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Academix.Infrastructure.Migrations
{
    public partial class EditedEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Classes_Teachers_ClassTeacherId",
                table: "Classes");

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

            migrationBuilder.AlterColumn<int>(
                name: "ParentId",
                table: "Students",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ClassTeacherId",
                table: "Classes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0d528e32-834b-4a2c-8c30-45f02bc50e66", "4ceb1fbc-503b-4ca1-8333-81299b2fa748", "Director", "DIRECTOR" },
                    { "7e07ae4e-1b0e-44ef-953e-6edc4199f885", "0c8c51b1-d760-4810-a7f6-6d09677d9b32", "Administrator", "ADMINISTRATOR" },
                    { "8679f400-9b07-4081-9c01-6fdfa9109514", "fa62b6ea-cc0b-41f1-be54-98009b2500e8", "Parent", "PARENT" },
                    { "dba6d188-6dec-4d5c-a66f-2b4f63af5633", "1bf73414-db50-4154-8150-b67cdbf86d4e", "Teacher", "TEACHER" },
                    { "e9a8e131-c448-47b7-9a1c-1427fdcf8450", "5aa66b68-91dc-4a56-bf22-3698412e4b8e", "Student", "STUDENT" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Classes_Teachers_ClassTeacherId",
                table: "Classes",
                column: "ClassTeacherId",
                principalTable: "Teachers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Classes_Teachers_ClassTeacherId",
                table: "Classes");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0d528e32-834b-4a2c-8c30-45f02bc50e66");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7e07ae4e-1b0e-44ef-953e-6edc4199f885");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8679f400-9b07-4081-9c01-6fdfa9109514");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dba6d188-6dec-4d5c-a66f-2b4f63af5633");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e9a8e131-c448-47b7-9a1c-1427fdcf8450");

            migrationBuilder.AlterColumn<int>(
                name: "ParentId",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ClassTeacherId",
                table: "Classes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Classes_Teachers_ClassTeacherId",
                table: "Classes",
                column: "ClassTeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
