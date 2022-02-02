using AppVenta.Dominio;
using AppVenta.Dominio.Interfaces.Repositorios;
using AppVenta.Infraestructura.Datos.Contextos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AppVenta.Infraestructura.Datos.Repositorios
{
    public class ProductoRepositorio : IRepositorioBase<Producto, Guid>
    {
        private VentaContexto db;

        public ProductoRepositorio(VentaContexto _db) {
            db = _db;
        }

        public Producto Agregar(Producto entidad)
        {
            entidad.productoId = Guid.NewGuid();
            db.Productos.Add(entidad);
            return entidad;
        }

        public void Editar(Producto entidad)
        {
            var productoSeleccionado = db.Productos.Where(c => c.productoId == entidad.productoId).FirstOrDefault();
            if (productoSeleccionado != null) {
                productoSeleccionado.nombre = entidad.nombre;
                productoSeleccionado.descripcion = entidad.descripcion;
                productoSeleccionado.costo = entidad.costo;
                productoSeleccionado.precio = entidad.precio;
                productoSeleccionado.cantidadEnStock = entidad.cantidadEnStock;

                db.Entry(productoSeleccionado).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }
        }

        public void Eliminar(Guid entidadId)
        {
            var productoSeleccionado = db.Productos.Where(c => c.productoId == entidadId).FirstOrDefault();
            if (productoSeleccionado != null)
            {
                db.Productos.Remove(productoSeleccionado);

                db.Entry(productoSeleccionado).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }
        }

        public void GuardarTodosLosCambios()
        {
            db.SaveChanges();
        }

        public List<Producto> Listar()
        {
            return db.Productos.ToList();
        }

        public Producto SeleccionarPorID(Guid entidadId)
        {
            var productoSeleccionado = db.Productos.Where(c => c.productoId == entidadId).FirstOrDefault();
            return productoSeleccionado;
        }
    }
}
