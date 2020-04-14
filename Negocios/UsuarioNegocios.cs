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
        readonly AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();

        public string Inserir(Usuario usuario)
        {
            try
            {

                Pessoa pessoa = new Pessoa();
                acessoDados.AdicionarParametros("@ID_PESSOA", pessoa.Id_Pessoa);

                Funcionario funcionario = new Funcionario();
                acessoDados.AdicionarParametros("@ID_FUNCIONARIO", funcionario.Id_Funcionario);


                GrupoTipo grupoTipo = new GrupoTipo();
                acessoDados.AdicionarParametros("@ID_GRUPO", grupoTipo.Id_Grupo);

                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@ID_PESSOA", pessoa);
                acessoDados.AdicionarParametros("@ID_FUNCIONARIO", funcionario);
                acessoDados.AdicionarParametros("@ID_GRUPO", grupoTipo);
                acessoDados.AdicionarParametros("@USUARIO", usuario.Nome_Usuario);
                acessoDados.AdicionarParametros("@SENHA", usuario.Senha);
                acessoDados.AdicionarParametros("@EMAIL_PROFISSIONAL", usuario.Email_Profissional);




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
                    usuario.Nome_Usuario = Convert.ToString(dataRow["USUARIO"]);
                    usuario.Senha = Convert.ToString(dataRow["SENHA"]);

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
