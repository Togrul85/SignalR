using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JuanProject.Migrations
{
    public partial class addConnectionIdAppUserTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ConnectionId",
                table: "AppUser",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConnectionId",
                table: "AppUser");
        }
    }
}
