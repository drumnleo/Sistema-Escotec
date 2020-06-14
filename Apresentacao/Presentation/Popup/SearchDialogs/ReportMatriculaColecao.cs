using System;
using System.Windows.Forms;
using ObjetoTransferencia;
using System.Reflection;


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
            MatriculaRelatorioColecao matCol = new MatriculaRelatorioColecao();
            MatriculaRelatorio matriculaRelatorio = new MatriculaRelatorio();
            foreach (Matricula matricula in matriculas)
            {
                matriculaRelatorio.Id_Matricula = matricula.Id_Matricula;
                matriculaRelatorio.Id_Aluno = matricula.Aluno.Id_Aluno;
                matriculaRelatorio.NomeAluno = matricula.Aluno.Pessoa.Nome;
                matriculaRelatorio.SobrenomeAluno = matricula.Aluno.Pessoa.Sobrenome;
                matriculaRelatorio.Curso = matricula.Turma.Curso.Nome;
                matriculaRelatorio.Qtde_Parcelas = matricula.Turma.Curso.Qtde_Parcelas;
                matriculaRelatorio.Usuario = matricula.Usuario.Id_Usuario;
                matriculaRelatorio.Total = matricula.Turma.Curso.Valor_Total;

                matCol.Add(matriculaRelatorio);
            }
            MatriculaRelatorioBindingSource.DataSource = matCol;
        }

        private void ReportMatriculacolecao_Load(object sender, EventArgs e)
        {
            LoadingData();
            this.reportViewer1.RefreshReport();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
