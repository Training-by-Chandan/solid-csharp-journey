using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Solid.School.Data.Migrations
{
    public partial class seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "826d6171-a044-4f4c-b0b6-2979e0bb53ad",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEMlsLdHWP6rYmG59xYWpLMdFpLFGROjvfnfLg9buEDiCVxhN6UUfNFA4ju7p1x4A2g==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "95119256-753e-4d5c-a1bf-b307200b64b4",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAECHc6HzkZILR7eaq2/ufRzbmqKRFIU9G9+essTPVX2xhpq/+uU6oXPA+lKlmHiJabA==");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "826d6171-a044-4f4c-b0b6-2979e0bb53ad",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEDjSGIoN7urELbf3d4CVaOQHTV4RSjq9m8bxiOg4hfTkuzrVAr+FriFUqFWUIJLaZg==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "95119256-753e-4d5c-a1bf-b307200b64b4",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEIbPLFHC3zc967CKtczRZeOsERM9quIL4fC9+8WTKT2HUOLrwPXXGNxGZikdn6QpmQ==");
        }
    }
}
