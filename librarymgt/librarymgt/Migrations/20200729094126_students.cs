using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace librarymgt.Migrations
{
    public partial class students : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BookIssueds",
                columns: table => new
                {
                    BookIssuedId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BookId = table.Column<int>(nullable: false),
                    StudentId1 = table.Column<int>(nullable: false),
                    StudentId2 = table.Column<int>(nullable: true),
                    issueDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookIssueds", x => x.BookIssuedId);
                    table.ForeignKey(
                        name: "FK_BookIssueds_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookIssueds_Students_StudentId1",
                        column: x => x.StudentId1,
                        principalTable: "Students",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookIssueds_Students_StudentId2",
                        column: x => x.StudentId2,
                        principalTable: "Students",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookIssueds_BookId",
                table: "BookIssueds",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BookIssueds_StudentId1",
                table: "BookIssueds",
                column: "StudentId1");

            migrationBuilder.CreateIndex(
                name: "IX_BookIssueds_StudentId2",
                table: "BookIssueds",
                column: "StudentId2");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookIssueds");
        }
    }
}
