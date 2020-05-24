using System;
using System.Windows.Forms;
using ObjetoTransferencia;
using Negocios;
using System.Reflection;

namespace Apresentacao.Presentation.Pages
{
    public partial class AdicionarEditarMatricula : UserControl
    {
        public AdicionarEditarMatricula()
        {
            if (Program.IsInDesignMode()) return;

            InitializeComponent();

            BtnEfetivar.Enabled = false;

            dataGrid.AutoGenerateColumns = false;
            dataGrid.AllowUserToResizeColumns = false;
            dataGrid.AllowUserToResizeRows = false;
            dataGrid.ColumnHeadersHeight = 30;
            dataGrid.RowHeadersWidth = 30;
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            TimerDatagrid.Stop();
        }

        //-----------     Variáveis e Instancias de Objetos-----------------------
        public static Pessoa PessoaGetSet { get; set; }
        public static Orcamento OrcamentoGetSet { get; set; }
        public static TurmaOrcamento TurmaOrcamentoGetSet { get; set; }
        public static EnderecoColecao EnderecoGetSet { get; set; }
        public static ContasReceberColecao ContasReceberGetSet { get; set; }
        public static Matricula MatriculaGetSet { get; set; }

        public static Boolean AtualizaDatagrid;
        public static Boolean DesabilitaTimer;


        //---------------Load (Carrega ao iniciar formulário)---------------------
        private void AdicionarEditarMatricula_Load(object sender, EventArgs e)
        {

        }



        //------------------------Métodos botões----------------------------------
        private void BtnSearchOrc_Click(object sender, EventArgs e)
        {
            new Apresentacao.Presentation.Popup.transparentBg(new Apresentacao.Presentation.Popup.SearchDialogs.SearchDialog_TurmaOrcamentoMatricula());
            TimerDatagrid.Start();
        }


        //-------------------------Métodos Void-------------------------------------
        private void CamposPessoa()
        {
            PessoaNegocios pessoaNegocios = new PessoaNegocios();
            PessoaGetSet = null;
            PessoaGetSet = pessoaNegocios.ConsultarPorId(TurmaOrcamentoGetSet.Orcamento.Atendimento.Pessoa.Id_Pessoa);
            TbxNome.Text = PessoaGetSet.Nome;
            TbxSobrenome.Text = PessoaGetSet.Sobrenome;
            TbxCPF.Text = PessoaGetSet.CPF;
            TbxDtNasc.Text = PessoaGetSet.Data_Nasc.ToShortDateString();
            TbxEmail.Text = PessoaGetSet.Email;

            CamposEndereco(0, true);
        }
        private void CamposEndereco(int index, bool atualiza)
        {
            EnderecoNegocios enderecoNegocios = new EnderecoNegocios();
            EnderecoGetSet = enderecoNegocios.ConsultarPorIdPessoa(PessoaGetSet.Id_Pessoa);
            if (atualiza)
            {
                CarregaComboBox();
            }
            TbxRua.Text = EnderecoGetSet[index].Logradouro;
            TbxRuaNum.Text = EnderecoGetSet[index].Numero.ToString();
            TbxCompl.Text = EnderecoGetSet[index].Complemento;
            TbxCidade.Text = EnderecoGetSet[index].Cidade;
            TbxEstado.Text = EnderecoGetSet[index].UF;
            TbxCep.Text = EnderecoGetSet[index].CEP;

            CamposCursoTurma();
        }
        private void CarregaComboBox()
        {
            CbxEnd.DataSource = null;
            CbxEnd.DataSource = EnderecoGetSet;
            CbxEnd.DisplayMember = "ID_ENDERECO";
            CbxEnd.ValueMember = "ID_ENDERECO";
        }
        private void CamposCursoTurma()
        {
            LblIdOrc.Text = TurmaOrcamentoGetSet.Orcamento.Id_Orcamento.ToString();
            TbxCurso.Text = TurmaOrcamentoGetSet.Turma.Curso.Nome;
            TbxLaboratorio.Text = TurmaOrcamentoGetSet.Turma.Laboratorio.Nome;
            TbxTurma.Text = TurmaOrcamentoGetSet.Turma.Nome_Turma;
            TbxProfessor.Text = TurmaOrcamentoGetSet.Turma.ProfessorMinistra.Professor.Funcionario.Pessoa.Nome + "" + TurmaOrcamentoGetSet.Turma.ProfessorMinistra.Professor.Funcionario.Pessoa.Sobrenome;
            TbxDtInicio.Text = TurmaOrcamentoGetSet.Turma.Data_Inicio.ToShortDateString();
            TbxDtFim.Text = TurmaOrcamentoGetSet.Turma.Data_Fim.ToShortDateString();
            TbxHoraInicio.Text = TurmaOrcamentoGetSet.Turma.Hora_Inicio.ToShortTimeString();
            TbxHoraFim.Text = TurmaOrcamentoGetSet.Turma.Hora_Fim.ToShortTimeString();
            ChSeg.Checked = TurmaOrcamentoGetSet.Turma.Segunda_Aula;
            ChTerca.Checked = TurmaOrcamentoGetSet.Turma.Terca_Aula;
            ChQuarta.Checked = TurmaOrcamentoGetSet.Turma.Quarta_Aula;
            ChQuinta.Checked = TurmaOrcamentoGetSet.Turma.Quinta_Aula;
            ChSexta.Checked = TurmaOrcamentoGetSet.Turma.Sexta_Aula;
            ChSabado.Checked = TurmaOrcamentoGetSet.Turma.Sabado_Aula;

            CamposPromocao();
        }
        private void CamposPromocao()
        {
            TbxPromocao.Text = TurmaOrcamentoGetSet.PromocaoValor.Nome_Promocao;
            TbxQtdParcelas.Text = TurmaOrcamentoGetSet.Turma.Curso.Qtde_Parcelas.ToString();

            BtnEfetivar.Enabled = true;
        }

        //----------------------Metodos Componentes-----------------------------
        private void CbxEnd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbxEnd.SelectedValue != null)
            {
                if (CbxEnd.SelectedValue.ToString() != "ObjetoTransferencia.Endereco")
                {
                    CamposEndereco(CbxEnd.SelectedIndex, false);
                }
            }
        }


        //---------------------------DataGrid-------------------------------------
        private void CarregarDatagrid(int idMatricula)
        {
            ContasReceberNegocios contasReceberNegocios = new ContasReceberNegocios();
            ContasReceberGetSet = contasReceberNegocios.ConsultarPorIdMatricula(idMatricula);

            dataGrid.DataSource = null;
            dataGrid.DataSource = ContasReceberGetSet;
            dataGrid.AutoGenerateColumns = false;
            dataGrid.AllowUserToResizeColumns = false;
            dataGrid.AllowUserToResizeRows = false;
            dataGrid.ColumnHeadersHeight = 30;
            dataGrid.RowHeadersWidth = 30;
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
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


        //---------------------------Timers-------------------------------------
        private void TimerDatagrid_Tick(object sender, EventArgs e)
        {
            if (AtualizaDatagrid == true)
            {
                CamposPessoa();
                TimerDatagrid.Stop();
            }
            if (DesabilitaTimer == true)
            {
                TimerDatagrid.Stop();
            }
        }

        private void BtnEfetivar_Click(object sender, EventArgs e)
        {
            Matricula matricula = new Matricula();
            MatriculaNegocios matriculaNegocios = new MatriculaNegocios();
            try
            {
                Aluno aluno = new Aluno
                {
                    Pessoa = PessoaGetSet
                };
                matricula.Aluno = aluno;
                matricula.Turma = TurmaOrcamentoGetSet.Turma;
                matricula.PromocaoValor = TurmaOrcamentoGetSet.PromocaoValor;
                matricula.Usuario = LoginNegocios.UsuarioLogadoGetSet;

            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao carregar campos. Verifique os campos na tela");
            }

            string retorno = matriculaNegocios.Inserir(matricula);

            try
            {
                int idMatricula = Convert.ToInt32(retorno);
                MatriculaGetSet = matriculaNegocios.ConsultarPorId(idMatricula)[0];
                LblIdAluno.Text = MatriculaGetSet.Aluno.Id_Aluno.ToString();
                LblEfetiva.Text = "Matrícula Efetivada";
                CarregarDatagrid(idMatricula);
                MessageBox.Show("Matricula efetivada com sucesso!");
            }
            catch (Exception)
            {
                MessageBox.Show("Erro: Detalhes: " + retorno);
            }
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            ClearTextBoxes(this.Controls);
            CbxEnd.DataSource = null;
            CbxEnd.Update();
            CbxEnd.Refresh();
            PessoaGetSet = null;
            OrcamentoGetSet = null;
            TurmaOrcamentoGetSet = null;
            EnderecoGetSet = null;
            ContasReceberGetSet = null;
            MatriculaGetSet = null;
            LblEfetiva.Text = "Matrícula não efetivada.";

        }

        private void ClearTextBoxes(Control.ControlCollection ctrlCollection)
        {
            foreach (Control ctrl in ctrlCollection)
            {
                if (ctrl is TextBoxBase)
                {
                    ctrl.Text = String.Empty;
                }
                else
                {
                    ClearTextBoxes(ctrl.Controls);
                }
            }
        }
    }
}
