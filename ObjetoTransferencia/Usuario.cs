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
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime Data_Admissao { get; set; }
        public string Nome_Usuario { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
    }
}
