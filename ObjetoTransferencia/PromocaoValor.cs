using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class PromocaoValor
    {
        public int Id_Promocao_Valor { get; set; }
        public string Nome_Promocao { get; set; }
        public DateTime Validade { get; set; }
        public bool Entrada { get; set; }
        public Int16 Desconto_Entrada { get; set; }
        public decimal Valor_Entrada { get; set; }
        public Int16 Desconto_Demais { get; set; }
        public DateTime Data_Cadastro { get; set; }
        public DateTime Data_Ultima_Alteracao { get; set; }
        public Usuario Usuario { get; set; }
        public bool Ativo { get; set; }
    }
}
