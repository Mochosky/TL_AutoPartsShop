using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AutoPartsShop.Migrations
{
    public partial class UpdatingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 1,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "\\images\\thumbnails\\mini-motorcraft-sparkplug.jpg", "\\images\\motorcraft-sparkplug.jpg" });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 2,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "\\images\\thumbnails\\mini-gates-timmingbelt.jpg", "\\images\\gates-timmingbelt.jpg" });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 3,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "\\images\\thumbnails\\mini-gmb-waterpump.jpg", "\\images\\gmb-waterpump.jpg" });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 4,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "\\images\\thumbnails\\mini-gates-tensioner.jpg", "\\images\\gates-tensioner.jpg" });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 5,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "\\images\\thumbnails\\mini-map-coilsprings.jpg", "\\images\\map-coilsprings.jpg" });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 6,
                columns: new[] { "Created", "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { new DateTime(2020, 7, 28, 3, 47, 34, 676, DateTimeKind.Local).AddTicks(9450), "\\images\\thumbnails\\mini-kyb-strutboot.jpg", "\\images\\kyb-strutboot.jpg" });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 7,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "\\images\\thumbnails\\mini-hawk-brakepad.jpg", "\\images\\hawk-brakepad.jpg" });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 8,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "\\images\\thumbnails\\mini-bosch-quietcastdiscrotor.jpg", "\\images\\bosch-quietcastdiscrotor.jpg" });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 9,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "\\images\\thumbnails\\mini-bosch-quietcastbrakepads.jpg", "\\images\\bosch-quietcastbrakepads.jpg" });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 10,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "\\images\\thumbnails\\mini-hikari-ledheadlights.jpg", "\\images\\hikari-ledheadlights.jpg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 1,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "~\\images\\thumbnails\\mini-motorcraft-sparkplug.jpg", "~\\images\\motorcraft-sparkplug.jpg" });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 2,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "~\\images\\thumbnails\\mini-gates-timmingbelt.jpg", "~\\images\\gates-timmingbelt.jpg" });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 3,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "~\\images\\thumbnails\\mini-gmb-waterpump.jpg", "~\\images\\gmb-waterpump.jpg" });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 4,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "~\\images\\thumbnails\\mini-gates-tensioner.jpg", "~\\images\\gates-tensioner.jpg" });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 5,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "~\\images\\thumbnails\\mini-map-coilsprings.jpg", "~\\images\\map-coilsprings.jpg" });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 6,
                columns: new[] { "Created", "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { new DateTime(2020, 7, 28, 3, 42, 35, 140, DateTimeKind.Local).AddTicks(3277), "~\\images\\thumbnails\\mini-kyb-strutboot.jpg", "~\\images\\kyb-strutboot.jpg" });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 7,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "~\\images\\thumbnails\\mini-hawk-brakepad.jpg", "~\\images\\hawk-brakepad.jpg" });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 8,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "~\\images\\thumbnails\\mini-bosch-quietcastdiscrotor.jpg", "~\\images\\bosch-quietcastdiscrotor.jpg" });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 9,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "~\\images\\thumbnails\\mini-bosch-quietcastbrakepads.jpg", "~\\images\\bosch-quietcastbrakepads.jpg" });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 10,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "~\\images\\thumbnails\\mini-hikari-ledheadlights.jpg", "~\\images\\hikari-ledheadlights.jpg" });
        }
    }
}
