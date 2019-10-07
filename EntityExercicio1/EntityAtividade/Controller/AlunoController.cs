using EntityAtividade.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityAtividade.Controller
{
    public class AlunoController
    {
        ContextDB contextDB = new ContextDB();

        public IQueryable<Alunos> GetAlunos()
        {
            #region sobreQueryable
            //IQueryable - aqui temos nossa primeira interface com a classe, 
            //IQueryable essa classe contem varias funcionalidades prontas para usar igual bando de dados como SELECT
            //<Alunos> - definimos o tipo que ira retornar , GetPessoas - dando nome ao Metodo
            #endregion
            return contextDB.ListaDeAlunos;//retorna a lista de pessoas           
        }
        public void AddAluno(Alunos item)//item, pessoa, qlqr nome para o objeto
        {
            #region comentarios
            //contextDB - nosso bando de dados, 
            //.ListaDePessoas - nossa tabela Pessoa
            //Add.(item) adicionamos o item
            #endregion
            contextDB.ListaDeAlunos.Add(item);
            contextDB.SaveChanges();
        }

    }
}
