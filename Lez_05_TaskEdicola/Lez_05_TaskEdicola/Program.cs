using Lez_05_TaskEdicola.Classes;
using System.Security.Cryptography;

namespace Lez_05_TaskEdicola
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Edicola edicola = new Edicola();
            bool continua = true;

            while (continua)
            {
                edicola.Benvenuto();

                string? inputScelta = Console.ReadLine();

                switch (inputScelta?.ToUpper())
                {
                    case "1":
                        edicola.AggiungiGiornale();
                        break;
                    case "2":
                        edicola.AggiungiRivista();
                        break;
                    case "3":
                        edicola.Rimuovi();
                        break;
                    case "4":
                        edicola.VisualizzaStockPubblicazioni();
                        break;
                    case "5":
                        edicola.AggiornaQuantitaDisponibile();
                        break;
                    case "6":
                        edicola.CercaPerTitoloDataCategoria();
                        break;
                    case "Q":
                        continua = false;
                        Console.WriteLine("Arrivederci!");
                        break;
                    default:
                        Console.WriteLine("Opzione non valida. Scegli un'opzione valida.");
                        break;
                }
            }

        }




    }









          
                
            
        }
 

