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
using Utilities.BunifuButton.Transitions;

namespace Apresentacao.Presentation.Pages
{
    public partial class AdicionarEditarProfessor : UserControl
    {
        public AdicionarEditarProfessor()
        {
            if (Program.IsInDesignMode()) return;
            InitializeComponent();

            BtnSearchMinistra.Enabled = false;
            BtnSalvarProfessor.Enabled = false;
            BtnExcluirProfessor.Enabled = false;
            BtnSalvarMinistra.Enabled = false;
            BtnAtualizarMinistra.Enabled = false;
            BtnExcluirMinistra.Enabled = false;
        }


        //-----------     Variáveis e Instancias de Objetos---------------------
        public static Professor ProfessorGetSet { get; set; }
        public static Funcionario FuncionarioGetSet { get; set; }
        public static ProfessorMinistra MinistraGetSet { get; set; }
        public static bool atualizarCamposProfessor = false;
        public static bool atualizarCamposProfessorMinistra = false;
        public static bool atualizarCamposFuncinario = false;
        readonly MetodosNegocios metodosNegocios = new MetodosNegocios();
        ProfessorNegocios professorNegocios = new ProfessorNegocios();


        //---------------Load (Carrega ao iniciar formulário)-------------------
        private void AdicionarEditarProfessor_Load(object sender, EventArgs e)
        {

        }


        //------------------------Métodos botões--------------------------------
        //-------------Professor
        private void BtnSearchProfessor_Click(object sender, EventArgs e)
        {
            new Popup.transparentBg(new Popup.SearchDialogs.SearchDialog_Professor());

            PreencheProfessor.Enabled = true;
        }


        //-------------Professor Ministra
        private void BtnSearchMinistra_Click(object sender, EventArgs e)
        {
            new Popup.transparentBg(new Popup.SearchDialogs.SearchDialog_ProfessorMinistra(Convert.ToInt32(TbxIdFuncionario.Text)));

            PreencheProfMinistra.Enabled = true;
        }


        //-------------Funcionario
        private void BtnSearchFuncionario_Click(object sender, EventArgs e)
        {
            new Popup.transparentBg(new Popup.SearchDialogs.SearchDialog_Professor_Funcionario());
            //ProfessorGetSet = new Professor();
            //FuncionarioGetSet = new Funcionario();

            PreencheFuncionario.Enabled = true;
        }

        //-------------------------Métodos personalizados----------------------------------
        private void limparTela()
        {
            metodosNegocios.LimpaTextBox(this.Controls);
        }
        //------------Professor
        private void CarregaCamposProfessor()
        {
            if (ProfessorGetSet != null)
            {
                if (ProfessorGetSet.Id_Professor > 0)
                {
                    limparTela();
                    TbxIdProfessor.Text = ProfessorGetSet.Id_Professor.ToString();
                    TbxIdFuncionario.Text = ProfessorGetSet.Funcionario.Id_Funcionario.ToString();
                    TbxNomeProfessor.Text = ProfessorGetSet.Funcionario.Pessoa.Nome;
                    TbxSobrenomeProfessor.Text = ProfessorGetSet.Funcionario.Pessoa.Sobrenome;
                    TbxDtCadastroProfessor.Text = ProfessorGetSet.Data_Cadastro.ToShortDateString();
                    TbxDtAdmissao.Text = ProfessorGetSet.Funcionario.Data_Admissao.ToShortDateString();
                    TbxEntrada.Text = ProfessorGetSet.Funcionario.Hora_Entrada.ToString();
                    TbxSaida.Text = ProfessorGetSet.Funcionario.Hora_Saida.ToString();

                    TbxIdProfMinistra.Text = ProfessorGetSet.Id_Professor.ToString();
                    TbxNomeMinistra.Text = ProfessorGetSet.Funcionario.Pessoa.Nome;
                    TbxSobrenomeMinistra.Text = ProfessorGetSet.Funcionario.Pessoa.Sobrenome;
                    CarregaComboBoxCurso();
                    BtnSalvarProfessor.Enabled = false;
                    BtnExcluirProfessor.Enabled = true;
                    BtnSalvarMinistra.Enabled = true;
                    BtnAtualizarMinistra.Enabled = false;
                    BtnExcluirMinistra.Enabled = false;
                }
                else
                {
                    limparTela();
                }
            }      
        }


        //------------Ministra
        private void CarregaCamposMinistra()
        {
            if (MinistraGetSet != null)
            {
                if (MinistraGetSet.Id_Professor_Ministra > 0)
                {
                    limparTela();
                    ProfessorGetSet = professorNegocios.ConsultaPorId(MinistraGetSet.Professor.Id_Professor)[0];
                    CarregaCamposProfessor();
                    if (MinistraGetSet.Id_Professor_Ministra > 0)
                    {
                        TbxIdMinistra.Text = MinistraGetSet.Id_Professor_Ministra.ToString();
                        TbxDtCadastroMinistra.Text = MinistraGetSet.Data_Cadastro.ToShortDateString();

                        CursoNegocios cursoNegocios = new CursoNegocios();
                        CursoColecao cursoColecao = cursoNegocios.ConsultarPorId(MinistraGetSet.Curso.Id_Curso);

                        CbxCurso.DataSource = null;
                        CbxCurso.DataSource = cursoColecao;
                        CbxCurso.DisplayMember = "Nome";
                        CbxCurso.ValueMember = "Id_Curso";
                        CbxCurso.Update();
                        CbxCurso.Refresh();

                        BtnAtualizarMinistra.Enabled = true;
                        BtnExcluirMinistra.Enabled = true;
                        BtnSalvarMinistra.Enabled = false;
                    }
                }
            }             
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
            CbxCurso.SelectedIndex = -1;
        }


        //------------Funcionario
        private void CarregaCamposFuncionario()
        {
            if (FuncionarioGetSet != null)
            {
                if (FuncionarioGetSet.Id_Funcionario > 0)
                {
                    limparTela();
                    ProfessorColecao professores = professorNegocios.ConsultaPorIdFuncionario(FuncionarioGetSet.Id_Funcionario);
                    if (professores.Count > 0)
                    {
                        ProfessorGetSet = professores[0];
                        CarregaCamposProfessor();
                        BtnSearchMinistra.Enabled = true;
                        BtnSalvarProfessor.Enabled = false;
                        BtnExcluirProfessor.Enabled = true;
                    }
                    else
                    {
                        TbxIdFuncionario.Text = FuncionarioGetSet.Id_Funcionario.ToString();
                        TbxNomeProfessor.Text = FuncionarioGetSet.Pessoa.Nome;
                        TbxSobrenomeProfessor.Text = FuncionarioGetSet.Pessoa.Sobrenome;
                        TbxDtAdmissao.Text = FuncionarioGetSet.Data_Admissao.ToShortDateString();
                        TbxEntrada.Text = FuncionarioGetSet.Hora_Entrada.ToString();
                        TbxSaida.Text = FuncionarioGetSet.Hora_Saida.ToString();
                        BtnSearchMinistra.Enabled = false;
                        BtnSalvarProfessor.Enabled = true;
                        BtnExcluirProfessor.Enabled = false;
                    }
                }
                else
                {
                    limparTela();
                }
            }    
        }


        //----------------------Eventos Componentes-----------------------------    
        private void CbxCurso_Click(object sender, EventArgs e)
        {
            CarregaComboBoxCurso();
        }


        //----------------------Timers-----------------------------
        private void PreencheProfessor_Tick(object sender, EventArgs e)
        {
            if (atualizarCamposProfessor == true)
            {
                CarregaCamposProfessor();
                PreencheProfessor.Enabled = false;
                if (ProfessorGetSet.Id_Professor > 0)
                {
                    BtnSearchMinistra.Enabled = true;
                }
            }
        }
        private void PreencheProfMinistra_Tick(object sender, EventArgs e)
        {
            if (atualizarCamposProfessorMinistra == true)
            {
                CarregaCamposMinistra();
                PreencheProfMinistra.Enabled = false;
            }
        }
        private void PreencheFuncionario_Tick(object sender, EventArgs e)
        {
            if (atualizarCamposFuncinario == true)
            {
                CarregaCamposFuncionario();
                PreencheFuncionario.Enabled = false;
                
            }
        }

        private void BtnSalvarProfessor_Click(object sender, EventArgs e)
        {
            Professor professor = new Professor();
            professor.Funcionario = new Funcionario();
            professor.Funcionario.Id_Funcionario = Convert.ToInt32(TbxIdFuncionario.Text);
            professor.Usuario = LoginNegocios.UsuarioLogadoGetSet;
            string retorno = professorNegocios.InserirProfessor(professor);
            try
            {
                int idProfessor = Convert.ToInt32(retorno);
                ProfessorGetSet = new Professor();
                ProfessorGetSet = professorNegocios.ConsultaPorId(idProfessor)[0];
                MessageBox.Show("Cadastro professor inserido com sucesso!");
                CarregaCamposProfessor();
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao inserir professor. Destalhes: " + retorno);
            }
        }

        private void BtnExcluirProfessor_Click(object sender, EventArgs e)
        {
            ProfessorGetSet.Usuario = LoginNegocios.UsuarioLogadoGetSet;
            string retorno = professorNegocios.ExcluirProfessor(ProfessorGetSet);
            try
            {
                int idProfessor = Convert.ToInt32(retorno);
                MessageBox.Show("Professor excluído com sucesso!");
                ProfessorGetSet = null;
                FuncionarioGetSet = null;
                MinistraGetSet = null;
                limparTela();
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao excluir professor. Detalhes: " + retorno);
            }
        }

        private void BtnSalvarCurso_Click(object sender, EventArgs e)
        {
            if (CbxCurso.SelectedItem != null)
            {
                ProfessorMinistra professorMinistra = new ProfessorMinistra();
                professorMinistra.Professor = ProfessorGetSet;
                professorMinistra.Curso = new Curso();
                professorMinistra.Usuario = LoginNegocios.UsuarioLogadoGetSet;
                professorMinistra.Curso = (Curso)CbxCurso.SelectedItem;

                string retorno = professorNegocios.InserirProfessorMinistra(professorMinistra);

                try
                {
                    int idMinistra = Convert.ToInt32(retorno);
                    MessageBox.Show("Curso ministrado cadastro com sucesso!");
                    MinistraGetSet = professorNegocios.ConsultarMinistraPorId(idMinistra)[0];
                    CarregaCamposMinistra();
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro ao inserir curso ministrado, verifique!");
                }
            }
            else
            {
                MessageBox.Show("Nenhum curso selecionado, verifique!");
            }
        }

        private void BtnExcluirCurso_Click(object sender, EventArgs e)
        {
            if (TbxIdMinistra.Text != "")
            {
                ProfessorMinistra ministra = new ProfessorMinistra();
                ministra.Usuario = LoginNegocios.UsuarioLogadoGetSet;
                ministra.Id_Professor_Ministra = Convert.ToInt32(TbxIdMinistra.Text);

                string retorno = professorNegocios.ExcluirProfessorMinistra(ministra);

                try
                {
                    int idMinistra = Convert.ToInt32(retorno);
                    MessageBox.Show("Cadastro curso ministrado excluído com sucesso!");
                    limparTela();
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro ao excluir curso ministrado. Detalhes: " + retorno);
                }
            }
            else
            {
                MessageBox.Show("Nenhum curso ministrado selecionado, verifique!");
            }
        }

        private void BtnAtualizarCurso_Click(object sender, EventArgs e)
        {
            if (TbxIdMinistra.Text != "")
            {
                if (CbxCurso.SelectedItem != null)
                {
                    ProfessorMinistra ministra = new ProfessorMinistra();
                    ministra.Usuario = LoginNegocios.UsuarioLogadoGetSet;
                    ministra.Id_Professor_Ministra = Convert.ToInt32(TbxIdMinistra.Text);
                    ministra.Professor = ProfessorGetSet;
                    ministra.Curso = (Curso)CbxCurso.SelectedItem;

                    string retorno = professorNegocios.ExcluirProfessorMinistraAtualizar(ministra);

                    try
                    {
                        int idMinistra = Convert.ToInt32(retorno);
                        MessageBox.Show("Curso ministrado atualizado com sucesso!");
                        MinistraGetSet = null;
                        MinistraGetSet = professorNegocios.ConsultarMinistraPorId(idMinistra)[0];
                        CarregaCamposMinistra();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Erro ao atualizar curso ministrado. Detalhes: " + retorno);
                    }
                }
                else
                {
                    MessageBox.Show("Nenhum curso selecionado, verifique!");
                }
            }
            else
            {
                MessageBox.Show("Nenhum curso ministrado selecionado, verifique!");
            }
        }

        private void BtnNovoMinistra_Click(object sender, EventArgs e)
        {
            MinistraGetSet = new ProfessorMinistra();
            CarregaCamposMinistra();
            TbxIdMinistra.Text = "";
            TbxDtCadastroMinistra.Text = "";
            CarregaComboBoxCurso();
            BtnSalvarMinistra.Enabled = true;
            BtnAtualizarMinistra.Enabled = false;
            BtnExcluirMinistra.Enabled = false;
        }
    }
}
