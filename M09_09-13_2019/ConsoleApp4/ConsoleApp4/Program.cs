using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        //iniciando uma constante de um numero inteiro
        const int testeConst = 999;

        
        static void Main(string[] args)
        {
            string testePrimitivo = string.Empty;
            String outroTestePrimitivo;
            bool testComp;
            Boolean testeComp;
            bool? testeBoolNull; //bool? aceita valor nulo alem de verdadeiro/falso
            int numeroInteiro = 999;
            long numeroInteiroLongo = 8598215; //numero inteiro maior

            var testeFora = string.Empty;
            testeFora = "teste";

            var teste1 = "String";//texto
            var teste2 = 'C';//char
            var teste3 = 9;//int
            var teste4 = 3.8;//double
            var teste5 = 0x00F;//hexa
            //apresentando a const
            Console.WriteLine(testeConst);
            Console.ReadKey();

        }
    }
}
