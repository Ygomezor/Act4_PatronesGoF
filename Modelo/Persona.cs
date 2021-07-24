using System;

namespace Modelo
{
    public class Persona : Identificacion
    {
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string Documento { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int Edad
        {
            get
            {
                return DateTime.Today.AddTicks(-FechaNacimiento.Ticks).Year - 1;
            }
        }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public bool Estado { get; set; } = true;
        public TipoDocumento TipoDocumento { get; set; }
    }
}
