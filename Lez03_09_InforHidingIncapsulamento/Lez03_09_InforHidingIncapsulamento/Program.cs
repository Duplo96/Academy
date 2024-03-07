using Lez03_09_InforHidingIncapsulamento.Classes;

namespace Lez03_09_InforHidingIncapsulamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Automobile peugeot = new Automobile();
            peugeot.marca = "pegeout";

            Automobile bmw = new Automobile();
            bmw.marca = "bmw";
            bmw.cilindrata = 1330;
            bmw.posti = 4;

            Moto honda = new Moto();
            honda.setCilindrata(750);
            Console.WriteLine(honda.getCilindrata());

            Monopattino xiao = new Monopattino();
            xiao.Marca = "Xiaomi";
            xiao.NumPersone = 3;


            Console.WriteLine(xiao.NumPersone);
            Console.WriteLine(xiao.Marca);
            Console.WriteLine(xiao.VelMax);



            Bicicletta nukeproof = new Bicicletta();
            nukeproof.HasCampanello= true;

            Bicicletta commencal = new Bicicletta("Commencal", "AllMountain", false);
        }
    }
}
