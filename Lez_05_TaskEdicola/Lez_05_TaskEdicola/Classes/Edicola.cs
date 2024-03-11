using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;

namespace Lez_05_TaskEdicola.Classes
{
    internal class Edicola
    {
        public List<Pubblicazioni> Elenco = new List<Pubblicazioni>();
       
        public void Benvenuto()
        {
            Console.WriteLine("Benvenuto all'Edicola. Scegli un'opzione:");
            Console.WriteLine("1. Aggiungi un nuovo giornale");
            Console.WriteLine("2. Aggiungi una nuova rivista");
            Console.WriteLine("3. Rimuovi una pubblicazione");
            Console.WriteLine("4. Visualizza l'elenco delle pubblicazioni");
            Console.WriteLine("5. Aggiorna la quantità disponibile di una pubblicazione");
            Console.WriteLine("6. Cerca per titolo, data o categoria");
            Console.WriteLine("Q. Esci");
        }

        public void AggiungiGiornale()
        {
            Console.WriteLine("Hai scelto di inserire un giornale");
            Console.WriteLine("Inserisci il Titolo");
            string? inputTitolo = Console.ReadLine();
            Console.WriteLine("Inserisci il Prezzo");
            string? inputPrezzo = Console.ReadLine();
            Console.WriteLine("Inserisci la Categoria");
            string? inputCategoria = Console.ReadLine();

            Console.WriteLine("Inserisci la quantità disponibile:");
            if (int.TryParse(Console.ReadLine(), out int quantitaDisponibile))
            {
                Giornale nuovoGiornale = new Giornale(inputTitolo, inputPrezzo, inputCategoria, quantitaDisponibile);
                Elenco.Add(nuovoGiornale);
            }
            else
            {
                Console.WriteLine("Quantità non valida.");
            }
        }

        public void AggiungiRivista()
        {
            Console.WriteLine("Hai scelto di inserire una rivista");
            Console.WriteLine("Inserisci il Titolo");
            string? inputTitolo = Console.ReadLine();
            Console.WriteLine("Inserisci il Prezzo");
            string? inputPrezzo = Console.ReadLine();
            Console.WriteLine("Inserisci la Categoria");
            string? inputCategoria = Console.ReadLine();

            Console.WriteLine("Inserisci la quantità disponibile:");
            if (int.TryParse(Console.ReadLine(), out int quantitaDisponibile))
            {
                Rivista nuovaRivista = new Rivista(inputTitolo, inputPrezzo, inputCategoria, quantitaDisponibile);
                Elenco.Add(nuovaRivista);
            }
            else
            {
                Console.WriteLine("Quantità non valida.");
            }
        }
        public void AggiornaQuantitaDisponibile()
        {
            Console.WriteLine("Aggiorna la quantità disponibile di una pubblicazione.");
            Console.WriteLine("Inserisci il Titolo della pubblicazione da aggiornare:");
            string? inputTitolo = Console.ReadLine();

            Console.WriteLine("Inserisci la nuova quantità disponibile:");
            if (int.TryParse(Console.ReadLine(), out int nuovaQuantita))
            {
                bool pubblicazioneTrovata = false;

                foreach (Pubblicazioni pubblicazione in Elenco)
                {
                    if (pubblicazione.Titolo == inputTitolo)
                    {
                        pubblicazioneTrovata = true;

                        if (pubblicazione is Giornale giornale)
                        {
                            giornale.QuantitaDisponibile = nuovaQuantita;
                        }
                        else if (pubblicazione is Rivista rivista)
                        {
                            rivista.QuantitaDisponibile = nuovaQuantita;
                        }

                        Console.WriteLine($"Quantità disponibile aggiornata per '{pubblicazione.Titolo}'.");
                        break;
                    }
                }

                if (!pubblicazioneTrovata)
                {
                    Console.WriteLine($"Nessuna pubblicazione con titolo '{inputTitolo}' trovata nell'inventario.");
                }
            }
            else
            {
                Console.WriteLine("Quantità non valida.");
            }
        }



        public void Rimuovi()
        {
            Console.WriteLine("Rimuovi");
            Console.WriteLine("Inserisci il Titolo");
            string? inputTitolo = Console.ReadLine();

            bool pubblicazioneRimossa = false;

            for (int i = 0; i < Elenco.Count; i++)
            {
                if (Elenco[i].Titolo == inputTitolo)
                {
                    Elenco.RemoveAt(i);
                    pubblicazioneRimossa = true;
                    i--;
                }
            }

            if (pubblicazioneRimossa)
            {
                Console.WriteLine($"Pubblicazione/i con titolo '{inputTitolo}' rimosse con successo.");
            }
            else
            {
                Console.WriteLine($"Nessuna pubblicazione con titolo '{inputTitolo}' trovata nell'inventario.");
            }
        }

        public void VisualizzaStockPubblicazioni()
        {
            Console.WriteLine("Stock delle pubblicazioni:");

            foreach (Pubblicazioni pubblicazione in Elenco)
            {
                Type tipoPubblicazione = pubblicazione.GetType();

                if (tipoPubblicazione == typeof(Giornale))
                {
                    Giornale giornale = (Giornale)pubblicazione;
                    Console.WriteLine($"Giornale - Titolo: {giornale.Titolo}, Categoria: {giornale.Categoria}, Prezzo: {giornale.Prezzo}, Quantità disponibile: {giornale.QuantitaDisponibile}");
                }
                else if (tipoPubblicazione == typeof(Rivista))
                {
                    Rivista rivista = (Rivista)pubblicazione;
                    Console.WriteLine($"Rivista - Titolo: {rivista.Titolo}, Categoria: {rivista.Categoria}, Prezzo: {rivista.Prezzo}, Quantità disponibile: {rivista.QuantitaDisponibile}");
                }
            }

            Console.WriteLine("----------------------------------");
        }

       
        public void Cerca()
        {
            Console.WriteLine("Inserisci il criterio di ricerca (titolo, data o categoria):");
            string criterioRicerca = Console.ReadLine().ToLower();

            if (string.IsNullOrEmpty(criterioRicerca))
            {
                Console.WriteLine("Il criterio di ricerca non può essere vuoto.");
                return;
            }

            Console.WriteLine("Inserisci il valore da cercare:");
            string valoreRicerca = Console.ReadLine()?.ToLower();

            if (string.IsNullOrEmpty(valoreRicerca))
            {
                Console.WriteLine("Il valore di ricerca non può essere vuoto.");
                return;
            }

            Console.WriteLine("Risultati della ricerca:");

            foreach (Pubblicazioni pubblicazione in Elenco)
            {
                switch (criterioRicerca)
                {
                    case "titolo":
                        if (pubblicazione.Titolo.ToLower().Contains(valoreRicerca))
                        {
                            Console.WriteLine(pubblicazione);
                        }
                        break;
                    case "data":
                        if (pubblicazione.DataPubblicazione.ToShortDateString().Contains(valoreRicerca))
                        {
                            Console.WriteLine(pubblicazione);
                        }
                        break;
                    case "categoria":
                        if (pubblicazione.Categoria.ToLower().Contains(valoreRicerca))
                        {
                            Console.WriteLine(pubblicazione);
                        }
                        break;
                    default:
                        Console.WriteLine("Criterio di ricerca non valido.");
                        break;
                }

            }
        }
        

    }
}


