using System;

namespace Lez_03_08_ClassiEdOggetti
{
    internal class Bottiglia
    {
        public string? materiale;
        public string? colore;
        public float diametro;
        public float altezza;
        public string? contenuto;


        public float calcolaVolume()
        {
            float raggio = diametro / 2;
            float area = (float)Math.PI * (raggio * raggio);
            return area * altezza;
        }
        public void stampaDettagli()
        {
            Console.WriteLine($"Materiale: {materiale} \nColore: {colore}\nDiametro: {diametro}\nAltezza: {altezza}\nContenuto: {contenuto}");
        }

    }
}
