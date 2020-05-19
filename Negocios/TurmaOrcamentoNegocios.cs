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
    public class TurmaOrcamentoNegocios
    {
        AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();

        public string Inserir(TurmaOrcamento turmaOrcamento)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@ID_ORCAMENTO", turmaOrcamento.Orcamento.Id_Orcamento);
                acessoDados.AdicionarParametros("@ID_TURMA", turmaOrcamento.Turma.Id_Turma);
                acessoDados.AdicionarParametros("@ID_PROMOCAO_VALOR", turmaOrcamento.PromocaoValor.Id_Promocao_Valor);
                acessoDados.AdicionarParametros("@ID_USUARIO", turmaOrcamento.Usuario.Id_Usuario);

                string idTurmaOrcamento = acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "USP_TURMA_ORCAMENTO_INSERIR").ToString();

                return idTurmaOrcamento;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Atualizarr(TurmaOrcamento turmaOrcamento)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@ID_ORCAMENTO", turmaOrcamento.Orcamento.Id_Orcamento);
                acessoDados.AdicionarParametros("@ID_TURMA", turmaOrcamento.Turma.Id_Turma);
                acessoDados.AdicionarParametros("@ID_PROMOCAO_VALOR", turmaOrcamento.PromocaoValor.Id_Promocao_Valor);
                acessoDados.AdicionarParametros("@ID_USUARIO", turmaOrcamento.Usuario.Id_Usuario);

                string idTurmaOrcamento = acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "USP_TURMA_ORCAMENTO_ATUALIZARPORID").ToString();

                return idTurmaOrcamento;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public TurmaOrcamentoColecao ConsultarPorOrcamento(int id)
        {
            try
            {
                TurmaOrcamentoColecao turmaOrcamentoColecao = new TurmaOrcamentoColecao();

                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@ID_ORCAMENTO", id);

                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "USP_TURMA_ORCAMENTO_CONSULTARPORORCAMENTO");

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    TurmaOrcamento turmaOrcamento = new TurmaOrcamento();
                    turmaOrcamento.Qtde_Parcelas = Convert.ToInt16(dataRow["QTDE_PARCELAS"]);
                    turmaOrcamento.Valor_Entrada_Turma = Convert.ToDecimal(dataRow["VALOR_ENTRADA_TURMA"]);
                    turmaOrcamento.Valor_Parcela_Demais = Convert.ToDecimal(dataRow["VALOR_PARCELA_DEMAIS"]);

                    Orcamento orcamento = new Orcamento();
                    orcamento.Id_Orcamento = Convert.ToInt32(dataRow["ID_ORCAMENTO"]);

                    Turma turma = new Turma();
                    turma.Id_Turma = Convert.ToInt32(dataRow["ID_TURMA"]);
                    turma.Nome_Turma = Convert.ToString(dataRow["NOME_TURMA"]);

                    PromocaoValor promocaoValor = new PromocaoValor();
                    promocaoValor.Id_Promocao_Valor = Convert.ToInt32(dataRow["ID_PROMOCAO_VALOR"]);
                    promocaoValor.Nome_Promocao = Convert.ToString(dataRow["NOME_PROMOCAO"]);

                    Curso curso = new Curso();
                    curso.Id_Curso = Convert.ToInt32(dataRow["ID_CURSO"]);
                    curso.Nome = Convert.ToString(dataRow["NOME_CURSO"]);
                    turma.Curso = curso;

                    Usuario usuario = new Usuario();
                    usuario.Id_Usuario = Convert.ToInt32(dataRow["USUARIO_CAD_ALT"]);

                    turmaOrcamento.Orcamento = orcamento;
                    turmaOrcamento.Turma = turma;       
                    turmaOrcamento.PromocaoValor = promocaoValor;
                    turmaOrcamento.Usuario = usuario;
                    turmaOrcamentoColecao.Add(turmaOrcamento);
                }

                return turmaOrcamentoColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar orçamento turma. Detalhes: " + ex.Message);
            }
        }

        public TurmaOrcamentoColecao ConsultarPorPessoa(string nome)
        {
            try
            {
                TurmaOrcamentoColecao turmaOrcamentoColecao = new TurmaOrcamentoColecao();

                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@NOME", nome);

                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "USP_TURMA_ORCAMENTO_CONSULTARPORORPESSOA");

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    TurmaOrcamento turmaOrcamento = new TurmaOrcamento();
                    turmaOrcamento.Qtde_Parcelas = Convert.ToInt16(dataRow["QTDE_PARCELAS"]);
                    turmaOrcamento.Valor_Entrada_Turma = Convert.ToDecimal(dataRow["VALOR_ENTRADA_TURMA"]);
                    turmaOrcamento.Valor_Parcela_Demais = Convert.ToDecimal(dataRow["VALOR_PARCELA_DEMAIS"]);
                    turmaOrcamento.Data_Cadastro = Convert.ToDateTime(dataRow["DATA_CADASTRO"]);
                    turmaOrcamento.Data_Ultima_Alteracao = Convert.ToDateTime(dataRow["DATA_ULTIMA_ALTERACAO"]);

                    Orcamento orcamento = new Orcamento();
                    orcamento.Id_Orcamento = Convert.ToInt32(dataRow["ID_ORCAMENTO"]);
                    orcamento.Validade_Orcamento = Convert.ToDateTime(dataRow["VALIDADE_ORCAMENTO"]);

                    Turma turma = new Turma();
                    turma.Id_Turma = Convert.ToInt32(dataRow["ID_TURMA"]);
                    turma.Nome_Turma = Convert.ToString(dataRow["NOME_TURMA"]);

                    Curso curso = new Curso();
                    curso.Id_Curso = Convert.ToInt32(dataRow["ID_CURSO"]);
                    curso.Nome = Convert.ToString(dataRow["NOME_CURSO"]);
                    turma.Curso = curso;

                    PromocaoValor promocaoValor = new PromocaoValor();
                    promocaoValor.Id_Promocao_Valor = Convert.ToInt32(dataRow["ID_PROMOCAO_VALOR"]);
                    promocaoValor.Nome_Promocao = Convert.ToString(dataRow["NOME_PROMOCAO"]);

                    Usuario usuario = new Usuario();
                    usuario.Id_Usuario = Convert.ToInt32(dataRow["USUARIO_CAD_ALT"]);

                    turmaOrcamento.Orcamento = orcamento;
                    turmaOrcamento.Turma = turma;
                    turmaOrcamento.PromocaoValor = promocaoValor;
                    turmaOrcamento.Usuario = usuario;
                    turmaOrcamentoColecao.Add(turmaOrcamento);
                }

                return turmaOrcamentoColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar orçamento turma. Detalhes: " + ex.Message);
            }
        }

        public TurmaOrcamentoColecao ConsultarPorId(int idOrcamento, int idTurma)
        {
            try
            {
                TurmaOrcamentoColecao turmaOrcamentoColecao = new TurmaOrcamentoColecao();

                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@ID_ORCAMENTO", idOrcamento);
                acessoDados.AdicionarParametros("@ID_TURMA", idTurma);

                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "USP_TURMA_ORCAMENTO_CONSULTARPORID");

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    TurmaOrcamento turmaOrcamento = new TurmaOrcamento();
                    turmaOrcamento.Qtde_Parcelas = Convert.ToInt16(dataRow["QTDE_PARCELAS"]);
                    turmaOrcamento.Valor_Entrada_Turma = Convert.ToDecimal(dataRow["VALOR_ENTRADA_TURMA"]);
                    turmaOrcamento.Valor_Parcela_Demais = Convert.ToDecimal(dataRow["VALOR_PARCELA_DEMAIS"]);

                    Orcamento orcamento = new Orcamento();
                    orcamento.Id_Orcamento = Convert.ToInt32(dataRow["ID_ORCAMENTO"]);
                    orcamento.Validade_Orcamento = Convert.ToDateTime(dataRow["VALIDADE_ORCAMENTO"]);

                    Turma turma = new Turma();
                    turma.Id_Turma = Convert.ToInt32(dataRow["ID_TURMA"]);

                    PromocaoValor promocaoValor = new PromocaoValor();
                    promocaoValor.Id_Promocao_Valor = Convert.ToInt32(dataRow["ID_PROMOCAO_VALOR"]);

                    Usuario usuario = new Usuario();
                    usuario.Id_Usuario = Convert.ToInt32(dataRow["USUARIO_CAD_ALT"]);

                    turmaOrcamento.Orcamento = orcamento;
                    turmaOrcamento.Turma = turma;
                    turmaOrcamento.PromocaoValor = promocaoValor;
                    turmaOrcamento.Usuario = usuario;
                    turmaOrcamentoColecao.Add(turmaOrcamento);
                }

                return turmaOrcamentoColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar orçamento turma. Detalhes: " + ex.Message);
            }
        }

        public TurmaOrcamentoColecao ConsultarPorIdAtendimento(int idAtendimento)
        {
            try
            {
                TurmaOrcamentoColecao turmaOrcamentoColecao = new TurmaOrcamentoColecao();

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
                    pessoa.Nome = Convert.ToString(dataRow["NOME"]);
                    pessoa.Sobrenome = Convert.ToString(dataRow["SOBRENOME"]);

                    Turma turma = new Turma();
                    turma.Id_Turma = Convert.ToInt32(dataRow["ID_TURMA"]);
                    turma.Nome_Turma = Convert.ToString(dataRow["NOME_TURMA"]);

                    orcamento.Usuario_Cad_Alt = usuarioCadAlt;
                    orcamento.Aprovado_Usuario = usuarioAprova;
                    orcamento.UsuarioGeraOrcamento = usuarioGera;
                    orcamento.Atendimento = atendimento;
                    orcamento.Atendimento.Pessoa = pessoa;

                    PromocaoValor promocaoValor = new PromocaoValor();
                    promocaoValor.Id_Promocao_Valor = Convert.ToInt32(dataRow["ID_PROMOCAO_VALOR"]);
                    promocaoValor.Nome_Promocao = Convert.ToString(dataRow["NOME_PROMOCAO"]);

                    TurmaOrcamento turmaOrcamento = new TurmaOrcamento();
                    turmaOrcamento.Qtde_Parcelas = Convert.ToInt16(dataRow["QTDE_PARCELAS"]);
                    turmaOrcamento.Valor_Entrada_Turma = Convert.ToDecimal(dataRow["VALOR_ENTRADA_TURMA"]);
                    turmaOrcamento.Valor_Parcela_Demais = Convert.ToDecimal(dataRow["VALOR_PARCELA_DEMAIS"]);
                    turmaOrcamento.Orcamento = orcamento;
                    turmaOrcamento.Turma = turma;
                    turmaOrcamento.PromocaoValor = promocaoValor;

                    turmaOrcamentoColecao.Add(turmaOrcamento);
                }

                return turmaOrcamentoColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar Orçamento. Detalhes: " + ex.Message);
            }
        }

        public string Excluir(TurmaOrcamento turmaOrcamento)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@ID_ORCAMENTO", turmaOrcamento.Orcamento.Id_Orcamento);
                acessoDados.AdicionarParametros("@ID_TURMA", turmaOrcamento.Turma.Id_Turma);
                acessoDados.AdicionarParametros("@ID_USUARIO", turmaOrcamento.Usuario.Id_Usuario);

                string idTurma = acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "USP_TURMA_ORCAMENTO_EXCLUIR").ToString();

                return idTurma;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
