using AppVenta.Dominio;
using Microsoft.EntityFrameworkCore;
using AppVenta.Infraestructura.Datos.Configs;

namespace AppVenta.Infraestructura.Datos.Contextos
{
    public class VentaContexto : DbContext
    {
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Venta> Ventas { get; set; }

        public DbSet<VentaDetalle> VentaDetalles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options) {
            options.UseSqlServer(@"Server=localhost;Database=master;Trusted_Connection=True;");

        }

        protected override void OnModelCreating(ModelBuilder builder) {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new ProductoConfig());
            builder.ApplyConfiguration(new VentaConfig());
            builder.ApplyConfiguration(new VentaDetalleConfig());
        }

    }
}
