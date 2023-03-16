using Microsoft.EntityFrameworkCore.Migrations;

namespace Car.DataAccess.Migrations
{
    public partial class resim : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Resim",
                table: "Arabalar",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Resim",
                table: "Arabalar");
        }
    }
}
