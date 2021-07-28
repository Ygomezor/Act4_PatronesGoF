using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class Materia : NombreObjeto, ICloneable
    {
        public int Creditos { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
