using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez_04_05_Task.Classes
{
    internal class CodiceFiscale
    {
        public string? Codice { get; set; }
        public DateTime DataScadenza { get; set; }

        public override string ToString()
        {
            return $"[CODFIS] {Codice} {DataScadenza.ToString("dd / MM / yyyy")}";
        }

    }
}
