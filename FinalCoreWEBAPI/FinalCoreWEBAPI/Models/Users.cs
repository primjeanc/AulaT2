using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FinalCoreWEBAPI.Models
{
    public partial class Users
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
    }
}
