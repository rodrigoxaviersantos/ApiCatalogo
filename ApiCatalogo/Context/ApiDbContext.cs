using ApiCatalogo.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiCatalogo.Context
{
        public class ApiDbContext : DbContext
        {
            public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
            { }

            public DbSet<Categoria> Categorias { get; set; }
            public DbSet<Produto> Produtos { get; set; }

        }

}
