using Microsoft.EntityFrameworkCore;
using MVC_VendaLanche.Models.Entities;

namespace MVC_VendaLanche.Context
{
    public class AppDbContext : DbContext
    {
         public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
         {        
         }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<CarrinhoCompraItem> CarrinhoCompraItens { get; set; }
        public DbSet<Lanche> Lanches { get; set; }

    }
}
