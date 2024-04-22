using Microsoft.AspNetCore.Mvc;
using MVC_VendaLanche.Models;
using MVC_VendaLanche.Repositories.Interfaces;
using MVC_VendaLanche.ViewModels;
using System.Diagnostics;

namespace MVC_VendaLanche.Controllers
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
            var homeViewModel = new HomeViewModel
            {
                LanchesPreferidos = _lancheRepository.LanchesPreferidos
            };
            return View(homeViewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
