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
        public Pessoa  Pessoa { get; set; }
        public Usuario Usuario { get; set; }
        public Funcionario Funcionario { get; set; }
        public GrupoUsuario GrupoUsuario { get; set; }
        public Curso Curso { get; set; }
        public Endereco Endereco { get; set; }
        public Laboratorio Laboratorio { get; set; }
        public Marketing Marketing { get; set; }
        public Orcamento Orcamento { get; set; }
        public Professor Professor { get; set; }
        public ProfessorMinistra ProfessorMinistra { get; set; }
        public PromocaoValor PromocaoValor { get; set; }
        public TipoApostila TipoApostila { get; set; }
        public TipoAtendimento TipoAtendimento { get; set; }
        public TipoCurso TipoCurso { get; set; }
        public TipoLaboratorio  TipoLaboratorio { get; set; }
        public Turma Turma { get; set; }
        public DateTime  Data_Cadastro { get; set; }
        public DateTime Data_Ultima_Alteracao { get; set; }
        public int Usuario_Cad_Alt { get; set; }
        public bool Ativo { get; set; }

    }
}
