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
using KimtToo.VisualReactive;

namespace Apresentacao.Presentation.Pages
{
    public partial class AdicionarEditarUsuario : UserControl
    {
        public AdicionarEditarUsuario()
        {
            if (Program.IsInDesignMode()) return;
            InitializeComponent();

        }

        private static Pessoa pessoaGetSet;

        public static Pessoa PessoaGetSet
        {
            get { return pessoaGetSet; }
            set { pessoaGetSet = value; }
        }

        private static Funcionario funcionarioGetSet;

        public static Funcionario FuncionarioGetSet
        {
            get { return funcionarioGetSet; }
            set { funcionarioGetSet = value; }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            Usuario usuario = new Usuario();
            Foto foto = new Foto();
            GrupoTipo grupoTipo = new GrupoTipo();
            UsuarioNegocios usuarioNegocios = new UsuarioNegocios();



            usuario.Nome_Usuario = txtUsuario.Text;
            usuario.Senha = txtSenha.Text;
            usuario.grupoTipo = grupoTipo;

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
            //GrupoColecao grupoColecao = new GrupoColecao();

            //GrupoUsuariosNegocios grupoUsuariosNegocios = new GrupoUsuariosNegocios();
            //string txt = "";
            //grupoColecao = grupoUsuariosNegocios.ConsultarPorNome(txt);

            //cbxGrupo.DataSource = null;
            //cbxGrupo.DataSource = grupoColecao;
            //cbxGrupo.ValueMember = "ID_GRUPO";
            //cbxGrupo.DisplayMember = "NOME";

        }

        private void AddEditMember_Resize(object sender, EventArgs e)
        {
            container.Left = this.Width / 2 - container.Width / 2;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            new Apresentacao.Presentation.Popup.transparentBg(new Apresentacao.Presentation.Popup.SearchDialogs.SearchDialog_FuncionarioUsuario());
        }

        private void timerpreenche_Tick(object sender, EventArgs e)
        {
            if (pessoaGetSet != null)
            {
                tbxCPF.Text = pessoaGetSet.CPF;
                tbxCPF.Enabled = false;
                tbxNome.Text = pessoaGetSet.Nome;
                tbxNome.Enabled = false;
                tbxSobrenome.Text = pessoaGetSet.Sobrenome;
                tbxSobrenome.Enabled = false;
            }

        }
    }
}
