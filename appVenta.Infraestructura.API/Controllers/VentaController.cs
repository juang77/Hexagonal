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
    public class VentaController : ControllerBase
    {
        VentaServicio CrearServicio()
        {
            VentaContexto db = new VentaContexto();
            VentaRepositorio repoVenta = new VentaRepositorio(db);
            ProductoRepositorio repoProducto = new ProductoRepositorio(db);
            VentaDetalleRepositorio repoDEtalle = new VentaDetalleRepositorio(db);
            VentaServicio servicio = new VentaServicio(repoVenta, repoProducto, repoDEtalle);
            return servicio;
        }

        // GET: api/<VentaController>
        [HttpGet]
        public ActionResult<List<Venta>> Get()
        {
            var servicio = CrearServicio();
            return Ok(servicio.Listar());
        }

        // GET api/<VentaController>/5
        [HttpGet("{id}")]
        public ActionResult<Venta> Get(Guid id)
        {
            var servicio = CrearServicio();
            return Ok(servicio.SeleccionarPorID(id));
        }

        // POST api/<VentaController>
        [HttpPost]
        public ActionResult Post([FromBody] Venta venta)
        {
            var servicio = CrearServicio();
            servicio.Agregar(venta);
            return Ok("Agregado satisfactoriamente!!!!");
        }


        // DELETE api/<VentaController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(Guid id)
        {
            var servicio = CrearServicio();
            servicio.Anular(id);
            return Ok("Venta Anulada satisfactoriamente!!!!");
        }
    }
}
