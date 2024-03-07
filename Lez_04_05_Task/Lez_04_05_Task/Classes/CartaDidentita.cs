using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Lez_04_05_Task.Classes
{
    internal class CartaDidentita : CodiceFiscale
    {
        public DateTime DataEmissione { get; set; }


        private string? luogoEmissione;

        public string? LuogoEmissione
        {
            get { return luogoEmissione; }
            set
            {
                if (value is not null && (value.Equals("Comune") || value.Equals("Zecca dello stato")))

                    luogoEmissione = value;
                else Console.WriteLine("ERRRORE DI EMISSIONE");
            }

        }
        public override string ToString()
        {
            return $"[CARTADID]{Codice} {DataScadenza.ToString("dd/MM/yyyy")} {DataEmissione.ToString("dd/MM/yyyy")} {LuogoEmissione}";
        }

    } 
}
