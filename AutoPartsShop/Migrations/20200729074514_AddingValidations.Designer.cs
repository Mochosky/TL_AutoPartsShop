﻿// <auto-generated />
using System;
using AutoPartsShop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AutoPartsShop.Migrations
{
    [DbContext(typeof(AutoPartsShopDbContext))]
    [Migration("20200729074514_AddingValidations")]
    partial class AddingValidations
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AutoPartsShop.Models.CartItem", b =>
                {
                    b.Property<int>("CartItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CartId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PartId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("CartItemId");

                    b.HasIndex("PartId");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("AutoPartsShop.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Modified")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Modified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Engine"
                        },
                        new
                        {
                            CategoryId = 2,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Modified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Suspension"
                        },
                        new
                        {
                            CategoryId = 3,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Modified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Brakes"
                        },
                        new
                        {
                            CategoryId = 4,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Modified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Tunning"
                        });
                });

            modelBuilder.Entity("AutoPartsShop.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)")
                        .HasMaxLength(25);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<DateTime>("Modified")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<DateTime>("OrderPlaced")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("OrderTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Zip")
                        .IsRequired()
                        .HasColumnType("nvarchar(6)")
                        .HasMaxLength(6);

                    b.HasKey("OrderId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("AutoPartsShop.Models.OrderDetail", b =>
                {
                    b.Property<int>("OrderDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<DateTime>("Modified")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("PartId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("OrderDetailId");

                    b.HasIndex("OrderId");

                    b.HasIndex("PartId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("AutoPartsShop.Models.Part", b =>
                {
                    b.Property<int>("PartId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageThumbnailUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsInStock")
                        .HasColumnType("bit");

                    b.Property<bool>("IsOnSale")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Modified")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(6,3)");

                    b.HasKey("PartId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Parts");

                    b.HasData(
                        new
                        {
                            PartId = 1,
                            Brand = "Motorcraft",
                            CategoryId = 1,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "High-quality spark plugs recommended by Ford Motor Company. Used for conventional distributor-equipped and coil-on-plug ignition systems found in many Ford, Lincoln and Mercury vehicles. ",
                            ImageThumbnailUrl = "\\images\\thumbnails\\mini-motorcraft-sparkplug.jpg",
                            ImageUrl = "\\images\\motorcraft-sparkplug.jpg",
                            IsInStock = true,
                            IsOnSale = false,
                            Modified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Motorcraft Spark Plug,SP-534/SP-580",
                            Price = 7.05m
                        },
                        new
                        {
                            PartId = 2,
                            Brand = "Gates",
                            CategoryId = 1,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Gates Gates Timing Belts T343 (ONE PER PKG) Timing Belts (ONE PER PKG)2013-11 Ford, Fiesta, 4-Cyl. 1.6 L, Cam. Belt.",
                            ImageThumbnailUrl = "\\images\\thumbnails\\mini-gates-timmingbelt.jpg",
                            ImageUrl = "\\images\\gates-timmingbelt.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Modified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Gates (T343) Engine Timing Belt",
                            Price = 28.98m
                        },
                        new
                        {
                            PartId = 3,
                            Brand = "GMB",
                            CategoryId = 1,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "GMB OE Replacement Water Pumps are precision-built and balanced that meet or exceed original equipment specifications. GMB is one of the world's largest designers and producers of automotive products for most European, Asian and domestic built vehicles. GMB products are engineered and built utilizing the strictest design and manufacturing guidelines, with the finest quality assured through ISO 9002 programs. ",
                            ImageThumbnailUrl = "\\images\\thumbnails\\mini-gmb-waterpump.jpg",
                            ImageUrl = "\\images\\gmb-waterpump.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Modified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "GMB 125-3300 OE Replacement Water Pump with Gasket",
                            Price = 35.01m
                        },
                        new
                        {
                            PartId = 4,
                            Brand = "Gates",
                            CategoryId = 1,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "GMB OE Replacement Water Pumps are precision-built and balanced that meet or exceed original equipment specifications. GMB is one of the world's largest designers and producers of automotive products for most European, Asian and domestic built vehicles. GMB products are engineered and built utilizing the strictest design and manufacturing guidelines, with the finest quality assured through ISO 9002 programs. ",
                            ImageThumbnailUrl = "\\images\\thumbnails\\mini-gates-tensioner.jpg",
                            ImageUrl = "\\images\\gates-tensioner.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Modified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Tensioner",
                            Price = 29.99m
                        },
                        new
                        {
                            PartId = 5,
                            Brand = "Mac Auto Parts",
                            CategoryId = 2,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "This item is a brand new pair of 100% New Tested Strut & Coil Spring Assembly's It will fit the following makes and models:2011 - 2016 Ford FiestaKit Includes: 2Pc Fits FRONT 1x Part# 1333356L FRONT Left Spring Strut Shock PREMIUM BRAND WITH IMPROVED BUSHINGS VARI RATE SPRING WITH UPPER BEARING MOUNT1x Part# 1333356R FRONT Right Spring Strut Shock PREMIUM BRAND WITH IMPROVED BUSHINGS VARI RATE SPRING WITH UPPER BEARING MOUNT",
                            ImageThumbnailUrl = "\\images\\thumbnails\\mini-map-coilsprings.jpg",
                            ImageUrl = "\\images\\map-coilsprings.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Modified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "(2) 100% New FRONT Complete Coil Spring Struts for 2011-2016 Ford Fiesta",
                            Price = 237.30m
                        },
                        new
                        {
                            PartId = 6,
                            Brand = "KYB",
                            CategoryId = 2,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "KYB Strut Boot Kits keep your struts protected from dirt, dust, sand, salt and other road debris.",
                            ImageThumbnailUrl = "\\images\\thumbnails\\mini-kyb-strutboot.jpg",
                            ImageUrl = "\\images\\kyb-strutboot.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Modified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "KYB SB125 - Strut Boot",
                            Price = 19.14m
                        },
                        new
                        {
                            PartId = 7,
                            Brand = "Hawk",
                            CategoryId = 3,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Hawk Performance is a leading supplier of severe duty and high-performance friction products manufactured in ISO-certified facilities for the motorsports and performance automotive aftermarket. Hawk Performance products are engineered to allow users to control, command and conquer the terrain for which their vehicles are designed.",
                            ImageThumbnailUrl = "\\images\\thumbnails\\mini-hawk-brakepad.jpg",
                            ImageUrl = "\\images\\hawk-brakepad.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Modified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Hawk HB725B.650 Brake Pad",
                            Price = 78.49m
                        },
                        new
                        {
                            PartId = 8,
                            Brand = "Bosch",
                            CategoryId = 3,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Bosch QuietCast Premium Disc Brake Rotors utilize innovative materials that ensure the highest quality performance, prevent rust and corrosion with clear-look coating protection, provide a clean look for today's open-wheeled vehicles, are 100% precision balanced for smooth operation, and have a factory-engraved edge with code and minimum thickness specifications.",
                            ImageThumbnailUrl = "\\images\\thumbnails\\mini-bosch-quietcastdiscrotor.jpg",
                            ImageUrl = "\\images\\bosch-quietcastdiscrotor.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Modified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Bosch 20011534 QuietCast Premium Disc Brake Rotor For 2011-2016 Ford Fiesta; Front",
                            Price = 46.62m
                        },
                        new
                        {
                            PartId = 9,
                            Brand = "Bosch",
                            CategoryId = 3,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "QuietCast delivers the quiet operation you expect with the durability and long life that are the hallmarks of all Bosch products. QuietCast comes complete with hardware (where available) and lubricant to do a complete brake job the first time, every time.",
                            ImageThumbnailUrl = "\\images\\thumbnails\\mini-bosch-quietcastbrakepads.jpg",
                            ImageUrl = "\\images\\bosch-quietcastbrakepads.jpg",
                            IsInStock = true,
                            IsOnSale = false,
                            Modified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Bosch BC1454 QuietCast Premium Ceramic Disc Brake Pad Set For 2011-2017 Ford Fiesta; Front",
                            Price = 34.51m
                        },
                        new
                        {
                            PartId = 10,
                            Brand = "HIKARI WINGS",
                            CategoryId = 4,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Best Night Vision: HIKARI 'Night King' series can ensure both the sufficient luminance in front of the vehicle and the light can even be overspread to both sides of the vehicle so that a driver's own driving field can be created, and the driving field of view and safety can be assured.",
                            ImageThumbnailUrl = "\\images\\thumbnails\\mini-hikari-ledheadlights.jpg",
                            ImageUrl = "\\images\\hikari-ledheadlights.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Modified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "HIKARI 2020, H11 H8 H9 LED Headlight Bulbs, 150% Brightness, 100% Extra Night Visibility, TOP XHP50.2 LED 10400lm 6000K Cool White",
                            Price = 69.99m
                        });
                });

            modelBuilder.Entity("AutoPartsShop.Models.CartItem", b =>
                {
                    b.HasOne("AutoPartsShop.Models.Part", "Part")
                        .WithMany()
                        .HasForeignKey("PartId");
                });

            modelBuilder.Entity("AutoPartsShop.Models.OrderDetail", b =>
                {
                    b.HasOne("AutoPartsShop.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AutoPartsShop.Models.Part", "Part")
                        .WithMany()
                        .HasForeignKey("PartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AutoPartsShop.Models.Part", b =>
                {
                    b.HasOne("AutoPartsShop.Models.Category", "Category")
                        .WithMany("Parts")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
