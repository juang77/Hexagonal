using System;
using System.Collections.Generic;
using System.Text;

namespace AppVenta.Dominio.Interfaces
{
    public interface IAgregar<IEntidad>
    {
        IEntidad Agregar(IEntidad entidad);
    }
}
