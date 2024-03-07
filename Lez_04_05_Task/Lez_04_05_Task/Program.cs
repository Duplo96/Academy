using Lez_04_05_Task.Classes;

namespace Lez_04_05_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? inputCodiceFiscale = Console.ReadLine();
            string? inputCartaDIdentita = Console.ReadLine();


            Utente per = new Utente()
            {
                Nome ="Giovanni",
                Cognome="Pace",
                Identita = new CartaDidentita()
                {
                    Codice="1223",
                    DataEmissione= new DateTime(2020,12,21),
                      DataScadenza= new DateTime(2020, 12, 22),
                      LuogoEmissione = "Comune"

                },
                Fiscale = new CodiceFiscale()
                {
                    Codice= "2324",
                    DataScadenza= new DateTime(2020/12/21)
                    
                }
                

            };
            Console.WriteLine(per);
        }
    }
}
