using System;
using System.Collections.Generic;
using System.Text;
//using AspNetMvc.Api.Domains.Contracts.Repositorios;
using AspNetMvc.Api.Domains.Contracts.Services;
using AspNetMvc.Api.Domains.Contracts.Repositories;
using AspNetMvc.Api.Domains.Dtos.ContaCorrente;

namespace AspNetMvc.Api.Domains.Services
{
    public class ContaCorrenteServices : IContaCorrenteServices
    {
        private readonly IContaCorrenteRepositories _contaCorrenteRepositories;

        public ContaCorrenteServices()
        {

        }
        public ContaCorrenteServices(IContaCorrenteRepositories contaCorrenteRepositories):base()
        {
            _contaCorrenteRepositories = contaCorrenteRepositories;
        }

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
    }
}
