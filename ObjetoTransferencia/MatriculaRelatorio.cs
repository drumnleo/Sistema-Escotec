using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class MatriculaRelatorio
    {
        public int Id_Matricula { get; set; }
        public int Id_Aluno { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Curso { get; set; }
        public Int16 Qtde_Parcela { get; set; }
        public int Usuario { get; set; }
        public decimal Total { get; set; }
    }
}
