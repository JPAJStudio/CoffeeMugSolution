using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoffeeMug.Api.Migrations
{
    public partial class InitialSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("016bcb97-dace-4e04-9942-e2d41912f5b5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("05545070-64c9-4b00-b540-2698aa169c26"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0f208b96-b8b2-4d59-bdcd-407025d48208"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8207482c-5c3e-4c1e-83e9-f86813824c0a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ab15f6f1-efdc-4196-b79b-278510dd78ab"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b774da7f-39c7-485e-86bb-58c3f228ba5a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c485a887-eb58-4358-a114-641c732e1a2a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d2a51310-fed5-4cc3-9cd2-2c7a92edb40b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e72746af-24ed-490d-aa40-895cf915597a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fea5b78f-abe9-43e1-8598-0e187fe12769"));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("cfd2e301-17e5-48a3-a6da-ea35fcc68647"), "Audi A4", 149000.99m },
                    { new Guid("ae38790b-4616-46db-b95b-95fe3222f9b6"), "BMW M5", 399000.95m },
                    { new Guid("ec6f9796-e2c8-4227-9593-6e77dbbc1319"), "Mercedes GLC", 179000m },
                    { new Guid("d2a898ee-b54b-4c3c-ab30-1d687fd1abbc"), "Mazda 6", 119000m },
                    { new Guid("7739b7e0-92a5-44d7-b722-719c7355e0dc"), "Opel Astra", 79000m },
                    { new Guid("3fbdb1e8-3bc3-4eca-9d20-617296831cd7"), "Seat Ateca", 150000m },
                    { new Guid("f5d0177d-1ade-4c91-8c45-f955969c9d09"), "Skoda Superb", 159000m },
                    { new Guid("e21c9d1a-3e99-48b9-a738-ae620f8f6729"), "Saab 9-3", 15800m },
                    { new Guid("ab403513-e911-4c2d-bac0-365eeb09bb90"), "Volkswagen Amarok", 180000m },
                    { new Guid("b997d0c6-28c7-40f6-b0a2-266cbab5560d"), "Volvo S60", 219000m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3fbdb1e8-3bc3-4eca-9d20-617296831cd7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7739b7e0-92a5-44d7-b722-719c7355e0dc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ab403513-e911-4c2d-bac0-365eeb09bb90"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ae38790b-4616-46db-b95b-95fe3222f9b6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b997d0c6-28c7-40f6-b0a2-266cbab5560d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cfd2e301-17e5-48a3-a6da-ea35fcc68647"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d2a898ee-b54b-4c3c-ab30-1d687fd1abbc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e21c9d1a-3e99-48b9-a738-ae620f8f6729"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ec6f9796-e2c8-4227-9593-6e77dbbc1319"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f5d0177d-1ade-4c91-8c45-f955969c9d09"));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("fea5b78f-abe9-43e1-8598-0e187fe12769"), "Audi A4", 149000.99m },
                    { new Guid("0f208b96-b8b2-4d59-bdcd-407025d48208"), "BMW M5", 399000.95m },
                    { new Guid("e72746af-24ed-490d-aa40-895cf915597a"), "Mercedes GLC", 179000m },
                    { new Guid("b774da7f-39c7-485e-86bb-58c3f228ba5a"), "Mazda 6", 119000m },
                    { new Guid("d2a51310-fed5-4cc3-9cd2-2c7a92edb40b"), "Opel Astra", 79000m },
                    { new Guid("ab15f6f1-efdc-4196-b79b-278510dd78ab"), "Seat Ateca", 150000m },
                    { new Guid("05545070-64c9-4b00-b540-2698aa169c26"), "Skoda Superb", 159000m },
                    { new Guid("c485a887-eb58-4358-a114-641c732e1a2a"), "Saab 9-3", 15800m },
                    { new Guid("016bcb97-dace-4e04-9942-e2d41912f5b5"), "Volkswagen Amarok", 180000m },
                    { new Guid("8207482c-5c3e-4c1e-83e9-f86813824c0a"), "Volvo S60", 219000m }
                });
        }
    }
}
