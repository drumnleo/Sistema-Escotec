using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcessoBandoDados;
using ObjetoTransferencia;
using System.Data;


namespace Negocios
{
    public class TurmaNegocios
    {
        AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();

        public string Inserir(Turma turma)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@ID_CURSO", turma.Curso.Id_Curso);
                acessoDados.AdicionarParametros("@ID_LABORATORIO", turma.Laboratorio.Id_Laboratorio);
                acessoDados.AdicionarParametros("@ID_PROFESSOR_MINISTRA", turma.ProfessorMinistra.Id_Professor_Ministra);
                acessoDados.AdicionarParametros("@NOME_TURMA", turma.Nome_Turma);
                acessoDados.AdicionarParametros("@DATA_INICIO", turma.Data_Inicio);
                acessoDados.AdicionarParametros("@DATA_FIM", turma.Data_Fim);
                acessoDados.AdicionarParametros("@HORA_INICIO", turma.Hora_Inicio);
                acessoDados.AdicionarParametros("@HORA_FIM", turma.Hora_Fim);
                acessoDados.AdicionarParametros("@VAGAS_DISPONIVEIS", turma.Vagas_Disponiveis);
                acessoDados.AdicionarParametros("@SEG", turma.Segunda_Aula);
                acessoDados.AdicionarParametros("@TER", turma.Terca_Aula);
                acessoDados.AdicionarParametros("@QUA", turma.Quarta_Aula);
                acessoDados.AdicionarParametros("@QUI", turma.Quinta_Aula);
                acessoDados.AdicionarParametros("@SEX", turma.Sexta_Aula);
                acessoDados.AdicionarParametros("@SAB", turma.Sabado_Aula);
                acessoDados.AdicionarParametros("@DOM", turma.Domingo_Aula);
                acessoDados.AdicionarParametros("@ID_USUARIO", turma.Usuario.Id_Usuario);


                string idTurma = acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "USP_TURMA_INSERIR").ToString();

                return idTurma;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string AtualizarporId(Turma turma)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@ID_TURMA", turma.Id_Turma);
                acessoDados.AdicionarParametros("@ID_CURSO", turma.Curso.Id_Curso);
                acessoDados.AdicionarParametros("@ID_LABORATORIO", turma.Laboratorio.Id_Laboratorio);
                acessoDados.AdicionarParametros("@ID_PROFESSOR_MINISTRA", turma.ProfessorMinistra.Id_Professor_Ministra);
                acessoDados.AdicionarParametros("@NOME_TURMA", turma.Nome_Turma);
                acessoDados.AdicionarParametros("@DATA_INICIO", turma.Data_Inicio);
                acessoDados.AdicionarParametros("@DATA_FIM", turma.Data_Fim);
                acessoDados.AdicionarParametros("@HORA_INICIO", turma.Hora_Inicio);
                acessoDados.AdicionarParametros("@HORA_FIM", turma.Hora_Fim);
                acessoDados.AdicionarParametros("@VAGAS_DISPONIVEIS", turma.Vagas_Disponiveis);
                acessoDados.AdicionarParametros("@SEG", turma.Segunda_Aula);
                acessoDados.AdicionarParametros("@TER", turma.Terca_Aula);
                acessoDados.AdicionarParametros("@QUA", turma.Quarta_Aula);
                acessoDados.AdicionarParametros("@QUI", turma.Quinta_Aula);
                acessoDados.AdicionarParametros("@SEX", turma.Sexta_Aula);
                acessoDados.AdicionarParametros("@SAB", turma.Sabado_Aula);
                acessoDados.AdicionarParametros("@DOM", turma.Domingo_Aula);
                acessoDados.AdicionarParametros("@ID_USUARIO", turma.Usuario.Id_Usuario);


                string idTurma = acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "USP_TURMA_ATUALIZARPORID").ToString();

                return idTurma;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Excluir(Turma turma)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@ID_TURMA", turma.Id_Turma);
                acessoDados.AdicionarParametros("@ID_USUARIO", turma.Usuario.Id_Usuario);

                string idTurma = acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "USP_TURMA_EXCLUIR").ToString();

                return idTurma;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public TurmaColecao ConsultarPorNome(string nome)
        {
            try
            {
                TurmaColecao turmaColecao = new TurmaColecao();

                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@NOME_TURMA", nome);

                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "USP_TURMA_CONSULTARPORNOME");

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    Turma turma = new Turma();

                    turma.Id_Turma = Convert.ToInt32(dataRow["ID_TURMA"]);
                    turma.Nome_Turma = Convert.ToString(dataRow["NOME_TURMA"]);
                    turma.Data_Inicio = Convert.ToDateTime(dataRow["DATA_INICIO"]);
                    turma.Data_Fim = Convert.ToDateTime(dataRow["DATA_FIM"]);
                    turma.Hora_Inicio = (TimeSpan)(dataRow["HORA_INICIO"]);
                    turma.Hora_Fim = (TimeSpan)(dataRow["HORA_FIM"]);
                    turma.Qtde_Feriado = Convert.ToInt16(dataRow["QTDE_FERIADOS"]);
                    turma.Vagas_Disponiveis = Convert.ToInt16(dataRow["VAGAS_DISPONIVEIS"]);
                    turma.Segunda_Aula = Convert.ToBoolean(dataRow["SEGUNDA_AULA"]);
                    turma.Terca_Aula = Convert.ToBoolean(dataRow["TERCA_AULA"]);
                    turma.Quarta_Aula = Convert.ToBoolean(dataRow["QUARTA_AULA"]);
                    turma.Quinta_Aula = Convert.ToBoolean(dataRow["QUINTA_AULA"]);
                    turma.Sexta_Aula = Convert.ToBoolean(dataRow["SEXTA_AULA"]);
                    turma.Sabado_Aula = Convert.ToBoolean(dataRow["SABADO_AULA"]);
                    turma.Domingo_Aula = Convert.ToBoolean(dataRow["DOMINGO_AULA"]);
                    turma.Data_Cadastro = Convert.ToDateTime(dataRow["DATA_CADASTRO"]);
                    turma.Data_Ultima_Alteracao = Convert.ToDateTime(dataRow["DATA_ULTIMA_ALTERACAO"]);

                    Usuario usuario = new Usuario();
                    usuario.Id_Usuario = Convert.ToInt32(dataRow["USUARIO_CAD_ALT"]);

                    Curso curso = new Curso();
                    curso.Id_Curso = Convert.ToInt32(dataRow["ID_CURSO"]);
                    curso.Nome = Convert.ToString(dataRow["CURSO_NOME"]);

                    Laboratorio laboratorio = new Laboratorio();
                    laboratorio.Id_Laboratorio = Convert.ToInt32(dataRow["ID_LABORATORIO"]);
                    laboratorio.Nome = Convert.ToString(dataRow["NOME_LABORATORIO"]);

                    Pessoa pessoa = new Pessoa();
                    pessoa.Id_Pessoa = Convert.ToInt32(dataRow["ID_PESSOA"]);
                    pessoa.Nome = Convert.ToString(dataRow["NOME_PROFESSOR"]);
                    pessoa.Sobrenome = Convert.ToString(dataRow["SOBRENOME_PROFESSOR"]);

                    ProfessorMinistra professorMinistra = new ProfessorMinistra();
                    professorMinistra.Id_Professor_Ministra = Convert.ToInt32(dataRow["ID_PROFESSOR_MINISTRA"]);

                    Professor professor = new Professor();
                    professor.Id_Professor = Convert.ToInt32(dataRow["ID_PROFESSOR"]);

                    Funcionario funcionario = new Funcionario();
                    funcionario.Id_Funcionario = Convert.ToInt32(dataRow["ID_FUNCIONARIO"]);

                    turma.ProfessorMinistra = professorMinistra;
                    turma.ProfessorMinistra.Professor = professor;
                    turma.ProfessorMinistra.Professor.Funcionario = funcionario;
                    turma.ProfessorMinistra.Professor.Funcionario.Pessoa = pessoa;
                    turma.Usuario = usuario;
                    turma.Curso = curso;
                    turma.Laboratorio = laboratorio;
                    turma.ProfessorMinistra = professorMinistra;
                    turmaColecao.Add(turma);
                }

                return turmaColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar turma. Detalhes: " + ex.Message);
            }
        }

        public TurmaColecao ConsultarPorId(int id)
        {
            try
            {
                TurmaColecao turmaColecao = new TurmaColecao();

                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@ID", id);

                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "USP_TURMA_CONSULTARPORID");

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    Turma turma = new Turma();

                    turma.Id_Turma = Convert.ToInt32(dataRow["ID_TURMA"]);
                    turma.Nome_Turma = Convert.ToString(dataRow["NOME_TURMA"]);
                    turma.Data_Inicio = Convert.ToDateTime(dataRow["DATA_INICIO"]);
                    turma.Data_Fim = Convert.ToDateTime(dataRow["DATA_FIM"]);
                    turma.Hora_Inicio = (TimeSpan)(dataRow["HORA_INICIO"]);
                    turma.Hora_Fim = (TimeSpan)(dataRow["HORA_FIM"]);
                    turma.Qtde_Feriado = Convert.ToInt16(dataRow["QTDE_FERIADOS"]);
                    turma.Vagas_Disponiveis = Convert.ToInt16(dataRow["VAGAS_DISPONIVEIS"]);
                    turma.Segunda_Aula = Convert.ToBoolean(dataRow["SEGUNDA_AULA"]);
                    turma.Terca_Aula = Convert.ToBoolean(dataRow["TERCA_AULA"]);
                    turma.Quarta_Aula = Convert.ToBoolean(dataRow["QUARTA_AULA"]);
                    turma.Quinta_Aula = Convert.ToBoolean(dataRow["QUINTA_AULA"]);
                    turma.Sexta_Aula = Convert.ToBoolean(dataRow["SEXTA_AULA"]);
                    turma.Sabado_Aula = Convert.ToBoolean(dataRow["SABADO_AULA"]);
                    turma.Domingo_Aula = Convert.ToBoolean(dataRow["DOMINGO_AULA"]);
                    turma.Data_Cadastro = Convert.ToDateTime(dataRow["DATA_CADASTRO"]);
                    turma.Data_Ultima_Alteracao = Convert.ToDateTime(dataRow["DATA_ULTIMA_ALTERACAO"]);

                    Usuario usuario = new Usuario();
                    usuario.Id_Usuario = Convert.ToInt32(dataRow["USUARIO_CAD_ALT"]);

                    Curso curso = new Curso();
                    curso.Id_Curso = Convert.ToInt32(dataRow["ID_CURSO"]);
                    curso.Nome = Convert.ToString(dataRow["CURSO_NOME"]);

                    Laboratorio laboratorio = new Laboratorio();
                    laboratorio.Id_Laboratorio = Convert.ToInt32(dataRow["ID_LABORATORIO"]);
                    laboratorio.Nome = Convert.ToString(dataRow["NOME_LABORATORIO"]);

                    Pessoa pessoa = new Pessoa();
                    pessoa.Id_Pessoa = Convert.ToInt32(dataRow["ID_PESSOA"]);
                    pessoa.Nome = Convert.ToString(dataRow["NOME_PROFESSOR"]);
                    pessoa.Sobrenome = Convert.ToString(dataRow["SOBRENOME_PROFESSOR"]);

                    ProfessorMinistra professorMinistra = new ProfessorMinistra();
                    professorMinistra.Id_Professor_Ministra = Convert.ToInt32(dataRow["ID_PROFESSOR_MINISTRA"]);

                    Professor professor = new Professor();
                    professor.Id_Professor = Convert.ToInt32(dataRow["ID_PROFESSOR"]);

                    Funcionario funcionario = new Funcionario();
                    funcionario.Id_Funcionario = Convert.ToInt32(dataRow["ID_FUNCIONARIO"]);

                    turma.ProfessorMinistra = professorMinistra;
                    turma.ProfessorMinistra.Professor = professor;
                    turma.ProfessorMinistra.Professor.Funcionario = funcionario;
                    turma.ProfessorMinistra.Professor.Funcionario.Pessoa = pessoa;
                    turma.Usuario = usuario;
                    turma.Curso = curso;
                    turma.Laboratorio = laboratorio;
                    turma.ProfessorMinistra = professorMinistra;
                    turmaColecao.Add(turma);
                }

                return turmaColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar turma. Detalhes: " + ex.Message);
            }
        }

        public TurmaColecao ConsultarPorCurso(int id)
        {
            try
            {
                TurmaColecao turmaColecao = new TurmaColecao();

                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@ID_CURSO", id);

                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "USP_TURMA_CONSULTARPORCURSO");

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    Turma turma = new Turma();

                    turma.Id_Turma = Convert.ToInt32(dataRow["ID_TURMA"]);
                    turma.Nome_Turma = Convert.ToString(dataRow["NOME_TURMA"]);
                    turma.Data_Inicio = Convert.ToDateTime(dataRow["DATA_INICIO"]);
                    turma.Data_Fim = Convert.ToDateTime(dataRow["DATA_FIM"]);
                    turma.Hora_Inicio = (TimeSpan)(dataRow["HORA_INICIO"]);
                    turma.Hora_Fim = (TimeSpan)(dataRow["HORA_FIM"]);
                    turma.Qtde_Feriado = Convert.ToInt16(dataRow["QTDE_FERIADOS"]);
                    turma.Vagas_Disponiveis = Convert.ToInt16(dataRow["VAGAS_DISPONIVEIS"]);
                    turma.Segunda_Aula = Convert.ToBoolean(dataRow["SEGUNDA_AULA"]);
                    turma.Terca_Aula = Convert.ToBoolean(dataRow["TERCA_AULA"]);
                    turma.Quarta_Aula = Convert.ToBoolean(dataRow["QUARTA_AULA"]);
                    turma.Quinta_Aula = Convert.ToBoolean(dataRow["QUINTA_AULA"]);
                    turma.Sexta_Aula = Convert.ToBoolean(dataRow["SEXTA_AULA"]);
                    turma.Sabado_Aula = Convert.ToBoolean(dataRow["SABADO_AULA"]);
                    turma.Domingo_Aula = Convert.ToBoolean(dataRow["DOMINGO_AULA"]);
                    turma.Data_Cadastro = Convert.ToDateTime(dataRow["DATA_CADASTRO"]);
                    turma.Data_Ultima_Alteracao = Convert.ToDateTime(dataRow["DATA_ULTIMA_ALTERACAO"]);

                    Usuario usuario = new Usuario();
                    usuario.Id_Usuario = Convert.ToInt32(dataRow["USUARIO_CAD_ALT"]);

                    Curso curso = new Curso();
                    curso.Id_Curso = Convert.ToInt32(dataRow["ID_CURSO"]);
                    curso.Nome = Convert.ToString(dataRow["CURSO_NOME"]);

                    Laboratorio laboratorio = new Laboratorio();
                    laboratorio.Id_Laboratorio = Convert.ToInt32(dataRow["ID_LABORATORIO"]);
                    laboratorio.Nome = Convert.ToString(dataRow["NOME_LABORATORIO"]);

                    Pessoa pessoa = new Pessoa();
                    pessoa.Id_Pessoa = Convert.ToInt32(dataRow["ID_PESSOA"]);
                    pessoa.Nome = Convert.ToString(dataRow["NOME_PROFESSOR"]);
                    pessoa.Sobrenome = Convert.ToString(dataRow["SOBRENOME_PROFESSOR"]);

                    ProfessorMinistra professorMinistra = new ProfessorMinistra();
                    professorMinistra.Id_Professor_Ministra = Convert.ToInt32(dataRow["ID_PROFESSOR_MINISTRA"]);

                    Professor professor = new Professor();
                    professor.Id_Professor = Convert.ToInt32(dataRow["ID_PROFESSOR"]);

                    Funcionario funcionario = new Funcionario();
                    funcionario.Id_Funcionario = Convert.ToInt32(dataRow["ID_FUNCIONARIO"]);

                    turma.ProfessorMinistra = professorMinistra;
                    turma.ProfessorMinistra.Professor = professor;
                    turma.ProfessorMinistra.Professor.Funcionario = funcionario;
                    turma.ProfessorMinistra.Professor.Funcionario.Pessoa = pessoa;
                    turma.Usuario = usuario;
                    turma.Curso = curso;
                    turma.Laboratorio = laboratorio;
                    turma.ProfessorMinistra = professorMinistra;
                    turmaColecao.Add(turma);
                }

                return turmaColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar turma. Detalhes: " + ex.Message);
            }
        }
    }
}
