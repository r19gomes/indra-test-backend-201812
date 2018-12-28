﻿// <auto-generated />
using AspNetMvc.Api.Infrastructures.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace AspNetMvc.Api.Infrastructures.DataAccess.Migrations
{
    [DbContext(typeof(BaseContext))]
    [Migration("20181228141308_DB-20181828-1213")]
    partial class DB201818281213
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AspNetMvc.Api.Infrastructures.DataAccess.Models.Agencia", b =>
                {
                    b.Property<long>("BancoId");

                    b.Property<long>("AgendaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<DateTime>("AtualizacaoDataHora")
                        .HasColumnType("datetime2");

                    b.Property<long>("AtualizacaoUsuarioId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CadastroDataHora")
                        .HasColumnType("datetime2");

                    b.Property<long>("CadastroUsuarioId")
                        .HasColumnType("bigint");

                    b.Property<byte>("Digito")
                        .HasColumnType("int");

                    b.Property<bool>("FlagStatus")
                        .HasColumnType("bit");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(300)");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.HasKey("BancoId", "AgendaId");

                    b.HasAlternateKey("AgendaId", "BancoId");

                    b.ToTable("Agencias");
                });

            modelBuilder.Entity("AspNetMvc.Api.Infrastructures.DataAccess.Models.Banco", b =>
                {
                    b.Property<long>("BancoId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Apelido")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime>("AtualizacaoDataHora")
                        .HasColumnType("datetime2");

                    b.Property<long>("AtualizacaoUsuarioId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CadastroDataHora")
                        .HasColumnType("datetime2");

                    b.Property<long>("CadastroUsuarioId")
                        .HasColumnType("bigint");

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasColumnType("varchar(15)");

                    b.Property<bool>("FlagStatus")
                        .HasColumnType("bit");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("NumeroCnpj")
                        .HasColumnType("varchar(15)");

                    b.HasKey("BancoId");

                    b.ToTable("Bancos");
                });

            modelBuilder.Entity("AspNetMvc.Api.Infrastructures.DataAccess.Models.ContaCorrente", b =>
                {
                    b.Property<long>("BancoId")
                        .HasColumnType("bigint");

                    b.Property<long>("AgenciaId")
                        .HasColumnType("bigint");

                    b.Property<long>("ContaCorrenteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<long?>("AgenciaAgendaId");

                    b.Property<long?>("AgenciaBancoId");

                    b.Property<DateTime>("AtualizacaoDataHora")
                        .HasColumnType("datetime2");

                    b.Property<long>("AtualizacaoUsuarioId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CadastroDataHora")
                        .HasColumnType("datetime2");

                    b.Property<long>("CadastroUsuarioId")
                        .HasColumnType("bigint");

                    b.Property<string>("Digito")
                        .HasColumnType("varchar(5)");

                    b.Property<bool>("FlagStatus")
                        .HasColumnType("bit");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Observacao")
                        .HasColumnType("varchar(max)");

                    b.Property<int>("TipoContaId")
                        .HasColumnType("int");

                    b.Property<int>("TipoPessoaId")
                        .HasColumnType("int");

                    b.Property<string>("Titular")
                        .IsRequired()
                        .HasColumnType("varchar(250)");

                    b.Property<string>("TitularCnpjCpf")
                        .HasColumnType("varchar(15)");

                    b.HasKey("BancoId", "AgenciaId", "ContaCorrenteId");

                    b.HasAlternateKey("AgenciaId", "BancoId", "ContaCorrenteId");

                    b.HasIndex("TipoContaId");

                    b.HasIndex("TipoPessoaId");

                    b.HasIndex("AgenciaBancoId", "AgenciaAgendaId");

                    b.ToTable("ContasCorrentes");
                });

            modelBuilder.Entity("AspNetMvc.Api.Infrastructures.DataAccess.Models.Lancamento", b =>
                {
                    b.Property<long>("LancamentoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<DateTime>("AtualizacaoDataHora")
                        .HasColumnType("datetime2");

                    b.Property<long>("AtualizacaoUsuarioId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CadastroDataHora")
                        .HasColumnType("datetime2");

                    b.Property<long>("CadastroUsuarioId")
                        .HasColumnType("bigint");

                    b.Property<long?>("ContaCorrenteAgenciaId");

                    b.Property<long?>("ContaCorrenteBancoId");

                    b.Property<long>("ContaCorrenteId")
                        .HasColumnType("bigint");

                    b.Property<long?>("ContaCorrenteId1");

                    b.Property<string>("Conteudo")
                        .HasColumnType("varchar(max)");

                    b.Property<bool>("FlagStatus")
                        .HasColumnType("bit");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("varchar(600)");

                    b.HasKey("LancamentoId");

                    b.HasIndex("ContaCorrenteBancoId", "ContaCorrenteAgenciaId", "ContaCorrenteId1");

                    b.ToTable("Lancamento");
                });

            modelBuilder.Entity("AspNetMvc.Api.Infrastructures.DataAccess.Models.TipoConta", b =>
                {
                    b.Property<int>("TipoContaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("AtualizacaoDataHora")
                        .HasColumnType("datetime2");

                    b.Property<long>("AtualizacaoUsuarioId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CadastroDataHora")
                        .HasColumnType("datetime2");

                    b.Property<long>("CadastroUsuarioId")
                        .HasColumnType("bigint");

                    b.Property<bool>("FlagStatus")
                        .HasColumnType("bit");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.HasKey("TipoContaId");

                    b.ToTable("TiposContas");
                });

            modelBuilder.Entity("AspNetMvc.Api.Infrastructures.DataAccess.Models.TipoPessoa", b =>
                {
                    b.Property<int>("TipoPessoaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Apelido")
                        .HasColumnType("varchar(20)");

                    b.Property<DateTime>("AtualizacaoDataHora")
                        .HasColumnType("datetime2");

                    b.Property<long>("AtualizacaoUsuarioId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CadastroDataHora")
                        .HasColumnType("datetime2");

                    b.Property<long>("CadastroUsuarioId")
                        .HasColumnType("bigint");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Sigla")
                        .IsRequired()
                        .HasColumnType("varchar(3)");

                    b.HasKey("TipoPessoaId");

                    b.ToTable("TiposPessoas");
                });

            modelBuilder.Entity("AspNetMvc.Api.Infrastructures.DataAccess.Models.Agencia", b =>
                {
                    b.HasOne("AspNetMvc.Api.Infrastructures.DataAccess.Models.Banco", "Banco")
                        .WithMany("Agencias")
                        .HasForeignKey("BancoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AspNetMvc.Api.Infrastructures.DataAccess.Models.ContaCorrente", b =>
                {
                    b.HasOne("AspNetMvc.Api.Infrastructures.DataAccess.Models.TipoConta", "TipoConta")
                        .WithMany("ContasCorrentes")
                        .HasForeignKey("TipoContaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AspNetMvc.Api.Infrastructures.DataAccess.Models.TipoPessoa", "TipoPessoa")
                        .WithMany("ContasCorrentes")
                        .HasForeignKey("TipoPessoaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AspNetMvc.Api.Infrastructures.DataAccess.Models.Agencia", "Agencia")
                        .WithMany("ContasCorrentes")
                        .HasForeignKey("AgenciaBancoId", "AgenciaAgendaId");
                });

            modelBuilder.Entity("AspNetMvc.Api.Infrastructures.DataAccess.Models.Lancamento", b =>
                {
                    b.HasOne("AspNetMvc.Api.Infrastructures.DataAccess.Models.ContaCorrente", "ContaCorrente")
                        .WithMany("Lancamentos")
                        .HasForeignKey("ContaCorrenteBancoId", "ContaCorrenteAgenciaId", "ContaCorrenteId1");
                });
#pragma warning restore 612, 618
        }
    }
}
