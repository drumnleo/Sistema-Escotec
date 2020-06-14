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

        public string InserirProfessor(Professor professor)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("ID_FUNCIONARIO", professor.Funcionario.Id_Funcionario);
                acessoDados.AdicionarParametros("ID_USUARIO", professor.Usuario.Id_Usuario);

                string idProfessor = acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "USP_PROFESSOR_INSERIR").ToString();

                return idProfessor;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string InserirProfessorMinistra(ProfessorMinistra ministra)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("ID_PROFESSOR", ministra.Professor.Id_Professor);
                acessoDados.AdicionarParametros("ID_CURSO", ministra.Curso.Id_Curso);
                acessoDados.AdicionarParametros("ID_USUARIO", ministra.Usuario.Id_Usuario);

                string idMinistra = acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "USP_PROFESSOR_MINISTRA_INSERIR").ToString();

                return idMinistra;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string ExcluirProfessor(Professor professor)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@ID_PROFESSOR", professor.Id_Professor);
                acessoDados.AdicionarParametros("@ID_USUARIO", professor.Usuario.Id_Usuario);

                string idProfessor = acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "USP_PROFESSOR_EXCLUIR").ToString();

                return idProfessor;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string ExcluirProfessorMinistra(ProfessorMinistra ministra)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@ID_PROFESSOR_MINISTRA", ministra.Id_Professor_Ministra);
                acessoDados.AdicionarParametros("@ID_USUARIO", ministra.Usuario.Id_Usuario);

                string idProfessor = acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "USP_PROFESSOR_MINISTRA_EXCLUIR").ToString();

                return idProfessor;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string ExcluirProfessorMinistraAtualizar(ProfessorMinistra ministra)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@ID_PROFESSOR_MINISTRA", ministra.Id_Professor_Ministra);
                acessoDados.AdicionarParametros("@ID_PROFESSOR", ministra.Professor.Id_Professor);
                acessoDados.AdicionarParametros("@ID_CURSO", ministra.Curso.Id_Curso);
                acessoDados.AdicionarParametros("@ID_USUARIO", ministra.Usuario.Id_Usuario);

                string idProfessor = acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "USP_PROFESSOR_MINISTRA_ATUALIZARPORID").ToString();

                return idProfessor;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public ProfessorMinistraColecao ConsultarMInistraPorCurso(int idCurso)
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
                professorMinistra.Professor.Funcionario.Id_Funcionario = Convert.ToInt32(dataRow["ID_FUNCIONARIO"]);
                professorMinistra.Professor.Funcionario.Pessoa = new Pessoa();

                professorMinistra.Professor.Funcionario.Pessoa.Nome = Convert.ToString(dataRow["NOME"]);
                professorMinistra.Professor.Funcionario.Pessoa.Sobrenome = Convert.ToString(dataRow["SOBRENOME"]);

                professorMinistra.Usuario = new Usuario();
                professorMinistra.Usuario.Id_Usuario = Convert.ToInt32(dataRow["USUARIO_CAD_ALT"]);

                professorMinistraColecao.Add(professorMinistra);
            }

            return professorMinistraColecao;
        }

        public ProfessorMinistraColecao ConsultarMInistraPorCursoNome(string curso)
        {
            acessoDados.LimparParametros();
            acessoDados.AdicionarParametros("@NOME_CURSO", curso);

            ProfessorMinistraColecao professorMinistraColecao = new ProfessorMinistraColecao();

            DataTable dt = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "USP_PROFESSOR_MINISTRA_CONSULTARPORCURSONOME");

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
                professorMinistra.Professor.Funcionario.Id_Funcionario = Convert.ToInt32(dataRow["ID_FUNCIONARIO"]);
                professorMinistra.Professor.Funcionario.Pessoa = new Pessoa();

                professorMinistra.Professor.Funcionario.Pessoa.Nome = Convert.ToString(dataRow["NOME"]);
                professorMinistra.Professor.Funcionario.Pessoa.Sobrenome = Convert.ToString(dataRow["SOBRENOME"]);

                professorMinistra.Usuario = new Usuario();
                professorMinistra.Usuario.Id_Usuario = Convert.ToInt32(dataRow["USUARIO_CAD_ALT"]);

                professorMinistraColecao.Add(professorMinistra);
            }

            return professorMinistraColecao;
        }

        public ProfessorMinistraColecao ConsultarMinistraPorId(int id)
        {
            acessoDados.LimparParametros();
            acessoDados.AdicionarParametros("@ID", id);

            ProfessorMinistraColecao professorMinistraColecao = new ProfessorMinistraColecao();

            DataTable dt = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "USP_PROFESSOR_MINISTRA_CONSULTARPORID");

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
                professorMinistra.Professor.Funcionario.Id_Funcionario = Convert.ToInt32(dataRow["ID_FUNCIONARIO"]);
                professorMinistra.Professor.Funcionario.Pessoa = new Pessoa();

                professorMinistra.Professor.Funcionario.Pessoa.Nome = Convert.ToString(dataRow["NOME"]);
                professorMinistra.Professor.Funcionario.Pessoa.Sobrenome = Convert.ToString(dataRow["SOBRENOME"]);

                professorMinistra.Usuario = new Usuario();
                professorMinistra.Usuario.Id_Usuario = Convert.ToInt32(dataRow["USUARIO_CAD_ALT"]);

                professorMinistraColecao.Add(professorMinistra);
            }

            return professorMinistraColecao;
        }

        public ProfessorMinistraColecao ConsultarMinistraPorIdFuncionario(int id)
        {
            acessoDados.LimparParametros();
            acessoDados.AdicionarParametros("@ID", id);

            ProfessorMinistraColecao professorMinistraColecao = new ProfessorMinistraColecao();

            DataTable dt = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "USP_PROFESSOR_MINISTRA_CONSULTAPORIDFUNCIONARIO");

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
                professorMinistra.Professor.Funcionario.Id_Funcionario = Convert.ToInt32(dataRow["ID_FUNCIONARIO"]);
                professorMinistra.Professor.Funcionario.Pessoa = new Pessoa();

                professorMinistra.Professor.Funcionario.Pessoa.Nome = Convert.ToString(dataRow["NOME"]);
                professorMinistra.Professor.Funcionario.Pessoa.Sobrenome = Convert.ToString(dataRow["SOBRENOME"]);

                professorMinistra.Usuario = new Usuario();
                professorMinistra.Usuario.Id_Usuario = Convert.ToInt32(dataRow["USUARIO_CAD_ALT"]);

                professorMinistraColecao.Add(professorMinistra);
            }

            return professorMinistraColecao;
        }

        public ProfessorColecao ConsultaPorNome(string nome)
        {
            acessoDados.LimparParametros();
            acessoDados.AdicionarParametros("@NOME", nome);

            ProfessorColecao professorColecao = new ProfessorColecao();
            DataTable dt = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "USP_PROFESSOR_CONSULTARPORNOME");

            foreach (DataRow dataRow in dt.Rows)
            {
                Professor professor = new Professor();
                professor.Id_Professor = Convert.ToInt32(dataRow["ID_PROFESSOR"]);
                professor.Data_Cadastro = Convert.ToDateTime(dataRow["DATA_CADASTRO"]);
                professor.Data_Ultima_Alteracao = Convert.ToDateTime(dataRow["DATA_ULTIMA_ALTERACAO"]);
                professor.Ativo = Convert.ToBoolean(dataRow["ATIVO"]);

                Funcionario funcionario = new Funcionario();
                funcionario.Id_Funcionario = Convert.ToInt32(dataRow["ID_FUNCIONARIO"]);
                funcionario.Data_Admissao = Convert.ToDateTime(dataRow["DATA_ADMISSAO"]);
                funcionario.Hora_Entrada = (TimeSpan)(dataRow["HORA_ENTRADA"]);
                funcionario.Hora_Saida = (TimeSpan)(dataRow["HORA_SAIDA"]);
                professor.Funcionario = funcionario;

                Pessoa pessoa = new Pessoa();
                pessoa.Nome = Convert.ToString(dataRow["NOME"]);
                pessoa.Sobrenome = Convert.ToString(dataRow["SOBRENOME"]);
                professor.Funcionario.Pessoa = pessoa;

                professorColecao.Add(professor);
            }

            return professorColecao;
        }

        public ProfessorColecao ConsultaPorId(int id)
        {
            acessoDados.LimparParametros();
            acessoDados.AdicionarParametros("@ID", id);

            ProfessorColecao professorColecao = new ProfessorColecao();
            DataTable dt = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "USP_PROFESSOR_CONSULTARPORID");

            foreach (DataRow dataRow in dt.Rows)
            {
                Professor professor = new Professor();
                professor.Id_Professor = Convert.ToInt32(dataRow["ID_PROFESSOR"]);
                professor.Data_Cadastro = Convert.ToDateTime(dataRow["DATA_CADASTRO"]);
                professor.Data_Ultima_Alteracao = Convert.ToDateTime(dataRow["DATA_ULTIMA_ALTERACAO"]);
                professor.Ativo = Convert.ToBoolean(dataRow["ATIVO"]);

                Funcionario funcionario = new Funcionario();
                funcionario.Id_Funcionario = Convert.ToInt32(dataRow["ID_FUNCIONARIO"]);
                funcionario.Data_Admissao = Convert.ToDateTime(dataRow["DATA_ADMISSAO"]);
                funcionario.Hora_Entrada = (TimeSpan)(dataRow["HORA_ENTRADA"]);
                funcionario.Hora_Saida = (TimeSpan)(dataRow["HORA_SAIDA"]);
                professor.Funcionario = funcionario;

                Pessoa pessoa = new Pessoa();
                pessoa.Nome = Convert.ToString(dataRow["NOME"]);
                pessoa.Sobrenome = Convert.ToString(dataRow["SOBRENOME"]);
                professor.Funcionario.Pessoa = pessoa;

                professorColecao.Add(professor);
            }

            return professorColecao;
        }

        public ProfessorColecao ConsultaPorIdFuncionario(int id)
        {
            acessoDados.LimparParametros();
            acessoDados.AdicionarParametros("@ID", id);

            ProfessorColecao professorColecao = new ProfessorColecao();
            DataTable dt = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "USP_PROFESSOR_CONSULTARPORIDFUNCIONARIO");

            foreach (DataRow dataRow in dt.Rows)
            {
                Professor professor = new Professor();
                professor.Id_Professor = Convert.ToInt32(dataRow["ID_PROFESSOR"]);
                professor.Data_Cadastro = Convert.ToDateTime(dataRow["DATA_CADASTRO"]);
                professor.Data_Ultima_Alteracao = Convert.ToDateTime(dataRow["DATA_ULTIMA_ALTERACAO"]);
                professor.Ativo = Convert.ToBoolean(dataRow["ATIVO"]);

                Funcionario funcionario = new Funcionario();
                funcionario.Id_Funcionario = Convert.ToInt32(dataRow["ID_FUNCIONARIO"]);
                funcionario.Data_Admissao = Convert.ToDateTime(dataRow["DATA_ADMISSAO"]);
                funcionario.Hora_Entrada = (TimeSpan)(dataRow["HORA_ENTRADA"]);
                funcionario.Hora_Saida = (TimeSpan)(dataRow["HORA_SAIDA"]);
                professor.Funcionario = funcionario;

                Pessoa pessoa = new Pessoa();
                pessoa.Nome = Convert.ToString(dataRow["NOME"]);
                pessoa.Sobrenome = Convert.ToString(dataRow["SOBRENOME"]);
                professor.Funcionario.Pessoa = pessoa;

                professorColecao.Add(professor);
            }

            return professorColecao;
        }
    }
}
