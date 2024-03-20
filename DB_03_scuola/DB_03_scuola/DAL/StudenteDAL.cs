using DB_03_scuola.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_03_scuola.DAL
{
    internal class StudenteDAL : IDal<Studente>
    {
        static StudenteDAL instance;
        public bool delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Studente> findAll()
        {
            throw new NotImplementedException();
        }

        public Studente findById(int id)
        {
            throw new NotImplementedException();
        }

        public bool insert(Studente t)
        {
            throw new NotImplementedException();
        }

        public bool update(Studente t)
        {
            throw new NotImplementedException();
        }
    }
}
