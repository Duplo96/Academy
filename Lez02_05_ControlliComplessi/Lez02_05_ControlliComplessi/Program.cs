namespace Lez02_05_ControlliComplessi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string provincia = "BO";

            if (provincia.Equals("AQ"))
                Console.WriteLine("L'Aquila");
            else if (provincia.Equals("PE"))
                Console.WriteLine("Pescara");
            else if (provincia.Equals("TO"))
                Console.WriteLine("Torino");
            else
                Console.WriteLine("Non Trovato");

            //-------------------------------------

            provincia = "PE";
            switch(provincia)
            {
                case "AQ":
                    Console.WriteLine("L'Aquila");
                    break;
                case "TO":
                    Console.WriteLine("Torino");
                    break;
                case "BO":
                    Console.WriteLine("Bologna");
                    break;
                default:
                    Console.WriteLine("Non trovato");
                    break;
            }
        }
    }
}
