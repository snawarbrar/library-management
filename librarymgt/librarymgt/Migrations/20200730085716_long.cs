using Microsoft.EntityFrameworkCore.Migrations;

namespace librarymgt.Migrations
{
    public partial class @long : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "ISBN",
                table: "Books",
                nullable: false,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ISBN",
                table: "Books",
                nullable: false,
                oldClrType: typeof(long));
        }
    }
}
