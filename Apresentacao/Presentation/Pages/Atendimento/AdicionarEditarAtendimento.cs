using System;
using System.Windows.Forms;
using ObjetoTransferencia;
using Negocios;

namespace Apresentacao.Presentation.Pages
{
    public partial class AdicionarEditarAtendimento : UserControl
    {
        public AdicionarEditarAtendimento()
        {
            if (Program.IsInDesignMode()) return;
            InitializeComponent();
        }

        public static Pessoa PessoaGetSet { get; set; }

        public static Funcionario FuncionarioGetSet { get; set; }

        private void CamposPessoa()
        {
            //tbxCPF.Text = PessoaGetSet.CPF;
            //tbxCPF.Enabled = false;
            //tbxNome.Text = PessoaGetSet.Nome;
            //tbxNome.Enabled = false;
            //tbxSobrenome.Text = PessoaGetSet.Sobrenome;
            //tbxSobrenome.Enabled = false;
            //lblIdPessoa.Text = PessoaGetSet.Id_Pessoa.ToString();
        }

        private void CamposFuncionario()
        {
            //dtAdmissao.Value = FuncionarioGetSet.Data_Admissao;
            //if (FuncionarioGetSet.Data_Demissao.ToString() != "01/01/0001 00:00:00")
            //{
            //    dtDemissao.Value = FuncionarioGetSet.Data_Demissao;
            //}
            //horaEntrada.Value = FuncionarioGetSet.Hora_Entrada;
            //horaSaida.Value = FuncionarioGetSet.Hora_Saida;
            //tbxCTPS.Text = FuncionarioGetSet.Num_CTPS.ToString();
            //tbxSerieCTPS.Text = FuncionarioGetSet.Serie_CTPS.ToString();
            //tbxNIS.Text = FuncionarioGetSet.Num_NIS.ToString();
            //dtDataCadastro.Value = FuncionarioGetSet.Data_Cadastro;
            //dtUltimaAtualizacao.Value = FuncionarioGetSet.Data_Ultima_Alteracao;
            //lblIdFuncionario.Text = FuncionarioGetSet.Id_Funcionario.ToString();
        }

        private void timerpreenche_Tick(object sender, EventArgs e)
        {

            //if (FuncionarioGetSet != null)
            //{
            //    if (lblIdFuncionario.Text == "None")
            //    {
            //        CamposPessoa();
            //        CamposFuncionario();
            //        btnAtualizar.Enabled = true;
            //        btnSalvar.Enabled = false;
            //        btnAtualizar.Enabled = true;
            //    }
            //    else if (FuncionarioGetSet.Id_Funcionario != Convert.ToInt32(lblIdFuncionario.Text))
            //    {
            //        CamposFuncionario();
            //        CamposPessoa();
            //        btnAtualizar.Enabled = true;
            //        btnSalvar.Enabled = false;
            //        btnAtualizar.Enabled = true;
            //    }
            //}
            //else if (PessoaGetSet != null)
            //{
            //    CamposPessoa();
            //    btnAtualizar.Enabled = true;
            //    btnSalvar.Enabled = true;
            //    btnAtualizar.Enabled = false;
            //}
            //else if (PessoaGetSet != null && FuncionarioGetSet != null)
            //{
            //    btnSalvar.Enabled = false;
            //    btnAtualizar.Enabled = false;
            //}

        }

        
    }
}
