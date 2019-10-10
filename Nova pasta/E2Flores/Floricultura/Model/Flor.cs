using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Floricultura.Model
{
    public class Flor
    {
        [Key]
        public int Id {get;set;}
        [Required]
        public int Quantidade {get;set;}
        [Required]
        [MaxLength(20)]
        public string Nome { get; set; }
    }
}
