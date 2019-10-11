using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BikeLibrary.Model;

namespace BikeLibrary.Controller
{
    public class MarcaController
    {
        BikeContext contextDB = new BikeContext();

        public IQueryable<Marca> GetMarcas()
        {
            return contextDB.Marcas.Where(x => x.Ativo == true);
        }

        public bool AddMarca(Marca item)
        {
            if (string.IsNullOrWhiteSpace(item.Nome))// metodo que identifica espacos em branco
                return false;

            contextDB.Marcas.Add(item);// parte final do adicionar, ela insere na tabela e salva com o comando abaixo
            contextDB.SaveChanges();
            return true;
        }
        public bool UpdateMarca(Marca item)
        {
            var atualiza = contextDB.Marcas.FirstOrDefault(x => x.Id == item.Id);
            //           BD      tabela    busca na tabela o livro
            //Compara os IDs e verifica se encontrou o livro
            if (atualiza == null)
                return false;
            else
                atualiza = item;
            atualiza.DataAlteracao = DateTime.Now;
            contextDB.SaveChanges();// salva apos confirmar IDs iguais
            return true;
        }
        public bool RemoveMarca(int findId)
        {
            var atualiza = contextDB.Marcas.FirstOrDefault(x => x.Id == findId);
            if (atualiza == null)
                return false;

            atualiza.Ativo = false;
            contextDB.SaveChanges();
            return true;
        }
    }
}
