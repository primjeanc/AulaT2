using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityClass.Model;

namespace EntityClass.Controller
{
    public class PessoaController
    {
        //Realizo minha conexão com o bando de dados
        EntityContextDB contextDB = new EntityContextDB();

        public IQueryable<Pessoa> GetPessoas()
        {
            //IQueryable - aqui temos nossa primeira interface com a classe, 
            //IQueryable essa classe contem varias funcionalidades prontas para usar igual bando de dados como SELECT
            //<Pessoa> - definimos o tipoq eu ira retornar , GetPessoas - dando nome ao Metodo
            return contextDB.ListaDePessoas;//retorna a lista de pessoas
        }
    }
}
