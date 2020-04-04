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
using System.Reflection;
using Apresentacao.Presentation.Pages;
using Apresentacao.Validacao_cpf_e_afins;

namespace Apresentacao.Presentation.Popup.SearchDialogs
{
    
    public partial class SearchDialog : Form
    {
        Pessoa pessoaescolhida = new Pessoa();

        Pessoa pessoaSelecionada = new Pessoa();

        int id_Pessoa;
        public SearchDialog()
        {
            InitializeComponent();

            dataGrid.AutoGenerateColumns = false;
            ckboxfem.Checked = false;
            ckboxmasc.Checked = false;
            btnAtualizar.Visible = false;
            btnSelecionar.Visible = false;
        }

        private void SearchDialog_Load(object sender, EventArgs e)
        {
            CarregaComboBox();
        }

        private void CarregaComboBox()
        {
            EstadoCivilNegocios estadoCivilNegocios = new EstadoCivilNegocios();
            ProfissaoNegocios profissaoNegocios = new ProfissaoNegocios();
            TipoDocNegocios tipoDocNegocios = new TipoDocNegocios();

            string txt = "";
            EstadoCivilColecao estadoCivilColecao = estadoCivilNegocios.ConsultarPorDescricao(txt);
            ProfissaoColecao profissaoColecao = profissaoNegocios.ConsultarPorDescricao(txt);
            TipoDocColecao tipoDocColecao = tipoDocNegocios.ConsultarPorDescricao(txt);

            cbxEstadoCivil.DataSource = null;
            cbxEstadoCivil.DataSource = estadoCivilColecao;
            cbxEstadoCivil.ValueMember = "ID_ESTADOCIVIL";
            cbxEstadoCivil.DisplayMember = "DESCRICAO";

            cbxProfissao.DataSource = null;
            cbxProfissao.DataSource = profissaoColecao;
            cbxProfissao.ValueMember = "ID_PROFISSAO";
            cbxProfissao.DisplayMember = "Nome_Profissao";

            cbxTipoDoc.DataSource = null;
            cbxTipoDoc.DataSource = tipoDocColecao;
            cbxTipoDoc.ValueMember = "ID_TIPODOC";
            cbxTipoDoc.DisplayMember = "DESCRICAO";
        }

        private void CarregaComboBox_cbxEstadoCivil()
        {
            EstadoCivilNegocios estadoCivilNegocios = new EstadoCivilNegocios();
            string txt = "";
            EstadoCivilColecao estadoCivilColecao = estadoCivilNegocios.ConsultarPorDescricao(txt);

            cbxEstadoCivil.DataSource = null;
            cbxEstadoCivil.DataSource = estadoCivilColecao;
            cbxEstadoCivil.ValueMember = "ID_ESTADOCIVIL";
            cbxEstadoCivil.DisplayMember = "DESCRICAO";
        }

        private void CarregaComboBox_cbxProfissao()
        {
            ProfissaoNegocios profissaoNegocios = new ProfissaoNegocios();
            string txt = "";
            ProfissaoColecao profissaoColecao = profissaoNegocios.ConsultarPorDescricao(txt);

            cbxProfissao.DataSource = null;
            cbxProfissao.DataSource = profissaoColecao;
            cbxProfissao.ValueMember = "ID_PROFISSAO";
            cbxProfissao.DisplayMember = "Nome_Profissao";
        }

        private void CarregaComboBox_cbxTipoDoc()
        {
            TipoDocNegocios tipoDocNegocios = new TipoDocNegocios();
            string txt = "";
            TipoDocColecao tipoDocColecao = tipoDocNegocios.ConsultarPorDescricao(txt);

            cbxTipoDoc.DataSource = null;
            cbxTipoDoc.DataSource = tipoDocColecao;
            cbxTipoDoc.ValueMember = "ID_TIPODOC";
            cbxTipoDoc.DisplayMember = "DESCRICAO";
        }

        private void SearchDialog_Shown(object sender, EventArgs e)
        {
            tbxSearch.Focus();
        }

        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            atualizarcampos();
        }

        private void atualizarcampos()
        {
            PessoaNegocios pessoaNegocios = new PessoaNegocios();
            pessoaSelecionada = pessoaNegocios.ConsultarPorId(Convert.ToInt32(dataGrid.Rows[dataGrid.CurrentRow.Index].Cells[0].Value));

            CarregarPessoaSelecionada(pessoaSelecionada);
            btnAtualizar.Visible = true;
            btnNovo.Text = "Novo";
            btnAtualizar.Location = new Point(267, 291);
            btnAtualizar.Visible = true;
            btnSelecionar.Location = new Point(124, 291);
            btnSelecionar.Visible = true;
            pessoaescolhida = pessoaSelecionada;
        }

        private void CarregarPessoaSelecionada(Pessoa pessoa)
        {

            tbxNome.Text = pessoa.Nome;
            tbxNome.Enabled = false;
            tbxNome.Refresh();

            tbxSobrenome.Text = pessoa.Sobrenome;
            tbxSobrenome.Enabled = false;
            tbxSobrenome.Refresh();

            tbxPai.Text = pessoa.Pai;
            tbxPai.Enabled = false;
            tbxPai.Refresh();

            tbxMae.Text = pessoa.Mae;
            tbxMae.Enabled = false;
            tbxMae.Refresh();

            tbxCPF.Text = Convert.ToString(pessoa.CPF);
            tbxCPF.Enabled = false;
            tbxCPF.Refresh();

            tbxNumDoc.Text = Convert.ToString(pessoa.Doc);
            tbxNumDoc.Enabled = false;

            PessoaColecao pessoacolecaocbx = new PessoaColecao();
            pessoacolecaocbx.Insert(0, pessoa);

            TipoDocNegocios tipoDocNegocios = new TipoDocNegocios();
            TipoDocColecao tipoDocColecao = tipoDocNegocios.ConsultarPorId(pessoa.Id_TipoDoc);
            cbxTipoDoc.DataSource = null;
            cbxTipoDoc.DataSource = tipoDocColecao;
            cbxTipoDoc.ValueMember = "ID_TIPODOC";
            cbxTipoDoc.DisplayMember = "DESCRICAO";
            cbxTipoDoc.SelectedIndex = 0;
            cbxTipoDoc.DropDownStyle = ComboBoxStyle.DropDownList;

            EstadoCivilNegocios estadoCivilNegocios = new EstadoCivilNegocios();
            EstadoCivilColecao estadoCivilcolecao = estadoCivilNegocios.ConsultarPorId(pessoa.Id_EstadoCivil);
            cbxEstadoCivil.DataSource = null;
            cbxEstadoCivil.DataSource = estadoCivilcolecao;
            cbxEstadoCivil.ValueMember = "ID_ESTADOCIVIL";
            cbxEstadoCivil.DisplayMember = "DESCRICAO";
            cbxEstadoCivil.SelectedIndex = 0;
            cbxEstadoCivil.DropDownStyle = ComboBoxStyle.DropDownList;

            ProfissaoNegocios profissaoNegocios = new ProfissaoNegocios();
            ProfissaoColecao profissaoColecao = profissaoNegocios.ConsultarPorId(pessoa.Id_Profissao);
            cbxProfissao.DataSource = null;
            cbxProfissao.DataSource = profissaoColecao;
            cbxProfissao.ValueMember = "ID_PROFISSAO";
            cbxProfissao.DisplayMember = "NOME_PROFISSAO";
            cbxProfissao.SelectedIndex = 0;
            cbxProfissao.DropDownStyle = ComboBoxStyle.DropDownList;

            tbxEmail.Text = pessoa.Email;
            tbxEmail.Enabled = false;
            tbxEmail.Refresh();

            if (pessoa.Sexo == 'M' || pessoa.Sexo == 'm')
            {
                ckboxmasc.Checked = true;
                ckboxmasc.Enabled = false;
                ckboxfem.Checked = false;
                ckboxfem.Enabled = false;
            }
            else
            {
                ckboxmasc.Checked = false;
                ckboxmasc.Enabled = false;
                ckboxfem.Checked = true;
                ckboxfem.Enabled = false;
            }
            ckboxfem.Enabled = false;
            ckboxmasc.Enabled = false;

            dtnascimento.Value = pessoa.Data_Nasc;
            dtnascimento.Enabled = false;
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {

            Enableallcontrols();
            CarregaComboBox();
            PessoaNegocios pessoaNegocios = new PessoaNegocios();
            PessoaColecao pessoaColecao = pessoaNegocios.ConsultarPorDescricao(tbxSearch.Text);
            ClearTextBoxes(this.Controls);

            dataGrid.DataSource = null;
            dataGrid.DataSource = pessoaColecao;
            dataGrid.Update();
            dataGrid.Refresh();

            btnNovo.Text = "Novo";
            btnNovo.Visible = true;
            btnAtualizar.Visible = false;
            btnAtualizar.Text = "Atualizar";
            btnSelecionar.Visible = false;
            btnAtualizar.Location = new Point(267, 291);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (btnNovo.Text == "Novo")
            {
                dataGrid.DataSource = null;
                dataGrid.Refresh();
                CarregaComboBox();
                ClearTextBoxes(this.Controls);
                Enableallcontrols();
                btnNovo.Text = "Salvar";
                btnAtualizar.Visible = false;
                btnSelecionar.Visible = false;
            }
            else if (btnNovo.Text == "Salvar")
            {
                Pessoa pessoa = new Pessoa();
                PessoaNegocios pessoaNegocios = new PessoaNegocios();
                Validadocs validadocs = new Validadocs();

                pessoa.Id_Profissao = Convert.ToInt32(cbxProfissao.SelectedValue);
                pessoa.Id_TipoDoc = Convert.ToInt32(cbxTipoDoc.SelectedValue);
                pessoa.Id_EstadoCivil = Convert.ToInt32(cbxEstadoCivil.SelectedValue);
                pessoa.Nome = tbxNome.Text;
                pessoa.Sobrenome = tbxSobrenome.Text;
                pessoa.CPF = validadocs.SemFormatacao(tbxCPF.Text);
                pessoa.Doc = tbxNumDoc.Text;
                pessoa.Data_Nasc = dtnascimento.Value;
                pessoa.Email = tbxEmail.Text;
                pessoa.Pai = tbxPai.Text;
                pessoa.Mae = tbxMae.Text;
                if (ckboxfem.Checked == true)
                {
                    pessoa.Sexo = 'F';
                }
                else if (ckboxmasc.Checked == true)
                {
                    pessoa.Sexo = 'M';
                }
                else
                {
                    MessageBox.Show("Há um erro na seleção do sexo, verifique!");
                }
                pessoa.Id_Usuario = LoginNegocios.UsuarioLogadoGetSet.Id_Usuario;

                string retorno = pessoaNegocios.Inserir(pessoa);

                try
                {
                    int idPessoa = Convert.ToInt32(retorno);
                    Pessoa pessoaCadastrada = pessoaNegocios.ConsultarPorId(idPessoa);
                    MessageBox.Show("Cadastro base inserido com sucesso!");
                    AdicionarEditarFuncionario.PessoaGetSet = pessoaCadastrada;
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro ao cadastrar. Detalhes: " + retorno);
                }
            }
        }

        private void ClearTextBoxes(Control.ControlCollection ctrlCollection)
        {
            foreach (Control ctrl in ctrlCollection)
            {
                if (ctrl is TextBoxBase)
                {
                    ctrl.Text = String.Empty;
                    ctrl.Enabled = true;
                }
                else
                {
                    ClearTextBoxes(ctrl.Controls);
                }
            }

            ckboxfem.Enabled = true;
            ckboxmasc.Enabled = true;
            dtnascimento.Enabled = true;
        }

        private void Enableallcontrols()
        {
            tbxNome.Enabled = true;
            tbxSobrenome.Enabled = true;
            tbxCPF.Enabled = true;
            tbxEmail.Enabled = true;
            tbxMae.Enabled = true;
            tbxPai.Enabled = true;
            tbxNumDoc.Enabled = true;
            tbxSearch.Enabled = true;
            cbxEstadoCivil.Enabled = true;
            cbxProfissao.Enabled = true;
            cbxTipoDoc.Enabled = true;
            ckboxfem.Enabled = true;
            ckboxmasc.Enabled = true;
            dtnascimento.Enabled = true;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa();
            AdicionarEditarFuncionario.PessoaGetSet = pessoa;
            this.Close();
        }

        public static string FormatCNPJ(string CNPJ)
        {
            return Convert.ToUInt64(CNPJ).ToString(@"00\.000\.000\/0000\-00");
        }

        private void tbxCPF_Leave(object sender, EventArgs e)
        {
            Validadocs validadocs = new Validadocs();
            tbxCPF.Text = validadocs.SemFormatacao(tbxCPF.Text);

            if (tbxCPF.Text.Length != 11)
            {
                tbxCPF.Text = "";
            }
            if (tbxCPF.Text.Length == 0)
            {

            }
            else
            {
                tbxCPF.Text = validadocs.FormatCPF(tbxCPF.Text);
                bool validacpf = validadocs.ValidaCPF(tbxCPF.Text);
                if (validacpf)
                {
                    lblavisocpf.Text = "CPF Válido";
                }
                else
                {
                    MessageBox.Show("CPF inválido!");
                    lblavisocpf.Text = "(somente números sem pontos)";
                    tbxCPF.Text = "";
                }
            }
        }

        private void tbxCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("este campo aceita somente numero");
            }
        }

        private void ckboxmasc_OnChange(object sender, EventArgs e)
        {
            if (ckboxmasc.Checked == true)
            {
                ckboxfem.Checked = false;
            }
        }

        private void ckboxfem_OnChange(object sender, EventArgs e)
        {
            if (ckboxfem.Checked == true)
            {
                ckboxmasc.Checked = false;
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (btnAtualizar.Text == "Atualizar")
            {
                Enableallcontrols();
                btnAtualizar.Text = "Gravar";
                btnNovo.Visible = false;
                btnSelecionar.Visible = false;
                btnAtualizar.Location = new Point(410, 291);
            }
            else if (btnAtualizar.Text == "Gravar")
            {

                Pessoa pessoa = new Pessoa();
                PessoaNegocios pessoaNegocios = new PessoaNegocios();
                Validadocs validadocs = new Validadocs();

                pessoa.Id_Pessoa = pessoaSelecionada.Id_Pessoa;
                pessoa.Id_Profissao = Convert.ToInt32(cbxProfissao.SelectedValue);
                pessoa.Id_TipoDoc = Convert.ToInt32(cbxTipoDoc.SelectedValue);
                pessoa.Id_EstadoCivil = Convert.ToInt32(cbxEstadoCivil.SelectedValue);
                pessoa.Nome = tbxNome.Text;
                pessoa.Sobrenome = tbxSobrenome.Text;
                pessoa.CPF = validadocs.SemFormatacao(tbxCPF.Text);
                pessoa.Doc = tbxNumDoc.Text;
                pessoa.Data_Nasc = dtnascimento.Value;
                pessoa.Email = tbxEmail.Text;
                pessoa.Pai = tbxPai.Text;
                pessoa.Mae = tbxMae.Text;
                if (ckboxfem.Checked == true)
                {
                    pessoa.Sexo = 'F';
                }
                else if (ckboxmasc.Checked == true)
                {
                    pessoa.Sexo = 'M';
                }
                else
                {
                    MessageBox.Show("Há um erro na seleção do sexo, verifique!");
                }
                pessoa.Id_Usuario = LoginNegocios.UsuarioLogadoGetSet.Id_Usuario;

                string retorno = pessoaNegocios.AtualizarporId(pessoa);

                try
                {
                    int idPessoa = Convert.ToInt32(retorno);
                    Pessoa pessoaCadastrada = pessoaNegocios.ConsultarPorId(idPessoa);
                    MessageBox.Show("Cadastro base atualizado com sucesso!");
                    AdicionarEditarFuncionario.PessoaGetSet = pessoaCadastrada;
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro ao atualizar. Detalhes: " + retorno);
                }
            }

        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            AdicionarEditarFuncionario.PessoaGetSet = pessoaescolhida;
            this.Close();
        }

        private void cbxEstadoCivil_Click(object sender, EventArgs e)
        {
            CarregaComboBox_cbxEstadoCivil();
        }

        private void cbxTipoDoc_Click(object sender, EventArgs e)
        {
            CarregaComboBox_cbxTipoDoc();
        }

        private void cbxProfissao_Click(object sender, EventArgs e)
        {
            CarregaComboBox_cbxProfissao();
        }
    }
}
