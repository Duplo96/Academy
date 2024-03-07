using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez_04_04_Utilizzo
{
    internal class Utente
    {
        public string? Nominativo { get; set; }

        

        public Indirizzo? Spedizione { get; set; }

        

        public Indirizzo? Fatturazione { get; set; }

        public override string ToString()
        {
            return $"[UTENTE]\n{Spedizione}\n{Fatturazione}\n";
        }

    }
}
