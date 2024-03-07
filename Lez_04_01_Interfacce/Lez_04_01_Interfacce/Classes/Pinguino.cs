using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez_04_01_Interfacce.Classes
{
    internal class Pinguino : IAnimale
    {
        public bool Criniera { get; set; }

        public void versoEmesso() {

            Console.WriteLine("BOH");
                }
        public void tipoMovimento()
        {
        Console.WriteLine("Cammina");
            
            }

   
    }
}
