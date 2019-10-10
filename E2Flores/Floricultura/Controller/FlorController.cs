using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Floricultura.Model;


namespace Floricultura.Controller
{
    
    public class FlorController
    {
        FlorContext contextDB = new FlorContext();

        public IQueryable<Flor> GetFlores()
        {
            return contextDB.Flores;
        }
        public bool AddFlor(Flor item)
        {
            if (string.IsNullOrWhiteSpace(item.Nome))// metodo que identifica espacos em branco
                return false;
            contextDB.Flores.Add(item);// parte final do adicionar, ela insere na tabela e salva com o comando abaixo
            contextDB.SaveChanges();
            return true;
        }

    }
}
