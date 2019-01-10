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
            var response = new BancoResponse();

            var result = _bancoRepositories.Get(id);
            IList<Banco> banco = new List<Banco>()
            {
                new Banco(result)
            };

            response.Banco = banco;
            response.Success = true;

            return response;
        }

        public BancoResponse GetAll()
        {
            var response = new BancoResponse();

            IList<Banco> banco;
            banco = _bancoRepositories.GetAll();

            response.Banco = banco;
            response.Success = true;

            return response;
        }

        public BancoResponse Insert(BancoRequest request)
        {
            var response = new BancoResponse();

            var result = _bancoRepositories.Insert(request);
            IList<Banco> banco = new List<Banco>()
            {
                new Banco(result)
            };

            response.Banco = banco;
            response.Success = true;

            return response;
        }

        public BancoResponse Update(BancoRequest request)
        {
            var response = new BancoResponse();

            var result = _bancoRepositories.Update(request);
            IList<Banco> banco = new List<Banco>()
            {
                new Banco(result)
            };

            response.Banco = banco;
            response.Success = true;

            return response;
        }

        #endregion

    }
}
