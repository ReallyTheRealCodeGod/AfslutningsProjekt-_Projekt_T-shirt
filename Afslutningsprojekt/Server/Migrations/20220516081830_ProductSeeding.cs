using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Afslutningsprojekt.Server.Migrations
{
    public partial class ProductSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateUpdated", "Description", "Image", "IsDeleted", "IsPublic", "OriginalPrice", "Price", "Title" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 5, 16, 10, 18, 30, 307, DateTimeKind.Local).AddTicks(3904), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unikum Munikums first t-shirt design to be introduced to the website", "https://upload.wikimedia.org/wikipedia/commons/2/24/Blue_Tshirt.jpg", false, false, 200m, 100m, "testing T-shirt flag 1" },
                    { 2, 1, new DateTime(2022, 5, 16, 10, 18, 30, 307, DateTimeKind.Local).AddTicks(3940), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unikum Munikums second t-shirt design to be introduced to the website", "https://upload.wikimedia.org/wikipedia/commons/2/24/Blue_Tshirt.jpg", false, false, 200m, 99m, "testing T-shirt 2" },
                    { 3, 1, new DateTime(2022, 5, 16, 10, 18, 30, 307, DateTimeKind.Local).AddTicks(3942), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unikum Munikums ordinary shirt", "https://upload.wikimedia.org/wikipedia/commons/2/24/Blue_Tshirt.jpg", false, false, 200m, 99m, "testing T-shirt 2" },
                    { 4, 1, new DateTime(2022, 5, 16, 10, 18, 30, 307, DateTimeKind.Local).AddTicks(3944), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unikum Munikums second t-shirt design to be introduced to the website", "https://upload.wikimedia.org/wikipedia/commons/2/24/Blue_Tshirt.jpg", false, false, 200m, 99m, "testing T-shirt" },
                    { 5, 1, new DateTime(2022, 5, 16, 10, 18, 30, 307, DateTimeKind.Local).AddTicks(3946), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unikum Munikums second t-shirt design to be introduced to the website", "https://upload.wikimedia.org/wikipedia/commons/2/24/Blue_Tshirt.jpg", false, false, 200m, 99m, "ugly testing T-shirt" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
