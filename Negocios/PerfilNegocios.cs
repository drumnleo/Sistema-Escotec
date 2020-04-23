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
    public class PerfilNegocios
    {
        AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();

        //Inserir
        public string Inserir(PerfilAcesso perfilAcesso)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@DESCRICAO", perfilAcesso.Descricao);
                acessoDados.AdicionarParametros("@PESSOA", perfilAcesso.Pessoa);
                acessoDados.AdicionarParametros("@USUARIO", perfilAcesso.Usuario);
                acessoDados.AdicionarParametros("@FUNCIONARIO", perfilAcesso.Funcionario);
                acessoDados.AdicionarParametros("@GRUPO_USUARIO", perfilAcesso.GrupoUsuario);
                acessoDados.AdicionarParametros("@CURSO", perfilAcesso.Curso);
                acessoDados.AdicionarParametros("@ENDERECO", perfilAcesso.Endereco);
                acessoDados.AdicionarParametros("@LABORATORIO", perfilAcesso.Laboratorio);
                acessoDados.AdicionarParametros("@MARKETING", perfilAcesso.Marketing);
                acessoDados.AdicionarParametros("@ORCAMENTO", perfilAcesso.Orcamento);
                acessoDados.AdicionarParametros("PROFESSOR", perfilAcesso.Professor);
                acessoDados.AdicionarParametros("PROFESSOR_MINISTRA", perfilAcesso.ProfessorMinistra);
                acessoDados.AdicionarParametros("PROMOCAO_VALOR", perfilAcesso.PromocaoValor);
                acessoDados.AdicionarParametros("@TPO_APOSTILA", perfilAcesso.TipoApostila);
                acessoDados.AdicionarParametros("@TIPO_ATENDIMENTO", perfilAcesso.TipoAtendimento);
                acessoDados.AdicionarParametros("@TIPO_CURSO", perfilAcesso.TipoCurso);
                acessoDados.AdicionarParametros("@TIPO_LABORATORIO", perfilAcesso.TipoLaboratorio);
                acessoDados.AdicionarParametros("@TURMA", perfilAcesso.Turma);
                acessoDados.AdicionarParametros("@CAIXA", perfilAcesso.Caixa);
                acessoDados.AdicionarParametros("@ID_USUARIO", perfilAcesso.Usuario_Cad_Alt);

                string idPerfil = acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "USP_PERFIL_ACESSO_INSERIR").ToString();

                return idPerfil;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }    
        }

        public string AtualizarPorId(PerfilAcesso perfilAcesso)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@ID_PERFIL", perfilAcesso.Id_Perfil);
                acessoDados.AdicionarParametros("@DESCRICAO", perfilAcesso.Descricao);
                acessoDados.AdicionarParametros("@PESSOA", perfilAcesso.Pessoa);
                acessoDados.AdicionarParametros("@USUARIO", perfilAcesso.Usuario);
                acessoDados.AdicionarParametros("@FUNCIONARIO", perfilAcesso.Funcionario);
                acessoDados.AdicionarParametros("@GRUPO_USUARIO", perfilAcesso.GrupoUsuario);
                acessoDados.AdicionarParametros("@CURSO", perfilAcesso.Curso);
                acessoDados.AdicionarParametros("@ENDERECO", perfilAcesso.Endereco);
                acessoDados.AdicionarParametros("@LABORATORIO", perfilAcesso.Laboratorio);
                acessoDados.AdicionarParametros("@MARKETING", perfilAcesso.Marketing);
                acessoDados.AdicionarParametros("@ORCAMENTO", perfilAcesso.Orcamento);
                acessoDados.AdicionarParametros("PROFESSOR", perfilAcesso.Professor);
                acessoDados.AdicionarParametros("PROFESSOR_MINISTRA", perfilAcesso.ProfessorMinistra);
                acessoDados.AdicionarParametros("PROMOCAO_VALOR", perfilAcesso.PromocaoValor);
                acessoDados.AdicionarParametros("@TPO_APOSTILA", perfilAcesso.TipoApostila);
                acessoDados.AdicionarParametros("@TIPO_ATENDIMENTO", perfilAcesso.TipoAtendimento);
                acessoDados.AdicionarParametros("@TIPO_CURSO", perfilAcesso.TipoCurso);
                acessoDados.AdicionarParametros("@TIPO_LABORATORIO", perfilAcesso.TipoLaboratorio);
                acessoDados.AdicionarParametros("@TURMA", perfilAcesso.Turma);
                acessoDados.AdicionarParametros("@CAIXA", perfilAcesso.Caixa);
                acessoDados.AdicionarParametros("@ID_USUARIO", perfilAcesso.Usuario_Cad_Alt);

                string idPerfil = acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "USP_PERFIL_ACESSO_ATUALIZARPORID").ToString();

                return idPerfil;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }


        public PerfilAcessoColecao ConsultarPorNome(string nome)
        {
            try
            {
                PerfilAcessoColecao perfilColecao = new PerfilAcessoColecao();

                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@NOME", nome);

                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "USP_PERFIL_ACESSO_CONSULTARPORDESCRICAO");

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    PerfilAcesso perfilAcesso = new PerfilAcesso();

                    perfilAcesso.Id_Perfil = Convert.ToInt32(dataRow["ID_PERFIL"]);
                    perfilAcesso.Descricao = Convert.ToString(dataRow["DESCRICAO"]);
                    perfilAcesso.Pessoa = Convert.ToChar(dataRow["PESSOA"]);
                    perfilAcesso.Usuario = Convert.ToChar(dataRow["USUARIO"]);
                    perfilAcesso.Funcionario = Convert.ToChar(dataRow["FUNCIONARIO"]);
                    perfilAcesso.GrupoUsuario = Convert.ToChar(dataRow["GRUPO_USUARIO"]);
                    perfilAcesso.Curso = Convert.ToChar(dataRow["CURSO"]);
                    perfilAcesso.Endereco = Convert.ToChar(dataRow["ENDERECO"]);
                    perfilAcesso.Laboratorio = Convert.ToChar(dataRow["LABORATORIO"]);
                    perfilAcesso.Marketing = Convert.ToChar(dataRow["MARKETING"]);
                    perfilAcesso.Orcamento = Convert.ToChar(dataRow["ORCAMENTO"]);
                    perfilAcesso.Professor = Convert.ToChar(dataRow["PROFESSOR"]);
                    perfilAcesso.ProfessorMinistra = Convert.ToChar(dataRow["PROFESSOR_MINISTRA"]);
                    perfilAcesso.PromocaoValor = Convert.ToChar(dataRow["PROMOCAO_VALOR"]);
                    perfilAcesso.TipoApostila = Convert.ToChar(dataRow["TIPO_APOSTILA"]);
                    perfilAcesso.TipoAtendimento = Convert.ToChar(dataRow["TIPO_ATENDIMENTO"]);
                    perfilAcesso.TipoCurso = Convert.ToChar(dataRow["TIPO_CURSO"]);
                    perfilAcesso.TipoLaboratorio = Convert.ToChar(dataRow["TIPO_LABORATORIO"]);
                    perfilAcesso.Turma = Convert.ToChar(dataRow["TURMA"]);
                    perfilAcesso.Caixa = Convert.ToChar(dataRow["CAIXA"]);
                    perfilAcesso.Data_Cadastro = Convert.ToDateTime(dataRow["DATA_CADASTRO"]);
                    perfilAcesso.Data_Ultima_Alteracao = Convert.ToDateTime(dataRow["DATA_ALTERACAO"]);
                    perfilAcesso.Usuario_Cad_Alt = Convert.ToInt32(dataRow["USUARIO_CAD_ALT"]);


                    perfilColecao.Add(perfilAcesso);
                }

                return perfilColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar Perfil. Detalhes" + ex.Message);
            }
        }
    }
}
