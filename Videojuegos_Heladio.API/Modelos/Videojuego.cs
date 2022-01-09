using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Videojuegos_Heladio.API.DTOS;

namespace Videojuegos_Heladio.API.Modelos
{
    public class Videojuego
    {

        public Videojuego()
        {

        }

        public Videojuego(VideojuegoDTO nuevo)
        {
            this.Nombre = nuevo.Nombre;
            this.Precio = nuevo.Precio;
            this.Disponible = true;
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


        [ForeignKey("IdPlataforma")]
        public virtual Plataforma Plataforma { get; set; }


    }
}
