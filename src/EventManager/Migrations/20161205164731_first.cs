using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EventManager.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    artistId = table.Column<string>(nullable: true),
                    date = table.Column<DateTime>(nullable: false),
                    description = table.Column<string>(nullable: true),
                    genre = table.Column<string>(nullable: true),
                    isCanceled = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.id);
                    table.ForeignKey(
                        name: "FK_Events_AspNetUsers_artistId",
                        column: x => x.artistId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.AddColumn<string>(
                name: "bio",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "name",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Events_artistId",
                table: "Events",
                column: "artistId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "bio",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "name",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Events");
        }
    }
}
