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
                acessoDados.AdicionarParametros("@ID_PESSOA", endereco.Pessoa.Id_Pessoa);
                acessoDados.AdicionarParametros("@LOGRADOURO", endereco.Logradouro);
                acessoDados.AdicionarParametros("@NUMERO", endereco.Numero);
                acessoDados.AdicionarParametros("@COMPLEMENTO", endereco.Complemento);
                acessoDados.AdicionarParametros("@BAIRRO", endereco.Bairro);
                acessoDados.AdicionarParametros("@CIDADE", endereco.Cidade);
                acessoDados.AdicionarParametros("@ESTADO", endereco.Estado);
                acessoDados.AdicionarParametros("@UF", endereco.UF);
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
                acessoDados.AdicionarParametros("@ID_PESSOA", endereco.Pessoa.Id_Pessoa);
                acessoDados.AdicionarParametros("@LOGRADOURO", endereco.Logradouro);
                acessoDados.AdicionarParametros("@NUMERO", endereco.Numero);
                acessoDados.AdicionarParametros("@COMPLEMENTO", endereco.Complemento);
                acessoDados.AdicionarParametros("@BAIRRO", endereco.Bairro);
                acessoDados.AdicionarParametros("@CIDADE", endereco.Cidade);
                acessoDados.AdicionarParametros("@ESTADO", endereco.Estado);
                acessoDados.AdicionarParametros("@UF", endereco.UF);
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

        public EnderecoColecao ConsultarPorCpf(string cpf )
        {
            try
            {
                EnderecoColecao enderecoColecao = new EnderecoColecao();

                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@CPF", cpf);

                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "USP_ENDERECO_CONSUTARPORPESSOA");

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    Endereco endereco = new Endereco();

                    endereco.Id_Endereco = Convert.ToInt32(dataRow["ID_ENDERECO"]);
                    endereco.Logradouro = Convert.ToString(dataRow["LOGRADOURO"]);
                    endereco.Numero = Convert.ToInt16(dataRow["NUMERO"]);
                    endereco.Complemento = Convert.ToString(dataRow["COMPLEMENTO"]);
                    endereco.Bairro = Convert.ToString(dataRow["BAIRRO"]);
                    endereco.Cidade = Convert.ToString(dataRow["CIDADE"]);
                    endereco.Estado = Convert.ToString(dataRow["ESTADO"]);
                    endereco.UF = Convert.ToString(dataRow["UF"]);
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

        public EnderecoColecao ConsultarPorId(int id)
        {
            try
            {
                EnderecoColecao enderecoColecao = new EnderecoColecao();

                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@ID_ENDERECO", id);

                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "USP_ENDERECO_CONSUTARPORID");

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    Endereco endereco = new Endereco();

                    endereco.Id_Endereco = Convert.ToInt32(dataRow["ID_ENDERECO"]);
                    endereco.Logradouro = Convert.ToString(dataRow["LOGRADOURO"]);
                    endereco.Numero = Convert.ToInt16(dataRow["NUMERO"]);
                    endereco.Complemento = Convert.ToString(dataRow["COMPLEMENTO"]);
                    endereco.Bairro = Convert.ToString(dataRow["BAIRRO"]);
                    endereco.Cidade = Convert.ToString(dataRow["CIDADE"]);
                    endereco.Estado = Convert.ToString(dataRow["ESTADO"]);
                    endereco.UF = Convert.ToString(dataRow["UF"]);
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

        public EnderecoColecao ConsultarPorIdPessoa(int id)
        {
            try
            {
                EnderecoColecao enderecoColecao = new EnderecoColecao();

                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@ID_PESSOA", id);

                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "USP_ENDERECO_CONSUTARPORIDPESSOA");

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    Endereco endereco = new Endereco();

                    endereco.Id_Endereco = Convert.ToInt32(dataRow["ID_ENDERECO"]);
                    endereco.Logradouro = Convert.ToString(dataRow["LOGRADOURO"]);
                    endereco.Numero = Convert.ToInt16(dataRow["NUMERO"]);
                    endereco.Complemento = Convert.ToString(dataRow["COMPLEMENTO"]);
                    endereco.Bairro = Convert.ToString(dataRow["BAIRRO"]);
                    endereco.Cidade = Convert.ToString(dataRow["CIDADE"]);
                    endereco.Estado = Convert.ToString(dataRow["ESTADO"]);
                    endereco.UF = Convert.ToString(dataRow["UF"]);
                    endereco.CEP = Convert.ToString(dataRow["CEP"]);
                    endereco.Data_Cadastro = Convert.ToDateTime(dataRow["DATA_CADASTRO"]);
                    endereco.Data_Ultima_Alteracao = Convert.ToDateTime(dataRow["DATA_ULTIMA_ALTERACAO"]);

                    Usuario usuario = new Usuario();

                    usuario.Id_Usuario = Convert.ToInt32(dataRow["USUARIO_CAD_ALT"]);

                    Pessoa pessoa = new Pessoa();

                    pessoa.Id_Pessoa = Convert.ToInt32(dataRow["ID_PESSOA"]);

                    endereco.Usuario = usuario;
                    endereco.Pessoa = pessoa;
                    enderecoColecao.Add(endereco);
                }

                return enderecoColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar Endereço. Detalhes: " + ex.Message);
            }
        }

        public EnderecoGeralColecao ConsultarPorCep(int cep)
        {
            try
            {
                EnderecoGeralColecao enderecoGeralColecao = new EnderecoGeralColecao();

                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@CEP", cep);

                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "USP_ENDERECOGERAL_CONSULTA_PORCEP");

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    EnderecoGeral enderecoGeral = new EnderecoGeral();

                    enderecoGeral.CEP = Convert.ToInt32(dataRow["CEP"]);
                    enderecoGeral.Rua = Convert.ToString(dataRow["RUA"]);
                    enderecoGeral.Bairro = Convert.ToString(dataRow["BAIRRO"]);
                    enderecoGeral.Cidade = Convert.ToString(dataRow["CIDADE"]);
                    enderecoGeral.Estado = Convert.ToString(dataRow["ESTADO"]);
                    enderecoGeral.Uf = Convert.ToString(dataRow["UF"]);

                    enderecoGeralColecao.Add(enderecoGeral);
                }

                return enderecoGeralColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar Endereço. Detalhes: " + ex.Message);
            }
        }

        public EstadoColecao ConsultarEstadoPorNome(string nome)
        {
            try
            {
                EstadoColecao estadoColecao = new EstadoColecao();

                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@ESTADO", nome);

                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "USP_ESTADO_CONSULTARPORNOME");

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    Estado estado = new Estado();

                    estado.Id_Estado = Convert.ToInt32(dataRow["ID_ESTADO"]);
                    estado.Nome_Estado = Convert.ToString(dataRow["NOME_ESTADO"]);
                    estado.Abreviacao = Convert.ToString(dataRow["ABREVIACAO"]);

                    estadoColecao.Add(estado);
                }

                return estadoColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar Estado. Detalhes: " + ex.Message);
            }
        }

    }
}
