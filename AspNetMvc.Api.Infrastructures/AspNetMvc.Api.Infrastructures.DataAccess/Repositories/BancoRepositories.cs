using AspNetMvc.Api.Domains.Contracts.Repositories;
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
            throw new NotImplementedException();
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

        #endregion
    }
}
