using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RegistroImoveis.Models
{
    public class Proprietario
    {
        [Key]
        public int Id { get; set; }
        [CustomValidator("Nome")]
        public string Nome { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [CustomValidator("DataNascimento")]
        public DateTime DataNascimento { get; set; }
    }
}