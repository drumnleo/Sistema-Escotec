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
    public partial class Frm_TpCurso : Form
    {
        public Frm_TpCurso()
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

        public TipoCurso TipoCursoEscolhido { get; set; }

        private void SearchDialog_Load(object sender, EventArgs e)
        {
            CarregarDataGrid();
            BtnSalvar.Enabled = true;
            BtnAtualizar.Enabled = false;
            BtnExcluir.Enabled = false;
        }
        private void SearchDialog_Shown(object sender, EventArgs e)
        {
            TbxVagas.Focus();
        }


        // Métodos Botões

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            TipoCursoNegocios tipoCursoNegocios = new TipoCursoNegocios();
            TipoCurso tipoCurso = new TipoCurso();
            string retorno = "erro";
            try
            {
                string vagas = VerificaCampoDigitado(TbxVagas.Text, "Vagas");
                tipoCurso.Vagas = Convert.ToInt16(vagas);
                if (CbxLaboratorio.SelectedValue != null)
                {
                    tipoCurso.Laboratorio = new Laboratorio();
                    tipoCurso.Laboratorio.Id_Laboratorio = Convert.ToInt32(CbxLaboratorio.SelectedValue.ToString());
                }
                else
                {
                    throw new Exception("Erro ao inserir Laboratório, verifique!");
                }
                tipoCurso.Nome = VerificaCampoDigitado(TbxNomeCurso.Text, "Nome Curso");
                tipoCurso.Descricao = TbxCursoDescricao.Text;
                tipoCurso.Usuario = LoginNegocios.UsuarioLogadoGetSet;
                retorno = tipoCursoNegocios.Inserir(tipoCurso);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
            try
            {
                int idTipoTurma = Convert.ToInt32(retorno);
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
            TipoCursoNegocios tipoCursoNegocios = new TipoCursoNegocios();
            TipoCurso tipoCurso = new TipoCurso();
            try
            {
                string vagas = VerificaCampoDigitado(TbxVagas.Text, "Vagas");
                tipoCurso.Id_Tipo_Curso = Convert.ToInt32(TbxId.Text);
                tipoCurso.Vagas = Convert.ToInt16(vagas);
                if (CbxLaboratorio.SelectedValue != null)
                {
                    tipoCurso.Laboratorio = new Laboratorio();
                    tipoCurso.Laboratorio.Id_Laboratorio = Convert.ToInt32(CbxLaboratorio.SelectedValue.ToString());
                }
                else
                {
                    throw new Exception("Erro ao carregar Laboratório selecionado, verifique!");
                }
                tipoCurso.Nome = VerificaCampoDigitado(TbxNomeCurso.Text, "Nome Curso");
                tipoCurso.Descricao = TbxCursoDescricao.Text;
                tipoCurso.Usuario = LoginNegocios.UsuarioLogadoGetSet;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            string retorno = tipoCursoNegocios.AtualizarporId(tipoCurso);

            try
            {
                int idTipoTurma = Convert.ToInt32(retorno);
                MessageBox.Show("Atualizado com sucesso!", "Confirmado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao inserir. Detalhes: " + retorno, "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            TipoCursoNegocios tipoCursoNegocios = new TipoCursoNegocios();
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
            TipoCurso tipoCurso = new TipoCurso();
            tipoCurso.Usuario = LoginNegocios.UsuarioLogadoGetSet;
            tipoCurso.Id_Tipo_Curso = Convert.ToInt32(TbxId.Text);
            string retorno = tipoCursoNegocios.Excluir(tipoCurso);

            try
            {
                int idTipoCurso = Convert.ToInt32(retorno);
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
            TipoCursoNegocios tipoCursoNegocios = new TipoCursoNegocios();
            TipoCursoEscolhido = tipoCursoNegocios.ConsultarPorId(Convert.ToInt32(dataGrid.Rows[dataGrid.CurrentRow.Index].Cells[0].Value))[0];

            TbxId.Text = TipoCursoEscolhido.Id_Tipo_Curso.ToString();
            TbxVagas.Text = TipoCursoEscolhido.Vagas.ToString();
            TbxDataCadastro.Text = TipoCursoEscolhido.Data_Cadastro.ToShortDateString();
            TbxDataAtualizacao.Text = TipoCursoEscolhido.Data_Ultima_Alteracao.ToShortDateString();
            TbxNomeCurso.Text = TipoCursoEscolhido.Nome;
            TbxCursoDescricao.Text = TipoCursoEscolhido.Descricao;

            CbxLaboratorio.DataSource = null;
            LaboratorioNegocios laboratorioNegocios = new LaboratorioNegocios();
            LaboratorioColecao laboratorios = laboratorioNegocios.ConsultarPorId(TipoCursoEscolhido.Laboratorio.Id_Laboratorio);

            CbxLaboratorio.DataSource = laboratorios;
            CbxLaboratorio.DisplayMember = "NOME";
            CbxLaboratorio.ValueMember = "ID_LABORATORIO";
            CbxLaboratorio.Update();
            CbxLaboratorio.Refresh();
            CbxLaboratorio.SelectedIndex = 0;
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
            TipoCursoEscolhido = null;
            TbxId.Text = "";
            TbxVagas.Text = "";
            TbxDataCadastro.Text = "";
            TbxDataAtualizacao.Text = "";
            TbxNomeCurso.Text = "";
            TbxCursoDescricao.Text = "";
            CarregarComboBox();
            CbxLaboratorio.SelectedIndex = -1;

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
            TipoCursoNegocios tipoCursoNegocios = new TipoCursoNegocios();
            TipoCursoColecao tipoCursos = tipoCursoNegocios.ConsultarPorNome("");

            dataGrid.DataSource = null;
            dataGrid.DataSource = tipoCursos;
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
            LaboratorioNegocios laboratorioNegocios = new LaboratorioNegocios();
            LaboratorioColecao laboratorios = laboratorioNegocios.ConsultarPorNome("");

            CbxLaboratorio.DataSource = null;
            CbxLaboratorio.DataSource = laboratorios;
            CbxLaboratorio.DisplayMember = "NOME";
            CbxLaboratorio.ValueMember = "ID_LABORATORIO";
            CbxLaboratorio.SelectedIndex = -1;
        }
        private void CbxLaboratorio_Click(object sender, EventArgs e)
        {
            CarregarComboBox();
        }
    }
}
