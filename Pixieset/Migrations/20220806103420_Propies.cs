using Microsoft.EntityFrameworkCore.Migrations;

namespace Pixieset.Migrations
{
    public partial class Propies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MadeImage1",
                table: "ExampleActions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MadeImage2",
                table: "ExampleActions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MadeImage3",
                table: "ExampleActions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MadeImage4",
                table: "ExampleActions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MadeImagename1",
                table: "ExampleActions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MadeImagename2",
                table: "ExampleActions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MadeImagename3",
                table: "ExampleActions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MadeImagename4",
                table: "ExampleActions",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MadeImage1",
                table: "ExampleActions");

            migrationBuilder.DropColumn(
                name: "MadeImage2",
                table: "ExampleActions");

            migrationBuilder.DropColumn(
                name: "MadeImage3",
                table: "ExampleActions");

            migrationBuilder.DropColumn(
                name: "MadeImage4",
                table: "ExampleActions");

            migrationBuilder.DropColumn(
                name: "MadeImagename1",
                table: "ExampleActions");

            migrationBuilder.DropColumn(
                name: "MadeImagename2",
                table: "ExampleActions");

            migrationBuilder.DropColumn(
                name: "MadeImagename3",
                table: "ExampleActions");

            migrationBuilder.DropColumn(
                name: "MadeImagename4",
                table: "ExampleActions");
        }
    }
}
