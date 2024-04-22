using MVC_VendaLanche.Context;
using MVC_VendaLanche.Models.Entities;
using MVC_VendaLanche.Repositories.Interfaces;

namespace MVC_VendaLanche.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> Categorias => _context.Categorias;


    }
}
