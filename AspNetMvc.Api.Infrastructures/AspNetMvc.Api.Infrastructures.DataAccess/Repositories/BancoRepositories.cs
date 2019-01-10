using AspNetMvc.Api.Domains.Contracts.Repositories;
using AspNetMvc.Api.Domains.Dtos.Banco;
using AspNetMvc.Api.Infrastructures.DataAccess.Contexts;
using AspNetMvc.Api.Infrastructures.DataAccess.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using Banco = AspNetMvc.Api.Infrastructures.DataAccess.Entities.Banco;

namespace AspNetMvc.Api.Infrastructures.DataAccess.Repositories
{
    public class BancoRepositories : RepositoryBase<Banco>, IBancoRepositories
    {
        #region Builders

        public BancoRepositories()
        {
        }

        public BancoRepositories(DbContext dbContext) : base()
        {
            if (dbContext == null)
                dbContext = base.DbContext;
        }

        #endregion

        #region Methods

        public Domains.Dtos.Banco.Banco Get(long id)
        {
            Domains.Dtos.Banco.Banco result =
                new Domains.Dtos.Banco.Banco();

            using (var ctx = new DbContext())
            {

                var banco = ctx.Bancos.Find(id);

                result.BancoId = banco.BancoId;
                result.Codigo = banco.Codigo;
                result.Nome = banco.Nome;
                result.Apelido = banco.Apelido;
                result.NumeroCnpj = banco.NumeroCnpj;
                result.WebSiteOficial = banco.WebSiteOficial;
                result.FlagStatus = banco.FlagStatus;
                result.CadastroUsuarioId = banco.CadastroUsuarioId;
                result.CadastroDataHora = banco.CadastroDataHora;
                result.AtualizacaoUsuarioId = banco.AtualizacaoUsuarioId;
                result.AtualizacaoDataHora = banco.AtualizacaoDataHora;

            }

            return result;
        }

        public IList<Domains.Dtos.Banco.Banco> GetAll()
        {
            IList<Domains.Dtos.Banco.Banco> result =
                new List<Domains.Dtos.Banco.Banco>();

            using (var ctx = new DbContext())
            {
                var ret = ctx.Bancos.ToList();
                if (ret.Count > 0)
                {
                    foreach (var item in ret)
                    {
                        result.Add(new Domains.Dtos.Banco.Banco
                        {
                            BancoId = item.BancoId,
                            Codigo = item.Codigo,
                            Nome = item.Nome,
                            Apelido = item.Apelido,
                            NumeroCnpj = item.NumeroCnpj,
                            FlagStatus = item.FlagStatus,
                            CadastroUsuarioId = item.CadastroUsuarioId,
                            CadastroDataHora = item.CadastroDataHora,
                            AtualizacaoUsuarioId = item.AtualizacaoUsuarioId,
                            AtualizacaoDataHora = item.AtualizacaoDataHora
                        });

                    }
                }
            }

            return result;
        }

        public Domains.Dtos.Banco.Banco Insert(BancoRequest request)
        {
            Domains.Dtos.Banco.Banco result =
                 new Domains.Dtos.Banco.Banco();

            using (var ctx = new DbContext())
            {
                ctx.Add(new Entities.Banco
                {
                    BancoId = request.Banco.BancoId,
                    Codigo = request.Banco.Codigo,
                    Nome = request.Banco.Nome,
                    Apelido = request.Banco.Apelido,
                    NumeroCnpj = request.Banco.NumeroCnpj,
                    WebSiteOficial = request.Banco.WebSiteOficial,
                    FlagStatus = request.Banco.FlagStatus,
                    CadastroUsuarioId = request.Banco.CadastroUsuarioId,
                    CadastroDataHora = request.Banco.CadastroDataHora,
                    AtualizacaoUsuarioId = request.Banco.AtualizacaoUsuarioId,
                    AtualizacaoDataHora = request.Banco.AtualizacaoDataHora
                });
                ctx.SaveChanges();
            }

            return result;
        }

        public Domains.Dtos.Banco.Banco Update(BancoRequest request)
        {
            Domains.Dtos.Banco.Banco result = 
                new Domains.Dtos.Banco.Banco();

            using (var ctx = new DbContext())
            {
                ctx.Update(new Entities.Banco
                {
                    BancoId = request.Banco.BancoId,
                    Codigo = request.Banco.Codigo,
                    Nome = request.Banco.Nome,
                    Apelido = request.Banco.Apelido,
                    NumeroCnpj = request.Banco.NumeroCnpj,
                    WebSiteOficial = request.Banco.WebSiteOficial,
                    FlagStatus = request.Banco.FlagStatus,
                    CadastroUsuarioId = request.Banco.CadastroUsuarioId,
                    CadastroDataHora = request.Banco.CadastroDataHora,
                    AtualizacaoUsuarioId = request.Banco.AtualizacaoUsuarioId,
                    AtualizacaoDataHora = request.Banco.AtualizacaoDataHora
                });
                ctx.SaveChanges();
            }

            return result;
        }

        #endregion
    }
}
