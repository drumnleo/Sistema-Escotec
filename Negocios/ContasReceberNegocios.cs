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
    public class ContasReceberNegocios
    {
        AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();

        public ContasReceberColecao ConsultarPorIdMatricula(int id)
        {
            try
            {
                ContasReceberColecao contasReceberColecao = new ContasReceberColecao();

                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@ID_MATRICULA", id);

                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "USP_CONSULTAPARCELASMATRICULA");

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    ContasReceber contasReceber = new ContasReceber();
                    contasReceber.Id_Conta_Receber = Convert.ToInt32(dataRow["ID_CONTA_RECEBER"]);
                    contasReceber.Numero_Parcela = Convert.ToInt16(dataRow["NUMERO_PARCELA"]);
                    contasReceber.Total_Parcelas = Convert.ToInt16(dataRow["TOTAL_PARCELAS"]);
                    contasReceber.Valor = Convert.ToDecimal(dataRow["VALOR"]);
                    contasReceber.Data_Cadastro = Convert.ToDateTime(dataRow["DATA_CADASTRO"]);
                    contasReceber.Vencimento = Convert.ToDateTime(dataRow["VENCIMENTO"]);
                    contasReceber.Acrescimo_Atraso = Convert.ToInt16(dataRow["ACRESCIMO_ATRASO"]);
                    contasReceber.Situacao_Pg = Convert.ToChar(dataRow["SITUACAO_PG"]);
                    if (dataRow["DATA_PAGAMENTO"].ToString() != "")
                    {
                        contasReceber.Data_Pagamento = Convert.ToDateTime(dataRow["DATA_PAGAMENTO"]);
                    }
                    if (dataRow["DATA_ULTIMA_ALTERACAO"].ToString() != "")
                    {
                        contasReceber.Data_Pagamento = Convert.ToDateTime(dataRow["DATA_ULTIMA_ALTERACAO"]);
                    }

                    TipoConta tipoConta = new TipoConta();
                    tipoConta.Id_Tipo_Conta = Convert.ToInt32(dataRow["ID_TIPO_CONTA"]);

                    Matricula matricula = new Matricula();
                    matricula.Id_Matricula = Convert.ToInt32(dataRow["ID_MATRICULA"]);

                    Aluno aluno = new Aluno();
                    aluno.Id_Aluno = Convert.ToInt32(dataRow["ID_ALUNO"]);
                    matricula.Aluno = aluno;

                    Usuario usuario = new Usuario();
                    usuario.Id_Usuario = Convert.ToInt32(dataRow["USUARIO_CAD_ALT"]);

                    contasReceber.TipoConta = tipoConta;
                    contasReceber.Matricula = matricula;
                    contasReceber.Usuario = usuario;
                    contasReceberColecao.Add(contasReceber);
                }

                return contasReceberColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar Funcionário. Detalhes: " + ex.Message);
            }

        }

        public ContasReceberColecao ConsultarPorIdConta(int id)
        {
            try
            {
                ContasReceberColecao contasReceberColecao = new ContasReceberColecao();

                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@ID_CONTA_RECEBER", id);

                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "USP_CONSULTAPARCELASMATRICULAPORIDCONTA");

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    ContasReceber contasReceber = new ContasReceber();
                    contasReceber.Id_Conta_Receber = Convert.ToInt32(dataRow["ID_CONTA_RECEBER"]);
                    contasReceber.Numero_Parcela = Convert.ToInt16(dataRow["NUMERO_PARCELA"]);
                    contasReceber.Total_Parcelas = Convert.ToInt16(dataRow["TOTAL_PARCELAS"]);
                    contasReceber.Valor = Convert.ToDecimal(dataRow["VALOR"]);
                    contasReceber.Data_Cadastro = Convert.ToDateTime(dataRow["DATA_CADASTRO"]);
                    contasReceber.Vencimento = Convert.ToDateTime(dataRow["VENCIMENTO"]);
                    contasReceber.Acrescimo_Atraso = Convert.ToInt16(dataRow["ACRESCIMO_ATRASO"]);
                    contasReceber.Situacao_Pg = Convert.ToChar(dataRow["SITUACAO_PG"]);
                    if (dataRow["DATA_PAGAMENTO"].ToString() != "")
                    {
                        contasReceber.Data_Pagamento = Convert.ToDateTime(dataRow["DATA_PAGAMENTO"]);
                    }
                    if (dataRow["DATA_ULTIMA_ALTERACAO"].ToString() != "")
                    {
                        contasReceber.Data_Pagamento = Convert.ToDateTime(dataRow["DATA_ULTIMA_ALTERACAO"]);
                    }

                    TipoConta tipoConta = new TipoConta();
                    tipoConta.Id_Tipo_Conta = Convert.ToInt32(dataRow["ID_TIPO_CONTA"]);

                    Matricula matricula = new Matricula();
                    matricula.Id_Matricula = Convert.ToInt32(dataRow["ID_MATRICULA"]);

                    Aluno aluno = new Aluno();
                    aluno.Id_Aluno = Convert.ToInt32(dataRow["ID_ALUNO"]);
                    matricula.Aluno = aluno;

                    Usuario usuario = new Usuario();
                    usuario.Id_Usuario = Convert.ToInt32(dataRow["USUARIO_CAD_ALT"]);

                    contasReceber.TipoConta = tipoConta;
                    contasReceber.Matricula = matricula;
                    contasReceber.Usuario = usuario;
                    contasReceberColecao.Add(contasReceber);
                }

                return contasReceberColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar Funcionário. Detalhes: " + ex.Message);
            }

        }

        public ContasReceberColecao ConsultarPorIdContaPaga(int id)
        {
            try
            {
                ContasReceberColecao contasReceberColecao = new ContasReceberColecao();

                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@ID_CONTA_RECEBER", id);

                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "USP_CONSULTAPARCELASMATRICULAPORIDCONTAPAGA");

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    ContasReceber contasReceber = new ContasReceber();
                    contasReceber.Id_Conta_Receber = Convert.ToInt32(dataRow["ID_CONTA_RECEBER"]);
                    contasReceber.Numero_Parcela = Convert.ToInt16(dataRow["NUMERO_PARCELA"]);
                    contasReceber.Total_Parcelas = Convert.ToInt16(dataRow["TOTAL_PARCELAS"]);
                    contasReceber.Valor = Convert.ToDecimal(dataRow["VALOR"]);
                    contasReceber.Data_Cadastro = Convert.ToDateTime(dataRow["DATA_CADASTRO"]);
                    contasReceber.Vencimento = Convert.ToDateTime(dataRow["VENCIMENTO"]);
                    contasReceber.Acrescimo_Atraso = Convert.ToInt16(dataRow["ACRESCIMO_ATRASO"]);
                    contasReceber.Situacao_Pg = Convert.ToChar(dataRow["SITUACAO_PG"]);
                    if (dataRow["DATA_PAGAMENTO"].ToString() != "")
                    {
                        contasReceber.Data_Pagamento = Convert.ToDateTime(dataRow["DATA_PAGAMENTO"]);
                    }
                    if (dataRow["DATA_ULTIMA_ALTERACAO"].ToString() != "")
                    {
                        contasReceber.Data_Pagamento = Convert.ToDateTime(dataRow["DATA_ULTIMA_ALTERACAO"]);
                    }

                    TipoConta tipoConta = new TipoConta();
                    tipoConta.Id_Tipo_Conta = Convert.ToInt32(dataRow["ID_TIPO_CONTA"]);

                    Matricula matricula = new Matricula();
                    matricula.Id_Matricula = Convert.ToInt32(dataRow["ID_MATRICULA"]);

                    Aluno aluno = new Aluno();
                    aluno.Id_Aluno = Convert.ToInt32(dataRow["ID_ALUNO"]);
                    matricula.Aluno = aluno;

                    Usuario usuario = new Usuario();
                    usuario.Id_Usuario = Convert.ToInt32(dataRow["USUARIO_CAD_ALT"]);

                    contasReceber.TipoConta = tipoConta;
                    contasReceber.Matricula = matricula;
                    contasReceber.Usuario = usuario;
                    contasReceberColecao.Add(contasReceber);
                }

                return contasReceberColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar Funcionário. Detalhes: " + ex.Message);
            }

        }

        public ContasReceberColecao ConsultarPorCPF(string cpf)
        {
            try
            {
                ContasReceberColecao contasReceberColecao = new ContasReceberColecao();

                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@CPF", cpf);

                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "USP_CONSULTAPARCELASMATRICULAPORCPF");

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    ContasReceber contasReceber = new ContasReceber();
                    contasReceber.Id_Conta_Receber = Convert.ToInt32(dataRow["ID_CONTA_RECEBER"]);
                    contasReceber.Numero_Parcela = Convert.ToInt16(dataRow["NUMERO_PARCELA"]);
                    contasReceber.Total_Parcelas = Convert.ToInt16(dataRow["TOTAL_PARCELAS"]);
                    contasReceber.Valor = Convert.ToDecimal(dataRow["VALOR"]);
                    contasReceber.Data_Cadastro = Convert.ToDateTime(dataRow["DATA_CADASTRO"]);
                    contasReceber.Vencimento = Convert.ToDateTime(dataRow["VENCIMENTO"]);
                    contasReceber.Acrescimo_Atraso = Convert.ToInt16(dataRow["ACRESCIMO_ATRASO"]);
                    contasReceber.Situacao_Pg = Convert.ToChar(dataRow["SITUACAO_PG"]);
                    if (dataRow["DATA_PAGAMENTO"].ToString() != "")
                    {
                        contasReceber.Data_Pagamento = Convert.ToDateTime(dataRow["DATA_PAGAMENTO"]);
                    }
                    if (dataRow["DATA_ULTIMA_ALTERACAO"].ToString() != "")
                    {
                        contasReceber.Data_Pagamento = Convert.ToDateTime(dataRow["DATA_ULTIMA_ALTERACAO"]);
                    }

                    TipoConta tipoConta = new TipoConta();
                    tipoConta.Id_Tipo_Conta = Convert.ToInt32(dataRow["ID_TIPO_CONTA"]);

                    Matricula matricula = new Matricula();
                    matricula.Id_Matricula = Convert.ToInt32(dataRow["ID_MATRICULA"]);

                    Aluno aluno = new Aluno();
                    aluno.Id_Aluno = Convert.ToInt32(dataRow["ID_ALUNO"]);
                    matricula.Aluno = aluno;

                    Usuario usuario = new Usuario();
                    usuario.Id_Usuario = Convert.ToInt32(dataRow["USUARIO_CAD_ALT"]);

                    contasReceber.TipoConta = tipoConta;
                    contasReceber.Matricula = matricula;
                    contasReceber.Usuario = usuario;
                    contasReceberColecao.Add(contasReceber);
                }

                return contasReceberColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar Funcionário. Detalhes: " + ex.Message);
            }

        }
    }
}
