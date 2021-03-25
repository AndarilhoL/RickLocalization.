using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RickLocalization.Persistence.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Morties",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    UrlImage = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Morties", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ricks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    UrlImage = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ricks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Dimensions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    UrlImage = table.Column<string>(type: "TEXT", nullable: true),
                    MortyId = table.Column<Guid>(type: "TEXT", nullable: false),
                    RickId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dimensions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dimensions_Morties_MortyId",
                        column: x => x.MortyId,
                        principalTable: "Morties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Dimensions_Ricks_RickId",
                        column: x => x.RickId,
                        principalTable: "Ricks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dimensions_MortyId",
                table: "Dimensions",
                column: "MortyId");

            migrationBuilder.CreateIndex(
                name: "IX_Dimensions_RickId",
                table: "Dimensions",
                column: "RickId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dimensions");

            migrationBuilder.DropTable(
                name: "Morties");

            migrationBuilder.DropTable(
                name: "Ricks");
        }
    }
}
