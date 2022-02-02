using AppVenta.Dominio;
using AppVenta.Dominio.Interfaces.Repositorios;
using AppVenta.Infraestructura.Datos.Contextos;
using System;
using System.Collections.Generic;
using System.Linq;


namespace AppVenta.Infraestructura.Datos.Repositorios
{
    public class VentaRepositorio : IRepositorioMovimiento<Venta, Guid>
    {
        private VentaContexto db;

        public VentaRepositorio(VentaContexto _db)
        {
            db = _db;
        }

        public Venta Agregar(Venta entidad)
        {
            entidad.ventaId = Guid.NewGuid();
            db.Ventas.Add(entidad);
            return entidad;
        }

        public void Anular(Guid entidadId)
        {
            var VentaSeleccionada = db.Ventas.Where(c => c.ventaId == entidadId).FirstOrDefault();
            if (VentaSeleccionada == null)
            {
                throw new NullReferenceException("Usted esta intentando anular una venta inexistente.");
            }

            VentaSeleccionada.anulado = true;
            db.Entry(VentaSeleccionada).State = Microsoft.EntityFrameworkCore.EntityState.Modified;


        }

        public void GuardarTodosLosCambios()
        {
            db.SaveChanges();
        }

        public List<Venta> Listar()
        {
            return db.Ventas.ToList();
        }

        public Venta SeleccionarPorID(Guid entidadId)
        {
            var VentaSeleccionada = db.Ventas.Where(c => c.ventaId == entidadId).FirstOrDefault();
            return VentaSeleccionada;
        }
    }
}
