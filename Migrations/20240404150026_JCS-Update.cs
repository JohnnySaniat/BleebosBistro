using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BleebosBistro.Migrations
{
    public partial class JCSUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "isClosed",
                table: "Orders",
                newName: "IsClosed");

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1001,
                column: "Date",
                value: new DateTime(2024, 4, 4, 10, 0, 26, 590, DateTimeKind.Local).AddTicks(7375));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1002,
                column: "Date",
                value: new DateTime(2024, 4, 3, 10, 0, 26, 590, DateTimeKind.Local).AddTicks(7413));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsClosed",
                table: "Orders",
                newName: "isClosed");

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1001,
                column: "Date",
                value: new DateTime(2024, 4, 4, 8, 39, 27, 910, DateTimeKind.Local).AddTicks(1919));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1002,
                column: "Date",
                value: new DateTime(2024, 4, 3, 8, 39, 27, 910, DateTimeKind.Local).AddTicks(1956));
        }
    }
}
