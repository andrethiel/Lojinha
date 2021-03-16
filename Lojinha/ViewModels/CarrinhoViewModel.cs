using Lojinha.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lojinha.ViewModels
{
    public class CarrinhoViewModel
    {
        public CarrinhoCompra carrinhoCompra { get; set; }
        public decimal CarrinhoTotal { get; set; }

    }
}
