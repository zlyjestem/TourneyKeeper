using Microsoft.EntityFrameworkCore.Migrations;

namespace TK.Tournaments.WebAPI.Migrations
{
    public partial class _2ndIteration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Format",
                table: "Tournaments",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Format",
                table: "Tournaments");
        }
    }
}
