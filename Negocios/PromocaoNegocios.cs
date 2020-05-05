using AcessoBandoDados;
using ObjetoTransferencia;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class PromocaoNegocios
    {
        AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();

        public string Inserir(PromocaoValor promocaoValor)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@NOME_PROMOCAO", promocaoValor.Nome_Promocao);
                acessoDados.AdicionarParametros("@VALIDADE", promocaoValor.Validade);
                acessoDados.AdicionarParametros("@ENTRADA", promocaoValor.Entrada);
                acessoDados.AdicionarParametros("@DESCONTO_ENTRADA", promocaoValor.Desconto_Entrada);
                acessoDados.AdicionarParametros("@VALOR_ENTRADA", promocaoValor.Valor_Entrada);
                acessoDados.AdicionarParametros("@DESCONTO_DEMAIS", promocaoValor.Desconto_Demais);
                acessoDados.AdicionarParametros("@ID_USUARIO", promocaoValor.Usuario.Id_Usuario);

                string idPromocaoValor = acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "USP_PROMOCAO_VALOR_INSERIR").ToString();

                return idPromocaoValor;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Atualizar(PromocaoValor promocaoValor)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@ID_PROMOCAO_VALOR", promocaoValor.Id_Promocao_Valor);
                acessoDados.AdicionarParametros("@NOME_PROMOCAO", promocaoValor.Nome_Promocao);
                acessoDados.AdicionarParametros("@VALIDADE", promocaoValor.Validade);
                acessoDados.AdicionarParametros("@ENTRADA", promocaoValor.Entrada);
                acessoDados.AdicionarParametros("@DESCONTO_ENTRADA", promocaoValor.Desconto_Entrada);
                acessoDados.AdicionarParametros("@VALOR_ENTRADA", promocaoValor.Valor_Entrada);
                acessoDados.AdicionarParametros("@DESCONTO_DEMAIS", promocaoValor.Desconto_Demais);
                acessoDados.AdicionarParametros("@ID_USUARIO", promocaoValor.Usuario.Id_Usuario);

                string idPromocaoValor = acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "USP_PROMOCAO_VALOR_ATUALIZARPORID").ToString();

                return idPromocaoValor;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public PromocaoValorColecao ConsultarPorNome(string nome)
        {
            try
            {
                PromocaoValorColecao promocaoValorColecao = new PromocaoValorColecao();

                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@NOME_PROMOCAO", nome);

                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "USP_PROMOCAO_VALOR_CONSULTARPORNOME");

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    PromocaoValor promocaoValor = new PromocaoValor();

                    promocaoValor.Id_Promocao_Valor = Convert.ToInt32(dataRow["ID_PROMOCAO_VALOR"]);
                    promocaoValor.Nome_Promocao = Convert.ToString(dataRow["NOME_PROMOCAO"]);
                    promocaoValor.Validade = Convert.ToDateTime(dataRow["VALIDADE"]);
                    promocaoValor.Entrada = Convert.ToBoolean(dataRow["ENTRADA"]);
                    promocaoValor.Desconto_Entrada = Convert.ToInt16(dataRow["DESCONTO_ENTRADA"]);
                    promocaoValor.Valor_Entrada = Convert.ToDecimal(dataRow["VALOR_ENTRADA"]);
                    promocaoValor.Desconto_Demais = Convert.ToInt16(dataRow["DESCONTO_DEMAIS"]);
                    promocaoValor.Data_Cadastro = Convert.ToDateTime(dataRow["DATA_CADASTRO"]);
                    promocaoValor.Data_Ultima_Alteracao = Convert.ToDateTime(dataRow["DATA_ULTIMA_ALTERACAO"]);

                    Usuario usuario = new Usuario();
                    usuario.Id_Usuario = Convert.ToInt32(dataRow["USUARIO_CAD_ALT"]);

                    promocaoValor.Usuario = usuario;
                    promocaoValorColecao.Add(promocaoValor);
                }

                return promocaoValorColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar Promoção. Detalhes: " + ex.Message);
            }
        }
    }
}
