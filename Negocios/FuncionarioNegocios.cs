using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjetoTransferencia;
using AcessoBandoDados;
using System.Data;

namespace Negocios
{
    public class FuncionarioNegocios
    {
        private readonly AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();
        public string Inserir(Funcionario funcionario)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@ID_PESSOA", funcionario.Id_Pessoa);
                acessoDados.AdicionarParametros("@DATA_ADMISSAO", funcionario.Data_Admissao);
                acessoDados.AdicionarParametros("@HORA_ENTRADA", funcionario.Hora_Entrada);
                acessoDados.AdicionarParametros("@HORA_SAIDA", funcionario.Hora_Saida);
                acessoDados.AdicionarParametros("@NUM_CTPS", funcionario.Num_CTPS);
                acessoDados.AdicionarParametros("@SERIE_CTPS", funcionario.Serie_CTPS);
                acessoDados.AdicionarParametros("@NUMERO_NIS", funcionario.Num_NIS);
                acessoDados.AdicionarParametros("@ID_USUARIO", funcionario.Usuario_Cad_Alt);

                string idFuncionario = acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "USP_FUNCIONARIO_INSERIR").ToString();

                return idFuncionario;
            }
            catch (Exception ex)
            {

                return ex.Message;
            }

        }

        public string AtualizarporId(Funcionario funcionario)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@ID_FUNCIONARIO", funcionario.Id_Funcionario);
                acessoDados.AdicionarParametros("@ID_PESSOA", funcionario.Id_Pessoa);
                acessoDados.AdicionarParametros("@DATA_ADMISSAO", funcionario.Data_Admissao);
                acessoDados.AdicionarParametros("@HORA_ENTRADA", funcionario.Hora_Entrada);
                acessoDados.AdicionarParametros("@HORA_SAIDA", funcionario.Hora_Saida);
                acessoDados.AdicionarParametros("@NUM_CTPS", funcionario.Num_CTPS);
                acessoDados.AdicionarParametros("@SERIE_CTPS", funcionario.Serie_CTPS);
                acessoDados.AdicionarParametros("@NUMERO_NIS", funcionario.Num_NIS);
                acessoDados.AdicionarParametros("@ID_USUARIO", funcionario.Usuario_Cad_Alt);

                string idFuncionario = acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "USP_FUNCIONARIO_ATUALIZARPORID").ToString();

                return idFuncionario;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Excluir(Funcionario funcionario)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("ID_FUNCIONARIO", funcionario.Id_Funcionario);
                acessoDados.AdicionarParametros("ID_USUARIO", funcionario.Usuario_Cad_Alt);
                string idFuncionario = acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "USP_FUNCIONARIO_EXCLUIR").ToString();
                return idFuncionario;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

    }
}
