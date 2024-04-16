using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BleebosBistro.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    Image = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    isClosed = table.Column<bool>(type: "boolean", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    IsOnline = table.Column<bool>(type: "boolean", nullable: false),
                    Subtotal = table.Column<int>(type: "integer", nullable: false),
                    Tip = table.Column<int>(type: "integer", nullable: false),
                    Total = table.Column<int>(type: "integer", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Image = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Uid = table.Column<string>(type: "text", nullable: false),
                    Username = table.Column<int>(type: "integer", nullable: false),
                    IsColleague = table.Column<string>(type: "text", nullable: false),
                    Image = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Image", "Name", "Price" },
                values: new object[,]
                {
                    { 101, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTULR06hbIXK3efBfwg0eJon8_z9CcU7srRmQqL-gRglQ&s", "Shrugbo", 100m },
                    { 102, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSrh1BIMheVzZsb7AUHvPlGo9QTSKdSvLPLFw&s", "Trenboodoo", 150m },
                    { 103, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT8iROIB-DTfaO0Tzke6ErgcaBR6V10C3xfEw&s", "Salad", 50m }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Date", "Email", "FirstName", "Image", "IsOnline", "isClosed", "LastName", "Subtotal", "Tip", "Total" },
                values: new object[,]
                {
                    { 1001, new DateTime(2024, 4, 2, 11, 36, 46, 800, DateTimeKind.Local).AddTicks(6354), "gertyherdy@example.com", "Darbin", "https://i.ibb.co/kqvY0KX/Bleebos-Bistro-Order2.png", true, true, "Glowbone", 2000, 300, 2300 },
                    { 1002, new DateTime(2024, 4, 1, 11, 36, 46, 800, DateTimeKind.Local).AddTicks(6393), "goober@example.com", "Phil", "https://i.ibb.co/kqvY0KX/Bleebos-Bistro-Order2.png", false, false, "Doctor", 1500, 200, 1700 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Image", "IsColleague", "Uid", "Username" },
                values: new object[,]
                {
                    { 1, "https://avatarfiles.alphacoders.com/113/113469.jpg", "Yes", "WFKkg9zIyfT36VTlUrxbLXhknJV2", 200201 },
                    { 2, "https://imagedelivery.net/9sCnq8t6WEGNay0RAQNdvQ/UUID-cl9g4rv6p4471q8nfruthlmio/public", "No", "WFKkg9zIyfT36VTlUrxbLXhknJV3", 200202 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
