namespace Lez_03_08_ClassiEdOggetti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bottiglia coca = new Bottiglia();
            coca.materiale = "PET";
            coca.colore = "Trasparente";
            coca.diametro = 12.5f;
            coca.altezza = 25.0f;
            coca.contenuto = "Cola";
            Console.WriteLine(coca.calcolaVolume());
            coca.stampaDettagli();

            Bottiglia acqua = new Bottiglia()
            {
                contenuto = "Acqua",
                colore = "Verde",
                diametro = 16.5f,
                altezza = 12.4f,
            };
            acqua.stampaDettagli();
        }
    }
}
