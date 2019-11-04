using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreAtiv2.Models
{
    public class Controle
    {
        public bool Ativo { get; set; } = true;
        public int UsuarioCri { get; set; } = 0;
        public int UsuarioAlt { get; set; } = 0;
        public DateTime DataCriacao { get; set; } = DateTime.Now;
        public DateTime DataAlteracao { get; set; } = DateTime.Now;
    }
}
