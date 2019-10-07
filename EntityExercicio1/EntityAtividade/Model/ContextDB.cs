using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityAtividade.Model;


namespace EntityAtividade.Model
{
    public class ContextDB : DbContext //DbContext classe pronta que contem todos os processos
                                       //de conexão com o banco de dados listagem das tabelas
    {
        public DbSet<Alunos> ListaDeAlunos { get; set; }
    }
}
