using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjetoTransferencia;
using AcessoBandoDados;
using System.Data;

namespace Negocios
{
    public class FuncionarioNegocios
    {
        private readonly AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();
        public string Inserir(Funcionario funcionario)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@ID_PESSOA", funcionario.Pessoa.Id_Pessoa);
                acessoDados.AdicionarParametros("@DATA_ADMISSAO", funcionario.Data_Admissao);
                acessoDados.AdicionarParametros("@HORA_ENTRADA", funcionario.Hora_Entrada);
                acessoDados.AdicionarParametros("@HORA_SAIDA", funcionario.Hora_Saida);
                acessoDados.AdicionarParametros("@NUM_CTPS", funcionario.Num_CTPS);
                acessoDados.AdicionarParametros("@SERIE_CTPS", funcionario.Serie_CTPS);
                acessoDados.AdicionarParametros("@NUMERO_NIS", funcionario.Num_NIS);
                acessoDados.AdicionarParametros("@ID_USUARIO", funcionario.Usuario_Cad_Alt);

                string idFuncionario = acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "USP_FUNCIONARIO_INSERIR").ToString();

                return idFuncionario;
            }
            catch (Exception ex)
            {

                return ex.Message;
            }

        }

        public string AtualizarporId(Funcionario funcionario)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@ID_FUNCIONARIO", funcionario.Id_Funcionario);
                acessoDados.AdicionarParametros("@ID_PESSOA", funcionario.Pessoa.Id_Pessoa);
                acessoDados.AdicionarParametros("@DATA_ADMISSAO", funcionario.Data_Admissao);
                acessoDados.AdicionarParametros("@HORA_ENTRADA", funcionario.Hora_Entrada);
                acessoDados.AdicionarParametros("@HORA_SAIDA", funcionario.Hora_Saida);
                acessoDados.AdicionarParametros("@NUM_CTPS", funcionario.Num_CTPS);
                acessoDados.AdicionarParametros("@SERIE_CTPS", funcionario.Serie_CTPS);
                acessoDados.AdicionarParametros("@NUMERO_NIS", funcionario.Num_NIS);
                acessoDados.AdicionarParametros("@ID_USUARIO", funcionario.Usuario_Cad_Alt);

                string idFuncionario = acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "USP_FUNCIONARIO_ATUALIZARPORID").ToString();

                return idFuncionario;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Excluir(Funcionario funcionario)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("ID_FUNCIONARIO", funcionario.Id_Funcionario);
                acessoDados.AdicionarParametros("ID_USUARIO", funcionario.Usuario_Cad_Alt);
                string idFuncionario = acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "USP_FUNCIONARIO_EXCLUIR").ToString();
                return idFuncionario;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public FuncionarioColecao ConsultarPorDescricao(string nome)
        {
            try
            {
                FuncionarioColecao funcionarioColecao = new FuncionarioColecao();

                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@NOME", nome);

                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "USP_FUNCIONARIO_CONSULTARPORNOME");

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    Funcionario funcionario = new Funcionario();

                    funcionario.Id_Funcionario = Convert.ToInt32(dataRow["ID_FUNCIONARIO"]);
                    funcionario.Data_Admissao = Convert.ToDateTime(dataRow["DATA_ADMISSAO"]);
                    if (dataRow["DATA_DEMISSAO"].ToString() != "")
                    {
                        funcionario.Data_Demissao = Convert.ToDateTime(dataRow["DATA_DEMISSAO"]);
                    }
                    funcionario.Hora_Entrada = DateTime.ParseExact(dataRow["HORA_ENTRADA"].ToString(), "HH:mm:ss", null, System.Globalization.DateTimeStyles.None);
                    funcionario.Hora_Saida = DateTime.ParseExact(dataRow["HORA_SAIDA"].ToString(), "HH:mm:ss", null, System.Globalization.DateTimeStyles.None);
                    funcionario.Num_CTPS = Convert.ToInt32(dataRow["NUM_CTPS"]);
                    funcionario.Serie_CTPS = Convert.ToInt32(dataRow["SERIE_CTPS"]);
                    funcionario.Num_NIS = Convert.ToInt32(dataRow["NUM_NIS"]);
                    funcionario.Data_Cadastro = Convert.ToDateTime(dataRow["DATA_CADASTRO"]);
                    funcionario.Data_Ultima_Alteracao = Convert.ToDateTime(dataRow["DATA_ULTIMA_ALTERACAO"]);
                    funcionario.Usuario_Cad_Alt = Convert.ToInt32(dataRow["USUARIO_CAD_ALT"]);

                    Pessoa pessoa = new Pessoa();

                    pessoa.Id_Pessoa = Convert.ToInt32(dataRow["ID_PESSOA"]);
                    pessoa.Nome = Convert.ToString(dataRow["NOME"]);
                    pessoa.Sobrenome = Convert.ToString(dataRow["SOBRENOME"]);
                    pessoa.CPF = Convert.ToString(dataRow["CPF"]);


                    funcionario.Pessoa = pessoa;
                    funcionarioColecao.Add(funcionario);
                }

                return funcionarioColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar Funcionário. Detalhes: " + ex.Message);
            }
        }

        public Funcionario ConsultarPorId(int id)
        {
            try
            {
                Funcionario funcionario = new Funcionario();

                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@ID_FUNCIONARIO", id);

                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "USP_FUNCIONARIO_CONSULTARPORID");

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    funcionario = new Funcionario();

                    funcionario.Id_Funcionario = Convert.ToInt32(dataRow["ID_FUNCIONARIO"]);
                    funcionario.Data_Admissao = Convert.ToDateTime(dataRow["DATA_ADMISSAO"]);
                    if (dataRow["DATA_DEMISSAO"].ToString() != "")
                    {
                        funcionario.Data_Demissao = Convert.ToDateTime(dataRow["DATA_DEMISSAO"]);
                    }
                    funcionario.Hora_Entrada = DateTime.ParseExact(dataRow["HORA_ENTRADA"].ToString(), "HH:mm:ss", null, System.Globalization.DateTimeStyles.None);
                    funcionario.Hora_Saida = DateTime.ParseExact(dataRow["HORA_SAIDA"].ToString(), "HH:mm:ss", null, System.Globalization.DateTimeStyles.None);
                    funcionario.Num_CTPS = Convert.ToInt32(dataRow["NUM_CTPS"]);
                    funcionario.Serie_CTPS = Convert.ToInt32(dataRow["SERIE_CTPS"]);
                    funcionario.Num_NIS = Convert.ToInt32(dataRow["NUM_NIS"]);
                    funcionario.Data_Cadastro = Convert.ToDateTime(dataRow["DATA_CADASTRO"]);
                    funcionario.Data_Ultima_Alteracao = Convert.ToDateTime(dataRow["DATA_ULTIMA_ALTERACAO"]);
                    funcionario.Usuario_Cad_Alt = Convert.ToInt32(dataRow["USUARIO_CAD_ALT"]);

                    Pessoa pessoa = new Pessoa();
                    pessoa.Id_Pessoa = Convert.ToInt32(dataRow["ID_PESSOA"]);
                    pessoa.Nome = Convert.ToString(dataRow["NOME"]);
                    pessoa.Sobrenome = Convert.ToString(dataRow["SOBRENOME"]);
                    pessoa.CPF = Convert.ToString(dataRow["CPF"]);

                    funcionario.Pessoa = pessoa;
                }

                return funcionario;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar Funcionário. Detalhes: " + ex.Message);
            }
        }

    }
}
