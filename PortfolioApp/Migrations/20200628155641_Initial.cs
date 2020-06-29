using Microsoft.EntityFrameworkCore.Migrations;

namespace PortfolioApp.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "About",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 50, nullable: false),
                    ImageName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: false),
                    Profile_desc = table.Column<string>(nullable: false),
                    FullName = table.Column<string>(maxLength: 50, nullable: false),
                    Birth_date = table.Column<string>(nullable: false),
                    Job = table.Column<string>(nullable: false),
                    Website = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Skills_desc = table.Column<string>(nullable: false),
                    Skill_key = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_About", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "About");
        }
    }
}
