using System;
using System.Collections.Generic;
using System.Text;

namespace AccesoDatos
{
    public interface IAccesoDatos<TEntity> where TEntity : class
    {
        void Crear(TEntity Entidad);
        void Editar(TEntity Entidad);
        TEntity ObtenerPorId(int id);
        IEnumerable<TEntity> Obtener();
        void Eliminar(TEntity Entidad);
    }
}
