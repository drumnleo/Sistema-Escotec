using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class ProfessorMinistra
    {
        public int Id_Professor_Ministra { get; set; }
        public Professor Professor { get; set; }
        public Curso Curso { get; set; }
        public DateTime Data_Cadastro { get; set; }
        public DateTime Data_Ultima_Alteracao { get; set; }
        public Usuario Usuario { get; set; }
        public bool Ativo { get; set; }

    }
}
