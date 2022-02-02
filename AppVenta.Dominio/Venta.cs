using System;
using System.Collections.Generic;

namespace AppVenta.Dominio
{
    public class Venta
    {
        public Guid ventaId { get; set; }

        public long numeroVenta { get; set; }

        public string concepto { get; set; }

        public decimal subtotal { get; set; }

        public decimal impuesto { get; set; }

        public decimal total { get; set; }

        public Boolean anulado { get; set; } = false;

        public List<VentaDetalle> VentaDetalles { get; set; }
    }
}
