using AspNetMvc.Api.Domains.Contracts.Repositories;
using AspNetMvc.Api.Domains.Dtos.ContaCorrente;
using AspNetMvc.Api.Infrastructures.DataAccess.Contexts;
using AspNetMvc.Api.Infrastructures.DataAccess.Entities;
using AspNetMvc.Api.Infrastructures.DataAccess.Repositorios.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ContaCorrente = AspNetMvc.Api.Infrastructures.DataAccess.Entities.ContaCorrente;

namespace AspNetMvc.Api.Infrastructures.DataAccess.Repositorios
{
    public class ContaCorrenteRepositories : RepositoryBase<ContaCorrente>, IContaCorrenteRepositories
    {
        public ContaCorrenteRepositories()
        {
        }

        public ContaCorrenteRepositories(DbContext dbContext) : base()
        {
            if (dbContext == null)
                dbContext = base.DbContext;
        }

        public Domains.Dtos.ContaCorrente.ContaCorrente Get(long id)
        {
            throw new NotImplementedException();
        }

        public IList<Domains.Dtos.ContaCorrente.ContaCorrente> GetAll()
        {
            IList<Domains.Dtos.ContaCorrente.ContaCorrente> result =
                new List<Domains.Dtos.ContaCorrente.ContaCorrente>();

            using (var ctx = new DbContext())
            {
                var ret = ctx.ContasCorrentes.ToList();
                if (ret.Count > 0)
                {
                    foreach (var item in ret)
                    {
                        result.Add(new Domains.Dtos.ContaCorrente.ContaCorrente
                        {
                            BancoId = item.BancoId,
                            AgenciaId = item.AgenciaId

                        });

                    }
                }
            }

            return result;
        }
    }
}
