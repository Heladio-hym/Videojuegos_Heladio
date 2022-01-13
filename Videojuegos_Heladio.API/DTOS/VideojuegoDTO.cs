using System.ComponentModel.DataAnnotations;

namespace Videojuegos_Heladio.API.DTOS
{
    public class VideojuegoDTO
    {

        [MaxLength(50)]
        public string Nombre { get; set; }

        public float Precio { get; set; }

        public int IdPlataforma { get; set; }


    }
}
