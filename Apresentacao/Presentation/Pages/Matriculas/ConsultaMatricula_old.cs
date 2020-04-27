using System;
using System.Windows.Forms;
using ObjetoTransferencia;
using Negocios;

namespace Apresentacao.Presentation.Pages
{
    public partial class ConsultaMatricula_old : UserControl
    {
        public ConsultaMatricula_old()
        {
            if (Program.IsInDesignMode()) return;
            InitializeComponent();
        }

        private void cbxUsuario_Click(object sender, EventArgs e)
        {
            carregacbxusuario();
        }

        private void carregacbxusuario()
        {
            UsuarioNegocios usuarioNegocios = new UsuarioNegocios();
            UsuarioColecao usuarioColecao = usuarioNegocios.ConsultarPorNome("");

            cbxUsuario.DataSource = null;
            cbxUsuario.DataSource = usuarioColecao;
            cbxUsuario.ValueMember = "ID_USUARIO";
            cbxUsuario.DisplayMember = "USUARIO";
        }
    }
}
