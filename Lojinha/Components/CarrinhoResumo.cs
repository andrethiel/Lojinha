using Lojinha.Models;
using Lojinha.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lojinha.Components
{
    public class CarrinhoResumo : ViewComponent
    {
        private readonly CarrinhoCompra _carrinhoCompra;
        public CarrinhoResumo(CarrinhoCompra carrinhoCompra)
        {
            _carrinhoCompra = carrinhoCompra;
        }

        public IViewComponentResult Invoke()
        {
            var itens = _carrinhoCompra.GetCarrinhoItens();
            //var itens = new List<CarrinhoCompraItem>()
            //{
            //    new CarrinhoCompraItem(),
            //    new CarrinhoCompraItem()
            //};
            _carrinhoCompra.CarrinhoCompraItems = itens;

            var carinhoVM = new CarrinhoViewModel
            {
                carrinhoCompra = _carrinhoCompra,
                CarrinhoTotal = _carrinhoCompra.GetTotalCarrinho()
            };

            return View(carinhoVM);
        }
    }
}
