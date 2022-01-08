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
    public class PlataformaController : ControllerBase
    {
        private readonly Contexto _bd;

        public PlataformaController(Contexto contexto)
        {
            _bd = contexto;
        }
        [HttpGet]
        public IActionResult Listar()
        {
            var lista = _bd.Plataforma;
            return Ok(lista);
        }
        [HttpPost]
        public IActionResult Guardar(Plataforma obj)
        {
            _bd.Plataforma.Add(obj);
            _bd.SaveChanges();
            return Ok(obj);
        }
        [HttpPut]
        public IActionResult Modificar(Plataforma obj, int id)
        {

            var modificar = _bd.Plataforma.Find(id);
            modificar.Nombre = obj.Nombre;
            modificar.Activo = obj.Activo;
            _bd.Plataforma.Update(modificar);
            _bd.SaveChanges();
            return Ok(modificar);
        }
        [HttpDelete]
        public IActionResult Borrar(int id)
        {
            var borrar = _bd.Plataforma.Find(id);
            _bd.Plataforma.Remove(borrar);
            _bd.SaveChanges();
            return Ok(borrar);
        }

    }
}
