﻿using DB_03_scuola.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_03_scuola.DAL
{
    internal class DocenteDAL : IDal<Docente>
    {

        static DocenteDAL? instance;

        public static DocenteDAL getInstance()
        {
            if (instance == null)
                instance = new DocenteDAL();

            return instance;
        }


        private DocenteDAL()
        {
            Console.WriteLine("Costrutto invocato");
        }





        public bool delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Docente> findAll()
        {
            throw new NotImplementedException();
        }

        public Docente findById(int id)
        {
            throw new NotImplementedException();
        }

        public bool insert(Docente t)
        {
            throw new NotImplementedException();
        }

        public bool update(Docente t)
        {
            throw new NotImplementedException();
        }
    }
}
