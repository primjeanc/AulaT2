﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirstTest.Model;

namespace CodeFirstTest.Controller
{
    public class CervejaController
    {
        //informamos a conexao do contextDb com o Banco de dados mas nao deixamos publico, logo temos as informacoes, mas o console nao acessa(altera)
        CervejaContextDb contextDb = new CervejaContextDb(@"data source=(localdb)\MSSQLlocalDB;initial catalog=RevisandoEntity.Model.CervejaContextDB;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework");
        public void AddCerveja(Cerveja item)
        {
            contextDb.Cervejas.Add(item);
            contextDb.SaveChanges();
        }

        

    }
}
