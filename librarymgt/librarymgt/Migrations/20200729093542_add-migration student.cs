using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace librarymgt.Migrations
{
    public partial class addmigrationstudent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_BookCategories_BookCategoryId",
                table: "Books");

            migrationBuilder.RenameColumn(
                name: "BookCategoryId",
                table: "Books",
                newName: "bookCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Books_BookCategoryId",
                table: "Books",
                newName: "IX_Books_bookCategoryId");

            migrationBuilder.AlterColumn<int>(
                name: "bookCategoryId",
                table: "Books",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RollNumber = table.Column<string>(maxLength: 5, nullable: false),
                    StuName = table.Column<string>(nullable: false),
                    StuEmail = table.Column<string>(nullable: false),
                    Course = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                });

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

            migrationBuilder.AddForeignKey(
                name: "FK_Books_BookCategories_bookCategoryId",
                table: "Books",
                column: "bookCategoryId",
                principalTable: "BookCategories",
                principalColumn: "BookCategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_BookCategories_bookCategoryId",
                table: "Books");

            migrationBuilder.DropTable(
                name: "BookIssueds");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.RenameColumn(
                name: "bookCategoryId",
                table: "Books",
                newName: "BookCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Books_bookCategoryId",
                table: "Books",
                newName: "IX_Books_BookCategoryId");

            migrationBuilder.AlterColumn<int>(
                name: "BookCategoryId",
                table: "Books",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Books_BookCategories_BookCategoryId",
                table: "Books",
                column: "BookCategoryId",
                principalTable: "BookCategories",
                principalColumn: "BookCategoryId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
