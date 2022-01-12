using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Videojuegos_Heladio.API.DTOS;

namespace Videojuegos_Heladio.API.Modelos
{
    [Table("Venta")]
    public class Venta
    {

        public Venta()
        {

        }

        public Venta(VentaDTO nuevo)
        {
            Fecha = DateTime.Now;
            IdCliente = nuevo.IdCliente;
            IdVideojuego = nuevo.IdVideojuego;


        }

        [Key]
        public int IdVenta { get; set; }

        [Required]
        public DateTime Fecha { get; set; }

        [Required]
        public int IdCliente { get; set; }

        [Required]
        public int IdVideojuego { get; set; }

        [ForeignKey("IdCliente")]
        public virtual Cliente Cliente { get; set; }

        [ForeignKey("IdVideojuego")]
        public virtual Videojuego Videojuego { get; set; }

    }
}
