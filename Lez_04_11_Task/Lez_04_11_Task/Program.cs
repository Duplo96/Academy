using Lez_04_11_Task.Classes;

namespace Lez_04_11_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
               * Creare un sistema che mantenga traccia degli oggetti contenuti nelle stanze 
               * della vostra casa.
               * Di ogni oggetto voglio conoscere:
               * - Nome
               * - Descrizione
               * - Valore dell'oggetto
               * 
               * Di ogni stanza voglio conoscere il nome
               */

            Stanza cucina = new Stanza()
            {
                Nome = "Cucina"

            };
            Oggetto frigorifero = new Oggetto()
            {
                Nome = "Frigorifero",
                Descrizione = "Bel frigorifero",
                Valore = "100"
            };
            Oggetto frigorifero2 = new Oggetto()
            {
                Nome = "Frigorifero",
                Descrizione = "Bel frigorifero",
                Valore = "100"
            };

            cucina.aggiungiOggetto(frigorifero);
            cucina.stampaDettagli();


          ;

        }
    }
}
