
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class Caixa
    {
        public int Id_Caixa { get; set; }
        public DateTime Data_Caixa { get; set; }
        public Usuario Func_Abre { get; set; }
        public Usuario Func_Recebe { get; set; }
        public  Usuario Func_Fechamento { get; set; }
        public decimal Valor_Abertura { get; set; }
        public decimal Valor_Sangria { get; set; }
        public Decimal Saldo { get; set; }
        public string Situacao { get; set; }
        public DateTime Data_Cadastro { get; set; }
        public DateTime Data_Ultima_Alteracao { get; set; }
        public DateTime Data_Fechamento { get; set; }


    }
}
