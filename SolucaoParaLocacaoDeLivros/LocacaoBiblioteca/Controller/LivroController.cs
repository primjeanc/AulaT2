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
        public LivroController()
        {
            ListaDeLivros = new List<Livro>();
            ListaDeLivros.Add(new Livro() //lista (um ou mais objetos)
            {
                Nome = "A ordem das batatas não altera a maionese",
                Id = 000001
            });
            ListaDeLivros.Add(new Livro()
            {
                Nome = "Certo, errado ou XGH",
                Id = 000002
            });

        }           

        public List<Livro> ListaDeLivros { get; set; }//class tipo LISTA para guardar os Livros
        /// <summary>
        /// Metodo que adiciona livros em nossa lista ja instanciada criada dentro do construtor
        /// </summary>
        /// <param name="paralivro"></param>
        public void AdicionarLivro(Livro paralivro)
        {
            ListaDeLivros.Add(paralivro);
        }
       






    }
}
