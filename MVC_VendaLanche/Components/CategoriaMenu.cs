using Microsoft.AspNetCore.Mvc;
using MVC_VendaLanche.Repositories.Interfaces;
using NuGet.Protocol.Core.Types;

namespace MVC_VendaLanche.Components
{
    public class CategoriaMenu  : ViewComponent
    {
        private readonly ICategoriaRepository _categoriaRepository;

        public CategoriaMenu(ICategoriaRepository categoriaRepository)
        {
            _categoriaRepository  = categoriaRepository;
        }

        public IViewComponentResult Invoke()
        {
            var categorias = _categoriaRepository.Categorias.OrderBy(c => c.CategoriaNome);

            return View(categorias);
        }
    }
}
