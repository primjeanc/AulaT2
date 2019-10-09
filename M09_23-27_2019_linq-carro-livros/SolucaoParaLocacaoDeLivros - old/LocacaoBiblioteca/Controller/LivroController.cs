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
        private LocacaoContext contextDB = new LocacaoContext();//inicia a classe do LocacaoContext
        public LivroController()
        {
            

        }           
                
       
        public void AdicionarLivro(Livro livro)
        {
            livro.Id = contextDB.IdLivroContador++;
            contextDB.ListaDeLivros.Add(livro);
        }
        public List<Livro> RetornaListaDeLivros()
        {
            return contextDB.ListaDeLivros.Where(x => x.Ativo).ToList<Livro>(); 
            //where(..ativo) onde o where procura retorno BOOLEAN do Ativo, que seriam os TRUE apenas
            //quando passa pela lambda '=>' deixa de ser lista, o ToList faz voltar a ser lista
        }

        /// <summary>
        /// Metodo para desativar registro do livro selecionado pelo ID
        /// </summary>
        /// <param name="intentificadoID"></param>
        public void RemoverLivroPorID(int intentificadoID)
        {
            //aqui usamos FirstOrDefault para localiza nosso usuario dentro da lista
            //com isso conseguimos acessar as propriedades dele e desativar o registro
            var livro = contextDB.ListaDeLivros.FirstOrDefault(x => x.Id == intentificadoID);
            if (livro != null)
                livro.Ativo = false;
            //usando if(...) ao inves de usar direto '.Ativo = false' para evitar erro ao tentar remover ID que nao existe ou n foi encontrado
            //poderia usar IF no usuarioController tambem
        }







    }
}
