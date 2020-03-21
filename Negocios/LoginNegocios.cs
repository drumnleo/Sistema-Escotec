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
    public class LoginNegocios
    {
        AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();

        //Login
        public string Login(string nome, string senha)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@USUARIO", nome);
                acessoDados.AdicionarParametros("@SENHA", senha);


                string retorno = acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "USP_USUARIO_LOGIN").ToString();

                return retorno;
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
            
        }

        public PerfilTipoColecao ConsultarPorNome(string nome)
        {
            try
            {
                PerfilTipoColecao perfilColecao = new PerfilTipoColecao();

                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@NOME", nome);

                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "USP_PERFIL_CONSULTARPORNOME");

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    PerfilTipo perfilTipo = new PerfilTipo();

                    perfilTipo.Id_PerfilTipo = Convert.ToInt32(dataRow["ID"]);
                    perfilTipo.Nome = Convert.ToString(dataRow["NOME"]);
                    perfilTipo.BtnCadastrar = Convert.ToBoolean(dataRow["MENU_CADASTRAR"]);
                    perfilTipo.BtnConsultar = Convert.ToBoolean(dataRow["MENU_CONSULTAR"]);
                    perfilTipo.BtnExcluir = Convert.ToBoolean(dataRow["MENU_EXCLUIR"]);

                    perfilColecao.Add(perfilTipo);
                }

                return perfilColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar Perfil. Detalhes" + ex.Message);
            }
        }

        public string Excluir(PerfilTipo perfil)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("ID_PERFIL", perfil.Id_PerfilTipo);
                string idperfil = acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "USP_PERFIL_EXCLUIR").ToString();
                return idperfil;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

    }
}
