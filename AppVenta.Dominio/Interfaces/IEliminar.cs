namespace AppVenta.Dominio.Interfaces
{
    public interface IEliminar<IEntidadID> 
    {
        void Eliminar(IEntidadID entidadId);
    }
}
