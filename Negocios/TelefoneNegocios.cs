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
    public class TelefoneNegocios
    {
        AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();

        public string Inserir(Telefone telefone)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@ID_TIPO_TELEFONE", telefone.TipoTelefone.Id_Tipo_Telefone);
                acessoDados.AdicionarParametros("@TELEFONE", telefone.Num_Telefone);
                acessoDados.AdicionarParametros("@DDD", telefone.DDD);
                acessoDados.AdicionarParametros("@RAMAL", telefone.Ramal);
                acessoDados.AdicionarParametros("@ID_USUARIO ", telefone.Usuario.Id_Usuario);

                string IdTelefone = acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "USP_TELEFONE_INSERIR").ToString();

                return IdTelefone;
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
        public TelefoneColecao ConsultarPorNome(string nome)
        {
            try
            {
                TelefoneColecao telefoneColecao = new TelefoneColecao();

                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@NOME", nome);

                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "USP_TELEFONE_CONSULTARPORNOMEPESSOA");

                foreach(DataRow dataRow in dataTable.Rows)
                {
                    Telefone telefone = new Telefone();

                    telefone.Id_Telefone = Convert.ToInt32(dataRow["ID_TELEFONE"]);
                    telefone.DDD = Convert.ToInt16(dataRow["DDD"]);
                    telefone.Num_Telefone = Convert.ToString(dataRow["TELEFONE"]);
                    telefone.Ramal = Convert.ToInt16(dataRow["RAMAL"]);
                    telefone.Data_Cadastro = Convert.ToDateTime(dataRow["DATA_CADASTRO "]);
                    telefone.Data_Ultima_Alteracao = Convert.ToDateTime(dataRow["DATA_ULTIMA_ALTERACAO"]);

                    TipoTelefone tipoTelefone = new TipoTelefone();
                    tipoTelefone.Id_Tipo_Telefone = Convert.ToInt32(dataRow["ID_TIPO_TELEFONE"]);
                    tipoTelefone.Descricao = Convert.ToString(dataRow["DESCRICAO"]);

                    Pessoa pessoa = new Pessoa();
                    pessoa.Id_Pessoa = Convert.ToInt32(dataRow["ID_PESSOA"]);

                    Usuario usuarioCadAlt = new Usuario();
                    if (dataRow["USUARIO_CAD_ALT"].ToString() != "")
                    {
                        usuarioCadAlt.Id_Usuario = Convert.ToInt32(dataRow["USUARIO_CAD_ALT"]);
                    }

                    telefone.TipoTelefone = tipoTelefone;
                    telefone.Pessoa = pessoa;
                    telefoneColecao.Add(telefone);

                }
                return telefoneColecao;
               
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao consultar telefone. Detalhes" + ex.Message);
            }
        }

        public string Excluir(Telefone telefone)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@ID_TELEFONE", telefone.Id_Telefone);
                acessoDados.AdicionarParametros("@ID_USUARIO", telefone.Usuario.Id_Usuario);

                string IdTelefone = acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "USP_TELEFONE_EXCLUIR").ToString();
                return IdTelefone
            }
            catch (Exception ex )
            {

                return ex.Message;
            }

        }


    }

}
