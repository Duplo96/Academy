using DB_03_scuola.DAL;
using DB_03_scuola.Models;
namespace DB_03_scuola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DocenteDAL.getInstance().insert(new Docente() { });

        }
    }
}
