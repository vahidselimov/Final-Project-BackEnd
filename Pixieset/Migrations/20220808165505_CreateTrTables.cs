using Microsoft.EntityFrameworkCore.Migrations;

namespace Pixieset.Migrations
{
    public partial class CreateTrTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TrNames",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrNames", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TrIcons",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IconsName = table.Column<string>(nullable: true),
                    TrNameId = table.Column<int>(nullable: true),
                    TrId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrIcons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrIcons_TrNames_TrNameId",
                        column: x => x.TrNameId,
                        principalTable: "TrNames",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TrIcons_TrNameId",
                table: "TrIcons",
                column: "TrNameId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TrIcons");

            migrationBuilder.DropTable(
                name: "TrNames");
        }
    }
}
