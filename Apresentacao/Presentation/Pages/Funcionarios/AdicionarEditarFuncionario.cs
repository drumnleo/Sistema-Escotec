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

        public static Pessoa PessoaGetSet { get; set; }
        public static Funcionario FuncionarioGetSet { get; set; }
        public static Boolean AtualizarPessoa = false;
        public static Boolean AtualizarFuncionario = false;


        //Botões
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
            if (CheckDemissao.Checked)
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
                Funcionario funcionarioCadastrado = funcionarioNegocios.ConsultarPorId(IdFuncionario)[0];
                MessageBox.Show("Funcionario atualizado com sucesso!");
                AdicionarEditarFuncionario.FuncionarioGetSet = funcionarioCadastrado;
                AdicionarEditarFuncionario.AtualizarFuncionario = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao atualizar funcionário. Detalhes: " + retorno);
            }


        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();
            try
            {
                funcionario.Pessoa = PessoaGetSet;
                funcionario.Data_Admissao = dtAdmissao.Value;
                funcionario.Hora_Entrada = horaEntrada.Value;
                funcionario.Hora_Saida = horaSaida.Value;
                funcionario.Num_CTPS = Convert.ToInt32(tbxCTPS.Text);
                funcionario.Serie_CTPS = Convert.ToInt32(tbxSerieCTPS.Text);
                funcionario.Num_NIS = Convert.ToInt32(tbxNIS.Text);
                funcionario.Usuario_Cad_Alt = LoginNegocios.UsuarioLogadoGetSet;
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao carregar campos. Verifique os campos digitados");
            }


            FuncionarioNegocios funcionarioNegocios = new FuncionarioNegocios();

            string retorno = funcionario.Usuario_Cad_Alt != null ? funcionarioNegocios.Inserir(funcionario) : "";
            if (retorno != "")
            {
                try
                {
                    int idFuncionario = Convert.ToInt32(retorno);
                    Funcionario funcionarioCadastrado = funcionarioNegocios.ConsultarPorId(idFuncionario)[0];
                    MessageBox.Show("Funcionario inserido com sucesso!");
                    lblIdFuncionario.Text = funcionarioCadastrado.Id_Funcionario.ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro: Detalhes: " + retorno);
                }
            }

        }
        private void btnSelecionarFoto_Click(object sender, EventArgs e)
        {
            new Popup.transparentBg(new Popup.SearchDialogs.SearchDialog_WebCam_Foto());
        }


        //Timers
        private void timerpreenche_Tick(object sender, EventArgs e)
        {
            if (AtualizarPessoa == true)
            {
                CamposPessoa();
                AtualizaBotoes();
            }
            if (AtualizarFuncionario == true)
            {
                EscondeTbxDt();
                CamposFuncionario();           
                AtualizaBotoes();
            }
        }


        //Datetime pickers muda formato da data no componente
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
        
        
        //Datetime picker esconde textbox 
        private void dtDemissao_Enter(object sender, EventArgs e)
        {
            TbxdtDemissao.Visible = false;
        }
        private void dtAdmissao_Enter(object sender, EventArgs e)
        {
            TbxdtAdmissao.Visible = false;
        }


        //Metodos
        private void AtualizaBotoes()
        {
            if (PessoaGetSet != null && FuncionarioGetSet != null)
            {
                btnAtualizar.Enabled = true;
                btnSalvar.Enabled = false;
            }
            else if (PessoaGetSet != null && FuncionarioGetSet != null)
            {
                btnSalvar.Enabled = false;
                btnAtualizar.Enabled = false;
            }
            else
            {
                btnSalvar.Enabled = true;
                btnAtualizar.Enabled = false;
            }
        }
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
        private void limpaCampos()
        {
            tbxNome.Text = "";
            tbxSobrenome.Text = "";
            tbxCPF.Text = "";
            dtAdmissao.Value = new DateTime(2020, 01, 01);
            TbxdtAdmissao.Visible = true;
            dtDemissao.Value = new DateTime(2020, 01, 01);
            TbxdtDemissao.Visible = true;
            tbxCTPS.Text = "";
            tbxSerieCTPS.Text = "";
            tbxNIS.Text = "";
            dtDataCadastro.Value = DateTime.Now;
            dtUltimaAtualizacao.Value = DateTime.Now;
        }

        private void LimpaCamposFuncionario()
        {
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
        private Boolean VerificaFuncionarioCadastrado()
        {
            Boolean retorno = true;

            if (retorno == true)
            {
                retorno = TbxdtAdmissao.Visible == false;
            }
            if (retorno == true)
            {
                retorno = TbxdtAdmissao.Visible == false;
            }
            if (retorno == true)
            {
                retorno = TbxdtDemissao.Visible == false;
            }




            return retorno;

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
            if (FuncionarioGetSet.Pessoa != null)
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
                horaEntrada.Value = FuncionarioGetSet.Hora_Entrada;
                horaSaida.Value = FuncionarioGetSet.Hora_Saida;
                tbxCTPS.Text = FuncionarioGetSet.Num_CTPS.ToString();
                tbxSerieCTPS.Text = FuncionarioGetSet.Serie_CTPS.ToString();
                tbxNIS.Text = FuncionarioGetSet.Num_NIS.ToString();
                dtDataCadastro.Value = FuncionarioGetSet.Data_Cadastro;
                dtUltimaAtualizacao.Value = FuncionarioGetSet.Data_Ultima_Alteracao;
                lblIdFuncionario.Text = FuncionarioGetSet.Id_Funcionario.ToString();

                AtualizarFuncionario = false;
            }
            else
            {
                LimpaCamposFuncionario();

                AtualizarFuncionario = false;
            }
            
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            PessoaGetSet = new Pessoa();
            FuncionarioGetSet = new Funcionario();
            AtualizarPessoa = true;
            AtualizarFuncionario = true;
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
                AtualizarFuncionario = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao excluir. Detalhes: " + retorno);
            }
        }
    }
}
