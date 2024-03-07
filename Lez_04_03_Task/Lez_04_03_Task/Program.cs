using Lez_04_03_Task.Classes;

namespace Lez_04_03_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Creare un sistema di gestione veicoli:
             *
             * All'inserimento di un nuovo veicolo mi sia permessa la scelta tra:
             * 1. Automobile
             * 2. Moto
             *
             * Alla fine dell'inserimento delle caratteristiche del veicolo, stampare i suoi dettagli.
             *
             * Libera scelta degli attributi
             */

            
            bool insAbi = true;
           while (insAbi)
            {
                Console.WriteLine("Premi 1 per inserire una Automobile \nPremi 2 per inserire una Moto\nQ. Uscire");
                string? input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        try
                        {
                            Console.WriteLine("Inserisci Targa");
                            string? inTarga = Console.ReadLine();
                            Console.WriteLine("Inserisci Telaio");
                            int inTelaio =  Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Inserisci Porte");
                            int inPorte = Convert.ToInt32(Console.ReadLine());

                            Automobile auto = new Automobile()
                            {
                                Targa = inTarga,
                                Telaio = inTelaio,
                                NumeroPorte = inPorte
                            };
                            Console.WriteLine(auto);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case "2":
                        try
                        {
                            Console.WriteLine("Inserisci Targa");
                            string? inTarga = Console.ReadLine();
                            Console.WriteLine("Inserisci Telaio");
                            int inTelaio = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Inserisci Porte");
                            int inPorte = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Ha il portapacchi?");
                            

                            Moto moto= new Moto()
                            {
                                
                                Targa = inTarga,
                                Telaio = inTelaio,
                                NumeroPorte = inPorte
                            };
                            Console.WriteLine(moto);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case "Q":
                        insAbi = !insAbi;
                        break;
                    default:
                        Console.WriteLine("Errore, comando non riconosciuto");
                        break;

                }

            };

        }
    }
}
