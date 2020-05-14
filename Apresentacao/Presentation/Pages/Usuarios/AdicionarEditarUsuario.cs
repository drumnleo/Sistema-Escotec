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

        public static Funcionario FuncionarioGetSet { get; set; }
        public static Usuario UsuarioGetSet { get; set; }
        public static GrupoUsuarioColecao GrupoUsuarioGetSet { get; set; }
        public static Boolean AtualizarUsuario = false;
        public static Boolean AtualizarFuncionario = false;

        //Load
        private void AdicionarEditarUsuario_Load(object sender, EventArgs e)
        {
            CarregaComboBox();
        }

        //Metodos botões
        private void btnNovo_Click(object sender, EventArgs e)
        {
            FuncionarioGetSet = new Funcionario();
            AtualizarFuncionario = true;
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            GrupoUsuario grupoUsuario = new GrupoUsuario();
            UsuarioNegocios usuarioNegocios = new UsuarioNegocios();
            try
            {
                usuario.Funcionario = FuncionarioGetSet;
                usuario.GrupoUsuario = GrupoUsuarioGetSet[cbxGrupo.SelectedIndex];
                usuario.Nome_Usuario = tbxUsuario.Text;
                usuario.Senha = TbxSenha.Text;
                usuario.Email_Profissional = tbxEmail.Text;
                usuario.Usuario_cad_alt = LoginNegocios.UsuarioLogadoGetSet;
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao carregar campos. Verifique os campos digitados");
            }

            string retorno = usuarioNegocios.Inserir(usuario);

            try
            {
                int idusuario = Convert.ToInt32(retorno);
                MessageBox.Show("Usuário inserido com sucesso!");
                UsuarioGetSet = usuarioNegocios.ConsultarPorId(idusuario);
                AtualizarUsuario = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao inserir usuário. Mensagem: " + retorno);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            new Apresentacao.Presentation.Popup.transparentBg(new Apresentacao.Presentation.Popup.SearchDialogs.SearchDialog_FuncionarioUsuario());
        }
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (UsuarioGetSet != null)
            {
                UsuarioNegocios usuarioNegocios = new UsuarioNegocios();
                Usuario usuario = new Usuario();

                usuario.Id_Usuario = Convert.ToInt32(lblIdUsuario.Text);
                usuario.Funcionario = FuncionarioGetSet;
                usuario.GrupoUsuario = GrupoUsuarioGetSet[cbxGrupo.SelectedIndex];
                usuario.Nome_Usuario = tbxUsuario.Text;
                usuario.Senha = TbxSenha.Text;
                usuario.Email_Profissional = tbxEmail.Text;
                usuario.Usuario_cad_alt = LoginNegocios.UsuarioLogadoGetSet;

                string retorno = usuarioNegocios.AtualizarporId(usuario);
                try
                {
                    int idusuario = Convert.ToInt32(retorno);
                    UsuarioGetSet = usuarioNegocios.ConsultarPorId(idusuario);
                    MessageBox.Show("Usuário atualizado com sucesso!");
                    AtualizarUsuario = true;
                    AtualizarFuncionario = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro ao atualizar usuário. Detalhes: " + retorno);
                }
            }
        }
        private void btnSearchUsuario_Click(object sender, EventArgs e)
        {
            new Popup.transparentBg(new Popup.SearchDialogs.SearchDialog_Usuario());
        }


        //Métodos Void
        private void CamposPessoa()
        {
            tbxCPF.Text = FuncionarioGetSet.Pessoa.CPF;
            tbxCPF.Enabled = false;
            tbxNome.Text = FuncionarioGetSet.Pessoa.Nome;
            tbxNome.Enabled = false;
            tbxSobrenome.Text = FuncionarioGetSet.Pessoa.Sobrenome;
            tbxSobrenome.Enabled = false;
            lblIdFuncionário.Text = FuncionarioGetSet.Id_Funcionario.ToString();
        }
        private void CamposUsuario()
        {
            dtAdmissao.Value = FuncionarioGetSet.Data_Admissao;
            tbxUsuario.Text = UsuarioGetSet.Nome_Usuario;
            tbxEmail.Text = UsuarioGetSet.Email_Profissional;
            TbxSenha.Text = "123456";
            TbxSenha2.Text = "654321";
            if (UsuarioGetSet.Id_Usuario > 0)
            {
                GrupoUsuariosNegocios grupoUsuariosNegocios = new GrupoUsuariosNegocios();
                GrupoUsuarioColecao grupoUsuarioColecao = grupoUsuariosNegocios.ConsultarPorId(UsuarioGetSet.GrupoUsuario.Id_Grupo);
                try
                {
                    cbxGrupo.DataSource = null;
                    cbxGrupo.DataSource = grupoUsuarioColecao;
                    cbxGrupo.ValueMember = "ID_GRUPO";
                    cbxGrupo.DisplayMember = "NOME";
                    cbxGrupo.SelectedIndex = 0;
                    cbxGrupo.DropDownStyle = ComboBoxStyle.DropDownList;
                    lblIdUsuario.Text = UsuarioGetSet.Id_Usuario.ToString();
                    btnSearchUsuario.Visible = false;
                    lblBuscarUsuario.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            } 
        }
        private void LimpaCamposUsuario()
        {
            UsuarioGetSet = new Usuario();
            CarregaComboBox();
            tbxEmail.Text = "";
            tbxUsuario.Text = "";
            TbxSenha.Text = "";
            lblIdUsuario.Text = "";
            dtCadastro.Value = DateTime.Now;
            dtAdmissao.Value = DateTime.Now;
            btnAtualizar.Enabled = false;
            btnSalvar.Enabled = true;
            BtnExcluir.Enabled = false;
        }
        private void LimpaCamposFuncionario()
        {
            FuncionarioGetSet = new Funcionario();
            tbxNome.Text = "";
            tbxSobrenome.Text = "";
            tbxCPF.Text = "";
            lblIdFuncionário.Text = "";
        }
        private void CarregaComboBox()
        {
            GrupoUsuariosNegocios grupoUsuariosNegocios = new GrupoUsuariosNegocios();

            string txt = "";
            GrupoUsuarioGetSet = grupoUsuariosNegocios.ConsultarPorNome(txt);

            cbxGrupo.DataSource = null;
            cbxGrupo.DataSource = GrupoUsuarioGetSet;
            cbxGrupo.ValueMember = "ID_GRUPO";
            cbxGrupo.DisplayMember = "NOME";
        }
        private void LimparCamposTela()
        {
            FuncionarioGetSet = new Funcionario();
            tbxNome.Text = "";
            tbxSobrenome.Text = "";
            tbxCPF.Text = "";
            lblIdFuncionário.Text = "";

            UsuarioGetSet = new Usuario();
            CarregaComboBox();
            tbxEmail.Text = "";
            tbxUsuario.Text = "";
            TbxSenha.Text = "";
            dtCadastro.Value = DateTime.Now;
            dtAdmissao.Value = DateTime.Now;
        }

        private void timerpreenche_Tick(object sender, EventArgs e)
        {
            if (AtualizarFuncionario == true)
            {
                if (FuncionarioGetSet.Id_Funcionario > 0)
                {
                    CamposPessoa();
                    btnAtualizar.Enabled = false;
                    btnSalvar.Enabled = true;
                    BtnExcluir.Enabled = false;
                    AtualizarFuncionario = false;
                    AtualizarUsuario = true;
                }
                else
                {
                    LimpaCamposFuncionario();
                    LimpaCamposUsuario();
                    AtualizarFuncionario = false;
                    AtualizarUsuario = false;
                }
                
            }
            if (AtualizarUsuario == true)
            {
                if (UsuarioGetSet.Id_Usuario > 0)
                {
                    CamposUsuario();
                    btnAtualizar.Enabled = true;
                    BtnExcluir.Enabled = true;
                    btnSalvar.Enabled = false;
                    AtualizarUsuario = false;
                }
            }

        }

        private void cbxGrupo_Click(object sender, EventArgs e)
        {
            CarregaComboBox();
        }

        private void TimerSenha_Tick(object sender, EventArgs e)
        {
            if (TbxSenha.Text == "" && TbxSenha2.Text == "")
            {
                ImgNega.Visible = false;
                ImgOk.Visible = false;
            }
            else if (TbxSenha.Text == TbxSenha2.Text)
            {
                ImgNega.Visible = false;
                ImgOk.Visible = true;
            }
            else
            {
                ImgNega.Visible = true;
                ImgOk.Visible = false;
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            UsuarioNegocios usuarioNegocios = new UsuarioNegocios();
            DialogResult resultado = MessageBox.Show("Tem certeza?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.No)
            {
                return;
            }
            UsuarioGetSet.Usuario_cad_alt = LoginNegocios.UsuarioLogadoGetSet;
            string retorno = usuarioNegocios.Excluir(UsuarioGetSet);

            try
            {
                int idusuario = Convert.ToInt32(retorno);
                MessageBox.Show("Cadastro excluído com sucesso!");
                UsuarioGetSet = new Usuario();
                FuncionarioGetSet = new Funcionario();
                AtualizarFuncionario = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao excluir. Detalhes: " + retorno);
            }
        }
    }
}
