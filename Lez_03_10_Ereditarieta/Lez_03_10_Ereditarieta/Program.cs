using Lez_03_10_Ereditarieta.Classes;

namespace Lez_03_10_Ereditarieta
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Persona per = new Persona("Giovanni", "Pace");
            per.stampaDettaglio();

            Studente stu = new Studente("Valeria", "Verdi", "ABC1234");
            stu.stampaDettaglio();

            /*Docente doc = new Docente()
             * {
             * Nome ="Emmet"
             * Cognome = "Brown"
             * Materia = "Fisica applicata"
             * Dipartimento = "Fisica"
             * }
             * doc.stampaDettaglio();
            */
  

        }
    }
}
