using Lojinha.Repository;
using Lojinha.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lojinha.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILancheRepository _lancheRepository;
        public HomeController(ILancheRepository lancheRepository)
        {
            _lancheRepository = lancheRepository;
        }
        public IActionResult Index()
        {
            var homeView = new HomeViewModel
            {
                lanchesPreferidos = _lancheRepository.LanchesPreferidos
            };
            return View(homeView);
        }
    }
}
