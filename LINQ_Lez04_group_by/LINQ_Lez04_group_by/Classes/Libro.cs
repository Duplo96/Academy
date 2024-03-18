using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Lez04_group_by.Classes
{
    internal class Libro
    {
        public string? Titolo { get; set; }
        public string? Autore { get; set; }

        public  string? Genere { get; set; }


        public Libro(string?titolo,string?autore,string?genere)
        {
            Titolo=titolo;
            Autore=autore;
            Genere=genere;
        }

    }
}
