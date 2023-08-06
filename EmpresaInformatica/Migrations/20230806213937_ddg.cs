using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmpresaInformatica.Migrations
{
    /// <inheritdoc />
    public partial class ddg : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Valor",
                table: "Notas",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Valor",
                table: "Notas");
        }
    }
}
