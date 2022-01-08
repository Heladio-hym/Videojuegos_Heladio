using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Videojuegos_Heladio.API.Modelos;

namespace Videojuegos_Heladio.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideojuegoController : ControllerBase
    {
        private readonly Contexto _bd;

        public VideojuegoController(Contexto contexto)
        {
            _bd = contexto;
        }
        [HttpGet]
        public IActionResult Listar()
        {
            var lista = _bd.Videojuego;
            return Ok(lista);
        }
        [HttpPost]
        public IActionResult Guardar(Videojuego obj)
        {
            _bd.Videojuego.Add(obj);
            _bd.SaveChanges();
            return Ok(obj);
        }
        [HttpPut]
        public IActionResult Modificar(Videojuego obj, int id)
        {

            var modificar = _bd.Videojuego.Find(id);
            modificar.Nombre = obj.Nombre;
            modificar.Disponible = obj.Disponible;
            modificar.Precio = obj.Precio;
            _bd.Videojuego.Update(modificar);
            _bd.SaveChanges();
            return Ok(modificar);
        }
        [HttpDelete]
        public IActionResult Borrar(int id)
        {
            var borrar = _bd.Videojuego.Find(id);
            _bd.Videojuego.Remove(borrar);
            _bd.SaveChanges();
            return Ok(borrar);
        }

    }
}
