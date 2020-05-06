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
    public class OrcamentoNegocios
    {
        AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();

        public string Inserir(Orcamento orcamento)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@ID_ATENDIMENTO", orcamento.Atendimento.Id_Atendimento);
                acessoDados.AdicionarParametros("@VALIDADE_ORCAMENTO", orcamento.Validade_Orcamento);
                acessoDados.AdicionarParametros("@ID_USUARIO", orcamento.Usuario_Cad_Alt.Id_Usuario);

                string idOrcamento = acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "USP_ORCAMENTO_INSERIR").ToString();

                return idOrcamento;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string AtualizarporId(Orcamento orcamento)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@ID_ORCAMENTO", orcamento.Id_Orcamento);
                acessoDados.AdicionarParametros("@ID_PESSOA", orcamento.Atendimento.Id_Atendimento);
                acessoDados.AdicionarParametros("@VALIDADE_ORCAMENTO", orcamento.Validade_Orcamento);
                acessoDados.AdicionarParametros("@ID_USUARIO", orcamento.Usuario_Cad_Alt.Id_Usuario);

                string idOrcamento = acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "USP_ORCAMENTO_ATUALIZARPORID").ToString();

                return idOrcamento;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Excluir(Orcamento orcamento)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@ID_ORCAMENTO", orcamento.Id_Orcamento);
                acessoDados.AdicionarParametros("@ID_USUARIO", orcamento.Usuario_Cad_Alt.Id_Usuario);

                string idOrcamento = acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "USP_ORCAMENTO_EXCLUIR").ToString();

                return idOrcamento;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public OrcamentoColecao ConsultarPorIdAtendimento(int idAtendimento)
        {
            try
            {
                OrcamentoColecao orcamentoColecao = new OrcamentoColecao();

                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@ID_ATENDIMENTO", idAtendimento);

                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "USP_ORCAMENTO_CONSULTARPORATENDIMENTO");

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    Orcamento orcamento = new Orcamento();

                    orcamento.Id_Orcamento = Convert.ToInt32(dataRow["ID_ORCAMENTO"]);
                    orcamento.Validade_Orcamento = Convert.ToDateTime(dataRow["VALIDADE_ORCAMENTO"]);
                    orcamento.Data_Cadastro = Convert.ToDateTime(dataRow["DATA_CADASTRO"]);
                    orcamento.Data_Ultima_Alteracao = Convert.ToDateTime(dataRow["DATA_ULTIMA_ALTERACAO"]);
                    orcamento.Aprovado = Convert.ToBoolean(dataRow["APROVADO"]);
                    orcamento.Comentario_Aprovacao = Convert.ToString(dataRow["COMENTARIO_APROVACAO"]);

                    Usuario usuarioAprova = new Usuario();
                    if (int.TryParse(dataRow["APROVADO_USUARIO"].ToString(), out int v))
                    {
                        usuarioAprova.Id_Usuario = v;
                    }

                    Usuario usuarioGera = new Usuario();
                    usuarioGera.Id_Usuario = Convert.ToInt32(dataRow["USUARIO_GERA_ORCAMENTO"]);

                    Usuario usuarioCadAlt = new Usuario();
                    usuarioCadAlt.Id_Usuario = Convert.ToInt32(dataRow["USUARIO_CAD_ALT"]);

                    Atendimento atendimento = new Atendimento();
                    atendimento.Id_Atendimento = Convert.ToInt32(dataRow["ID_ATENDIMENTO"]);

                    Pessoa pessoa = new Pessoa();
                    pessoa.Id_Pessoa = Convert.ToInt32(dataRow["ID_PESSOA"]);

                    orcamento.Usuario_Cad_Alt = usuarioCadAlt;
                    orcamento.Aprovado_Usuario = usuarioAprova;
                    orcamento.UsuarioGeraOrcamento = usuarioGera;
                    orcamento.Atendimento = atendimento;
                    orcamento.Atendimento.Pessoa = pessoa;
                    
                    orcamentoColecao.Add(orcamento);
                }

                return orcamentoColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar Orçamento. Detalhes: " + ex.Message);
            }
        }

        public OrcamentoColecao ConsultarPorIdOrcamento(int idOrcamento)
        {
            try
            {
                OrcamentoColecao orcamentoColecao = new OrcamentoColecao();

                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@ID_ORCAMENTO", idOrcamento);

                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "USP_ORCAMENTO_CONSULTARPORID");

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    Orcamento orcamento = new Orcamento();

                    orcamento.Id_Orcamento = Convert.ToInt32(dataRow["ID_ORCAMENTO"]);
                    orcamento.Validade_Orcamento = Convert.ToDateTime(dataRow["VALIDADE_ORCAMENTO"]);
                    orcamento.Data_Cadastro = Convert.ToDateTime(dataRow["DATA_CADASTRO"]);
                    orcamento.Data_Ultima_Alteracao = Convert.ToDateTime(dataRow["DATA_ULTIMA_ALTERACAO"]);
                    orcamento.Aprovado = Convert.ToBoolean(dataRow["APROVADO"]);
                    orcamento.Comentario_Aprovacao = Convert.ToString(dataRow["COMENTARIO_APROVACAO"]);

                    Usuario usuarioAprova = new Usuario();
                    if (int.TryParse(dataRow["APROVADO_USUARIO"].ToString(), out int v))
                    {
                        usuarioAprova.Id_Usuario = v;
                    }

                    Usuario usuarioGera = new Usuario();
                    usuarioGera.Id_Usuario = Convert.ToInt32(dataRow["USUARIO_GERA_ORCAMENTO"]);

                    Usuario usuarioCadAlt = new Usuario();
                    usuarioCadAlt.Id_Usuario = Convert.ToInt32(dataRow["USUARIO_CAD_ALT"]);

                    Atendimento atendimento = new Atendimento();
                    atendimento.Id_Atendimento = Convert.ToInt32(dataRow["ID_ATENDIMENTO"]);

                    Pessoa pessoa = new Pessoa();
                    pessoa.Id_Pessoa = Convert.ToInt32(dataRow["ID_PESSOA"]);

                    orcamento.Usuario_Cad_Alt = usuarioCadAlt;
                    orcamento.Aprovado_Usuario = usuarioAprova;
                    orcamento.UsuarioGeraOrcamento = usuarioGera;
                    orcamento.Atendimento = atendimento;
                    orcamento.Atendimento.Pessoa = pessoa;

                    orcamentoColecao.Add(orcamento);
                }

                return orcamentoColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar Orçamento. Detalhes: " + ex.Message);
            }
        }
    }
}
