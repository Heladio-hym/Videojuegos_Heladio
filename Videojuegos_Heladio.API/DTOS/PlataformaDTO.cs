using System.ComponentModel.DataAnnotations;

namespace Videojuegos_Heladio.API.DTOS
{
    public class PlataformaDTO
    {

        [MaxLength(30)]
        public string Nombre { get; set; }

    }
}
