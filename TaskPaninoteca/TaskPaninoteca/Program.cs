using TaskPaninoteca.Controllers;

namespace TaskPaninoteca
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DB gest = new DB();
            // Inserisci il panino

            //gest.insert(new Panino()
            //{
            //    Nome = "Er",
            //    Descrizione = "Bono fracico",
            //    Prezzo = 15.4m,
            //    IsVegan = true
            //});


            //Stampare tutti i panini
            List<Panino> menu = gest.findAll();

            foreach (Panino p in menu)
            {
                Console.WriteLine(p);
            }

            //Stampare tutti i panini vegani
            var paniniVegani = menu.Where(p => p.IsVegan == true);

            foreach(Panino p in paniniVegani)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine(menu.Count);
            //Prezzo medio dei panini
            Console.WriteLine(menu.Average(p=>p.Prezzo));
        }

    }
}
