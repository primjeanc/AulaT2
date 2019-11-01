﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMigration.Model
{
    public class ControleUsuario
    {
        public bool Ativo { get; set; }
        public int UsuarioCriacao { get; set; } = 0;
        public int UsuarioAlteracao { get; set; } = 0;
        public DateTime DataCriacao { get; set; } = DateTime.Now;
        public DateTime DataAlteracao { get; set; } = DateTime.Now;

    }
}