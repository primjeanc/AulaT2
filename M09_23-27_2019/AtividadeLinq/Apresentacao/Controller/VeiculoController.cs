using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apresentacao.Model;

namespace Apresentacao.Controller
{
    public class VeiculoController
    {
        public Context contextDB = new Context();

        public List<Veiculo> RetornaListaVeiculos()
        {
            return contextDB.ListaVeiculo;
        }
        public List<Veiculo> RetornaListaVeiculosMes(int mes)
        {
            return contextDB.ListaVeiculo.Where(x=> x.Data.Month == mes).ToList();
        }

    }
    
}
