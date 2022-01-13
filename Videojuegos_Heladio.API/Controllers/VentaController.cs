using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Videojuegos_Heladio.API.DTOS;
using Videojuegos_Heladio.API.Modelos;

namespace Videojuegos_Heladio.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentaController : ControllerBase
    {

        private readonly Contexto _bd;

        public VentaController(Contexto contexto)
        {
            _bd = contexto;
        }

        [HttpGet]
        public IActionResult Listar()
        {
            var lista = _bd.Venta.ToList();

            return Ok(lista);
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult Buscar(int id)
        {
            var obj = _bd.Venta.Find(id);

            if (obj == null)
                return NotFound("Venta No encontrada");

            return Ok(obj);
        }

        [HttpPost]
        public IActionResult Guardar(VentaDTO obj)
        {
            var nuevo = new Venta(obj);
            _bd.Venta.Add(nuevo);
            _bd.SaveChanges();
            return Ok(nuevo);

        }

        [HttpPut]
        [Route("{id}/CambiarVenta")]
        public IActionResult Modificar(int id, VentaDTO obj)
        {

            var modificar = _bd.Venta.Find(id);

            if (modificar == null)
                return NoContent();

            modificar.Descripcion = obj.Descripcion;
            modificar.IdCliente = obj.IdCliente;
            modificar.IdVideojuego = obj.IdVideojuego;

            _bd.Venta.Update(modificar);
            _bd.SaveChanges();

            return Ok(modificar);
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Borrar(int id)
        {
            var borrar = _bd.Venta.Find(id);

            if (borrar == null)
                return NoContent();

            _bd.Venta.Remove(borrar);
            _bd.SaveChanges();
            return Ok(borrar);
        }

    }
}
