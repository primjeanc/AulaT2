﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercitandoWHILEeFOR
{
    class Program
    {
        static void Main(string[] args)
        {
            var nome = @"Pensando mais a longo prazo, a execução dos pontos do programa estimula a padronização dos modos de operação convencionais. O empenho em analisar a constante divulgação das informações acarreta um processo de reformulação e modernização dos relacionamentos verticais entre as hierarquias. No entanto, não podemos esquecer que o fenômeno da Internet faz parte de um processo de gerenciamento dos níveis de motivação departamental. A certificação de metodologias que nos auxiliam a lidar com o entendimento das metas propostas apresenta tendências no sentido de aprovar a manutenção do sistema de participação geral. Do mesmo modo, o novo modelo estrutural aqui preconizado garante a contribuição de um grupo importante na determinação do fluxo de informações.

          A prática cotidiana prova que o desenvolvimento contínuo de distintas formas de atuação assume importantes posições no estabelecimento das direções preferenciais no sentido do progresso. Neste sentido, o início da atividade geral de formação de atitudes pode nos levar a considerar a reestruturação do sistema de formação de quadros que corresponde às necessidades. As experiências acumuladas demonstram que a revolução dos costumes obstaculiza a apreciação da importância do orçamento setorial.

          Todas estas questões, devidamente ponderadas, levantam dúvidas sobre se o aumento do diálogo entre os diferentes setores produtivos nos obriga à análise dos índices pretendidos. Assim mesmo, o acompanhamento das preferências de consumo oferece uma interessante oportunidade para verificação do impacto na agilidade decisória. Nunca é demais lembrar o peso e o significado destes problemas, uma vez que o desafiador cenário globalizado facilita a criação das formas de ação.

          É claro que a mobilidade dos capitais internacionais representa uma abertura para a melhoria das condições financeiras e administrativas exigidas. Por outro lado, a valorização de fatores subjetivos desafia a capacidade de equalização das diversas correntes de pensamento. O incentivo ao avanço tecnológico, assim como a contínua expansão de nossa atividade promove a alavancagem das diretrizes de desenvolvimento para o futuro. Ainda assim, existem dúvidas a respeito de como a necessidade de renovação processual causa impacto indireto na reavaliação de todos os recursos funcionais envolvidos.

          Gostaria de enfatizar que a complexidade dos estudos efetuados é uma das consequências das condições inegavelmente apropriadas. É importante questionar o quanto a crescente influência da mídia ainda não demonstrou convincentemente que vai participar na mudança da gestão inovadora da qual fazemos parte. A nível organizacional, a consolidação das estruturas agrega valor ao estabelecimento dos métodos utilizados na avaliação de resultados. O que temos que ter sempre em mente é que a competitividade nas transações comerciais auxilia a preparação e a composição de alternativas às soluções ortodoxas.

          Caros amigos, a expansão dos mercados mundiais exige a precisão e a definição dos procedimentos normalmente adotados. Todavia, o surgimento do comércio virtual prepara-nos para enfrentar situações atípicas decorrentes dos conhecimentos estratégicos para atingir a excelência. Acima de tudo, é fundamental ressaltar que a consulta aos diversos militantes possibilita uma melhor visão global do retorno esperado a longo prazo.

          Não obstante, o comprometimento entre as equipes maximiza as possibilidades por conta do remanejamento dos quadros funcionais. Evidentemente, a hegemonia do ambiente político aponta para a melhoria do investimento em reciclagem técnica. O cuidado em identificar pontos críticos na adoção de políticas descentralizadoras cumpre um papel essencial na formulação dos paradigmas corporativos. No mundo atual, a estrutura atual da organização deve passar por modificações independentemente das novas proposições.

          Podemos já vislumbrar o modo pelo qual a determinação clara de objetivos afeta positivamente a correta previsão das posturas dos órgãos dirigentes com relação às suas atribuições. Desta maneira, a percepção das dificuldades estende o alcance e a importância do levantamento das variáveis envolvidas. Por conseguinte, o consenso sobre a necessidade de qualificação não pode mais se dissociar do processo de comunicação como um todo.

          Percebemos, cada vez mais, que o julgamento imparcial das eventualidades talvez venha a ressaltar a relatividade das regras de conduta normativas. Por outro lado, a execução dos pontos do programa estimula a padronização das condições financeiras e administrativas exigidas. O empenho em analisar a crescente influência da mídia acarreta um processo de reformulação e modernização dos relacionamentos verticais entre as hierarquias.";
            var countFind = 0;
            Console.WriteLine("Encontre o número de vezes em que a palavra 'que' aparece no texto:");
            var palavra = Console.ReadLine(); //para buscar qlqr combinacao de 3 palavras
            /*
            for (int i = 0; i < (nome.Length-2); i++)
            {
                var palavraBusca = nome[i].ToString() + nome[i + 1].ToString() + nome[i + 2].ToString();
                if (palavra == palavraBusca)
                    countFind++;
            }
            */
            /**/

            int i = 0;
           if (palavra.Length == 3)// fragmentado em IFs para consultar 1, 2 ou 3 letras juntas ao inves de so 3 letras juntas
            while (i < (nome.Length-2))
            {
                var palavraBusca = nome[i].ToString() + nome[i + 1].ToString() + nome[i + 2].ToString();
                
                i++;
                if (palavra == palavraBusca)
                    countFind++;


            }
            else if (palavra.Length == 2)
                while (i < (nome.Length - 1))
                {
                    var palavraBusca = nome[i].ToString() + nome[i + 1].ToString();

                    i++;
                    if (palavra == palavraBusca)
                        countFind++;


                }
            else
                while (i < (nome.Length))
                {
                    var palavraBusca = nome[i].ToString();

                    i++;
                    if (palavra == palavraBusca)
                        countFind++;


                }
                

            Console.WriteLine($"Quantidade total de {palavra} {countFind}");
            Console.ReadKey();

        }
    }
}
