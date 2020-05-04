using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;
using ObjetoTransferencia;

namespace Apresentacao
{
    public partial class FrmLogin_flat : Form
    {
        public FrmLogin_flat()
        {
            InitializeComponent();
        }

        private void Login()
        {
            LoginNegocios loginNegocios = new LoginNegocios();

            string login = loginNegocios.Login(txtLogin.Text, txtSenha.Text);

            try
            {
                int retorno = int.Parse(login);

                Usuario usuario = new Usuario();
                usuario.Id_Usuario = retorno;
                LoginNegocios.UsuarioLogadoGetSet = usuario;

                FrmMenu frmMenu = new FrmMenu();
                frmMenu.Show();

                this.WindowState = FormWindowState.Minimized;
                this.ShowInTaskbar = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao fazer login. Detalhes: " + login, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtSenha_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Cursor = Cursors.WaitCursor;
                Login();    
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Close();
        }
    }
}
