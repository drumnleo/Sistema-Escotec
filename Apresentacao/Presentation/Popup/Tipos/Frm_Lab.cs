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
    public partial class Frm_Lab : Form
    {
        public Frm_Lab()
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

        public Laboratorio LaboratorioEscolhido { get; set; }

        private void SearchDialog_Load(object sender, EventArgs e)
        {
            CarregarDataGrid();
            BtnSalvar.Enabled = true;
            BtnAtualizar.Enabled = false;
            BtnExcluir.Enabled = false;
        }
        private void SearchDialog_Shown(object sender, EventArgs e)
        {
            TbxNomeLab.Focus();
        }


        // Métodos Botões

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            LaboratorioNegocios laboratorioNegocios = new LaboratorioNegocios();
            Laboratorio laboratorio = new Laboratorio();
            try
            {
                laboratorio.Nome = VerificaCampoDigitado(TbxNomeLab.Text, "Nome");
                string numsala = VerificaCampoDigitado(TbxNumSala.Text, "Nº Sala");
                laboratorio.Numero_Sala = Convert.ToInt16(numsala);
                string capacidade = VerificaCampoDigitado(TbxCap.Text, "Max. Alunos");
                laboratorio.Capacidade = Convert.ToInt16(capacidade);
                if (CbxTipoLab.SelectedValue != null)
                {
                    laboratorio.TipoLaboratorio = new TipoLaboratorio();
                    laboratorio.TipoLaboratorio.Id_Tipo_Laboratorio = Convert.ToInt32(CbxTipoLab.SelectedValue.ToString());
                }
                else
                {
                    throw new Exception("Erro ao inserir Laboratório, verifique!");
                }
                laboratorio.Usuario = LoginNegocios.UsuarioLogadoGetSet;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            string retorno = laboratorioNegocios.Inserir(laboratorio);

            try
            {
                int idLaboratorio = Convert.ToInt32(retorno);
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
            LaboratorioNegocios laboratorioNegocios = new LaboratorioNegocios();
            Laboratorio laboratorio = new Laboratorio();
            try
            {
                laboratorio.Id_Laboratorio = Convert.ToInt32(TbxId.Text);
                laboratorio.Nome = VerificaCampoDigitado(TbxNomeLab.Text, "Nome");
                string numsala = VerificaCampoDigitado(TbxNumSala.Text, "Nº Sala");
                laboratorio.Numero_Sala = Convert.ToInt16(numsala);
                string capacidade = VerificaCampoDigitado(TbxCap.Text, "Max. Alunos");
                laboratorio.Capacidade = Convert.ToInt16(capacidade);
                if (CbxTipoLab.SelectedValue != null)
                {
                    laboratorio.TipoLaboratorio = new TipoLaboratorio();
                    laboratorio.TipoLaboratorio.Id_Tipo_Laboratorio = Convert.ToInt32(CbxTipoLab.SelectedValue.ToString());
                }
                else
                {
                    throw new Exception("Erro ao atualizar Laboratório, verifique!");
                }
                laboratorio.Usuario = LoginNegocios.UsuarioLogadoGetSet;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            string retorno = laboratorioNegocios.AtualizarporId(laboratorio);

            try
            {
                int idLaboratorio = Convert.ToInt32(retorno);
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
            LaboratorioNegocios laboratorioNegocios = new LaboratorioNegocios();
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
            Laboratorio laboratorio = new Laboratorio();
            laboratorio.Usuario = LoginNegocios.UsuarioLogadoGetSet;
            laboratorio.Id_Laboratorio = Convert.ToInt32(TbxId.Text);
            string retorno = laboratorioNegocios.Excluir(laboratorio);

            try
            {
                int idLaboratorio = Convert.ToInt32(retorno);
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
            LaboratorioNegocios laboratorioNegocios = new LaboratorioNegocios();
            LaboratorioEscolhido = laboratorioNegocios.ConsultarPorId(Convert.ToInt32(dataGrid.Rows[dataGrid.CurrentRow.Index].Cells[0].Value))[0];

            TbxId.Text = LaboratorioEscolhido.Id_Laboratorio.ToString();
            TbxNumSala.Text = LaboratorioEscolhido.Numero_Sala.ToString();
            TbxDataCadastro.Text = LaboratorioEscolhido.Data_Cadastro.ToShortDateString();
            TbxDataAtualizacao.Text = LaboratorioEscolhido.Data_Ultima_Alteracao.ToShortDateString();
            TbxNomeLab.Text = LaboratorioEscolhido.Nome;
            TbxCap.Text = LaboratorioEscolhido.Capacidade.ToString();

            CbxTipoLab.DataSource = null;
            TipoLaboratorioNegocios tipoLaboratorioNegocios = new TipoLaboratorioNegocios();
            TipoLaboratorioColecao tipoLaboratorios = tipoLaboratorioNegocios.ConsultarPorId(LaboratorioEscolhido.TipoLaboratorio.Id_Tipo_Laboratorio);

            CbxTipoLab.DataSource = tipoLaboratorios;
            CbxTipoLab.DisplayMember = "TIPO";
            CbxTipoLab.ValueMember = "ID_TIPO_LABORATORIO";
            CbxTipoLab.Update();
            CbxTipoLab.Refresh();
            CbxTipoLab.SelectedIndex = 0;
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
            LaboratorioEscolhido = null;
            TbxId.Text = "";
            TbxNumSala.Text = "";
            TbxDataCadastro.Text = "";
            TbxDataAtualizacao.Text = "";
            TbxNomeLab.Text = "";
            TbxCap.Text = "";
            CarregarComboBox();
            CbxTipoLab.SelectedIndex = -1;

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
            LaboratorioNegocios laboratorioNegocios = new LaboratorioNegocios();
            LaboratorioColecao laboratorios = laboratorioNegocios.ConsultarPorNome("");

            dataGrid.DataSource = null;
            dataGrid.DataSource = laboratorios;
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


        //Método ComboBox
        private void CarregarComboBox()
        {
            TipoLaboratorioNegocios tipoLaboratorioNegocios = new TipoLaboratorioNegocios();
            TipoLaboratorioColecao tipoLaboratorios = tipoLaboratorioNegocios.ConsultarPorTipo("");

            CbxTipoLab.DataSource = null;
            CbxTipoLab.DataSource = tipoLaboratorios;
            CbxTipoLab.DisplayMember = "TIPO";
            CbxTipoLab.ValueMember = "ID_TIPO_LABORATORIO";
            CbxTipoLab.SelectedIndex = -1;
        }
        private void CbxLaboratorio_Click(object sender, EventArgs e)
        {
            CarregarComboBox();
        }
    }
}
