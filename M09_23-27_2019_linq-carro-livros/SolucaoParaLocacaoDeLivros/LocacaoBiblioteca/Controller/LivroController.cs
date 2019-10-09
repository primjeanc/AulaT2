using LocacaoBiblioteca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca.Controller
{
    public class LivroController
    {
        LocacaoContext contextDB = new LocacaoContext();//inicia a classe do LocacaoContext

        public IQueryable<Livro> GetLivros()
        {
            return contextDB.Livros.Where(x => x.Ativo == true);
        }      
        public bool AddLivro(Livro item)
        {
            if (string.IsNullOrWhiteSpace(item.Nome))// metodo que identifica espacos em branco
                return false;
           
            contextDB.Livros.Add(item);
            contextDB.SaveChanges();
            
            return true;

        }
        //public List<Livro> RetornaListaDeLivros()
        //{
        //    return contextDB.Livros.Where(x => x.Ativo).ToList<Livro>(); 
        //    //where(..ativo) onde o where procura retorno BOOLEAN do Ativo, que seriam os TRUE apenas
        //    //quando passa pela lambda '=>' deixa de ser lista, o ToList faz voltar a ser lista
        //}

        /// <summary>
        /// Metodo para desativar registro do livro selecionado pelo ID
        /// </summary>
        /// <param name="intentificadoID"></param>
        public bool RemoverLivroPorID(int intentificadoID)
        {
            //aqui usamos FirstOrDefault para localiza nosso usuario dentro da lista
            //com isso conseguimos acessar as propriedades dele e desativar o registro
            var livro = contextDB.Livros.FirstOrDefault(x => x.Id == intentificadoID);
            if (livro == null)
                return false;

            livro.Ativo = false;
            contextDB.SaveChanges();

            return true;
            
        }
        public bool AtualizarLivro(Livro item)
        {
            var book =//variavel para o livro
            contextDB.Livros.FirstOrDefault(x => x.Id == item.Id);
            //BD      tabela    busca na tabela o livro
            //Compara os IDs e verifica se encontrou o livro
            if (book == null)
                return false;
            else
                book = item;
            book.DataAlteracao = DateTime.Now;
            contextDB.SaveChanges();// salva apos confirmar IDs iguais
            return true;
        }


    }
}
