using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeLibrary.Model
{
    public class Bike
    {
        [Key]
        public int Id {get;set;}
        [Required]        
        public int IdMarca { get; set; }
        [Required]        
        public int IdModelo { get; set; }
        [Required]        
        public double Valor { get; set; }
        public bool Ativo { get; set; } = true;
        public DateTime DataCriacao { get; set; } = DateTime.Now;
        public DateTime DataAlteracao { get; set; } = DateTime.Now;
        
    }
}
