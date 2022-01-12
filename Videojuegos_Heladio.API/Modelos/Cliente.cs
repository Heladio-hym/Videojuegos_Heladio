using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Videojuegos_Heladio.API.DTOS;

namespace Videojuegos_Heladio.API.Modelos
{
    [Table("Cliente")]
    public class Cliente
    {

        public Cliente()
        {

        }

        public Cliente(ClienteDTO nuevo)
        {
            Nombre = nuevo.Nombre;
            Telefono = nuevo.Telefono;
            Correo = nuevo.Correo;
            Direccion = nuevo.Direccion;
        }

        [Key]
        public int IdCliente { get; set; }
        [Required]
        [MaxLength(90)]
        public string Nombre { get; set; }
        [MaxLength(10)]
        public string Telefono { get; set; }
        [MaxLength(120)]
        public string Correo { get; set; }
        [MaxLength(250)]
        public string Direccion { get; set; }

        public virtual List<Venta> Venta { get; set; }

    }
}
