namespace Lez_01_02_ControlliSemplici
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string nominativo= "Giovanni Pace";
            //int eta =37 ;
            //float temp = 36.5f;

            //Console.WriteLine( $"{nominativo} è {eta} anni vecchio ed ha una temperatura corporea di {temp}°C");


            // nominativo = "Mario Rossi";
            // eta = 23;
            // temp = 38f;

            //Console.WriteLine($"{nominativo} è {eta} anni vecchio ed ha una temperatura corporea di {temp}°C");


            Console.WriteLine("Scrivi la tua temperatura");
            try
            {

                string? inputUtente = Console.ReadLine();
                double temp = Convert.ToDouble(inputUtente);

                if (temp >= 35.5f && temp <= 42.0f)
                {
                    if (temp <= 37.5f)
                        Console.WriteLine("Puoi entrare");
                    else
                        Console.WriteLine("Non puoi entrare");
                }


                else Console.WriteLine("Errore di validazione");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Errore: {ex.Message}");
            }


              

            }
            //try
            //{
            //    int valoreConvertito = Convert.ToInt32(inputUtente);
            //    if (valoreConvertito >= 18)
            //        Console.WriteLine("Maggiorenne");
            //    else
            //        Console.WriteLine("MInorenne");
            //}
            //catch(FormatException ex) 
            //{
            //    Console.WriteLine($"Errore: {ex.Message}");
            //}
            //catch (Exception ex) 
            //{
            //    Console.WriteLine($"Errore generico: {ex}");
            //} finally
            //{ Console.WriteLine("Operazione terminata"); 
            //}



        }
    }
}
