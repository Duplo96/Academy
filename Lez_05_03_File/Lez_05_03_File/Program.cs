namespace Lez_05_03_File
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //SCRITTURA --------------------------------------
            //string path = "C:\\Users\\Utente.ACADEMY2024-15\\Desktop\\text.txt";
            //string? path = Path.GetDirectoryName(typeof(Program).Assembly.Location);

            string? contenuto = "Ciao Giovanni Pace";
            try
            {
                if (path is not null)
                    using (StreamWriter sw = new StreamWriter(path))
                    {

                        sw.WriteLine(contenuto);
                        sw.WriteLine("Ciao");
                        sw.WriteLine("Ciao23");
                        sw.WriteLine("Ciao26");
                        sw.WriteLine("Ciao32");


                    }
                Console.WriteLine("tutto ok");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }




            // LETTURA -------------------------------------
            // string? path = Path.GetDirectoryName(typeof(Program).Assembly.Location);
            //string path = "C:\\Users\\Utente.ACADEMY2024-15\\Desktop\\text.txt";


            //{
            //    try
            //    {
            //        using (StreamReader sr = new StreamReader(path))
            //        {
            //            string? line;

            //            while ((line = sr.ReadLine()) != null)
            //            {

            //                Console.WriteLine(line);
            //            }
            //        }
            //    }catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }
            //}

            Console.ReadLine();
        }
    }
}
