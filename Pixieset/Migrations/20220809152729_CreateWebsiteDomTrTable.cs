using Microsoft.EntityFrameworkCore.Migrations;

namespace Pixieset.Migrations
{
    public partial class CreateWebsiteDomTrTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "WebsiteDomId",
                table: "WebsitesIcons",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WebsiteDomTrId",
                table: "WebsitesIcons",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "WebsiteDomTr",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WebsiteDomTr", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WebsitesIcons_WebsiteDomTrId",
                table: "WebsitesIcons",
                column: "WebsiteDomTrId");

            migrationBuilder.AddForeignKey(
                name: "FK_WebsitesIcons_WebsiteDomTr_WebsiteDomTrId",
                table: "WebsitesIcons",
                column: "WebsiteDomTrId",
                principalTable: "WebsiteDomTr",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WebsitesIcons_WebsiteDomTr_WebsiteDomTrId",
                table: "WebsitesIcons");

            migrationBuilder.DropTable(
                name: "WebsiteDomTr");

            migrationBuilder.DropIndex(
                name: "IX_WebsitesIcons_WebsiteDomTrId",
                table: "WebsitesIcons");

            migrationBuilder.DropColumn(
                name: "WebsiteDomId",
                table: "WebsitesIcons");

            migrationBuilder.DropColumn(
                name: "WebsiteDomTrId",
                table: "WebsitesIcons");
        }
    }
}
