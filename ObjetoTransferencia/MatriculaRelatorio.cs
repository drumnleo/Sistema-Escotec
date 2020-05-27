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
        public string NomeAluno { get; set; }
        public string SobrenomeAluno { get; set; }
        public string Curso { get; set; }
        public int Usuario { get; set; }
        public decimal Total { get; set; }
        public string Nome_Profissao { get; set; }
        public string CPFAluno  { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Nome_Rua { get; set; }
        public string Bairro { get; set; }
        public Int16 Qtde_Parcelas { get; set; }
        public Int16 Carga_Horaria { get; set; }
        public decimal Valor_Entrada_Turma { get; set; }
        public string DocAluno { get; set; }
        public DateTime Data_Fim { get; set; }
        public DateTime Hora_Inicio { get; set; }
        public string NomeFuncionario { get; set; }
        public string SobrenomeFuncionario { get; set; }
        public decimal Valor_Parcela_Demais { get; set; }


    }
}
