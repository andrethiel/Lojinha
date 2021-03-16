using Lojinha.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lojinha.Models
{
    public class CarrinhoCompra
    {
        private readonly DataContext _context;
        public CarrinhoCompra(DataContext context)
        {
            _context = context;
        }
        public string ID { get; set; }
        public List<CarrinhoCompraItem> CarrinhoCompraItems { get; set; }

        public static CarrinhoCompra GetCarrinho(IServiceProvider service)
        {
            ISession session = service.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

            var context = service.GetService<DataContext>();

            string carrinhoID = session.GetString("ID") ?? Guid.NewGuid().ToString();

            session.SetString("ID", carrinhoID);

            return new CarrinhoCompra(context)
            {
                ID = carrinhoID
            };
        }

        public void AdicionarCarrinho(Lanche lanche)
        {
            var carrinhoCompraItem = _context.CarrinhoCompraItems.SingleOrDefault(s => s.Lanche.ID == lanche.ID && s.CarrinhoCompraID == ID);

            if (carrinhoCompraItem == null)
            {
                carrinhoCompraItem = new CarrinhoCompraItem
                {
                    CarrinhoCompraID = ID,
                    Lanche = lanche,
                    Quantidade = 1
                };

                _context.CarrinhoCompraItems.Add(carrinhoCompraItem);
            }
            else
            {
                carrinhoCompraItem.Quantidade++;
            }
            _context.SaveChanges();
        }

        public int RemoveCarrinho(Lanche lanche)
        {
            var carrinhoCompraItem = _context.CarrinhoCompraItems.SingleOrDefault(s => s.Lanche.ID == lanche.ID && s.CarrinhoCompraID == ID);

            var quantidadeLocal = 0;
            if(carrinhoCompraItem != null)
            {
                if(carrinhoCompraItem.Quantidade > 1)
                {
                    carrinhoCompraItem.Quantidade--;
                    quantidadeLocal = carrinhoCompraItem.Quantidade;
                }
                else
                {
                    _context.CarrinhoCompraItems.Remove(carrinhoCompraItem);
                }
            }
            _context.SaveChanges();
            return quantidadeLocal;
        }

        public List<CarrinhoCompraItem> GetCarrinhoItens() => CarrinhoCompraItems ?? (CarrinhoCompraItems = _context.CarrinhoCompraItems.Where(c => c.CarrinhoCompraID == ID).Include(s => s.Lanche).ToList());

        public void LimparCarrinho()
        {
            var carrinhoItens = _context.CarrinhoCompraItems.Where(c => c.CarrinhoCompraID == ID);
            _context.CarrinhoCompraItems.RemoveRange(carrinhoItens);
            _context.SaveChanges();
        }

        public decimal GetTotalCarrinho()
        {
            var total = _context.CarrinhoCompraItems.Where(c => c.CarrinhoCompraID == ID)
                .Select(c => c.Lanche.Preco * c.Quantidade).Sum();

            return total;
        }
    }
}
