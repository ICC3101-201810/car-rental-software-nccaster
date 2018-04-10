using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3carrental
{
    class Vehiculo
    {
        string Patente;
        string Marca;
        int rueda;
        string tipo;
        public Vehiculo(string mPatente , string mMarca , int mRueda , string mTipo)
        {
            Patente = mPatente;
            Marca = mMarca;
            rueda = mRueda;
            tipo = mTipo;
        }
    }
}
