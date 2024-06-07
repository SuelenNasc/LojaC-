using Microsoft.EntityFrameworkCore;
using Loja.models;

namespace Loja.data
{
    public class LojaDbContext : DbContext{
            public LojaDbContext(DbContextOptions<LojaDbContext> options) : base(options){}
            public DbSet<Produto> Produtos { get; set; }
    }
}
