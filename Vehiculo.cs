using Program;
using System;
using System.Collections.Generic;
using System.Text;

namespace POO_Polimorfismo
{
    internal class Vehiculo : Maquinas, InterfaceVehiculo
    {
            private string nombreTransporte;
            public Vehiculo() 
            {

            }
            public Vehiculo(string nombre)
            {
                nombreTransporte = nombre;
            }
            public override void Electrico()
            {
            Console.WriteLine($"El vehículo {nombreTransporte} es electrico");
            }
        public void ArrancarMotor(string palabra)
            {
                Console.WriteLine($"El vehículo {nombreTransporte} arrancó su motor, su sonido es {palabra}");
            }
            public void PararMotor()
            {
                Console.WriteLine($"El vehículo {nombreTransporte} paró su motor");
            }
            public virtual void Conducir()
            {
                Console.WriteLine($"El vehículo {nombreTransporte} está siendo conducido");
            }
            public void setNombre(string nombre)
            {
                this.nombreTransporte = nombre;
            }
            public void getNombre()
            {
                Console.WriteLine($"El nombre del ser vivo es: {nombreTransporte}");
            }

        
    }
}
