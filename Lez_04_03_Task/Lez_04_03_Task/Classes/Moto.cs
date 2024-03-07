using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez_04_03_Task.Classes
{
    internal class Moto: Veicolo
    {
        public bool HasPortapacchi { get; set; }


        public override string ToString()
        {
            return $"{Targa} {Telaio} {NumeroPorte}";
        }

    }
}
