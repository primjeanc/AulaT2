using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool p; //variável booleana
            bool q;
            string r; //var text
            bool s;
           

            string continuar = "S";
            while (continuar == "S")
            {
                Console.WriteLine("Valor para P ( V ou F)");
                r = Console.ReadLine();
                if (r == "V")
                    p = true;
                else
                    p = false;
                Console.WriteLine("Valor para Q (V ou F)");//texto de entrada
                r = Console.ReadLine(); //entrada de dado
                if (r == "V")//leitura de letra ou palavra "String" para boolean
                    q = true;
                else
                    q = false;
                Console.WriteLine(s = (p == q)); // teste logico para v e f
                Console.WriteLine(s = (p != q));
                Console.WriteLine(s = (p && q));
                Console.WriteLine(s = (p || q));
                Console.ReadKey(); //manter tela aberta com resultado

                Console.WriteLine("Deseja continuar?");
                continuar = Console.ReadLine();

                
            }

        }
    }
}
