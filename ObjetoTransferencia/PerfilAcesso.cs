using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class PerfilAcesso
    {
        public int Id_Perfil { get; set; }
        public string Descricao { get; set; }
        public char  Pessoa { get; set; }
        public char Usuario { get; set; }
        public char Funcionario { get; set; }
        public char GrupoUsuario { get; set; }
        public char Curso { get; set; }
        public char Endereco { get; set; }
        public char Laboratorio { get; set; }
        public char Marketing { get; set; }
        public char Orcamento { get; set; }
        public char Professor { get; set; }
        public char ProfessorMinistra { get; set; }
        public char PromocaoValor { get; set; }
        public char TipoApostila { get; set; }
        public char TipoAtendimento { get; set; }
        public char TipoCurso { get; set; }
        public char TipoLaboratorio { get; set; }
        public char Turma { get; set; }
        public char Caixa { get; set; }
        public DateTime  Data_Cadastro { get; set; }
        public DateTime Data_Ultima_Alteracao { get; set; }
        public int Usuario_Cad_Alt { get; set; }
        public bool Ativo { get; set; }

    }
}
