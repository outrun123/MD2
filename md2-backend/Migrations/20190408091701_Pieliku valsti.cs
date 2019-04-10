using Microsoft.EntityFrameworkCore.Migrations;

namespace md2backend.Migrations
{
    public partial class Pielikuvalsti : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "valsts",
                table: "Properties",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "valsts",
                table: "Properties");
        }
    }
}
