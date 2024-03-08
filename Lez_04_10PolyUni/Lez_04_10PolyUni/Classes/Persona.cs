using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez_04_10PolyUni.Classes
{
    internal abstract class Persona
    {


        public string? Nome { get; set; }
        public string? Cognome { get; set; }


        public virtual void stampaDettaglio()
        {
            Console.WriteLine($"[PERSONA]{Nome}{Cognome}");
        }



    }
}
