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
    public class FeriadoNegocios
    {
        AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();

        //Inserir

        public string Inserir(Feriado feriado)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@NOME_FERIADO", feriado.Nome_Feriado);
                acessoDados.AdicionarParametros("@DATA_FERIADO", feriado.Data_Cadastro);
                acessoDados.AdicionarParametros("@ID_USUARIO",feriado.Usuario.Id_Usuario);

                string IdFeriado = acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "USP_FERIADO_INSERIR").ToString();

                return IdFeriado;
            }
            catch (Exception ex)
            {

                return ex.Message;
            }


        }
        public string Excluir(Feriado feriado)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@ID_FERIADO",feriado.Id_Feriado);
                acessoDados.AdicionarParametros("@ID_USUARIO", feriado.Usuario.Id_Usuario);

                string id_cargo = acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "USP_FERIADO_EXCLUIR").ToString();
                return id_cargo;
            }


            catch (Exception ex)

            {

                return ex.Message;
            }
        }


    }
}
