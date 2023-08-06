using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmpresaInformatica.Migrations
{
    /// <inheritdoc />
    public partial class fdsf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GerarNotaServico");

            migrationBuilder.DropColumn(
                name: "Valor",
                table: "Notas");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Valor",
                table: "Notas",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateTable(
                name: "GerarNotaServico",
                columns: table => new
                {
                    NotasId = table.Column<int>(type: "int", nullable: false),
                    ServicosId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GerarNotaServico", x => new { x.NotasId, x.ServicosId });
                    table.ForeignKey(
                        name: "FK_GerarNotaServico_Notas_NotasId",
                        column: x => x.NotasId,
                        principalTable: "Notas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GerarNotaServico_Servicos_ServicosId",
                        column: x => x.ServicosId,
                        principalTable: "Servicos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GerarNotaServico_ServicosId",
                table: "GerarNotaServico",
                column: "ServicosId");
        }
    }
}
