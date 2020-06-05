using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcessoBandoDados;
using ObjetoTransferencia;

namespace Negocios
{
    public class ProfessorNegocios
    {
        AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();

        public ProfessorMinistraColecao ConsultarPorCurso(int idCurso)
        {
            acessoDados.LimparParametros();
            acessoDados.AdicionarParametros("@ID_CURSO", idCurso);

            ProfessorMinistraColecao professorMinistraColecao = new ProfessorMinistraColecao();

            DataTable dt = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "USP_PROFESSOR_MINISTRA_CONSULTARPORCURSO");

            foreach (DataRow dataRow in dt.Rows)
            {
                ProfessorMinistra professorMinistra = new ProfessorMinistra();

                professorMinistra.Id_Professor_Ministra = Convert.ToInt32(dataRow["ID_PROFESSOR_MINISTRA"]);
                professorMinistra.Data_Cadastro = Convert.ToDateTime(dataRow["DATA_CADASTRO"]);
                professorMinistra.Data_Ultima_Alteracao = Convert.ToDateTime(dataRow["DATA_ULTIMA_ALTERACAO"]);
                professorMinistra.Nome = Convert.ToString(dataRow["NOME"]);

                professorMinistra.Professor = new Professor();
                professorMinistra.Professor.Id_Professor = Convert.ToInt32(dataRow["ID_PROFESSOR"]);

                professorMinistra.Curso = new Curso();
                professorMinistra.Curso.Id_Curso = Convert.ToInt32(dataRow["ID_CURSO"]);
                professorMinistra.Curso.Nome = Convert.ToString(dataRow["CURSO_NOME"]);

                professorMinistra.Professor.Funcionario = new Funcionario();
                professorMinistra.Professor.Funcionario.Pessoa = new Pessoa();

                professorMinistra.Professor.Funcionario.Pessoa.Nome = Convert.ToString(dataRow["NOME"]);
                professorMinistra.Professor.Funcionario.Pessoa.Sobrenome = Convert.ToString(dataRow["SOBRENOME"]);

                professorMinistra.Usuario = new Usuario();
                professorMinistra.Usuario.Id_Usuario = Convert.ToInt32(dataRow["USUARIO_CAD_ALT"]);

                professorMinistraColecao.Add(professorMinistra);
            }

            return professorMinistraColecao;
        }
    }
}
