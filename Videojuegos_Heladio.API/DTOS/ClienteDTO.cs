using System.ComponentModel.DataAnnotations;

namespace Videojuegos_Heladio.API.DTOS
{
    public class ClienteDTO
    {

        [MaxLength(90)]
        public string Nombre { get; set; }
        [MaxLength(10)]
        public string Telefono { get; set; }
        [MaxLength(120)]
        public string Correo { get; set; }
        [MaxLength(250)]
        public string Direccion { get; set; }

    }
}
