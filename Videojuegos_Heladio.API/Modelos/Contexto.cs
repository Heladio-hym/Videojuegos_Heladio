using Microsoft.EntityFrameworkCore;

namespace Videojuegos_Heladio.API.Modelos
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> Options) : base(Options)
        {

        }

        public DbSet<Videojuego> Videojuego { get; set; }

        public DbSet<Cliente> Cliente { get; set; }

        public DbSet<Plataforma> Plataforma { get; set; }
        
        public DbSet<Venta> Venta { get; set; }

    }
}
