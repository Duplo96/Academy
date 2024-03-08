using Lez_05_01_Statici.Classes;

namespace Lez_05_01_Statici
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Automobile autoUno = new Automobile("Blu");
            Automobile autoDue = new Automobile("Gialla");

            //Console.WriteLine(Automobile.Contatore);

            // Automobile.Contatore = -23 Non è permesso perché la set è private

            Automobile.stampaContatore();
        }
    }
}
