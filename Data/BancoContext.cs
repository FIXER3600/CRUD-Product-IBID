using Microsoft.EntityFrameworkCore;
using ProductProject.Models;

namespace ProductProject.Data
{
    public class BancoContext:DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options):base(options)
        {

        }
        public DbSet<Product> Produtos { get; set; }
    }
}
