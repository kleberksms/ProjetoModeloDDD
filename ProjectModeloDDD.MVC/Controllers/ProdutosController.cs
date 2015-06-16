using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using ProjectModeloDDD.Application.Interface;
using ProjectModeloDDD.Domain.Entities;
using ProjectModeloDDD.MVC.ViewModels;

namespace ProjectModeloDDD.MVC.Controllers
{
    public class ProdutosController : Controller
    {
        
        private readonly IProdutoAppService _produtoAppService;
        private readonly IClienteAppService _clienteAppService;

        public ProdutosController(IProdutoAppService produtoAppService, IClienteAppService clienteAppService)
        {
            _produtoAppService = produtoAppService;
            _clienteAppService = clienteAppService;
        }

        // GET: Produto
        public ActionResult Index()
        {
            Mapper.CreateMap<Produto, ProdutoViewModel>();
            var produtoViewModel = Mapper.Map<IEnumerable<Produto>, IEnumerable<ProdutoViewModel>>(_produtoAppService.GetAll());
            return View(produtoViewModel);
        }

        // GET: Produto/Details/5
        public ActionResult Details(int id)
        {
            var produto = _produtoAppService.GetById(id);
            var produtoViewModel = Mapper.Map<Produto, ProdutoViewModel>(produto);
            return View(produtoViewModel);
        }

        // GET: Produto/Create
        public ActionResult Create()
        {
            ViewBag.ClienteId = new SelectList(_clienteAppService.GetAll(),"ClienteId","Nome");
            return View();
        }

        // POST: Produto/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProdutoViewModel produto)
        {
            if (ModelState.IsValid)
            {
                var produtoDomain = Mapper.Map<ProdutoViewModel, Produto>(produto);
                _produtoAppService.Add(produtoDomain);
                return RedirectToAction("Index");
            }
            return View(produto);
        }

        // GET: Produto/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.ClienteId = new SelectList(_clienteAppService.GetAll(), "ClienteId", "Nome");
            var produto = _produtoAppService.GetById(id);
            var produtoViewModel = Mapper.Map<Produto, ProdutoViewModel>(produto);
            return View(produtoViewModel);
        }

        // POST: Produto/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ProdutoViewModel produto)
        {
            if (ModelState.IsValid)
            {
                var produtoDomain = Mapper.Map<ProdutoViewModel, Produto>(produto);
                _produtoAppService.Update(produtoDomain);
                return RedirectToAction("Index");
            }
            return View(produto);
        }

        // GET: Produto/Delete/5
        public ActionResult Delete(int id)
        {
            var produto = _produtoAppService.GetById(id);
            var produtoViewModel = Mapper.Map<Produto, ProdutoViewModel>(produto);
            return View(produtoViewModel);
        }

        // POST: Produto/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfitmed(int id)
        {
            var produto = _produtoAppService.GetById(id);
            _produtoAppService.Remove(produto);
            return RedirectToAction("Index");
        }
    }
}
