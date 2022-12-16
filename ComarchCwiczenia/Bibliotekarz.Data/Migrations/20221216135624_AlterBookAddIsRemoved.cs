using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bibliotekarz.Data.Migrations
{
    public partial class AlterBookAddIsRemoved : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsRemoved",
                table: "Books",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsRemoved",
                table: "Books");
        }
    }
}
