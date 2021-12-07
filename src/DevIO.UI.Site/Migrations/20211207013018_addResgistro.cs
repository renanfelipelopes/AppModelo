using Microsoft.EntityFrameworkCore.Migrations;

namespace DevIO.UI.Site.Migrations
{
    public partial class addResgistro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Registro",
                table: "Alunos",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Registro",
                table: "Alunos");
        }
    }
}
