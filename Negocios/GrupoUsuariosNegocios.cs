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

        public string Inserir(GrupoUsuario grupoTipo)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@NOME", grupoTipo.Nome);
                acessoDados.AdicionarParametros("@ID_PERFIL", grupoTipo.perfilMenu.Id_Perfil);


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
                    GrupoUsuario grupoTipo = new GrupoUsuario();

                    grupoTipo.Id_Grupo = Convert.ToInt32(dataRow["ID_GRUPO"]);
                    grupoTipo.perfilMenu.Id_Perfil = Convert.ToInt32(dataRow["ID_PERFIL"]);
                    grupoTipo.Nome = Convert.ToString(dataRow["NOME"]);

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
                    GrupoUsuario grupoTipo = new GrupoUsuario();

                    grupoTipo.Id_Grupo = Convert.ToInt32(dataRow["ID_GRUPO"]);
                    grupoTipo.perfilMenu.Id_Perfil = Convert.ToInt32(dataRow["ID_PERFIL"]);
                    grupoTipo.Nome = Convert.ToString(dataRow["NOME"]);

                    grupoColecao.Add(grupoTipo);
                }

                return grupoColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar grupo. Detalhes" + ex.Message);
            }
        }
        public string Excluir(GrupoUsuario grupoTipo)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("ID_GRUPO", grupoTipo.Id_Grupo);
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
