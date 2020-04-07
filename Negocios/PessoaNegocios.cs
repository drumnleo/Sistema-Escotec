using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ObjetoTransferencia;
using AcessoBandoDados;

namespace Negocios
{
    public class PessoaNegocios
    {
        private readonly AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();

        public string Inserir(Pessoa pessoa)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@ID_PROFISSAO", pessoa.Id_Profissao);
                acessoDados.AdicionarParametros("@ID_TIPODOC", pessoa.Id_TipoDoc);
                acessoDados.AdicionarParametros("@ID_ESTADO_CIVIL", pessoa.Id_EstadoCivil);
                acessoDados.AdicionarParametros("@NOME", pessoa.Nome);
                acessoDados.AdicionarParametros("@SOBRENOME", pessoa.Sobrenome);
                acessoDados.AdicionarParametros("@CPF", pessoa.CPF);
                acessoDados.AdicionarParametros("@DOC", pessoa.Doc);
                acessoDados.AdicionarParametros("@DATA_NASC", pessoa.Data_Nasc);
                acessoDados.AdicionarParametros("@EMAIL", pessoa.Email);
                acessoDados.AdicionarParametros("@PAI", pessoa.Pai);
                acessoDados.AdicionarParametros("@MAE", pessoa.Mae);
                acessoDados.AdicionarParametros("@SEXO", pessoa.Sexo);
                acessoDados.AdicionarParametros("@ID_USUARIO", pessoa.Id_Usuario);

                string idPessoa = acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "USP_PESSOA_INSERIR").ToString();

                return idPessoa;
            }
            catch (Exception ex)
            {

                return ex.Message;
            }

        }

        public string Excluir(Pessoa pessoa)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("ID_PESSOA", pessoa.Id_Pessoa);
                acessoDados.AdicionarParametros("ID_USUARIO", pessoa.Id_Usuario);
                string IdPessoa = acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "USP_PESSOA_EXCLUIR").ToString();
                return IdPessoa;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string AtualizarporId(Pessoa pessoa)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@ID_PESSOA", pessoa.Id_Pessoa);
                acessoDados.AdicionarParametros("@ID_PROFISSAO", pessoa.Id_Profissao);
                acessoDados.AdicionarParametros("@ID_TIPODOC", pessoa.Id_TipoDoc);
                acessoDados.AdicionarParametros("@ID_ESTADO_CIVIL", pessoa.Id_EstadoCivil);
                acessoDados.AdicionarParametros("@NOME", pessoa.Nome);
                acessoDados.AdicionarParametros("@SOBRENOME", pessoa.Sobrenome);
                acessoDados.AdicionarParametros("@CPF", pessoa.CPF);
                acessoDados.AdicionarParametros("@DOC", pessoa.Doc);
                acessoDados.AdicionarParametros("@DATA_NASC", pessoa.Data_Nasc);
                acessoDados.AdicionarParametros("@EMAIL", pessoa.Email);
                acessoDados.AdicionarParametros("@PAI", pessoa.Pai);
                acessoDados.AdicionarParametros("@MAE", pessoa.Mae);
                acessoDados.AdicionarParametros("@SEXO", pessoa.Sexo);
                acessoDados.AdicionarParametros("@ID_USUARIO", pessoa.Id_Usuario);

                string idPessoa = acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "USP_PESSOA_ATUALIZARPORID").ToString();

                return idPessoa;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public PessoaColecao ConsultarPorDescricao(string nome)
        {
            try
            {
                PessoaColecao pessoaColecao = new PessoaColecao();

                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@NOME", nome);

                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "USP_PESSOA_CONSULTARPORNOME");

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    Pessoa pessoa = new Pessoa();

                    pessoa.Id_Pessoa = Convert.ToInt32(dataRow["ID_PESSOA"]);
                    pessoa.Id_Profissao = Convert.ToInt32(dataRow["ID_PROFISSAO"]);
                    pessoa.Id_TipoDoc = Convert.ToInt32(dataRow["ID_TIPODOC"]);
                    pessoa.Id_EstadoCivil = Convert.ToInt32(dataRow["ID_ESTADO_CIVIL"]);
                    pessoa.Nome = Convert.ToString(dataRow["NOME"]);
                    pessoa.Sobrenome = Convert.ToString(dataRow["SOBRENOME"]);
                    pessoa.CPF = Convert.ToString(dataRow["CPF"]);
                    pessoa.Doc = Convert.ToString(dataRow["DOC"]);
                    pessoa.Data_Nasc = Convert.ToDateTime(dataRow["DATA_NASC"]);
                    pessoa.Email = Convert.ToString(dataRow["EMAIL"]);
                    pessoa.Pai = Convert.ToString(dataRow["PAI"]);
                    pessoa.Mae = Convert.ToString(dataRow["MAE"]);
                    pessoa.Sexo = Convert.ToChar(dataRow["SEXO"]);
                    pessoa.Data_Cadastro = Convert.ToDateTime(dataRow["DATA_CADASTRO"]);
                    pessoa.Id_Usuario = Convert.ToInt32(dataRow["USUARIO_CAD_ALT"]);
                    pessoa.Data_Ultima_Alteracao = Convert.ToDateTime(dataRow["DATA_ULTIMA_ALTERACAO"]);

                    pessoaColecao.Add(pessoa);
                }

                return pessoaColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar Pessoa. Detalhes: " + ex.Message);
            }
        }

        public Pessoa ConsultarPorId(int id)
        {
            try
            {
                Pessoa pessoa = new Pessoa();

                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@ID", id);

                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "USP_PESSOA_CONSULTARPORID");

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    pessoa.Id_Pessoa = Convert.ToInt32(dataRow["ID_PESSOA"]);
                    pessoa.Id_Profissao = Convert.ToInt32(dataRow["ID_PROFISSAO"]);
                    pessoa.Id_TipoDoc = Convert.ToInt32(dataRow["ID_TIPODOC"]);
                    pessoa.Id_EstadoCivil = Convert.ToInt32(dataRow["ID_ESTADO_CIVIL"]);
                    pessoa.Nome = Convert.ToString(dataRow["NOME"]);
                    pessoa.Sobrenome = Convert.ToString(dataRow["SOBRENOME"]);
                    pessoa.CPF = Convert.ToString(dataRow["CPF"]);
                    pessoa.Doc = Convert.ToString(dataRow["DOC"]);
                    pessoa.Data_Nasc = Convert.ToDateTime(dataRow["DATA_NASC"]);
                    pessoa.Email = Convert.ToString(dataRow["EMAIL"]);
                    pessoa.Pai = Convert.ToString(dataRow["PAI"]);
                    pessoa.Mae = Convert.ToString(dataRow["MAE"]);
                    pessoa.Sexo = Convert.ToChar(dataRow["SEXO"]);
                    pessoa.Data_Cadastro = Convert.ToDateTime(dataRow["DATA_CADASTRO"]);
                    pessoa.Id_Usuario = Convert.ToInt32(dataRow["USUARIO_CAD_ALT"]);
                    pessoa.Data_Ultima_Alteracao = Convert.ToDateTime(dataRow["DATA_ULTIMA_ALTERACAO"]);

                }

                return pessoa;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar Pessoa. Detalhes: " + ex.Message);
            }
        }
    }
}
