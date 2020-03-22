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

        public string Inserir(Usuario usuario, Foto foto)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@ID_PESSOA", usuario.Pessoa.Id_Pessoa);
                acessoDados.AdicionarParametros("@ID_FUNCIONARIO", usuario.funcionario.Id_Funcionario);
                acessoDados.AdicionarParametros("@ID_GRUPO", usuario.grupoTipo.Id_Grupo);
                acessoDados.AdicionarParametros("@USUARIO", usuario.Nome_Usuario);
                acessoDados.AdicionarParametros("@SENHA", usuario.Senha);
                acessoDados.AdicionarParametros("@FOTO", foto.Arquivo_Foto);


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
