using Lez_04_10PolyUni.Classes;

namespace Lez_04_10PolyUni
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Universita uni = new Universita()
            {
                Nome = "Dei Ciccioli"
            };

            Persona stuUno = new Studente("Giovanni", "Pace", "ABC1234");
            Persona stuDue = new Studente("Giovanni", "Pace", "ABC1234");

            Persona docUno = new Docente("Giovanni", "Pace", "ABC1234", "ABC1234");
            Persona docDue = new Docente("Giovanni", "Pace", "ABC1234", "ABC1234");

            uni.aggiungi(stuUno);
            uni.aggiungi(stuDue);
            uni.aggiungi(docUno);
            uni.aggiungi(docDue);

            uni.elencoStudenti();

        }
    }
}
