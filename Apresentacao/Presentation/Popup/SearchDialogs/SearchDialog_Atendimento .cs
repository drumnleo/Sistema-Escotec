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
    
    public partial class SearchDialog_Atendimento : Form
    {
        Atendimento AtendimentoEscolhido = new Atendimento();

        public SearchDialog_Atendimento()
        {
            InitializeComponent();

            dataGrid.AutoGenerateColumns = false;
            btnSelecionar.Visible = false;
        }

        private void SearchDialog_Shown(object sender, EventArgs e)
        {
            tbxNome.Focus();
        }

        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            atualizarcampos();
        }

        private void atualizarcampos()
        {
            AtendimentoNegocios atendimentoNegocios = new AtendimentoNegocios();
            AtendimentoEscolhido = atendimentoNegocios.ConsultarPorId(Convert.ToInt32(dataGrid.Rows[dataGrid.CurrentRow.Index].Cells[0].Value))[0];

            btnSelecionar.Location = new Point(541, 15);
            btnSelecionar.Visible = true;
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            AtendimentoNegocios atendimentoNegocios = new AtendimentoNegocios();
            AtendimentoColecao atendimentoColecao = atendimentoNegocios.ConsultarPorNomePessoa(tbxNome.Text, tbxSobrenome.Text);
            

            dataGrid.DataSource = null;
            dataGrid.DataSource = atendimentoColecao;
            dataGrid.Update();
            dataGrid.Refresh();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            AdicionarEditarAtendimento.AtendimentoGetset = AtendimentoEscolhido;
            AdicionarEditarAtendimento.AtualizaAtendimento = true;
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
