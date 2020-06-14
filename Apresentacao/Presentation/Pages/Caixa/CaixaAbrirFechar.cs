using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;
using ObjetoTransferencia;
using System.Reflection;

namespace Apresentacao.Presentation.Pages
{
    public partial class CaixaAbrirFechar : UserControl
    {
        public CaixaColecao CaixasGetSet { get; set; }
        public Caixa CaixaEscolhido { get; set; }


        int busca = 0;

        public CaixaAbrirFechar()
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

            PanelData.Visible = false;
            PanelUsuario.Visible = false;

            TbxSaldo.Enabled = false;
            TbxSituacao.Enabled = false;
            TbxDataFechamento.Enabled = false;

            CbxBusca.SelectedIndex = 0;

            BtnAbrir.Enabled = true;
            BtnExcluir.Enabled = false;
            BtnAtualizar.Enabled = false;
            BtnNovo.Enabled = true;

            Carregacbxusuarioscaixa();
        }

        private void Carregacbxusuario()
        {
            UsuarioNegocios usuarioNegocios = new UsuarioNegocios();
            UsuarioColecao usuarioColecao = usuarioNegocios.ConsultarPorNome("");

            CbxUsuario.DataSource = null;
            CbxUsuario.DataSource = usuarioColecao;
            CbxUsuario.ValueMember = "Id_Usuario";
            CbxUsuario.DisplayMember = "Nome_Usuario";
        }

        private void Carregacbxusuarioscaixa()
        {
            UsuarioNegocios usuarioNegocios = new UsuarioNegocios();
            UsuarioColecao usuarioColecao = usuarioNegocios.ConsultarPorNome("");

            CbxUsuarioRecebe.DataSource = null;
            CbxUsuarioRecebe.DataSource = usuarioColecao;
            CbxUsuarioRecebe.ValueMember = "Id_Usuario";
            CbxUsuarioRecebe.DisplayMember = "Nome_Usuario";
            CbxUsuarioRecebe.SelectedIndex = -1;
        }

        private void Carregacbxusuariorecebe()
        {
            UsuarioNegocios usuarioNegocios = new UsuarioNegocios();
            UsuarioColecao usuarioColecao = usuarioNegocios.ConsultarPorNome("");

            CbxUsuarioRecebe.DataSource = null;
            CbxUsuarioRecebe.DataSource = usuarioColecao;
            CbxUsuarioRecebe.ValueMember = "Id_Usuario";
            CbxUsuarioRecebe.DisplayMember = "Nome_Usuario";
            CbxUsuarioRecebe.SelectedIndex = -1;
        }

        private void CbxBusca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbxBusca.SelectedIndex != -1)
            {
                switch (CbxBusca.SelectedIndex)
                {
                    case 0:
                        PanelData.Visible = true;
                        PanelUsuario.Visible = false;
                        busca = CbxBusca.SelectedIndex;
                        break;
                    case 1:
                        PanelData.Visible = false;
                        PanelUsuario.Visible = true;
                        busca = CbxBusca.SelectedIndex;
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
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            CarregaDataGrid();
        }

        private void CarregaDataGrid()
        {
            if (busca > -1)
            {
                CaixaNegocios caixaNegocios = new CaixaNegocios();
                switch (busca)
                {
                    case 1:
                        CaixasGetSet = caixaNegocios.ConsultarPorFuncRecebe(Convert.ToInt32(CbxUsuario.SelectedValue));
                        dataGrid.DataSource = null;
                        dataGrid.DataSource = CaixasGetSet;
                        dataGrid.Update();
                        dataGrid.Refresh();
                        break;
                    case 0:
                        CaixasGetSet = caixaNegocios.ConsultarPorData(DtInicio.Value, DtFim.Value);
                        dataGrid.DataSource = null;
                        dataGrid.DataSource = CaixasGetSet;
                        dataGrid.Update();
                        dataGrid.Refresh();
                        break;
                    case 2:
                        CaixasGetSet = caixaNegocios.ConsultarTodos();
                        dataGrid.DataSource = null;
                        dataGrid.DataSource = CaixasGetSet;
                        dataGrid.Update();
                        dataGrid.Refresh();
                        busca = 1;
                        break;
                }
            }
        }
        private void CbxUsuario_Click(object sender, EventArgs e)
        {
            Carregacbxusuario();
        }
        private void Atualizarcampos()
        {
            CaixaNegocios caixaNegocios = new CaixaNegocios();

            CaixaEscolhido = new Caixa();
            CaixaColecao caixas = caixaNegocios.ConsultarPorIdCaixa(Convert.ToInt32(dataGrid.Rows[dataGrid.CurrentRow.Index].Cells[0].Value));
            CaixaEscolhido = caixas[0];
            TbxIdCaixa.Text = CaixaEscolhido.Id_Caixa.ToString();
            TbxDataCadastro.Text = CaixaEscolhido.Data_Cadastro.ToShortDateString();
            TbxUltimaAlteracao.Text = CaixaEscolhido.Data_Ultima_Alteracao.ToShortDateString();
            TbxDataCaixa.Text = CaixaEscolhido.Data_Caixa.ToShortDateString();
            TbxValorAbertura.Text = CaixaEscolhido.Valor_Abertura.ToString();
            TbxValorSangria.Text = CaixaEscolhido.Valor_Sangria.ToString();
            TbxSaldo.Text = CaixaEscolhido.Saldo.ToString();
            if (CaixaEscolhido.Situacao == "a")
            {
                TbxSituacao.Text = "Aberto";
                TbxUsuarioAbre.Text = CaixaEscolhido.Func_Abre.Nome_Usuario;
            }
            else if (CaixaEscolhido.Situacao == "f")
            {
                TbxSituacao.Text = "Fechado";
                TbxUsuarioFecha.Text = CaixaEscolhido.Func_Fechamento.Nome_Usuario;
            }
            else
            {
                TbxSituacao.Text = "Erro!";
            }
            TbxDataFechamento.Text = CaixaEscolhido.Data_Ultima_Alteracao.ToShortDateString();

            UsuarioNegocios usuarioNegocios = new UsuarioNegocios();
            

            CbxUsuarioRecebe.DataSource = null;
            
            UsuarioColecao usuarios2 = new UsuarioColecao();
            Usuario usuarioRecebe = usuarioNegocios.ConsultarPorId(CaixaEscolhido.Func_Recebe.Id_Usuario);
            usuarios2.Add(usuarioRecebe);
            CbxUsuarioRecebe.DataSource = usuarios2;
            CbxUsuarioRecebe.DisplayMember = "NOME_USUARIO";
            CbxUsuarioRecebe.ValueMember = "ID_USUARIO";
            CbxUsuarioRecebe.Update();
            CbxUsuarioRecebe.Refresh();
            CbxUsuarioRecebe.SelectedIndex = 0;            
        }
        private void LimparCampos()
        {
            TbxIdCaixa.Text = "";
            TbxDataCadastro.Text = "";
            TbxUltimaAlteracao.Text = "";
            TbxDataCaixa.Text = "";
            TbxValorAbertura.Text = "";
            TbxValorSangria.Text = "";
            TbxSaldo.Text = "";
            TbxSituacao.Text = "";
            TbxDataFechamento.Text = "";
            Carregacbxusuarioscaixa();

            CaixasGetSet = null;
            CaixaEscolhido = null;

            BtnAbrir.Enabled = true;
            BtnExcluir.Enabled = false;
            BtnAtualizar.Enabled = false;
            BtnNovo.Enabled = true;
            BtnFechar.Enabled = false;
            
        }

        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Atualizarcampos();
            if (CaixaEscolhido.Situacao == "f")
            {
                BtnExcluir.Enabled = false;
                BtnAtualizar.Enabled = false;
                BtnAbrir.Enabled = false;
                BtnNovo.Enabled = true;
                BtnFechar.Enabled = false;
            }
            if (CaixaEscolhido.Situacao == "a")
            {
                BtnExcluir.Enabled = true;
                BtnAtualizar.Enabled = true;
                BtnAbrir.Enabled = false;
                BtnNovo.Enabled = true;
                BtnFechar.Enabled = true;

                TbxDataFechamento.Enabled = true;
            }
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

        private void CbxUsuarioRecebe_Click(object sender, EventArgs e)
        {
            Carregacbxusuariorecebe();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void BtnAbrir_Click(object sender, EventArgs e)
        {
            CaixaNegocios caixaNegocios = new CaixaNegocios();
            Caixa caixa = new Caixa();
            caixa.Func_Abre = LoginNegocios.UsuarioLogadoGetSet;
            try
            {
                if (CbxUsuarioRecebe.SelectedValue != null)
                {
                    caixa.Func_Recebe = new Usuario();
                    caixa.Func_Recebe.Id_Usuario = Convert.ToInt32(CbxUsuarioRecebe.SelectedValue.ToString());
                }
                else
                {
                    throw new Exception("Erro ao inserir Usuario do Caixa, verifique!");
                }

                bool valorAbertura = decimal.TryParse(TbxValorAbertura.Text, out decimal valorAberturaDecimal);
                if (valorAbertura)
                {
                    caixa.Valor_Abertura = valorAberturaDecimal;
                }
                else
                {
                    throw new Exception("Erro ao inserir valor de abertura, verifique!");
                }

                bool valorSangria = decimal.TryParse(TbxValorSangria.Text, out decimal valorSangriaDecimal);
                if (valorAbertura)
                {
                    caixa.Valor_Sangria = valorSangriaDecimal;
                }
                else
                {
                    throw new Exception("Erro ao inserir valor de sangria, verifique!");
                }

                bool dataCaixa = DateTime.TryParse(TbxDataCaixa.Text, out DateTime dataCaixaDate);
                if (valorAbertura)
                {
                    caixa.Data_Caixa = dataCaixaDate;
                }
                else
                {
                    throw new Exception("Erro ao inserir data do caixa, verifique!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            string retorno = caixaNegocios.AbreCaixa(caixa);

            try
            {
                int idCaixa = Convert.ToInt32(retorno);
                MessageBox.Show("Aberto com sucesso!", "Confirmado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CaixaEscolhido = null;
                CaixaEscolhido = caixaNegocios.ConsultarPorIdCaixa(idCaixa)[0];
                LimparCampos();
                busca = 2;
                CarregaDataGrid();

            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao abrir caixa. Detalhes: " + retorno);
            }
        }

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            CaixaNegocios caixaNegocios = new CaixaNegocios();
            Caixa caixa = new Caixa();
            try
            {
                caixa.Id_Caixa = Convert.ToInt32(TbxIdCaixa.Text);
                caixa.Func_Abre = LoginNegocios.UsuarioLogadoGetSet;

                if (CbxUsuarioRecebe.SelectedValue != null)
                {
                    caixa.Func_Recebe = new Usuario();
                    caixa.Func_Recebe.Id_Usuario = Convert.ToInt32(CbxUsuarioRecebe.SelectedValue.ToString());
                }
                else
                {
                    throw new Exception("Erro ao inserir Usuario do Caixa, verifique!");
                }

                bool valorAbertura = decimal.TryParse(TbxValorAbertura.Text, out decimal valorAberturaDecimal);
                if (valorAbertura)
                {
                    caixa.Valor_Abertura = valorAberturaDecimal;
                }
                else
                {
                    throw new Exception("Erro ao inserir valor de abertura, verifique!");
                }

                bool valorSangria = decimal.TryParse(TbxValorSangria.Text, out decimal valorSangriaDecimal);
                if (valorAbertura)
                {
                    caixa.Valor_Sangria = valorSangriaDecimal;
                }
                else
                {
                    throw new Exception("Erro ao inserir valor de sangria, verifique!");
                }

                bool dataCaixa = DateTime.TryParse(TbxDataCaixa.Text, out DateTime dataCaixaDate);
                if (valorAbertura)
                {
                    caixa.Data_Caixa = dataCaixaDate;
                }
                else
                {
                    throw new Exception("Erro ao inserir data do caixa, verifique!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            string retorno = caixaNegocios.AtualizaCaixa(caixa);

            try
            {
                int idCaixa = Convert.ToInt32(retorno);
                MessageBox.Show("Atualizado com sucesso!", "Confirmado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CaixaEscolhido = null;
                CaixaEscolhido = caixaNegocios.ConsultarPorIdCaixa(idCaixa)[0];
                LimparCampos();
                busca = 2;
                CarregaDataGrid();

            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao atualizar caixa. Detalhes: " + retorno);
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            CaixaNegocios caixaNegocios = new CaixaNegocios();
            if (TbxIdCaixa.Text == "")
            {
                MessageBox.Show("Nenhum caixa selecionado.");
                return;
            }
            DialogResult resultado = MessageBox.Show("Tem certeza?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.No)
            {
                return;
            }
            Caixa caixa = new Caixa();
            caixa.Id_Caixa = Convert.ToInt32(TbxIdCaixa.Text);

            string retorno = caixaNegocios.ExcluiCaixa(caixa);

            try
            {
                int idCaixa = Convert.ToInt32(retorno);
                MessageBox.Show("Excluído com sucesso!", "Confirmado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
                busca = 2;
                CarregaDataGrid();
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao excluir. Detalhes: " + retorno);
            }
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            CaixaNegocios caixaNegocios = new CaixaNegocios();
            CaixaEscolhido.Func_Fechamento = LoginNegocios.UsuarioLogadoGetSet;
            string retorno = caixaNegocios.FechaCaixa(CaixaEscolhido);

            try
            {
                int idCaixa = Convert.ToInt32(retorno);
                MessageBox.Show("Caixa fechado com sucesso!");
                LimparCampos();
                busca = 2;
                CarregaDataGrid();
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao fechar caixa. Detalhes: " + retorno);
            }
        }
    }
}
