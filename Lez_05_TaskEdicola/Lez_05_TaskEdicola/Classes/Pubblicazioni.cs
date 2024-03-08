using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

using System;

namespace Lez_05_TaskEdicola.Classes
{
    internal abstract class Pubblicazioni
    {
        public  string? Titolo { get; set; }
        public  string? Prezzo { get; set; }
        public string? Categoria { get; set; }
        public DateTime DataPubblicazione { get; set; }

        public Pubblicazioni() { }

        public Pubblicazioni(string? titolo, string? prezzo, string? categoria, DateTime dataDiPubblicazione)
        {
            Titolo = titolo;
            Prezzo = prezzo;
            Categoria = categoria;
            DataPubblicazione = dataDiPubblicazione;
        }

        public override string ToString()
        {
            return $"Titolo: {Titolo}, Prezzo: {Prezzo}, Categoria: {Categoria}";
        }
    }
}

