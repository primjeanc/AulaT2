using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityClass.Model
{
    public class Pessoa
    {
        [Key]// aqui temos uma anotação que indica que nossa chave é o campo logo abaixo
        //da nossa anotacao e a palavra chave [key] significa que ele eh nossa chave primaria como no sql
        public int Id { get; set; }
        public string Nome { get; set; }


    }
}
