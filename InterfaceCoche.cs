using System;
using System.Collections.Generic;
using System.Text;

namespace POO_Polimorfismo
{
    internal interface InterfaceCoche : InterfaceVehiculo
    {
        void Acelerar();
        void Frenar();
    }
}
