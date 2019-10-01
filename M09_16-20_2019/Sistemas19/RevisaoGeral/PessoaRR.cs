using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisaoGeral
{
    public class PessoaRR
    {
        public string Nome { get; set; }
        
        public int Idade { get; internal set; }
       
        public double Altura { get; internal set; }
        
        public char Sexo { get; internal set; }
    }
}
