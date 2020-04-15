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
    public class TipoApostilaNegocios
    {
        AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();

        public string Inserir(TipoApostila tipoApostila)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@ID_TIPO_CURSO", tipoApostila.TipoCurso.Id_Tipo_Curso);
                acessoDados.AdicionarParametros("@TIPO", tipoApostila.Tipo);
                acessoDados.AdicionarParametros("@ID_USUARIO", tipoApostila.Usuario.Id_Usuario);


                string idTipoApostila = acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "USP_TIPO_APOSTILA_INSERIR").ToString();

                return idTipoApostila;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public string AtualizarporId(TipoApostila tipoApostila)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@ID_TIPO_APOSTILA", tipoApostila.Id_Tipo_Apostila);
                acessoDados.AdicionarParametros("@ID_TIPO_CURSO", tipoApostila.TipoCurso.Id_Tipo_Curso);
                acessoDados.AdicionarParametros("@TIPO", tipoApostila.Tipo);
                acessoDados.AdicionarParametros("@ID_USUARIO", tipoApostila.Usuario.Id_Usuario);


                string idTipoApostila = acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "USP_TIPO_APOSTILA_ATUALIZARPORID").ToString();

                return idTipoApostila;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Excluir(TipoApostila tipoApostila)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@ID_TIPO_APOSTILA", tipoApostila.Id_Tipo_Apostila);
                acessoDados.AdicionarParametros("@ID_USUARIO", tipoApostila.Usuario.Id_Usuario);

                string idTipoApostila = acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "USP_TIPO_APOSTILA_EXCLUIR").ToString();

                return idTipoApostila;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public TipoApostilaColecao ConsultarPorNome(string tipo)
        {
            try
            {
                TipoApostilaColecao tipoApostilaColecao = new TipoApostilaColecao();

                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@TIPO", tipo);

                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "USP_TIPO_APOSTILA_CONSULTARPORTIPO");

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    TipoApostila tipoApostila = new TipoApostila();

                    tipoApostila.Id_Tipo_Apostila = Convert.ToInt32(dataRow["ID_TIPO_APOSTILA"]);
                    tipoApostila.Tipo = Convert.ToString(dataRow["TIPO"]);
                    tipoApostila.Data_Cadastro = Convert.ToDateTime(dataRow["DATA_CADASTRO"]);
                    tipoApostila.Data_Ultima_Alteracao = Convert.ToDateTime(dataRow["DATA_ULTIMA_ALTERACAO"]);

                    Usuario usuario = new Usuario();

                    usuario.Id_Usuario = Convert.ToInt32(dataRow["USUARIO_CAD_ALT"]);

                    TipoCurso tipoCurso = new TipoCurso();

                    tipoCurso.Id_Tipo_Curso = Convert.ToInt32(dataRow["ID_TIPO_CURSO"]);

                    tipoApostila.Usuario = usuario;
                    tipoApostila.TipoCurso = tipoCurso;
                    tipoApostilaColecao.Add(tipoApostila);
                }

                return tipoApostilaColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar tipo de apostila. Detalhes: " + ex.Message);
            }
        }
    }
}
