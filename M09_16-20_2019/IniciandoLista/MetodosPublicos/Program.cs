using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosPublicos
{
    public class Program
    {
        static void Main(string[] args)
        {
  

        }
        /// <summary>
        /// Metodo principal de inicialização do sistema
        /// </summary>
        public static void ConversorMonetarioSis()
        {
            Console.WriteLine("Sistema conversor de moedas");
            Console.WriteLine("Informe o valor em reais a ser convertido:");

            var valorAConverter = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe uma moeda para conversão:");
            Console.WriteLine("DOLAR,EURO,YEN,BTC");

            var moedaAlvoParaConverter = Console.ReadLine().ToLower();
            ConvertMoeda(valorAConverter, moedaAlvoParaConverter);

            Console.ReadKey();
        }
        /// <summary>
        /// Método que converte moeda Real para um alvo específico
        /// DOLAR
        /// EURO
        /// YEN
        /// BITCOIN
        /// </summary>
        /// <param name="minhaMoeda"></param>
        /// <param name="moedaAlvo"></param>
        public static void ConvertMoeda(double minhaMoeda, string moedaAlvo)
        {           
            switch (moedaAlvo)//qualquer nome de variavel desde que esteja declarada no inicio do metodo
            {
                case "dolar":
                    Console.WriteLine(FormatRealDolar(minhaMoeda));
                    break;
                case "euro":
                    Console.WriteLine(FormataRealEuro(minhaMoeda));
                    break;
                case "yen":
                    Console.WriteLine(FormataRealIene(minhaMoeda));
                    break;
                case "btc":
                    Console.WriteLine(FormataRealBitCoin(minhaMoeda));
                    break;
                default:
                    Console.WriteLine("Nenhuma opção válida informada");
                    break;
            }

        }
        /// <summary>
        /// Converte moeda para Dolar
        /// </summary>
        /// <param name="meuNumero"></param>
        /// <returns></returns>
        private static string FormatRealDolar(double meuNumero)
        {
            return (meuNumero / 4.5008).ToString("C2", CultureInfo.CreateSpecificCulture("en-US"));//dolar
        }
        /// <summary>
        /// COnverte moeda para Euro
        /// </summary>
        /// <param name="meuNumero"></param>
        /// <returns></returns>
        private static string FormataRealEuro(double meuNumero)
        {
            return (meuNumero / 4.70).ToString("C", CultureInfo.CreateSpecificCulture("en-US")).Replace("$", "Euro ");//euro
        }
        /// <summary>
        /// Converte moeda para Iene (YEN)
        /// </summary>
        /// <param name="meuNumero"></param>
        /// <returns></returns>
        private static string FormataRealIene(double meuNumero)
        {
            return (meuNumero / 0.038).ToString("C2", CultureInfo.CreateSpecificCulture("ja-JP"));//Iene japones
        }
        /// <summary>
        /// Converte moeda para BitCoin
        /// </summary>
        /// <param name="meuNumero"></param>
        /// <returns></returns>
        private static string FormataRealBitCoin(double meuNumero)
        {
            return (meuNumero / 41824.47).ToString("C10").Replace("R$", "BitCoin");
        }
    }
}
