using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez_04_03_Task.Classes
{
    internal class Automobile : Veicolo
    {

       
       
        public string? Targa { get; set; }


        public override string ToString()
        {
            return $"[Automobile] \nTarga: {Targa} \nTelaio: {Telaio} \nNumero porte: {NumeroPorte}";
        }
    }
}
