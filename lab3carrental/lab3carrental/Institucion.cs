using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3carrental
{
    class Institucion : Cliente
    {
        string nombre;
        public Institucion (string miId , string miNombre) : base(miId)
        {
            this.nombre = miNombre;
        }
    }
}
