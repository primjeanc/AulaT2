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
        private int IdLivroContador = 1;
        public LivroController()
        {
            ListaDeLivros = new List<Livro>();
            ListaDeLivros.Add(new Livro() //lista (um ou mais objetos)
            {
                Nome = "A ordem das batatas não altera a maionese",
                Id = IdLivroContador++
            });
            ListaDeLivros.Add(new Livro()
            {
                Nome = "Certo, errado ou XGH",
                Id = IdLivroContador++
            });

        }           

        private List<Livro> ListaDeLivros { get; set; }//class tipo LISTA para guardar os Livros "private" para evitar uso separado dentro do programa
        /// <summary>
        /// Metodo que adiciona livros em nossa lista ja instanciada criada dentro do construtor
        /// </summary>
        /// <param name="livro"></param>
        public void AdicionarLivro(Livro livro)
        {
            livro.Id = IdLivroContador++;
            ListaDeLivros.Add(livro);
        }
        public List<Livro> RetornaListaDeLivros()
        {
            return ListaDeLivros;
        }







    }
}
