using Microsoft.EntityFrameworkCore.Migrations;

namespace SolucionCreditos.Data.Migrations
{
    public partial class SolucionesCreditoDBEntradasSalidas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Entrada",
                table: "TipoMovimientos",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Entrada",
                table: "TipoMovimientos");
        }
    }
}
