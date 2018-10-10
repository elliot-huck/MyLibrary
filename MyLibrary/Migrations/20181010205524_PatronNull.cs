using Microsoft.EntityFrameworkCore.Migrations;

namespace MyLibrary.Migrations
{
    public partial class PatronNull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Patron_PatronId",
                table: "Book");

            migrationBuilder.AlterColumn<int>(
                name: "PatronId",
                table: "Book",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Patron_PatronId",
                table: "Book",
                column: "PatronId",
                principalTable: "Patron",
                principalColumn: "PatronId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Patron_PatronId",
                table: "Book");

            migrationBuilder.AlterColumn<int>(
                name: "PatronId",
                table: "Book",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Patron_PatronId",
                table: "Book",
                column: "PatronId",
                principalTable: "Patron",
                principalColumn: "PatronId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
