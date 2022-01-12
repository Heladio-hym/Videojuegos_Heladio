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
    public class VideojuegosController : ControllerBase
    {
        private readonly Contexto _bd;

        public VideojuegosController(Contexto contexto)
        {
            _bd = contexto;
        }

        [HttpGet]
        public IActionResult Listar()
        {
            var lista = _bd.Videojuego.ToList();

            return Ok(lista);
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult Buscar(int id)
        {
            var obj = _bd.Videojuego.Find(id);

            if (obj == null)
                return NotFound("Videojuego no encontrado");

            return Ok(obj);
        }

        [HttpPost]
        public IActionResult Guardar(VideojuegoDTO obj)
        {
            var nuevo = new Videojuego(obj);
            _bd.Videojuego.Add(nuevo);
            _bd.SaveChanges();
            return Ok(nuevo);
        }

        [HttpPut]
        [Route("{id}/CambiarVideojuego")]
        public IActionResult Modificar(int id, VideojuegoDTO obj)
        {

            var modificar = _bd.Videojuego.Find(id);

            if (modificar == null)
                return NoContent();

            modificar.Nombre = obj.Nombre;
            modificar.Precio = obj.Precio;

            _bd.Videojuego.Update(modificar);
            _bd.SaveChanges();

            return Ok(modificar);
        }

        [HttpPut]
        [Route("{id}/cambiarEstatus")]
        public IActionResult CambiarEstatus(int id)
        {
            var modificar = _bd.Videojuego.Find(id);

            if (modificar == null)
                return NoContent();

            modificar.Disponible = !modificar.Disponible;

            _bd.Entry(modificar).State = EntityState.Modified;
            _bd.SaveChanges();

            return Ok(modificar);
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Borrar(int id)
        {
            var borrar = _bd.Videojuego.Find(id);

            if (borrar == null)
                return NoContent();

            _bd.Videojuego.Remove(borrar);
            _bd.SaveChanges();
            return Ok(borrar);
        }

    }
}
