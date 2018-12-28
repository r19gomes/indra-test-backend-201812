using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace AspNetMvc.Api.Infrastructures.DataAccess.Migrations
{
    public partial class DB201818281156 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContasCorrentes_TipoPessoa_TipoPessoaId",
                table: "ContasCorrentes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TipoPessoa",
                table: "TipoPessoa");

            migrationBuilder.RenameTable(
                name: "TipoPessoa",
                newName: "TiposPessoas");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TiposPessoas",
                table: "TiposPessoas",
                column: "TipoPessoaId");

            migrationBuilder.AddForeignKey(
                name: "FK_ContasCorrentes_TiposPessoas_TipoPessoaId",
                table: "ContasCorrentes",
                column: "TipoPessoaId",
                principalTable: "TiposPessoas",
                principalColumn: "TipoPessoaId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContasCorrentes_TiposPessoas_TipoPessoaId",
                table: "ContasCorrentes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TiposPessoas",
                table: "TiposPessoas");

            migrationBuilder.RenameTable(
                name: "TiposPessoas",
                newName: "TipoPessoa");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TipoPessoa",
                table: "TipoPessoa",
                column: "TipoPessoaId");

            migrationBuilder.AddForeignKey(
                name: "FK_ContasCorrentes_TipoPessoa_TipoPessoaId",
                table: "ContasCorrentes",
                column: "TipoPessoaId",
                principalTable: "TipoPessoa",
                principalColumn: "TipoPessoaId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
