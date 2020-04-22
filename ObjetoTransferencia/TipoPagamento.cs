using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class TipoPagamento
    {
        public int Id_Tipo_Pagamento { get; set; }
        public string Descricao { get; set; }
        public DateTime Data_Cadastro { get; set; }
        public DateTime Data_Ultimo_Cadastro { get; set; }
        public Usuario Usuario { get; set; }
    }
}
