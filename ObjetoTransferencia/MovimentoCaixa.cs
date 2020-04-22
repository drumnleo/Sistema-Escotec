using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class MovimentoCaixa
    {
        public int Id_Mov_Caixa { get; set; }
        public Caixa Caixa { get; set; }
        public TipoMovimentoCaixa TipoMovimentoCaixa { get; set; }
        public ContasReceber ContasReceber { get; set; }
        public string Saida_Entrada { get; set; }
        public decimal Valor { get; set; }
        public short Desconto { get; set; }
        public decimal Valor_Decimal { get; set; }
        public DateTime Data_Movimento { get; set; }
        public Usuario Usuario_Aut_Estorno { get; set; }
        public Usuario Usuario_Aut_Desc { get; set; }
        public Usuario Usuario { get; set; }
    }
}
