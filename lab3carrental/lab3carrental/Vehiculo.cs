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
        string motor;
        string consumo;
        public Vehiculo(string mPatente , string mMarca , int mRueda , string mMotor , string mConsumo)
        {
            Patente = mPatente;
            Marca = mMarca;
            rueda = mRueda;
            motor = mMotor;
            consumo = mConsumo;
        }
    }
}
