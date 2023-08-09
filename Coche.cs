using System;
using System.Collections.Generic;
using System.Text;

namespace POO_Polimorfismo
{
    internal class Coche : Vehiculo, InterfaceCoche
    {
        private string nombre;
        public Coche(string nombre)
        {
            setNombre(nombre);
        }
        public override void Conducir()
        {
            Console.WriteLine($"El vehículo {nombre} circula por las calles");
        }
        public void Acelerar()
        {
            Console.WriteLine($"El {nombre} está acelerando");
        }
        public void Frenar()
        {
            Console.WriteLine($"El {nombre} está frenando");
        }
    }
}
