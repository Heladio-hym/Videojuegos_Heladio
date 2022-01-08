using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Videojuegos_Heladio.API.Modelos
{
    public class Plataforma
    {

        [Key]
        public int IdPlataforma { get; set; }

        [Required]
        [MaxLength(30)]
        public String Nombre { get; set; }

        [Required]
        public bool Activo { get; set; }

        public virtual List<Videojuego> Videojuego { get; set; }
    }
}
