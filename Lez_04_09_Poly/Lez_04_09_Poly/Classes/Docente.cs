using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez_04_09_Poly.Classes
{
    internal class Docente : Persona
    {

        public string? Dipartimento { get; set; }
        public string? Materia { get; set; }

        Docente() { }
       public Docente(string? nome, string? cognome, string? materia, string? dipartimento)
        {
            Nome = nome;
            Cognome= cognome;
            Materia=materia;
            Dipartimento=dipartimento;

        }
        public override void stampaDettaglio()
        {
            Console.WriteLine($"[DOCENTE]{Nome}{Cognome}{Materia}{Dipartimento}");
        }
        public virtual void stampaDocentePersonalizzato()
        {
            Console.WriteLine("[DOCENTE]");
            Console.WriteLine($"--------------Materia: {Materia}---------------------");
            Console.WriteLine($"-------------Nome:{Nome} e Cognome {Cognome}----------------------");
            Console.WriteLine($"-------------Dipartimento: {Dipartimento}---------------------");
        }
    }
}
