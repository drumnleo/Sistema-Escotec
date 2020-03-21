using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class PerfilMenu
    {
        public int Id_Perfil { get; set; }
        public  string Nome  { get; set; }
        public bool Btn_Teste { get; set; }
        public bool Btn_Cadastrar { get; set; }
        public bool Btn_Excluir { get; set; }
        public DateTime Data_Cadastro { get; set; }
        public DateTime Data_Ultima_Alteracao { get; set; }
        public int Usuario_Cad_Alt { get; set; }
        public Usuario Usuario { get; set; }
        public bool Ativo { get; set; }


    }
}
