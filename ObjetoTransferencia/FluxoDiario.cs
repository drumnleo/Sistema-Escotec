using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class FluxoDiario
    {
        public int Id_Fluxo_Diario { get; set; }
        public DateTime Data_Fluxo { get; set; }
        public DateTime Hora_Fluxo { get; set; }
        public string Tipo { get; set; }
        public Caixa Caixa { get; set; }
        public ContasPagar ContasPagar { get; set; }
        public decimal Valor { get; set; }
        public decimal Saldo_Inicial { get; set; }
        public decimal Saldo_Final { get; set; }
        public bool Estorno { get; set; }
        public string Obervacao_Estorno { get; set; }
    }
}
