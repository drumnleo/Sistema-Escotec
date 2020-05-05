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
    public class AtendimentoNegocios
    {
        AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();

        public string Inserir(Atendimento atendimento)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("ID_TIPO_ATENDIMENTO", atendimento.TipoAtendimento.Id_Tipo_Atendimento);
                acessoDados.AdicionarParametros("ID_PESSOA", atendimento.Pessoa.Id_Pessoa);
                acessoDados.AdicionarParametros("ID_MKT", atendimento.Marketing.Id_Mkt);
                acessoDados.AdicionarParametros("RECEPTIVO", atendimento.Receptivo);
                acessoDados.AdicionarParametros("OBSERVACAO", atendimento.Observacao);
                acessoDados.AdicionarParametros("ID_USUARIO", atendimento.Usuario.Id_Usuario);

                string idAtendimento = acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "USP_ATENDIMENTO_INSERIR").ToString();

                return idAtendimento;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Atualizar(Atendimento atendimento)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("ID_ATENDIMENTO", atendimento.Id_Atendimento);
                acessoDados.AdicionarParametros("ID_TIPO_ATENDIMENTO", atendimento.TipoAtendimento.Id_Tipo_Atendimento);
                acessoDados.AdicionarParametros("ID_PESSOA", atendimento.Pessoa.Id_Pessoa);
                acessoDados.AdicionarParametros("ID_MKT", atendimento.Marketing.Id_Mkt);
                acessoDados.AdicionarParametros("RECEPTIVO", atendimento.Receptivo);
                acessoDados.AdicionarParametros("OBSERVACAO", atendimento.Observacao);
                acessoDados.AdicionarParametros("ID_USUARIO", atendimento.Usuario.Id_Usuario);

                string idAtendimento = acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "USP_ATENDIMENTO_INSERIR").ToString();

                return idAtendimento;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public AtendimentoColecao ConsultarPorIdPessoa(int id)
        {
            try
            {
                AtendimentoColecao atendimentoColecao = new AtendimentoColecao();

                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@ID_PESSOA", id);

                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "USP_ATENDIMENTO_CUNSULTAPORIDPESSOA");

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    Atendimento atendimento = new Atendimento();

                    atendimento.Id_Atendimento = Convert.ToInt32(dataRow["ID_ATENDIMENTO"]);
                    atendimento.Receptivo = Convert.ToChar(dataRow["RECEPTIVO"]);
                    atendimento.Observacao = Convert.ToString(dataRow["OBSERVACAO"]);
                    atendimento.Data_Cadastro = Convert.ToDateTime(dataRow["DATA_CADASTRO"]);
                    atendimento.Data_Ultima_Alteracao = Convert.ToDateTime(dataRow["DATA_ULTIMA_ALTERACAO"]);

                    TipoAtendimento tipoAtendimento = new TipoAtendimento();
                    tipoAtendimento.Id_Tipo_Atendimento = Convert.ToInt32(dataRow["ID_TIPO_ATENDIMENTO"]);
                    tipoAtendimento.Descricao = Convert.ToString(dataRow["TIPO_ATENDIMENTO_DESCRICAO"]);

                    Pessoa pessoa = new Pessoa();
                    pessoa.Id_Pessoa = Convert.ToInt32(dataRow["ID_PESSOA"]);

                    Marketing marketing = new Marketing();
                    marketing.Id_Mkt = Convert.ToInt32(dataRow["ID_MKT"]);
                    marketing.Descricao = Convert.ToString(dataRow["MARKETING_DESCRICAO"]);

                    atendimento.TipoAtendimento = tipoAtendimento;
                    atendimento.Pessoa = pessoa;
                    atendimento.Marketing = marketing;

                    atendimentoColecao.Add(atendimento);
                }

                return atendimentoColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar Atendimento. Detalhes: " + ex.Message);
            }
        }
    }
}
