using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace AspNetMvc.Api.Infrastructures.DataAccess.Migrations
{
    public partial class DB201818281213 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Lancamento",
                columns: table => new
                {
                    LancamentoId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AtualizacaoDataHora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AtualizacaoUsuarioId = table.Column<long>(type: "bigint", nullable: false),
                    CadastroDataHora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CadastroUsuarioId = table.Column<long>(type: "bigint", nullable: false),
                    ContaCorrenteAgenciaId = table.Column<long>(nullable: true),
                    ContaCorrenteBancoId = table.Column<long>(nullable: true),
                    ContaCorrenteId = table.Column<long>(type: "bigint", nullable: false),
                    ContaCorrenteId1 = table.Column<long>(nullable: true),
                    Conteudo = table.Column<string>(type: "varchar(max)", nullable: true),
                    FlagStatus = table.Column<bool>(type: "bit", nullable: false),
                    Titulo = table.Column<string>(type: "varchar(600)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lancamento", x => x.LancamentoId);
                    table.ForeignKey(
                        name: "FK_Lancamento_ContasCorrentes_ContaCorrenteBancoId_ContaCorrenteAgenciaId_ContaCorrenteId1",
                        columns: x => new { x.ContaCorrenteBancoId, x.ContaCorrenteAgenciaId, x.ContaCorrenteId1 },
                        principalTable: "ContasCorrentes",
                        principalColumns: new[] { "BancoId", "AgenciaId", "ContaCorrenteId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Lancamento_ContaCorrenteBancoId_ContaCorrenteAgenciaId_ContaCorrenteId1",
                table: "Lancamento",
                columns: new[] { "ContaCorrenteBancoId", "ContaCorrenteAgenciaId", "ContaCorrenteId1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Lancamento");
        }
    }
}
