using System;
using System.Collections.Generic;
using System.Text;

namespace Negocio
{
    public interface IRepositorioEstudiante<TEntity> where TEntity : class
    {
        void Matricular(TEntity Entidad);
        void AddMateria(TEntity entity);
        List<TEntity> ListarMaterias();
    }
}
