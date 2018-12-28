using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace AspNetMvc.Api.Infrastructures.DataAccess.Migrations
{
    public partial class DB201818281154 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TipoPessoa",
                columns: table => new
                {
                    TipoPessoaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Apelido = table.Column<string>(type: "varchar(20)", nullable: true),
                    AtualizacaoDataHora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AtualizacaoUsuarioId = table.Column<long>(type: "bigint", nullable: false),
                    CadastroDataHora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CadastroUsuarioId = table.Column<long>(type: "bigint", nullable: false),
                    Nome = table.Column<string>(type: "varchar(50)", nullable: false),
                    Sigla = table.Column<string>(type: "varchar(3)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoPessoa", x => x.TipoPessoaId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ContasCorrentes_TipoPessoaId",
                table: "ContasCorrentes",
                column: "TipoPessoaId");

            migrationBuilder.AddForeignKey(
                name: "FK_ContasCorrentes_TipoPessoa_TipoPessoaId",
                table: "ContasCorrentes",
                column: "TipoPessoaId",
                principalTable: "TipoPessoa",
                principalColumn: "TipoPessoaId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContasCorrentes_TipoPessoa_TipoPessoaId",
                table: "ContasCorrentes");

            migrationBuilder.DropTable(
                name: "TipoPessoa");

            migrationBuilder.DropIndex(
                name: "IX_ContasCorrentes_TipoPessoaId",
                table: "ContasCorrentes");
        }
    }
}
