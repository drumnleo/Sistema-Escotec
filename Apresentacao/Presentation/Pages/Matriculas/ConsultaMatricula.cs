using System;
using System.Windows.Forms;
using ObjetoTransferencia;
using Negocios;
using System.Reflection;
using Microsoft.Reporting.WinForms;
using System.Drawing;

namespace Apresentacao.Presentation.Pages
{
    public partial class ConsultaMatricula : UserControl
    {
        MatriculaColecao matriculasBuscadas = new MatriculaColecao();
        ReportDataSource rs = new ReportDataSource();
        int busca = 0;
        public ConsultaMatricula()
        {
            if (Program.IsInDesignMode()) return;
            InitializeComponent();
            dataGrid.AutoGenerateColumns = false;
            dataGrid.RowsDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10F, GraphicsUnit.Pixel);
            dataGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10F, GraphicsUnit.Pixel);
            dataGrid.RowTemplate.Height = 30;
            dataGrid.ColumnHeadersHeight = 30;
            dataGrid.AllowUserToResizeColumns = false;
            dataGrid.AllowUserToResizeRows = false;
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            PanelNome.Visible = true;
            PanelCpf.Visible = false;
            PanelData.Visible = false;
            PanelTurma.Visible = false;
            PanelUsuario.Visible = false;
            CbxBusca.SelectedIndex = 0;
        }
        private void cbxUsuario_Click(object sender, EventArgs e)
        {
            carregacbxusuario();
        }
        private void cbxCurso_Click(object sender, EventArgs e)
        {
            Carregacbxturma();
        }
        private void carregacbxusuario()
        {
            UsuarioNegocios usuarioNegocios = new UsuarioNegocios();
            UsuarioColecao usuarioColecao = usuarioNegocios.ConsultarPorNome("");

            CbxUsuario.DataSource = null;
            CbxUsuario.DataSource = usuarioColecao;
            CbxUsuario.ValueMember = "Id_Usuario";
            CbxUsuario.DisplayMember = "Nome_Usuario";
        }
        private void Carregacbxturma()
        {
            TurmaNegocios turmaNegocios = new TurmaNegocios();
            TurmaColecao turmaColecao = turmaNegocios.ConsultarPorNome("");

            CbxTurma.DataSource = null;
            CbxTurma.DataSource = turmaColecao;
            CbxTurma.ValueMember = "Id_Turma";
            CbxTurma.DisplayMember = "Nome_Turma";
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (busca > -1)
            {
                MatriculaNegocios matriculaNegocios = new MatriculaNegocios();
                switch (busca)
                {
                    case 0:
                        matriculasBuscadas = matriculaNegocios.ConsultarPorNomeAluno(TbxNome.Text, TbxSobrenome.Text);
                        dataGrid.DataSource = null;
                        dataGrid.DataSource = matriculasBuscadas;
                        dataGrid.Update();
                        dataGrid.Refresh();
                        break;
                    case 1:
                        matriculasBuscadas = matriculaNegocios.ConsultarPorCpfAluno(TbxCpf.Text);
                        dataGrid.DataSource = null;
                        dataGrid.DataSource = matriculasBuscadas;
                        dataGrid.Update();
                        dataGrid.Refresh();
                        break;
                    case 2:
                        matriculasBuscadas = matriculaNegocios.ConsultarPorDatas(DtInicio.Value, DtFim.Value);
                        dataGrid.DataSource = null;
                        dataGrid.DataSource = matriculasBuscadas;
                        dataGrid.Update();
                        dataGrid.Refresh();
                        break;
                    case 3:
                        matriculasBuscadas = matriculaNegocios.ConsultarPorTurma(Convert.ToInt32(CbxTurma.SelectedValue));
                        dataGrid.DataSource = null;
                        dataGrid.DataSource = matriculasBuscadas;
                        dataGrid.Update();
                        dataGrid.Refresh();
                        break;
                    case 4:
                        matriculasBuscadas = matriculaNegocios.ConsultarPorIdUsuario(Convert.ToInt32(CbxUsuario.SelectedValue));
                        dataGrid.DataSource = null;
                        dataGrid.DataSource = matriculasBuscadas;
                        dataGrid.Update();
                        dataGrid.Refresh();
                        break;
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
        private void dataGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((dataGrid.Rows[e.RowIndex].DataBoundItem != null) && (dataGrid.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
            {
                e.Value = BindProperty(dataGrid.Rows[e.RowIndex].DataBoundItem, dataGrid.Columns[e.ColumnIndex].DataPropertyName);
            }
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            new Popup.transparentBg(new Popup.SearchDialogs.ReportMatriculacolecao(matriculasBuscadas));
        }

        private void CbxBusca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbxBusca.SelectedIndex != -1)
            {
                switch (CbxBusca.SelectedIndex)
                {
                    case 0:
                        PanelNome.Visible = true;
                        PanelCpf.Visible = false;
                        PanelData.Visible = false;
                        PanelTurma.Visible = false;          
                        PanelUsuario.Visible = false;
                        busca = CbxBusca.SelectedIndex;
                        break;
                    case 1:
                        PanelNome.Visible = false;
                        PanelCpf.Visible = true;
                        PanelData.Visible = false;
                        PanelTurma.Visible = false;
                        PanelUsuario.Visible = false;
                        busca = CbxBusca.SelectedIndex;
                        break;
                    case 2:
                        PanelNome.Visible = false;
                        PanelCpf.Visible = false;
                        PanelData.Visible = true;
                        PanelTurma.Visible = false;
                        PanelUsuario.Visible = false;
                        busca = CbxBusca.SelectedIndex;
                        break;
                    case 3:
                        PanelNome.Visible = false;
                        PanelCpf.Visible = false;
                        PanelData.Visible = false;
                        PanelTurma.Visible = true;
                        PanelUsuario.Visible = false;
                        busca = CbxBusca.SelectedIndex;
                        break;
                    case 4:
                        PanelNome.Visible = false;
                        PanelCpf.Visible = false;
                        PanelData.Visible = false;
                        PanelTurma.Visible = false;
                        PanelUsuario.Visible = true;
                        busca = CbxBusca.SelectedIndex;
                        break;
                }
            }
        }
    }

}
