namespace Lez_02_06_CicliSemplici
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int indice = 0;
            //while (indice < 5)
            //{
            //    Console.WriteLine("Ciao");
            //    indice++;
            //}
            ////----------------------------------
            //int indice2 = 0;

            //while (indice2 < 5)
            //{
            //    Console.WriteLine($"Sono all'indice {indice2 + 1}");
            //    indice++;
            //}
            //----------------------------------

            //    int i = 0;
            //    do
            //    {
            //        Console.WriteLine($"Sono all'indice {i + 1}");
            //        i++;

            //    }
            //    while (i < 5);
            //}

            //----------------------------------


            //bool inserimentoAbilitato = true;
            //while (inserimentoAbilitato)
            //{

            //    Console.WriteLine("Inserisci il tuo nome o digita Q per uscire");
            //    string? inputUtente = Console.ReadLine();
            //    if (inputUtente != null && inputUtente.Equals("Q"))
            //    {
            //        inserimentoAbilitato = false;
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Ciao {inputUtente}");
            //    }
            //}
            //----------------------------------

            /*
             * STEP1
             * scrivere un sistema di gestione invitati alla propria festa
             * L'inserimento avviene tramite console che prende un input (in due tempi diversi)
             * il nome e cognome
             * 
             * All'uscita del programma verrà stampato l'elecon delle persone precedentemente 
             * inserita,separate da virgola
             */


            bool insAb = true;
            string? risultato = null;


            while (insAb)
            {
                Console.WriteLine("Cosa vuoi fare?\n Premi invio per un nuovo utente o digita Q " +
                    "per uscire");
                string? inputScelta = Console.ReadLine();

                if (inputScelta is not null && inputScelta.Equals("Q"))
                    insAb = false;

                else
                {
                    Console.WriteLine(" inserisci il Nome:");
                    string? inputNome = Console.ReadLine();

                    Console.WriteLine(" inserisci il Cognome:");
                    string? inputCognome = Console.ReadLine();
                    risultato += inputNome + " " + inputCognome + ", ";
                    Console.WriteLine("Operazione effettuata con successo! \n " +
                        "-------------------------");
                }

            }
            Console.WriteLine(risultato);   
        }
    }
}
