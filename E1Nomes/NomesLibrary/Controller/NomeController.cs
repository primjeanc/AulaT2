using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NomesLibrary.Model;

namespace NomesLibrary.Controller
{
    public class NomeController
    {
        NomeContext contextDB = new NomeContext();
        /// <summary>
        /// Metodo que retorna tabela de nomes
        /// </summary>
        /// <returns></returns>
        public IQueryable<Nome> GetNomes()
        {
            return contextDB.Nomes;
        }
        /// <summary>
        /// Metodo que adiciona nomes
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool AddNome(Nome item)
        {
            if (string.IsNullOrWhiteSpace(item.NomeC))
                return false;
            contextDB.Nomes.Add(item);
            contextDB.SaveChanges();
            return true;

        }

    }
}
