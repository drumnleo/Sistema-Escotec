using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class Telefone
    {
        public int Id_Telefone { get; set; }
        public TipoTelefone TipoTelefone { get; set; }
        public Int16 DDD { get; set; }
        public string Num_Telefone { get; set; }
        public Int16 Ramal { get; set; }
        public DateTime Data_Cadastro { get; set; }
        public DateTime Data_Ultima_Alteracao { get; set; }
        public Usuario Usuario { get; set; }
    }
}
