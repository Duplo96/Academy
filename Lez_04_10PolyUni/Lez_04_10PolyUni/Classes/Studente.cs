using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez_04_10PolyUni.Classes
{
    internal class Studente : Persona
    {


        public string? Matricola { get; set; }

        Studente() { }
        public Studente(string? nome, string? cognome, string? matricola)
        {
            Nome = nome;
            Cognome = cognome;
            Matricola = matricola;
            

        }
        public override void stampaDettaglio()
        {
            Console.WriteLine($"[STUDENTE]{Nome}{Cognome}{Matricola}");
        }

        public virtual void stampaStudentePersonalizzato()
        {
            Console.WriteLine($"[STUDENTE]");
            Console.WriteLine($"--------------{Matricola}---------------------");
            Console.WriteLine($"-------------Nome:{Nome} e Cognome {Cognome}----------------------");
            Console.WriteLine($"-----------------------------------");
        }






    }
}
