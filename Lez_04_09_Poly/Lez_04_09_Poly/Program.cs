using Lez_04_09_Poly.Classes;

namespace Lez_04_09_Poly
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Persona stuUno = new Studente("Giovanni", "Pace", "ABC1234");
            Persona stuDue = new Studente("Giovanni", "Pace", "ABC1234");

            Persona docUno = new Docente("Giovanni", "Pace", "ABC1234", "ABC1234");
            Persona docDue = new Docente("Giovanni", "Pace", "ABC1234", "ABC1234");

            List<Persona> list = new List<Persona>();
            list.Add(stuUno);
            list.Add(stuDue);
            list.Add(docUno);
            list.Add(docDue);

            for (int i = 0; i < list.Count; i++)
            {

                //list[i].stampaDettaglio();

                if (list[i].GetType() == typeof(Studente))
                {
                    Studente temp = (Studente)list[i];
                    temp.stampaStudentePersonalizzato();
                }
                else if (list[i].GetType() == typeof(Docente))
                {
                    Docente temp = (Docente)list[i];
                    temp.stampaDocentePersonalizzato();
                }
            }


            //Object stuUno = new Studente("Giovanni", "Pace", "ABC1234");
            //Object stuDue = new Studente("Giovanni", "Pace", "ABC1234");

            //Object docUno = new Docente("Giovanni", "Pace", "ABC1234", "ABC1234");
            //Object docDue = new Docente("Giovanni", "Pace", "ABC1234", "ABC1234");


            //List<Object> list = new List<Object>();
            //list.Add(stuUno);
            //list.Add(stuDue);
            //list.Add(docUno);
            //list.Add(docDue);

        }
    }
}
