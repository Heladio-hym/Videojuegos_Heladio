﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Videojuegos_Heladio.API.DTOS
{
    public class VentaDTO
    {
        public string Descripcion { get; set; }

        public int IdCliente { get; set; }

        public int IdVideojuego { get; set; }
    }
}
