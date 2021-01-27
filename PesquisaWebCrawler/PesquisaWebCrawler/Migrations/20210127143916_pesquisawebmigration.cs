using Microsoft.EntityFrameworkCore.Migrations;

namespace PesquisaWebCrawler.Migrations
{
    public partial class pesquisawebmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Refeicao",
                columns: table => new
                {
                    PROCODIGO = table.Column<string>(nullable: false),
                    PRONOME = table.Column<string>(nullable: true),
                    PRODESCRICAO = table.Column<string>(nullable: true),
                    PROIMAGEM = table.Column<string>(nullable: true),
                    PROLINK = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Refeicao", x => x.PROCODIGO);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Refeicao");
        }
    }
}
