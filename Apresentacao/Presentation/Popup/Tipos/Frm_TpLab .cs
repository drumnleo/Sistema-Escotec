using Negocios;
using ObjetoTransferencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao.Presentation.Popup.Tipos
{
    public partial class Frm_TpLab : Form
    {
        public Frm_TpLab()
        {
            InitializeComponent();

            dataGrid.AutoGenerateColumns = false;
            dataGrid.AllowUserToResizeColumns = false;
            dataGrid.AllowUserToResizeRows = false;
            dataGrid.ColumnHeadersHeight = 20;
            dataGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGrid.RowHeadersWidth = 20;
            dataGrid.RowTemplate.Height = 20;
            dataGrid.RowHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            CarregarDataGrid();
        }

        public TipoLaboratorio TipoLaboratorioEscolhido { get; set; }

        private void SearchDialog_Load(object sender, EventArgs e)
        {
            CarregarDataGrid();
            BtnSalvar.Enabled = true;
            BtnAtualizar.Enabled = false;
            BtnExcluir.Enabled = false;
        }
        private void SearchDialog_Shown(object sender, EventArgs e)
        {
            TbxTipo.Focus();
        }


        // Métodos Botões

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            TipoLaboratorioNegocios tipoLaboratorioNegocios = new TipoLaboratorioNegocios();
            TipoLaboratorio tipoLaboratorio = new TipoLaboratorio();
            try
            {
                tipoLaboratorio.Tipo = VerificaCampoDigitado(TbxTipo.Text, "Tipo");
                tipoLaboratorio.Descricao = VerificaCampoDigitado(TbxDescricao.Text, "Descrição");
                tipoLaboratorio.Usuario = LoginNegocios.UsuarioLogadoGetSet;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            string retorno = tipoLaboratorioNegocios.Inserir(tipoLaboratorio);

            try
            {
                int idTipoLaboratorio = Convert.ToInt32(retorno);
                MessageBox.Show("Salvo com sucesso!", "Confirmado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao inserir. Detalhes: " + retorno);
            }
        }
        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            TipoLaboratorioNegocios tipoLaboratorioNegocios = new TipoLaboratorioNegocios();
            TipoLaboratorio tipoLaboratorio = new TipoLaboratorio();
            try
            {
                tipoLaboratorio.Id_Tipo_Laboratorio = Convert.ToInt32(TbxId.Text);
                tipoLaboratorio.Tipo = VerificaCampoDigitado(TbxTipo.Text, "Tipo");
                tipoLaboratorio.Descricao = VerificaCampoDigitado(TbxDescricao.Text, "Descrição");
                tipoLaboratorio.Usuario = LoginNegocios.UsuarioLogadoGetSet;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            string retorno = tipoLaboratorioNegocios.AtualizarporId(tipoLaboratorio);

            try
            {
                int idTipoLaboratorio = Convert.ToInt32(retorno);
                MessageBox.Show("Atualizado com sucesso!", "Confirmado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao atualizar. Detalhes: " + retorno, "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            TipoLaboratorioNegocios tipoLaboratorioNegocios = new TipoLaboratorioNegocios();
            if (TbxId.Text == "")
            {
                MessageBox.Show("Nenhum cadastro selecionado.");
                return;
            }
            DialogResult resultado = MessageBox.Show("Tem certeza?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.No)
            {
                return;
            }
            TipoLaboratorio tipoLaboratorio = new TipoLaboratorio();
            tipoLaboratorio.Usuario = LoginNegocios.UsuarioLogadoGetSet;
            tipoLaboratorio.Id_Tipo_Laboratorio = Convert.ToInt32(TbxId.Text);
            string retorno = tipoLaboratorioNegocios.Excluir(tipoLaboratorio);

            try
            {
                int idTipoLaboratorio = Convert.ToInt32(retorno);
                MessageBox.Show("Excluído com sucesso!", "Confirmado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao excluir. Detalhes: " + retorno);
            }
        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }


        //Métodos Personalizados
        private void Atualizarcampos()
        {
            TipoLaboratorioNegocios tipoLaboratorioNegocios = new TipoLaboratorioNegocios();
            TipoLaboratorioEscolhido = tipoLaboratorioNegocios.ConsultarPorId(Convert.ToInt32(dataGrid.Rows[dataGrid.CurrentRow.Index].Cells[0].Value))[0];

            TbxId.Text = TipoLaboratorioEscolhido.Id_Tipo_Laboratorio.ToString();
            TbxDataCadastro.Text = TipoLaboratorioEscolhido.Data_Cadastro.ToShortDateString();
            TbxDataAtualizacao.Text = TipoLaboratorioEscolhido.Data_Ultima_Alteracao.ToShortDateString();
            TbxTipo.Text = TipoLaboratorioEscolhido.Tipo;
            TbxDescricao.Text = TipoLaboratorioEscolhido.Descricao;
        }
        private string VerificaCampoDigitado(string valor, string campo)
        {
            string retorno;

            if (valor != "")
            {
                retorno = valor;
            }
            else
            {
                throw new Exception("Erro ao inserir o campo " + campo + ". Verifique!");
            }

            return retorno;
        }
        private void LimpaCampos()
        {
            TipoLaboratorioEscolhido = null;
            TbxId.Text = "";
            TbxDataCadastro.Text = "";
            TbxDataAtualizacao.Text = "";
            TbxTipo.Text = "";
            TbxDescricao.Text = "";

            CarregarDataGrid();

            BtnSalvar.Enabled = true;
            BtnAtualizar.Enabled = false;
            BtnExcluir.Enabled = false;
        }


        //Métodos Datagrid
        private void DataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Atualizarcampos();
            BtnSalvar.Enabled = false;
            BtnAtualizar.Enabled = true;
            BtnExcluir.Enabled = true;
        }
        private void CarregarDataGrid()
        {
            TipoLaboratorioNegocios tipoLaboratorioNegocios = new TipoLaboratorioNegocios();
            TipoLaboratorioColecao tipoLaboratorios = tipoLaboratorioNegocios.ConsultarPorTipo("");

            dataGrid.DataSource = null;
            dataGrid.DataSource = tipoLaboratorios;
            dataGrid.Update();
            dataGrid.Refresh();
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
