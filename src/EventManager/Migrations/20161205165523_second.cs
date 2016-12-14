using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EventManager.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_AspNetUsers_artistId",
                table: "Events");

            migrationBuilder.DropIndex(
                name: "IX_Events_artistId",
                table: "Events");

            migrationBuilder.AddColumn<string>(
                name: "artistId1",
                table: "Events",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "artistId",
                table: "Events",
                nullable: false);

            migrationBuilder.CreateIndex(
                name: "IX_Events_artistId1",
                table: "Events",
                column: "artistId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_AspNetUsers_artistId1",
                table: "Events",
                column: "artistId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_AspNetUsers_artistId1",
                table: "Events");

            migrationBuilder.DropIndex(
                name: "IX_Events_artistId1",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "artistId1",
                table: "Events");

            migrationBuilder.AlterColumn<string>(
                name: "artistId",
                table: "Events",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Events_artistId",
                table: "Events",
                column: "artistId");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_AspNetUsers_artistId",
                table: "Events",
                column: "artistId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
