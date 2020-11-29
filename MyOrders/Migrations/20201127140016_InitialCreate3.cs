using Microsoft.EntityFrameworkCore.Migrations;

namespace MyOrders.Migrations
{
    public partial class InitialCreate3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CargoWeight",
                table: "Order",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "CargoWeight",
                table: "Order",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int));
        }
    }
}
