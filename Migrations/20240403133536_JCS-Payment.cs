using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BleebosBistro.Migrations
{
    public partial class JCSPayment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PaymentType",
                table: "Orders",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1001,
                columns: new[] { "Date", "PaymentType" },
                values: new object[] { new DateTime(2024, 4, 3, 8, 35, 36, 536, DateTimeKind.Local).AddTicks(9341), "Credit" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1002,
                columns: new[] { "Date", "PaymentType" },
                values: new object[] { new DateTime(2024, 4, 2, 8, 35, 36, 536, DateTimeKind.Local).AddTicks(9380), "Cash" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PaymentType",
                table: "Orders");

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
        }
    }
}
