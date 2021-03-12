using Lojinha.Context;
using Lojinha.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lojinha.Repository
{
    public class LanchesRepository : ILancheRepository
    {
        private readonly DataContext _context;
        public LanchesRepository(DataContext context)
        {
            _context = context;
        }
        public IEnumerable<Lanche> Lanches => _context.Lanches.Include(c => c.Categoria);

        public IEnumerable<Lanche> LanchesPreferidos => _context.Lanches.Where(c => c.LanchePreferido).Include(c => c.Categoria);

        public Lanche GetLancheById(int ID)
        {
            return _context.Lanches.FirstOrDefault(l => l.ID == ID);
        }
    }
}
