using Microsoft.EntityFrameworkCore.Migrations;

namespace Pixieset.Migrations
{
    public partial class CIconsTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IconName",
                table: "CIcons");

            migrationBuilder.AddColumn<int>(
                name: "CIconsId",
                table: "TrIcons",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TrIcons_CIconsId",
                table: "TrIcons",
                column: "CIconsId");

            migrationBuilder.AddForeignKey(
                name: "FK_TrIcons_CIcons_CIconsId",
                table: "TrIcons",
                column: "CIconsId",
                principalTable: "CIcons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TrIcons_CIcons_CIconsId",
                table: "TrIcons");

            migrationBuilder.DropIndex(
                name: "IX_TrIcons_CIconsId",
                table: "TrIcons");

            migrationBuilder.DropColumn(
                name: "CIconsId",
                table: "TrIcons");

            migrationBuilder.AddColumn<string>(
                name: "IconName",
                table: "CIcons",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
