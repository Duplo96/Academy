using TaskLINQ.Classes;

namespace TaskLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Prodotto> products = new List<Prodotto>()
            {
                new Prodotto() { Nome = "Coca-cola", Categoria = "Bevande", Prezzo = 2f, Descrizione = "Buona", Quantita = 3 },
                new Prodotto() { Nome = "Acqua", Categoria = "Bevande", Prezzo = 2f, Descrizione = "Trasparente", Quantita = 3 },
                new Prodotto() { Nome = "Lampada", Categoria = "Illuminazione", Prezzo = 35f, Descrizione = "Luminosa", Quantita = 5 },
                new Prodotto() { Nome = "Letto", Categoria = "Mobilio", Prezzo = 40f, Descrizione = "Comodo", Quantita = 2 }
            };
            #region Output tutti i prodotti
            var risultato = from prod in products
                            where prod.Categoria =="Bevande"
                            select prod;

            foreach (var item in risultato)
            {
                Console.WriteLine($"{item.Nome}");
            }

            /*VERSIONE CON METODO
             * var risultato= elenco
             * .Where(prod => prod.Categoria == "Bevande"")
             * .Select(p => new {p.Nome,p.Prezzo})
             * 
             */

            #endregion

            Console.WriteLine($"{products.Average(p => p.Prezzo)}");

            var totalPieces = from prod in products
                              group prod by prod.Categoria into contenitoreCategoria
                              select contenitoreCategoria;


            foreach (var item in totalPieces)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Sum(p => p.Quantita));
            }

            var total = from prod in products
                        where prod.Quantita > 0
                        select new { Price=prod.Prezzo, Quantity=prod.Quantita };

            //foreach (var prod in products)
            //{
            //    Console.WriteLine($"{prod.Categoria} {prod.Nome}");
            //    Console.WriteLine(prod.Quantita * prod.Prezzo);
            //}
            
               // Totale negozio 
                Console.WriteLine(total.Sum(t=>t.Quantity * t.Price)); 

           



        }
    }
}

