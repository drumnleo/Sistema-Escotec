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
    public class UsuarioNegocios
    {
        AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();

        public string Inserir(Usuario usuario)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@NOME", usuario.Nome);
                acessoDados.AdicionarParametros("@SOBRENOME", usuario.Sobrenome);
                acessoDados.AdicionarParametros("@DATA_ADMISSAO", usuario.Data_Admissao);
                acessoDados.AdicionarParametros("@USUARIO", usuario.Nome_Usuario);
                acessoDados.AdicionarParametros("@SENHA", usuario.Senha);
                acessoDados.AdicionarParametros("@EMAIL", usuario.Email);
                acessoDados.AdicionarParametros("ID_GRUPO", usuario.grupoTipo.ID_GRUPO);

                string idusuario = acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "USP_USUARIO_INSERIR").ToString();

                return idusuario;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public UsuarioColecao ConsultarPorNome(string nome)
        {
            try
            {
                UsuarioColecao usuarioColecao = new UsuarioColecao();

                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@NOME", nome);

                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "USP_USUARIO_CONSULTARPORNOME");

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    Usuario usuario = new Usuario();

                    usuario.Id_Usuario = Convert.ToInt32(dataRow["ID_USUARIO"]);
                    usuario.Nome = Convert.ToString(dataRow["NOME"]);
                    usuario.Sobrenome = Convert.ToString(dataRow["SBORENOME"]);
                    usuario.Data_Admissao = Convert.ToDateTime(dataRow["DATA_ADMISSAO"]);
                    usuario.Nome_Usuario = Convert.ToString(dataRow["USUARIO"]);
                    usuario.Senha = Convert.ToString(dataRow["SENHA"]);
                    usuario.Email = Convert.ToString(dataRow["EMAIL"]);

                    usuarioColecao.Add(usuario);
                }

                return usuarioColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar Usuário. Detalhes" + ex.Message);
            }
        }

        public string Excluir(Usuario usuario)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("ID_USUARIO", usuario.Id_Usuario);
                string id_usuario = acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "USP_USUARIO_EXCLUIR").ToString();
                return id_usuario;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

    }
}
