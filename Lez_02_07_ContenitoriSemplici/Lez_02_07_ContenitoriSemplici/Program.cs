namespace Lez_02_07_ContenitoriSemplici
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] numeri = { 1, 2, 3, 4, 5};

            //Console.WriteLine(numeri);

            //int[] numeri = new int[6];
            //numeri[0] = 7;
            //numeri[1] = 6; 
            //numeri[2] = 8;
            //numeri[3] = 2;
            //numeri[4] = 8; 
            //numeri[5] = 67;


            //int i = 0;
            //while (i < numeri.Length)
            //{
            //    Console.WriteLine(numeri[i]);
            //    i++;
            //}

            //------------------------------------------------

            //string[] parco = { "Maserati", " Lamborghini", "Bmw" };

            //for (int i=0; i<parco.Length; i++) {
            //    Console.WriteLine(parco[i]);
            //        }

            //------------------------------------------------

            //string[] parco = { "Maserati", " Lamborghini", "BMW" };
            //string ricerca = "BMW";
            //bool trovato = false;

            //for (int i = 0; i < parco.Length; i++)
            //{
            //    if (parco[i].Equals(ricerca))
            //        trovato= true;

            //}
            //if (trovato)
            //    Console.WriteLine("Trovato");
            //else Console.WriteLine("Non trovato");
            //}
            //------------------------------------------------

            //string[] parco = { "Maserati", "Lamborghini", "BMW" };

            //foreach (string auto in parco)
            //{
            //    Console.WriteLine(auto);
            //}


            //------------------------------------------------

            //int a = 5;
            //if (5<3) 
            //{
            //    a = 7;
            //    Console.WriteLine(a);
            //    int b = 9; // la varibile b fuori dal contesto non esiste
            //}

            //------------------------------------------------

            //string[] parco = { "Maserati", "Lamborghini", "BMW" };

            //Array.Sort(parco); //Ordina in maniera alfabetica 

            //foreach (string auto in parco)
            //{
            //    Console.WriteLine(auto);
            //}


            //------------------------------------------------
            /*
             * Presa una stringa composta in questo modo: "Giovanni, Valeria, Mario"
             * trasformarla in un array evitando le ripetizioni
             */

            string? pippo= "Giovanni,Valeria,Mario";
            char[] arr;
            arr = pippo.ToCharArray(0, 22);  
            foreach (char item in arr) {
                Console.WriteLine();
                Console.WriteLine(item);
            };
        }
    }
}
