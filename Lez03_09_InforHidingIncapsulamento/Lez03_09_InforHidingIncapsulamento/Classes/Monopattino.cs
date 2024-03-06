using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez03_09_InforHidingIncapsulamento.Classes
{
    internal class Monopattino
    {

        public string? Marca {get; set; }
        public float VelMax { get;} = 24.0f; //non voglio che qualcuno la setti quindi cancello set


        private int numPersone;

        public int NumPersone
        {
            get { return numPersone; }
            set {
                if (value >= 0)
                    numPersone = value;
                else
                    Console.WriteLine("Errore");


        }
        }

    }
}
