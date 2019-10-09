using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCelulares.Model
{
    public class ControleUsuario
    {
        public bool Ativo { get; set; } = true; // = default 1 do SQL
        public int UsuarioCriacao { get; set; } = 0;// = default 0 do SQL
        public int UsuarioAlteracao { get; set; } = 0;
        public DateTime DataCriacao { get; set; } = DateTime.Now; // = default getdate() SQL
        public DateTime DataAlteracao { get; set; } = DateTime.Now;
    }
}
