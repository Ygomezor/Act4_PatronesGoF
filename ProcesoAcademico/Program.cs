using Modelo;
using Negocio;
using System;

namespace ProcesoAcademico
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudiante estudiante = LlenarDatosEstudiante();
            RepositorioEstudiante<Estudiante> repositorio = new RepositorioEstudiante<Estudiante>();
            if (repositorio.ObtenerPorId(estudiante.Id)==null)
            {
                repositorio.Crear(estudiante);
            }
            repositorio.Matricular(estudiante);

            Console.ReadKey();
        }

        public static Estudiante LlenarDatosEstudiante()
        {
            return new Estudiante
            {
                Apellido = "Gomez",
                Nombre = "Alexandra",
                Codigo = "12323343",
                Direccion = "Av siempre viva",
                Documento = "234567890",
                TipoDocumento = new TipoDocumento { Id = 1, Nombre = "CC" },
                EstaMatriculado = true,
                FechaNacimiento = new DateTime(1988, 11, 18),
                Telefono = "3123549932"
            };
        }
    }
}
