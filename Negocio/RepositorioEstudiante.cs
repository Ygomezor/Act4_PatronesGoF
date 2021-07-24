using AccesoDatos;
using System;
using System.Collections.Generic;

namespace Negocio
{
    public class RepositorioEstudiante<TEntity> : IRepositorio<TEntity> where TEntity : class
    {
        public RepositorioEstudiante()
        {

        }
        public void Crear(TEntity Entidad)
        {
            Singleton<TEntity>.Instancia.Crear(Entidad);
        }

        public void Editar(TEntity Entidad)
        {
            Singleton<TEntity>.Instancia.Editar(Entidad);
        }

        public void Eliminar(TEntity Entidad)
        {
            Singleton<TEntity>.Instancia.Eliminar(Entidad);
        }

        public IEnumerable<TEntity> Obtener()
        {
            return Singleton<TEntity>.Instancia.Obtener();
        }

        public TEntity ObtenerPorId(int id)
        {
            return Singleton<TEntity>.Instancia.ObtenerPorId(id);
        }

        public void Matricular(TEntity Entidad)
        {
            Singleton<TEntity>.Instancia.Crear(Entidad);
        }
    }
}
