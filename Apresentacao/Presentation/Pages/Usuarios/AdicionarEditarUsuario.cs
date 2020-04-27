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
        private static Usuario usuarioGetSet;
        public static Usuario UsuarioGetSet
        {
            get { return usuarioGetSet; }
            set { usuarioGetSet = value; }
        }
        private void CamposPessoa()
        {
            tbxCPF.Text = PessoaGetSet.CPF;
            tbxCPF.Enabled = false;
            tbxNome.Text = PessoaGetSet.Nome;
            tbxNome.Enabled = false;
            tbxSobrenome.Text = PessoaGetSet.Sobrenome;
            tbxSobrenome.Enabled = false;
            lblIdFuncionário.Text = FuncionarioGetSet.Id_Funcionario.ToString();
        }

        private void CamposUsuario()
        {
            dtAdmissao.Value = FuncionarioGetSet.Data_Admissao;
            tbxUsuario.Text = usuarioGetSet.Nome_Usuario;
            tbxEmail.Text = usuarioGetSet.Email_Profissional;
            
            if (usuarioGetSet.Id_Usuario > 0)
            {
                GrupoUsuariosNegocios grupoUsuariosNegocios = new GrupoUsuariosNegocios();
                GrupoUsuarioColecao grupoUsuarioColecao = grupoUsuariosNegocios.ConsultarPorId(usuarioGetSet.GrupoUsuario.Id_Grupo);
                try
                {
                    cbxGrupo.DataSource = null;
                    cbxGrupo.DataSource = grupoUsuarioColecao;
                    cbxGrupo.ValueMember = "ID_GRUPO";
                    cbxGrupo.DisplayMember = "NOME";
                    cbxGrupo.SelectedIndex = 0;
                    cbxGrupo.DropDownStyle = ComboBoxStyle.DropDownList;
                    lblIdUsuario.Text = usuarioGetSet.Id_Usuario.ToString();
                    btnSearchUsuario.Visible = false;
                    lblBuscarUsuario.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            } 
        }

        private void AdicionarEditarUsuario_Load(object sender, EventArgs e)
        {
            
        }

        private void LimparCamposTela()
        {
            funcionarioGetSet = new Funcionario();
            UsuarioGetSet = new Usuario();
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
            if (FuncionarioGetSet != null)
            {
                if (lblIdFuncionário.Text == "None")
                {
                    CamposPessoa();
                    btnAtualizar.Enabled = true;
                    btnSalvar.Enabled = false;
                    btnAtualizar.Enabled = true;
                }
                else if (FuncionarioGetSet.Id_Funcionario != Convert.ToInt32(lblIdFuncionário.Text))
                {
                    CamposPessoa();
                    btnAtualizar.Enabled = true;
                    btnSalvar.Enabled = false;
                    btnAtualizar.Enabled = true;
                }
            }
            if (usuarioGetSet != null)
            {
                if (lblIdUsuario.Text == "None")
                {
                    CamposPessoa();
                    CamposUsuario();
                    btnAtualizar.Enabled = true;
                    btnSalvar.Enabled = false;
                    btnAtualizar.Enabled = true;
                }
                else if (usuarioGetSet.Id_Usuario != Convert.ToInt32(lblIdUsuario.Text))
                {
                    CamposUsuario();
                    CamposPessoa();
                    btnAtualizar.Enabled = true;
                    btnSalvar.Enabled = false;
                    btnAtualizar.Enabled = true;
                }
            }

        }

        private void CarregaComboBox()
        {
            GrupoUsuariosNegocios grupoUsuariosNegocios = new GrupoUsuariosNegocios();


            string txt = "";
            GrupoUsuarioColecao grupoColecao = grupoUsuariosNegocios.ConsultarPorNome(txt);


            cbxGrupo.DataSource = null;
            cbxGrupo.DataSource = grupoColecao;
            cbxGrupo.ValueMember = "ID_GRUPO";
            cbxGrupo.DisplayMember = "NOME";
        }

        private void btnSearchUsuario_Click(object sender, EventArgs e)
        {
            new Popup.transparentBg(new Popup.SearchDialogs.SearchDialog_Usuario());
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimparCamposTela();
            CarregaComboBox();
            lblBuscarUsuario.Visible = true;
            btnSearchUsuario.Visible = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            GrupoUsuario grupoUsuario = new GrupoUsuario();
            UsuarioNegocios usuarioNegocios = new UsuarioNegocios();
            if (int.TryParse(lblIdFuncionário.Text, out _))
            {
                usuario.Nome_Usuario = tbxUsuario.Text;
                usuario.Funcionario.Id_Funcionario = Convert.ToInt32(lblIdFuncionário.Text);
                usuario.Senha = txtSenha.Text;
                usuario.GrupoUsuario.Id_Grupo = Convert.ToInt32(cbxGrupo.SelectedValue);
                tbxEmail.Text = usuario.Email_Profissional;

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
            else
            {
                MessageBox.Show("Não foi selecionado um funcionário!");
            }
            
        }

        private void cbxGrupo_Click(object sender, EventArgs e)
        {
            CarregaComboBox();
        }
    }
}
