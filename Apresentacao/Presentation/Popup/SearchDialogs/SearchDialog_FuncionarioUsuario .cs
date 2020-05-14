using System;
using System.Windows.Forms;
using ObjetoTransferencia;
using Negocios;
using System.Reflection;
using Apresentacao.Presentation.Pages;

namespace Apresentacao.Presentation.Popup.SearchDialogs
{
    
    public partial class SearchDialog_FuncionarioUsuario : Form
    {
        Funcionario funcionarioEscolhido = new Funcionario();
        Usuario usuarioEscolhido = new Usuario();


        public SearchDialog_FuncionarioUsuario()
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
            Atualizarcampos();
        }

        private void Atualizarcampos()
        {
            if (dataGrid.CurrentRow != null)
            {
                FuncionarioNegocios funcionarioNegocios = new FuncionarioNegocios();
                funcionarioEscolhido = funcionarioNegocios.ConsultarPorId(Convert.ToInt32(dataGrid.Rows[dataGrid.CurrentRow.Index].Cells[0].Value))[0];
                UsuarioNegocios usuarioNegocios = new UsuarioNegocios();
                usuarioEscolhido = usuarioNegocios.ConsultarPorIdFuncionario(funcionarioEscolhido.Id_Funcionario);
                btnSelecionar.Visible = true;
            }
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            FuncionarioNegocios funcionarioNegocios = new FuncionarioNegocios();
            FuncionarioColecao funcionarioColecao = funcionarioNegocios.ConsultarPorDescricao(tbxSearch.Text);
            

            dataGrid.DataSource = null;
            dataGrid.DataSource = funcionarioColecao;
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
            AdicionarEditarUsuario.FuncionarioGetSet = new Funcionario();
            AdicionarEditarUsuario.UsuarioGetSet = new Usuario();
            AdicionarEditarUsuario.AtualizarFuncionario = true;
            AdicionarEditarUsuario.AtualizarUsuario = true;


            AdicionarEditarUsuario.FuncionarioGetSet = funcionarioEscolhido;
            PessoaNegocios pessoaNegocios = new PessoaNegocios();
            AdicionarEditarUsuario.FuncionarioGetSet.Pessoa = pessoaNegocios.ConsultarPorId(funcionarioEscolhido.Pessoa.Id_Pessoa);
            AdicionarEditarUsuario.AtualizarFuncionario = true;

            if (usuarioEscolhido.Id_Usuario.ToString() != "")
            {
                AdicionarEditarUsuario.UsuarioGetSet = usuarioEscolhido;
            }
            else
            {
                AdicionarEditarUsuario.UsuarioGetSet = new Usuario();
            }
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
