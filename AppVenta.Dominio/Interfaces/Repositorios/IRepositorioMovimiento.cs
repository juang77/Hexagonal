namespace AppVenta.Dominio.Interfaces.Repositorios
{
    public interface IRepositorioMovimiento<IEntidad, TEntidadID>
        : IAgregar<IEntidad>, IListar<IEntidad, TEntidadID>, ITransaccion
    {
        void Anular(TEntidadID entidadId);
    }
}
