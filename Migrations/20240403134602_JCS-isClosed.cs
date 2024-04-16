using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BleebosBistro.Migrations
{
    public partial class JCSisClosed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1001,
                column: "Date",
                value: new DateTime(2024, 4, 3, 8, 46, 2, 802, DateTimeKind.Local).AddTicks(9200));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1002,
                column: "Date",
                value: new DateTime(2024, 4, 2, 8, 46, 2, 802, DateTimeKind.Local).AddTicks(9239));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1001,
                column: "Date",
                value: new DateTime(2024, 4, 3, 8, 35, 36, 536, DateTimeKind.Local).AddTicks(9341));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1002,
                column: "Date",
                value: new DateTime(2024, 4, 2, 8, 35, 36, 536, DateTimeKind.Local).AddTicks(9380));
        }
    }
}
