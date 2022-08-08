using Microsoft.EntityFrameworkCore;

namespace ControleEstoque_BackEnd.Contetx
{
    public class AppDbcontext:DbContext
    {
        public class AppDbContext(DbContextOptions<AppDbcontext> options): base
            {
            }
            public DbSet<Produto> Produtos { get; set }

        public AppDbcontext(DbSet<Produto> produtos)
        {
            Produtos = produtos;
        }
    }
}
