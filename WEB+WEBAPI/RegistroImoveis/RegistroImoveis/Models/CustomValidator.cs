using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RegistroImoveis.Models
{
    public class CustomValidator : ValidationAttribute
    {
        private string FieldName { get; set; }
        public CustomValidator(string field)
        {
            FieldName = field;
        }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            ContextDb db = new ContextDb();

            if (FieldName == "Nome")
            {
                if (db.Proprietarios.FirstOrDefault(x => x.Nome == value.ToString()) != null)
                {
                    //throw new Exception("Usuário já existente"); }
                    //return base.IsValid(value, validationContext);
                    return new ValidationResult("Usuário já existente");
                }
            }
            if (FieldName == "DataNascimento")
            {
                {
                    if (DateTime.Parse(value.ToString()) >= DateTime.Now.AddYears(-18) ||
                            DateTime.Parse(value.ToString()) <= DateTime.Now.AddYears(-150))
                    {                       
                        return new ValidationResult("Data inválida, Menor de Idade ou Velho demais pra comprar alguma coisa =D");
                    }
                }                
            }
            return ValidationResult.Success;
        }
    }
}