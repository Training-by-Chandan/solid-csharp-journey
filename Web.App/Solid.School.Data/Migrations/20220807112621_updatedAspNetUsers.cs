using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Solid.School.Data.Migrations
{
    public partial class updatedAspNetUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "826d6171-a044-4f4c-b0b6-2979e0bb53ad");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "95119256-753e-4d5c-a1bf-b307200b64b4");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ProfilePic",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "IdentityUser",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityUser", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "IdentityUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "826d6171-a044-4f4c-b0b6-2979e0bb53ad", 0, "826d6171-a044-4f4c-b0b6-2979e0bb53af", "admin@admin.com", true, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEAD69QpBo2XlGRn7hQC4+yhe6IMXlgYR3AGFDdiEBJ60V3Jo0nMahIvnBMcDDAEuyg==", "1234567890", true, "826d6171-a044-4f4c-b0b6-2979e0bb53ae", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "IdentityUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "95119256-753e-4d5c-a1bf-b307200b64b4", 0, "95119256-753e-4d5c-a1bf-b307200b64b6", "employee@employee.com", true, false, null, "EMPLOYEE@EMPLOYEE.COM", "EMPLOYEE@EMPLOYEE.COM", "AQAAAAEAACcQAAAAELIg0e0sCUHiXixtfGL6hyJykkVcXt9eXwUp7uTv89FAyvZm+GuZiG6ESWu31xL8dg==", "1234567890", true, "95119256-753e-4d5c-a1bf-b307200b64b5", false, "employee@employee.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IdentityUser");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ProfilePic",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "826d6171-a044-4f4c-b0b6-2979e0bb53ad", 0, "826d6171-a044-4f4c-b0b6-2979e0bb53af", "admin@admin.com", true, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEIUBTAuh8ZfasAevgSwHoBtE3qcXAV1kLcKDQ3k16CBLfXPzOnbhyCAXlIqzFBnzHg==", "1234567890", true, "826d6171-a044-4f4c-b0b6-2979e0bb53ae", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "95119256-753e-4d5c-a1bf-b307200b64b4", 0, "95119256-753e-4d5c-a1bf-b307200b64b6", "employee@employee.com", true, false, null, "EMPLOYEE@EMPLOYEE.COM", "EMPLOYEE@EMPLOYEE.COM", "AQAAAAEAACcQAAAAEAX0x8BHfsBXxqihbW9Rd6LCVUVMBe3OGOR/LABUHW4EmCCDHSexJRtY+jG+obxJig==", "1234567890", true, "95119256-753e-4d5c-a1bf-b307200b64b5", false, "employee@employee.com" });
        }
    }
}
