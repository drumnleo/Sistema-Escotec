using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class Matricula
    {
        public int Id_Matricula { get; set; }
        public Aluno Aluno { get; set; }
        public Turma Turma { get; set; }
        public PromocaoValor PromocaoValor { get; set; }
        public DateTime Data_Cadastro { get; set; }
        public DateTime Data_Ultimo_Cadastro { get; set; }
        public Usuario Usuario { get; set; }
        public bool Ativo { get; set; }
        public string Situacao { get; set; }
    }
}
