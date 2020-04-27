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
using System.Linq;
using Microsoft.Reporting.WinForms;

namespace Apresentacao.Presentation.Popup.SearchDialogs
{
    
    public partial class ReportMatriculacolecao : Form
    {
        MatriculaColecao matriculas = new MatriculaColecao();
        public ReportMatriculacolecao(MatriculaColecao matriculaColecao)
        {
            InitializeComponent();
            matriculas = matriculaColecao;
        }
        ReportDataSource rs = new ReportDataSource();
        //private void dataGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        //{
        //    if ((dataGrid.Rows[e.RowIndex].DataBoundItem != null) && (dataGrid.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
        //    {
        //        e.Value = BindProperty(dataGrid.Rows[e.RowIndex].DataBoundItem, dataGrid.Columns[e.ColumnIndex].DataPropertyName);
        //    }
        //}

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

        private void LoadingData()
        {
            rs.Name = "Matricula";
            rs.Value = matriculas;
            reportViewer1.LocalReport.DataSources.Add(rs);
            reportViewer1.LocalReport.ReportEmbeddedResource = "Apresentacao.RlMatriculaListaDiaria.rdlc";
            reportViewer1.Dock = DockStyle.Fill;
            this.Controls.Add(reportViewer1);
            reportViewer1.RefreshReport();

        }

        private void ReportMatriculacolecao_Load(object sender, EventArgs e)
        {
            LoadingData();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public class MatriculaRelatorio
        {
            public int Id_Matricula { get; set; }
        }
    }
}
