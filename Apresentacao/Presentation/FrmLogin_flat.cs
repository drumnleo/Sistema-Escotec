﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
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

        public static FormWindowState EstadoForm { get; set; }
        public static Boolean Taskbar { get; set; }
        public static Boolean TrocaEstado { get; set; } = false;
        FrmMenu frmMenu = null;
        

        public void Login()
        {
            LoginNegocios loginNegocios = new LoginNegocios();

            string login = loginNegocios.Login(txtLogin.Text, txtSenha.Text);

            try
            {
                int retorno = int.Parse(login);
                Usuario usuario = new Usuario();
                usuario.Id_Usuario = retorno;
                usuario.Senha = txtSenha.Text;
                LoginNegocios.UsuarioLogadoGetSet = usuario;

                frmMenu = new FrmMenu();
                frmMenu.Show();
                this.Hide();
                //EstadoForm = FormWindowState.Minimized;
                //this.WindowState = EstadoForm;
                //Taskbar = false;
                //this.ShowInTaskbar = Taskbar;
                TrocaEstado = false;
        }
            catch(Exception)
            {
                MessageBox.Show("Erro ao fazer login. Detalhes: " + login, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            txtSenha.Focus();
            txtSenha.Select();
            Login();
            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (TrocaEstado == true)
            {
                txtSenha.Text = "";
                txtLogin.Text = "";
                
                this.Show();
                frmMenu.Close();
                TrocaEstado = false;
            }
        }
    }
}
