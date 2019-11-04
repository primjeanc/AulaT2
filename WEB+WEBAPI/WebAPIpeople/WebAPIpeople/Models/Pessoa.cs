using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAPIpeople.Models
{
    public class Pessoa
    {
        [Key]
        public int Id { get; set; }        
        [Required]      
        public int Idade { get; set; } = 0;
        [Required]
        public string Nome { get; set; } = string.Empty;
        public bool Ativo { get; set; } = true;
    }
}