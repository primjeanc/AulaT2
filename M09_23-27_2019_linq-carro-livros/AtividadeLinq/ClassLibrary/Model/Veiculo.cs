using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apresentacao.Model
{
    public class Veiculo//o nome correto da classe seria 'Venda' ja que a lista eh um relatorio de vendas com os compradores nao modelos
    {
        public int Id { get; set; }
        public string Carro { get; set; }
        public double Valor { get; set; }
        public int Quantidade { get; set; }
        public DateTime Data { get; set; } // na hora de povoar a lista seria algo como >>> Data = DateTime.Parse("10/02/2019") 

    }
}
