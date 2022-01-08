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
    public class PlataformaController : ControllerBase
    {
        private readonly Contexto _bd;

        public PlataformaController(Contexto contexto)
        {
            _bd = contexto;
        }
        [HttpGet]
        [Route("{id}")]
        public IActionResult Buscar(int id)
        {
            var obj = _bd.Plataforma.Find(id);

            if (obj == null)
                return NotFound();

            return Ok(obj);
        }
        [HttpPost]
        public IActionResult Guardar(PlataformaDTO obj)
        {
            var nuevo = new Plataforma(obj);
            _bd.Plataforma.Add(nuevo);
            _bd.SaveChanges();
            return Ok(nuevo);
        }
        [HttpPut]
        [Route("{id}")]
        public IActionResult Modificar(int id, Plataforma obj)
        {

            var modificar = _bd.Plataforma.Find(id);

            if (modificar == null)
                return NoContent();

            modificar.Nombre = obj.Nombre;
        
            _bd.Plataforma.Update(modificar);
            _bd.SaveChanges();

            return Ok(modificar);
        }

        [HttpPut]
        [Route("{id}/cambiarEstatus")]
        public IActionResult CambiarEstatus(int id)
        {
            var modificar = _bd.Plataforma.Find(id);

            if (modificar == null)
                return NoContent();

            modificar.Activo = !modificar.Activo;

            _bd.Entry(modificar).State = EntityState.Modified;
            //            _db.Color.Add(modificar);
            _bd.SaveChanges();

            return Ok(modificar);
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Borrar(int id)
        {
            var borrar = _bd.Plataforma.Find(id);

            if (borrar == null)
                return NoContent();

            _bd.Plataforma.Remove(borrar);
            _bd.SaveChanges();
            return Ok(borrar);
        }

    }
}
