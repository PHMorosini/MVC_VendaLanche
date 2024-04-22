using Microsoft.AspNetCore.Mvc;
using MVC_VendaLanche.Models.Entities;
using MVC_VendaLanche.Repositories.Interfaces;
using MVC_VendaLanche.ViewModels;

namespace MVC_VendaLanche.Controllers
{
    public class CategoriaListController : Controller
    {

        private ICategoriaRepository _categoriaRepository;

        public CategoriaListController(ICategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }
        

        public IActionResult List()
        {
            IEnumerable<Categoria> categorias;
            categorias = _categoriaRepository.Categorias.OrderBy(c => c.CategoriaNome);
            var CategoriasListViewModel = new CategoriasListViewModel
            {
                Categorias = categorias
            };
            return View(CategoriasListViewModel);
        }
    }
}
