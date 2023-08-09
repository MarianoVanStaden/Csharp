using System;
using System.Collections.Generic;
using System.Text;

namespace POO_Polimorfismo
{
    internal interface InterfaceVehiculo
    {
        void ArrancarMotor(string x);
        void PararMotor();

        void Conducir();

        void setNombre(string nombre);

        void getNombre();

    }
}
