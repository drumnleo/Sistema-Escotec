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

        public static Usuario UsuarioLogadoGetSet { get; set; }

    }
}
