using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaBiblicoteca
{
    public class MontadorasCarros
    {
        public static void ClasseListaCarros()
        {
            Console.Clear();
            var minhaLista = new List<string>();

            minhaLista.Add("Toyota");
            minhaLista.Add("Honda");
            minhaLista.Add("Ford");
            minhaLista.Add("Hyundai");
            minhaLista.Add("Nissan");
            minhaLista.Add("Volkswagen");

            minhaLista.ForEach(i => Console.WriteLine(i)); //foreach simplificado para lista/coleções
            Console.WriteLine("Aperte qualquer tecla para continuar");
            Console.ReadKey();

        }
    }
}
