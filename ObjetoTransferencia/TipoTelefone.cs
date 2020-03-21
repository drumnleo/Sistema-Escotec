using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class TipoTelefone
    {
        public int Id_Tipo_Telefone { get; set; }
        public string Descricao { get; set; }
        public DateTime Data_Cadastro { get; set; }
        public DateTime Data_Ultima_Alteracao { get; set; }
        public Usuario Usuario { get; set; }
        public bool Ativo { get; set; }
    }
}
