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

        public string AtualizarporId(TipoLaboratorio tipoLaboratorio)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@ID_TIPO_LABORATORIO", tipoLaboratorio.Id_Tipo_Laboratorio);
                acessoDados.AdicionarParametros("@TIPO", tipoLaboratorio.Tipo);
                acessoDados.AdicionarParametros("@DESCRICAO", tipoLaboratorio.Descricao);
                acessoDados.AdicionarParametros("@ID_USUARIO", tipoLaboratorio.Usuario.Id_Usuario);


                string idTipoLaboratorio = acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "USP_TIPO_LABORATORIO_ATUALIZARPORID").ToString();

                return idTipoLaboratorio;
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

        public TipoLaboratorioColecao ConsultarPorTipo(string tipo)
        {
            try
            {
                TipoLaboratorioColecao tipoLaboratorioColecao = new TipoLaboratorioColecao();

                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@TIPO", tipo);

                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "USP_TIPO_LABORATORIO_CONSULTAR_PORTIPO");

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    TipoLaboratorio tipoLaboratorio = new TipoLaboratorio();

                    tipoLaboratorio.Id_Tipo_Laboratorio = Convert.ToInt32(dataRow["ID_TIPO"]);
                    tipoLaboratorio.Tipo = Convert.ToString(dataRow["TIPO"]);
                    tipoLaboratorio.Descricao = Convert.ToString(dataRow["DESCRICAO"]);
                    tipoLaboratorio.Data_Cadastro = Convert.ToDateTime(dataRow["DATA_CADASTRO"]);
                    tipoLaboratorio.Data_Ultima_Alteracao = Convert.ToDateTime(dataRow["DATA_ULTIMA_ALTERACAO"]);

                    Usuario usuario = new Usuario();

                    usuario.Id_Usuario = Convert.ToInt32(dataRow["USUARIO_CAD_ALT"]);

                    tipoLaboratorio.Usuario = usuario;
                    tipoLaboratorioColecao.Add(tipoLaboratorio);
                }

                return tipoLaboratorioColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar Tipo de Laboratório. Detalhes: " + ex.Message);
            }
        }


    }
}
