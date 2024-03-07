using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez_03_11_Astrazione.Classes
{
    internal  abstract class Animale
    {
        public bool HasPelo { get; set; }
        public int NumZampe {  get; set; }
        public bool Vola { get; set; }

        public abstract void versoEmesso();
    }
}
