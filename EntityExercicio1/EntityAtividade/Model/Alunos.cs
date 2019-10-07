using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityAtividade.Model
{
    public class Alunos
    {
        [Key]//primary key identity (1,1) que temos no Banco de Dados SQL
        public int Id { get; set; }
        [Required]
        public int Idade { get; set; }
        [Required]
        [StringLength(30)]// seria o not null para nome, com nvarchar(30) 
        public string Nome { get; set; }
    }
}
