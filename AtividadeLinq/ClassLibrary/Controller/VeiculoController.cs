using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apresentacao.Model;//o using criado era ClassLibrary.Model mas como puxou depois associou com a versao anterior


namespace Apresentacao.Controller
{
    public class VeiculoController
    {
        public Context contextDB = new Context();

        public List<Veiculo> RetornaListaVeiculos()//lista geral extra, nao era obrigatorio
        {
            return contextDB.ListaVeiculo;
        }
        public List<Veiculo> RetornaListaVeiculosMes(int mes)
        {
            return contextDB.ListaVeiculo.Where(x=> x.Data.Month == mes).ToList();
        }

    }
    
}
