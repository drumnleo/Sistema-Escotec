using AcessoBandoDados;
using ObjetoTransferencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class CaixaNegocios
    {
        readonly AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();

        public string AbreCaixa(Caixa caixa)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@USUARIO_ABRE", caixa.Func_Abre.Id_Usuario);
                acessoDados.AdicionarParametros("@USUARIO_RECEBE", caixa.Func_Recebe.Id_Usuario);
                acessoDados.AdicionarParametros("@VALOR_ABERTURA", caixa.Valor_Abertura);
                acessoDados.AdicionarParametros("@VALOR_SANGRIA", caixa.Valor_Sangria);
                acessoDados.AdicionarParametros("@DATA_CAIXA", caixa.Data_Caixa);

                string retorno = acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "USP_CAIXA_ABRE").ToString();

                return retorno;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string AtualizaCaixa(Caixa caixa)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@ID_CAIXA", caixa.Id_Caixa);
                acessoDados.AdicionarParametros("@USUARIO_ABRE", caixa.Func_Abre.Id_Usuario);
                acessoDados.AdicionarParametros("@USUARIO_RECEBE", caixa.Func_Recebe.Id_Usuario);
                acessoDados.AdicionarParametros("@VALOR_ABERTURA", caixa.Valor_Abertura);
                acessoDados.AdicionarParametros("@VALOR_SANGRIA", caixa.Valor_Sangria);
                acessoDados.AdicionarParametros("@DATA_CAIXA", caixa.Data_Caixa);

                string retorno = acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "USP_CAIXA_ATUALIZARPORID").ToString();

                return retorno;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string FechaCaixa(Caixa caixa)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@ID_CAIXA", caixa.Id_Caixa);
                acessoDados.AdicionarParametros("@ID_USUARIO", caixa.Func_Fechamento.Id_Usuario);

                string retorno = acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "USP_CAIXA_FECHA").ToString();

                return retorno;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string ExcluiCaixa(Caixa caixa)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@ID_CAIXA", caixa.Id_Caixa);


                string retorno = acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "USP_CAIXA_EXCLUIR").ToString();

                return retorno;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public CaixaColecao ConsultarPorData(DateTime dataInicial, DateTime dataFinal)
        {
            try
            {
                CaixaColecao caixaColecao = new CaixaColecao();

                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@DATA_INICIAL", dataInicial);
                acessoDados.AdicionarParametros("@DATA_FINAL", dataFinal);

                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "USP_CAIXA_CONSULTARPORDATA");

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    Caixa caixa = new Caixa();
                    caixa.Id_Caixa = Convert.ToInt32(dataRow["ID_CAIXA"]);
                    caixa.Data_Caixa = Convert.ToDateTime(dataRow["DATA_CAIXA"]);
                    caixa.Valor_Abertura = Convert.ToDecimal(dataRow["VALOR_ABERTURA"]);
                    caixa.Valor_Sangria = Convert.ToDecimal(dataRow["VALOR_SANGRIA"]);
                    caixa.Saldo = Convert.ToDecimal(dataRow["SALDO"]);
                    caixa.Situacao = Convert.ToString(dataRow["SITUACAO"]);
                    caixa.Data_Cadastro = Convert.ToDateTime(dataRow["DATA_CADASTRO"]);
                    caixa.Data_Ultima_Alteracao = Convert.ToDateTime(dataRow["DATA_ULTIMA_ALTERACAO"]);
                    if (dataRow["DATA_FECHAMENTO"].ToString() != "")
                    {
                        caixa.Data_Fechamento = Convert.ToDateTime(dataRow["DATA_FECHAMENTO"]);
                    }

                    Usuario usuarioRecebe = new Usuario();
                    usuarioRecebe.Nome_Usuario = Convert.ToString(dataRow["NOME_USUARIORECEBE"]);
                    usuarioRecebe.Id_Usuario = Convert.ToInt32(dataRow["USUARIO_RECEBE"]);

                    Usuario usuarioAbre = new Usuario();
                    usuarioAbre.Nome_Usuario = Convert.ToString(dataRow["NOME_USUARIOABRE"]);
                    usuarioAbre.Id_Usuario = Convert.ToInt32(dataRow["USUARIO_ABRE"]);

                    Usuario usuarioFecha = new Usuario();
                    if (dataRow["NOME_USUARIOFECHA"].ToString() != "")
                    {
                        usuarioFecha.Nome_Usuario = Convert.ToString(dataRow["NOME_USUARIOFECHA"]);
                        usuarioFecha.Id_Usuario = Convert.ToInt32(dataRow["USUARIO_FECHAMENTO"]);
                    }
        
                    caixa.Func_Abre = usuarioAbre;
                    caixa.Func_Fechamento = usuarioFecha;
                    caixa.Func_Recebe = usuarioRecebe;
                    caixaColecao.Add(caixa);
                }

                return caixaColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar caixa. Detalhes: " + ex.Message);
            }
        }

        public CaixaColecao ConsultarPorFuncRecebe(int id)
        {
            try
            {
                CaixaColecao caixaColecao = new CaixaColecao();

                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@ID_USUARIO_RECEBE", id);

                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "USP_CAIXA_CONSULTARPOR_ID_USUARIORECEBE");

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    Caixa caixa = new Caixa();
                    caixa.Id_Caixa = Convert.ToInt32(dataRow["ID_CAIXA"]);
                    caixa.Data_Caixa = Convert.ToDateTime(dataRow["DATA_CAIXA"]);
                    caixa.Valor_Abertura = Convert.ToDecimal(dataRow["VALOR_ABERTURA"]);
                    caixa.Valor_Sangria = Convert.ToDecimal(dataRow["VALOR_SANGRIA"]);
                    caixa.Saldo = Convert.ToDecimal(dataRow["SALDO"]);
                    caixa.Situacao = Convert.ToString(dataRow["SITUACAO"]);
                    caixa.Data_Cadastro = Convert.ToDateTime(dataRow["DATA_CADASTRO"]);
                    caixa.Data_Ultima_Alteracao = Convert.ToDateTime(dataRow["DATA_ULTIMA_ALTERACAO"]);
                    if (dataRow["DATA_FECHAMENTO"].ToString() != "")
                    {
                        caixa.Data_Fechamento = Convert.ToDateTime(dataRow["DATA_FECHAMENTO"]);
                    }

                    Usuario usuarioRecebe = new Usuario();
                    usuarioRecebe.Nome_Usuario = Convert.ToString(dataRow["NOME_USUARIORECEBE"]);
                    usuarioRecebe.Id_Usuario = Convert.ToInt32(dataRow["USUARIO_RECEBE"]);

                    Usuario usuarioAbre = new Usuario();
                    usuarioAbre.Nome_Usuario = Convert.ToString(dataRow["NOME_USUARIOABRE"]);
                    usuarioAbre.Id_Usuario = Convert.ToInt32(dataRow["USUARIO_ABRE"]);

                    Usuario usuarioFecha = new Usuario();
                    if (dataRow["NOME_USUARIOFECHA"].ToString() != "")
                    {
                        usuarioFecha.Nome_Usuario = Convert.ToString(dataRow["NOME_USUARIOFECHA"]);
                        usuarioFecha.Id_Usuario = Convert.ToInt32(dataRow["USUARIO_FECHAMENTO"]);
                    }



                    caixa.Func_Abre = usuarioAbre;
                    caixa.Func_Fechamento = usuarioFecha;
                    caixa.Func_Recebe = usuarioRecebe;
                    caixaColecao.Add(caixa);
                }

                return caixaColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar caixa. Detalhes: " + ex.Message);
            }
        }

        public CaixaColecao ConsultarPorIdCaixa(int id)
        {
            try
            {
                CaixaColecao caixaColecao = new CaixaColecao();

                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@ID_CAIXA", id);

                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "USP_CAIXA_CONSULTARPOR_ID_CAIXA");

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    Caixa caixa = new Caixa();
                    caixa.Id_Caixa = Convert.ToInt32(dataRow["ID_CAIXA"]);
                    caixa.Data_Caixa = Convert.ToDateTime(dataRow["DATA_CAIXA"]);
                    caixa.Valor_Abertura = Convert.ToDecimal(dataRow["VALOR_ABERTURA"]);
                    caixa.Valor_Sangria = Convert.ToDecimal(dataRow["VALOR_SANGRIA"]);
                    caixa.Saldo = Convert.ToDecimal(dataRow["SALDO"]);
                    caixa.Situacao = Convert.ToString(dataRow["SITUACAO"]);
                    caixa.Data_Cadastro = Convert.ToDateTime(dataRow["DATA_CADASTRO"]);
                    caixa.Data_Ultima_Alteracao = Convert.ToDateTime(dataRow["DATA_ULTIMA_ALTERACAO"]);
                    if (dataRow["DATA_FECHAMENTO"].ToString() != "")
                    {
                        caixa.Data_Fechamento = Convert.ToDateTime(dataRow["DATA_FECHAMENTO"]);
                    }

                    Usuario usuarioRecebe = new Usuario();
                    usuarioRecebe.Nome_Usuario = Convert.ToString(dataRow["NOME_USUARIORECEBE"]);
                    usuarioRecebe.Id_Usuario = Convert.ToInt32(dataRow["USUARIO_RECEBE"]);

                    Usuario usuarioAbre = new Usuario();
                    usuarioAbre.Nome_Usuario = Convert.ToString(dataRow["NOME_USUARIOABRE"]);
                    usuarioAbre.Id_Usuario = Convert.ToInt32(dataRow["USUARIO_ABRE"]);

                    Usuario usuarioFecha = new Usuario();
                    if (dataRow["NOME_USUARIOFECHA"].ToString() != "")
                    {
                        usuarioFecha.Nome_Usuario = Convert.ToString(dataRow["NOME_USUARIOFECHA"]);
                        usuarioFecha.Id_Usuario = Convert.ToInt32(dataRow["USUARIO_FECHAMENTO"]);
                    }



                    caixa.Func_Abre = usuarioAbre;
                    caixa.Func_Fechamento = usuarioFecha;
                    caixa.Func_Recebe = usuarioRecebe;
                    caixaColecao.Add(caixa);
                }

                return caixaColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar caixa. Detalhes: " + ex.Message);
            }
        }

        public CaixaColecao ConsultarTodos()
        {
            try
            {
                CaixaColecao caixaColecao = new CaixaColecao();

                acessoDados.LimparParametros();

                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "USP_CAIXA_CONSULTARTODOSABERTOS");

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    Caixa caixa = new Caixa();
                    caixa.Id_Caixa = Convert.ToInt32(dataRow["ID_CAIXA"]);
                    caixa.Data_Caixa = Convert.ToDateTime(dataRow["DATA_CAIXA"]);
                    caixa.Valor_Abertura = Convert.ToDecimal(dataRow["VALOR_ABERTURA"]);
                    caixa.Valor_Sangria = Convert.ToDecimal(dataRow["VALOR_SANGRIA"]);
                    caixa.Saldo = Convert.ToDecimal(dataRow["SALDO"]);
                    caixa.Situacao = Convert.ToString(dataRow["SITUACAO"]);
                    caixa.Data_Cadastro = Convert.ToDateTime(dataRow["DATA_CADASTRO"]);
                    caixa.Data_Ultima_Alteracao = Convert.ToDateTime(dataRow["DATA_ULTIMA_ALTERACAO"]);
                    if (dataRow["DATA_FECHAMENTO"].ToString() != "")
                    {
                        caixa.Data_Fechamento = Convert.ToDateTime(dataRow["DATA_FECHAMENTO"]);
                    }

                    Usuario usuarioRecebe = new Usuario();
                    usuarioRecebe.Nome_Usuario = Convert.ToString(dataRow["NOME_USUARIORECEBE"]);
                    usuarioRecebe.Id_Usuario = Convert.ToInt32(dataRow["USUARIO_RECEBE"]);

                    Usuario usuarioAbre = new Usuario();
                    usuarioAbre.Nome_Usuario = Convert.ToString(dataRow["NOME_USUARIOABRE"]);
                    usuarioAbre.Id_Usuario = Convert.ToInt32(dataRow["USUARIO_ABRE"]);

                    Usuario usuarioFecha = new Usuario();
                    if (dataRow["NOME_USUARIOFECHA"].ToString() != "")
                    {
                        usuarioFecha.Nome_Usuario = Convert.ToString(dataRow["NOME_USUARIOFECHA"]);
                        usuarioFecha.Id_Usuario = Convert.ToInt32(dataRow["USUARIO_FECHAMENTO"]);
                    }



                    caixa.Func_Abre = usuarioAbre;
                    caixa.Func_Fechamento = usuarioFecha;
                    caixa.Func_Recebe = usuarioRecebe;
                    caixaColecao.Add(caixa);
                }

                return caixaColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar caixa. Detalhes: " + ex.Message);
            }
        }

        public string MovimentoCaixaPadrao(MovimentoCaixa movimentoCaixa)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@ID_CAIXA", movimentoCaixa.Caixa.Id_Caixa);
                acessoDados.AdicionarParametros("@ID_TIPO_MOVIMENTO", movimentoCaixa.TipoMovimentoCaixa.Id_Tipo_Movimento);
                acessoDados.AdicionarParametros("@ID_CONTA_RECEBER", movimentoCaixa.ContasReceber.Id_Conta_Receber);
                acessoDados.AdicionarParametros("@DESCONTO", movimentoCaixa.Desconto);
                acessoDados.AdicionarParametros("@ID_USUARIO", movimentoCaixa.Usuario.Id_Usuario);

                string retorno = acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "USP_MOVIMENTA_CAIXA_PADRAO").ToString();

                return retorno;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string MovimentoCaixaEstorno(MovimentoCaixa movimentoCaixa)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@ID_CAIXA", movimentoCaixa.Caixa.Id_Caixa);
                acessoDados.AdicionarParametros("@ID_MOV_CAIXA", movimentoCaixa.Id_Mov_Caixa);
                acessoDados.AdicionarParametros("@VALOR", movimentoCaixa.Valor_Final);
                acessoDados.AdicionarParametros("@ID_CONTA_RECEBER", movimentoCaixa.ContasReceber.Id_Conta_Receber);
                acessoDados.AdicionarParametros("@USUARIO_AUT_ESTORNO", movimentoCaixa.Usuario_Aut_Estorno.Id_Usuario);
                acessoDados.AdicionarParametros("@ID_USUARIO", movimentoCaixa.Usuario.Id_Usuario);

                string retorno = acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "USP_MOVIMENTA_CAIXA_ESTORNO").ToString();

                return retorno;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string MovimentoCaixaSangria(MovimentoCaixa movimentoCaixa)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@ID_CAIXA", movimentoCaixa.Caixa.Id_Caixa);
                acessoDados.AdicionarParametros("@ID_TIPO_MOVIMENTO", movimentoCaixa.TipoMovimentoCaixa.Id_Tipo_Movimento);
                acessoDados.AdicionarParametros("@VALOR", movimentoCaixa.Valor_Final);
                acessoDados.AdicionarParametros("@ID_USUARIO_SANGRIA", movimentoCaixa.Usuario_Aut_Estorno.Id_Usuario);
                acessoDados.AdicionarParametros("@ID_USUARIO", movimentoCaixa.Usuario.Id_Usuario);

                string retorno = acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "USP_MOVIMENTA_CAIXA_SANGRIA").ToString();

                return retorno;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public MovimentoCaixaColecao ConsultarMovimentoPorIdCaixa(int id)
        {
            try
            {
                MovimentoCaixaColecao movimentoCaixas = new MovimentoCaixaColecao();
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@ID_CAIXA", id);

                DataTable dt = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "USP_MOVIMENTOCAIXA_BUSCARPORIDCAIXA");

                foreach (DataRow dataRow in dt.Rows)
                {
                    MovimentoCaixa movimentoCaixa = new MovimentoCaixa();
                    movimentoCaixa.Id_Mov_Caixa = Convert.ToInt32(dataRow["ID_MOV_CAIXA"]);
                    movimentoCaixa.Saida_Entrada = Convert.ToString(dataRow["SAIDA_ENTRADA"]);
                    movimentoCaixa.Valor = Convert.ToDecimal(dataRow["VALOR"]);
                    movimentoCaixa.Desconto = Convert.ToInt16(dataRow["DESCONTO"]);
                    movimentoCaixa.Valor_Final = Convert.ToDecimal(dataRow["VALOR_FINAL"]);
                    movimentoCaixa.Data_Movimento = Convert.ToDateTime(dataRow["DATA_MOVIMENTO"]);

                    movimentoCaixa.Caixa = new Caixa();
                    movimentoCaixa.Caixa.Id_Caixa = Convert.ToInt32(dataRow["ID_CAIXA"]);

                    movimentoCaixa.TipoMovimentoCaixa = new TipoMovimentoCaixa();
                    movimentoCaixa.TipoMovimentoCaixa.Id_Tipo_Movimento = Convert.ToInt32(dataRow["ID_TIPO_MOVIMENTO"]);

                    movimentoCaixa.ContasReceber = new ContasReceber();
                    movimentoCaixa.ContasReceber.Id_Conta_Receber = Convert.ToInt32(dataRow["ID_CONTA_RECEBER"]);

                    movimentoCaixa.Usuario_Aut_Estorno = new Usuario();
                    if (int.TryParse(dataRow["USUARIO_AUT_ESTORNO"].ToString(), out int v))
                    {
                        movimentoCaixa.Usuario_Aut_Estorno.Id_Usuario = v;
                    }

                    movimentoCaixa.Usuario_Aut_Desc = new Usuario();
                    if (int.TryParse(dataRow["USUARIO_AUT_DESCONTO"].ToString(), out int x))
                    {
                        movimentoCaixa.Usuario_Aut_Desc.Id_Usuario = x;
                    }

                    movimentoCaixa.Usuario = new Usuario();
                    movimentoCaixa.Usuario.Id_Usuario = Convert.ToInt32(dataRow["USUARIO_CAD_ALT"]);

                    movimentoCaixas.Add(movimentoCaixa);
                }

                return movimentoCaixas;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar movimento. Detalhes: " + ex.Message);
            }
        }

        public MovimentoCaixaColecao ConsultarMovimentoPorId(int id)
        {
            try
            {
                MovimentoCaixaColecao movimentoCaixas = new MovimentoCaixaColecao();
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@ID_MOV_CAIXA", id);

                DataTable dt = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "USP_MOVIMENTOCAIXA_BUSCARPORID");

                foreach (DataRow dataRow in dt.Rows)
                {
                    MovimentoCaixa movimentoCaixa = new MovimentoCaixa();
                    movimentoCaixa.Id_Mov_Caixa = Convert.ToInt32(dataRow["ID_MOV_CAIXA"]);
                    movimentoCaixa.Saida_Entrada = Convert.ToString(dataRow["SAIDA_ENTRADA"]);
                    movimentoCaixa.Valor = Convert.ToDecimal(dataRow["VALOR"]);
                    movimentoCaixa.Desconto = Convert.ToInt16(dataRow["DESCONTO"]);
                    movimentoCaixa.Valor_Final = Convert.ToDecimal(dataRow["VALOR_FINAL"]);
                    movimentoCaixa.Data_Movimento = Convert.ToDateTime(dataRow["DATA_MOVIMENTO"]);

                    movimentoCaixa.Caixa = new Caixa();
                    movimentoCaixa.Caixa.Id_Caixa = Convert.ToInt32(dataRow["ID_CAIXA"]);

                    movimentoCaixa.TipoMovimentoCaixa = new TipoMovimentoCaixa();
                    movimentoCaixa.TipoMovimentoCaixa.Id_Tipo_Movimento = Convert.ToInt32(dataRow["ID_TIPO_MOVIMENTO"]);

                    movimentoCaixa.ContasReceber = new ContasReceber();
                    movimentoCaixa.ContasReceber.Id_Conta_Receber = Convert.ToInt32(dataRow["ID_CONTA_RECEBER"]);

                    movimentoCaixa.Usuario_Aut_Estorno = new Usuario();
                    if (int.TryParse(dataRow["USUARIO_AUT_ESTORNO"].ToString(), out int v))
                    {
                        movimentoCaixa.Usuario_Aut_Estorno.Id_Usuario = v;
                    }

                    movimentoCaixa.Usuario_Aut_Desc = new Usuario();
                    if (int.TryParse(dataRow["USUARIO_AUT_DESCONTO"].ToString(), out int x))
                    {
                        movimentoCaixa.Usuario_Aut_Desc.Id_Usuario = x;
                    }

                    movimentoCaixa.Usuario = new Usuario();
                    movimentoCaixa.Usuario.Id_Usuario = Convert.ToInt32(dataRow["USUARIO_CAD_ALT"]);

                    movimentoCaixas.Add(movimentoCaixa);
                }

                return movimentoCaixas;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar movimento. Detalhes: " + ex.Message);
            }
        }
    }
}
