using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Videojuegos_Heladio.API.DTOS;
using Videojuegos_Heladio.API.Modelos;

namespace Videojuegos_Heladio.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {

        private readonly Contexto _bd;

        public ClienteController(Contexto contexto)
        {
            _bd = contexto;
        }

        [HttpGet]
        public IActionResult Listar()
        {
            var lista = _bd.Cliente.ToList();

            return Ok(lista);
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult Buscar(int id)
        {
            var obj = _bd.Cliente.Find(id);

            if (obj == null)
                return NotFound("Cliente No encontrado");

            return Ok(obj);
        }

        [HttpPost]
        public IActionResult Guardar(ClienteDTO obj)
        {
            var nuevo = new Cliente(obj);
            _bd.Cliente.Add(nuevo);
            _bd.SaveChanges();
            return Ok(nuevo);
        }

        [HttpPut]
        [Route("{id}/CambiarCliente")]
        public IActionResult Modificar(int id, ClienteDTO obj)
        {

            var modificar = _bd.Cliente.Find(id);

            if (modificar == null)
                return NoContent();

            modificar.Nombre = obj.Nombre;
            modificar.Telefono = obj.Telefono;
            modificar.Correo = obj.Correo;
            modificar.Direccion = obj.Direccion;

            _bd.Cliente.Update(modificar);
            _bd.SaveChanges();

            return Ok(modificar);
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Borrar(int id)
        {
            var borrar = _bd.Cliente.Find(id);

            if (borrar == null)
                return NoContent();

            _bd.Cliente.Remove(borrar);
            _bd.SaveChanges();
            return Ok(borrar);
        }

    }
}