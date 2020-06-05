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

                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@ID_FUNCIONARIO", usuario.Funcionario.Id_Funcionario);
                acessoDados.AdicionarParametros("@ID_GRUPO", usuario.GrupoUsuario.Id_Grupo);
                acessoDados.AdicionarParametros("@NOME_USUARIO", usuario.Nome_Usuario);
                acessoDados.AdicionarParametros("@SENHA", usuario.Senha);
                acessoDados.AdicionarParametros("@EMAIL_PROFISSIONAL", usuario.Email_Profissional);
                acessoDados.AdicionarParametros("USUARIO_CAD_ALT", usuario.Usuario_cad_alt.Id_Usuario);

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
                    usuario.Email_Profissional = Convert.ToString(dataRow["EMAIL_PROFISSIONAL"]);
                    usuario.Data_Cadastro = Convert.ToDateTime(dataRow["DATA_CADASTRO"]);
                    usuario.Data_Ultima_Alteracao = Convert.ToDateTime(dataRow["DATA_ULTIMA_ALTERACAO"]);

                    Funcionario funcionario = new Funcionario();
                    funcionario.Id_Funcionario = Convert.ToInt32(dataRow["ID_FUNCIONARIO"]);

                    Pessoa pessoa = new Pessoa();
                    pessoa.Nome = Convert.ToString(dataRow["NOME"]);
                    pessoa.Sobrenome = Convert.ToString(dataRow["SOBRENOME"]);

                    GrupoUsuario grupoUsuario = new GrupoUsuario();
                    grupoUsuario.Id_Grupo = Convert.ToInt32(dataRow["ID_GRUPO_USUARIO"]);
                    grupoUsuario.Nome = Convert.ToString(dataRow["GRUPO_NOME"]);

                    usuario.Funcionario = funcionario;
                    usuario.Funcionario.Pessoa = pessoa;
                    usuario.GrupoUsuario = grupoUsuario;

                    usuarioColecao.Add(usuario);
                }

                return usuarioColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar Usuário. Detalhes" + ex.Message);
            }
        }

        public Usuario ConsultarPorId(int id)
        {
            try
            {
                Usuario usuario = new Usuario();

                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@ID_USUARIO", id);
                string query = "SELECT USUARIO.ID_USUARIO, USUARIO.ID_FUNCIONARIO, PESSOA.NOME AS NOME,	PESSOA.SOBRENOME AS SOBRENOME, USUARIO.NOME_USUARIO AS USUARIO,	USUARIO.EMAIL_PROFISSIONAL,	USUARIO.ID_GRUPO_USUARIO AS ID_GRUPO_USUARIO, GRUPO.NOME AS GRUPO_NOME, USUARIO.DATA_CADASTRO AS DATA_CADASTRO,	USUARIO.DATA_ULTIMA_ALTERACAO AS DATA_ULTIMA_ALTERACAO FROM TBL_USUARIO AS USUARIO JOIN TBL_FUNCIONARIO AS FUNCIONARIO ON USUARIO.ID_FUNCIONARIO = FUNCIONARIO.ID_FUNCIONARIO JOIN TBL_PESSOA AS PESSOA ON FUNCIONARIO.ID_PESSOA = PESSOA.ID_PESSOA JOIN TBL_GRUPO_USUARIO AS GRUPO ON USUARIO.ID_GRUPO_USUARIO = GRUPO.ID_GRUPO WHERE USUARIO.ID_USUARIO = " + LoginNegocios.UsuarioLogadoGetSet.Id_Usuario + " AND USUARIO.ATIVO = 1";
                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "USP_USUARIO_CONSULTARPORID");

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    usuario.Id_Usuario = Convert.ToInt32(dataRow["ID_USUARIO"]);
                    usuario.Nome_Usuario = Convert.ToString(dataRow["USUARIO"]);
                    usuario.Email_Profissional = Convert.ToString(dataRow["EMAIL_PROFISSIONAL"]);
                    usuario.Data_Cadastro = Convert.ToDateTime(dataRow["DATA_CADASTRO"]);
                    usuario.Data_Ultima_Alteracao = Convert.ToDateTime(dataRow["DATA_ULTIMA_ALTERACAO"]);

                    Funcionario funcionario = new Funcionario();
                    funcionario.Id_Funcionario = Convert.ToInt32(dataRow["ID_FUNCIONARIO"]);

                    Pessoa pessoa = new Pessoa();
                    pessoa.Nome = Convert.ToString(dataRow["NOME"]);
                    pessoa.Sobrenome = Convert.ToString(dataRow["SOBRENOME"]);

                    GrupoUsuario grupoUsuario = new GrupoUsuario();
                    grupoUsuario.Id_Grupo = Convert.ToInt32(dataRow["ID_GRUPO_USUARIO"]);
                    grupoUsuario.Nome = Convert.ToString(dataRow["GRUPO_NOME"]);

                    usuario.Funcionario = funcionario;
                    usuario.Funcionario.Pessoa = pessoa;
                    usuario.GrupoUsuario = grupoUsuario;
                }

                return usuario;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar Usuário. Detalhes" + ex.Message);
            }
        }

        public UsuarioColecao ConsultarDireferentes()
        {
            try
            {
                UsuarioColecao usuarioColecao = new UsuarioColecao();

                acessoDados.LimparParametros();
                string query = "SELECT USUARIO.ID_USUARIO, USUARIO.ID_FUNCIONARIO, PESSOA.NOME AS NOME,	PESSOA.SOBRENOME AS SOBRENOME, USUARIO.NOME_USUARIO AS USUARIO,	USUARIO.EMAIL_PROFISSIONAL,	USUARIO.ID_GRUPO_USUARIO AS ID_GRUPO_USUARIO, GRUPO.NOME AS GRUPO_NOME, USUARIO.DATA_CADASTRO AS DATA_CADASTRO,	USUARIO.DATA_ULTIMA_ALTERACAO AS DATA_ULTIMA_ALTERACAO FROM TBL_USUARIO AS USUARIO JOIN TBL_FUNCIONARIO AS FUNCIONARIO ON USUARIO.ID_FUNCIONARIO = FUNCIONARIO.ID_FUNCIONARIO JOIN TBL_PESSOA AS PESSOA ON FUNCIONARIO.ID_PESSOA = PESSOA.ID_PESSOA JOIN TBL_GRUPO_USUARIO AS GRUPO ON USUARIO.ID_GRUPO_USUARIO = GRUPO.ID_GRUPO WHERE USUARIO.ID_USUARIO != " + LoginNegocios.UsuarioLogadoGetSet.Id_Usuario + " AND USUARIO.ATIVO = 1";
                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.Text, query);

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    Usuario usuario = new Usuario();
                    usuario.Id_Usuario = Convert.ToInt32(dataRow["ID_USUARIO"]);
                    usuario.Nome_Usuario = Convert.ToString(dataRow["USUARIO"]);
                    usuario.Email_Profissional = Convert.ToString(dataRow["EMAIL_PROFISSIONAL"]);
                    usuario.Data_Cadastro = Convert.ToDateTime(dataRow["DATA_CADASTRO"]);
                    usuario.Data_Ultima_Alteracao = Convert.ToDateTime(dataRow["DATA_ULTIMA_ALTERACAO"]);

                    Funcionario funcionario = new Funcionario();
                    funcionario.Id_Funcionario = Convert.ToInt32(dataRow["ID_FUNCIONARIO"]);

                    Pessoa pessoa = new Pessoa();
                    pessoa.Nome = Convert.ToString(dataRow["NOME"]);
                    pessoa.Sobrenome = Convert.ToString(dataRow["SOBRENOME"]);

                    GrupoUsuario grupoUsuario = new GrupoUsuario();
                    grupoUsuario.Id_Grupo = Convert.ToInt32(dataRow["ID_GRUPO_USUARIO"]);
                    grupoUsuario.Nome = Convert.ToString(dataRow["GRUPO_NOME"]);

                    usuario.Funcionario = funcionario;
                    usuario.Funcionario.Pessoa = pessoa;
                    usuario.GrupoUsuario = grupoUsuario;
                    usuarioColecao.Add(usuario);
                }

                return usuarioColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar Usuário. Detalhes" + ex.Message);
            }
        }

        public Usuario ConsultarPorIdFuncionario(int id)
        {
            try
            {
                Usuario usuario = new Usuario();

                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@ID_FUNCIONARIO", id);

                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "USP_USUARIO_CONSULTARPORIDFUNCIONARIO");

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    usuario.Id_Usuario = Convert.ToInt32(dataRow["ID_USUARIO"]);
                    usuario.Nome_Usuario = Convert.ToString(dataRow["USUARIO"]);
                    usuario.Email_Profissional = Convert.ToString(dataRow["EMAIL_PROFISSIONAL"]);
                    usuario.Data_Cadastro = Convert.ToDateTime(dataRow["DATA_CADASTRO"]);
                    usuario.Data_Ultima_Alteracao = Convert.ToDateTime(dataRow["DATA_ULTIMA_ALTERACAO"]);

                    Funcionario funcionario = new Funcionario();
                    funcionario.Id_Funcionario = Convert.ToInt32(dataRow["ID_FUNCIONARIO"]);

                    Pessoa pessoa = new Pessoa();
                    pessoa.Nome = Convert.ToString(dataRow["NOME"]);
                    pessoa.Sobrenome = Convert.ToString(dataRow["SOBRENOME"]);

                    GrupoUsuario grupoUsuario = new GrupoUsuario();
                    grupoUsuario.Id_Grupo = Convert.ToInt32(dataRow["ID_GRUPO_USUARIO"]);
                    grupoUsuario.Nome = Convert.ToString(dataRow["GRUPO_NOME"]);

                    usuario.Funcionario = funcionario;
                    usuario.Funcionario.Pessoa = pessoa;
                    usuario.GrupoUsuario = grupoUsuario;
                }

                return usuario;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar Usuário. Detalhes" + ex.Message);
            }
        }

        public string AtualizarporId(Usuario usuario)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("ID_USUARIO", usuario.Id_Usuario);
                acessoDados.AdicionarParametros("@ID_FUNCIONARIO", usuario.Funcionario.Id_Funcionario);
                acessoDados.AdicionarParametros("@ID_GRUPO", usuario.GrupoUsuario.Id_Grupo);
                acessoDados.AdicionarParametros("@NOME_USUARIO", usuario.Nome_Usuario);
                acessoDados.AdicionarParametros("@SENHA", usuario.Senha);
                acessoDados.AdicionarParametros("@EMAIL_PROFISSIONAL", usuario.Email_Profissional);
                acessoDados.AdicionarParametros("USUARIO_CAD_ALT", usuario.Usuario_cad_alt.Id_Usuario);

                string idUsuario = acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "USP_USUARIO_ATUALIZARPORID").ToString();

                return idUsuario;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Excluir(Usuario usuario)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("ID_USUARIO", usuario.Id_Usuario);
                acessoDados.AdicionarParametros("ID_USUARIO_LOGADO", usuario.Usuario_cad_alt.Id_Usuario);

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
