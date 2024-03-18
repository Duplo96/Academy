using LINQ_Lez03_group_by.Classes;

namespace LINQ_Lez03_group_by
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
                new Libro("Libro D","Autore 4","Sci-Fi")
            };
            #region GROUP BY,raggruppamento
            var risultato = from libro in elenco
                            group libro by libro.Genere into contenitoreGenere
                            select contenitoreGenere;

            foreach (var genere in risultato)
            {
                Console.WriteLine(genere.Key);
                foreach (Libro lib in genere)
                {
                    Console.WriteLine(lib.stampaLibro());
                }
            }
            #endregion

        }
    }
}
