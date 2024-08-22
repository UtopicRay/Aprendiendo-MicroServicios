using Commerce.Services.CuponAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Commerce.Services.CuponAPI.Context
{
    public class AppDbContext:DbContext
    {
        //Esto siempre es igual
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }
        //Estas son las tablas de la base de datos
        public DbSet<Cupon> Cupons { get; set; }
    }
}
