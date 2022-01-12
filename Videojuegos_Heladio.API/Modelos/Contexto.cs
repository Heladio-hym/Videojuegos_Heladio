using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Videojuegos_Heladio.API.Modelos;

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
