using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
   public class Marketing_Atendimento
    {
        public int Id_Marketing_Atendimento { get; set; }
        public Marketing Marketing { get; set; }
        public Orcamento Orcamento  { get; set; }
        public string OBS { get; set; }
        public DateTime Data_Cadastro { get; set; }
        public DateTime Data_Ultima_Alteracao { get; set; }
        public Usuario Usuario { get; set; }
        public bool Ativo { get; set; }

    }
}
