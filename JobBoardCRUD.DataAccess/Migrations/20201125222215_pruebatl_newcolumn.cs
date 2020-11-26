using Microsoft.EntityFrameworkCore.Migrations;

namespace JobBoardCRUD.DataAccess.Migrations
{
    public partial class pruebatl_newcolumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "mipropiedad",
                table: "Pruebatl",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "mipropiedad",
                table: "Pruebatl");
        }
    }
}
