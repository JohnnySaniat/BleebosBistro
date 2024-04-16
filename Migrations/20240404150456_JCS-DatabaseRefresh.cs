using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BleebosBistro.Migrations
{
    public partial class JCSDatabaseRefresh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1001,
                column: "Date",
                value: new DateTime(2024, 4, 4, 10, 4, 55, 795, DateTimeKind.Local).AddTicks(3435));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1002,
                column: "Date",
                value: new DateTime(2024, 4, 3, 10, 4, 55, 795, DateTimeKind.Local).AddTicks(3472));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1001,
                column: "Date",
                value: new DateTime(2024, 4, 4, 10, 1, 13, 755, DateTimeKind.Local).AddTicks(4207));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1002,
                column: "Date",
                value: new DateTime(2024, 4, 3, 10, 1, 13, 755, DateTimeKind.Local).AddTicks(4243));
        }
    }
}
