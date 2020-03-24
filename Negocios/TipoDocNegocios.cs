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
    public class TipoDocNegocios
    {
        private readonly AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();
        public TipoDocColecao ConsultarPorDescricao(string descricao)
        {
            try
            {
                TipoDocColecao tipoDocColecao = new TipoDocColecao();

                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@DESCRICAO", descricao);

                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "USP_TIPO_DOC_CONSULTARPORDESCRICAO");

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    TipoDoc tipoDoc = new TipoDoc();

                    tipoDoc.Id_TipoDoc = Convert.ToInt32(dataRow["ID_TIPODOC"]);
                    tipoDoc.Descricao = Convert.ToString(dataRow["DESCRICAO"]);

                    tipoDocColecao.Add(tipoDoc);
                }

                return tipoDocColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar Profissão. Detalhes: " + ex.Message);
            }
        }

        public TipoDocColecao ConsultarPorId(int id)
        {
            try
            {
                TipoDocColecao tipoDocColecao = new TipoDocColecao();

                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@ID", id);

                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "USP_TIPO_DOC_CONSULTARPORID");

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    TipoDoc tipoDoc = new TipoDoc();

                    tipoDoc.Descricao = Convert.ToString(dataRow["DESCRICAO"]);

                    tipoDocColecao.Add(tipoDoc);
                }

                return tipoDocColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar Profissão. Detalhes: " + ex.Message);
            }
        }
    }
}
