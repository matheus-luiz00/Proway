﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridViewExample.Model
{
    public class Carros
    {
        public string Modelo { get; set; }

        public DateTime Ano { get; set; }

        public int Marca { get; set; }
        public bool Ativo { get; set; } = true;
        public int UsuInc { get; set; } = 1;
        public int UsuAlt { get; set; } = 1;
        public DateTime DatInc { get; set; } = DateTime.Now;
        public DateTime DatAlt { get; set; } = DateTime.Now;
    }
}
