using Lojinha.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lojinha
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> Categorias { get; }
        
    }
}
