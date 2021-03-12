using Lojinha.Context;
using Lojinha.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lojinha.Repository
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly DataContext _context;
        public CategoriaRepository(DataContext context)
        {
            _context = context;
        }
        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}
