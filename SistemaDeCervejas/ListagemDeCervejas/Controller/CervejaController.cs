using ListagemDeCervejas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ListagemDeCervejas.Controller
{
    public class CervejaController
    {
        SistemaCervejaContext cervejaContext = new SistemaCervejaContext();

        /// <summary>
        /// Metodo que retorna a lista de cervejas consumidas
        /// </summary>
        /// <returns></returns>
        public List<Cerveja> GetCervejas()//Listagem
        {
            return cervejaContext.ListaDeCervejasPublica;
        }

        /// <summary>
        /// metodo que inicia adicao de Cerveja a lista, ela gera o valor de contador e inicia o ponto .Add
        /// no programa deverá ser informado demais dados nome,litros,alcool, valor e chamar metodo AddCerveja
        /// para receber Id e adicionar a lista
        /// </summary>
        /// <param name="cerveja"></param>
        public void AddCerveja(Cerveja cerveja)
        {
            cerveja.Id = cervejaContext.idContador++;
            cervejaContext.ListaDeCervejasPublica.Add(cerveja);            


        }
        /// <summary>
        /// Metodo que retorna custo(Valor) total gasto em cerveja
        /// </summary>
        /// <returns></returns>
        public double SomaValorCerveja()
        {
            return cervejaContext.ListaDeCervejasPublica.Sum(x => x.Valor);
            
        }
        /// <summary>
        /// Metodo que retorna quantidade de Alcool consumido
        /// </summary>
        /// <returns></returns>
        public double SomaLitrosCerveja() 
        {
            return cervejaContext.ListaDeCervejasPublica.Sum(x => x.Litros);

        }
        /// <summary>
        /// Metodo que testa teor de alcool na Lei Seca, 
        /// esperando ser informado no programa sexo (m/f) e peso em kilos
        /// </summary>
        /// <param name="gender"></param>
        /// <param name="weight"></param>
        /// <returns></returns>
        public bool LeiSeca(double gender, double weight)
        {
            //litros*10*alcool/(peso*taxaGender)
            var teorAlcool = cervejaContext.ListaDeCervejasPublica.Sum(x => (x.Litros * 10 * x.Alcool/(weight*gender)));
            if (teorAlcool > 0.05)
                return true;
            else return false;
        }
    }
}
