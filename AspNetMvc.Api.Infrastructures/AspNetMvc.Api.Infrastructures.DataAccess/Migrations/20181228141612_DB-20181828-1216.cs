using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace AspNetMvc.Api.Infrastructures.DataAccess.Migrations
{
    public partial class DB201818281216 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lancamento_ContasCorrentes_ContaCorrenteBancoId_ContaCorrenteAgenciaId_ContaCorrenteId1",
                table: "Lancamento");

            migrationBuilder.DropIndex(
                name: "IX_Lancamento_ContaCorrenteBancoId_ContaCorrenteAgenciaId_ContaCorrenteId1",
                table: "Lancamento");

            migrationBuilder.DropColumn(
                name: "ContaCorrenteAgenciaId",
                table: "Lancamento");

            migrationBuilder.DropColumn(
                name: "ContaCorrenteBancoId",
                table: "Lancamento");

            migrationBuilder.DropColumn(
                name: "ContaCorrenteId1",
                table: "Lancamento");

            migrationBuilder.AddColumn<long>(
                name: "AgenciaId",
                table: "Lancamento",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "BancoId",
                table: "Lancamento",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_Lancamento_BancoId_AgenciaId_ContaCorrenteId",
                table: "Lancamento",
                columns: new[] { "BancoId", "AgenciaId", "ContaCorrenteId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Lancamento_ContasCorrentes_BancoId_AgenciaId_ContaCorrenteId",
                table: "Lancamento",
                columns: new[] { "BancoId", "AgenciaId", "ContaCorrenteId" },
                principalTable: "ContasCorrentes",
                principalColumns: new[] { "BancoId", "AgenciaId", "ContaCorrenteId" },
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lancamento_ContasCorrentes_BancoId_AgenciaId_ContaCorrenteId",
                table: "Lancamento");

            migrationBuilder.DropIndex(
                name: "IX_Lancamento_BancoId_AgenciaId_ContaCorrenteId",
                table: "Lancamento");

            migrationBuilder.DropColumn(
                name: "AgenciaId",
                table: "Lancamento");

            migrationBuilder.DropColumn(
                name: "BancoId",
                table: "Lancamento");

            migrationBuilder.AddColumn<long>(
                name: "ContaCorrenteAgenciaId",
                table: "Lancamento",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ContaCorrenteBancoId",
                table: "Lancamento",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ContaCorrenteId1",
                table: "Lancamento",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Lancamento_ContaCorrenteBancoId_ContaCorrenteAgenciaId_ContaCorrenteId1",
                table: "Lancamento",
                columns: new[] { "ContaCorrenteBancoId", "ContaCorrenteAgenciaId", "ContaCorrenteId1" });

            migrationBuilder.AddForeignKey(
                name: "FK_Lancamento_ContasCorrentes_ContaCorrenteBancoId_ContaCorrenteAgenciaId_ContaCorrenteId1",
                table: "Lancamento",
                columns: new[] { "ContaCorrenteBancoId", "ContaCorrenteAgenciaId", "ContaCorrenteId1" },
                principalTable: "ContasCorrentes",
                principalColumns: new[] { "BancoId", "AgenciaId", "ContaCorrenteId" },
                onDelete: ReferentialAction.Restrict);
        }
    }
}
