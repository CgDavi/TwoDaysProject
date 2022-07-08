using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TwoDaysProject.Database.Migrations
{
    public partial class resultsNumberAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ResultsNumber",
                table: "SitePages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "f9edfb7b-65df-435c-b97a-722b6c5ce33f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3f09027e-bead-438c-a97a-d9d01f8eade2",
                column: "ConcurrencyStamp",
                value: "8fc48f88-f5ec-46d0-8c09-858f76f9ad0b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "599f7d0f-c150-421f-9132-5f9e822711c8",
                column: "ConcurrencyStamp",
                value: "9a21fa79-5b72-439a-9b52-28ff9dd338cc");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "39db4566-a788-490e-b8a6-4fe9b829fcc2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d7021e6d-b9bb-4495-9766-ac6e8e1e98b8", "AQAAAAEAACcQAAAAEO+IRxoWsP7z3vBew1BkaCZsFSDiC9bweqqrP4bFVrqU+HlcVUz+oWDVyTiYwaO5hg==", "af44c21c-1a42-43c0-9c4b-639164486dfc" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ResultsNumber",
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
    }
}
