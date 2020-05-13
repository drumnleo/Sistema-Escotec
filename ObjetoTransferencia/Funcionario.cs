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
        public Pessoa Pessoa { get; set; }
        public DateTime Data_Admissao { get; set; }
        public DateTime Data_Demissao { get; set; }
        public TimeSpan Hora_Entrada { get; set; }
        public TimeSpan Hora_Saida { get; set; }
        public int Num_CTPS { get; set; }
        public int Serie_CTPS { get; set; }
        public int Num_NIS { get; set; }
        public DateTime Data_Cadastro { get; set; }
        public DateTime Data_Ultima_Alteracao { get; set; }
        public Usuario Usuario_Cad_Alt { get; set; }
    }
}
