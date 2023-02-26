using Microsoft.EntityFrameworkCore.Migrations;

namespace DashBoardT.Migrations
{
    public partial class m9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "cvname",
                table: "employee",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "photoname",
                table: "employee",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "cvname",
                table: "employee");

            migrationBuilder.DropColumn(
                name: "photoname",
                table: "employee");
        }
    }
}
