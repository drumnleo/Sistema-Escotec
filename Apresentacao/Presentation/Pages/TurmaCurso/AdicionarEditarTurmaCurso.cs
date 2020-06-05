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

        public static bool atualizarCampos = false;



        //---------------Load (Carrega ao iniciar formulário)-------------------
        private void AdicionarEditarUsuario_Load(object sender, EventArgs e)
        {
            CarregaComboBoxProfessorMinistra(1);
            CarregaComboBoxTipoCurso();
            CarregaComboBoxLaboratorio();
            CarregaComboBoxCurso();
        }


        //------------------------Métodos botões--------------------------------




        //-------------------------Métodos Void----------------------------------
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
            ProfessorMinistraColecao professorMinistraColecao = professorNegocios.ConsultarPorCurso(idCurso);

            CbxProfessor.DataSource = null;
            CbxProfessor.DataSource = professorMinistraColecao;
            CbxProfessor.DisplayMember = "Nome";
            CbxProfessor.ValueMember = "Id_Professor_Ministra";
            CbxProfessor.Update();
            CbxProfessor.Refresh();
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
            TbxIdCurso.Text = "";
            TbxDtCadCurso.Text = "";
            TbxDtUltAltTurma.Text = "";
            TbxNomeCurso.Text = "";
            TbxQtdAulas.Text = "";
            TbxAulasSem.Text = "";
            TbxDurMes.Text = "";
            TbxCargHor.Text = "";
            TbxHorasAula.Text = "";
            TbxParcelasCurso.Text = "";
            TbxValorTotal.Text = "";

            CursoGetSet = new Curso();
            CarregaComboBoxTipoCurso();
            CbxTipoCurso.SelectedIndex = -1;
        }


        //----------------------Metodos Componentes-----------------------------

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

        private void CbxProfessor_Format(object sender, ListControlConvertEventArgs e)
        {
            if (CbxProfessor.DisplayMember.Contains("."))
            {

            }
        }

        private void BtnSearchCurso_Click(object sender, EventArgs e)
        {
            new Popup.transparentBg(new Popup.SearchDialogs.SearchDialog_Curso());

            PreencheCurso.Enabled = true;
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

        private void CbxTipoCurso_Click(object sender, EventArgs e)
        {
            CarregaComboBoxTipoCurso();
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
            if ((!char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("este campo aceita somente numero");
            }
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
    }
}
