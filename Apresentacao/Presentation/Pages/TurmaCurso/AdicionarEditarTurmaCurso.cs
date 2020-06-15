using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjetoTransferencia;
using Negocios;
using KimtToo.VisualReactive;
using Apresentacao.Presentation.Popup.SearchDialogs;
using Apresentacao.Presentation.Popup.Tipos;
using System.Reflection;
using System.Windows.Documents;
using System.Globalization;

namespace Apresentacao.Presentation.Pages
{
    public partial class AdicionarEditarTurmaCurso : UserControl
    {
        public AdicionarEditarTurmaCurso()
        {
            if (Program.IsInDesignMode()) return;
            InitializeComponent();
        }


        //-----------     Variáveis e Instancias de Objetos---------------------
        public static Curso CursoGetSet { get; set; }
        public static Turma TurmaGetSet { get; set; }
        public static bool atualizarCampos = false;
        public static bool atualizarCamposTurma = false;
        readonly MetodosNegocios metodosNegocios = new MetodosNegocios();


        //---------------Load (Carrega ao iniciar formulário)-------------------
        private void AdicionarEditarTurmaCurso_Load(object sender, EventArgs e)
        {
            CarregaComboBoxProfessorMinistra(1);
            CarregaComboBoxTipoCurso();
            CarregaComboBoxLaboratorio();
            CarregaComboBoxCurso();

            CbxProfessor.Enabled = false;
        }


        //------------------------Métodos botões--------------------------------
        //-------------Curso
        private void BtnSearchCurso_Click(object sender, EventArgs e)
        {
            new Popup.transparentBg(new Popup.SearchDialogs.SearchDialog_Curso());

            PreencheCurso.Enabled = true;
        }
        private void BtnSalvarCurso_Click(object sender, EventArgs e)
        {
            CursoNegocios cursoNegocios = new CursoNegocios();
            Curso curso = new Curso();
            try
            {
                curso.TipoCurso = (TipoCurso)CbxTipoCurso.SelectedItem;
                curso.Nome = VerificaCampoDigitado(TbxNomeCurso.Text, "Nome");
                string qtdeAulas = VerificaCampoDigitado(TbxQtdAulas.Text, "Qtde de Aulas");
                curso.Qtde_Aulas = Convert.ToInt16(qtdeAulas);
                string qtdeAulasSemana = VerificaCampoDigitado(TbxAulasSem.Text, "Aulas Semana");
                curso.Qtde_Aulas_Semana = Convert.ToInt16(qtdeAulasSemana);
                string durMeses = VerificaCampoDigitado(TbxDurMes.Text, "Duração Meses");
                curso.Duracao_Meses = Convert.ToInt16(durMeses);
                string cargaHoraria = VerificaCampoDigitado(TbxCargHor.Text, "Carga Horária");
                curso.Carga_Horaria = Convert.ToInt16(cargaHoraria);
                string horasAula = VerificaCampoDigitado(TbxHorasAula.Text, "Horas p/ Aula");
                curso.Horas_Por_Aula = Convert.ToInt16(horasAula);
                string qtdeParc = VerificaCampoDigitado(TbxParcelasCurso.Text, "Parcelas");
                curso.Qtde_Parcelas = Convert.ToInt16(qtdeParc);
                string valorTotal = VerificaCampoDigitado(TbxValorTotal.Text, "Valor Total");
                curso.Valor_Total = Convert.ToDecimal(valorTotal);
                curso.Usuario = LoginNegocios.UsuarioLogadoGetSet;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            string idCurso = cursoNegocios.Inserir(curso);

            try
            {
                int retorno = Convert.ToInt32(idCurso);
                CursoGetSet = null;
                CursoGetSet = cursoNegocios.ConsultarPorId(retorno)[0];
                MessageBox.Show("Curso inserido com sucesso!");
                CarregaCamposCurso();
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao inserir curso. Detalhes: " + idCurso);
            }
        }
        private void BtnTipoCurso_Click(object sender, EventArgs e)
        {
            Frm_TpCurso frm_TpCurso = new Frm_TpCurso();
            DialogResult dr = frm_TpCurso.ShowDialog();

            if (dr == DialogResult.OK)
            {
                CarregaComboBoxTipoCurso();
            }
        }
        private void BtnTipoLaboratorio_Click(object sender, EventArgs e)
        {
            Frm_TpLab frm_TpLab = new Frm_TpLab();
            DialogResult dr = frm_TpLab.ShowDialog();

            if (dr == DialogResult.OK)
            {
                CarregaComboBoxLaboratorio();
            }
        }
        private void BtnLaboratorio_Click(object sender, EventArgs e)
        {
            Popup.Tipos.Frm_Lab frm_Lab = new Popup.Tipos.Frm_Lab();
            DialogResult dr = frm_Lab.ShowDialog();

            if (dr == DialogResult.OK)
            {
                CarregaComboBoxLaboratorio();
            }
        }
        private void BtnAtualizarCurso_Click(object sender, EventArgs e)
        {
            CursoNegocios cursoNegocios = new CursoNegocios();
            Curso curso = new Curso();
            try
            {
                if (TbxIdCurso.Text == "")
                {
                    throw new Exception("Nenhum cadastro de curso selecionado, verifique!");
                }
                curso.Id_Curso = Convert.ToInt32(TbxIdCurso.Text);
                curso.TipoCurso = (TipoCurso)CbxTipoCurso.SelectedItem;
                curso.Nome = VerificaCampoDigitado(TbxNomeCurso.Text, "Nome");
                string qtdeAulas = VerificaCampoDigitado(TbxQtdAulas.Text, "Qtde de Aulas");
                curso.Qtde_Aulas = Convert.ToInt16(qtdeAulas);
                string qtdeAulasSemana = VerificaCampoDigitado(TbxAulasSem.Text, "Aulas Semana");
                curso.Qtde_Aulas_Semana = Convert.ToInt16(qtdeAulasSemana);
                string durMeses = VerificaCampoDigitado(TbxDurMes.Text, "Duração Meses");
                curso.Duracao_Meses = Convert.ToInt16(durMeses);
                string cargaHoraria = VerificaCampoDigitado(TbxCargHor.Text, "Carga Horária");
                curso.Carga_Horaria = Convert.ToInt16(cargaHoraria);
                string horasAula = VerificaCampoDigitado(TbxHorasAula.Text, "Horas p/ Aula");
                curso.Horas_Por_Aula = Convert.ToInt16(horasAula);
                string qtdeParc = VerificaCampoDigitado(TbxParcelasCurso.Text, "Parcelas");
                curso.Qtde_Parcelas = Convert.ToInt16(qtdeParc);
                string valorTotal = VerificaCampoDigitado(TbxValorTotal.Text, "Valor Total");
                curso.Valor_Total = Convert.ToDecimal(valorTotal);
                curso.Usuario = LoginNegocios.UsuarioLogadoGetSet;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            string idCurso = cursoNegocios.AtualizarporId(curso);

            try
            {
                int retorno = Convert.ToInt32(idCurso);
                CursoGetSet = null;
                CursoGetSet = cursoNegocios.ConsultarPorId(retorno)[0];
                MessageBox.Show("Curso atualizado com sucesso!");
                CarregaCamposCurso();
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao atualizar curso. Detalhes: " + idCurso);
            }
        }
        private void BtnExcluirCurso_Click(object sender, EventArgs e)
        {
            CursoNegocios cursoNegocios = new CursoNegocios();
            if (TbxIdCurso.Text == "")
            {
                MessageBox.Show("Nenhum curso selecionado.");
                return;
            }
            DialogResult resultado = MessageBox.Show("Tem certeza?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.No)
            {
                return;
            }
            Curso curso = new Curso();
            curso.Usuario = LoginNegocios.UsuarioLogadoGetSet;
            curso.Id_Curso = Convert.ToInt32(TbxIdCurso.Text);
            string retorno = cursoNegocios.Excluir(curso);

            try
            {
                int idCurso = Convert.ToInt32(retorno);
                MessageBox.Show("Excluído com sucesso!", "Confirmado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCamposCurso();
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao excluir. Detalhes: " + retorno);
            }
        }
        //-------------Turma
        private void BtnSearchTurma_Click(object sender, EventArgs e)
        {
            new Popup.transparentBg(new Popup.SearchDialogs.SearchDialog_Turma());

            PreencheTurma.Enabled = true;
        }

        //-------------------------Métodos personalizados----------------------------------
        private void CarregaComboBox(ComboBox comboBox, Object obj, string DisplayMember, string ValueMember)
        {
            comboBox.DataSource = null;
            comboBox.DataSource = obj;
            comboBox.DisplayMember = DisplayMember;
            comboBox.ValueMember = ValueMember;
            comboBox.Update();
            comboBox.Refresh();
        }
        private void VerificaSeNumeroDigitado(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                MessageBox.Show("este campo aceita somente numero");
            }
        }
        private void VerificaSeDecimalDigitado(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("este campo aceita somente numero");
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


        //------------Curso
        private void CarregaComboBoxTipoCurso()
        {
            TipoCursoNegocios tipoCursoNegocios = new TipoCursoNegocios();
            TipoCursoColecao tipoCursoColecao = tipoCursoNegocios.ConsultarPorNome("");

            CbxTipoCurso.DataSource = null;
            CbxTipoCurso.DataSource = tipoCursoColecao;
            CbxTipoCurso.DisplayMember = "Nome";
            CbxTipoCurso.ValueMember = "Id_Tipo_Curso";
            CbxTipoCurso.Update();
            CbxTipoCurso.Refresh();
        }
        private void CarregaCamposCurso()
        {
            TbxIdCurso.Text = CursoGetSet.Id_Curso.ToString();
            TbxDtCadCurso.Text = CursoGetSet.Data_Cadastro.ToShortDateString();
            TbxDtUltCurso.Text = CursoGetSet.Data_Ultima_Alteracao.ToShortDateString();
            TbxNomeCurso.Text = CursoGetSet.Nome;
            TbxQtdAulas.Text = CursoGetSet.Qtde_Aulas.ToString();
            TbxAulasSem.Text = CursoGetSet.Qtde_Aulas_Semana.ToString();
            TbxDurMes.Text = CursoGetSet.Duracao_Meses.ToString();
            TbxCargHor.Text = CursoGetSet.Carga_Horaria.ToString();
            TbxHorasAula.Text = CursoGetSet.Horas_Por_Aula.ToString();
            TbxParcelasCurso.Text = CursoGetSet.Qtde_Parcelas.ToString();
            TbxValorTotal.Text = CursoGetSet.Valor_Total.ToString();
            ChkBoxApostila.Checked = CursoGetSet.Apostila;

            TipoCursoNegocios tipoCursoNegocios = new TipoCursoNegocios();
            TipoCursoColecao tipoCursoBuscado = tipoCursoNegocios.ConsultarPorId(CursoGetSet.TipoCurso.Id_Tipo_Curso);
            CbxTipoCurso.DataSource = null;
            CbxTipoCurso.DataSource = tipoCursoBuscado;
            CbxTipoCurso.DisplayMember = "Nome";
            CbxTipoCurso.ValueMember = "Id_Tipo_Curso";
            CbxTipoCurso.Update();
            CbxTipoCurso.Refresh();
        }
        private void LimparCamposCurso()
        {
            metodosNegocios.LimpaTextBox(panel2.Controls);

            CursoGetSet = new Curso();
            CarregaComboBoxTipoCurso();
            CbxTipoCurso.SelectedIndex = -1;
        }

        //----------Turma
        private void CarregaComboBoxCurso()
        {
            CursoNegocios cursoNegocios = new CursoNegocios();
            CursoColecao cursoColecao = cursoNegocios.ConsultarPorNome("");

            CbxCurso.DataSource = null;
            CbxCurso.DataSource = cursoColecao;
            CbxCurso.DisplayMember = "Nome";
            CbxCurso.ValueMember = "Id_Curso";
            CbxCurso.Update();
            CbxCurso.Refresh();
        }
        private void CarregaComboBoxLaboratorio()
        {
            LaboratorioNegocios laboratorioNegocios = new LaboratorioNegocios();
            LaboratorioColecao laboratorioColecao = laboratorioNegocios.ConsultarPorNome("");

            CbxLaboratorio.DataSource = null;
            CbxLaboratorio.DataSource = laboratorioColecao;
            CbxLaboratorio.DisplayMember = "Nome";
            CbxLaboratorio.ValueMember = "Id_Laboratorio";
            CbxLaboratorio.Update();
            CbxLaboratorio.Refresh();
        }
        private void CarregaComboBoxProfessorMinistra(int idCurso)
        {
            ProfessorNegocios professorNegocios = new ProfessorNegocios();
            ProfessorMinistraColecao professorMinistraColecao = professorNegocios.ConsultarMInistraPorCurso(idCurso);

            CbxProfessor.DataSource = null;
            CbxProfessor.DataSource = professorMinistraColecao;
            CbxProfessor.DisplayMember = "Nome";
            CbxProfessor.ValueMember = "Id_Professor_Ministra";
            CbxProfessor.Update();
            CbxProfessor.Refresh();
        }
        private void CarregaCamposTurma()
        {
            TbxIdTurma.Text = TurmaGetSet.Id_Turma.ToString();
            TbxDtDataCadastroTurma.Text = TurmaGetSet.Data_Cadastro.ToShortDateString();
            TbxDtUltAltTurma.Text = TurmaGetSet.Data_Ultima_Alteracao.ToShortDateString();
            TbxNomeTurma.Text = TurmaGetSet.Nome_Turma;
            TbxFeriados.Text = TurmaGetSet.Qtde_Feriado.ToString();
            TbxVagas.Text = TurmaGetSet.Vagas_Disponiveis.ToString();
            TbxDataInicio.Text = TurmaGetSet.Data_Inicio.ToShortDateString();
            TbxDataFim.Text = TurmaGetSet.Data_Fim.ToShortDateString();
            TbxHoraInicio.Text = TurmaGetSet.Hora_Inicio.ToString();
            TbxHoraFim.Text = TurmaGetSet.Hora_Fim.ToString();
            ChkBoxSegunda.Checked = TurmaGetSet.Segunda_Aula;
            ChkBoxTerca.Checked = TurmaGetSet.Terca_Aula;
            ChkBoxQuarta.Checked = TurmaGetSet.Quarta_Aula;
            ChkBoxQuinta.Checked = TurmaGetSet.Quinta_Aula;
            ChkBoxSexta.Checked = TurmaGetSet.Sexta_Aula;
            ChkBoxSabado.Checked = TurmaGetSet.Sabado_Aula;
            ChkBoxDomingo.Checked = TurmaGetSet.Domingo_Aula;

            CursoNegocios cursoNegocios = new CursoNegocios();
            CursoColecao cursoColecao = cursoNegocios.ConsultarPorId(TurmaGetSet.Curso.Id_Curso);
            CarregaComboBox(CbxCurso, cursoColecao, "Nome", "Id_Curso");

            ProfessorNegocios professorNegocios = new ProfessorNegocios();
            ProfessorMinistraColecao professorColecao = professorNegocios.ConsultarMinistraPorId(TurmaGetSet.ProfessorMinistra.Id_Professor_Ministra);
            CarregaComboBox(CbxProfessor, professorColecao, "Nome", "Id_Professor_Ministra");

            LaboratorioNegocios laboratorioNegocios = new LaboratorioNegocios();
            LaboratorioColecao laboratorioColecao = laboratorioNegocios.ConsultarPorId(TurmaGetSet.Laboratorio.Id_Laboratorio);
            CarregaComboBox(CbxLaboratorio, laboratorioColecao, "Nome", "Id_Laboratorio");
        }
        private void LimparCamposTurma()
        {
            metodosNegocios.MarcaChkBox(panel1.Controls);
            metodosNegocios.LimpaTextBox(panel1.Controls);

            TurmaGetSet = new Turma();
            CarregaComboBoxLaboratorio();
            CbxLaboratorio.SelectedIndex = -1;

            CarregaComboBoxCurso();
            CbxCurso.SelectedIndex = -1;          
        }


        //----------------------Eventos Componentes-----------------------------

        private void CbxProfessor_Format(object sender, ListControlConvertEventArgs e)
        {
            if (CbxProfessor.DisplayMember.Contains("."))
            {

            }
        }      
        private void CbxTipoCurso_Click(object sender, EventArgs e)
        {
            CarregaComboBoxTipoCurso();
        }
        private void TbxValorTotal_TextChange(object sender, EventArgs e)
        {
            decimal d;
            if (decimal.TryParse(TbxValorTotal.Text, out d))
            {
                //valid 
            }
            else
            {
                //invalid
                MessageBox.Show("Por favor, insira um valor válido!");
                return;
            }
        }
        private void CbxCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbxCurso.SelectedValue != null)
            {
                if (CbxCurso.SelectedValue.GetType() != typeof(Curso))
                {
                    CarregaComboBoxProfessorMinistra((int)CbxCurso.SelectedValue);
                    CbxProfessor.Enabled = true;
                }
            }      
        }


        //----------------------Timers-----------------------------
        private void PreencheTurma_Tick(object sender, EventArgs e)
        {
            if (atualizarCamposTurma == true)
            {
                CarregaCamposTurma();
                PreencheTurma.Enabled = false;
                atualizarCamposTurma = false;
            }
        }
        private void PreencheCurso_Tick(object sender, EventArgs e)
        {
            if (atualizarCampos == true)
            {
                CarregaCamposCurso();
                PreencheCurso.Enabled = false;
                atualizarCampos = false;
            }
        }
        private Turma CarregaTurma()
        {
            Turma turma = new Turma();
            try
            {
                if (TbxIdTurma.Text != "")
                {
                    turma.Id_Turma = Convert.ToInt32(TbxIdTurma.Text);
                }
                turma.Curso = (Curso)CbxCurso.SelectedItem;
                turma.Laboratorio = (Laboratorio)CbxLaboratorio.SelectedItem;
                turma.ProfessorMinistra = (ProfessorMinistra)CbxProfessor.SelectedItem;
                string vagas = VerificaCampoDigitado(TbxVagas.Text, "Vagas");
                turma.Vagas_Disponiveis = Convert.ToInt16(vagas);
                turma.Nome_Turma = VerificaCampoDigitado(TbxNomeTurma.Text, "Nome Turma");
                string datainicio = VerificaCampoDigitado(TbxDataInicio.Text, "Data Início");
                turma.Data_Inicio = Convert.ToDateTime(datainicio);
                string datafim = VerificaCampoDigitado(TbxDataFim.Text, "Data Fim");
                turma.Data_Fim = Convert.ToDateTime(datafim);
                if (metodosNegocios.ValidaTime(TbxHoraInicio.Text) || TbxHoraInicio.Text != "")
                {
                    TimeSpan horainicio = new TimeSpan();
                    bool hora = TimeSpan.TryParseExact(TbxHoraInicio.Text, "hh\\:mm", CultureInfo.CurrentCulture, TimeSpanStyles.None, out horainicio);
                    if (hora)
                    {
                        turma.Hora_Inicio = horainicio;
                    }
                }
                if (metodosNegocios.ValidaTime(TbxHoraFim.Text) || TbxHoraFim.Text != "")
                {
                    TimeSpan horafim = new TimeSpan();
                    bool hora = TimeSpan.TryParseExact(TbxHoraFim.Text, "hh\\:mm", CultureInfo.CurrentCulture, TimeSpanStyles.None, out horafim);
                    if (hora)
                    {
                        turma.Hora_Fim = horafim;
                    }
                }
                turma.Segunda_Aula = ChkBoxSegunda.Checked;
                turma.Terca_Aula = ChkBoxTerca.Checked;
                turma.Quarta_Aula = ChkBoxQuarta.Checked;
                turma.Quinta_Aula = ChkBoxQuinta.Checked;
                turma.Sexta_Aula = ChkBoxSexta.Checked;
                turma.Sabado_Aula = ChkBoxSabado.Checked;
                turma.Domingo_Aula = ChkBoxDomingo.Checked;
                turma.Usuario = LoginNegocios.UsuarioLogadoGetSet;

                return turma;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                turma = null;
                return turma;
            }
        }
        private void BtnSalvarTurma_Click(object sender, EventArgs e)
        {
            TurmaNegocios turmaNegocios = new TurmaNegocios();
            Turma turma = CarregaTurma();
            

            string idTurma = turmaNegocios.Inserir(turma);

            try
            {
                int retorno = Convert.ToInt32(idTurma);
                TurmaGetSet = null;
                TurmaGetSet = turmaNegocios.ConsultarPorId(retorno)[0];
                MessageBox.Show("Turma inserida com sucesso!");
                CarregaCamposTurma();
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao inserir turma. Detalhes: " + idTurma);
            }
        }
        private void TbxHoraInicio_Leave(object sender, EventArgs e)
        {
            if (!(metodosNegocios.ValidaTime(TbxHoraInicio.Text)))
            {
                MessageBox.Show("Hora inválida!");
            }
        }
        private void TbxHoraFim_Leave(object sender, EventArgs e)
        {
            if (!(metodosNegocios.ValidaTime(TbxHoraFim.Text)))
            {
                MessageBox.Show("Hora inválida!");
            }
        }
        private void BtnNovoTurma_Click(object sender, EventArgs e)
        {
            LimparCamposTurma();
        }
        private void BtnAtualizarTurma_Click(object sender, EventArgs e)
        {
            TurmaNegocios turmaNegocios = new TurmaNegocios();
            Turma turma = CarregaTurma();

            string retorno = turmaNegocios.AtualizarporId(turma);

            try
            {
                int idTurma = Convert.ToInt32(retorno);
                TurmaGetSet = null;
                TurmaGetSet = turmaNegocios.ConsultarPorId(idTurma)[0];
                MessageBox.Show("Turma atualizada com sucesso!");
                CarregaCamposTurma();
            }   
            catch (Exception)
            {
                MessageBox.Show("Erro ao atualizar turma. Detalhes: " + retorno);
            }
        }
        private void ClickComboBox(object sender, EventArgs e)
        {
            if (((ComboBox)sender).Name == "CbxCurso")
            {
                CursoNegocios cursoNegocios = new CursoNegocios();
                CursoColecao cursos = cursoNegocios.ConsultarPorNome("");
                CarregaComboBox(CbxCurso, cursos, "Nome", "Id_Curso");
            }
            if (((ComboBox)sender).Name == "CbxLaboratorio")
            {
                LaboratorioNegocios laboratorioNegocios = new LaboratorioNegocios();
                LaboratorioColecao laboratorios = laboratorioNegocios.ConsultarPorNome("");
                CarregaComboBox(CbxLaboratorio, laboratorios, "Nome", "Id_Laboratorio");
            }
        }

        private void CbxProfessor_Click(object sender, EventArgs e)
        {

        }
    }
}
