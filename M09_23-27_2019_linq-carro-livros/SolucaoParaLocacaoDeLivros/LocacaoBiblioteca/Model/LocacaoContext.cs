﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca.Model
{
    public class LocacaoContext: DbContext
    {      
        public DbSet<Usuario> Usuarios { get; set; }//tabela Usuarios
        public DbSet<Livro> Livros { get; set; }//tabela Livros
    }


}


