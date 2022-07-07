using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SotkonTestProject.Migrations
{
    public partial class init4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Records",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BanId = table.Column<int>(type: "int", nullable: true),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CurrentPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NextPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Records", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Records_Bans_BanId",
                        column: x => x.BanId,
                        principalTable: "Bans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Records_BanId",
                table: "Records",
                column: "BanId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Records");
        }
    }
}
