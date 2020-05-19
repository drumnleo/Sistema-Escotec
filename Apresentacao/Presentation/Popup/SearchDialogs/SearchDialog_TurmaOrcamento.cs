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
    
    public partial class SearchDialog_TurmaOrcamento : Form
    {
        TurmaOrcamento turmaOrcamentoEscolhido = new TurmaOrcamento();

        public SearchDialog_TurmaOrcamento()
        {
            InitializeComponent();
            dataGrid.AutoGenerateColumns = false;
            dataGrid.AllowUserToResizeColumns = false;
            dataGrid.AllowUserToResizeRows = false;
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            btnSelecionar.Visible = false;
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
            TurmaOrcamentoNegocios turmaOrcamentoNegocios = new TurmaOrcamentoNegocios();
            int idOrcamento = Convert.ToInt32(dataGrid.Rows[dataGrid.CurrentRow.Index].Cells[0].FormattedValue);
            int idTurma = Convert.ToInt32(dataGrid.Rows[dataGrid.CurrentRow.Index].Cells[1].FormattedValue);
            turmaOrcamentoEscolhido = turmaOrcamentoNegocios.ConsultarPorId(idOrcamento, idTurma)[0];

            btnSelecionar.Location = new Point(541, 15);
            btnSelecionar.Visible = true;
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            TurmaOrcamentoNegocios turmaOrcamentoNegocios = new TurmaOrcamentoNegocios();
            TurmaOrcamentoColecao turmaOrcamentos = turmaOrcamentoNegocios.ConsultarPorPessoa(tbxSearch.Text);

            dataGrid.DataSource = null;
            dataGrid.DataSource = turmaOrcamentos;
            dataGrid.AllowUserToResizeColumns = false;
            dataGrid.AllowUserToResizeRows = false;
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGrid.Update();
            dataGrid.Refresh();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            //AdicionarEditarFuncionario.FuncionarioGetSet = funcionarioEscolhido;
            //AdicionarEditarFuncionario.AtualizarFuncionario = true;
            //AdicionarEditarFuncionario.PessoaGetSet = funcionarioEscolhido.Pessoa;
            //AdicionarEditarFuncionario.AtualizarPessoa = true;
            this.Close();
        }

        private void dataGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((dataGrid.Rows[e.RowIndex].DataBoundItem != null) && (dataGrid.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
            {
                e.Value = BindProperty(dataGrid.Rows[e.RowIndex].DataBoundItem, dataGrid.Columns[e.ColumnIndex].DataPropertyName);
            }

            if (this.dataGrid.Columns[e.ColumnIndex].Name == "Validade")
            {
                ShortFormDateFormat(e);
            }
        }

        private static void ShortFormDateFormat(DataGridViewCellFormattingEventArgs formatting)
        {
            if (formatting.Value != null)
            {
                try
                {
                    DateTime theDate = DateTime.Parse(formatting.Value.ToString());
                    String dateString = theDate.ToString("MM/dd/yyyy");
                    formatting.Value = dateString;
                    formatting.FormattingApplied = true;
                }
                catch (FormatException)
                {
                    // Set to false in case there are other handlers interested trying to
                    // format this DataGridViewCellFormattingEventArgs instance.
                    formatting.FormattingApplied = false;
                }
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
