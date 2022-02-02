namespace AppVenta.Dominio.Interfaces.Repositorios
{
    public interface IRepositorioBase<IEntidad, TEntidadID> 
        : IAgregar<IEntidad>, IEditar<IEntidad>, IEliminar<TEntidadID>, IListar<IEntidad, TEntidadID>, ITransaccion
    {

    }
}
