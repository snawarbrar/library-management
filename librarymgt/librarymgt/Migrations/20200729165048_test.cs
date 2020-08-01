using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace librarymgt.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookIssueds_Students_StudentId1",
                table: "BookIssueds");

            migrationBuilder.DropForeignKey(
                name: "FK_BookIssueds_Students_StudentId2",
                table: "BookIssueds");

            migrationBuilder.DropIndex(
                name: "IX_BookIssueds_StudentId2",
                table: "BookIssueds");

            migrationBuilder.DropColumn(
                name: "StudentId2",
                table: "BookIssueds");

            migrationBuilder.RenameColumn(
                name: "StudentId1",
                table: "BookIssueds",
                newName: "StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_BookIssueds_StudentId1",
                table: "BookIssueds",
                newName: "IX_BookIssueds_StudentId");

            migrationBuilder.AddColumn<DateTime>(
                name: "ReturnDate",
                table: "BookIssueds",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddForeignKey(
                name: "FK_BookIssueds_Students_StudentId",
                table: "BookIssueds",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookIssueds_Students_StudentId",
                table: "BookIssueds");

            migrationBuilder.DropColumn(
                name: "ReturnDate",
                table: "BookIssueds");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "BookIssueds",
                newName: "StudentId1");

            migrationBuilder.RenameIndex(
                name: "IX_BookIssueds_StudentId",
                table: "BookIssueds",
                newName: "IX_BookIssueds_StudentId1");

            migrationBuilder.AddColumn<int>(
                name: "StudentId2",
                table: "BookIssueds",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_BookIssueds_StudentId2",
                table: "BookIssueds",
                column: "StudentId2");

            migrationBuilder.AddForeignKey(
                name: "FK_BookIssueds_Students_StudentId1",
                table: "BookIssueds",
                column: "StudentId1",
                principalTable: "Students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookIssueds_Students_StudentId2",
                table: "BookIssueds",
                column: "StudentId2",
                principalTable: "Students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
