﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez_04_04_Utilizzo
{
    internal class Indirizzo 
    {
        public string? Via { get; set; }
        public string? Cap{ get; set; }
        public string? Citta{ get; set; }
        public string? Provincia { get; set; }

        public override string ?ToString()
        {
            return $"[INDIRIZZO]\n{Via}\n{Cap}\n{Citta}\n{Provincia}";
        }

    }
}
