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
    public class TipoCursoNegocios
    {
        AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();

        public string Inserir(TipoCurso tipoCurso)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@ID_LABORATORIO", tipoCurso.Laboratorio.Id_Laboratorio);
                acessoDados.AdicionarParametros("@NOME", tipoCurso.Nome);
                acessoDados.AdicionarParametros("@DESCRICAO", tipoCurso.Descricao);
                acessoDados.AdicionarParametros("@VAGAS", tipoCurso.Vagas);
                acessoDados.AdicionarParametros("@ID_USUARIO", tipoCurso.Usuario.Id_Usuario);

                string idTipoCurso = acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "USP_TIPO_CURSO_INSERIR").ToString();

                return idTipoCurso;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public string AtualizarporId(TipoCurso tipoCurso)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@ID_TIPO_CURSO", tipoCurso.Id_Tipo_Curso);
                acessoDados.AdicionarParametros("@ID_LABORATORIO", tipoCurso.Laboratorio.Id_Laboratorio);
                acessoDados.AdicionarParametros("@NOME", tipoCurso.Nome);
                acessoDados.AdicionarParametros("@DESCRICAO", tipoCurso.Descricao);
                acessoDados.AdicionarParametros("@VAGAS", tipoCurso.Vagas);
                acessoDados.AdicionarParametros("@ID_USUARIO", tipoCurso.Usuario.Id_Usuario);

                string idTipoCurso = acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "USP_TIPO_CURSO_ATUALIZARPORID").ToString();

                return idTipoCurso;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Excluir(TipoCurso tipoCurso)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@ID_TIPO_CURSO", tipoCurso.Id_Tipo_Curso);
                acessoDados.AdicionarParametros("@ID_USUARIO", tipoCurso.Usuario.Id_Usuario);

                string idTipoCurso = acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "USP_TIPO_CURSO_EXCLUIR").ToString();

                return idTipoCurso;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public TipoCursoColecao ConsultarPorNome(string nome)
        {
            try
            {
                TipoCursoColecao tipoCursoColecao = new TipoCursoColecao();

                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@NOME", nome);

                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "USP_LABORATORIO_CONSULTAR_PORNOME");

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    TipoCurso tipoCurso = new TipoCurso();

                    tipoCurso.Nome = Convert.ToString(dataRow["NOME"]);
                    tipoCurso.Descricao = Convert.ToString(dataRow["DESCRICAO"]);
                    tipoCurso.Vagas = Convert.ToInt16(dataRow["VAGAS"]);
                    tipoCurso.Data_Cadastro = Convert.ToDateTime(dataRow["DATA_CADASTRO"]);
                    tipoCurso.Data_Ultima_Alteracao = Convert.ToDateTime(dataRow["DATA_ULTIMA_ALTERACAO"]);

                    Usuario usuario = new Usuario();

                    usuario.Id_Usuario = Convert.ToInt32(dataRow["USUARIO_CAD_ALT"]);

                    Laboratorio laboratorio = new Laboratorio();

                    laboratorio.Id_Laboratorio = Convert.ToInt32(dataRow["ID_LABORATORIO"]);
                    laboratorio.Nome = Convert.ToString(dataRow["NOME"]);

                    tipoCurso.Usuario = usuario;
                    tipoCurso.Laboratorio = laboratorio;
                    tipoCursoColecao.Add(tipoCurso);
                }

                return tipoCursoColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar tipo de curso. Detalhes: " + ex.Message);
            }
        }
    }
}
