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
using Apresentacao.Paginas.Usuarios;

namespace Apresentacao.PopUp.SearchDialogs
{
    
    public partial class SearchDialog : Form
    {
        Pessoa pessoaselecionada = new Pessoa();
        public SearchDialog()
        {
            InitializeComponent();

            dataGrid.AutoGenerateColumns = false;

        }


        private void SearchDialog_Load(object sender, EventArgs e)
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

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchDialog_Shown(object sender, EventArgs e)
        {
            tbxSearch.Focus();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            PessoaNegocios pessoaNegocios = new PessoaNegocios();
            PessoaColecao pessoaColecao = pessoaNegocios.ConsultarPorDescricao(tbxSearch.Text);

            dataGrid.DataSource = null;
            dataGrid.DataSource = pessoaColecao;
            dataGrid.Update();
            dataGrid.Refresh();
        }

        private object CarregarPropriedade(object propriedade, string nomeDaPropriedade)
        {
            try
            {
                object retorno = "";

                if(nomeDaPropriedade.Contains("."))
                {
                    PropertyInfo[] propertyInfoArrary;
                    string propriedadeAntesdoponto;

                    propriedadeAntesdoponto = nomeDaPropriedade.Substring(0, nomeDaPropriedade.IndexOf("."));

                    if(propriedade != null)
                    {
                        propertyInfoArrary = propriedade.GetType().GetProperties();

                        foreach (PropertyInfo propertyinfo in propertyInfoArrary)
                        {
                            if(propertyinfo.Name == propriedadeAntesdoponto)
                            {
                                retorno = CarregarPropriedade(propertyinfo.GetValue(propriedade, null), nomeDaPropriedade.Substring(nomeDaPropriedade.IndexOf(".") + 1));
                            }
                        }
                    }
                }
                if(!nomeDaPropriedade.Contains("."))
                {
                    Type tpoPropertyType;
                    PropertyInfo pfoPropertyinfo;

                    if(propriedade != null)
                    {
                        tpoPropertyType = propriedade.GetType();
                        pfoPropertyinfo = tpoPropertyType.GetProperty(nomeDaPropriedade);
                        retorno = pfoPropertyinfo.GetValue(propriedade, null);
                    }
                }             
                return retorno;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
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

            if(pessoa.Sexo == 'M' || pessoa.Sexo == 'm')
            {
                checkboxmasc.Checked = true;
                checkboxmasc.Enabled = false;
                checkboxfem.Checked = false;
                checkboxfem.Enabled = false;
            }
            else
            {
                checkboxmasc.Checked = false;
                checkboxmasc.Enabled = false;
                checkboxfem.Checked = true;
                checkboxfem.Enabled = false;
            }
            checkboxfem.Enabled = false;
            checkboxmasc.Enabled = false;

            dtnascimento.Value = pessoa.Data_Nasc;
            dtnascimento.Enabled = false;

            AdicionarEditarUsuario.PessoaGetSet = pessoa;

        }

        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            atualizarcampos();
        }

        private void atualizarcampos()
        {
            PessoaNegocios pessoaNegocios = new PessoaNegocios();
            PessoaColecao pessoaColecao = pessoaNegocios.ConsultarPorId(Convert.ToInt32(dataGrid.Rows[dataGrid.CurrentRow.Index].Cells[0].Value));
            pessoaselecionada = pessoaColecao[0];

            CarregarPessoaSelecionada(pessoaselecionada);
        }
    }
}
