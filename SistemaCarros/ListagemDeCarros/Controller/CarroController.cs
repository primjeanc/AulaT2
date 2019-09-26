using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListagemDeCarros.Model;

namespace ListagemDeCarros.Controller
{
    public class CarroController
    {
        SistemaCarrosContext carrosContext = new SistemaCarrosContext();// inicia e aloca em memoria

        /// <summary>
        /// Metodo que retorna lista de carros completa
        /// </summary>
        /// <returns></returns>
        public List<Carro> ListagemCarros()
        { return carrosContext.ListaDeCarrosPublica; }
    }
    
}
