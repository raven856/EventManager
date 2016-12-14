using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EventManager.Migrations
{
    public partial class m2m : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AttendanceTags",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    EventId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttendanceTags", x => new { x.UserId, x.EventId });
                    table.ForeignKey(
                        name: "FK_AttendanceTags_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AttendanceTags_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FollowingTags",
                columns: table => new
                {
                    followerId = table.Column<string>(nullable: false),
                    followeeId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FollowingTags", x => new { x.followerId, x.followeeId });
                    table.ForeignKey(
                        name: "FK_FollowingTags_AspNetUsers_followeeId",
                        column: x => x.followeeId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id"
                        //,onDelete: ReferentialAction.Cascade
                        );
                    table.ForeignKey(
                        name: "FK_FollowingTags_AspNetUsers_followerId",
                        column: x => x.followerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id"
                        //,onDelete: ReferentialAction.Cascade
                        );
                });

            migrationBuilder.CreateIndex(
                name: "IX_AttendanceTags_EventId",
                table: "AttendanceTags",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_AttendanceTags_UserId",
                table: "AttendanceTags",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_FollowingTags_followeeId",
                table: "FollowingTags",
                column: "followeeId");

            migrationBuilder.CreateIndex(
                name: "IX_FollowingTags_followerId",
                table: "FollowingTags",
                column: "followerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AttendanceTags");

            migrationBuilder.DropTable(
                name: "FollowingTags");
        }
    }
}
