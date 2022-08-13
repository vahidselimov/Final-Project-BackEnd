using Microsoft.EntityFrameworkCore.Migrations;

namespace Pixieset.Migrations
{
    public partial class CreateWebsiteTrTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WebsitesNames",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WebsitesNames", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WebsitesIcons",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    WebsiteNameTrId = table.Column<int>(nullable: true),
                    WebsiteNameId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WebsitesIcons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WebsitesIcons_WebsitesNames_WebsiteNameTrId",
                        column: x => x.WebsiteNameTrId,
                        principalTable: "WebsitesNames",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WebsitesIcons_WebsiteNameTrId",
                table: "WebsitesIcons",
                column: "WebsiteNameTrId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WebsitesIcons");

            migrationBuilder.DropTable(
                name: "WebsitesNames");
        }
    }
}
