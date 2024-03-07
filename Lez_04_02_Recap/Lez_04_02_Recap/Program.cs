using Lez_04_02_Recap.Classes;

namespace Lez_04_02_Recap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] stuUno = { "Giovanni Pace", "12345", "PCAGNN" };
            //string[] stuDue = { "Valeria Verdi", "12346", "VLRVRD" };
            //string[] stuTre = { "Mario Rossi", "12347", "MRRRSS" };

            //string[][] elenco = { stuUno, stuDue, stuTre };

            Studente uno = new Studente("Pippo", 1234, "PPPP");
            Studente due = new Studente("Pippo", 1234, "PPPP");
            Studente tre = new Studente("Pippo", 1234, "PPPP");
            //Studente quattro = new Studente(); Non permesso
            //Studente cinque = new Studente(); Non permesso
            Studente sei = new Studente("Pippo", "PPPP");

            Studente[] elenco = {uno,due, tre,};


        }
    }
}
