using System.Collections.Generic;

namespace AppVenta.Dominio.Interfaces
{
    public interface IListar<IEntidad, TEntidadID> 
    {
        List<IEntidad> Listar();

        IEntidad SeleccionarPorID(TEntidadID entidadId);
    }
}
