using Microsoft.EntityFrameworkCore.Migrations;

namespace Pixieset.Migrations
{
    public partial class CreateTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "socialmedias",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Text = table.Column<string>(nullable: true),
                    Right = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Span1 = table.Column<string>(nullable: true),
                    Span2 = table.Column<string>(nullable: true),
                    Span3 = table.Column<string>(nullable: true),
                    Icon1 = table.Column<string>(nullable: true),
                    Icon2 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_socialmedias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "socialicons",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SocialmediasId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_socialicons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_socialicons_socialmedias_SocialmediasId",
                        column: x => x.SocialmediasId,
                        principalTable: "socialmedias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_socialicons_SocialmediasId",
                table: "socialicons",
                column: "SocialmediasId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "socialicons");

            migrationBuilder.DropTable(
                name: "socialmedias");
        }
    }
}
