using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class TipoAtendimento
    {
        public int Id_Tipo_Atendimento { get; set; }
        public string Descricao { get; set; }
        public DateTime Data_cadastro { get; set; }
        public DateTime Data_Ultima_Alt { get; set; }
        public Usuario Usuario { get; set; }
        public bool Ativo { get; set; }
    }
}
