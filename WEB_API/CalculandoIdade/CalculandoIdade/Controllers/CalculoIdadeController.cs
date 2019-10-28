using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using CalculandoIdade.Models;

namespace CalculandoIdade.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class CalculoIdadeController : ApiController
    {
        /// <summary>
        /// Retorna nome da aplicacao e o que ela faz #CleanCodeNot
        /// </summary>
        /// <returns></returns>    
        List<ObjectImc> listaDeObjetos = new List<ObjectImc>()
        {
        new ObjectImc() { Nome = "Ana"},
        new ObjectImc() { Nome = "Breno" },
        new ObjectImc() { Nome = "Carbunkle" }
        };    
            
        public List<ObjectImc> Get()
        {
            return listaDeObjetos;
        }
        
        public string Get(double peso, double altura, string nome)
        {
            
            var imc = peso / (altura * altura);
            return $"{nome}, baseado na sua altura {altura}m e peso {peso}Kg seu IMC é de: {Math.Round(imc, 1)}";

        }
        public ObjectImc Post(ObjectImc values)
        {
            ObjectImc imcCalc = values;
            imcCalc.ImcValue = imcCalc.Peso / (imcCalc.Altura * imcCalc.Altura);
            listaDeObjetos.Add(imcCalc);
            return imcCalc;
            //return $"{imcCalc.Nome}, baseado na sua altura {imcCalc.Altura}m e peso {imcCalc.Peso}Kg seu IMC é de: {Math.Round(values.ImcValue, 1)}";

        }
    }
}
