using Microsoft.EntityFrameworkCore;
using MVC_VendaLanche.Context;
using MVC_VendaLanche.Models.Entities;
using MVC_VendaLanche.Repositories.Interfaces;

namespace MVC_VendaLanche.Repositories
{
    public class LancheRepository : ILancheRepository
    {
        public readonly AppDbContext _context;
        public LancheRepository(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Lanche> Lanches => _context.Lanches.Include(c => c.Categoria);
        public IEnumerable<Lanche> LanchesPreferidos => _context.Lanches.Where(l => l.IsLanchePreferido).Include(c => c.Categoria);

        public Lanche GetLancheById(int lancheid) 
        {
           return  _context.Lanches.FirstOrDefault(l => l.LancheId == lancheid);
        }
    }
}
