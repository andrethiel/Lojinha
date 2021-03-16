using Lojinha.Models;
using Lojinha.Repository;
using Lojinha.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lojinha.Controllers
{
    public class CarrinhoController : Controller
    {
        private readonly ILancheRepository _lancheRepository;
        private readonly CarrinhoCompra _carrinhoCompra;
        public CarrinhoController(ILancheRepository lancheRepository, CarrinhoCompra carrinhoCompra)
        {
            _lancheRepository = lancheRepository;
            _carrinhoCompra = carrinhoCompra;
        }
        public IActionResult Index()
        {
            var itens = _carrinhoCompra.GetCarrinhoItens();
            _carrinhoCompra.CarrinhoCompraItems = itens;

            var carrinho = new CarrinhoViewModel
            {
                carrinhoCompra = _carrinhoCompra,
                CarrinhoTotal = _carrinhoCompra.GetTotalCarrinho()
            };

            return View(carrinho);
        }

        public RedirectToActionResult Adicionar(int ID)
        {
            var lancheSelecionado = _lancheRepository.Lanches.FirstOrDefault(p => p.ID == ID);
            if(lancheSelecionado != null)
            {
                _carrinhoCompra.AdicionarCarrinho(lancheSelecionado);
            }

            return RedirectToAction("Index");
        }

        public IActionResult RemoverDoCarrinho(int ID)
        {
            var lanche = _lancheRepository.Lanches.FirstOrDefault(p => p.ID == ID);
            if(lanche != null)
            {
                _carrinhoCompra.RemoveCarrinho(lanche);
            }
            return RedirectToAction("Index");

        }
    }
}
