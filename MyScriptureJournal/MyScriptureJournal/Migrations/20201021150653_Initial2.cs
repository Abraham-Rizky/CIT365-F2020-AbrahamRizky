using Microsoft.EntityFrameworkCore.Migrations;

namespace MyScriptureJournal.Migrations
{
    public partial class Initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ReleaseDate",
                table: "Scripture",
                newName: "Date");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Scripture",
                newName: "ReleaseDate");
        }
    }
}
