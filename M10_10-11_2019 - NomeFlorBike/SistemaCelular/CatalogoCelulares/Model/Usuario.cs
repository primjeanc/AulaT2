using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCelulares.Model
{
    public class Usuario: ControleUsuario
    {
        [Key]// primary key identity(1,1)
        public int Id { get; set; }
        [MaxLength(50)]// semelhante ao stringLenght
        public string Nome { get; set; }
        [Required]//campo obrigatorio = a NOT NULL do SQL
        [MaxLength(30)]
        public string Login { get; set; }
        [MaxLength(30)]
        [Required]
        public string Senha { get; set; }


    }
}
