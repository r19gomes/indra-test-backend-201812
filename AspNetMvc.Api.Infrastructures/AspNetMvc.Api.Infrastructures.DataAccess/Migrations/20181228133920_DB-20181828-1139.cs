using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace AspNetMvc.Api.Infrastructures.DataAccess.Migrations
{
    public partial class DB201818281139 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddUniqueConstraint(
                name: "AK_Agencias_AgendaId_BancoId",
                table: "Agencias",
                columns: new[] { "AgendaId", "BancoId" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AK_Agencias_AgendaId_BancoId",
                table: "Agencias");
        }
    }
}
