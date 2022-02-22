using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjBancoAPI.Migrations
{
    public partial class TabelasMapeadas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tbl_Extrato",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SaldoAtual = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Extrato", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Cartao",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo = table.Column<int>(type: "int", nullable: false),
                    ExtratoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Cartao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tbl_Cartao_Tbl_Extrato_ExtratoId",
                        column: x => x.ExtratoId,
                        principalTable: "Tbl_Extrato",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Lancamento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Valor = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Data = table.Column<DateTime>(type: "date", nullable: false),
                    ExtratoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Lancamento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tbl_Lancamento_Tbl_Extrato_ExtratoId",
                        column: x => x.ExtratoId,
                        principalTable: "Tbl_Extrato",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Cartao_ExtratoId",
                table: "Tbl_Cartao",
                column: "ExtratoId");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Lancamento_ExtratoId",
                table: "Tbl_Lancamento",
                column: "ExtratoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tbl_Cartao");

            migrationBuilder.DropTable(
                name: "Tbl_Lancamento");

            migrationBuilder.DropTable(
                name: "Tbl_Extrato");
        }
    }
}
