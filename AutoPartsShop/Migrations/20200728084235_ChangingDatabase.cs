using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AutoPartsShop.Migrations
{
    public partial class ChangingDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Parts_Categories_CategoryId1",
                table: "Parts");

            migrationBuilder.DropIndex(
                name: "IX_Parts_CategoryId1",
                table: "Parts");

            migrationBuilder.DropColumn(
                name: "CategoryId1",
                table: "Parts");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "Parts",
                nullable: false,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Parts",
                nullable: false,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Parts",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "Categories",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Modified",
                table: "Categories",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Created", "Description", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Engine" },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Suspension" },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Brakes" },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Tunning" }
                });

            migrationBuilder.InsertData(
                table: "Parts",
                columns: new[] { "PartId", "Brand", "CategoryId", "Description", "ImageThumbnailUrl", "ImageUrl", "IsInStock", "IsOnSale", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Motorcraft", 1, "High-quality spark plugs recommended by Ford Motor Company. Used for conventional distributor-equipped and coil-on-plug ignition systems found in many Ford, Lincoln and Mercury vehicles. ", "~\\images\\thumbnails\\mini-motorcraft-sparkplug.jpg", "~\\images\\motorcraft-sparkplug.jpg", true, false, "Motorcraft Spark Plug,SP-534/SP-580", 7.05m },
                    { 2, "Gates", 1, "Gates Gates Timing Belts T343 (ONE PER PKG) Timing Belts (ONE PER PKG)2013-11 Ford, Fiesta, 4-Cyl. 1.6 L, Cam. Belt.", "~\\images\\thumbnails\\mini-gates-timmingbelt.jpg", "~\\images\\gates-timmingbelt.jpg", true, true, "Gates (T343) Engine Timing Belt", 28.98m },
                    { 3, "GMB", 1, "GMB OE Replacement Water Pumps are precision-built and balanced that meet or exceed original equipment specifications. GMB is one of the world's largest designers and producers of automotive products for most European, Asian and domestic built vehicles. GMB products are engineered and built utilizing the strictest design and manufacturing guidelines, with the finest quality assured through ISO 9002 programs. ", "~\\images\\thumbnails\\mini-gmb-waterpump.jpg", "~\\images\\gmb-waterpump.jpg", true, true, "GMB 125-3300 OE Replacement Water Pump with Gasket", 35.01m },
                    { 4, "Gates", 1, "GMB OE Replacement Water Pumps are precision-built and balanced that meet or exceed original equipment specifications. GMB is one of the world's largest designers and producers of automotive products for most European, Asian and domestic built vehicles. GMB products are engineered and built utilizing the strictest design and manufacturing guidelines, with the finest quality assured through ISO 9002 programs. ", "~\\images\\thumbnails\\mini-gates-tensioner.jpg", "~\\images\\gates-tensioner.jpg", true, true, "Tensioner", 29.99m },
                    { 5, "Mac Auto Parts", 2, "This item is a brand new pair of 100% New Tested Strut & Coil Spring Assembly's It will fit the following makes and models:2011 - 2016 Ford FiestaKit Includes: 2Pc Fits FRONT 1x Part# 1333356L FRONT Left Spring Strut Shock PREMIUM BRAND WITH IMPROVED BUSHINGS VARI RATE SPRING WITH UPPER BEARING MOUNT1x Part# 1333356R FRONT Right Spring Strut Shock PREMIUM BRAND WITH IMPROVED BUSHINGS VARI RATE SPRING WITH UPPER BEARING MOUNT", "~\\images\\thumbnails\\mini-map-coilsprings.jpg", "~\\images\\map-coilsprings.jpg", true, true, "(2) 100% New FRONT Complete Coil Spring Struts for 2011-2016 Ford Fiesta", 237.30m }
                });

            migrationBuilder.InsertData(
                table: "Parts",
                columns: new[] { "PartId", "Brand", "CategoryId", "Created", "Description", "ImageThumbnailUrl", "ImageUrl", "IsInStock", "IsOnSale", "Name", "Price" },
                values: new object[] { 6, "KYB", 2, new DateTime(2020, 7, 28, 3, 42, 35, 140, DateTimeKind.Local).AddTicks(3277), "KYB Strut Boot Kits keep your struts protected from dirt, dust, sand, salt and other road debris.", "~\\images\\thumbnails\\mini-kyb-strutboot.jpg", "~\\images\\kyb-strutboot.jpg", true, true, "KYB SB125 - Strut Boot", 19.14m });

            migrationBuilder.InsertData(
                table: "Parts",
                columns: new[] { "PartId", "Brand", "CategoryId", "Description", "ImageThumbnailUrl", "ImageUrl", "IsInStock", "IsOnSale", "Name", "Price" },
                values: new object[,]
                {
                    { 7, "Hawk", 3, "Hawk Performance is a leading supplier of severe duty and high-performance friction products manufactured in ISO-certified facilities for the motorsports and performance automotive aftermarket. Hawk Performance products are engineered to allow users to control, command and conquer the terrain for which their vehicles are designed.", "~\\images\\thumbnails\\mini-hawk-brakepad.jpg", "~\\images\\hawk-brakepad.jpg", true, true, "Hawk HB725B.650 Brake Pad", 78.49m },
                    { 8, "Bosch", 3, "Bosch QuietCast Premium Disc Brake Rotors utilize innovative materials that ensure the highest quality performance, prevent rust and corrosion with clear-look coating protection, provide a clean look for today's open-wheeled vehicles, are 100% precision balanced for smooth operation, and have a factory-engraved edge with code and minimum thickness specifications.", "~\\images\\thumbnails\\mini-bosch-quietcastdiscrotor.jpg", "~\\images\\bosch-quietcastdiscrotor.jpg", true, true, "Bosch 20011534 QuietCast Premium Disc Brake Rotor For 2011-2016 Ford Fiesta; Front", 46.62m },
                    { 9, "Bosch", 3, "QuietCast delivers the quiet operation you expect with the durability and long life that are the hallmarks of all Bosch products. QuietCast comes complete with hardware (where available) and lubricant to do a complete brake job the first time, every time.", "~\\images\\thumbnails\\mini-bosch-quietcastbrakepads.jpg", "~\\images\\bosch-quietcastbrakepads.jpg", true, false, "Bosch BC1454 QuietCast Premium Ceramic Disc Brake Pad Set For 2011-2017 Ford Fiesta; Front", 34.51m },
                    { 10, "HIKARI WINGS", 4, "Best Night Vision: HIKARI 'Night King' series can ensure both the sufficient luminance in front of the vehicle and the light can even be overspread to both sides of the vehicle so that a driver's own driving field can be created, and the driving field of view and safety can be assured.", "~\\images\\thumbnails\\mini-hikari-ledheadlights.jpg", "~\\images\\hikari-ledheadlights.jpg", true, true, "HIKARI 2020, H11 H8 H9 LED Headlight Bulbs, 150% Brightness, 100% Extra Night Visibility, TOP XHP50.2 LED 10400lm 6000K Cool White", 69.99m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Parts_CategoryId",
                table: "Parts",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Parts_Categories_CategoryId",
                table: "Parts",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Parts_Categories_CategoryId",
                table: "Parts");

            migrationBuilder.DropIndex(
                name: "IX_Parts_CategoryId",
                table: "Parts");

            migrationBuilder.DeleteData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "Created",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "Modified",
                table: "Categories");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "Parts",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "getdate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Parts",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "getdate()");

            migrationBuilder.AlterColumn<string>(
                name: "CategoryId",
                table: "Parts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "CategoryId1",
                table: "Parts",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Parts_CategoryId1",
                table: "Parts",
                column: "CategoryId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Parts_Categories_CategoryId1",
                table: "Parts",
                column: "CategoryId1",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
