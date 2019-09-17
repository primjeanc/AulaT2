using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeachNaLista
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaDateTime();
            ListaString();
            ListaInteiros();
            ListaDecimais();

            Console.ReadKey();
        }
        /// <summary>
        /// Lista de datas
        /// </summary>
        private static void ListaDateTime()
        {
            var minhaLista = new List<DateTime>();
            minhaLista.Add(new DateTime(2019, 9, 17));
            minhaLista.Add(new DateTime(2019, 9, 18));
            minhaLista.Add(new DateTime(2019, 9, 19));
            minhaLista.Add(new DateTime(2019, 9, 20));
            Console.WriteLine("Lista de datas:");
            //'minhaData' variável criada como indice/itens da lista sem precisar determinar tipo como var,int etc
            minhaLista.ForEach(minhaData => Console.WriteLine(minhaData.ToString("yyyy/MM/dd")));            
        }
        /// <summary>
        /// Lista de marcas
        /// </summary>
        private static void ListaString()
        {
            var minhaLista = new List<string>();

            minhaLista.Add("XIAOMI");
            minhaLista.Add("IPHONE APPLE");
            minhaLista.Add("SAMSUNG");
            minhaLista.Add("NOKIA");

            minhaLista.ForEach(i => Console.WriteLine(i)); //foreach simplificado para lista/coleções
        }
        /// <summary>
        /// Lista de números inteiros
        /// </summary>
        private static void ListaInteiros()
        {
            var minhaLista = new List<int>();

            minhaLista.Add(17);
            minhaLista.Add(18);
            minhaLista.Add(19);
            minhaLista.Add(20);
            Console.WriteLine("Lista de números inteiros:");
            minhaLista.ForEach(i => Console.WriteLine(i)); 
        }
        /// <summary>
        /// Lista de Decimais
        /// </summary>
        private static void ListaDecimais()
        {
            var minhaLista = new List<double>();

            minhaLista.Add(3.75);
            minhaLista.Add(4.98);
            minhaLista.Add(2.42);
            minhaLista.Add(110.05);
            Console.WriteLine("Lista Monetário:");
            minhaLista.ForEach(nDec => Console.WriteLine(nDec.ToString("C") + 
                " " + MoneyCulture(nDec, "en-US", 4.5008) + " | " 
                + MoneyCulture(nDec, "ja-JP",0.038) + " | "
                + MoneyCulture(nDec, "eu-EN", 4.70) + " euro  |" + " "                
                + FormataRealBitCoin(nDec)));         
        }/*
        private static string FormataNumeroDecimalEmDolar(double meuNumero)
        {
            return (meuNumero / 4.5008).ToString("C", CultureInfo.CreateSpecificCulture("en-US"));//dolar
        }*//*
        private static string FormataRealIene(double meuNumero)
        {
            return (meuNumero / 0.038).ToString("C2", CultureInfo.CreateSpecificCulture("ja-JP"));//Iene japones
        }*//*
        private static string FormataRealEuro(double meuNumero)
        {
            return (meuNumero / 4.70).ToString("C", CultureInfo.CreateSpecificCulture("eu-EN"));//euro
        }*/
        /// <summary>
        /// Metodo que converte moeda Real para BitCoin
        /// </summary>
        /// <param name="meuNumero"></param>
        /// <returns></returns>
        private static string FormataRealBitCoin(double meuNumero)
        {
            return (meuNumero / 41824.47).ToString("C10").Replace("R$", "BTC");//return (meuNumero / 41824.47).ToString()
        }
        /// <summary>
        /// Método que converte moeda Real para outras moedas Dolar/Iene/Euro
        /// </summary>
        /// <param name="meuNumero"></param>
        /// <param name="cultura"></param>
        /// <param name="diferenca"></param>
        /// <returns></returns>
        private static string MoneyCulture(double meuNumero, string cultura, double diferenca)
        {
            return (meuNumero / diferenca).ToString("C2", CultureInfo.CreateSpecificCulture(cultura));
        }
    }
}
