using MVC_VendaLanche.Models.Entities;

namespace MVC_VendaLanche.ViewModels
{
    public class LancheListViewModel
    {
        public IEnumerable<Lanche> Lanches { get; set; }
        public string CategoriaAtual {  get; set; }
    }
}
