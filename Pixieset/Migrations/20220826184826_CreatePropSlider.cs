using Microsoft.EntityFrameworkCore.Migrations;

namespace Pixieset.Migrations
{
    public partial class CreatePropSlider : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discount",
                table: "Slider",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DiscoverUrl",
                table: "Slider",
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "Order",
                table: "Slider",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.CreateTable(
                name: "CategoryVM",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryVM", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CreateCategoryVM",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreateCategoryVM", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EditCategoryVM",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EditCategoryVM", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryVM");

            migrationBuilder.DropTable(
                name: "CreateCategoryVM");

            migrationBuilder.DropTable(
                name: "EditCategoryVM");

            migrationBuilder.DropColumn(
                name: "Discount",
                table: "Slider");

            migrationBuilder.DropColumn(
                name: "DiscoverUrl",
                table: "Slider");

            migrationBuilder.DropColumn(
                name: "Order",
                table: "Slider");
        }
    }
}
