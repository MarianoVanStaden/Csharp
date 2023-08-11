//using Herencia;
//using System;

//namespace Herencia
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Caballo Babieca = new Caballo("Felipe");
//            Humano Pedro = new Humano("Pedro");
//            Gorila Copito = new Gorila("Copito");
//            Mamiferos random = new Mamiferos("Alguno");

//            Mamiferos[] almacenAnimales = new Mamiferos[4];
//            almacenAnimales[0] = Babieca;
//            almacenAnimales[1] = Pedro;
//            almacenAnimales[2] = Copito;
//            almacenAnimales[3] = random;
//            for (int i=0; i < 4; i++) { 
//            almacenAnimales[i].Pensar();
//            }
//            Babieca.Respirar();

//            //Babieca.Respirar();
//            //Babieca.CuidarCrias();
//            //Babieca.Galopar();
//            //Pedro.Pensar();
//            //Pedro.CuidarCrias();
//            //Pedro.Pensar();
//            //Copito.Respirar();
//            //Copito.CuidarCrias();
//            //Copito.Trepar();
//            //Console.WriteLine();
//            //Pedro.Pensar();

//        }
//    }

////mariano

//    class Mamiferos
//    {
//        private string nombreSerVivo;
//        public Mamiferos()
//        {

//        }
//        public Mamiferos(String nombre)
//        {
//            nombreSerVivo = nombre;
//        }
//        protected void Respirar()
//        {
//            Console.WriteLine("Soy capaz de respirar");
//        }
//        public virtual void Pensar()
//        {
//            Console.WriteLine("Pensamiento básico instintivo");
//        }
//        public void CuidarCrias()
//        {
//            Console.WriteLine("Cuido a mis crias hasta que se valgan por sí solas");
//        }
//        public void getNombre()
//        {
//            Console.WriteLine($"El nombre del ser vivo es: {nombreSerVivo}");
//        }
//        public void setNombre(string nombre)
//        {
//            this.nombreSerVivo = nombre;
//        }

//    }
//    class Caballo : Mamiferos
//    {
//        private int numero;
//        public Caballo(String nombreCaballo)
//        {
//           setNombre(nombreCaballo);
//        }
//        public Caballo()
//        {

//        }
//        public Caballo(int numero)
//        {
//            numero = numero;
            
//        }
//        public void Galopar()
//        {
//            Console.WriteLine("Soy capaz de Galopar");
//        }
//        public override void Pensar()
//        {
//            Console.WriteLine("Pensamiento básico elemental");
//        }
        
//    }
//}
//class Gorila : Mamiferos
//{
//    public Gorila()
//    {

//    }
//    public Gorila(String nombreGorila) : base(nombreGorila)
//    {

//    }
//    public void Trepar()
//    {
//        Console.WriteLine("Soy capaz de trepar");
//    }
//    public override void Pensar()
//    {
//        Console.WriteLine("Pensamiento instintivo avanzado");
//    }
//}
//class Humano : Mamiferos
//{
//    public Humano()
//    {

//    }
//    public Humano(String nombreHumano) : base(nombreHumano)
//    {
    
//    }

//    public override void Pensar()
//    {
//        Console.WriteLine("Soy capaz de pensar");
//    }
//}


using Herencia;
using POO_Polimorfismo;
using System;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehiculo random = new Vehiculo("Clase Padre");
            Avion jet = new Avion("Bell-212");
            Coche automovil = new Coche("Fiat-Palio");

            jet.ArrancarMotor("Tracatracatrtaca");
            jet.Despegar();
            jet.Aterrizar();
            jet.PararMotor();

            Vehiculo[] conjunto = new Vehiculo[3];
            conjunto[0] = random;
            conjunto[1] = jet;
            conjunto[2] = automovil;

            foreach(Vehiculo valor in conjunto)
            {
                valor.Conducir();
            }

        }
    }

}
