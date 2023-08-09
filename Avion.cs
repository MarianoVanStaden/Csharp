using System;
using System.Collections.Generic;
using System.Text;


namespace POO_Polimorfismo
{
    internal class Avion : Vehiculo, InterfaceAvion
    {
        private string nombre;
        public Avion(string nombre)
        {
            setNombre(nombre);
        }

        public override void Conducir()
        {
            Console.WriteLine($"El vehículo {nombre} vuela por los aires");
        }
        public  void Despegar()
        {
            Console.WriteLine($"El {nombre} despegó de la pista de vuelo");
        }
        public  void Aterrizar()
        {
            Console.WriteLine($"El {nombre} aterrizó en la pista de vuelo");
        }
    }
}
