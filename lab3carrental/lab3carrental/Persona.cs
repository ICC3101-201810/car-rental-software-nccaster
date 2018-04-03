using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3carrental
{
    class Persona : Cliente
    {
        string Nombre;
        string Apellido;
        string Licencia;
        public Persona (string miId , string miNombre , string miApellido , string miLicencia) : base(miId)
        {
            this.Nombre = miNombre;
            this.Apellido = miApellido;
            this.Licencia = miLicencia;
        }
    }
}
