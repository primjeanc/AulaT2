using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaBiblicoteca
{
    public class Cervejas
    {
        public static void ClasseListaCervejas()
        {
            Console.Clear();
            var minhaLista = new List<string>();

            minhaLista.Add("Budweiser");
            minhaLista.Add("Corona");
            minhaLista.Add("Stella Artois");
            minhaLista.Add("Franziskaner");
            minhaLista.Add("Original");

            minhaLista.ForEach(i => Console.WriteLine(i)); //foreach simplificado para lista/coleções            
            Console.WriteLine("Aperte qualquer tecla para continuar");
            Console.ReadKey();
        }
    }
}
