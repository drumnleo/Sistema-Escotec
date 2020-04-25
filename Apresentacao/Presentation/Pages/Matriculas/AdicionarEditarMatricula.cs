using System;
using System.Windows.Forms;
using ObjetoTransferencia;
using Negocios;

namespace Apresentacao.Presentation.Pages
{
    public partial class AdicionarEditarMatricula : UserControl
    {
        public AdicionarEditarMatricula()
        {
            if (Program.IsInDesignMode()) return;
            InitializeComponent();

            btnAtualizar.Enabled = false;

            dtAdmissao.Format = DateTimePickerFormat.Custom;
            dtAdmissao.CustomFormat = " ";

            dtDemissao.Format = DateTimePickerFormat.Custom;
            dtDemissao.CustomFormat = " ";

            dtDataCadastro.Format = DateTimePickerFormat.Custom;
            dtDataCadastro.CustomFormat = " ";
            dtDataCadastro.Enabled = false;

            dtUltimaAtualizacao.Format = DateTimePickerFormat.Custom;
            dtUltimaAtualizacao.CustomFormat = " ";
            dtUltimaAtualizacao.Enabled = false;

        }

        public static Pessoa PessoaGetSet { get; set; }

        public static Funcionario FuncionarioGetSet { get; set; }

        private void CamposPessoa()
        {
            tbxCPF.Text = PessoaGetSet.CPF;
            tbxCPF.Enabled = false;
            tbxNome.Text = PessoaGetSet.Nome;
            tbxNome.Enabled = false;
            tbxSobrenome.Text = PessoaGetSet.Sobrenome;
            tbxSobrenome.Enabled = false;
            lblIdPessoa.Text = PessoaGetSet.Id_Pessoa.ToString();
        }

        private void CamposFuncionario()
        {
            dtAdmissao.Value = FuncionarioGetSet.Data_Admissao;
            if (FuncionarioGetSet.Data_Demissao.ToString() != "01/01/0001 00:00:00")
            {
                dtDemissao.Value = FuncionarioGetSet.Data_Demissao;
            }
            horaEntrada.Value = FuncionarioGetSet.Hora_Entrada;
            horaSaida.Value = FuncionarioGetSet.Hora_Saida;
            tbxCTPS.Text = FuncionarioGetSet.Num_CTPS.ToString();
            tbxSerieCTPS.Text = FuncionarioGetSet.Serie_CTPS.ToString();
            tbxNIS.Text = FuncionarioGetSet.Num_NIS.ToString();
            dtDataCadastro.Value = FuncionarioGetSet.Data_Cadastro;
            dtUltimaAtualizacao.Value = FuncionarioGetSet.Data_Ultima_Alteracao;
            lblIdFuncionario.Text = FuncionarioGetSet.Id_Funcionario.ToString();
        }

        private void timerpreenche_Tick(object sender, EventArgs e)
        {

            if (FuncionarioGetSet != null)
            {
                if (lblIdFuncionario.Text == "None")
                {
                    CamposPessoa();
                    CamposFuncionario();
                    btnAtualizar.Enabled = true;
                    btnSalvar.Enabled = false;
                    btnAtualizar.Enabled = true;
                }
                else if (FuncionarioGetSet.Id_Funcionario != Convert.ToInt32(lblIdFuncionario.Text))
                {
                    CamposFuncionario();
                    CamposPessoa();
                    btnAtualizar.Enabled = true;
                    btnSalvar.Enabled = false;
                    btnAtualizar.Enabled = true;
                }
            }
            else if (PessoaGetSet != null)
            {
                CamposPessoa();
                btnAtualizar.Enabled = true;
                btnSalvar.Enabled = true;
                btnAtualizar.Enabled = false;
            }
            else if (PessoaGetSet != null && FuncionarioGetSet != null)
            {
                btnSalvar.Enabled = false;
                btnAtualizar.Enabled = false;
            }

        }

        private void btnSearchPessoa_Click(object sender, EventArgs e)
        {
            new Popup.transparentBg(new Popup.SearchDialogs.SearchDialog());
        }

        private void btnSearchFuncionario_Click(object sender, EventArgs e)
        {
            new Popup.transparentBg(new Popup.SearchDialogs.SearchDialog_Funcionario());
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            FuncionarioNegocios funcionarioNegocios = new FuncionarioNegocios();
            Funcionario funcionario = new Funcionario();

            funcionario.Id_Funcionario = Convert.ToInt32(lblIdFuncionario.Text);
            funcionario.Pessoa = PessoaGetSet;
            funcionario.Data_Admissao = dtAdmissao.Value;
            if (FuncionarioGetSet.Data_Demissao.ToString() != "01/01/0001 00:00:00")
            {
                funcionario.Data_Demissao = dtDemissao.Value;
            }
            funcionario.Hora_Entrada = horaEntrada.Value;
            funcionario.Hora_Saida = horaSaida.Value;
            funcionario.Num_CTPS = Convert.ToInt32(tbxCTPS.Text);
            funcionario.Serie_CTPS = Convert.ToInt32(tbxSerieCTPS.Text);
            funcionario.Num_NIS = Convert.ToInt32(tbxNIS.Text);
            funcionario.Usuario_Cad_Alt = LoginNegocios.UsuarioLogadoGetSet;

            string retorno = funcionarioNegocios.AtualizarporId(funcionario);
            try
            {
                int IdFuncionario = Convert.ToInt32(retorno); 
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao atualizar funcionário. Detalhes: " + retorno);
            }


        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();
            funcionario.Pessoa = PessoaGetSet;
            funcionario.Data_Admissao = dtAdmissao.Value;
            funcionario.Hora_Entrada = horaEntrada.Value;
            funcionario.Hora_Saida = horaSaida.Value;
            funcionario.Num_CTPS = Convert.ToInt32(tbxCTPS.Text);
            funcionario.Serie_CTPS = Convert.ToInt32(tbxSerieCTPS.Text);
            funcionario.Num_NIS = Convert.ToInt32(tbxNIS.Text);
            funcionario.Usuario_Cad_Alt = LoginNegocios.UsuarioLogadoGetSet;

            FuncionarioNegocios funcionarioNegocios = new FuncionarioNegocios();
            string retorno = funcionarioNegocios.Inserir(funcionario);

            try
            {
                int idFuncionario = Convert.ToInt32(retorno);
                Funcionario funcionarioCadastrado = funcionarioNegocios.ConsultarPorId(idFuncionario);
                MessageBox.Show("Funcionario inserido com sucesso!");
                lblIdFuncionario.Text = funcionarioCadastrado.Id_Funcionario.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Erro: Detalhes: " + retorno);
            }
        }

        private void dtAdmissao_ValueChanged(object sender, EventArgs e)
        {
            dtAdmissao.CustomFormat = "dd-MM-yyyy";
        }

        private void dtDemissao_ValueChanged(object sender, EventArgs e)
        {
            dtDemissao.CustomFormat = "dd-MM-yyyy";
        }

        private void dtDataCadastro_ValueChanged(object sender, EventArgs e)
        {
            dtDataCadastro.CustomFormat = "dd-MM-yyyy";
        }

        private void dtUltimaAtualizacao_ValueChanged(object sender, EventArgs e)
        {
            dtUltimaAtualizacao.CustomFormat = "dd-MM-yyyy";
        }

        private void btnSelecionarFoto_Click(object sender, EventArgs e)
        {
            new Popup.transparentBg(new Popup.SearchDialogs.SearchDialog_WebCam_Foto());
        }
    }
}
