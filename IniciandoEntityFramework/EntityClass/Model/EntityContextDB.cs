using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityClass.Model
{
    public class EntityContextDB : DbContext //DbContext classe pronta que contem todos os processos
        //de conexão com o banco de dados listagem das tabelas
    {
        public DbSet<Pessoa> ListaDePessoas { get; set; }
        //DbSet - palavra reservada para Entity que indica que vamos definir uma tabela do nosso bando de dados
        //<Pessoa> -  aqui definimos nossa tabela Pessoa, ou seja especificamos qual classe sera referencia 
        //de uma tabela do bando de dados, ela vai ao bando com o nome que definimos em nossa classe
        //ListaDePessoas {get;set;} -  nessa parte liberamos nossa tabela para acessar

    }
}
