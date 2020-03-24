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
        //public CursoColecao ConsultarPorNome(string nome)

        //{
        //    try
        //    {
        //        CursoColecao cursoColecao = new CursoColecao();

        //        acessoDados.LimparParametros();
        //        acessoDados.AdicionarParametros("@NOME", nome);

        //        DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "USP_CURSO_CONSULTAR_NOME");

        //        foreach (DataRow dataRow in dataTable.Rows)
        //        {
        //            Curso curso = new curso();

        //            curso.Id_Curso = Convert.ToInt32(dataRow["ID_CARGO"]);
        //            curso.Nome = Convert.ToString(dataRow["ID_CARGO"]);
        //            curso.Id_Curso = Convert.ToInt32(dataRow["ID_CARGO"]);
        //            curso.Id_Curso = Convert.ToInt32(dataRow["ID_CARGO"]);
        //            curso.Id_Curso = Convert.ToInt32(dataRow["ID_CARGO"]);
        //            curso.Id_Curso = Convert.ToInt32(dataRow["ID_CARGO"]);
        //            curso.Id_Curso = Convert.ToInt32(dataRow["ID_CARGO"]);


        //        }

        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }


        //}
        //public string Excluir (Curso curso)
        //{
        //    try
        //    {
        //        acessoDados.LimparParametros();
        //        acessoDados.AdicionarParametros("@ID_CURSO", curso.Id_Curso);
        //        acessoDados.AdicionarParametros("@ID_USUARIO", curso.Usuario.Id_Usuario);
        //        string id_curso = acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "USP_CURSO_EXCLUIR").ToString();
        //        return id_curso;
        //    }
        //    catch (Exception ex )
        //    {

        //        return ex.Message;
        //    }

        //}




    }
}
