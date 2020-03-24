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

        public PessoaColecao ConsultarPorId(int id)
        {
            try
            {
                PessoaColecao pessoaColecao = new PessoaColecao();

                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@ID", id);

                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "USP_PESSOA_CONSULTARPORID");

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
    }
}
