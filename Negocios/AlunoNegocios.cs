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
    public class AlunoNegocios
    {
        AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();

        //Inserir 

        public string Inserir (Aluno aluno)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@ID_PESSOA", aluno.Pessoa.Id_Pessoa);
                acessoDados.AdicionarParametros("@ID_USUARIO", aluno.Usuario.Id_Usuario);

                string IdAluno = acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "USP_ALUNO_INSERIR").ToString();

                return IdAluno;
            }
            catch (Exception ex)
            {

                return ex.Message;

            }

        }
        public AlunoColecao ConsultarPorNome(string nome)
        {
            try
            {
                AlunoColecao alunoColecao = new AlunoColecao();

                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@NOME", nome);

                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "USP_ALUNO_CONSULTAPORNOME");

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    Aluno aluno = new Aluno();
                    aluno.Id_Aluno = Convert.ToInt32(dataRow["ID_ALUNO"]);
                    aluno.Data_Cadastro = Convert.ToDateTime(dataRow["DATA_CADASTRO"]);
                    aluno.Data_Ultimo_Cadastro = Convert.ToDateTime(dataRow["DATA_ULTIMA_ALTERACAO"]);

                    Pessoa pessoa = new Pessoa();
                    pessoa.Id_Pessoa = Convert.ToInt32(dataRow["ID_PESSOA"]);
                    pessoa.Nome = Convert.ToString(dataRow["NOME"]);
                    pessoa.Sobrenome = Convert.ToString(dataRow["SOBRENOME"]);
                    pessoa.CPF = Convert.ToString(dataRow["CPF"]);

                    Endereco endereco = new Endereco();
                    endereco.Id_Endereco = Convert.ToInt32(dataRow["ID_ENDERECO"]);
                    endereco.CEP = Convert.ToString(dataRow["CEP"]);
                    endereco.Logradouro = Convert.ToString(dataRow["LOGRADOURO"]);
                    endereco.Bairro = Convert.ToString(dataRow["BAIRRO"]);
                    endereco.Cidade = Convert.ToString(dataRow["CIDADE"]);
                    endereco.Estado = Convert.ToString(dataRow["ESTADO"]);

                    Usuario usuario = new Usuario();
                    usuario.Id_Usuario = Convert.ToInt32(dataRow["USUARIO_CAD_ALT"]);

                    aluno.Pessoa = pessoa;
                    alunoColecao.Add(aluno);
                }
                return alunoColecao;                                         
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar aluno. Detalhes: "+ ex.Message);
            }

        }

        public Aluno ConsultarPorId(int id)
        {
            try
            {
                Aluno aluno = new Aluno();

                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@ID_ALUNO", id);

                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "USP_ALUNO_CONSULTARPORID");

                foreach(DataRow dataRow in dataTable.Rows)
                {
                    aluno.Id_Aluno = Convert.ToInt32(dataRow["ID_ALUNO"]);
                    aluno.Data_Cadastro = Convert.ToDateTime(dataRow["DATA_CADASTRO"]);
                    aluno.Data_Ultimo_Cadastro = Convert.ToDateTime(dataRow["DATA_ULTIMA_ALTERACAO"]);

                    Pessoa pessoa = new Pessoa();
                    pessoa.Id_Pessoa = Convert.ToInt32(dataRow["ID_PESSOA"]);
                    pessoa.Nome = Convert.ToString(dataRow["NOME"]);
                    pessoa.Sobrenome = Convert.ToString(dataRow["SOBRENOME"]);
                    pessoa.CPF = Convert.ToString(dataRow["CPF"]);

                    Endereco endereco = new Endereco();
                    endereco.Id_Endereco = Convert.ToInt32(dataRow["ID_ENDERECO"]);
                    endereco.CEP = Convert.ToString(dataRow["CEP"]);
                    endereco.Logradouro = Convert.ToString(dataRow["LOGRADOURO"]);
                    endereco.Bairro = Convert.ToString(dataRow["BAIRRO"]);
                    endereco.Cidade = Convert.ToString(dataRow["CIDADE"]);
                    endereco.Estado = Convert.ToString(dataRow["ESTADO"]);

                    Usuario usuario = new Usuario();
                    usuario.Id_Usuario = Convert.ToInt32(dataRow["USUARIO_CAD_ALT"]);

                    aluno.Pessoa = pessoa;
                }

                return aluno;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar Funcionário. Detalhes: " + ex.Message);
            }

        }
        public string AtualizarPorId(Aluno aluno)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@ID_ALUNO", aluno.Id_Aluno);
                acessoDados.AdicionarParametros("@ID_PESSOA", aluno.Pessoa.Id_Pessoa);
                acessoDados.AdicionarParametros("@ID_USUARIO", aluno.Usuario.Id_Usuario);

                string idAluno = acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "USP_ALUNO_ATUALIZARPORID").ToString();

                return idAluno;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public string Excluir(Aluno aluno)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@ID_ALUNO", aluno.Id_Aluno);
                acessoDados.AdicionarParametros("@ID_USUARIO", aluno.Usuario.Id_Usuario);

                string idAluno = acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "USP_ALUNO_EXCLUIR").ToString();
                return idAluno;
            }
            catch (Exception ex )
            {
                return ex.Message;
            }
        }
    }
}