using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
   public class Orcamento
    {
        
        public int Id_Orcamento { get; set; }
        public Atendimento Atendimento { get; set; }
        public DateTime Validade_Orcamento { get; set; }
        public Boolean Aprovado { get; set; }
        public DateTime Data_Cadastro { get; set; }
        public DateTime Data_Ultima_Alteracao { get; set; }
        public Usuario UsuarioGeraOrcamento { get; set; }
        public Usuario Usuario_Cad_Alt { get; set; }
        public Usuario Aprovado_Usuario { get; set; }
        public string Comentario_Aprovacao { get; set; }
        public bool Ativo { get; set; }

    }
}
