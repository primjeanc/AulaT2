using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisandoEntity.Model
{
    public class Cerveja
    {// habilita o [key] com o 'using....'
        [Key]// primary key identity(1,1) do banco
        public int Id { get; set; }

        [Required]// define como not null
        [StringLength(50)]//define tamanho do nvarchar de Nome (nro de caracteres da string)
        public string Nome { get; set; }
        [StringLength(25)]
        public string Tipo { get; set; }
        public double Teor { get; set; }
    }
}
