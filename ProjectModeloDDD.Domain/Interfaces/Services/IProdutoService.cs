using System.Collections.Generic;
using ProjectModeloDDD.Domain.Entities;
using ProjectModeloDDD.Domain.Interfaces.Repositories;

namespace ProjectModeloDDD.Domain.Interfaces.Services
{
    public interface IProdutoService : IServiceBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);
    }
}

