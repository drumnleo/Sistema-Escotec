using System;
using System.Windows.Forms;
using ObjetoTransferencia;
using Negocios;
using System.Reflection;
using Apresentacao.Presentation.Pages;

namespace Apresentacao.Presentation.Popup.SearchDialogs
{
    
    public partial class SearchDialog_Usuario : Form
    {
        Usuario UsuarioEscolhido = new Usuario();

        public SearchDialog_Usuario()
        {
            InitializeComponent();

            dataGrid.AutoGenerateColumns = false;
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
            UsuarioNegocios usuarioNegocios = new UsuarioNegocios();
            UsuarioEscolhido = usuarioNegocios.ConsultarPorId(Convert.ToInt32(dataGrid.Rows[dataGrid.CurrentRow.Index].Cells[0].Value));

            btnSelecionar.Visible = true;
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            UsuarioNegocios usuarioNegocios = new UsuarioNegocios();
            UsuarioColecao usuarioColecao = usuarioNegocios.ConsultarPorNome(tbxSearch.Text);
            

            dataGrid.DataSource = null;
            dataGrid.DataSource = usuarioColecao;
            dataGrid.Update();
            dataGrid.Refresh();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            AdicionarEditarUsuario.UsuarioGetSet = UsuarioEscolhido;
            //AdicionarEditarFuncionario.PessoaGetSet = funcionarioEscolhido.Pessoa;
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
