using Microsoft.EntityFrameworkCore.Migrations;

namespace Pixieset.Migrations
{
    public partial class CreateImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Made");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Made");

            migrationBuilder.DropColumn(
                name: "Text2",
                table: "ExampleActions");

            migrationBuilder.AddColumn<string>(
                name: "Image1",
                table: "Made",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image2",
                table: "Made",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image3",
                table: "Made",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image4",
                table: "Made",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name1",
                table: "Made",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name2",
                table: "Made",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name3",
                table: "Made",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name4",
                table: "Made",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "ExampleActions",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image1",
                table: "Made");

            migrationBuilder.DropColumn(
                name: "Image2",
                table: "Made");

            migrationBuilder.DropColumn(
                name: "Image3",
                table: "Made");

            migrationBuilder.DropColumn(
                name: "Image4",
                table: "Made");

            migrationBuilder.DropColumn(
                name: "Name1",
                table: "Made");

            migrationBuilder.DropColumn(
                name: "Name2",
                table: "Made");

            migrationBuilder.DropColumn(
                name: "Name3",
                table: "Made");

            migrationBuilder.DropColumn(
                name: "Name4",
                table: "Made");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "ExampleActions");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Made",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Made",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Text2",
                table: "ExampleActions",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
