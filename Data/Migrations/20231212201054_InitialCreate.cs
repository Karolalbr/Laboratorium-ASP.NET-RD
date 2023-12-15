using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "40358116-35e4-41f0-9e78-e31cf01c3f8e", "76ac3c01-4d87-4e27-90bd-95121a486672" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "54f2034f-b5e7-4550-9232-5797c26f640d", "8fedb26e-1551-41f7-8750-780f01bbf43e" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "40358116-35e4-41f0-9e78-e31cf01c3f8e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "54f2034f-b5e7-4550-9232-5797c26f640d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "76ac3c01-4d87-4e27-90bd-95121a486672");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8fedb26e-1551-41f7-8750-780f01bbf43e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1889c695-24cf-43e7-b2c9-e66004ccbe15", "1889c695-24cf-43e7-b2c9-e66004ccbe15", "admin", "ADMIN" },
                    { "298cd350-f038-4553-8f80-7fc672ad4998", "298cd350-f038-4553-8f80-7fc672ad4998", "user", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "15b4dce2-37c4-4f1b-b3ed-7e5eb75fc31c", 0, "fa1413e5-1332-4666-be64-67d05690f5f1", "adam@wsei.edu.pl", true, false, null, "ADAM@WSEI.EDU>PL", "ADAM", "AQAAAAEAACcQAAAAEAt55xe1RcaeIFbSemP6OS85qns84Z/2/G95mTK0Th1d1gL9Wz9b5qT0e5Ya8r0p8g==", null, false, "1145270e-eb28-47da-9303-f076c813b6e0", false, "adam" },
                    { "1fcce0e5-0678-4756-a427-a6031a012327", 0, "8dcffe5a-9db2-4608-b5e3-6dc231b7b940", "marcin@wsei.edu.pl", true, false, null, "MARCIN@WSEI.EDU>PL", "MARCIN", "AQAAAAEAACcQAAAAEBtxIIq0ENoauj6ZV3Pvh8x8eRvzUB39w6N1NpwcA1spMz+ny83U4nUVaFsPQGVwdA==", null, false, "01cf231b-00a3-4f18-9eaf-370c93d02008", false, "marcin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "1889c695-24cf-43e7-b2c9-e66004ccbe15", "15b4dce2-37c4-4f1b-b3ed-7e5eb75fc31c" },
                    { "298cd350-f038-4553-8f80-7fc672ad4998", "1fcce0e5-0678-4756-a427-a6031a012327" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1889c695-24cf-43e7-b2c9-e66004ccbe15", "15b4dce2-37c4-4f1b-b3ed-7e5eb75fc31c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "298cd350-f038-4553-8f80-7fc672ad4998", "1fcce0e5-0678-4756-a427-a6031a012327" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1889c695-24cf-43e7-b2c9-e66004ccbe15");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "298cd350-f038-4553-8f80-7fc672ad4998");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15b4dce2-37c4-4f1b-b3ed-7e5eb75fc31c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1fcce0e5-0678-4756-a427-a6031a012327");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "40358116-35e4-41f0-9e78-e31cf01c3f8e", "40358116-35e4-41f0-9e78-e31cf01c3f8e", "admin", "ADMIN" },
                    { "54f2034f-b5e7-4550-9232-5797c26f640d", "54f2034f-b5e7-4550-9232-5797c26f640d", "user", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "76ac3c01-4d87-4e27-90bd-95121a486672", 0, "55135d5b-4ed4-4531-85bd-4c4aef009875", "adam@wsei.edu.pl", true, false, null, "ADAM@WSEI.EDU>PL", null, "AQAAAAEAACcQAAAAECKqgeDZRlcA4C+H8bf4mySadG6XjiezGP6ZR6yRV0tUfLo+KhUJebWWYb9qPLgf7A==", null, false, "91076cd8-925a-44a0-80ac-5674daad1431", false, "adam" },
                    { "8fedb26e-1551-41f7-8750-780f01bbf43e", 0, "fe412491-51f4-49b1-8beb-ca136ee35b1c", "marcin@wsei.edu.pl", true, false, null, "MARCIN@WSEI.EDU>PL", null, "AQAAAAEAACcQAAAAECGQRmzzvBBGr+qe0LhPpjTeltfGPL2DKRspVCy5WaGN8fbuAS6nIR1MLrns3h/4hw==", null, false, "df2e0f64-2b65-4b9c-ad22-f247139d89d3", false, "marcin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "40358116-35e4-41f0-9e78-e31cf01c3f8e", "76ac3c01-4d87-4e27-90bd-95121a486672" },
                    { "54f2034f-b5e7-4550-9232-5797c26f640d", "8fedb26e-1551-41f7-8750-780f01bbf43e" }
                });
        }
    }
}
