using System.ComponentModel.DataAnnotations;

namespace Videojuegos_Heladio.API.DTOS
{
    public class VentaDTO
    {
        [MaxLength(100)]
        public string Descripcion { get; set; }

        public int IdCliente { get; set; }

        public int IdVideojuego { get; set; }
    }
}
