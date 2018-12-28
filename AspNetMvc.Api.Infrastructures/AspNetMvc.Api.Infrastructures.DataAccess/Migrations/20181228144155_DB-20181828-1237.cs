using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace AspNetMvc.Api.Infrastructures.DataAccess.Migrations
{
    public partial class DB201818281237 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lancamento_ContasCorrentes_BancoId_AgenciaId_ContaCorrenteId",
                table: "Lancamento");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Lancamento",
                table: "Lancamento");

            migrationBuilder.RenameTable(
                name: "Lancamento",
                newName: "Lancamentos");

            migrationBuilder.RenameIndex(
                name: "IX_Lancamento_BancoId_AgenciaId_ContaCorrenteId",
                table: "Lancamentos",
                newName: "IX_Lancamentos_BancoId_AgenciaId_ContaCorrenteId");

            migrationBuilder.AddColumn<long>(
                name: "LancamentoPaiId",
                table: "Lancamentos",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "TipoLancamento",
                table: "Lancamentos",
                type: "varchar(1)",
                nullable: false,
                defaultValue: "C");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Lancamentos",
                table: "Lancamentos",
                column: "LancamentoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Lancamentos_ContasCorrentes_BancoId_AgenciaId_ContaCorrenteId",
                table: "Lancamentos",
                columns: new[] { "BancoId", "AgenciaId", "ContaCorrenteId" },
                principalTable: "ContasCorrentes",
                principalColumns: new[] { "BancoId", "AgenciaId", "ContaCorrenteId" },
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lancamentos_ContasCorrentes_BancoId_AgenciaId_ContaCorrenteId",
                table: "Lancamentos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Lancamentos",
                table: "Lancamentos");

            migrationBuilder.DropColumn(
                name: "LancamentoPaiId",
                table: "Lancamentos");

            migrationBuilder.DropColumn(
                name: "TipoLancamento",
                table: "Lancamentos");

            migrationBuilder.RenameTable(
                name: "Lancamentos",
                newName: "Lancamento");

            migrationBuilder.RenameIndex(
                name: "IX_Lancamentos_BancoId_AgenciaId_ContaCorrenteId",
                table: "Lancamento",
                newName: "IX_Lancamento_BancoId_AgenciaId_ContaCorrenteId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Lancamento",
                table: "Lancamento",
                column: "LancamentoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Lancamento_ContasCorrentes_BancoId_AgenciaId_ContaCorrenteId",
                table: "Lancamento",
                columns: new[] { "BancoId", "AgenciaId", "ContaCorrenteId" },
                principalTable: "ContasCorrentes",
                principalColumns: new[] { "BancoId", "AgenciaId", "ContaCorrenteId" },
                onDelete: ReferentialAction.Cascade);
        }
    }
}
