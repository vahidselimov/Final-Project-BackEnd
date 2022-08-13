using Microsoft.EntityFrameworkCore.Migrations;

namespace Pixieset.Migrations
{
    public partial class createprop : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image2",
                table: "Slider",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Small2",
                table: "Slider",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Text3",
                table: "Slider",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Text4",
                table: "Slider",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image2",
                table: "Slider");

            migrationBuilder.DropColumn(
                name: "Small2",
                table: "Slider");

            migrationBuilder.DropColumn(
                name: "Text3",
                table: "Slider");

            migrationBuilder.DropColumn(
                name: "Text4",
                table: "Slider");
        }
    }
}
