using Lojinha.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lojinha.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Lanche> lanchesPreferidos { get; set; }
    }
}
