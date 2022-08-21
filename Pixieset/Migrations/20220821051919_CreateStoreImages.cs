using Microsoft.EntityFrameworkCore.Migrations;

namespace Pixieset.Migrations
{
    public partial class CreateStoreImages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StoreAutoImagesNames",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoreAutoImagesNames", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StoreAutoImages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(nullable: true),
                    NameId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoreAutoImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StoreAutoImages_StoreAutoImagesNames_NameId",
                        column: x => x.NameId,
                        principalTable: "StoreAutoImagesNames",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StoreAutoImages_NameId",
                table: "StoreAutoImages",
                column: "NameId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StoreAutoImages");

            migrationBuilder.DropTable(
                name: "StoreAutoImagesNames");
        }
    }
}
