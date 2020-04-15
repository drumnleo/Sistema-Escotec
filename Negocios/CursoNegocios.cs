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
    public class CursoNegocios
    {
        AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();

        //Inserir

        public string Inserir(Curso curso)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@ID_TIPO_CURSO", curso.TipoCurso.Id_Tipo_Curso);
                acessoDados.AdicionarParametros("@NOME", curso.Nome);
                acessoDados.AdicionarParametros("@QTDE_AULAS_SEMANA", curso.Qtde_Aulas_Semana);
                acessoDados.AdicionarParametros("@DURACAO_MESES", curso.Duracao_Meses);
                acessoDados.AdicionarParametros("@CARGA_HORARIA", curso.Carga_Horaria);
                acessoDados.AdicionarParametros("@HORAS_POR_AULA", curso.Horas_Por_Aula);
                acessoDados.AdicionarParametros("@APOSITILA", curso.Apostila);
                acessoDados.AdicionarParametros("@VALOR_TOTAL", curso.Valor_Total);
                acessoDados.AdicionarParametros("@QTDE_PARCELAS", curso.Qtde_Parcelas);
                acessoDados.AdicionarParametros("@ID_USUARIO", curso.Usuario.Id_Usuario);


                string IdCargo = acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "USP_CURSO_INSERIR").ToString();

                return IdCargo;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string AtualizarporId(Curso curso)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("ID_CURSO", curso.Id_Curso);
                acessoDados.AdicionarParametros("@ID_TIPO_CURSO", curso.TipoCurso.Id_Tipo_Curso);
                acessoDados.AdicionarParametros("@NOME", curso.Nome);
                acessoDados.AdicionarParametros("@QTDE_AULAS_SEMANA", curso.Qtde_Aulas_Semana);
                acessoDados.AdicionarParametros("@DURACAO_MESES", curso.Duracao_Meses);
                acessoDados.AdicionarParametros("@CARGA_HORARIA", curso.Carga_Horaria);
                acessoDados.AdicionarParametros("@HORAS_POR_AULA", curso.Horas_Por_Aula);
                acessoDados.AdicionarParametros("@APOSITILA", curso.Apostila);
                acessoDados.AdicionarParametros("@VALOR_TOTAL", curso.Valor_Total);
                acessoDados.AdicionarParametros("@QTDE_PARCELAS", curso.Qtde_Parcelas);
                acessoDados.AdicionarParametros("@ID_USUARIO", curso.Usuario.Id_Usuario);


                string IdCargo = acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "USP_CURSO_ATUALIZARPORID").ToString();

                return IdCargo;
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

        public CursoColecao ConsultarPorNome(string nome)
        {
            try
            {
                CursoColecao cursoColecao = new CursoColecao();

                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@NOME", nome);

                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "USP_CURSO_CONSULTARPORNOME");

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    Curso curso = new Curso();

                    curso.Nome = Convert.ToString(dataRow["NOME"]);
                    curso.Qtde_Aulas = Convert.ToInt16(dataRow["QTDE_AULAS"]);
                    curso.Qtde_Aulas_Semana = Convert.ToInt16(dataRow["QTDE_AULAS_SEMANA"]);
                    curso.Duracao_Meses = Convert.ToInt16(dataRow["DURACAO_MESES"]);
                    curso.Carga_Horaria = Convert.ToInt16(dataRow["CARGA_HORARIA"]);
                    curso.Horas_Por_Aula = Convert.ToInt16(dataRow["HORAS_POR_AULA"]);
                    curso.Apostila = Convert.ToBoolean(dataRow["APOSTILA"]);
                    curso.Valor_Total = Convert.ToDecimal(dataRow["VALOR_TOTAL"]);
                    curso.Qtde_Parcelas = Convert.ToInt16(dataRow["QTDE_PARCELAS"]);
                    curso.Data_Cadastro = Convert.ToDateTime(dataRow["DATA_CADASTRO"]);
                    curso.Data_Ultima_Alteracao = Convert.ToDateTime(dataRow["DATA_ULTIMA_ALTERACAO"]);

                    Usuario usuario = new Usuario();

                    usuario.Id_Usuario = Convert.ToInt32(dataRow["USUARIO_CAD_ALT"]);

                    TipoCurso tipoCurso = new TipoCurso();

                    tipoCurso.Id_Tipo_Curso = Convert.ToInt32(dataRow["ID_TIPO_CURSO"]);

                    curso.Usuario = usuario;
                    curso.TipoCurso = tipoCurso;
                    cursoColecao.Add(curso);
                }

                return cursoColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar curso. Detalhes: " + ex.Message);
            }
        }
    }
}
