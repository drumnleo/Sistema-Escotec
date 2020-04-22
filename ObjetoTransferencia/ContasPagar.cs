using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class ContasPagar
    {
        public int Id_Conta_Pagar { get; set; }
        public TipoConta TipoConta { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public Int16 Numero_Parcela { get; set; }
        public Int16 Total_Parcelas { get; set; }
        public decimal Valor { get; set; }
        public DateTime Vencimento { get; set; }
        public Int16 Desconto_Antecipado { get; set; }
        public string Situacao_Pg { get; set; }
        public DateTime Data_Cadastro { get; set; }
        public DateTime Data_Ultimo_Cadastro { get; set; }
        public Usuario Usuario { get; set; }

    }
}
