using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez_05_TaskEdicola.Classes
{
    internal class Rivista : Pubblicazioni
    {
        public int QuantitaDisponibile { get; set; } = 0;

        public Rivista(string? titolo, string? prezzo, string? categoria, int quantitaDisponibile)
        {
            Titolo = titolo;
            Prezzo = prezzo;
            Categoria = categoria;
            DataPubblicazione = DateTime.Now;
            QuantitaDisponibile = quantitaDisponibile;
        }
    }
}
