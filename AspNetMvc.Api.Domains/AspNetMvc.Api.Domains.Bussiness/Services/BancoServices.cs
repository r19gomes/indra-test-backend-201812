using AspNetMvc.Api.Domains.Contracts.Repositories;
using AspNetMvc.Api.Domains.Contracts.Services;
using AspNetMvc.Api.Domains.Dtos.Banco;
using System;
using System.Collections.Generic;

namespace AspNetMvc.Api.Domains.Services
{
    public class BancoServices : IBancoServices
    {
        #region Properties | Fields

        private readonly IBancoRepositories _bancoRepositories;

        #endregion

        #region Builders

        public BancoServices()
        {

        }

        public BancoServices(IBancoRepositories bancoRepositories) : base()
        {
            _bancoRepositories = bancoRepositories;
        }

        #endregion

        #region Methods

        public BancoResponse Get(long id)
        {
            //aquibob
            _bancoRepositories.Get(id);
            throw new NotImplementedException();
        }

        public BancoResponse GetAll()
        {
            var response = new BancoResponse();

            IList<Banco> banco;
            banco = _bancoRepositories.GetAll();

            response.Banco = banco;

            return response;
        }

        #endregion

    }
}
