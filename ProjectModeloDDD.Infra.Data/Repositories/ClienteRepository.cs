using ProjectModeloDDD.Domain.Entities;
using ProjectModeloDDD.Domain.Interfaces.Repositories;

namespace ProjectModeloDDD.Infra.Data.Repositories
{
    public class ClienteRepository : RepositoryBase<Cliente>, IClienteRepository
    {
    }
}
