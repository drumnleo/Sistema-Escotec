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
    
    public partial class SearchDialog_Curso : Form
    {
        Curso CursoEscolhido = new Curso();

        public SearchDialog_Curso()
        {
            InitializeComponent();

            dataGrid.AutoGenerateColumns = false;
            dataGrid.RowsDefaultCellStyle.Font = new Font("Segoe UI Semibold", 11F, GraphicsUnit.Pixel);
            dataGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 11F, GraphicsUnit.Pixel);
            dataGrid.RowTemplate.Height = 30;
            dataGrid.ColumnHeadersHeight = 30;
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
            CarregaCursoSelecionado();
        }

        private void CarregaCursoSelecionado()
        {
            CursoNegocios cursoNegocios = new CursoNegocios();
            int IdCurso = Convert.ToInt32(dataGrid.Rows[dataGrid.CurrentRow.Index].Cells[0].FormattedValue);

            CursoEscolhido = cursoNegocios.ConsultarPorId(IdCurso)[0];

            btnSelecionar.Enabled = true;
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            CursoNegocios cursoNegocios = new CursoNegocios();
            CursoColecao cursoColecao = cursoNegocios.ConsultarPorNome(tbxSearch.Text);

            dataGrid.DataSource = null;
            dataGrid.DataSource = cursoColecao;
            dataGrid.AllowUserToResizeColumns = false;
            dataGrid.AllowUserToResizeRows = false;
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGrid.Update();
            dataGrid.Refresh();

            CursoEscolhido = new Curso();
            btnSelecionar.Enabled = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            AdicionarEditarTurmaCurso.CursoGetSet = CursoEscolhido;
            AdicionarEditarTurmaCurso.atualizarCampos = true;

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
