namespace Lez_04_04_Utilizzo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Indirizzo indi = new Indirizzo()
            {
                Via = "Via le mani dagli occhi",
                Cap = "1111",
                Citta = "Farindola",
                Provincia = "CH"
            };

            Utente gio = new Utente()
            {
                Nominativo = "Giovanni Pace",
                Spedizione = new Indirizzo()
                {
                    Via = "Via le mani dagli occhi",
                    Cap = "1111",
                    Citta = "Farindola",
                    Provincia = "CH"
                },
                Fatturazione = new Indirizzo()
                {
                    Via = "Piazza la bomba e scappa",
                    Cap = "454545",
                    Citta = "Pippo",
                    Provincia = "PP"
                }
            };

            Console.WriteLine(gio);




         

            

        }
    }
}
