using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
   public class TipoCurso
    {
        public int Id_Tipo_Curso { get; set; }
        public Laboratorio Laboratorio { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public short Vagas { get; set; }
        public DateTime Data_Cadastro { get; set; }
        public DateTime Data_Ultima_Alteracao { get; set; }
        public Usuario Usuario { get; set; }
        public bool Ativo { get; set; }
    }
}
