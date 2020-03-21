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

        public PerfilMenuColecao ConsultarPorNome(string nome)
        {
            try
            {
                PerfilMenuColecao perfilColecao = new PerfilMenuColecao();

                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@NOME", nome);

                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "USP_PERFIL_CONSULTARPORNOME");

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    PerfilMenu perfilMenu = new PerfilMenu();

                    perfilMenu.Id_Perfil = Convert.ToInt32(dataRow["ID"]);
                    perfilMenu.Nome = Convert.ToString(dataRow["NOME"]);
                    perfilMenu.Btn_Cadastrar = Convert.ToBoolean(dataRow["MENU_CADASTRAR"]);
                    perfilMenu.Btn_Excluir = Convert.ToBoolean(dataRow["MENU_EXCLUIR"]);

                    perfilColecao.Add(perfilMenu);
                }

                return perfilColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar Perfil. Detalhes" + ex.Message);
            }
        }

        public string Excluir(PerfilMenu perfilmenu)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("ID_PERFIL", perfilmenu.Id_Perfil);
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
