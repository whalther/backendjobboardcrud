using Microsoft.EntityFrameworkCore.Migrations;

namespace JobBoardCRUD.DataAccess.Migrations
{
    public partial class tf : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TempField",
                table: "Job",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TempField",
                table: "Job");
        }
    }
}
