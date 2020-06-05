using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjetoTransferencia;
using Negocios;
using Microsoft.VisualBasic.Logging;

namespace Apresentacao.Presentation.Popup.ConfirmaUsuario
{
    public partial class Frm_UsuarioConfirma : Form
    {
        string tipoAcesso;
        public Frm_UsuarioConfirma(UsuarioAutoriza usuarioAutoriza)
        {
            InitializeComponent();
            tipoAcesso = usuarioAutoriza.ToString();
        }

        private void Frm_UsuarioConfirma_Load(object sender, EventArgs e)
        {
            UsuarioNegocios usuarioNegocios = new UsuarioNegocios();
            UsuarioColecao usuarios = usuarioNegocios.ConsultarDireferentes();
            CbxUsuario.DataSource = null;
            CbxUsuario.DataSource = usuarios;
            CbxUsuario.DisplayMember = "NOME_USUARIO";
            CbxUsuario.ValueMember = "ID_USUARIO";
            CbxUsuario.Update();
            CbxUsuario.Refresh();
        }

        private void BtnAutorizar_Click(object sender, EventArgs e)
        {
            if (tipoAcesso == "caixa")
            {
                LoginNegocios loginNegocios = new LoginNegocios();
                Usuario usuario = (Usuario)CbxUsuario.SelectedItem;
                bool retorno = loginNegocios.VerificaSenhaUsuario(usuario.Nome_Usuario, TbxSenha.Text);
                if (retorno == false)
                {
                    MessageBox.Show("Senha inválida para o usuario " + usuario.Nome_Usuario + ".");
                }
            }
        }
    }
}
