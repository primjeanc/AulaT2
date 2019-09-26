using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaRelatorioCarros.Model;

namespace SistemaRelatorioCarros.Controller
{
    public class VendasController
    {
        SistemaVendasContext vendasContext = new SistemaVendasContext();

        /// <summary>
        /// retorna ListaDeVendas de forma publica, liberado apenas leitura, sem edicao externa
        /// </summary>
        /// <returns></returns>
        public List<Venda> GetVendas(int mes = 0)
        {
            if (mes == 0)
                return vendasContext.ListaDeVendasPublica;
            else
                return vendasContext.ListaDeVendasPublica.FindAll(x => x.Data.Month == mes);
        }
    }
    
}
