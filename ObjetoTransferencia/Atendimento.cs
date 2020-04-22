using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class Atendimento
    {
        public int Id_Atendimento { get; set; }
        public TipoAtendimento TipoAtendimento { get; set; }
        public Pessoa Pessoa { get; set; }
        public Marketing Marketing { get; set; }
        public string Receptivo { get; set; }
        public string Observacao { get; set; }
        public DateTime Data_Cadastro { get; set; }
        public DateTime Data_Ultima_Alteracao { get; set; }
        public Usuario Usuario { get; set; }
        public bool Ativo { get; set; }
    }
}
