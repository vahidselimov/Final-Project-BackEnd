using Microsoft.EntityFrameworkCore.Migrations;

namespace Pixieset.Migrations
{
    public partial class ConCDR : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CDRId",
                table: "TrIcons",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TrIcons_CDRId",
                table: "TrIcons",
                column: "CDRId");

            migrationBuilder.AddForeignKey(
                name: "FK_TrIcons_CDRs_CDRId",
                table: "TrIcons",
                column: "CDRId",
                principalTable: "CDRs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TrIcons_CDRs_CDRId",
                table: "TrIcons");

            migrationBuilder.DropIndex(
                name: "IX_TrIcons_CDRId",
                table: "TrIcons");

            migrationBuilder.DropColumn(
                name: "CDRId",
                table: "TrIcons");
        }
    }
}
