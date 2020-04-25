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
                acessoDados.AdicionarParametros("@ID_PERFIL", grupoTipo.PerfilAcesso.Id_Perfil);


                string idGrupo = acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "USP_GRUPO_INSERIR").ToString();

                return idGrupo;
            }
            catch (Exception ex)
            {

                return ex.Message;
            }

        }

        public GrupoUsuarioColecao ConsultarPorNome(string nome)
        {
            try
            {
                GrupoUsuarioColecao grupoUsuarioColecao = new GrupoUsuarioColecao();

                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@NOME", nome);

                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "USP_GRUPO_CONSULTARPORNOME");

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    GrupoUsuario grupoUsuario = new GrupoUsuario();

                    grupoUsuario.Id_Grupo = Convert.ToInt32(dataRow["ID_GRUPO"]);
                    grupoUsuario.Nome = Convert.ToString(dataRow["NOME"]);
                    grupoUsuario.Data_Cadastro = Convert.ToDateTime(dataRow["DATA_CADASTRO"]);
                    grupoUsuario.Data_Ultima_Alteracao = Convert.ToDateTime(dataRow["DATA_ULTIMA_ALTERACAO"]);

                    PerfilAcesso perfilAcesso = new PerfilAcesso();
                    perfilAcesso.Id_Perfil = Convert.ToInt32(dataRow["ID_PERFIL"]);

                    Usuario usuarioCadAlt = new Usuario();
                    if (dataRow["USUARIO_CAD_ALT"].ToString() != "")
                    {
                        usuarioCadAlt.Id_Usuario = Convert.ToInt32(dataRow["USUARIO_CAD_ALT"]);
                    }
                    
                    grupoUsuario.PerfilAcesso = perfilAcesso;
                    grupoUsuario.Usuario = usuarioCadAlt;
                    grupoUsuarioColecao.Add(grupoUsuario);
                }
                return grupoUsuarioColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar Grupo. Detalhes" + ex.Message);
            }
        }

        public GrupoUsuarioColecao ConsultarPorId(int id)
        {
            try
            {
                GrupoUsuarioColecao grupoUsuarioColecao = new GrupoUsuarioColecao();

                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@ID_GRUPO", id);

                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "USP_GRUPO_CONSULTARPORID");

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    GrupoUsuario grupoUsuario = new GrupoUsuario();

                    grupoUsuario.Id_Grupo = Convert.ToInt32(dataRow["ID_GRUPO"]);
                    grupoUsuario.Nome = Convert.ToString(dataRow["NOME"]);
                    grupoUsuario.Data_Cadastro = Convert.ToDateTime(dataRow["DATA_CADASTRO"]);
                    grupoUsuario.Data_Ultima_Alteracao = Convert.ToDateTime(dataRow["DATA_ULTIMA_ALTERACAO"]);

                    PerfilAcesso perfilAcesso = new PerfilAcesso();
                    perfilAcesso.Id_Perfil = Convert.ToInt32(dataRow["ID_PERFIL"]);

                    Usuario usuarioCadAlt = new Usuario();
                    if (dataRow["USUARIO_CAD_ALT"].ToString() != "")
                    {
                        usuarioCadAlt.Id_Usuario = Convert.ToInt32(dataRow["USUARIO_CAD_ALT"]);
                    }

                    grupoUsuario.PerfilAcesso = perfilAcesso;
                    grupoUsuario.Usuario = usuarioCadAlt;
                    grupoUsuarioColecao.Add(grupoUsuario);
                }
                return grupoUsuarioColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar Grupo. Detalhes" + ex.Message);
            }
        }

        public string Excluir(GrupoUsuario grupoUsuario)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("ID_GRUPO", grupoUsuario.Id_Grupo);
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
