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
    public class ProfissaoNegocios
    {
        private readonly AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();
        public ProfissaoColecao ConsultarPorDescricao(string profissaonome)
        {
            try
            {
                ProfissaoColecao profissaoColecao = new ProfissaoColecao();

                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@PROFISSAO", profissaonome);

                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "USP_PROFISSAO_CONSULTARPORPROFISSAO");

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    Profissao profissao = new Profissao();

                    profissao.Id_Profissao = Convert.ToInt32(dataRow["ID_PROFISSAO"]);
                    profissao.CBO = Convert.ToInt32(dataRow["CBO"]);
                    profissao.Nome_Profissao = Convert.ToString(dataRow["PROFISSAO"]);
                    profissao.Data_Cadastro = Convert.ToDateTime(dataRow["DATA_CADASTRO"]);

                    profissaoColecao.Add(profissao);
                }

                return profissaoColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar Profissão. Detalhes" + ex.Message);
            }
        }

        public ProfissaoColecao ConsultarPorId(int id)
        {
            try
            {
                ProfissaoColecao profissaoColecao = new ProfissaoColecao();

                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@ID", id);

                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "USP_PROFISSAO_CONSULTARPORID");

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    Profissao profissao = new Profissao();

                    profissao.Id_Profissao = Convert.ToInt32(dataRow["ID_PROFISSAO"]);
                    profissao.CBO = Convert.ToInt32(dataRow["CBO"]);
                    profissao.Nome_Profissao = Convert.ToString(dataRow["PROFISSAO"]);
                    profissao.Data_Cadastro = Convert.ToDateTime(dataRow["DATA_CADASTRO"]);

                    profissaoColecao.Add(profissao);
                }

                return profissaoColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar Profissão. Detalhes" + ex.Message);
            }
        }
    }
}
