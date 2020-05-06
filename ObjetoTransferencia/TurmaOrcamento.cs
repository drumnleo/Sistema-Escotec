using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class TurmaOrcamento
    {
        public Orcamento Orcamento { get; set; }
        public Turma Turma { get; set; }
        public PromocaoValor PromocaoValor { get; set; }
        public Int16 Qtde_Parcelas { get; set; }
        public decimal Valor_Entrada_Turma { get; set; }
        public decimal Valor_Parcela_Demais { get; set; }
        public DateTime Data_Cadastro { get; set; }
        public DateTime Data_Ultima_Alteracao { get; set; }
        public Usuario Usuario { get; set; }
    }
}
