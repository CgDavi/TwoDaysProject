using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TwoDaysProject.Database.Migrations
{
    public partial class generalConfig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GeneralConfigs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApiKey = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneralConfigs", x => x.Id);
                });

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

            migrationBuilder.InsertData(
                table: "GeneralConfigs",
                columns: new[] { "Id", "ApiKey" },
                values: new object[] { 1, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GeneralConfigs");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "bb4207e3-4e5b-44d0-8fac-2f27d3622bd9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3f09027e-bead-438c-a97a-d9d01f8eade2",
                column: "ConcurrencyStamp",
                value: "da624d35-524f-4c8b-b5f1-f59e4d4666d8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "599f7d0f-c150-421f-9132-5f9e822711c8",
                column: "ConcurrencyStamp",
                value: "07ba46d2-4c0f-4149-bd0b-cfd64ff1724e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "39db4566-a788-490e-b8a6-4fe9b829fcc2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "04d2f940-5716-44d9-b248-9e4bd88244e5", "AQAAAAEAACcQAAAAEJLpamKRdWpRYODWJQk/EZHsvemm8aDjapK7jwlk/zt5uWL9+m6W8Z5jh1Bz4RJWrg==", "8d2d82c3-6559-435b-8f6b-92b60bd5fe0a" });
        }
    }
}
