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
        public Turma Turma1 { get; set; }
        public Turma Turma2 { get; set; }
        public Turma Turma3 { get; set; }
        public Turma Turma4 { get; set; }
        public PromocaoValor PromocaoValor { get; set; }
        public DateTime Data_Cadastro { get; set; }
    }
}
