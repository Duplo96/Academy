using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez_05_TaskEdicola.Classes
{
    internal class Giornale : Pubblicazioni
    {
        public int QuantitaDisponibile { get; set; } = 0;

        public Giornale(string? titolo, string? prezzo, string? categoria, int quantitaDisponibile)
        {
            Titolo = titolo;
            Prezzo = prezzo;
            Categoria = categoria;
            DataPubblicazione = DateTime.Now;
            QuantitaDisponibile = quantitaDisponibile;
        }
    }
}

