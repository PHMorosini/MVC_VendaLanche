using MVC_VendaLanche.Models.Entities;

namespace MVC_VendaLanche.Repositories.Interfaces
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> Categorias { get; }
    }
}
