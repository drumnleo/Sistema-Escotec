using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcessoBandoDados;
using ObjetoTransferencia;
using System.Data;
using System.Diagnostics;

namespace Negocios
{
    public class MatriculaNegocios
    {
        readonly AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();

        //Inserir 

        public string Inserir(Matricula matricula)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@ID_PESSOA", matricula.Aluno.Pessoa.Id_Pessoa);
                acessoDados.AdicionarParametros("@ID_TURMA", matricula.Turma.Id_Turma);
                acessoDados.AdicionarParametros("@ID_PROMOCAO_VALOR", matricula.PromocaoValor.Id_Promocao_Valor);
                acessoDados.AdicionarParametros("@ID_USUARIO", matricula.Usuario.Id_Usuario);

                string IdMatricula = acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "USP_MATRICULA_INSERIR").ToString();

                return IdMatricula;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }
        public MatriculaColecao ConsultarPorNomeAluno(string nome, string sobrenome)
        {
            try
            {
                MatriculaColecao matriculaColecao = new MatriculaColecao();

                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@NOME_ALUNO", nome);
                acessoDados.AdicionarParametros("@SOBRENOME_ALUNO", sobrenome);

                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "USP_MATRICULA_CONSULTARPORNOMEALUNO");

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    Aluno aluno = new Aluno();
                    aluno.Id_Aluno = Convert.ToInt32(dataRow["ID_ALUNO"]);

                    Pessoa pessoa = new Pessoa();
                    pessoa.Nome = Convert.ToString(dataRow["NOME"]);
                    pessoa.Sobrenome = Convert.ToString(dataRow["SOBRENOME"]);

                    Matricula matricula = new Matricula();
                    matricula.Id_Matricula = Convert.ToInt32(dataRow["MATRICULA"]);
                    matricula.Situacao = Convert.ToChar(dataRow["SITUACAO"]);
                    matricula.Data_Cadastro = Convert.ToDateTime(dataRow["DATA_CADASTRO"]);
                    matricula.Data_Ultima_Alteracao = Convert.ToDateTime(dataRow["DATA_ULTIMA_ALTERACAO"]);

                    Turma turma = new Turma();
                    turma.Id_Turma = Convert.ToInt32(dataRow["ID_TURMA"]);
                    turma.Nome_Turma = Convert.ToString(dataRow["NOME_TURMA"]);

                    PromocaoValor promocaoValor = new PromocaoValor();
                    promocaoValor.Id_Promocao_Valor = Convert.ToInt32(dataRow["ID_PROMOCAO_VALOR"]);
                    promocaoValor.Nome_Promocao = Convert.ToString(dataRow["NOME_PROMOCAO"]);

                    Usuario usuario = new Usuario();
                    usuario.Id_Usuario = Convert.ToInt32(dataRow["USUARIO_CAD_ALT"]);

                    matricula.Aluno = aluno;
                    matricula.Aluno.Pessoa = pessoa;
                    matricula.PromocaoValor = promocaoValor;
                    matricula.Turma = turma;
                    matricula.Usuario = usuario;
                    matriculaColecao.Add(matricula);
                }
                return matriculaColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar matrícula. Detalhes: " + ex.Message);
            }
        }
        public MatriculaColecao ConsultarPorCpfAluno(string cpf)
        {
            try
            {
                MatriculaColecao matriculaColecao = new MatriculaColecao();

                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@CPF", cpf);

                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "USP_MATRICULA_CONSULTARPORCPFALUNO");

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    Aluno aluno = new Aluno();
                    aluno.Id_Aluno = Convert.ToInt32(dataRow["ID_ALUNO"]);

                    Pessoa pessoa = new Pessoa();
                    pessoa.Nome = Convert.ToString(dataRow["NOME"]);
                    pessoa.Sobrenome = Convert.ToString(dataRow["SOBRENOME"]);

                    Matricula matricula = new Matricula();
                    matricula.Id_Matricula = Convert.ToInt32(dataRow["MATRICULA"]);
                    matricula.Situacao = Convert.ToChar(dataRow["SITUACAO"]);
                    matricula.Data_Cadastro = Convert.ToDateTime(dataRow["DATA_CADASTRO"]);
                    matricula.Data_Ultima_Alteracao = Convert.ToDateTime(dataRow["DATA_ULTIMA_ALTERACAO"]);

                    Turma turma = new Turma();
                    turma.Id_Turma = Convert.ToInt32(dataRow["ID_TURMA"]);
                    turma.Nome_Turma = Convert.ToString(dataRow["NOME_TURMA"]);

                    PromocaoValor promocaoValor = new PromocaoValor();
                    promocaoValor.Id_Promocao_Valor = Convert.ToInt32(dataRow["ID_PROMOCAO_VALOR"]);
                    promocaoValor.Nome_Promocao = Convert.ToString(dataRow["NOME_PROMOCAO"]);

                    Usuario usuario = new Usuario();
                    usuario.Id_Usuario = Convert.ToInt32(dataRow["USUARIO_CAD_ALT"]);

                    matricula.Aluno = aluno;
                    matricula.Aluno.Pessoa = pessoa;
                    matricula.PromocaoValor = promocaoValor;
                    matricula.Turma = turma;
                    matricula.Usuario = usuario;
                    matriculaColecao.Add(matricula);
                }
                return matriculaColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar matrícula. Detalhes: " + ex.Message);
            }
        }
        public MatriculaColecao ConsultarPorTurma(int idTurma)
        {
            try
            {
                MatriculaColecao matriculaColecao = new MatriculaColecao();

                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@ID_TURMA", idTurma);

                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "USP_MATRICULA_CONSULTARPORTURMA");

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    Aluno aluno = new Aluno();
                    aluno.Id_Aluno = Convert.ToInt32(dataRow["ID_ALUNO"]);

                    Pessoa pessoa = new Pessoa();
                    pessoa.Nome = Convert.ToString(dataRow["NOME"]);
                    pessoa.Sobrenome = Convert.ToString(dataRow["SOBRENOME"]);

                    Matricula matricula = new Matricula();
                    matricula.Id_Matricula = Convert.ToInt32(dataRow["MATRICULA"]);
                    matricula.Situacao = Convert.ToChar(dataRow["SITUACAO"]);
                    matricula.Data_Cadastro = Convert.ToDateTime(dataRow["DATA_CADASTRO"]);
                    matricula.Data_Ultima_Alteracao = Convert.ToDateTime(dataRow["DATA_ULTIMA_ALTERACAO"]);

                    Turma turma = new Turma();
                    turma.Id_Turma = Convert.ToInt32(dataRow["ID_TURMA"]);
                    turma.Nome_Turma = Convert.ToString(dataRow["NOME_TURMA"]);

                    PromocaoValor promocaoValor = new PromocaoValor();
                    promocaoValor.Id_Promocao_Valor = Convert.ToInt32(dataRow["ID_PROMOCAO_VALOR"]);
                    promocaoValor.Nome_Promocao = Convert.ToString(dataRow["NOME_PROMOCAO"]);

                    Usuario usuario = new Usuario();
                    usuario.Id_Usuario = Convert.ToInt32(dataRow["USUARIO_CAD_ALT"]);

                    matricula.Aluno = aluno;
                    matricula.Aluno.Pessoa = pessoa;
                    matricula.PromocaoValor = promocaoValor;
                    matricula.Turma = turma;
                    matricula.Usuario = usuario;
                    matriculaColecao.Add(matricula);
                }
                return matriculaColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar matrícula. Detalhes: " + ex.Message);
            }
        }
        public MatriculaColecao ConsultarPorDatas(DateTime dataInicio, DateTime dataFim)
        {
            try
            {
                MatriculaColecao matriculaColecao = new MatriculaColecao();

                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@DATAINICIO", dataInicio);
                acessoDados.AdicionarParametros("@DATAFIM", dataFim);

                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "USP_MATRICULA_CONSULTARPORDATAS");

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    Aluno aluno = new Aluno();
                    aluno.Id_Aluno = Convert.ToInt32(dataRow["ID_ALUNO"]);

                    Pessoa pessoa = new Pessoa();
                    pessoa.Nome = Convert.ToString(dataRow["NOME"]);
                    pessoa.Sobrenome = Convert.ToString(dataRow["SOBRENOME"]);

                    Matricula matricula = new Matricula();
                    matricula.Id_Matricula = Convert.ToInt32(dataRow["MATRICULA"]);
                    matricula.Situacao = Convert.ToChar(dataRow["SITUACAO"]);
                    matricula.Data_Cadastro = Convert.ToDateTime(dataRow["DATA_CADASTRO"]);
                    matricula.Data_Ultima_Alteracao = Convert.ToDateTime(dataRow["DATA_ULTIMA_ALTERACAO"]);

                    Turma turma = new Turma();
                    turma.Id_Turma = Convert.ToInt32(dataRow["ID_TURMA"]);
                    turma.Nome_Turma = Convert.ToString(dataRow["NOME_TURMA"]);

                    PromocaoValor promocaoValor = new PromocaoValor();
                    promocaoValor.Id_Promocao_Valor = Convert.ToInt32(dataRow["ID_PROMOCAO_VALOR"]);
                    promocaoValor.Nome_Promocao = Convert.ToString(dataRow["NOME_PROMOCAO"]);

                    Usuario usuario = new Usuario();
                    usuario.Id_Usuario = Convert.ToInt32(dataRow["USUARIO_CAD_ALT"]);

                    matricula.Aluno = aluno;
                    matricula.Aluno.Pessoa = pessoa;
                    matricula.PromocaoValor = promocaoValor;
                    matricula.Turma = turma;
                    matricula.Usuario = usuario;
                    matriculaColecao.Add(matricula);
                }
                return matriculaColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar matrícula. Detalhes: " + ex.Message);
            }
        }
        public MatriculaColecao ConsultarPorIdAluno(int id)
        {
            try
            {
                MatriculaColecao matriculaColecao = new MatriculaColecao();

                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@ID_ALUNO", id);

                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "USP_MATRICULA_CONSULTARPORALUNO");

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    Aluno aluno = new Aluno();
                    aluno.Id_Aluno = Convert.ToInt32(dataRow["ID_ALUNO"]);

                    Pessoa pessoa = new Pessoa();
                    pessoa.Nome = Convert.ToString(dataRow["NOME"]);
                    pessoa.Sobrenome = Convert.ToString(dataRow["SOBRENOME"]);

                    Matricula matricula = new Matricula();
                    matricula.Id_Matricula = Convert.ToInt32(dataRow["MATRICULA"]);
                    matricula.Situacao = Convert.ToChar(dataRow["SITUACAO"]);
                    matricula.Data_Cadastro = Convert.ToDateTime(dataRow["DATA_CADASTRO"]);
                    matricula.Data_Ultima_Alteracao = Convert.ToDateTime(dataRow["DATA_ULTIMA_ALTERACAO"]);

                    Turma turma = new Turma();
                    turma.Id_Turma = Convert.ToInt32(dataRow["ID_TURMA"]);
                    turma.Nome_Turma = Convert.ToString(dataRow["NOME_TURMA"]);

                    PromocaoValor promocaoValor = new PromocaoValor();
                    promocaoValor.Id_Promocao_Valor = Convert.ToInt32(dataRow["ID_PROMOCAO_VALOR"]);
                    promocaoValor.Nome_Promocao = Convert.ToString(dataRow["NOME_PROMOCAO"]);

                    Usuario usuario = new Usuario();
                    usuario.Id_Usuario = Convert.ToInt32(dataRow["USUARIO_CAD_ALT"]);

                    matricula.Aluno = aluno;
                    matricula.Aluno.Pessoa = pessoa;
                    matricula.PromocaoValor = promocaoValor;
                    matricula.Turma = turma;
                    matricula.Usuario = usuario;
                    matriculaColecao.Add(matricula);
                }
                return matriculaColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar matrícula. Detalhes: " + ex.Message);
            }
        }
        public MatriculaColecao ConsultarPorIdUsuario(int id)
        {
            try
            {
                MatriculaColecao matriculaColecao = new MatriculaColecao();

                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@ID_USUARIO", id);

                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "USP_MATRICULA_CONSULTARPORUSUARIO");

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    Aluno aluno = new Aluno();
                    aluno.Id_Aluno = Convert.ToInt32(dataRow["ID_ALUNO"]);

                    Pessoa pessoa = new Pessoa();
                    pessoa.Nome = Convert.ToString(dataRow["NOME"]);
                    pessoa.Sobrenome = Convert.ToString(dataRow["SOBRENOME"]);

                    Matricula matricula = new Matricula();
                    matricula.Id_Matricula = Convert.ToInt32(dataRow["MATRICULA"]);
                    matricula.Situacao = Convert.ToChar(dataRow["SITUACAO"]);
                    matricula.Data_Cadastro = Convert.ToDateTime(dataRow["DATA_CADASTRO"]);
                    matricula.Data_Ultima_Alteracao = Convert.ToDateTime(dataRow["DATA_ULTIMA_ALTERACAO"]);

                    Turma turma = new Turma();
                    turma.Id_Turma = Convert.ToInt32(dataRow["ID_TURMA"]);
                    turma.Nome_Turma = Convert.ToString(dataRow["NOME_TURMA"]);

                    PromocaoValor promocaoValor = new PromocaoValor();
                    promocaoValor.Id_Promocao_Valor = Convert.ToInt32(dataRow["ID_PROMOCAO_VALOR"]);
                    promocaoValor.Nome_Promocao = Convert.ToString(dataRow["NOME_PROMOCAO"]);

                    Usuario usuario = new Usuario();
                    usuario.Id_Usuario = Convert.ToInt32(dataRow["USUARIO_CAD_ALT"]);

                    matricula.Aluno = aluno;
                    matricula.Aluno.Pessoa = pessoa;
                    matricula.PromocaoValor = promocaoValor;
                    matricula.Turma = turma;
                    matricula.Usuario = usuario;
                    matriculaColecao.Add(matricula);
                }
                return matriculaColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar matrícula. Detalhes: " + ex.Message);
            }
        }
        public MatriculaColecao ConsultarPorId(int id)
        {
            try
            {
                MatriculaColecao matriculaColecao = new MatriculaColecao();

                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@ID_MATRICULA", id);

                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "USP_MATRICULA_CONSULTARPORID");

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    Aluno aluno = new Aluno();
                    aluno.Id_Aluno = Convert.ToInt32(dataRow["ID_ALUNO"]);

                    Pessoa pessoa = new Pessoa();
                    pessoa.Nome = Convert.ToString(dataRow["NOME"]);
                    pessoa.Sobrenome = Convert.ToString(dataRow["SOBRENOME"]);

                    Matricula matricula = new Matricula();
                    matricula.Id_Matricula = Convert.ToInt32(dataRow["MATRICULA"]);
                    matricula.Situacao = Convert.ToChar(dataRow["SITUACAO"]);
                    matricula.Data_Cadastro = Convert.ToDateTime(dataRow["DATA_CADASTRO"]);
                    matricula.Data_Ultima_Alteracao = Convert.ToDateTime(dataRow["DATA_ULTIMA_ALTERACAO"]);

                    Turma turma = new Turma();
                    turma.Id_Turma = Convert.ToInt32(dataRow["ID_TURMA"]);
                    turma.Nome_Turma = Convert.ToString(dataRow["NOME_TURMA"]);

                    PromocaoValor promocaoValor = new PromocaoValor();
                    promocaoValor.Id_Promocao_Valor = Convert.ToInt32(dataRow["ID_PROMOCAO_VALOR"]);
                    promocaoValor.Nome_Promocao = Convert.ToString(dataRow["NOME_PROMOCAO"]);

                    Usuario usuario = new Usuario();
                    usuario.Id_Usuario = Convert.ToInt32(dataRow["USUARIO_CAD_ALT"]);

                    matricula.Aluno = aluno;
                    matricula.Aluno.Pessoa = pessoa;
                    matricula.PromocaoValor = promocaoValor;
                    matricula.Turma = turma;
                    matricula.Usuario = usuario;
                    matriculaColecao.Add(matricula);
                }
                return matriculaColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar matrícula. Detalhes: " + ex.Message);
            }
        }
        public string AtualizarPorId(Matricula matricula)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@ID_MATRICULA", matricula.Id_Matricula);
                acessoDados.AdicionarParametros("@ID_PESSOA", matricula.Aluno.Pessoa.Id_Pessoa);
                acessoDados.AdicionarParametros("@ID_TURMA", matricula.Turma.Id_Turma);
                acessoDados.AdicionarParametros("@ID_PROMOCAO_VALOR", matricula.PromocaoValor.Id_Promocao_Valor);
                acessoDados.AdicionarParametros("@SITUACAO", matricula.Situacao);
                acessoDados.AdicionarParametros("@ID_USUARIO", matricula.Usuario.Id_Usuario);

                string idMatricula = acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "USP_MATRICULA_ATUALIZARPORID").ToString();

                return idMatricula;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
