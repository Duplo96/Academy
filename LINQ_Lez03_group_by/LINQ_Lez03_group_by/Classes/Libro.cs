﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Lez03_group_by.Classes
{
    internal class Libro
    {

        public string? Titolo { get; set; }

        public string? Autore { get; set; }

        public string? Genere { get; set; }

        /// <summary>
        /// Costruttore con tre parametri
        /// </summary>
        /// <param name="titolo">Titolo del libro</param>
        /// <param name="autore">Autore del libro</param>
        /// <param name="genere">Genere del libro</param>
        public Libro(string?titolo,string?autore,string?genere) 
        {
            Titolo = titolo;
            Autore = autore;
            Genere = genere;
        
        }

        /// <summary>
        /// Metodo di stampa 
        /// </summary>
        /// <returns></returns>
        public string? stampaLibro()
        {
            return $"{Titolo},{Autore},{Genere}";

        }


    }
}
