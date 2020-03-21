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

namespace Apresentacao
{
    public partial class FrmLogin_flat : Form
    {
        public FrmLogin_flat()
        {
            InitializeComponent();
        }

        private void login()
        {
            LoginNegocios loginNegocios = new LoginNegocios();

            string login = loginNegocios.Login(txtLogin.Text, txtSenha.Text);

            try
            {
                int retorno = int.Parse(login);

                FrmMenu frmMenu = new FrmMenu();
                frmMenu.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao fazer login. Detalhes:" + login + ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Hide();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            login();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmLogin_flat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                login();
        }

        private void FrmLogin_flat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                login();
        }
    }
}
