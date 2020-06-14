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
    
    public partial class SearchDialog_ProfessorMinistra : Form
    {
        ProfessorMinistra MinistraEscolhido = new ProfessorMinistra();

        public SearchDialog_ProfessorMinistra(int idFuncionario)
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

            carregaDataGrid(idFuncionario);
        }

        private void SearchDialog_Shown(object sender, EventArgs e)
        {

        }

        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CarregarMinistraSelecionado();
        }

        private void CarregarMinistraSelecionado()
        {
            ProfessorNegocios professorNegocios = new ProfessorNegocios();
            int IdProfessorMinistra = Convert.ToInt32(dataGrid.Rows[dataGrid.CurrentRow.Index].Cells[0].FormattedValue);

            MinistraEscolhido = professorNegocios.ConsultarMinistraPorId(IdProfessorMinistra)[0];

            btnSelecionar.Enabled = true;
        }

        private void carregaDataGrid(int idFuncionario)
        {
            ProfessorNegocios professorNegocios = new ProfessorNegocios();
            ProfessorMinistraColecao ministraColecao = professorNegocios.ConsultarMinistraPorIdFuncionario(idFuncionario);

            dataGrid.DataSource = null;
            dataGrid.DataSource = ministraColecao;
            dataGrid.AllowUserToResizeColumns = false;
            dataGrid.AllowUserToResizeRows = false;
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGrid.Update();
            dataGrid.Refresh();

            MinistraEscolhido = new ProfessorMinistra();
            btnSelecionar.Enabled = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            AdicionarEditarProfessor.MinistraGetSet = MinistraEscolhido;
            AdicionarEditarProfessor.atualizarCamposProfessorMinistra = true;

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
