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
   public class LaboratorioNegocios
    {
        AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();


        public string Inserir (Laboratorio laboratorio)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@ID_TIPO_LABORATORIO", laboratorio.TipoLaboratorio.Id_Tipo_Laboratorio);
                acessoDados.AdicionarParametros("@NOME",laboratorio.Nome);
                acessoDados.AdicionarParametros("@NUMERO_SALA", laboratorio.Numero_Sala);
                acessoDados.AdicionarParametros("@CAPACIDADE", laboratorio.Capacidade);
                acessoDados.AdicionarParametros("@ID_USUARIO", laboratorio.Usuario.Id_Usuario);

                string id_Laboratorio = acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "USP_LABORATORIO_INSERIR").ToString();

                return id_Laboratorio;
            }
            catch (Exception ex)
            {

                return ex.Message;
            }

        }

        public string Excluir(Laboratorio laboratorio)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@ID_LABORATORIO", laboratorio.Id_Laboratorio);
                acessoDados.AdicionarParametros("@ID_USUARIO", laboratorio.Usuario.Id_Usuario);

                string id_Laboratorio = acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "USP_LABORATORIO_EXCLUIR").ToString();

                return id_Laboratorio;
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }


    }


}
