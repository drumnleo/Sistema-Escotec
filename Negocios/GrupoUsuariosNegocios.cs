using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcessoBandoDados;
using ObjetoTransferencia;
using System.Data;

namespace Negocios
{
    public class GrupoUsuariosNegocios
    {

        AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();

        public string Inserir(GrupoTipo grupoTipo)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@NOME", grupoTipo.NOME);
                acessoDados.AdicionarParametros("@ID_PERFIL", grupoTipo.ID_PERFIL);


                string idGrupo = acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "USP_GRUPO_INSERIR").ToString();

                return idGrupo;
            }
            catch (Exception ex)
            {

                return ex.Message;
            }

        }

        public GrupoColecao ConsultarPorNome(string nome)
        {
            try
            {
                GrupoColecao grupoColecao = new GrupoColecao();

                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@NOME", nome);

                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "USP_GRUPO_CONSULTARPORNOME");

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    GrupoTipo grupoTipo = new GrupoTipo();

                    grupoTipo.ID_GRUPO = Convert.ToInt32(dataRow["ID_GRUPO"]);
                    grupoTipo.ID_PERFIL = Convert.ToInt32(dataRow["ID_PERFIL"]);
                    grupoTipo.NOME = Convert.ToString(dataRow["NOME"]);

                    grupoColecao.Add(grupoTipo);
                }

                return grupoColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar Perfil. Detalhes" + ex.Message);
            }
        }

        public GrupoColecao ConsultarTodos()
        {
            try
            {
                GrupoColecao grupoColecao = new GrupoColecao();

                acessoDados.LimparParametros();

                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "USP_GRUPO_CONSULTARTODOS");

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    GrupoTipo grupoTipo = new GrupoTipo();

                    grupoTipo.ID_GRUPO = Convert.ToInt32(dataRow["ID_GRUPO"]);
                    grupoTipo.ID_PERFIL = Convert.ToInt32(dataRow["ID_PERFIL"]);
                    grupoTipo.NOME = Convert.ToString(dataRow["NOME"]);

                    grupoColecao.Add(grupoTipo);
                }

                return grupoColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar grupo. Detalhes" + ex.Message);
            }
        }
        public string Excluir(GrupoTipo grupoTipo)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("ID_GRUPO", grupoTipo.ID_GRUPO);
                string idperfil = acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "USP_GRUPO_EXCLUIR").ToString();
                return idperfil;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }


}
