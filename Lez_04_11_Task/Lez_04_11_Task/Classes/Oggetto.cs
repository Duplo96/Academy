using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez_04_11_Task.Classes
{
    internal class Oggetto
    {


        public string? Nome { get; set; }
        public string? Descrizione { get; set; }
        public string? Valore { get; set;}


        public override string ToString()
        {
            return $"[OGGETTO]{Nome} {Descrizione} {Valore}€";
        }

    }
}
