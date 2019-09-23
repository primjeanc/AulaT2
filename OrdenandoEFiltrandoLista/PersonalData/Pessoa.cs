using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalData
{
    class Pessoa
    {
        public string Nome { get; set; }
        public int Id { get; set; }
        public double Carteira { get; set; }
        public DateTime DataNascimento { get; set; }


        // a partir dessa linha seria outra forma de resolver
        private List<Pessoa> ListaDePessoa { get; set; }
        public Pessoa()
        {
            /* 
            ListaDePessoa.Add1	Spears	07/11/2004	 846.96
            ListaDePessoa.Add2	Swanson	20/06/2003	 233.09
            ListaDePessoa.Add3	Gay	03/12/2001	 911.92
            ListaDePessoa.Add4	Gregory	02/01/2000	 469.01
            ListaDePessoa.Add5	Olson	18/07/2001	 261.90
            ListaDePessoa.Add6	Garza	01/04/2000	 360.41
            ListaDePessoa.Add7	Sweet	12/03/2003	 312.76
            ListaDePessoa.Add8	Cline	26/03/2002	 484.51
            ListaDePessoa.Add9	Oliver	05/07/2004	 513.76
            ListaDePessoa.Add10	Vang	10/07/2000	 271.05
            ListaDePessoa.Add11	Maddox	29/05/2004	 783.97
            ListaDePessoa.Add12	Garrett	03/06/2006	 154.11
            ListaDePessoa.Add13	Mcintosh	06/07/2006	 902.80
            ListaDePessoa.Add14	Yang	29/04/2005	 550.48
            ListaDePessoa.Add15	Hendricks	05/09/2003	 410.56
            ListaDePessoa.Add16	Cain	12/01/2002	 221.13
            ListaDePessoa.Add17	Blackburn	10/05/2000	 135.67
            ListaDePessoa.Add18	Howe	27/09/2005	 360.14
            ListaDePessoa.Add19	Pratt	18/09/2000	 991.83
            ListaDePessoa.Add20	Sherman	20/02/2003	 667.00*/
        }
        public List<Pessoa> RetornaListaDeMaiorDeIdade()
        {
            return ListaDePessoa.FindAll(x=> DateTime.Now.Year - )
        }


    }
}
