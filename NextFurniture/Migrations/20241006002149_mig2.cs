using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NextFurniture.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Star",
                table: "Comments",
                type: "float",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Star",
                table: "Comments",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");
        }
    }
}
