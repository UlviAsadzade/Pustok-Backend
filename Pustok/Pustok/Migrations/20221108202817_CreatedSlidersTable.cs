using Microsoft.EntityFrameworkCore.Migrations;

namespace Pustok.Migrations
{
    public partial class CreatedSlidersTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sliders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Title1 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Title2 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Subtitle = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    RedirectUrl = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    UrlText = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Order = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sliders", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sliders");
        }
    }
}
