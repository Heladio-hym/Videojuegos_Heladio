using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Videojuegos_Heladio.API.DTOS;

namespace Videojuegos_Heladio.API.Modelos
{
    [Table("Videojuego")]
    public class Videojuego
    {

        public Videojuego()
        {

        }

        public Videojuego(VideojuegoDTO nuevo)
        {
            Nombre = nuevo.Nombre;
            Precio = nuevo.Precio;
            Disponible = true;
            IdPlataforma = nuevo.IdPlataforma;


        }

        [Key]
        public int IdVideojuego { get; set; }

        [Required]
        [MaxLength(50)]
        public string Nombre { get; set; }

        [Required]
        public float Precio { get; set; }

        [Required]
        public bool Disponible { get; set; }

        [Required]
        public int IdPlataforma { get; set; }


        [ForeignKey("IdPlataforma")]
        public virtual Plataforma Plataforma { get; set; }

        public virtual List<Venta> Venta { get; set; }

    }
}
