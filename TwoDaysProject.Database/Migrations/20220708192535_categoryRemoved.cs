using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TwoDaysProject.Database.Migrations
{
    public partial class categoryRemoved : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "SitePages");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "2cc0eef4-f7c2-4b6a-889a-a85ae31845dc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3f09027e-bead-438c-a97a-d9d01f8eade2",
                column: "ConcurrencyStamp",
                value: "c0fae5bf-19a4-4c2d-8a3e-e9c3c0a24d8c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "599f7d0f-c150-421f-9132-5f9e822711c8",
                column: "ConcurrencyStamp",
                value: "a44818df-c29a-44f9-b87d-8d4ef631443f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "39db4566-a788-490e-b8a6-4fe9b829fcc2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6bcd0e88-215a-4c01-a765-bc109f09a3ef", "AQAAAAEAACcQAAAAEAE6/xJ2cTbrOCB2L8IXNDabslz9cfCSRwNI19KE8kDs82IiFz2i9LphLXzN3D8quA==", "10c171da-8085-4ebf-b150-baa823b37bfa" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "SitePages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "182823e7-6a4a-4de4-bc73-72807162c2d7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3f09027e-bead-438c-a97a-d9d01f8eade2",
                column: "ConcurrencyStamp",
                value: "45011ec3-9d03-430a-b319-cf523aa50935");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "599f7d0f-c150-421f-9132-5f9e822711c8",
                column: "ConcurrencyStamp",
                value: "d1f1b347-c8a8-4e8b-9619-a42cbfdbaea1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "39db4566-a788-490e-b8a6-4fe9b829fcc2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9d274540-264d-41db-b453-fac93f958a65", "AQAAAAEAACcQAAAAECzpT9K0D9D+R/tdAWsthV9lfetpC33azZhDNPEd5m8QEjULhfxNhkD458b/zjPsCg==", "000ec4af-41ae-4309-bcce-5a9f91543fb1" });
        }
    }
}
