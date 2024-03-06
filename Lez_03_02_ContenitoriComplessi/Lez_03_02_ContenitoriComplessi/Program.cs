namespace Lez_03_02_ContenitoriComplessi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Scrittura più corretta 


            string[] stuUno = { "Giovanni Pace", "12345", "PCAGNN" };
            string[] stuDue = { "Valeria Verdi", "12346", "VLRVRD" };
            string[] stuTre = { "Mario Rossi", "12347", "MRRSS" };

            string[][] elenco = { stuUno, stuDue, stuTre };
            Console.WriteLine("scrivi il tuo codice fiscale");
            string? codiceFiscale = Console.ReadLine();
            //Console.WriteLine(elenco[1][2]);

            //for (int i = 0; i < elenco.Length; i++)
            //{
            //    string[] temp = elenco[i];
            //    for(int x=0; x<temp.Length; x++)
            //    {
            //        Console.WriteLine(temp[x]);
            //    }
            //}


            for (int i = 0; i < elenco.Length; i++)
            {
                string[] temp = elenco[i];
                for (int j = 0; j < temp.Length; j++) 
                {
                    if (codiceFiscale is not null &&
                        temp[2].ToUpper().Equals(codiceFiscale.ToUpper().Trim())

                        )
                    {
                        Console.WriteLine($"Nome: {temp[0]} Matricola: {temp[1]}");
                    }
                    else
                    {
                        Console.WriteLine("L'utente non esiste");
                    }
                }
                
            }


            //---------------------------------------------------------

            // Puoi scriverlo così


            //string[][] elenco={

            // { "Giovanni Pace", "12345", "PCAGNN" };
            // { "Valeria Verdi", "12346", "VLRVRD" };
            // { "Mario Rossi", "12347", "MRRSS" };



        }


    


        }
    }

