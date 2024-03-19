using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskPaninoteca
{
    internal class Panino
    {


        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Descrizione { get; set; }
        public decimal Prezzo { get; set; }
        public bool IsVegan { get; set; }


        public override string ToString()
        {
            return $"{Id} {Nome} {Descrizione} {Prezzo}{(IsVegan ? " Vegano" : " Non Vegano")}";
        }

    }
}
