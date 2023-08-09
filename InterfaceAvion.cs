using System;
using System.Collections.Generic;
using System.Text;

namespace POO_Polimorfismo
{
    internal interface InterfaceAvion : InterfaceVehiculo
    {
        void Aterrizar();
        void Despegar();
    }
}
