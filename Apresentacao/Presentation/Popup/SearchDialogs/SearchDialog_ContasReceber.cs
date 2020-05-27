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
    
    public partial class SearchDialog_ContasReceber : Form
    {
        ContasReceber ContaEscolhida = new ContasReceber();

        public SearchDialog_ContasReceber()
        {
            InitializeComponent();
            dataGrid.AutoGenerateColumns = false;
            dataGrid.AllowUserToResizeColumns = false;
            dataGrid.AllowUserToResizeRows = false;
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            btnSelecionar.Enabled = false;
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
            ContasReceberNegocios contasReceberNegocios = new ContasReceberNegocios();
            ContaEscolhida = contasReceberNegocios.ConsultarPorIdMatricula(Convert.ToInt32(dataGrid.Rows[dataGrid.CurrentRow.Index].Cells[0].FormattedValue))[0];


            btnSelecionar.Enabled = true;
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            ContasReceberNegocios contasReceberNegocios = new ContasReceberNegocios();
            ContasReceberColecao contas = new ContasReceberColecao();
            Validadocs validadocs = new Validadocs();
            bool cpfvalido = validadocs.ValidaCPF(tbxSearch.Text);
            if (cpfvalido)
            {
                contas = contasReceberNegocios.ConsultarPorCPF(tbxSearch.Text);
                dataGrid.DataSource = null;
                dataGrid.DataSource = contas;
                dataGrid.AllowUserToResizeColumns = false;
                dataGrid.AllowUserToResizeRows = false;
                dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                dataGrid.Update();
                dataGrid.Refresh();
            }
            else
            {
                MessageBox.Show("CPF inválido!");
            } 
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            FrmCaixa.ContaGetSet = ContaEscolhida;
            FrmCaixa.AtualizaCampos = true;
            this.Close();
        }

        private void dataGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((dataGrid.Rows[e.RowIndex].DataBoundItem != null) && (dataGrid.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
            {
                e.Value = BindProperty(dataGrid.Rows[e.RowIndex].DataBoundItem, dataGrid.Columns[e.ColumnIndex].DataPropertyName);
            }
        }

        private string BindProperty(object property, string propertyName)
        {
            string retValue = "";
            if (propertyName.Contains("."))
            {
                PropertyInfo[] arrayProperties;
                string leftPropertyName;
                leftPropertyName = propertyName.Substring(0, propertyName.IndexOf("."));
                arrayProperties = property.GetType().GetProperties();
                foreach (PropertyInfo propertyInfo in arrayProperties)
                {
                    if (propertyInfo.Name == leftPropertyName)
                    {
                        retValue = BindProperty(
                          propertyInfo.GetValue(property, null),
                          propertyName.Substring(propertyName.IndexOf(".") + 1));
                        break;
                    }
                }
            }
            else
            {
                Type propertyType;
                PropertyInfo propertyInfo;
                propertyType = property.GetType();
                propertyInfo = propertyType.GetProperty(propertyName);
                retValue = propertyInfo.GetValue(property, null).ToString();
            }
            return retValue;
        }
    }
}
