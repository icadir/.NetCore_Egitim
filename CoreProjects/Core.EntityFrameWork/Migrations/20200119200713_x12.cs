using Microsoft.EntityFrameworkCore.Migrations;

namespace Core.EntityFrameWork.Migrations
{
    public partial class x12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Stok",
                table: "Products",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Stok",
                table: "Products");
        }
    }
}
