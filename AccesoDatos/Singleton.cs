using System;
using System.Collections.Generic;

namespace AccesoDatos
{
    public class Singleton<TEntity>: IAccesoDatos<TEntity> where TEntity : class
    {
        private static Singleton<TEntity> instancia = null;
        protected Singleton()
        {

        }
        public static Singleton<TEntity> Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new Singleton<TEntity>();
                }
                return instancia;
            }
        }

        public void Crear(TEntity Entidad)
        {
            Console.WriteLine($"Se ha creado {Entidad.GetType().Name}");
        }

        public void Editar(TEntity Entidad)
        {
            Console.WriteLine($"Se ha editado {Entidad.GetType().Name}");
        }

        public void Eliminar(TEntity Entidad)
        {
            Console.WriteLine($"Se ha eliminado {Entidad.GetType().Name}");
        }

        public IEnumerable<TEntity> Obtener()
        {
            return null;
        }

        public TEntity ObtenerPorId(int id)
        {
            if (id==0)
            {
                Console.WriteLine("No existe estudiante");
                return null;
            }
            return null;
        }
    }
}
