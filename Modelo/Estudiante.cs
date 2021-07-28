using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class Estudiante : Persona
    {
        public string Codigo { get; set; }
        public bool EstaMatriculado { get; set; }
        public List<Materia> Materias { get; set; }
    }
}
