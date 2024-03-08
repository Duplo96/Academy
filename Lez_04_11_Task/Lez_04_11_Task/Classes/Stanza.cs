using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez_04_11_Task.Classes
{
    internal class Stanza
    {
        public string? Nome { get; set; }


        private List<Oggetto> elenco { get; set; } = new List<Oggetto>();


        
        public void aggiungiOggetto(Oggetto oggetto)
        {
            elenco.Add(oggetto);
        }
        
        public void stampaDettagli()
        {
            Console.WriteLine(Nome);
            foreach (Oggetto item in elenco)
            {
                Console.WriteLine(item.ToString());
            }
        }

        


    }
}
