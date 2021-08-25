using Microsoft.EntityFrameworkCore.Migrations;

namespace TucBil.Migrations
{
    public partial class Addedregno : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RegNo",
                table: "Bilar",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RegNo",
                table: "Bilar");
        }
    }
}
