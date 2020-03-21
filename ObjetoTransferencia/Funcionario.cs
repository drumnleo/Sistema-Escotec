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
        public DateTime Data_Cadastro { get; set; }
        public DateTime Data_Ultima_Alteracao { get; set; }
        public Usuario Usuario { get; set; }
    }
}
