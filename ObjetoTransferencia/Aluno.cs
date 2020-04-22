﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class Aluno
    {
        public int Id_Aluno { get; set; }
        public Pessoa Pessoa { get; set; }
        public DateTime Data_Cadastro { get; set; }
        public DateTime Data_Ultimo_Cadastro { get; set; }
        public Usuario Usuario { get; set; }
        public bool Ativo { get; set; }
    }
}
