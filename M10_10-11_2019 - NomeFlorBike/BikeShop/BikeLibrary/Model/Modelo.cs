using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeLibrary.Model
{
    public class Modelo:Controle
    {
        [Key]
        public int Id { get; set; }        
        [Required]
        //[ForeignKey("Id")]//teoricamente faz FK do SQL pegando o ID da tabela atual e abaixo o ID da classe/tabela abaixo
        public int IdMarca { get; set; }
        public Marca Marca { get; set; }        
        [Required]
        [MaxLength(25)]
        public string Nome { get; set; }        
    }
}
