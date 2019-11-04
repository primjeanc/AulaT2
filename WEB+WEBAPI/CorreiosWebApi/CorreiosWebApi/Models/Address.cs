using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CorreiosWebApi.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }      
        [Required]
        public string Logradouro { get; set; } = string.Empty;
        public string Bairro { get; set; } = string.Empty;
        public string CEP { get; set; } = string.Empty;
        [MaxLength(2)]
        public string Uf { get; set; } = string.Empty;
        public string Municipio { get; set; } = string.Empty;
        public string Complemento { get; set; } = string.Empty;
    }
}