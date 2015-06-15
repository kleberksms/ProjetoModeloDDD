
using System.Collections.Generic;
using ProjectModeloDDD.Domain.Entities;
using ProjectModeloDDD.Domain.Interfaces.Repositories;

namespace ProjectModeloDDD.Domain.Interfaces.Services
{
    public interface IClienteService : IServiceBase<Cliente>
    {
        IEnumerable<Cliente> ObterClientesEspeciais(IEnumerable<Cliente> clientes);
    }
}
