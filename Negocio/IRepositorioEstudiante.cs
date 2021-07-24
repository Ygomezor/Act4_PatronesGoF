using System;
using System.Collections.Generic;
using System.Text;

namespace Negocio
{
    interface IRepositorioEstudiante<TEntity> where TEntity : class
    {
        void Matricular(TEntity Entidad);
    }
}
