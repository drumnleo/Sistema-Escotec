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
    public class PerfilNegocios
    {
        AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();

        //Inserir
        public string Inserir(PerfilMenu perfilTipo)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@NOME", perfilTipo.Nome);
                acessoDados.AdicionarParametros("@BTNCADASTRAR", perfilTipo.Btn_Cadastrar);
                acessoDados.AdicionarParametros("@BTNEXCLUIR", perfilTipo.Btn_Excluir);

                string idPerfil = acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "USP_PERFIL_INSERIR").ToString();

                return idPerfil;
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
                    PerfilMenu perfilTipo = new PerfilMenu();

                    perfilTipo.Id_Perfil = Convert.ToInt32(dataRow["ID"]);
                    perfilTipo.Nome = Convert.ToString(dataRow["NOME"]);
                    perfilTipo.Btn_Cadastrar = Convert.ToBoolean(dataRow["MENU_CADASTRAR"]);
                    perfilTipo.Btn_Excluir = Convert.ToBoolean(dataRow["MENU_EXCLUIR"]);

                    perfilColecao.Add(perfilTipo);
                }

                return perfilColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar Perfil. Detalhes" + ex.Message);
            }
        }

        public string Excluir(PerfilMenu perfilMenu)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("ID_PERFIL", perfilMenu.Id_Perfil);
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
