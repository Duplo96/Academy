using Lez_04_08_ContenitoriComplessi.Classes;

namespace Lez_04_08_ContenitoriComplessi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<string> elenco =   new List<string>();
            //elenco.Add("Maserati");
            //elenco.Add("FIAT");
            //elenco.Add("BMW");
            //elenco.Add("Lamborghini");
            //foreach(string s in elenco)
            //{
            //    Console.WriteLine(s);
            //}


            List<Contatto> rubrica = new List<Contatto>();
            rubrica.Add(new Contatto()
            {
                Nome = "Ppp",
                Cognome = "Ppp",
                Email = "Ppp",
                Telefono = "Ppp",

            });
            rubrica.Add(new Contatto()
            {
                Nome = "Ppp",
                Cognome = "Ppp",
                Email = "Ppp",
                Telefono = "Ppp",

            });
            rubrica.Add(new Contatto()
            {
                Nome = "Ppp",
                Cognome = "Ppp",
                Email = "Ppp",
                Telefono = "Ppp",

            });

            foreach(Contatto temp in rubrica)
            {

                Console.WriteLine(temp);

            }
        }
    }
}
