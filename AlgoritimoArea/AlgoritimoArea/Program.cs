using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritimoArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double ladoA;
            double ladoB;
            double areaT;
            int tipoDe;
            Console.WriteLine("Cálculo de Área");
            Console.WriteLine("Tipo de área: (1)quadrado (2)círculo (3)triângulo");
            tipoDe = Convert.ToInt32(Console.ReadLine());

            if (tipoDe == 1)
            {
                Console.WriteLine("Cálculo de Área, informe lado A");
                ladoA = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Cálculo de Área, informe lado B");
                ladoB = Convert.ToInt32(Console.ReadLine());
                areaT = (ladoA * ladoB);
                Console.Write("Área Total: ");
                Console.Write(areaT);
                Console.Write(" m²");
            } else if (tipoDe == 2)
                {
                    Console.WriteLine("Cálculo de Área, informe raio do círculo:");
                    ladoA = Convert.ToInt32(Console.ReadLine());
                   
                    areaT = (ladoA*ladoA*3,141596);
                    Console.Write("Área Total: ");
                    Console.Write(areaT);
                    Console.Write(" m²");
                }
                else
                {
                    Console.WriteLine("Cálculo de Área, informe Base");
                    ladoA = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Cálculo de Área, informe Altura");
                    ladoB = Convert.ToInt32(Console.ReadLine());
                    areaT = ((ladoA * ladoB)/2);
                    Console.Write("Área Total: ");
                    Console.Write(areaT);
                    Console.Write(" m²");
                }
            
            Console.WriteLine("Cálculo de Área, informe lado A");
            ladoA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Cálculo de Área, informe lado B");
            ladoB = Convert.ToInt32(Console.ReadLine());
            areaT = (ladoA * ladoB);
            Console.Write("Área Total: ");
            Console.Write(areaT);
            Console.Write(" m²");
            Console.ReadKey();
        }
    }
}
