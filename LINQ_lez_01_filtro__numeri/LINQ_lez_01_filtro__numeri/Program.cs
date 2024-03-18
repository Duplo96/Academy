namespace LINQ_lez_01_filtro__numeri
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            List<int> elenco = new List<int>() { 1, 2, 3, 4, 10,11,32,8,9, -2, -45 };

            // Voglio tutti i valori maggiori di 5

            var risultato = from valore in elenco
                            where valore > 5
                            orderby valore
                            select valore;
            foreach(int item in risultato)
            {
                Console.WriteLine(item);
            }

        }
    }
}
