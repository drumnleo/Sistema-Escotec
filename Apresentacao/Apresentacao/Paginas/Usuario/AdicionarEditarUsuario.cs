using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjetoTransferencia;
using Negocios;

namespace Apresentacao.Paginas.Usuarios
{
    public partial class AdicionarEditarUsuario : UserControl
    {
        public AdicionarEditarUsuario()
        {
            if (Program.IsInDesignMode()) return;
            InitializeComponent();

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            Usuario usuario = new Usuario();
            GrupoTipo grupoTipo = new GrupoTipo();
            UsuarioNegocios usuarioNegocios = new UsuarioNegocios();

            usuario.Nome = txtNome.Text;
            usuario.Sobrenome = txtSobrenome.Text;
            usuario.Email = txtEmail.Text;
            usuario.Nome_Usuario = txtUsuario.Text;
            usuario.Senha = txtSenha.Text;
            grupoTipo.ID_GRUPO = Convert.ToInt32(cbxGrupo.SelectedValue);
            usuario.grupoTipo = grupoTipo;
            usuario.Data_Admissao = dateAdmissao.Value;

            string retorno = usuarioNegocios.Inserir(usuario);

            try
            {
                int msgretorno = Convert.ToInt32(retorno);
                MessageBox.Show("Usuário inserido com sucesso. Código: " + msgretorno.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao inserir usuário. Mensagem: " + retorno);
            }


        }

        private void AdicionarEditarUsuario_Load(object sender, EventArgs e)
        {
            GrupoColecao grupoColecao = new GrupoColecao();

            GrupoUsuariosNegocios grupoUsuariosNegocios = new GrupoUsuariosNegocios();
            string txt = "";
            grupoColecao = grupoUsuariosNegocios.ConsultarPorNome(txt);

            cbxGrupo.DataSource = null;
            cbxGrupo.DataSource = grupoColecao;
            cbxGrupo.ValueMember = "ID_GRUPO";
            cbxGrupo.DisplayMember = "NOME";

        }

        private void AddEditMember_Resize(object sender, EventArgs e)
        {
            container.Left = this.Width / 2 - container.Width / 2;
        }
    }
}
