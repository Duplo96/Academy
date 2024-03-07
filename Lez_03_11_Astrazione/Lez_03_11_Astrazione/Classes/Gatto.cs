using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez_03_11_Astrazione.Classes
{
    internal class Gatto : Animale
    {
        public string Colore { get; set; }

        public override void versoEmesso()
        {
            Console.WriteLine("Miao");
        }
    }
}
