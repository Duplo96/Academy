﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez_04_03_Task.Classes
{
    internal  class Veicolo
    {
        

        public int Telaio { get; set; }

        public int NumeroPorte { get; set; }

        public override string ToString()
        {


            return $" Telaio: {Telaio} Numero porte: {NumeroPorte} ";
        }
    }
}
