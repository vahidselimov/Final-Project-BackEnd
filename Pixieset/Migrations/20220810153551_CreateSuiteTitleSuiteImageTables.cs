using Microsoft.EntityFrameworkCore.Migrations;

namespace Pixieset.Migrations
{
    public partial class CreateSuiteTitleSuiteImageTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SuiteTitles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuiteTitles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SuiteImages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(nullable: true),
                    SuiteTitleId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuiteImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SuiteImages_SuiteTitles_SuiteTitleId",
                        column: x => x.SuiteTitleId,
                        principalTable: "SuiteTitles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SuiteImages_SuiteTitleId",
                table: "SuiteImages",
                column: "SuiteTitleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SuiteImages");

            migrationBuilder.DropTable(
                name: "SuiteTitles");
        }
    }
}
