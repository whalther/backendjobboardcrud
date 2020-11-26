using Microsoft.EntityFrameworkCore.Migrations;

namespace JobBoardCRUD.DataAccess.Migrations
{
    public partial class new_column_status : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "JobStatus",
                table: "Job",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JobStatus",
                table: "Job");
        }
    }
}
