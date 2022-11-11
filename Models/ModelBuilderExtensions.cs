using Microsoft.EntityFrameworkCore;

namespace ComputerStore.Models
{
    public static class ModelBuilderExtensions
    {

        public static void Configure(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .HasOne(p => p.Category)
                .WithMany(u => u.Products)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Purchase>()
                .HasOne(p => p.Product)
                .WithMany(t => t.Purchases)
                .OnDelete(DeleteBehavior.Cascade);
        }

        public static void Seed(this ModelBuilder modelBuilder)
        {
            Category[] categories =
            {
                new Category
                {
                    CategoryId = 1,
                    Name = "Ноутбуки"
                },
                new Category
                {
                    CategoryId = 2,
                    Name = "Мобільні телефони"
                },
                new Category
                {
                    CategoryId = 3,
                    Name = "Комп'ютерні миші"
                }
            };

            Product[] products =
            {
                 new Product {
                        ProductId = 1,
                        Name = "HP 255 G8 (2W1E7EA) Asteroid Silver",
                        Description = "Екран 15.6” IPS (1920x1080) Full HD, матовий/AMD Ryzen 5 3500U (2.1 — 3.7 ГГц)/RAM 8 ГБ/SSD 512 ГБ/AMD Radeon Vega 8 Graphics/без ОД/LAN/Wi-Fi/Bluetooth/вебкамера/Windows 10 Pro 64bit/1.74 кг/сірий",
                        CategoryId = 1,
                        Price = 32599
                 },
                 new Product {
                        ProductId = 2,
                        Name = "HP Pavilion 14-dv0047ua (4A7L9EA) Natural Silver",
                        Description = "Екран 14\" IPS (1920x1080) Full HD, матовий / Intel Core i3-1125G4 (2.0 — 3.7 ГГц) / RAM 8 ГБ / SSD 512 ГБ / Intel UHD Graphics / без ОД / Wi-Fi / Bluetooth / вебкамера / Windows 10 Home 64 bit / 1.41 кг / сріблястий",
                        CategoryId = 1,
                        Price = 36055
                 },
                 new Product {
                        ProductId = 3,
                        Name = "Samsung Galaxy M32 6/128 GB Light Blue (SM-M325FLBGSEK)",
                        Description = "Екран (6.4\", Super AMOLED, 2400x1080) / MediaTek Helio G80(2.0 ГГц + 1.8 ГГц) / основна квадрокамера: 64 Мп + 8 Мп + 2 Мп + 2 Мп, фронтальна камера: 20 Мп / RAM 6 ГБ / 128 ГБ вбудованої пам'яті + microSD (до 1 ТБ) / 3G / LTE / GPS / підтримка 2 SIM-карток (Nano-SIM) / Android 11 / 5000 мА·год",
                        CategoryId = 2,
                        Price = 8555
                 },
                 new Product {
                        ProductId = 4,
                        Name = "Logitech M185 Wireless Blue (910-002239/910-002236)",
                        Description = "Під'єднання Бездротове / Розмір миші Маленька / Особливості Для обох рук (симетричний дизайн) / Сумісність з ОС Mac OS, Microsoft Windows",
                        CategoryId = 3,
                        Price = 8555
                 }
            };

            modelBuilder.Entity<Category>().HasData(categories);
            modelBuilder.Entity<Product>().HasData(products);
        }
    }
}
