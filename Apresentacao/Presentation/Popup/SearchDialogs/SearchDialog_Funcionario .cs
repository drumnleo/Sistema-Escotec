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
    
    public partial class SearchDialog_Funcionario : Form
    {
        Pessoa pessoaescolhida = new Pessoa();
        public SearchDialog_Funcionario()
        {
            InitializeComponent();

            dataGrid.AutoGenerateColumns = false;
            btnSelecionar.Visible = false;
        }

        private void SearchDialog_Load(object sender, EventArgs e)
        {
            
        }

        private void SearchDialog_Shown(object sender, EventArgs e)
        {
            tbxSearch.Focus();
        }

        private void CarregarPessoaSelecionada(Pessoa pessoa)
        {

            PessoaColecao pessoacolecaocbx = new PessoaColecao();
            pessoacolecaocbx.Insert(0, pessoa);

            TipoDocNegocios tipoDocNegocios = new TipoDocNegocios();
            TipoDocColecao tipoDocColecao = tipoDocNegocios.ConsultarPorId(pessoa.Id_TipoDoc);

            EstadoCivilNegocios estadoCivilNegocios = new EstadoCivilNegocios();
            EstadoCivilColecao estadoCivilcolecao = estadoCivilNegocios.ConsultarPorId(pessoa.Id_EstadoCivil);

            ProfissaoNegocios profissaoNegocios = new ProfissaoNegocios();
            ProfissaoColecao profissaoColecao = profissaoNegocios.ConsultarPorId(pessoa.Id_Profissao);

            AdicionarEditarFuncionario.PessoaGetSet = pessoa;
        }

        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            atualizarcampos();
        }

        private void atualizarcampos()
        {
            PessoaNegocios pessoaNegocios = new PessoaNegocios();
            Pessoa pessoaSelecionada = pessoaNegocios.ConsultarPorId(Convert.ToInt32(dataGrid.Rows[dataGrid.CurrentRow.Index].Cells[0].Value));

            CarregarPessoaSelecionada(pessoaSelecionada);

            btnSelecionar.Location = new Point(124, 291);
            btnSelecionar.Visible = true;
            pessoaescolhida = pessoaSelecionada;
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            CarregaComboBox();
            PessoaNegocios pessoaNegocios = new PessoaNegocios();
            PessoaColecao pessoaColecao = pessoaNegocios.ConsultarPorDescricao(tbxSearch.Text);

            dataGrid.DataSource = null;
            dataGrid.DataSource = pessoaColecao;
            dataGrid.Update();
            dataGrid.Refresh();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa();
            AdicionarEditarFuncionario.PessoaGetSet = pessoa;
            this.Close();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            AdicionarEditarFuncionario.PessoaGetSet = pessoaescolhida;
            this.Close();
        }
    }
}
