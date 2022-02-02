using AppVenta.Dominio.Interfaces;

namespace AppVenta.Aplicaciones.Interfaces
{
    public interface IServicioBase<TEntidad, TEntidadID>
        : IAgregar<TEntidad>, IEditar<TEntidad>, IEliminar<TEntidadID>, IListar<TEntidad, TEntidadID>
    {
    }
}
