using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Solid.School.Data.Migrations
{
    public partial class seedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "19fc5d8f-709f-43bb-99f4-4302e6493ed5", "19fc5d8f-709f-43bb-99f4-4302e6493ed5", "Employee", "EMPLOYEE" },
                    { "721841da-b446-45e1-988c-29234d26e562", "721841da-b446-45e1-988c-29234d26e562", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "826d6171-a044-4f4c-b0b6-2979e0bb53ad", 0, "826d6171-a044-4f4c-b0b6-2979e0bb53af", "admin@admin.com", true, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEIUBTAuh8ZfasAevgSwHoBtE3qcXAV1kLcKDQ3k16CBLfXPzOnbhyCAXlIqzFBnzHg==", "1234567890", true, "826d6171-a044-4f4c-b0b6-2979e0bb53ae", false, "admin@admin.com" },
                    { "95119256-753e-4d5c-a1bf-b307200b64b4", 0, "95119256-753e-4d5c-a1bf-b307200b64b6", "employee@employee.com", true, false, null, "EMPLOYEE@EMPLOYEE.COM", "EMPLOYEE@EMPLOYEE.COM", "AQAAAAEAACcQAAAAEAX0x8BHfsBXxqihbW9Rd6LCVUVMBe3OGOR/LABUHW4EmCCDHSexJRtY+jG+obxJig==", "1234567890", true, "95119256-753e-4d5c-a1bf-b307200b64b5", false, "employee@employee.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "721841da-b446-45e1-988c-29234d26e562", "826d6171-a044-4f4c-b0b6-2979e0bb53ad" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "19fc5d8f-709f-43bb-99f4-4302e6493ed5", "95119256-753e-4d5c-a1bf-b307200b64b4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "721841da-b446-45e1-988c-29234d26e562", "826d6171-a044-4f4c-b0b6-2979e0bb53ad" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "19fc5d8f-709f-43bb-99f4-4302e6493ed5", "95119256-753e-4d5c-a1bf-b307200b64b4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "19fc5d8f-709f-43bb-99f4-4302e6493ed5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "721841da-b446-45e1-988c-29234d26e562");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "826d6171-a044-4f4c-b0b6-2979e0bb53ad");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "95119256-753e-4d5c-a1bf-b307200b64b4");
        }
    }
}
