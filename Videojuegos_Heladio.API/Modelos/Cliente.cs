﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Videojuegos_Heladio.API.Modelos
{
    public class Cliente
    {

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

    }
}