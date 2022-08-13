using Microsoft.EntityFrameworkCore.Migrations;

namespace Pixieset.Migrations
{
    public partial class CreateDigitalTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Digital",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RightImage = table.Column<string>(nullable: true),
                    LeftImage = table.Column<string>(nullable: true),
                    RightText = table.Column<string>(nullable: true),
                    RightText2 = table.Column<string>(nullable: true),
                    RightText3 = table.Column<string>(nullable: true),
                    RightSpan = table.Column<string>(nullable: true),
                    Icons = table.Column<string>(nullable: true),
                    Rightli1 = table.Column<string>(nullable: true),
                    Rightli2 = table.Column<string>(nullable: true),
                    Rightli3 = table.Column<string>(nullable: true),
                    Rightli4 = table.Column<string>(nullable: true),
                    Leftli1 = table.Column<string>(nullable: true),
                    Leftli2 = table.Column<string>(nullable: true),
                    Leftli3 = table.Column<string>(nullable: true),
                    Leftli4 = table.Column<string>(nullable: true),
                    LeftText = table.Column<string>(nullable: true),
                    LeftText2 = table.Column<string>(nullable: true),
                    LeftText3 = table.Column<string>(nullable: true),
                    LeftSpan = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Digital", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Digital");
        }
    }
}
