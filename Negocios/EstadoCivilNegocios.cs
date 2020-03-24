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
    public class EstadoCivilNegocios
    {
        private readonly AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();
        public EstadoCivilColecao ConsultarPorDescricao(string descricao)
        {
            try
            {
                EstadoCivilColecao estadoCivilColecao = new EstadoCivilColecao();

                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@DESCRICAO", descricao);

                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "USP_ESTADO_CIVIL_CONSULTARPORDESCRICAO");

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    EstadoCivil estadoCivil = new EstadoCivil();

                    estadoCivil.Id_EstadoCivil = Convert.ToInt32(dataRow["ID_ESTADOCIVIL"]);
                    estadoCivil.Descricao = Convert.ToString(dataRow["DESCRICAO"]);

                    estadoCivilColecao.Add(estadoCivil);
                }

                return estadoCivilColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar Estado Civil. Detalhes" + ex.Message);
            }
        }

        public EstadoCivilColecao ConsultarPorId(int id)
        {
            try
            {
                EstadoCivilColecao estadoCivilColecao = new EstadoCivilColecao();

                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@ID", id);

                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "USP_ESTADO_CIVIL_CONSULTARPORID");

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    EstadoCivil estadoCivil = new EstadoCivil();

                    estadoCivil.Descricao = Convert.ToString(dataRow["DESCRICAO"]);

                    estadoCivilColecao.Add(estadoCivil);
                }

                return estadoCivilColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar Estado Civil. Detalhes" + ex.Message);
            }
        }
    }
}
