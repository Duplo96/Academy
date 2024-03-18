using LINQ_Lez04_group_by.Classes;

namespace LINQ_Lez04_group_by
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Libro> elenco = new List<Libro>()
            {
                new Libro("Libro A","Autore 1","Fantasy"),
                new Libro("Libro B","Autore 2","Fantasy"),
                new Libro("Libro C","Autore 3","Horror"),
                new Libro("Libro D","Autore 4","Sci-Fi"),
                new Libro("Libro E","Autore 2","Sci-Fi")
            };


            #region Selezione Condizionale

            //var risultato = condizione ? esito positivo : esito negativo

            //Esulta se è fantasy,altrimenti rimani deluso...

            var risultato = from libro in elenco
                            select libro.Genere.Equals("Fantasy") ? "Yuhuuuuuuu è fantay " +
                            libro.Titolo : "Non è fantasy " + libro.Titolo;
            
            foreach(var libro in risultato)
            {
                Console.WriteLine(libro);
            }




            #endregion

            #region Selezione Parziale
            //var risultato = from libro in elenco
            //                where libro.Autore.Equals("Autore 1")
            //                select new { Titolo = libro.Titolo, Genere = libro.Genere };
            //foreach(var item in risultato)
            //{
            //    Console.WriteLine($"{ item.Titolo} {item.Genere }");

            //}
            #endregion

            #region Gestione new {}
            //var stud = new { Nome = "Giovanni", Cognome = "Pace" };
            //Console.WriteLine(stud);
            #endregion


        }
    }
}
