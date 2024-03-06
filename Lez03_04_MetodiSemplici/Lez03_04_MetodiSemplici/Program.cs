namespace Lez03_04_MetodiSemplici
{
    internal class Program
    {
        static void saluta()
        {
            Console.WriteLine("ciao");
        }
        static void salutaPersonalizzato(string nome)
        {
           
            Console.WriteLine($"Ciao {nome}, come stai?");

        }
        
        static void dettaglioStudende(string nome, string cognome, string? matricola) {
            Console.WriteLine($"Nome: {nome}\nCognome: {cognome}\nMatricola: {matricola} \n");
        }
        static int Somma(int a,int b, int c)
        {
            int risultato = a + b + c;
            return risultato;
        }
        static void stampaArr(string[]elenco)
        {
            foreach(string str in elenco)
            {
                Console.WriteLine(str);
            }
        }


        static void Main(string[] args)
        {
            //Console.WriteLine("Scrivi il tuo nome");
            //string? nome = Console.ReadLine();
            //Console.WriteLine($"Ciao {nome}, come stai?");
            //saluta();
            //salutaPersonalizzato(nome);

            //string? nome1 = Console.ReadLine();
            //string? cognome = Console.ReadLine();
            //string? matricola = Console.ReadLine();
            //dettaglioStudende("Mario" ,"Rossi", null);

            //int sommaDiNumeri = Somma(43, 56, 12);
            //Console.WriteLine(sommaDiNumeri);
            //Console.WriteLine(sommaDiNumeri(Somma(43,56,12));

            string[] parco = { "BMW", "Maserati", "FIAT" };
            stampaArr(parco);


            string[] invitati = { "Valeria", "Mario"};

            stampaArr(invitati);
        }
    }
}
