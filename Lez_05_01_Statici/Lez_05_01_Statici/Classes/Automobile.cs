﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez_05_01_Statici.Classes
{
    internal class Automobile
    {

        public string? Colore { get; set; }
        public string? Materiale { get; set; } = "Plastica";

        public static int Contatore { get;  private set; } = 0; // Questo attributo viene allocato appena parte l applicazione
        
        public static void stampaContatore()
        {
            Console.WriteLine($"Il numero di macchinine è: {Contatore}");

        }
        
        
        
        
        
        
        public Automobile(string? colore, string? materiale)







        {
            Colore = colore;
            Materiale = materiale;
            Contatore++;
        }
        public Automobile(string? colore)
        {
            Colore = colore;
            Contatore++;
           
        }
    }
}
