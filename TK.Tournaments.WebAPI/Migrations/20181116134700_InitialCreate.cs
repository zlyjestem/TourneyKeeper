using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TK.Tournaments.WebAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tournaments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 80, nullable: false),
                    City = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    StartDateTime = table.Column<DateTime>(nullable: false),
                    EndDateTime = table.Column<DateTime>(nullable: false),
                    Price = table.Column<float>(nullable: false),
                    Currency = table.Column<string>(nullable: true),
                    SwissRounds = table.Column<int>(nullable: false),
                    IfTopCut = table.Column<bool>(nullable: false),
                    SizeOfTopCut = table.Column<int>(nullable: false),
                    IfProgressiveCut = table.Column<bool>(nullable: false),
                    WinsNeededForProgressiveCut = table.Column<int>(nullable: false),
                    Venue = table.Column<string>(nullable: true),
                    Adress = table.Column<string>(nullable: true),
                    StreamLink = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tournaments", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tournaments");
        }
    }
}
