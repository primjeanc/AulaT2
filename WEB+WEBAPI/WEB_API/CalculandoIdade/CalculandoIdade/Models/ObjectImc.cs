﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalculandoIdade.Models
{
    public class ObjectImc
    {
        public double ImcValue { get; set; } = 0;
        public double Peso { get; set; } = 0;
        public double Altura { get; set; } = 0;
        public string Nome { get; set; } = string.Empty;
    }
}