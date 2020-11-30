using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyOrders.Migrations
{
    public partial class Initital : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CitySender = table.Column<string>(nullable: false),
                    AddressSender = table.Column<string>(nullable: false),
                    CityRecipient = table.Column<string>(nullable: false),
                    AddressRecipient = table.Column<string>(nullable: false),
                    CargoWeight = table.Column<int>(nullable: false),
                    DateReceipt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Order");
        }
    }
}
