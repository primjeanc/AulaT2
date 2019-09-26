using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ListagemDeCarros.Model
{
    public class SistemaCarrosContext
    {
        public SistemaCarrosContext()
        {
            ListaDeCarros = new List<Carro>();
            #region lista10
            ListaDeCarros.Add(new Carro() { Id = 1, Marca = "Toyota", Modelo = "Corola", Ano = 2019, Cilindradas = 1600, Portas = 4 });
            ListaDeCarros.Add(new Carro() { Id = 2, Marca = "Honda", Modelo = "Civic", Ano = 2015, Cilindradas = 1800, Portas = 4 });
            ListaDeCarros.Add(new Carro() { Id = 3, Marca = "Ford", Modelo = "Fusion", Ano = 2016, Cilindradas = 1800, Portas = 4 });
            ListaDeCarros.Add(new Carro() { Id = 4, Marca = "Chevrolet", Modelo = "Astra", Ano = 2012, Cilindradas = 2000, Portas = 4 });
            ListaDeCarros.Add(new Carro() { Id = 5, Marca = "Toyota", Modelo = "Etios", Ano = 2018, Cilindradas = 122, Portas = 5 });
            ListaDeCarros.Add(new Carro() { Id = 6, Marca = "FIAT", Modelo = "Palio Sport", Ano = 2017, Cilindradas = 1400, Portas = 5 });
            ListaDeCarros.Add(new Carro() { Id = 7, Marca = "FIAT", Modelo = "UNO Veio", Ano = 2002, Cilindradas = 500, Portas = 5 });
            ListaDeCarros.Add(new Carro() { Id = 8, Marca = "Honda", Modelo = "FIT", Ano = 2016, Cilindradas = 1600, Portas = 5 });
            ListaDeCarros.Add(new Carro() { Id = 9, Marca = "Renault", Modelo = "Clio", Ano = 2017, Cilindradas = 1000, Portas = 5 });
            ListaDeCarros.Add(new Carro() { Id = 10, Marca = "VolksWagem", Modelo = "Fox", Ano = 2018, Cilindradas = 1600, Portas = 5 });
            #endregion

        }

        /// <summary>
        /// Lista original de carros, Private para evitar alterações, * criado ListaDeCarrosPublica com GET da lista original
        /// </summary>
        private List<Carro> ListaDeCarros { get; set; }//lista original
        public List<Carro> ListaDeCarrosPublica { get { return ListaDeCarros; } }//retorna apenas leitura(GET) da ListaDeCarros
    }


}
