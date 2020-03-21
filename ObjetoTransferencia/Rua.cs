using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
   public class Rua
    {
        public int Id_Cep { get; set; }
        public Estado Estado { get; set; }
        public Cidade Cidade { get; set; }
        public string Nome_Rua { get; set; }
        public string Bairro { get; set; }
        public bool Ativo { get; set; }
    }
}
