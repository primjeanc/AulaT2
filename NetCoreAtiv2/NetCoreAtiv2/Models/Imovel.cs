using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreAtiv2.Models
{
    public class Imovel:Controle
    {
        [Key]
        public int Id { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Municipio { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public int ProprietarioId { get; set; }
    }
}
