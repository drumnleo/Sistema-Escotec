using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
   public class TipoApostila
    {
        public int Id_Tipo_Apostila { get; set; }
        public TipoCurso TipoCurso { get; set; }
        public string Tipo { get; set; }
        public DateTime Data_Cadastro { get; set; }
        public DateTime Data_Ultima_Alteracao { get; set; }
        public Usuario Usuario { get; set; }
        public bool Ativo { get; set; }

    }
}
