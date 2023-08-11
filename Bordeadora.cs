using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Bordeadora : Maquinas
    {
        public override void Electrico()
        {
            Console.WriteLine("Esta maquina es electrica");    
        }
    }
}
