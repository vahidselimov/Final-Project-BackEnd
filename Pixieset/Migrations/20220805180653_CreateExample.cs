using Microsoft.EntityFrameworkCore.Migrations;

namespace Pixieset.Migrations
{
    public partial class CreateExample : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ExampleActions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Text = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Text2 = table.Column<string>(nullable: true),
                    MadeTitle = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExampleActions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Made",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Image = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Made", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ActionsIcons",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Icon1 = table.Column<string>(nullable: true),
                    Icon2 = table.Column<string>(nullable: true),
                    Span = table.Column<string>(nullable: true),
                    ExampleActionsId = table.Column<int>(nullable: true),
                    ExapleActionsId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActionsIcons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ActionsIcons_ExampleActions_ExampleActionsId",
                        column: x => x.ExampleActionsId,
                        principalTable: "ExampleActions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActionsIcons_ExampleActionsId",
                table: "ActionsIcons",
                column: "ExampleActionsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActionsIcons");

            migrationBuilder.DropTable(
                name: "Made");

            migrationBuilder.DropTable(
                name: "ExampleActions");
        }
    }
}
