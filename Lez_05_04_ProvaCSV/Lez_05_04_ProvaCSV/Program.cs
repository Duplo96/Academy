using Lez_05_04_ProvaCSV.Classes;
using System.Reflection.Metadata;

namespace Lez_05_04_ProvaCSV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona gio = new Persona("Giovanni", "Pace", "PCAGNN");
            Persona val = new Persona("Giovanni", "Pace", "PCAGNN");
            Persona mar = new Persona("Giovanni", "Pace", "PCAGNN");

            string path = "C:\\Users\\Utente.ACADEMY2024-15\\Desktop\\persone.txt";
            try
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine(gio.esportaCsv());
                    sw.WriteLine(val.esportaCsv());
                    sw.WriteLine(mar.esportaCsv());
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message) ;
            }
        }
    }
}
