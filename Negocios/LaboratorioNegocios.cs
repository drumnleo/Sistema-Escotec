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
                acessoDados.AdicionarParametros("@NOME", laboratorio.Nome);
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

        public string AtualizarporId(Laboratorio laboratorio)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@ID_LABORATORIO", laboratorio.Id_Laboratorio);
                acessoDados.AdicionarParametros("@ID_TIPO_LABORATORIO", laboratorio.TipoLaboratorio.Id_Tipo_Laboratorio);
                acessoDados.AdicionarParametros("@NOME", laboratorio.Nome);
                acessoDados.AdicionarParametros("@NUMERO_SALA", laboratorio.Numero_Sala);
                acessoDados.AdicionarParametros("@CAPACIDADE", laboratorio.Capacidade);
                acessoDados.AdicionarParametros("@ID_USUARIO", laboratorio.Usuario.Id_Usuario);

                string id_Laboratorio = acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "USP_LABORTORIO_ATUALIZAR_PORID").ToString();

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

        public LaboratorioColecao ConsultarPorNome(string nome)
        {
            try
            {
                LaboratorioColecao laboratorioColecao = new LaboratorioColecao();

                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@NOME", nome);

                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "USP_LABORATORIO_CONSULTAR_PORNOME");

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    Laboratorio laboratorio = new Laboratorio();
                    laboratorio.Id_Laboratorio = Convert.ToInt32(dataRow["ID_LABORATORIO"]);
                    laboratorio.Nome = Convert.ToString(dataRow["NOME"]);
                    laboratorio.Numero_Sala = Convert.ToInt16(dataRow["NUMERO_SALA"]);
                    laboratorio.Capacidade = Convert.ToInt16(dataRow["CAPACIDADE"]);
                    laboratorio.Data_Cadastro = Convert.ToDateTime(dataRow["DATA_CADASTRO"]);
                    laboratorio.Data_Ultima_Alteracao = Convert.ToDateTime(dataRow["DATA_ULTIMA_ALTERACAO"]);

                    Usuario usuario = new Usuario();

                    usuario.Id_Usuario = Convert.ToInt32(dataRow["USUARIO_CAD_ALT"]);

                    TipoLaboratorio tipoLaboratorio = new TipoLaboratorio();

                    tipoLaboratorio.Tipo = Convert.ToString(dataRow["TIPO"]);

                    laboratorio.Usuario = usuario;
                    laboratorio.TipoLaboratorio = tipoLaboratorio;
                    laboratorioColecao.Add(laboratorio);
                }

                return laboratorioColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar Laboratório. Detalhes: " + ex.Message);
            }
        }
        public LaboratorioColecao ConsultarPorId(int id)
        {
            try
            {
                LaboratorioColecao laboratorioColecao = new LaboratorioColecao();

                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@ID_LABORATORIO", id);

                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "USP_LABORATORIO_CONSULTAR_ID");

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    Laboratorio laboratorio = new Laboratorio();
                    laboratorio.Id_Laboratorio = Convert.ToInt32(dataRow["ID_LABORATORIO"]);
                    laboratorio.Nome = Convert.ToString(dataRow["NOME"]);
                    laboratorio.Numero_Sala = Convert.ToInt16(dataRow["NUMERO_SALA"]);
                    laboratorio.Capacidade = Convert.ToInt16(dataRow["CAPACIDADE"]);
                    laboratorio.Data_Cadastro = Convert.ToDateTime(dataRow["DATA_CADASTRO"]);
                    laboratorio.Data_Ultima_Alteracao = Convert.ToDateTime(dataRow["DATA_ULTIMA_ALTERACAO"]);

                    Usuario usuario = new Usuario();

                    usuario.Id_Usuario = Convert.ToInt32(dataRow["USUARIO_CAD_ALT"]);

                    TipoLaboratorio tipoLaboratorio = new TipoLaboratorio();

                    tipoLaboratorio.Tipo = Convert.ToString(dataRow["TIPO"]);

                    laboratorio.Usuario = usuario;
                    laboratorio.TipoLaboratorio = tipoLaboratorio;
                    laboratorioColecao.Add(laboratorio);
                }

                return laboratorioColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar Laboratório. Detalhes: " + ex.Message);
            }
        }
    }


}
