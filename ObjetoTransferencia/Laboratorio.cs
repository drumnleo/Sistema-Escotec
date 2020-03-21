using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class Laboratorio
    {
        public int Id_Laboratorio { get; set; }
        public TipoLaboratorio TipoLaboratorio { get; set; }
        public string Nome { get; set; }
        public short Numero_Sala { get; set; }
        public short Capacidade { get; set; }
        public DateTime Data_Cadastro { get; set; }
        public DateTime Data_Ultima_Alteracao { get; set; }
        public Usuario  Usuario { get; set; }
        public bool Ativo { get; set; }
    }
}
