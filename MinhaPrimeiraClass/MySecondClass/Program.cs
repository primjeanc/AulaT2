using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySecondClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var fruitList = new List<Fruits>
            {
                new Fruits()
                {
                    Name = "Morango",
                    Quantity = 5 },
                new Fruits()
                {
                    Name = "Banana",
                    Quantity = 7 },
                new Fruits()
                {
                    Name = "Pera",
                    Quantity = 9 },

            };
            fruitList.ForEach(i => Console.WriteLine($"Nome: {i.Name} -- Quantidade: {i.Quantity}"));
            Console.ReadKey();
        }
    }
}
