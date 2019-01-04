using AspNetMvc.Api.Infrastructures.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace AspNetMvc.Api.Infrastructures.DataAccess.Contexts
{
    public class DbContext: Microsoft.EntityFrameworkCore.DbContext
    {
        public DbSet<Banco> Bancos { get; set; }

        public DbSet<Agencia> Agencias { get; set; }

        public DbSet<TipoConta> TiposContas { get; set; }

        public DbSet<TipoPessoa> TiposPessoas { get; set; }

        public DbSet<ContaCorrente> ContasCorrentes { get; set; }

        public DbSet<Lancamento> Lancamentos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string cn = string.Empty;

            // ConnectionString do notebook Intel(R) Core(TM) i7-7500U CPU @ 2.70GHz 2,90 GHz
            cn = @"Data Source=DESKTOP-F4SIQSG\SQLEXPRESS;Initial Catalog=DB_INTRA_BANK;Integrated Security=SSPI;";

            // ConnectionString do MACBook
            //cn = @"Data Source=MACOS472F\MSSQL2014;Initial Catalog=DB_INTRA_BANK;Integrated Security=True";

            optionsBuilder.UseSqlServer(cn);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Bancos

            modelBuilder.Entity<Banco>(b =>
            {
                b.HasKey(o => o.BancoId);
                b.Property(o => o.BancoId).ValueGeneratedOnAdd();

                b.Property(o => o.Codigo).HasColumnType("varchar(15)").IsRequired();
                b.Property(o => o.Nome).HasColumnType("varchar(200)").IsRequired();
                b.Property(o => o.Apelido).HasColumnType("varchar(50)").IsRequired();
                b.Property(o => o.NumeroCnpj).HasColumnType("varchar(15)");
                b.Property(o => o.FlagStatus).HasColumnType("bit");
                b.Property(o => o.CadastroUsuarioId).HasColumnType("bigint").IsRequired();
                b.Property(o => o.CadastroDataHora).HasColumnType("datetime2").IsRequired();
                b.Property(o => o.AtualizacaoUsuarioId).HasColumnType("bigint");
                b.Property(o => o.AtualizacaoDataHora).HasColumnType("datetime2");

                b.HasMany(o => o.Agencias).WithOne(p => p.Banco);
            });

            #endregion

            #region Agências

            modelBuilder.Entity<Agencia>(b =>
            {
                b.HasKey(o => new { o.BancoId, o.AgendaId });
                b.Property(o => o.AgendaId).HasColumnType("bigint").IsRequired();
                b.Property(o => o.AgendaId).ValueGeneratedOnAdd();

                b.Property(o => o.Nome).HasColumnType("varchar(300)").IsRequired();
                b.Property(o => o.Numero).HasColumnType("int").IsRequired();
                b.Property(o => o.Digito).HasColumnType("int");
                b.Property(o => o.FlagStatus).HasColumnType("bit");
                b.Property(o => o.CadastroUsuarioId).HasColumnType("bigint").IsRequired();
                b.Property(o => o.CadastroDataHora).HasColumnType("datetime2").IsRequired();
                b.Property(o => o.AtualizacaoUsuarioId).HasColumnType("bigint");
                b.Property(o => o.AtualizacaoDataHora).HasColumnType("datetime2");

                b.HasOne(o => o.Banco).WithMany(p => p.Agencias);
                b.HasMany(o => o.ContasCorrentes).WithOne(p => p.Agencia);
            });

            #endregion

            #region TiposContas | Tipos de Contas Correntes

            modelBuilder.Entity<TipoConta>(b =>
            {
                b.HasKey(o => o.TipoContaId);
                b.Property(o => o.TipoContaId).HasColumnType("int").IsRequired();
                b.Property(o => o.TipoContaId).ValueGeneratedOnAdd();

                b.Property(o => o.Nome).HasColumnType("varchar(150)").IsRequired();
                b.Property(o => o.FlagStatus).HasColumnType("bit").IsRequired();
                b.Property(o => o.CadastroUsuarioId).HasColumnType("bigint").IsRequired();
                b.Property(o => o.CadastroDataHora).HasColumnType("datetime2").IsRequired();
                b.Property(o => o.AtualizacaoUsuarioId).HasColumnType("bigint");
                b.Property(o => o.AtualizacaoDataHora).HasColumnType("datetime2");

                b.HasMany(o => o.ContasCorrentes).WithOne(p => p.TipoConta);

            });

            #endregion

            #region Tipo de Pessoa Jurídica ou Física

            modelBuilder.Entity<TipoPessoa>(b =>
            {
                b.HasKey(o => o.TipoPessoaId);
                b.Property(o => o.TipoPessoaId).HasColumnType("int").IsRequired();
                b.Property(o => o.TipoPessoaId).ValueGeneratedOnAdd();

                b.Property(o => o.Nome).HasColumnType("varchar(50)").IsRequired();
                b.Property(o => o.Apelido).HasColumnType("varchar(20)");
                b.Property(o => o.Sigla).HasColumnType("varchar(3)").IsRequired();
                b.Property(o => o.CadastroUsuarioId).HasColumnType("bigint").IsRequired();
                b.Property(o => o.CadastroDataHora).HasColumnType("datetime2").IsRequired();
                b.Property(o => o.AtualizacaoUsuarioId).HasColumnType("bigint");
                b.Property(o => o.AtualizacaoDataHora).HasColumnType("datetime2");

                b.HasMany(o => o.ContasCorrentes).WithOne(p => p.TipoPessoa);
            });

            #endregion

            #region Contas Correntes

            //modelBuilder.Entity<ContaCorrente>(b =>
            //{
            //    b.HasKey(o => new { o.BancoId, o.AgenciaId, o.ContaCorrenteId });
            //    b.Property(o => o.BancoId).HasColumnType("bigint").IsRequired();
            //    b.Property(o => o.AgenciaId).HasColumnType("bigint").IsRequired();
            //    b.Property(o => o.ContaCorrenteId).HasColumnType("bigint").IsRequired();
            //    b.Property(o => o.ContaCorrenteId).ValueGeneratedOnAdd();

            //    b.Property(o => o.TipoContaId).HasColumnType("int").IsRequired();
            //    b.Property(o => o.Numero).HasColumnType("int").IsRequired();
            //    b.Property(o => o.Digito).HasColumnType("smallint");
            //    b.Property(o => o.Titular).HasColumnType("varchar(250)").IsRequired();
            //    b.Property(o => o.TitularCnpjCpf).HasColumnType("varchar(15)");
            //    b.Property(o => o.TipoPessoaId).HasColumnType("int").IsRequired();
            //    b.Property(o => o.Observacao).HasColumnType("varchar(max)");
            //    b.Property(o => o.FlagStatus).HasColumnType("bit").IsRequired();
            //    b.Property(o => o.CadastroUsuarioId).HasColumnType("bigint").IsRequired();
            //    b.Property(o => o.CadastroDataHora).HasColumnType("datetime2").IsRequired();
            //    b.Property(o => o.AtualizacaoUsuarioId).HasColumnType("bigint");
            //    b.Property(o => o.AtualizacaoDataHora).HasColumnType("datetime2");

            //    //b.HasOne(o => o.Agencia).WithMany(p => p.ContasCorrentes);
            //    //b.HasOne(o => o.TipoConta).WithMany(p => p.ContasCorrentes);
            //    //b.HasOne(o => o.TipoPessoa).WithMany(p => p.ContasCorrentes);
            //    //b.HasMany(o => o.Lancamentos).WithOne(p => p.ContaCorrente);

            //});

            #endregion

            #region Lançamentos 

            modelBuilder.Entity<Lancamento>(b =>
            {
                b.HasKey(o => o.LancamentoId);
                b.Property(o => o.LancamentoId).HasColumnType("bigint").IsRequired();
                b.Property(o => o.LancamentoId).ValueGeneratedOnAdd();

                b.Property(o => o.ContaCorrenteId).HasColumnType("bigint").IsRequired();
                b.Property(o => o.TipoLancamento).HasColumnType("varchar(1)").HasDefaultValue("C").IsRequired();
                b.Property(o => o.Titulo).HasColumnType("varchar(600)").IsRequired();
                b.Property(o => o.Conteudo).HasColumnType("varchar(max)");
                b.Property(o => o.FlagStatus).HasColumnType("bit").IsRequired();
                b.Property(o => o.LancamentoPaiId).HasColumnType("bigint");
                b.Property(o => o.CadastroUsuarioId).HasColumnType("bigint").IsRequired();
                b.Property(o => o.CadastroDataHora).HasColumnType("datetime2").IsRequired();
                b.Property(o => o.AtualizacaoUsuarioId).HasColumnType("bigint");
                b.Property(o => o.AtualizacaoDataHora).HasColumnType("datetime2");

                b.HasOne(o => o.ContaCorrente).WithMany(p => p.Lancamentos);
                b.HasOne(o => o.LancamentoPai).WithOne().HasForeignKey<Lancamento>(p => p.LancamentoId);
            });

            #endregion
        }
    }
}
