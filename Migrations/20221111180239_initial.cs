using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ComputerStore.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Purchases",
                columns: table => new
                {
                    PurchaseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Person = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ProductId1 = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Purchases", x => x.PurchaseId);
                    table.ForeignKey(
                        name: "FK_Purchases_Products_ProductId1",
                        column: x => x.ProductId1,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { 1, "Ноутбуки" });

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { 2, "Мобільні телефони" });

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { 3, "Комп'ютерні миші" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1L, 1, "Екран 15.6” IPS (1920x1080) Full HD, матовий/AMD Ryzen 5 3500U (2.1 — 3.7 ГГц)/RAM 8 ГБ/SSD 512 ГБ/AMD Radeon Vega 8 Graphics/без ОД/LAN/Wi-Fi/Bluetooth/вебкамера/Windows 10 Pro 64bit/1.74 кг/сірий", "HP 255 G8 (2W1E7EA) Asteroid Silver", 32599m },
                    { 2L, 1, "Екран 14\" IPS (1920x1080) Full HD, матовий / Intel Core i3-1125G4 (2.0 — 3.7 ГГц) / RAM 8 ГБ / SSD 512 ГБ / Intel UHD Graphics / без ОД / Wi-Fi / Bluetooth / вебкамера / Windows 10 Home 64 bit / 1.41 кг / сріблястий", "HP Pavilion 14-dv0047ua (4A7L9EA) Natural Silver", 36055m },
                    { 3L, 2, "Екран (6.4\", Super AMOLED, 2400x1080) / MediaTek Helio G80(2.0 ГГц + 1.8 ГГц) / основна квадрокамера: 64 Мп + 8 Мп + 2 Мп + 2 Мп, фронтальна камера: 20 Мп / RAM 6 ГБ / 128 ГБ вбудованої пам'яті + microSD (до 1 ТБ) / 3G / LTE / GPS / підтримка 2 SIM-карток (Nano-SIM) / Android 11 / 5000 мА·год", "Samsung Galaxy M32 6/128 GB Light Blue (SM-M325FLBGSEK)", 8555m },
                    { 4L, 3, "Під'єднання Бездротове / Розмір миші Маленька / Особливості Для обох рук (симетричний дизайн) / Сумісність з ОС Mac OS, Microsoft Windows", "Logitech M185 Wireless Blue (910-002239/910-002236)", 8555m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Purchases_ProductId1",
                table: "Purchases",
                column: "ProductId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Purchases");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "categories");
        }
    }
}
