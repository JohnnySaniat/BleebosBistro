using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BleebosBistro.Migrations
{
    public partial class JCSiCollection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsOnline",
                table: "Orders");

            migrationBuilder.CreateTable(
                name: "ItemOrder",
                columns: table => new
                {
                    ItemsId = table.Column<int>(type: "integer", nullable: false),
                    OrdersId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemOrder", x => new { x.ItemsId, x.OrdersId });
                    table.ForeignKey(
                        name: "FK_ItemOrder_Items_ItemsId",
                        column: x => x.ItemsId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemOrder_Orders_OrdersId",
                        column: x => x.OrdersId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1001,
                column: "Date",
                value: new DateTime(2024, 4, 2, 19, 8, 55, 376, DateTimeKind.Local).AddTicks(4296));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1002,
                column: "Date",
                value: new DateTime(2024, 4, 1, 19, 8, 55, 376, DateTimeKind.Local).AddTicks(4339));

            migrationBuilder.CreateIndex(
                name: "IX_ItemOrder_OrdersId",
                table: "ItemOrder",
                column: "OrdersId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemOrder");

            migrationBuilder.AddColumn<bool>(
                name: "IsOnline",
                table: "Orders",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1001,
                columns: new[] { "Date", "IsOnline" },
                values: new object[] { new DateTime(2024, 4, 2, 11, 36, 46, 800, DateTimeKind.Local).AddTicks(6354), true });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1002,
                column: "Date",
                value: new DateTime(2024, 4, 1, 11, 36, 46, 800, DateTimeKind.Local).AddTicks(6393));
        }
    }
}
