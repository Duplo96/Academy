﻿namespace Lez_03_03_TaskContenitori
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Titolo - AUTORE - ISBN - Casa Editrice
            string[] libro_1 = { "Il signore degli anelli", "JRRT", "123456-1225", "Casa ed 1" };
            string[] libro_2 = { "Il ritorno del re", "JRRT", "123456-1226", "Casa ed 1" };
            string[] libro_3 = { "Il visconte dimezzato", "I.Calvino", "987456-1225", "Casone editrice" };
            string[] libro_4 = { "Storia del buongiorno", "A. Christie", "456466-1225", "Casone editrice" };
            string[] libro_5 = { "Le due torri", "JRRT", "456463-1225", "Casa ed 1" };

            string[][] store = { libro_1, libro_2, libro_3, libro_4, libro_5 };

            //Contare tutti i libri di JRRT o di un autore inserito a mano.
            Console.WriteLine("Cerca l'autore");
            string? inputUtente = Console.ReadLine();
            int conteggio = 0;

            foreach (string[] libro in store)
            {
                if (libro[1].ToLower().Trim().Equals(inputUtente.ToLower().Trim()))
               
                conteggio++;
            }
            Console.WriteLine($"il numero di libri di {inputUtente} è: {conteggio}");

            conteggio = 0;

            for (int i=0; i<store.Length; i++)
            {
                string[] temp = store[i];
                if (inputUtente is not null &&
                    temp[1].ToUpper().Trim().Equals(inputUtente.ToUpper().Trim())
                    )
                {
                    conteggio++;
                }
            }
            Console.WriteLine($"il numero di libri di {inputUtente} è: {conteggio}");
        }
    }
}
