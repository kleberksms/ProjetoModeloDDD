using System.Collections.Generic;
using ProjectModeloDDD.Domain.Entities;

namespace ProjectModeloDDD.Application.Interface
{
    public interface IClienteAppService : IAppServiceBase<Cliente>
    {
        IEnumerable<Cliente> ObterClientesEspeciais();
    }
}
