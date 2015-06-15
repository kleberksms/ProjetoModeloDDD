using System.Collections.Generic;
using ProjectModeloDDD.Application.Interface;
using ProjectModeloDDD.Domain.Entities;
using ProjectModeloDDD.Domain.Interfaces.Services;

namespace ProjectModeloDDD.Application
{
    public class ProdutoAppService : AppServiceBase<Produto>, IProdutoAppService
    {
        private readonly IProdutoService _produtoService;

        public ProdutoAppService(IProdutoService produtoService) : base(produtoService)
        {
            _produtoService = produtoService;
        }

        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return _produtoService.BuscarPorNome(nome);
            ;
        }
    }
}
