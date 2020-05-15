using System;
using System.Windows.Forms;
using ObjetoTransferencia;
using Negocios;

namespace Apresentacao.Presentation.Pages
{
    public partial class AdicionarEditarFuncionario : UserControl
    {
        public AdicionarEditarFuncionario()
        {
            if (Program.IsInDesignMode()) return;
            InitializeComponent();

            btnAtualizar.Enabled = false;

            dtAdmissao.Format = DateTimePickerFormat.Custom;
            dtAdmissao.CustomFormat = " ";

            dtDemissao.Format = DateTimePickerFormat.Custom;
            dtDemissao.CustomFormat = " ";
            DateTime hoje = DateTime.Now;
            dtDemissao.Value = hoje.AddDays(1);

            dtDataCadastro.Format = DateTimePickerFormat.Custom;
            dtDataCadastro.CustomFormat = " ";
            dtDataCadastro.Enabled = false;

            dtUltimaAtualizacao.Format = DateTimePickerFormat.Custom;
            dtUltimaAtualizacao.CustomFormat = " ";
            dtUltimaAtualizacao.Enabled = false;

            MostraTbxDt();
            btnSalvar.Enabled = false;
        }

        //-----------     Variáveis e Instancias de Objetos-----------------------
        public static Pessoa PessoaGetSet { get; set; }
        public static Funcionario FuncionarioGetSet { get; set; }
        public static Boolean AtualizarPessoa = false;
        public static Boolean AtualizarFuncionario = false;


        //---------------Load (Carrega ao iniciar formulário)---------------------
        private void AdicionarEditarFuncionario_Load(object sender, EventArgs e)
        {
            btnAtualizar.Enabled = false;
            btnSalvar.Enabled = false;
            BtnExcluir.Enabled = false;
        }



        //------------------------Métodos botões----------------------------------
        private void BtnNovo_Click(object sender, EventArgs e)
        {
            PessoaGetSet = new Pessoa();
            FuncionarioGetSet = new Funcionario();
            AtualizarPessoa = true;
        }
        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            FuncionarioNegocios funcionarioNegocios = new FuncionarioNegocios();
            DialogResult resultado = MessageBox.Show("Tem certeza?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.No)
            {
                return;
            }
            FuncionarioGetSet.Usuario_Cad_Alt = LoginNegocios.UsuarioLogadoGetSet;
            string retorno = funcionarioNegocios.Excluir(FuncionarioGetSet);

            try
            {
                int idFuncionario = Convert.ToInt32(retorno);
                MessageBox.Show("Cadastro excluído com sucesso!");
                PessoaGetSet = new Pessoa();
                FuncionarioGetSet = new Funcionario();
                AtualizarPessoa = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao excluir. Detalhes: " + retorno);
            }
        }
        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            if (FuncionarioGetSet != null)
            {
                FuncionarioNegocios funcionarioNegocios = new FuncionarioNegocios();
                Funcionario funcionario = new Funcionario();

                funcionario.Id_Funcionario = Convert.ToInt32(lblIdFuncionario.Text);
                funcionario.Pessoa = PessoaGetSet;
                funcionario.Data_Admissao = dtAdmissao.Value;
                if (CheckDemissao.Checked)
                {
                    funcionario.Data_Demissao = dtDemissao.Value;
                }
                funcionario.Hora_Entrada = horaEntrada.Value.TimeOfDay;
                funcionario.Hora_Saida = horaSaida.Value.TimeOfDay;
                funcionario.Num_CTPS = Convert.ToInt32(tbxCTPS.Text);
                funcionario.Serie_CTPS = Convert.ToInt32(tbxSerieCTPS.Text);
                funcionario.Num_NIS = Convert.ToInt32(tbxNIS.Text);
                funcionario.Usuario_Cad_Alt = LoginNegocios.UsuarioLogadoGetSet;

                string retorno = funcionarioNegocios.AtualizarporId(funcionario);
                try
                {
                    int IdFuncionario = Convert.ToInt32(retorno);
                    FuncionarioGetSet = funcionarioNegocios.ConsultarPorId(IdFuncionario)[0];
                    MessageBox.Show("Funcionario atualizado com sucesso!");
                    AtualizarPessoa = true;
                    AtualizarFuncionario = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro ao atualizar funcionário. Detalhes: " + retorno);
                }
            }   
        }
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();
            FuncionarioNegocios funcionarioNegocios = new FuncionarioNegocios();
            try
            {
                funcionario.Pessoa = PessoaGetSet;
                funcionario.Data_Admissao = dtAdmissao.Value;
                funcionario.Hora_Entrada = horaEntrada.Value.TimeOfDay;
                funcionario.Hora_Saida = horaSaida.Value.TimeOfDay;
                funcionario.Num_CTPS = Convert.ToInt32(tbxCTPS.Text);
                funcionario.Serie_CTPS = Convert.ToInt32(tbxSerieCTPS.Text);
                funcionario.Num_NIS = Convert.ToInt32(tbxNIS.Text);
                funcionario.Usuario_Cad_Alt = LoginNegocios.UsuarioLogadoGetSet;
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao carregar campos. Verifique os campos digitados");
            }

            string retorno = funcionarioNegocios.Inserir(funcionario);

            try
            {
                int idFuncionario = Convert.ToInt32(retorno);
                FuncionarioGetSet = funcionarioNegocios.ConsultarPorId(idFuncionario)[0];
                MessageBox.Show("Funcionario inserido com sucesso!");
                AtualizarFuncionario = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Erro: Detalhes: " + retorno);
            }

        }
        private void BtnSearchPessoa_Click(object sender, EventArgs e)
        {
            new Popup.transparentBg(new Popup.SearchDialogs.SearchDialog());
        }
        private void BtnSearchFuncionario_Click(object sender, EventArgs e)
        {
            new Popup.transparentBg(new Popup.SearchDialogs.SearchDialog_Funcionario());
        }
        private void BtnSelecionarFoto_Click(object sender, EventArgs e)
        {
            new Popup.transparentBg(new Popup.SearchDialogs.SearchDialog_WebCam_Foto());
        }


        //-------------------------Métodos Void-------------------------------------

        private void MostraTbxDt()
        {
            TbxdtDemissao.Visible = true;
            TbxdtAdmissao.Visible = true;
        }
        private void EscondeTbxDt()
        {
            TbxdtDemissao.Visible = false;
            TbxdtAdmissao.Visible = false;
        }
        private void CamposPessoa()
        {
            tbxCPF.Text = PessoaGetSet.CPF;
            tbxCPF.Enabled = false;
            tbxNome.Text = PessoaGetSet.Nome;
            tbxNome.Enabled = false;
            tbxSobrenome.Text = PessoaGetSet.Sobrenome;
            tbxSobrenome.Enabled = false;
            lblIdPessoa.Text = PessoaGetSet.Id_Pessoa.ToString();

            AtualizarPessoa = false;
            AtualizarFuncionario = true;
        }
        private void CamposFuncionario()
        {
            dtAdmissao.Value = FuncionarioGetSet.Data_Admissao;
            if (FuncionarioGetSet.Data_Demissao.ToString() != "01/01/0001 00:00:00")
            {
                dtDemissao.Value = FuncionarioGetSet.Data_Demissao;
            }
            else if (dtDemissao.Value.Day == DateTime.Now.AddDays(1).Day)
            {
                TbxdtDemissao.Visible = true;
            }
            else
            {
                TbxdtDemissao.Visible = false;
            }
            DateTime entrada = new DateTime(2000, 01, 01, 00, 00, 00) + FuncionarioGetSet.Hora_Entrada;
            horaEntrada.Value = entrada;
            DateTime saida = new DateTime(2000, 01, 01, 00, 00, 00) + FuncionarioGetSet.Hora_Saida;
            horaSaida.Value = saida;
            tbxCTPS.Text = FuncionarioGetSet.Num_CTPS.ToString();
            tbxSerieCTPS.Text = FuncionarioGetSet.Serie_CTPS.ToString();
            tbxNIS.Text = FuncionarioGetSet.Num_NIS.ToString();
            dtDataCadastro.Value = FuncionarioGetSet.Data_Cadastro;
            dtUltimaAtualizacao.Value = FuncionarioGetSet.Data_Ultima_Alteracao;
            lblIdFuncionario.Text = FuncionarioGetSet.Id_Funcionario.ToString();
        }
        private void LimparCamposTela()
        {
            lblIdPessoa.Text = "";
            tbxNome.Text = "";
            tbxSobrenome.Text = "";
            tbxCPF.Text = "";

            lblIdFuncionario.Text = "";
            dtAdmissao.Value = new DateTime(2020, 01, 01);
            TbxdtAdmissao.Visible = true;
            dtDemissao.Value = new DateTime(2020, 01, 01);
            horaEntrada.Value = new DateTime(2000, 01, 01, 00, 00, 00);
            horaSaida.Value = new DateTime(2000, 01, 01, 00, 00, 00);
            TbxdtDemissao.Visible = true;
            tbxCTPS.Text = "";
            tbxSerieCTPS.Text = "";
            tbxNIS.Text = "";
            dtDataCadastro.Value = DateTime.Now;
            dtUltimaAtualizacao.Value = DateTime.Now;
        }

        //----------------------Metodos Componentes-----------------------------
        private void DtAdmissao_ValueChanged(object sender, EventArgs e)
        {
            dtAdmissao.CustomFormat = "dd-MM-yyyy";
        }
        private void DtDemissao_ValueChanged(object sender, EventArgs e)
        {
            dtDemissao.CustomFormat = "dd-MM-yyyy";
        }
        private void DtDataCadastro_ValueChanged(object sender, EventArgs e)
        {
            dtDataCadastro.CustomFormat = "dd-MM-yyyy";
        }
        private void DtUltimaAtualizacao_ValueChanged(object sender, EventArgs e)
        {
            dtUltimaAtualizacao.CustomFormat = "dd-MM-yyyy";
        }
        private void DtDemissao_Enter(object sender, EventArgs e)
        {
            TbxdtDemissao.Visible = false;
        }
        private void DtAdmissao_Enter(object sender, EventArgs e)
        {
            TbxdtAdmissao.Visible = false;
        }

        //---------------------------Timers-------------------------------------
        private void Timerpreenche_Tick(object sender, EventArgs e)
        {
            if (AtualizarPessoa == true)
            {
                if (PessoaGetSet.Id_Pessoa > 0)
                {
                    LimparCamposTela();
                    CamposPessoa();
                    btnAtualizar.Enabled = false;
                    btnSalvar.Enabled = true;
                    BtnExcluir.Enabled = false;
                    AtualizarFuncionario = false;
                    AtualizarFuncionario = true;
                }
                else
                {
                    LimparCamposTela();
                    btnSalvar.Enabled = false;
                    AtualizarPessoa = false;
                    AtualizarFuncionario = false;
                }

            }
            if (AtualizarFuncionario == true)
            {
                if (FuncionarioGetSet.Id_Funcionario > 0)
                {
                    CamposFuncionario();
                    EscondeTbxDt();
                    btnAtualizar.Enabled = true;
                    BtnExcluir.Enabled = true;
                    btnSalvar.Enabled = false;
                    AtualizarFuncionario = false;
                }
            }
        }
    }
}
