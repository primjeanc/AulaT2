using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeLibrary.Model
{
    public class Modelo
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int IdMarca { get; set; }

        //public Marca IdMarca {get;set;} //??
        [Required]
        [MaxLength(25)]
        public string Nome { get; set; }        
    }
}
