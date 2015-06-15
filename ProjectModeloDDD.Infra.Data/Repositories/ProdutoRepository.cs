using System.Collections.Generic;
using System.Linq;
using ProjectModeloDDD.Domain.Entities;
using ProjectModeloDDD.Domain.Interfaces.Repositories;

namespace ProjectModeloDDD.Infra.Data.Repositories
{
    public class ProdutoRepository : RepositoryBase<Produto>, IProdutoRepository
    {
        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return Db.Produtos.Where(p => p.Nome == nome);
        }
    }
}
