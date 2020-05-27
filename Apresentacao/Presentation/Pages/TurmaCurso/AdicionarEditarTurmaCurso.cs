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
        private CursoColecao CursoGetSet { get; set; }
        private TurmaColecao TurmaGetSet { get; set; }
        private LaboratorioColecao LaboratorioGetSet { get; set; }
        private TipoCursoColecao TipoCursoGetSet { get; set; }



        //---------------Load (Carrega ao iniciar formulário)-------------------
        private void AdicionarEditarUsuario_Load(object sender, EventArgs e)
        {
            CarregaComboBoxLaboratorio();
            
            toolTip1.SetToolTip(BtnSalvarCurso, "Salvar curso");
            toolTip1.SetToolTip(BtnAtualizarCurso, "Atualizar curso");
            toolTip1.SetToolTip(BtnExcluirCurso, "Excluir curso");
        }


        //------------------------Métodos botões--------------------------------

        private void BtnSearchFuncionario_Click(object sender, EventArgs e)
        {
            new Apresentacao.Presentation.Popup.transparentBg(new Apresentacao.Presentation.Popup.SearchDialogs.SearchDialog_FuncionarioUsuario());
        }    
        private void BtnSearchUsuario_Click(object sender, EventArgs e)
        {
            new Popup.transparentBg(new Popup.SearchDialogs.SearchDialog_Usuario());
        }


        //-------------------------Métodos Void----------------------------------

        private void CarregaComboBoxLaboratorio()
        {
            LaboratorioNegocios laboratorioNegocios = new LaboratorioNegocios();

            LaboratorioGetSet = laboratorioNegocios.ConsultarPorNome("");

            CbxLaboratorio.DataSource = null;
            CbxLaboratorio.DataSource = LaboratorioGetSet;
            CbxLaboratorio.ValueMember = "ID_LABORATORIO";
            CbxLaboratorio.DisplayMember = "NOME";
        }
        private void CarregaComboBoxTipoCurso()
        {
            TipoCursoNegocios tipoCursoNegocios = new TipoCursoNegocios();

            TipoCursoGetSet = tipoCursoNegocios.ConsultarPorNome("");

            CbxTipoCurso.DataSource = null;
            CbxTipoCurso.DataSource = TipoCursoGetSet;
            CbxTipoCurso.ValueMember = "ID_TIPO_CURSO";
            CbxTipoCurso.DisplayMember = "NOME";
        }
        private void CarregaComboBoxCurso()
        {
            CursoNegocios cursoNegocios = new CursoNegocios();

            CursoGetSet = cursoNegocios.ConsultarPorNome("");

            CbxLaboratorio.DataSource = null;
            CbxLaboratorio.DataSource = CursoGetSet;
            CbxLaboratorio.ValueMember = "ID_CURSO";
            CbxLaboratorio.DisplayMember = "NOME";
        }
        private void CarregaComboBoxProfessorMinistra()
        {
            //Professor cursoNegocios = new CursoNegocios();

            //CursoGetSet = cursoNegocios.ConsultarPorNome("");

            //CbxLaboratorio.DataSource = null;
            //CbxLaboratorio.DataSource = CursoGetSet;
            //CbxLaboratorio.ValueMember = "ID_CURSO";
            //CbxLaboratorio.DisplayMember = "NOME";
        }


        //----------------------Metodos Componentes-----------------------------
        private void CbxLaboratorio_Click(object sender, EventArgs e)
        {
            CarregaComboBoxLaboratorio();
        }


        private void BtnInserirTipoCurso_Click(object sender, EventArgs e)
        {
            Frm_TpCurso frm = new Frm_TpCurso();
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {

            }
        }

        private void CbxTipoCurso_Click(object sender, EventArgs e)
        {
            CarregaComboBoxTipoCurso();
        }
    }
}
