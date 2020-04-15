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
                acessoDados.AdicionarParametros("@ID_PESSOA", orcamento.Pessoa.Id_Pessoa);
                acessoDados.AdicionarParametros("@ID_PROMOCAO_VALOR", orcamento.PromocaoValor.Id_Promocao_Valor);
                acessoDados.AdicionarParametros("@ID_TURMA_1", orcamento.Turma1.Id_Turma);
                acessoDados.AdicionarParametros("@ID_TURMA_2", orcamento.Turma2.Id_Turma);
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
                acessoDados.AdicionarParametros("@ID_PROMOCAO_VALOR", orcamento.PromocaoValor.Id_Promocao_Valor);
                acessoDados.AdicionarParametros("@ID_TURMA_1", orcamento.Turma1.Id_Turma);
                acessoDados.AdicionarParametros("@ID_TURMA_2", orcamento.Turma2.Id_Turma);
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

        public OrcamentoColecao ConsultarPorPessoa(int idPessoa)
        {
            try
            {
                OrcamentoColecao orcamentoColecao = new OrcamentoColecao();

                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@ID_PESSOA", idPessoa);

                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "USP_ORCAMENTO_CONSULTARPORPESSOA");

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    Orcamento orcamento = new Orcamento();

                    orcamento.Id_Orcamento = Convert.ToInt32(dataRow["ID_ORCAMENTO"]);
                    orcamento.Valor_Entrada_Turma_1 = Convert.ToDecimal(dataRow["VALOR_ENTRADA_TURMA_1"]);
                    orcamento.Valor_DemaisParcelas_Turma_1 = Convert.ToDecimal(dataRow["VALOR_DEMAISPARCELAS_TURMA_1"]);
                    orcamento.Valor_Entrada_Turma_2 = Convert.ToDecimal(dataRow["VALOR_ENTRADA_TURMA_2"]);
                    orcamento.valor_DemaisParcelas_Turma_2 = Convert.ToDecimal(dataRow["VALOR_DEMAISPARCELAS_TURMA_2"]);
                    orcamento.Validade_Orcamento = Convert.ToDateTime(dataRow["VALIDADE_ORCAMENTO"]);
                    orcamento.Data_Cadastro = Convert.ToDateTime(dataRow["DATA_CADASTRO"]);
                    orcamento.Data_Ultima_Alteracao = Convert.ToDateTime(dataRow["DATA_ULTIMA_ALTERACAO"]);
                    orcamento.Aprovado = Convert.ToBoolean(dataRow["APROVADO"]);
                    orcamento.Comentario_Aprovacao = Convert.ToString(dataRow["COMENTARIO_APROVACAO"]);

                    Usuario usuario = new Usuario();
                    usuario.Id_Usuario = Convert.ToInt32(dataRow["USUARIO_CAD_ALT"]);

                    Usuario usuario_2 = new Usuario();
                    usuario_2.Id_Usuario = Convert.ToInt32(dataRow["APROVADO_USUARIO"]);

                    Turma turma_1 = new Turma();
                    turma_1.Id_Turma = Convert.ToInt32(dataRow["ID_TURMA_1"]);

                    Turma turma_2 = new Turma();
                    turma_2.Id_Turma = Convert.ToInt32(dataRow["ID_TURMA_2"]);

                    Pessoa pessoa = new Pessoa();
                    pessoa.Id_Pessoa = Convert.ToInt32(dataRow["ID_PESSOA"]);

                    PromocaoValor promocaoValor = new PromocaoValor();
                    promocaoValor.Id_Promocao_Valor = Convert.ToInt32(dataRow["ID_PROMOCAO_VALOR"]);

                    orcamento.Usuario_Cad_Alt = usuario;
                    orcamento.Aprovado_Usuario = usuario_2;
                    orcamento.Turma1 = turma_1;
                    orcamento.Turma2 = turma_2;
                    orcamento.Pessoa = pessoa;
                    orcamento.PromocaoValor = promocaoValor;
                    orcamentoColecao.Add(orcamento);
                }

                return orcamentoColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar tipo de apostila. Detalhes: " + ex.Message);
            }
        }
    }
}
