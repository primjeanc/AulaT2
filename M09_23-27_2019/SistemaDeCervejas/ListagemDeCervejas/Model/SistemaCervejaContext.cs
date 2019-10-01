using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListagemDeCervejas.Model
{
    public class SistemaCervejaContext
    {
        public int idContador = 1;//contador para gerar Id das cervejas
        public SistemaCervejaContext()
        {
            ListaDeCervejas = new List<Cerveja>();
            ListaDeCervejas.Add(new Cerveja() { Id = idContador++, Nome = "Original", Litros = 0.6, Alcool = 5.5, Valor = 4.95 });
            ListaDeCervejas.Add(new Cerveja() { Id = idContador++, Nome = "Budweiser", Litros = 0.6, Alcool = 5.0, Valor = 6.55 });
            ListaDeCervejas.Add(new Cerveja() { Id = idContador++, Nome = "Franziskaner Dunkel", Litros = 0.5, Alcool = 6.0, Valor = 16.90 });
            ListaDeCervejas.Add(new Cerveja() { Id = idContador++, Nome = "Stella Artois", Litros = 0.275, Alcool = 5.0, Valor = 2.99 });
            ListaDeCervejas.Add(new Cerveja() { Id = idContador++, Nome = "Bohemia", Litros = 0.355, Alcool = 5.0, Valor = 3.79 });
        }
        private List<Cerveja> ListaDeCervejas { get; set; }//lista privada
        public List<Cerveja> ListaDeCervejasPublica { get { return ListaDeCervejas; } }//retorna lista publica podendo receber adições



    }

}
