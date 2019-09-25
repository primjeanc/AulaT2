using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apresentacao.Model
{
    public class Context
    {
        public Context()
        {
            ListaVeiculo = new List<Veiculo>();

            ListaVeiculo.Add(new Veiculo() { Id = 1, Carro = "Risus Company", Valor = 7.200, Quantidade = 18, Data = DateTime.Parse("29/01/2019") });
            ListaVeiculo.Add(new Veiculo() { Id = 2, Carro = "Risus Associates", Valor = 9.961, Quantidade = 4,   Data = DateTime.Parse("10/02/2019") });
            ListaVeiculo.Add(new Veiculo() { Id = 3, Carro = "Et Libero Proin Foundation	    ", Valor = 8.710, Quantidade = 17, Data = DateTime.Parse("24/01/2019") });
            ListaVeiculo.Add(new Veiculo(){ Id = 4, Carro = "Cursus Et Ltd", Valor = 9.010, Quantidade =	17,	Data = DateTime.Parse("26/10/2019")});
            ListaVeiculo.Add(new Veiculo(){ Id = 5, Carro = "Odio Etiam Ligula Company", Valor = 5.245, Quantidade =	8,	Data = DateTime.Parse("16/02/2019")});
            ListaVeiculo.Add(new Veiculo(){ Id = 6, Carro = "Eu Nibh Inc.", Valor = 7.922, Quantidade =	9,	Data = DateTime.Parse("27/06/2019")});
            ListaVeiculo.Add(new Veiculo(){ Id = 7, Carro = "Tellus Limited", Valor = 7.294, Quantidade =	7,	Data = DateTime.Parse("26/01/2019")});
            ListaVeiculo.Add(new Veiculo(){ Id = 8, Carro = "Imperdiet PC", Valor = 8.305, Quantidade =	5,	Data = DateTime.Parse("06/09/2019")});
            ListaVeiculo.Add(new Veiculo(){ Id = 9, Carro = "Elit Inc.", Valor = 5.398, Quantidade =	18,	Data = DateTime.Parse("09/06/2019")});
            ListaVeiculo.Add(new Veiculo(){ Id = 10,Carro = "Quam A Limited", Valor = 5.398, Quantidade =	14,	Data = DateTime.Parse("09/09/2019")});
            ListaVeiculo.Add(new Veiculo(){ Id = 11,Carro = "Adipiscing Institute", Valor = 8.133, Quantidade =	4,  Data = DateTime.Parse("24/10/2019")});
            ListaVeiculo.Add(new Veiculo(){ Id = 12,Carro = "Posuere At Velit Ltd", Valor = 5.121, Quantidade =	15,	Data = DateTime.Parse("19/11/2019")});
            ListaVeiculo.Add(new Veiculo(){ Id = 13,Carro = "Nunc In Industries", Valor = 8.902, Quantidade =	2,	Data = DateTime.Parse("21/07/2019")});
            ListaVeiculo.Add(new Veiculo(){ Id = 14,Carro = "Integer Vitae Nibh Corporation", Valor = 6.313, Quantidade =	20,	Data = DateTime.Parse("02/02/2019")});
            ListaVeiculo.Add(new Veiculo(){ Id = 15,Carro = "Tellus Nunc Lectus Company", Valor = 9.650, Quantidade =	2,	Data = DateTime.Parse("20/07/2019")});
            ListaVeiculo.Add(new Veiculo(){ Id = 16,Carro = "Suspendisse LLC", Valor = 5.319, Quantidade =	12,	Data = DateTime.Parse("24/12/2019")});
            ListaVeiculo.Add(new Veiculo(){ Id = 17,Carro = "Mauris Vestibulum Corporation", Valor = 5.790, Quantidade =	5,	Data = DateTime.Parse("14/11/2019")});
            ListaVeiculo.Add(new Veiculo() { Id = 18, Carro = "Sed Nec Corp.", Valor = 8.421, Quantidade = 2, Data = DateTime.Parse("05/05/2019") });
            ListaVeiculo.Add(new Veiculo() { Id = 19, Carro = "Enim Nisl Elementum Inc.", Valor = 5.904, Quantidade = 6, Data = DateTime.Parse("26/06/2019") });
            ListaVeiculo.Add(new Veiculo() { Id = 20, Carro = "Ac Mattis Semper Corporation", Valor = 5.110, Quantidade = 4, Data = DateTime.Parse("14 /01/2019") });
            #region OutrosLista         
            //ListaVeiculo.Add(new Veiculo(){ Id = 21,Carro = Donec Tempus Lorem LLC	        8.576	16	29/03/2019
            //ListaVeiculo.Add(new Veiculo(){ Id = 22,Carro = Tempor Augue Ac Ltd	            9.072	16	09/07/2019
            //ListaVeiculo.Add(new Veiculo(){ Id = 23,Carro = Diam Duis Mi LLC	            8.472	4	23/09/2019
            //ListaVeiculo.Add(new Veiculo(){ Id = 24,Carro = Aliquam Corp.	                6.607	4	28/09/2019
            //ListaVeiculo.Add(new Veiculo(){ Id = 25,Carro = Montes Institute	            6.176	8	19/06/2019
            //ListaVeiculo.Add(new Veiculo(){ Id = 26,Carro = Hendrerit Institute	            8.387	11	17/09/2019
            //ListaVeiculo.Add(new Veiculo(){ Id = 27,Carro = Erat Etiam Vestibulum Corporation	7.584	9	02/06/2019
            //ListaVeiculo.Add(new Veiculo(){ Id = 28,Carro = Adipiscing Ltd	7.887	9	19/03/2019
            //ListaVeiculo.Add(new Veiculo(){ Id = 29,Carro = In Tempus Eu Inc.	5.233	16	20/07/2019
            //ListaVeiculo.Add(new Veiculo(){ Id = 30,Carro = Elit Institute	7.359	11	12/09/2019
            //ListaVeiculo.Add(new Veiculo(){ Id = 31,Carro = Aliquam Erat LLC	8.842	4	14/03/2019
            //ListaVeiculo.Add(new Veiculo(){ Id = 32,Carro = A Feugiat Tellus PC	9.176	4	10/12/2019
            //ListaVeiculo.Add(new Veiculo(){ Id = 33,Carro = Aliquet Incorporated	9.057	8	26/04/2019
            //ListaVeiculo.Add(new Veiculo(){ Id = 34,Carro = Dolor Dolor Tempus Institute	8.433	15	31/10/2019
            //ListaVeiculo.Add(new Veiculo(){ Id = 35,Carro = Risus Odio Auctor PC	8.286	11	29/03/2019
            //ListaVeiculo.Add(new Veiculo(){ Id = 36,Carro = Aliquet Molestie Tellus Corp.	8.779	1	05/07/2019
            //ListaVeiculo.Add(new Veiculo(){ Id = 37,Carro = Ipsum Corp.	5.568	15	10/03/2019
            //ListaVeiculo.Add(new Veiculo(){ Id = 38,Carro = Mi Lacinia Foundation	7.442	20	09/07/2019
            //ListaVeiculo.Add(new Veiculo(){ Id = 39,Carro = Cubilia Curae; Corp.	8.421	7	26/05/2019
            //ListaVeiculo.Add(new Veiculo(){ Id = 40,Carro = Velit Sed Malesuada Associates	9.841	6	07/11/2019
            //ListaVeiculo.Add(new Veiculo(){ Id = 41,Carro = Duis Foundation	9.849	6	08/12/2019
            //ListaVeiculo.Add(new Veiculo(){ Id = 42,Carro = Erat Semper Consulting	6.168	10	10/11/2019
            //ListaVeiculo.Add(new Veiculo(){ Id = 43,Carro = Turpis Inc.	7.758	7	12/08/2019
            //ListaVeiculo.Add(new Veiculo(){ Id = 44,Carro = Aenean Industries	8.770	12	10/09/2019
            //ListaVeiculo.Add(new Veiculo(){ Id = 45,Carro = Nulla Industries	8.884	8	10/11/2019
            //ListaVeiculo.Add(new Veiculo(){ Id = 46,Carro = Semper Egestas Urna Inc.	9.428	11	26/06/2019
            //ListaVeiculo.Add(new Veiculo(){ Id = 47,Carro = Donec Luctus Aliquet Industries	5.928	8	11/07/2019
            //ListaVeiculo.Add(new Veiculo(){ Id = 48,Carro = Cum Sociis Natoque Foundation	7.506	2	21/07/2019
            //ListaVeiculo.Add(new Veiculo(){ Id = 49,Carro = Vitae Sodales Limited	8.912	8	22/06/2019
            //ListaVeiculo.Add(new Veiculo(){ Id = 50,Carro = Tellus Sem Mollis Ltd	9.615	20	30/10/2019
            //ListaVeiculo.Add(new Veiculo(){ Id = 51,Carro = Nulla Tincidunt LLC	5.562	19	22/09/2019
            //ListaVeiculo.Add(new Veiculo(){ Id = 52,Carro = Sed Dictum Institute	9.243	14	26/06/2019
            //ListaVeiculo.Add(new Veiculo(){ Id = 53,Carro = Sed Turpis Company	7.243	14	20/08/2019
            //ListaVeiculo.Add(new Veiculo(){ Id = 54,Carro = Vitae Diam Proin Associates	6.631	2	10/06/2019
            //ListaVeiculo.Add(new Veiculo(){ Id = 55,Carro = Curabitur Inc.	8.090	3	09/02/2019
            //ListaVeiculo.Add(new Veiculo(){ Id = 56,Carro = Suscipit Est Ac LLC	8.567	15	08/03/2019
            //ListaVeiculo.Add(new Veiculo(){ Id = 57,Carro = Neque Morbi Industries	5.171	1	03/10/2019
            //ListaVeiculo.Add(new Veiculo(){ Id = 58,Carro = Non Ltd	5.102	19	14/08/2019
            //ListaVeiculo.Add(new Veiculo(){ Id = 59,Carro = Arcu Vestibulum Ante Institute	6.128	1	08/10/2019
            //ListaVeiculo.Add(new Veiculo(){ Id = 60,Carro = Nulla Foundation	7.636	6	14/04/2019
            //ListaVeiculo.Add(new Veiculo(){ Id = 61,Carro = Quis Massa Mauris LLP	5.053	3	09/10/2019
            //ListaVeiculo.Add(new Veiculo(){ Id = 62,Carro = Ut Incorporated	6.922	17	16/09/2019
            //ListaVeiculo.Add(new Veiculo(){ Id = 63,Carro = Aenean Egestas Corp.	8.142	19	17/11/2019
            //ListaVeiculo.Add(new Veiculo(){ Id = 64,Carro = Fusce Mi Lorem Consulting	8.312	20	19/11/2019
            //ListaVeiculo.Add(new Veiculo(){ Id = 65,Carro = A Sollicitudin Orci PC	5.864	1	20/03/2019
            //ListaVeiculo.Add(new Veiculo(){ Id = 66,Carro = Sociosqu Limited	5.985	12	28/11/2019
            //ListaVeiculo.Add(new Veiculo(){ Id = 67,Carro = Ullamcorper Duis Cursus LLC	5.164	7	22/12/2019
            //ListaVeiculo.Add(new Veiculo(){ Id = 68,Carro = Nibh Lacinia LLC	7.760	10	13/06/2019
            //ListaVeiculo.Add(new Veiculo(){ Id = 69,Carro = Eu Dui Institute	7.695	8	12/12/2019
            //ListaVeiculo.Add(new Veiculo(){ Id = 70,Carro = Fringilla Purus Mauris Consulting	5.845	6	01/03/2019
            //ListaVeiculo.Add(new Veiculo(){ Id = 71,Carro = Donec Tempus Lorem Industries	8.472	19	09/03/2019
            //ListaVeiculo.Add(new Veiculo(){ Id = 72,Carro = Auctor Incorporated	6.795	1	04/10/2019
            //ListaVeiculo.Add(new Veiculo(){ Id = 73,Carro = Enim Etiam Imperdiet Corporation	6.532	13	14/10/2019
            //ListaVeiculo.Add(new Veiculo(){ Id = 74,Carro = Non Cursus Non Industries	9.569	16	25/10/2019
            //ListaVeiculo.Add(new Veiculo(){ Id = 75,Carro = Ut Semper Incorporated	5.760	18	14/01/2019
            //ListaVeiculo.Add(new Veiculo(){ Id = 76,Carro = Sed Malesuada Corporation	6.561	4	06/03/2019
            //ListaVeiculo.Add(new Veiculo(){ Id = 77,Carro = Sed Neque Consulting	7.308	2	31/08/2019
            //ListaVeiculo.Add(new Veiculo(){ Id = 78,Carro = Nisl Arcu PC	7.260	8	19/06/2019
            //ListaVeiculo.Add(new Veiculo(){ Id = 79,Carro = Euismod Est Consulting	6.020	11	27/10/2019
            //ListaVeiculo.Add(new Veiculo(){ Id = 80,Carro = Leo Vivamus Ltd	5.055	8	22/10/2019
            //ListaVeiculo.Add(new Veiculo(){ Id = 81,Carro = Tristique Neque Inc.	9.268	13	25/02/2019
            //ListaVeiculo.Add(new Veiculo(){ Id = 82,Carro = In Lobortis PC	5.539	4	18/12/2019
            //ListaVeiculo.Add(new Veiculo(){ Id = 83,Carro = Nunc Ltd	6.846	2	09/10/2019
            //ListaVeiculo.Add(new Veiculo(){ Id = 84,Carro = Dictum Proin Limited	5.543	12	05/10/2019
            //ListaVeiculo.Add(new Veiculo(){ Id = 85,Carro = Erat Vitae LLP	5.060	7	12/12/2019
            //ListaVeiculo.Add(new Veiculo(){ Id = 86,Carro = Pellentesque Ultricies Dignissim PC	7.971	15	25/10/2019
            //ListaVeiculo.Add(new Veiculo(){ Id = 87,Carro = Phasellus Elit Company	5.350	15	31/10/2019
            //ListaVeiculo.Add(new Veiculo(){ Id = 88,Carro = Luctus Felis Ltd	9.872	13	06/01/2019
            //ListaVeiculo.Add(new Veiculo(){ Id = 89,Carro = Dui Suspendisse PC	6.878	7	06/02/2019
            //ListaVeiculo.Add(new Veiculo(){ Id = 90,Carro = Odio Associates	7.636	18	24/07/2019
            //ListaVeiculo.Add(new Veiculo(){ Id = 91,Carro = Vel Company	7.410	5	16/02/2019
            //ListaVeiculo.Add(new Veiculo(){ Id = 92,Carro = Lobortis Institute	5.110	8	27/05/2019
            //ListaVeiculo.Add(new Veiculo(){ Id = 93,Carro = Scelerisque Company	7.983	19	03/12/2019
            //ListaVeiculo.Add(new Veiculo(){ Id = 94,Carro = Posuere Enim Company	6.968	19	22/04/2019
            //ListaVeiculo.Add(new Veiculo(){ Id = 95,Carro = Sem Ut Corp.	6.504	11	02/02/2019
            //ListaVeiculo.Add(new Veiculo(){ Id = 96,Carro = Dui Fusce Aliquam PC	7.837	2	08/12/2019
            //ListaVeiculo.Add(new Veiculo(){ Id = 97,Carro = Nisl Sem Industries	6.835	5	14/11/2019
            //ListaVeiculo.Add(new Veiculo(){ Id = 98,Carro = Vitae Corp.	7.669	7	09/11/2019
            //ListaVeiculo.Add(new Veiculo(){ Id = 99,Carro = Malesuada Incorporated	5.960	4	26/09/2019
            //ListaVeiculo.Add(new Veiculo(){ Id = 100,Carro = 	Mauris Ltd	8.974	18	16/05/2019
            #endregion


        }
        public List<Veiculo> ListaVeiculo { get; set; }


    }
    
}
