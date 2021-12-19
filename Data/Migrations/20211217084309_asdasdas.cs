using Microsoft.EntityFrameworkCore.Migrations;

namespace GymT110Asp.Data.Migrations
{
    public partial class asdasdas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "GymDay",
                table: "Schedules",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Schedules",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Trainer",
                table: "Schedules",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GymDay",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "Trainer",
                table: "Schedules");
        }
    }
}
