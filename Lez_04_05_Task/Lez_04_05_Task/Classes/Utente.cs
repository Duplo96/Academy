using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez_04_05_Task.Classes
{
    internal class Utente 
    {

        public string? Nome { get; set; }
        public string? Cognome { get; set; }

        public CartaDidentita? Identita { get; set; }
        public CodiceFiscale? Fiscale { get; set; }

        public override string ToString()
        {
            return $"[UTENTE]{Nome},{Cognome} {Identita}{Fiscale}";
        }

    }
}