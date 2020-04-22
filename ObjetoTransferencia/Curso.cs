using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class Curso
    {
        public int Id_Curso { get; set; }
        public TipoCurso TipoCurso { get; set; }
        public string Nome { get; set; }
        public Int16 Qtde_Aulas { get; set; }
        public Int16 Qtde_Aulas_Semana { get; set; }
        public Int16 Duracao_Meses { get; set; }
        public short Carga_Horaria { get; set; }
        public Int16 Horas_Por_Aula { get; set; }
        public bool Apostila { get; set; }
        public decimal Valor_Total { get; set; }
        public Int16 Qtde_Parcelas { get; set; }
        public DateTime Data_Cadastro { get; set; }
        public DateTime Data_Ultima_Alteracao { get; set; }
        public Usuario Usuario { get; set; }
        public bool Ativo { get; set; }
    }
}
