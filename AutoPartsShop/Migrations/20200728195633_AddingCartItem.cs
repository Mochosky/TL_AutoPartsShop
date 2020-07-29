using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AutoPartsShop.Migrations
{
    public partial class AddingCartItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    CartItemId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CartId = table.Column<string>(nullable: true),
                    PartId = table.Column<int>(nullable: true),
                    Quantity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => x.CartItemId);
                    table.ForeignKey(
                        name: "FK_CartItems_Parts_PartId",
                        column: x => x.PartId,
                        principalTable: "Parts",
                        principalColumn: "PartId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2020, 7, 28, 14, 56, 32, 694, DateTimeKind.Local).AddTicks(9666));

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_PartId",
                table: "CartItems",
                column: "PartId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "PartId",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2020, 7, 28, 3, 58, 35, 511, DateTimeKind.Local).AddTicks(5836));
        }
    }
}
