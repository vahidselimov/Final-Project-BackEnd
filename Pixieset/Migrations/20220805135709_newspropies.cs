using Microsoft.EntityFrameworkCore.Migrations;

namespace Pixieset.Migrations
{
    public partial class newspropies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Small",
                table: "ExamplesRows");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "ExamplesRows");

            migrationBuilder.AddColumn<string>(
                name: "Image2",
                table: "ExamplesRows",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image3",
                table: "ExamplesRows",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Small1",
                table: "ExamplesRows",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Small2",
                table: "ExamplesRows",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Small3",
                table: "ExamplesRows",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title1",
                table: "ExamplesRows",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title2",
                table: "ExamplesRows",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title3",
                table: "ExamplesRows",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image2",
                table: "ExamplesRows");

            migrationBuilder.DropColumn(
                name: "Image3",
                table: "ExamplesRows");

            migrationBuilder.DropColumn(
                name: "Small1",
                table: "ExamplesRows");

            migrationBuilder.DropColumn(
                name: "Small2",
                table: "ExamplesRows");

            migrationBuilder.DropColumn(
                name: "Small3",
                table: "ExamplesRows");

            migrationBuilder.DropColumn(
                name: "Title1",
                table: "ExamplesRows");

            migrationBuilder.DropColumn(
                name: "Title2",
                table: "ExamplesRows");

            migrationBuilder.DropColumn(
                name: "Title3",
                table: "ExamplesRows");

            migrationBuilder.AddColumn<string>(
                name: "Small",
                table: "ExamplesRows",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "ExamplesRows",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
