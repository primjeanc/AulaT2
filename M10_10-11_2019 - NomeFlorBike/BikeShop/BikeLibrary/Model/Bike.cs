using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeLibrary.Model
{
    public class Bike:Controle
    {
        [Key]
        public int Id {get;set;}
        [Required]
        public double Valor { get; set; }
        [Required]   
        //[ForeignKey("Id")]
        public int IdModelo { get; set; }
        public Modelo Modelo { get; set; }        

        
    }
}
