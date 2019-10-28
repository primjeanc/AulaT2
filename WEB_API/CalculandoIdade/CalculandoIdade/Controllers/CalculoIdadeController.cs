using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace CalculandoIdade.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class CalculoIdadeController : ApiController
    {
        /// <summary>
        /// Retorna nome da aplicacao e o que ela faz #CleanCodeNot
        /// </summary>
        /// <returns></returns>    

            
        //}
        public string Get(double peso, double altura, string nome)
        {
            //string retorno = "Nada ocorreu";
            var imc = peso / (altura * altura);
            return $"{nome}, baseado na sua altura {altura}m e peso {peso}Kg seu IMC é de: {Math.Round(imc,1)}";

        }
    }
}
