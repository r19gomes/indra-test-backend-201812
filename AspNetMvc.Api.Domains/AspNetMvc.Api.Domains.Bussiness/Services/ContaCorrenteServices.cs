using AspNetMvc.Api.Domains.Contracts.Repositories;
using AspNetMvc.Api.Domains.Contracts.Services;
using AspNetMvc.Api.Domains.Dtos.ContaCorrente;
using System;
using System.Collections.Generic;

namespace AspNetMvc.Api.Domains.Services
{
    public class ContaCorrenteServices : IContaCorrenteServices
    {
        #region Properties | Fields

        private readonly IContaCorrenteRepositories _contaCorrenteRepositories;

        #endregion

        #region Builders

        public ContaCorrenteServices()
        {

        }

        public ContaCorrenteServices(IContaCorrenteRepositories contaCorrenteRepositories):base()
        {
            _contaCorrenteRepositories = contaCorrenteRepositories;
        }

        #endregion

        #region Methods

        public ContaCorrenteResponse Get(long id)
        {
            //aquibob
            _contaCorrenteRepositories.Get(id);
            throw new NotImplementedException();
        }

        public ContaCorrenteResponse GetAll()
        {
            var response = new ContaCorrenteResponse();

            IList<ContaCorrente> contaCorrente;
            contaCorrente = _contaCorrenteRepositories.GetAll();

            response.ContaCorrente = contaCorrente;

            return response;
        }

        #endregion
    }
}
