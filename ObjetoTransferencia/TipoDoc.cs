using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class TipoDoc
    {
        public int Id_TipoDoc { get; set; }
        public string Descricao { get; set; }
        public DateTime Data_Cadastro { get; set; }
        public DateTime Data_ultima_alteracao { get; set; }
    }
}
