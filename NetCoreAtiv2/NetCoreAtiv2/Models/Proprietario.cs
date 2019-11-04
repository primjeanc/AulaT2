using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreAtiv2.Models
{
    public class Proprietario:Controle
    {
        [Key]
        public int Id {get;set;}
        public string Nome {get;set;}
        [EmailAddress]
        public string Email {get;set;}
        public DateTime DataNascimento { get; set; } = DateTime.Now.AddYears(-18);

    }
}
