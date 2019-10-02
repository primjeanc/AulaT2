using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CestaDeFrutas
{
    class Program
    {
        static void Main(string[] args)
        {
            var cestaDeFrutas = new List<Fruta>();

            cestaDeFrutas.Add(new Fruta()
            {
                Id = 0,
                Nome = "Tomate",
                Cor =  "Vermelho",
                Peso = 212
            });//tomate
            cestaDeFrutas.Add(new Fruta()
            {
                Id = 1,
                Nome = "Goiaba",
                Cor = "Verde",
                Peso = 95
            });//goiaba
            cestaDeFrutas.Add(new Fruta()
            {
                Id = 2,
                Nome = "Manga",
                Cor = "Amarelo",
                Peso = 325
            });//manga
            // #region e #endregion separam o codigo on intervalo selecionado para poder minimizar estas linhas
            #region Lista 1            
            cestaDeFrutas.OrderByDescending(x => x.Id).ToList<Fruta>().ForEach(i => Console.WriteLine($"Id: {i.Id} | Nome: {i.Nome}"));
            Console.WriteLine("----Ordem Decrescente por ID--------------------------------------------------");
            #endregion
            #region Lista 2            
            cestaDeFrutas.OrderBy(x => x.Id).ToList<Fruta>().ForEach(i => Console.WriteLine($"Id: {i.Id} | Nome: {i.Nome}"));
            Console.WriteLine("-----Ordem Crescente por ID---------------------------------------------------");
            #endregion
            #region Lista 3           
            cestaDeFrutas.OrderBy(x => x.Nome).ToList<Fruta>().ForEach(i => Console.WriteLine($"Id: {i.Id} | Nome: {i.Nome}"));
            Console.WriteLine("----Ordem Crescente por Nome--------------------------------------------------");
            #endregion
            #region Lista 4
            //filtrando por peso e limitando a lista para mostrar apenas frutas com Peso  acima do valor citado "100"
            var filtroCesta = cestaDeFrutas.Where(x => x.Peso > 100).OrderBy(x=> x.Nome);
            filtroCesta.ToList<Fruta>().ForEach (i => Console.WriteLine($"Id: {i.Id} | Nome: {i.Nome} | Peso: {i.Peso}"));
            Console.WriteLine("------------------------------------------------------------------------------");
            #endregion
            (from frutinha in cestaDeFrutas//joga lista de 'cestaDeFrutas' em 'frutinha'
             where frutinha.Peso > 100//compara lista copiada com peso >100 e imprime se atender a regra de peso
             select frutinha).ToList<Fruta>().ForEach(i => Console.WriteLine($"Fruta escolhida: {i.Nome}"));//resultado impresso 
             
            var mostrandoFind = cestaDeFrutas.Find(x => x.Cor == "Amarelo" || x.Cor == "Vermelho");
            Console.WriteLine($"Id: {mostrandoFind.Id} | Nome: {mostrandoFind.Nome}");
            var mostrandoFindAll = cestaDeFrutas.FindAll(x => x.Cor == "Amarelo" || x.Cor == "Vermelho");
            mostrandoFindAll.ForEach(i => Console.WriteLine($"Id: {i.Id} | Nome: {i.Nome}"));
            Console.WriteLine("---Filtro de Cores------------------------------------------------------------");
            //ToList simplifica o ForEach que seria algo como:
            var listaOrdenada = mostrandoFindAll.OrderBy(x => x.Nome);
            foreach (var item in listaOrdenada)
                Console.WriteLine($"ID: {item.Id} Nome: {item.Nome}");
            Console.WriteLine("-------Find uma das cores------------------------------------------------------");
            var cestaDeFrutasFindOrder = cestaDeFrutas.OrderBy(x=> x.Nome).
                ToList<Fruta>()
                .Find(x=> x.Cor == "Amarelo" || x.Cor == "Vermelho");
            Console.WriteLine($"Id: {cestaDeFrutasFindOrder.Id} | Nome: {cestaDeFrutasFindOrder.Nome}");
            Console.ReadKey();
        }
    }
}
