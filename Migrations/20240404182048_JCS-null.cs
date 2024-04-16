using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BleebosBistro.Migrations
{
    public partial class JCSnull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PaymentType",
                table: "Orders",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1001,
                column: "Date",
                value: new DateTime(2024, 4, 4, 13, 20, 48, 428, DateTimeKind.Local).AddTicks(9077));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1002,
                column: "Date",
                value: new DateTime(2024, 4, 3, 13, 20, 48, 428, DateTimeKind.Local).AddTicks(9119));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PaymentType",
                table: "Orders",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1001,
                column: "Date",
                value: new DateTime(2024, 4, 4, 13, 18, 39, 26, DateTimeKind.Local).AddTicks(3915));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1002,
                column: "Date",
                value: new DateTime(2024, 4, 3, 13, 18, 39, 26, DateTimeKind.Local).AddTicks(3952));
        }
    }
}
