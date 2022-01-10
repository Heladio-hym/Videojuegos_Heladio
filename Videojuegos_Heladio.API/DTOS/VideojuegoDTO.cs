using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Videojuegos_Heladio.API.DTOS
{
    public class VideojuegoDTO
    {

        [MaxLength(50)]
        public string Nombre { get; set; }
        public float Precio { get; set; }

    }
}
