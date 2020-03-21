using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
   public class Orcamento
    {
        public int Id_Orcamento { get; set; }
        public Pessoa Pessoa { get; set; }
        public Turma turma1 { get; set; }
    }
}
