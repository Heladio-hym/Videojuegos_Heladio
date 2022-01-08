using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Videojuegos_Heladio.API.Modelos
{
    public class Videojuego
    {

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
