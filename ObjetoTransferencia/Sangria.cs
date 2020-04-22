using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class Sangria
    {
        public int Id_Sangria { get; set; }
        public Caixa Caixa { get; set; }
        public Decimal Valor { get; set; }
        public DateTime Data_Sangria { get; set; }
        public DateTime Hora_Sangria { get; set; }
        public DateTime Data_Ultima_Alteracao { get; set; }
        public Usuario Usuario { get; set; }
    }
}
