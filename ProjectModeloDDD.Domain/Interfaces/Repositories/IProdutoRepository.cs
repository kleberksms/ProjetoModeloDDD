using System.Collections.Generic;
using ProjectModeloDDD.Domain.Entities;

namespace ProjectModeloDDD.Domain.Interfaces.Repositories
{
    public interface IProdutoRepository : IRepositoryBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);
    }
}
