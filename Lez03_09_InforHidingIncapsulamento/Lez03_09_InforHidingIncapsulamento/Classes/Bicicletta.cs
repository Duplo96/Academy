using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez03_09_InforHidingIncapsulamento.Classes
{

    //Costruttori
    internal class Bicicletta
    {

        public string? Marca {  get; set; }
        public string? Tipo { get; set; }
        public bool HasCampanello { get; set; } = false;


        /*La firma è Bicicletta(), bisogna sempre inserire un costruttore
         * che abbia quello di default se hai un costruttore personalizzato
         */
        public Bicicletta() 
        {
            Console.WriteLine("Costruttore di default invocato");
        
        }
        //La firma Bicicletta(string,string,bool) 
        public Bicicletta(string?marca, string?tipo,bool hasCampanello)
        {
            Marca = marca;
            Tipo= tipo;
            HasCampanello = hasCampanello;
            Console.WriteLine("Costruttore con tre parametri");
        }
        public Bicicletta(string? marca, bool hasCampanello)
        {
            Marca = marca;
            
            HasCampanello = hasCampanello;
            Console.WriteLine("Costruttore con due parametri");
        }
    }

}
