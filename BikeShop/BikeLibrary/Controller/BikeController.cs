using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BikeLibrary.Model;

namespace BikeLibrary.Controller
{
    
    public class BikeController
    {
        BikeContext contextDB = new BikeContext();

        public IQueryable<Bike> GetBikes()
        {
            return contextDB.Bikes.Where(x => x.Ativo == true);
        }

        public bool AddBike(Bike item)
        {
            if (string.IsNullOrWhiteSpace(item.Marca))// metodo que identifica espacos em branco
                return false;
            if (string.IsNullOrWhiteSpace(item.Modelo))// metodo que identifica espacos em branco
                return false;
            if (item.Valor <= 0)//impede valores 0 ou negativos
                return false;
            contextDB.Bikes.Add(item);// parte final do adicionar, ela insere na tabela e salva com o comando abaixo
            contextDB.SaveChanges();
            return true;
        }
        public bool UpdateBike(Bike item)
        {
            var book = contextDB.Bikes.FirstOrDefault(x => x.Id == item.Id);
            //           BD      tabela    busca na tabela o livro
            //Compara os IDs e verifica se encontrou o livro
            if (book == null)
                return false;
            else
                book = item;
            book.DataAlteracao = DateTime.Now;
            contextDB.SaveChanges();// salva apos confirmar IDs iguais
            return true;
        }
        public bool RemoveBike(int findId)
        {
            var bike = contextDB.Bikes.FirstOrDefault(x => x.Id == findId);
            if (bike == null)
                return false;

            bike.Ativo = false;
            contextDB.SaveChanges();
            return true;
        }


    }
}
