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
    public class TipoLaboratorioNegocios
    {
        AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();

        //Inserir

        public string Inserir(TipoLaboratorio tipoLaboratorio)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@TIPO", tipoLaboratorio.Tipo);
                acessoDados.AdicionarParametros("@DESCRICAO", tipoLaboratorio.Descricao);
                acessoDados.AdicionarParametros("@ID_USUARIO", tipoLaboratorio.Usuario.Id_Usuario);

                string IdTipoLaboratorio = acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "USP_TIPO_LABORATORIO_INSERIR").ToString();

                return IdTipoLaboratorio;
            }
            catch (Exception ex)
            {

                return ex.Message;
            }


        }
        public string Excluir(TipoLaboratorio tipoLaboratorio)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@ID_TIPO_LABORATORIO", tipoLaboratorio.Id_Tipo_Laboratorio);
                acessoDados.AdicionarParametros("@ID_USUARIO", tipoLaboratorio.Usuario.Id_Usuario);

                string IdTipoLaboratorio = acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "USP_TIPO_LABORATORIO_EXCLUIR").ToString();
                return IdTipoLaboratorio;
            }


            catch (Exception ex)

            {

                return ex.Message;
            }
        }


    }
}
