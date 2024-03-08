using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez_05_02_StaticiEreditari.Classes
{
    internal class Automobile : Giocattolo
    {

        public bool HasBatterie { get; set; } = false;



       
        public Automobile()
        {

            Console.WriteLine($"[AUTOMOBILE] Costruttore Invocato, sono il giocattolo {contatore}");
           



        }

    }
}
