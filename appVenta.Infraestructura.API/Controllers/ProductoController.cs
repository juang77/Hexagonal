using AppVenta.Aplicaciones.Servicios;
using AppVenta.Dominio;
using AppVenta.Infraestructura.Datos.Contextos;
using AppVenta.Infraestructura.Datos.Repositorios;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;


namespace appVenta.Infraestructura.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        ProductoServicio CrearServicio()
        {
            VentaContexto db = new VentaContexto();
            ProductoRepositorio repo = new ProductoRepositorio(db);
            ProductoServicio servicio = new ProductoServicio(repo);
            return servicio;
        }

        // GET: api/<ProductoController>
        [HttpGet]
        public ActionResult<List<Producto>> Get()
        {
            var servicio = CrearServicio();
            return Ok(servicio.Listar());
        }

        // GET api/<ProductoController>/5
        [HttpGet("{id}")]
        public ActionResult<Producto> Get(Guid id)
        {
            var servicio = CrearServicio();
            return Ok(servicio.SeleccionarPorID(id));
        }

        // POST api/<ProductoController>
        [HttpPost]
        public ActionResult Post([FromBody] Producto producto)
        {
            var servicio = CrearServicio();
            servicio.Agregar(producto);
            return Ok("Agregado satisfactoriamente!!!!");
        }

        // PUT api/<ProductoController>/5
        [HttpPut("{id}")]
        public ActionResult Put(Guid id, [FromBody] Producto producto)
        {
            var servicio = CrearServicio();
            servicio.Editar(producto);
            return Ok("Editado satisfactoriamente!!!!");
        }

        // DELETE api/<ProductoController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(Guid id)
        {
            var servicio = CrearServicio();
            servicio.Eliminar(id);
            return Ok("Eliminado satisfactoriamente!!!!");
        }
    }
}
