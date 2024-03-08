using Lez_05_02_StaticiEreditari.Classes;

namespace Lez_05_02_StaticiEreditari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Giocattolo autoUno = new Automobile();
            Giocattolo autoDue = new Automobile();
            Giocattolo trenino = new Trenino();


           

            List<Giocattolo> elenco = new List<Giocattolo>();

            elenco.Add(trenino);
            elenco.Add(autoDue);
            elenco.Add(autoUno);


            foreach(Giocattolo gio in elenco)
            {
                if (gio.GetType() == typeof(Trenino))
                {
                    Trenino temp = (Trenino)gio;
                    temp.rumoreTrenino();
                }
            
            
            }


            

           
        }
    }
}
