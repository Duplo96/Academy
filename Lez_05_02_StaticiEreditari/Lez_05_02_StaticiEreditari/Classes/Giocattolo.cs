using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez_05_02_StaticiEreditari.Classes
{
    internal abstract class Giocattolo
    {

        public string? Materiale { get; set; }
        public int EtaMinima { get; set; } = 3;

        

        protected static int contatore= 0;

        public static int Contatore
        {
            get { return contatore; }
        }
        
        


        public Giocattolo()
        {
            Console.WriteLine("[GIOCATTOLO] Costruttore Invocato");
            contatore++;
        }


    }
}
