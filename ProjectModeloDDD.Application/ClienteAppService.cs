using System.Collections.Generic;
using ProjectModeloDDD.Application.Interface;
using ProjectModeloDDD.Domain.Entities;
using ProjectModeloDDD.Domain.Interfaces.Services;

namespace ProjectModeloDDD.Application
{
    public class ClienteAppService : AppServiceBase<Cliente>, IClienteAppService
    {
        private readonly IClienteService _clienteService;

        public ClienteAppService(IClienteService clienteService) 
            : base(clienteService)
        {
            _clienteService = clienteService;
        }


        public IEnumerable<Cliente> ObterClientesEspeciais()
        {
            return _clienteService.ObterClientesEspeciais(_clienteService.GetAll());
        }
    }
}
