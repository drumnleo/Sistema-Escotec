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
    public class TipoAtendimentoNegocios
    {
        AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();

        public TipoAtendimentoColecao ConsultarPorDescricao(string descricao)
        {
            try
            {
                TipoAtendimentoColecao tipoAtendimentoColecao = new TipoAtendimentoColecao();

                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@DESCRICAO", descricao);

                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "USP_TIPO_ATENDIMENTO_CONSULTAPORDESCRICAO");

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    TipoAtendimento tipoAtendimento = new TipoAtendimento();

                    tipoAtendimento.Id_Tipo_Atendimento = Convert.ToInt32(dataRow["ID_TIPO_ATENDIMENTO"]);
                    tipoAtendimento.Descricao = Convert.ToString(dataRow["DESCRICAO"]);
                    tipoAtendimento.Data_cadastro = Convert.ToDateTime(dataRow["DATA_CADASTRO"]);
                    tipoAtendimento.Data_Ultima_Alt = Convert.ToDateTime(dataRow["DATA_ULTIMA_ALTERACAO"]);

                    Usuario usuario = new Usuario();
                    usuario.Id_Usuario = Convert.ToInt32(dataRow["USUARIO_CAD_ALT"]);

                    tipoAtendimento.Usuario = usuario;
                    tipoAtendimentoColecao.Add(tipoAtendimento);
                }

                return tipoAtendimentoColecao;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao consultar aluno. Detalhes: " + ex.Message);
            }
        }
    }
}
