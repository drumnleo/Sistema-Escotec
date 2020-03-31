using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class Funcionario
    {
        public int Id_Funcionario { get; set; }
        public int Id_Pessoa { get; set; }
        public DateTime Data_Admissao { get; set; }
        public DateTime Data_Demissao { get; set; }
        public DateTime Hora_Entrada { get; set; }
        public DateTime Hora_Saida { get; set; }
        public byte Num_CTPS { get; set; }
        public byte Serie_CTPS { get; set; }
        public byte Num_NIS { get; set; }
        public DateTime Data_Cadastro { get; set; }
        public DateTime Data_Ultima_Alteracao { get; set; }
        public int Usuario_Cad_Alt { get; set; }
    }
}
