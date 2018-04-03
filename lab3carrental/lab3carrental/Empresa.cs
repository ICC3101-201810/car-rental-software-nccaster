using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3carrental
{
    class Empresa : Cliente
    {
        string Nombre;
        string autorizacion;
        public Empresa (string miId , string miNombre , string miAutorizacion) : base(miId)
        {
            this.Nombre = miNombre;
            this.autorizacion = miAutorizacion;
        }
    }
}
