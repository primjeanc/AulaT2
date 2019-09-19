using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RevisaoGeral
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PessoaRR> pessoas = new List<PessoaRR>();

            PessoaRR p1 = new PessoaRR();
            p1.Nome = "gabriel";
            p1.Idade = 29;
            p1.Sexo = 'M';
            p1.Altura = 2.03;
            PessoaRR p2 = new PessoaRR();
            p2.Nome = "elora";
            p2.Idade = 21;
            p2.Sexo = 'F';
            p2.Altura = 1.53;
            PessoaRR p3 = new PessoaRR();
            p3.Nome = "ronaldo";
            p3.Idade = 15;
            p3.Sexo = 'M';
            p3.Altura = 1.6;

            List<PessoaRR> menoresIdade = new List<PessoaRR>();
            foreach (PessoaRR p in pessoas)
            {
                if (p.Idade < 18)
                {
                    menoresIdade.Add(p);
                }
            }
            // Lambda - Where/OrderBy/FirstOrDefault
            pessoas.Where(pes => pes.Idade < 18); // retorna menores de 18 anos
            List<PessoaRR> pessoasOrdenadasPorAltura = pessoas.OrderBy(pa => pa.Altura).ToList(); //--- orndenar...
            // ----- falta classe pra rodar
            /*
            List<int> numeros = new List<int>();//criando lista 'numeros'
            Random rdm = new Random();

            //HashSet <int> dados = new HashSet<int>();
            //dados.Add(30)
            //dados.Add(30) <<<seria ignorado

            for (int w = 0; w < 10; w++)
            {
                int valorGeradoAleatoriamente = rdm.Next(100);//gera nro aleatorio 0-100
                if (!numeros.Contains(valorGeradoAleatoriamente))//verifica se alista nao contem este numero gerado acima
                {
                    numeros.Add(valorGeradoAleatoriamente);
                }
                else
                {
                    w--;//retorna 1 posicao( a  posicao havia incrementado no FOR mas não cumpriu a tarefa pois na tendeu o IF
                }
                
            }*/
            Console.ReadLine();









            //b = a
            //Neste caso, "b' aponta para a mesma area de Memoria que "a", OU SEJA
            //alterar o valor de 'b' dentro deste metodo
            //afetará a instancia de "a" no metodo main
            /*
            Amigos a = new Amigos(); //considerando que a classe Amiguinho tem objetos Nome e TempoAmizade
            a.Nome = "felipe";
            a.TempoAmi = 20;
            Casar(a);
            Console.WriteLine(a.Nome);
            Console.ReadKey();*/
            /*
            int ii = 30;
            Hebeficar(ref ii);//out n precisa inicializar o "ii" (variavel int...)
            Console.WriteLine(ii);
            int resultadoConversao = 0;
            if (int.TryParse("145", out resultadoConversao))
            {

            }....*/
        }
        static void Casar(PessoaRR b)
        {
            b.Nome += "Bernart";
        }

        static void Hebeficar(ref int idade)//ref ou out --- out n precisa inicializar o "ii" (variavel int...)
        {
            idade = 16000;
        }
    }
}
