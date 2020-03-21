using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class Usuario
    {
        public int Id_Usuario { get; set; }
        public GrupoTipo grupoTipo { get; set; }
        public Pessoa Pessoa { get; set; }
        public Funcionario funcionario { get; set; }
        public string Nome_Usuario { get; set; }
        public string Senha { get; set; }
        public DateTime Data_Cadastro { get; set; }
        public DateTime Data_Ultima_Alteracao { get; set; }
        public Usuario Usuario_cad_alt { get; set; }
    }
}
