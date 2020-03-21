using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class Cidade
    {
        public int Id_Cidade { get; set; }
        public Estado Estado { get; set; }
        public string Nome_Cidade { get; set; }
        public bool Ativo { get; set; }

    }
}
