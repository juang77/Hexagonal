using System;

namespace AppVenta.Dominio
{
    public class VentaDetalle
    {
        public Guid productoId { get; set; }

        public Guid ventaId { get; set; }

        public decimal costoUnitario { get; set; }

        public decimal precioUnitario { get; set; }

        public decimal cantidadVendida { get; set; }

        public decimal subtotal { get; set; }

        public decimal impuesto { get; set; }

        public decimal total { get; set; }

        public Producto producto { get; set; }

        public Venta venta { get; set; }
    }
}
