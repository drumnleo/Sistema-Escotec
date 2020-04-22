using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class Turma
    {
        public int Id_Turma { get; set; }
        public Curso Curso { get; set; }
        public Laboratorio Laboratorio { get; set; }
        public ProfessorMinistra ProfessorMinistra { get; set; }
        public string Nome_Turma { get; set; }
        public DateTime Data_Inicio { get; set; }
        public DateTime Data_Fim { get; set; }
        public DateTime Hora_Inicio { get; set; }
        public DateTime Hora_Fim { get; set; }
        public Int16 Qtde_Feriado { get; set; }
        public Int16 Vagas_Disponiveis { get; set; }
        public bool Segunda_Aula { get; set; }
        public bool Terca_Aula { get; set; }
        public bool Quarta_Aula { get; set; }
        public bool Quinta_Aula { get; set; }
        public bool Sexta_Aula { get; set; }
        public bool Sabado_Aula { get; set; }
        public bool Domingo_Aula { get; set; }
        public DateTime Data_Cadastro { get; set; }
        public DateTime Data_Ultima_Alteracao { get; set; }
        public Usuario Usuario { get; set; }
        public bool Ativo { get; set; }



    }
}
