
using Microsoft.EntityFrameworkCore;

namespace AutoPartsShop.Models
{
    public static class ModelDataSeeder
    {
        public static void DataSeed(this ModelBuilder modelBuilder)
        {
            // Model Builder for Category Table, this contains special column values and configurations.
            modelBuilder.Entity<Category>()
                .Property(c => c.Created)
                .HasDefaultValueSql("getdate()");
            modelBuilder.Entity<Category>()
                .Property(c => c.Modified)
                .HasDefaultValueSql("getdate()");

            // Model Builder for Order Table, this contains special column values and configurations.
            modelBuilder.Entity<Order>()
               .Property(c => c.OrderTotal)
               .HasColumnType("decimal(6,3)");
            modelBuilder.Entity<Order>()
                .Property(c => c.Created)
                .HasDefaultValueSql("getdate()");
            modelBuilder.Entity<Order>()
                .Property(c => c.Modified)
                .HasDefaultValueSql("getdate()");

            // Model Builder for Order Detail Table, this contains special column values and configurations.
            modelBuilder.Entity<OrderDetail>()
               .Property(c => c.Price)
               .HasColumnType("decimal(6,3)");
            modelBuilder.Entity<OrderDetail>()
                .Property(c => c.Created)
                .HasDefaultValueSql("getdate()");
            modelBuilder.Entity<OrderDetail>()
                .Property(c => c.Modified)
                .HasDefaultValueSql("getdate()");

            // Model Builder for Category Table: This contains seed data values.
            modelBuilder.Entity<Category>()
                .HasData(
                new Category { CategoryId = 1, Name = "Engine" },
                new Category { CategoryId = 2, Name = "Suspension" },
                new Category { CategoryId = 3, Name = "Brakes" },
                new Category { CategoryId = 4, Name = "Tunning" });

            // Model Builder for Part Table: This contains special column values and configurations.
            modelBuilder.Entity<Part>()
                .Property(p => p.Price)
                .HasColumnType("decimal(6,3)");
            modelBuilder.Entity<Part>()
                .Property(p => p.Created)
                .HasDefaultValueSql("getdate()");
            modelBuilder.Entity<Part>()
                .Property(p => p.Modified)
                .HasDefaultValueSql("getdate()");

            // Model Builder for Part Table: This contains seed data values.
            modelBuilder.Entity<Part>()
                .HasData(
                new Part
                {
                    PartId = 1,
                    Name = "Motorcraft Spark Plug,SP-534/SP-580",
                    Brand = "Motorcraft",
                    CategoryId = 1,
                    Price = 7.05M,
                    Description = "High-quality spark plugs recommended by Ford Motor Company. Used for conventional distributor-equipped and coil-on-plug ignition systems found in many Ford, Lincoln and Mercury vehicles. ",
                    IsInStock = true,
                    IsOnSale = false,
                    ImageUrl = "\\images\\motorcraft-sparkplug.jpg",
                    ImageThumbnailUrl = "\\images\\thumbnails\\mini-motorcraft-sparkplug.jpg",
                }, new Part
                {
                    PartId = 2,
                    Name = "Gates (T343) Engine Timing Belt",
                    Brand = "Gates",
                    CategoryId = 1,
                    Price = 28.98M,
                    Description = "Gates Gates Timing Belts T343 (ONE PER PKG) Timing Belts (ONE PER PKG)2013-11 Ford, Fiesta, 4-Cyl. 1.6 L, Cam. Belt.",
                    IsInStock = true,
                    IsOnSale = true,
                    ImageUrl = "\\images\\gates-timmingbelt.jpg",
                    ImageThumbnailUrl = "\\images\\thumbnails\\mini-gates-timmingbelt.jpg",
                }, new Part
                {
                    PartId = 3,
                    Name = "GMB 125-3300 OE Replacement Water Pump with Gasket",
                    Brand = "GMB",
                    CategoryId = 1,
                    Price = 35.01M,
                    Description = "GMB OE Replacement Water Pumps are precision-built and balanced that meet or exceed original equipment specifications. GMB is one of the world's largest designers and producers of automotive products for most European, Asian and domestic built vehicles. GMB products are engineered and built utilizing the strictest design and manufacturing guidelines, with the finest quality assured through ISO 9002 programs. ",
                    IsInStock = true,
                    IsOnSale = true,
                    ImageUrl = "\\images\\gmb-waterpump.jpg",
                    ImageThumbnailUrl = "\\images\\thumbnails\\mini-gmb-waterpump.jpg",
                },
                new Part
                {
                    PartId = 4,
                    Name = "Tensioner",
                    Brand = "Gates",
                    CategoryId = 1,
                    Price = 29.99M,
                    Description = "GMB OE Replacement Water Pumps are precision-built and balanced that meet or exceed original equipment specifications. GMB is one of the world's largest designers and producers of automotive products for most European, Asian and domestic built vehicles. GMB products are engineered and built utilizing the strictest design and manufacturing guidelines, with the finest quality assured through ISO 9002 programs. ",
                    IsInStock = true,
                    IsOnSale = true,
                    ImageUrl = "\\images\\gates-tensioner.jpg",
                    ImageThumbnailUrl = "\\images\\thumbnails\\mini-gates-tensioner.jpg",
                },
                new Part
                {
                    PartId = 5,
                    Name = "(2) 100% New FRONT Complete Coil Spring Struts for 2011-2016 Ford Fiesta",
                    Brand = "Mac Auto Parts",
                    CategoryId = 2,
                    Price = 237.30M,
                    Description = "This item is a brand new pair of 100% New Tested Strut & Coil Spring Assembly's It will fit the following makes and models:" +
                    "2011 - 2016 Ford Fiesta" +
                    "Kit Includes: 2Pc Fits FRONT " +
                    "1x Part# 1333356L FRONT Left Spring Strut Shock PREMIUM BRAND WITH IMPROVED BUSHINGS VARI RATE SPRING WITH UPPER BEARING MOUNT" +
                    "1x Part# 1333356R FRONT Right Spring Strut Shock PREMIUM BRAND WITH IMPROVED BUSHINGS VARI RATE SPRING WITH UPPER BEARING MOUNT",
                    IsInStock = true,
                    IsOnSale = true,
                    ImageUrl = "\\images\\map-coilsprings.jpg",
                    ImageThumbnailUrl = "\\images\\thumbnails\\mini-map-coilsprings.jpg",
                },
                new Part
                {
                    PartId = 6,
                    Name = "KYB SB125 - Strut Boot",
                    Brand = "KYB",
                    CategoryId = 2,
                    Price = 19.14M,
                    Description = "KYB Strut Boot Kits keep your struts protected from dirt, dust, sand, salt and other road debris.",
                    IsInStock = true,
                    IsOnSale = true,
                    ImageUrl = "\\images\\kyb-strutboot.jpg",
                    ImageThumbnailUrl = "\\images\\thumbnails\\mini-kyb-strutboot.jpg",
                },
                new Part
                {
                    PartId = 7,
                    Name = "Hawk HB725B.650 Brake Pad",
                    Brand = "Hawk",
                    CategoryId = 3,
                    Price = 78.49M,
                    Description = "Hawk Performance is a leading supplier of severe duty and high-performance friction products manufactured in ISO-certified facilities for the motorsports and performance automotive aftermarket. Hawk Performance products are engineered to allow users to control, command and conquer the terrain for which their vehicles are designed.",
                    IsInStock = true,
                    IsOnSale = true,
                    ImageUrl = "\\images\\hawk-brakepad.jpg",
                    ImageThumbnailUrl = "\\images\\thumbnails\\mini-hawk-brakepad.jpg",
                },
                new Part
                {
                    PartId = 8,
                    Name = "Bosch 20011534 QuietCast Premium Disc Brake Rotor For 2011-2016 Ford Fiesta; Front",
                    Brand = "Bosch",
                    CategoryId = 3,
                    Price = 46.62M,
                    Description = "Bosch QuietCast Premium Disc Brake Rotors utilize innovative materials that ensure the highest quality performance, prevent rust and corrosion with clear-look coating protection, provide a clean look for today's open-wheeled vehicles, are 100% precision balanced for smooth operation, and have a factory-engraved edge with code and minimum thickness specifications.",
                    IsInStock = true,
                    IsOnSale = true,
                    ImageUrl = "\\images\\bosch-quietcastdiscrotor.jpg",
                    ImageThumbnailUrl = "\\images\\thumbnails\\mini-bosch-quietcastdiscrotor.jpg",
                },
                new Part
                {
                    PartId = 9,
                    Name = "Bosch BC1454 QuietCast Premium Ceramic Disc Brake Pad Set For 2011-2017 Ford Fiesta; Front",
                    Brand = "Bosch",
                    CategoryId = 3,
                    Price = 34.51M,
                    Description = "QuietCast delivers the quiet operation you expect with the durability and long life that are the hallmarks of all Bosch products. QuietCast comes complete with hardware (where available) and lubricant to do a complete brake job the first time, every time.",
                    IsInStock = true,
                    IsOnSale = false,
                    ImageUrl = "\\images\\bosch-quietcastbrakepads.jpg",
                    ImageThumbnailUrl = "\\images\\thumbnails\\mini-bosch-quietcastbrakepads.jpg",
                },
                new Part
                {
                    PartId = 10,
                    Name = "HIKARI 2020, H11 H8 H9 LED Headlight Bulbs, 150% Brightness, 100% Extra Night Visibility, TOP XHP50.2 LED 10400lm 6000K Cool White",
                    Brand = "HIKARI WINGS",
                    CategoryId = 4,
                    Price = 69.99M,
                    Description = "Best Night Vision: HIKARI 'Night King' series can ensure both the sufficient luminance in front of the vehicle and the light can even be overspread to both sides of the vehicle so that a driver's own driving field can be created, and the driving field of view and safety can be assured.",
                    IsInStock = true,
                    IsOnSale = true,
                    ImageUrl = "\\images\\hikari-ledheadlights.jpg",
                    ImageThumbnailUrl = "\\images\\thumbnails\\mini-hikari-ledheadlights.jpg",
                });
        }
    }
}