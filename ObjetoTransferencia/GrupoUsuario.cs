using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class GrupoUsuario
    {
        public int Id_Grupo { get; set; }
        public PerfilAcesso PerfilAcesso { get; set; }
        public string Nome { get; set; }
        public DateTime Data_Cadastro { get; set; }
        public DateTime Data_Ultima_Alteracao { get; set; }
        public Usuario Usuario { get; set; }
        public bool Ativo { get; set; }

    }
}
