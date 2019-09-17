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

            minhaLista.Add(10003.75);
            minhaLista.Add(5004.98);
            minhaLista.Add(12002.42);
            minhaLista.Add(15000.05);
            Console.WriteLine("Lista Monetário:");
            minhaLista.ForEach(nDec => Console.WriteLine(nDec.ToString("C") + 
                " " +FormataNumeroDecimalEmDolar(nDec) + " " + FormataRealIene(nDec) + " " 
                + FormataRealEuro(nDec)+" euro  |" + " "
                + FormataRealBitCoin(nDec) + " BitCoin" + " "
                + MoneyCulture(nDec,"eu-EN",42000) + " BitCoin"));
            //minhaLista.ForEach(nDec => Console.WriteLine(nDec.ToString("C2",CultureInfo.CreateSpecificCulture("ja-JP"))));//japones
            
        }
        private static string FormataNumeroDecimalEmDolar(double meuNumero)
        {
            return (meuNumero / 4.5008).ToString("C", CultureInfo.CreateSpecificCulture("en-US"));//dolar
        }
        private static string FormataRealIene(double meuNumero)
        {
            return (meuNumero * 26.39).ToString("C", CultureInfo.CreateSpecificCulture("ja-JP"));//Iene japones
        }
        private static string FormataRealEuro(double meuNumero)
        {
            return (meuNumero / 5.10).ToString("C", CultureInfo.CreateSpecificCulture("eu-EN"));//euro
        }
        private static string FormataRealBitCoin(double meuNumero)
        {
            return (meuNumero / 41824.47).ToString("C2", CultureInfo.CreateSpecificCulture("eu-EN"));//return (meuNumero / 41824.47).ToString()
        }
        private static string MoneyCulture(double meuNumero, string cultura, double diferenca)
        {
            return (meuNumero / diferenca).ToString("C2", CultureInfo.CreateSpecificCulture(cultura));
        }
    }
}
