namespace AppVenta.Dominio.Interfaces.Repositorios
{
    public interface IRepositorioDetalle<IEntidad, TMovimientoID>
        : IAgregar<IEntidad>, ITransaccion
    {
    }
}
