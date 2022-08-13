using Microsoft.EntityFrameworkCore.Migrations;

namespace Pixieset.Migrations
{
    public partial class CreateFlowTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_socialicons_socialmedias_SocialmediasId",
                table: "socialicons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_socialmedias",
                table: "socialmedias");

            migrationBuilder.DropPrimaryKey(
                name: "PK_socialicons",
                table: "socialicons");

            migrationBuilder.RenameTable(
                name: "socialmedias",
                newName: "Socialmedias");

            migrationBuilder.RenameTable(
                name: "socialicons",
                newName: "Socialicons");

            migrationBuilder.RenameIndex(
                name: "IX_socialicons_SocialmediasId",
                table: "Socialicons",
                newName: "IX_Socialicons_SocialmediasId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Socialmedias",
                table: "Socialmedias",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Socialicons",
                table: "Socialicons",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Flows",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FlowTitle = table.Column<string>(nullable: true),
                    FlowRight = table.Column<string>(nullable: true),
                    FlowText = table.Column<string>(nullable: true),
                    FlowImage = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flows", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Socialicons_Socialmedias_SocialmediasId",
                table: "Socialicons",
                column: "SocialmediasId",
                principalTable: "Socialmedias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Socialicons_Socialmedias_SocialmediasId",
                table: "Socialicons");

            migrationBuilder.DropTable(
                name: "Flows");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Socialmedias",
                table: "Socialmedias");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Socialicons",
                table: "Socialicons");

            migrationBuilder.RenameTable(
                name: "Socialmedias",
                newName: "socialmedias");

            migrationBuilder.RenameTable(
                name: "Socialicons",
                newName: "socialicons");

            migrationBuilder.RenameIndex(
                name: "IX_Socialicons_SocialmediasId",
                table: "socialicons",
                newName: "IX_socialicons_SocialmediasId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_socialmedias",
                table: "socialmedias",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_socialicons",
                table: "socialicons",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_socialicons_socialmedias_SocialmediasId",
                table: "socialicons",
                column: "SocialmediasId",
                principalTable: "socialmedias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
