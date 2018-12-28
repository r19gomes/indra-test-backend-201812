using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace AspNetMvc.Api.Infrastructures.DataAccess.Migrations
{
    public partial class DB201818281127 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bancos",
                columns: table => new
                {
                    BancoId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Apelido = table.Column<string>(type: "varchar(50)", nullable: false),
                    AtualizacaoDataHora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AtualizacaoUsuarioId = table.Column<long>(type: "bigint", nullable: false),
                    CadastroDataHora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CadastroUsuarioId = table.Column<long>(type: "bigint", nullable: false),
                    Codigo = table.Column<string>(type: "varchar(15)", nullable: false),
                    FlagStatus = table.Column<bool>(type: "bit", nullable: false),
                    Nome = table.Column<string>(type: "varchar(200)", nullable: false),
                    NumeroCnpj = table.Column<string>(type: "varchar(15)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bancos", x => x.BancoId);
                });

            migrationBuilder.CreateTable(
                name: "TiposContas",
                columns: table => new
                {
                    TipoContaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AtualizacaoDataHora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AtualizacaoUsuarioId = table.Column<long>(type: "bigint", nullable: false),
                    CadastroDataHora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CadastroUsuarioId = table.Column<long>(type: "bigint", nullable: false),
                    FlagStatus = table.Column<bool>(type: "bit", nullable: false),
                    Nome = table.Column<string>(type: "varchar(150)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposContas", x => x.TipoContaId);
                });

            migrationBuilder.CreateTable(
                name: "Agencias",
                columns: table => new
                {
                    BancoId = table.Column<long>(nullable: false),
                    AgendaId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AtualizacaoDataHora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AtualizacaoUsuarioId = table.Column<long>(type: "bigint", nullable: false),
                    CadastroDataHora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CadastroUsuarioId = table.Column<long>(type: "bigint", nullable: false),
                    Digito = table.Column<byte>(type: "int", nullable: false),
                    FlagStatus = table.Column<bool>(type: "bit", nullable: false),
                    Nome = table.Column<string>(type: "varchar(300)", nullable: false),
                    Numero = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agencias", x => new { x.BancoId, x.AgendaId });
                    table.ForeignKey(
                        name: "FK_Agencias_Bancos_BancoId",
                        column: x => x.BancoId,
                        principalTable: "Bancos",
                        principalColumn: "BancoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ContasCorrentes",
                columns: table => new
                {
                    BancoId = table.Column<long>(type: "bigint", nullable: false),
                    AgenciaId = table.Column<long>(type: "bigint", nullable: false),
                    ContaCorrenteId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AgenciaAgendaId = table.Column<long>(nullable: true),
                    AgenciaBancoId = table.Column<long>(nullable: true),
                    AtualizacaoDataHora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AtualizacaoUsuarioId = table.Column<long>(type: "bigint", nullable: false),
                    CadastroDataHora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CadastroUsuarioId = table.Column<long>(type: "bigint", nullable: false),
                    Digito = table.Column<string>(type: "varchar(5)", nullable: true),
                    FlagStatus = table.Column<bool>(type: "bit", nullable: false),
                    Numero = table.Column<string>(type: "varchar(30)", nullable: false),
                    Observacao = table.Column<string>(type: "varchar(max)", nullable: true),
                    TipoContaId = table.Column<int>(type: "int", nullable: false),
                    TipoPessoaId = table.Column<byte>(type: "int", nullable: false),
                    Titular = table.Column<string>(type: "varchar(250)", nullable: false),
                    TitularCnpjCpf = table.Column<string>(type: "varchar(15)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContasCorrentes", x => new { x.BancoId, x.AgenciaId, x.ContaCorrenteId });
                    table.UniqueConstraint("AK_ContasCorrentes_AgenciaId_BancoId_ContaCorrenteId", x => new { x.AgenciaId, x.BancoId, x.ContaCorrenteId });
                    table.ForeignKey(
                        name: "FK_ContasCorrentes_TiposContas_TipoContaId",
                        column: x => x.TipoContaId,
                        principalTable: "TiposContas",
                        principalColumn: "TipoContaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContasCorrentes_Agencias_AgenciaBancoId_AgenciaAgendaId",
                        columns: x => new { x.AgenciaBancoId, x.AgenciaAgendaId },
                        principalTable: "Agencias",
                        principalColumns: new[] { "BancoId", "AgendaId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ContasCorrentes_TipoContaId",
                table: "ContasCorrentes",
                column: "TipoContaId");

            migrationBuilder.CreateIndex(
                name: "IX_ContasCorrentes_AgenciaBancoId_AgenciaAgendaId",
                table: "ContasCorrentes",
                columns: new[] { "AgenciaBancoId", "AgenciaAgendaId" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContasCorrentes");

            migrationBuilder.DropTable(
                name: "TiposContas");

            migrationBuilder.DropTable(
                name: "Agencias");

            migrationBuilder.DropTable(
                name: "Bancos");
        }
    }
}
