using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SotkonTestProject.Migrations
{
    public partial class init1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DropTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    ControlSaleTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    BanType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bans", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bans");
        }
    }
}
