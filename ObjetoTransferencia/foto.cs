﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
   public class Foto
    {
        public int Id_Foto { get; set; }
        public Pessoa Pessoa { get; set; }
        public Usuario Usuario { get; set; }
        public Image Arquivo_Foto { get; set; }
        public DateTime Data_Cadastro { get; set; }
        public DateTime Data_Ultima_Alteracao { get; set; }
        public bool Ativo { get; set; }

    }
}
