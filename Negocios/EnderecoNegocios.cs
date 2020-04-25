using System;
using ObjetoTransferencia;
using AcessoBandoDados;
using System.Data;

namespace Negocios
{
    public class EnderecoNegocios
    {
        private readonly AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();

        public string Inserir(Endereco endereco)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@LOGRADOURO", endereco.Lograduro);
                acessoDados.AdicionarParametros("@NUMERO", endereco.Numero);
                acessoDados.AdicionarParametros("@COMPLEMENTO", endereco.Complemento);
                acessoDados.AdicionarParametros("@BAIRRO", endereco.Bairro);
                acessoDados.AdicionarParametros("@CIDADE", endereco.Cidade);
                acessoDados.AdicionarParametros("@ESTADO", endereco.Estado);
                acessoDados.AdicionarParametros("@CEP", endereco.CEP);
                acessoDados.AdicionarParametros("@ID_USUARIO", endereco.Usuario.Id_Usuario);


                string idEndereco = acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "USP_ENDERECO_INSERIR").ToString();

                return idEndereco;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public string AtualizarporId(Endereco endereco)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@ID_ENDERECO", endereco.Id_Endereco);
                acessoDados.AdicionarParametros("@LOGRADOURO", endereco.Lograduro);
                acessoDados.AdicionarParametros("@NUMERO", endereco.Numero);
                acessoDados.AdicionarParametros("@COMPLEMENTO", endereco.Complemento);
                acessoDados.AdicionarParametros("@BAIRRO", endereco.Bairro);
                acessoDados.AdicionarParametros("@CIDADE", endereco.Cidade);
                acessoDados.AdicionarParametros("@ESTADO", endereco.Estado);
                acessoDados.AdicionarParametros("@CEP", endereco.CEP);
                acessoDados.AdicionarParametros("@ID_USUARIO", endereco.Usuario.Id_Usuario);

                string idEndereco = acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "USP_ENDERECO_ATUALIZARPORID").ToString();

                return idEndereco;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Excluir(Endereco endereco)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("ID_ENDERECO", endereco.Id_Endereco);
                acessoDados.AdicionarParametros("ID_USUARIO", endereco.Usuario.Id_Usuario);
                string idEndereco = acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "USP_ENDERECO_EXCLUIR").ToString();
                return idEndereco;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public EnderecoColecao ConsultarPorPessoa(int idPessoa )
        {
            try
            {
                EnderecoColecao enderecoColecao = new EnderecoColecao();

                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@ID_PESSOA", idPessoa);

                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "USP_ENDERECO_CONSUTARPORPESSOA");

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    Endereco endereco = new Endereco();

                    endereco.Id_Endereco = Convert.ToInt32(dataRow["ID_ENDERECO"]);
                    endereco.Lograduro = Convert.ToString(dataRow["LOGRADOURO"]);
                    endereco.Numero = Convert.ToInt16(dataRow["NUMERO"]);
                    endereco.Complemento = Convert.ToString(dataRow["COMPLEMENTO"]);
                    endereco.Bairro = Convert.ToString(dataRow["BAIRRO"]);
                    endereco.Cidade = Convert.ToString(dataRow["CIDADE"]);
                    endereco.Estado = Convert.ToString(dataRow["ESTADO"]);
                    endereco.CEP = Convert.ToString(dataRow["CEP"]);
                    endereco.Data_Cadastro = Convert.ToDateTime(dataRow["DATA_CADASTRO"]);
                    endereco.Data_Ultima_Alteracao = Convert.ToDateTime(dataRow["DATA_ULTIMA_ALTERACAO"]);

                    Usuario usuario = new Usuario();

                    usuario.Id_Usuario = Convert.ToInt32(dataRow["USUARIO_CAD_ALT"]);

                    endereco.Usuario = usuario;
                    enderecoColecao.Add(endereco);
                }

                return enderecoColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar Endereço. Detalhes: " + ex.Message);
            }
        }
    }
}
