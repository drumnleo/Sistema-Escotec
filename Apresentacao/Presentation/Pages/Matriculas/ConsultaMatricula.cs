using System;
using System.Windows.Forms;
using ObjetoTransferencia;
using Negocios;
using System.Reflection;
using Microsoft.Reporting.WinForms;

namespace Apresentacao.Presentation.Pages
{
    public partial class ConsultaMatricula : UserControl
    {
        MatriculaColecao matriculasBuscadas = new MatriculaColecao();
        ReportDataSource rs = new ReportDataSource(); 
        public ConsultaMatricula()
        {
            if (Program.IsInDesignMode()) return;
            InitializeComponent();
            dataGrid.AutoGenerateColumns = false;
        }
        private void cbxUsuario_Click(object sender, EventArgs e)
        {
            carregacbxusuario();
        }
        private void cbxCurso_Click(object sender, EventArgs e)
        {
            Carregacbxcurso();
        }
        private void carregacbxusuario()
        {
            UsuarioNegocios usuarioNegocios = new UsuarioNegocios();
            UsuarioColecao usuarioColecao = usuarioNegocios.ConsultarPorNome("");

            cbxUsuario.DataSource = null;
            cbxUsuario.DataSource = usuarioColecao;
            cbxUsuario.ValueMember = "Id_Usuario";
            cbxUsuario.DisplayMember = "Nome_Usuario";
        }
        private void Carregacbxcurso()
        {
            CursoNegocios cursoNegocios = new CursoNegocios();
            CursoColecao cursoColecao = cursoNegocios.ConsultarPorNome("");

            cbxCurso.DataSource = null;
            cbxCurso.DataSource = cursoColecao;
            cbxCurso.ValueMember = "Id_Curso";
            cbxCurso.DisplayMember = "Nome";
        }
        private void timerpreenche_Tick(object sender, EventArgs e)
        {
            if (rd01.Checked)
            {
                cbxCurso.Enabled = false;
                cbxUsuario.Enabled = false;
                dtInicio.Enabled = true;
                dtFim.Enabled = true;
            }
            else if (rd02.Checked)
            {
                cbxCurso.Enabled = false;
                cbxUsuario.Enabled = true;
                dtInicio.Enabled = false;
                dtFim.Enabled = false;
            }
            else if (rd03.Checked)
            {
                cbxCurso.Enabled = true;
                cbxUsuario.Enabled = false;
                dtInicio.Enabled = false;
                dtFim.Enabled = false;
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (rd01.Checked)
            {
                MatriculaNegocios matriculaNegocios = new MatriculaNegocios();
                matriculasBuscadas = matriculaNegocios.ConsultarPorDatas(dtInicio.Value, dtFim.Value);

                dataGrid.DataSource = null;
                dataGrid.DataSource = matriculasBuscadas;

                dataGrid.Update();
                dataGrid.Refresh();
            }
            else if (rd02.Checked)
            {
                
            }
            else if (rd03.Checked)
            {
                
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
    }

}
