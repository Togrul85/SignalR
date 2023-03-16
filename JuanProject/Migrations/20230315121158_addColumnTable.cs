using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JuanProject.Migrations
{
    public partial class addColumnTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "İmageUrl",
                table: "Blogs",
                newName: "ImageUrl");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Blogs",
                newName: "İmageUrl");
        }
    }
}
