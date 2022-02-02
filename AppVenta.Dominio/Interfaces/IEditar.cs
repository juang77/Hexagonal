using System;
using System.Collections.Generic;
using System.Text;

namespace AppVenta.Dominio.Interfaces
{
    public interface IEditar<IEntidad>
    {
        void Editar(IEntidad entidad);
    }
}
