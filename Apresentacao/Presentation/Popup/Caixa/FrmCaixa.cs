using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjetoTransferencia;
using Negocios;
using Apresentacao.Presentation.Popup.ConfirmaUsuario;

namespace Apresentacao.Presentation.Popup
{
    public partial class FrmCaixa : Form
    {
        public static ContasReceber ContaGetSet { get; set; }
        private Caixa caixaGetSet { get; set; }
        private Usuario usuariologado { get; set; }
        public static MovimentoCaixa MovimentoGetSet { get; set; }
        public static Usuario UsuarioEstorno { get; set; }
        public static Boolean AtualizaCampos = false;
        public static Boolean AtualizaCamposMovimento = false;


        public FrmCaixa()
        {
            InitializeComponent();
        }

        private void FrmCaixa_Load(object sender, EventArgs e)
        {
            UsuarioNegocios usuarioNegocios = new UsuarioNegocios();
            usuariologado = usuarioNegocios.ConsultarPorId(LoginNegocios.UsuarioLogadoGetSet.Id_Usuario);

            AtualizaCaixa();
        }



        //------------Metodos Botões
        private void BtnSair_Click(object sender, EventArgs e)
        {
            FrmLogin_flat.TrocaEstadoCaixa = true;
            this.Hide();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            new Popup.transparentBg(new Popup.SearchDialogs.SearchDialog_ContasReceber());
            timer1.Enabled = true;
        }
        private void BtnRecebe_Click(object sender, EventArgs e)
        {
            CaixaNegocios caixaNegocios = new CaixaNegocios();
            ContasReceberNegocios contasReceberNegocios = new ContasReceberNegocios();
            MovimentoCaixa movimentoCaixa = new MovimentoCaixa();
            movimentoCaixa.Caixa = caixaGetSet;
            movimentoCaixa.ContasReceber = ContaGetSet;
            if (TbxDesconto.Text != "")
            {
                movimentoCaixa.Desconto = Convert.ToInt16(TbxDesconto.Text);
            }
            movimentoCaixa.TipoMovimentoCaixa = new TipoMovimentoCaixa();
            movimentoCaixa.TipoMovimentoCaixa.Id_Tipo_Movimento = 1;
            movimentoCaixa.Usuario = usuariologado;

            string retorno = caixaNegocios.MovimentoCaixaPadrao(movimentoCaixa);

            try
            {
                int idMovimento = Convert.ToInt32(retorno);
                MessageBox.Show("Recebido com sucesso!", "Confirmado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MovimentoGetSet = caixaNegocios.ConsultarMovimentoPorId(idMovimento)[0];
                ContaGetSet = contasReceberNegocios.ConsultarPorIdContaPaga(Convert.ToInt32(TbxIdConta.Text))[0];
                LimparCampos();
                AtualizaCaixa();
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao abrir caixa. Detalhes: " + retorno);
            }
        }
        private void BtnEstorno_Click(object sender, EventArgs e)
        {
            Frm_UsuarioConfirma frm_UsuarioConfirma = new Frm_UsuarioConfirma(UsuarioAutoriza.caixa);
            DialogResult dr = frm_UsuarioConfirma.ShowDialog();

            if (dr == DialogResult.OK)
            {
                CaixaNegocios caixaNegocios = new CaixaNegocios();
                MovimentoCaixa movimentoCaixa = new MovimentoCaixa();
                movimentoCaixa.Id_Mov_Caixa = Convert.ToInt32(TbxIdMovCaixa.Text);
                movimentoCaixa.Valor_Final = Convert.ToDecimal(TbxTotal.Text);
                movimentoCaixa.Caixa = caixaGetSet;
                movimentoCaixa.Usuario_Aut_Estorno = UsuarioEstorno;
                movimentoCaixa.ContasReceber = ContaGetSet;
                movimentoCaixa.Usuario = usuariologado;

                string retorno = caixaNegocios.MovimentoCaixaEstorno(movimentoCaixa);

                try
                {
                    int idMovimento = Convert.ToInt32(retorno);
                    MessageBox.Show("Estornado com sucesso!", "Confirmado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();
                    AtualizaCaixa();

                }
                catch (Exception)
                {
                    MessageBox.Show("Erro ao estornar. Detalhes: " + retorno);
                }
            }
            else if (dr == DialogResult.No)
            {
                MessageBox.Show("Usuário para autorização de estorno não confirmado. Tente novamente!");
            }
        }
        private void BtnSangria_Click(object sender, EventArgs e)
        {
            Frm_UsuarioConfirma frm_UsuarioConfirma = new Frm_UsuarioConfirma(UsuarioAutoriza.caixa);
            DialogResult dr = frm_UsuarioConfirma.ShowDialog();

            if (dr == DialogResult.OK)
            {
                CaixaNegocios caixaNegocios = new CaixaNegocios();
                MovimentoCaixa movimentoCaixa = new MovimentoCaixa();
                movimentoCaixa.TipoMovimentoCaixa = new TipoMovimentoCaixa();
                movimentoCaixa.TipoMovimentoCaixa.Id_Tipo_Movimento = 3;
                movimentoCaixa.Valor_Final = Convert.ToDecimal(TbxSangriaValor.Text);
                movimentoCaixa.Caixa = caixaGetSet;
                movimentoCaixa.Usuario_Aut_Estorno = UsuarioEstorno;
                movimentoCaixa.ContasReceber = ContaGetSet;
                movimentoCaixa.Usuario = usuariologado;

                string retorno = caixaNegocios.MovimentoCaixaSangria(movimentoCaixa);

                try
                {
                    int idMovimento = Convert.ToInt32(retorno);
                    MessageBox.Show("Sangria realizada com sucesso!", "Confirmado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();
                    AtualizaCaixa();

                }
                catch (Exception)
                {
                    MessageBox.Show("Erro ao executar sangria. Detalhes: " + retorno);
                }
            }
            else if (dr == DialogResult.No)
            {
                MessageBox.Show("Usuário para autorização de sangria não confirmado. Tente novamente!");
            }
        }
        private void BtnSearchMovimento_Click(object sender, EventArgs e)
        {
            new Popup.transparentBg(new Apresentacao.Presentation.Popup.SearchDialogs.SearchDialog_MovimentoCaixa(caixaGetSet.Id_Caixa));
            timer2.Enabled = true;
        }


        //-----------Metodos Personalizados
        private void AtualizaCamposCaixa()
        {
            TbxIdCaixa.Text = caixaGetSet.Id_Caixa.ToString();
            TbxSaldo.Text = caixaGetSet.Saldo.ToString();
            TbxDataAtual.Text = DateTime.Now.ToShortDateString();
            TbxUsuario.Text = usuariologado.Nome_Usuario;
        }
        private void AtualizaCamposContas()
        {
            TbxIdMovCaixa.Text = "";
            TbxIdConta.Text = ContaGetSet.Id_Conta_Receber.ToString();
            TbxIdMatricula.Text = ContaGetSet.Matricula.Id_Matricula.ToString();
            AlunoNegocios alunoNegocios = new AlunoNegocios();
            Aluno aluno = alunoNegocios.ConsultarPorId(ContaGetSet.Matricula.Aluno.Id_Aluno);
            TbxNomeAluno.Text = aluno.Pessoa.Nome;
            TbxSobrenomeAluno.Text = aluno.Pessoa.Sobrenome;
            TbxCPF.Text = aluno.Pessoa.CPF;
            TbxSubTotal.Text = ContaGetSet.Valor.ToString();
            TbxTotal.Text = ContaGetSet.Valor.ToString();
            if (ContaGetSet.Situacao_Pg.ToString() == "P")
            {
                TbxSituacao.Text = "PAGO";
                BtnEstorno.Enabled = true;
                TbxDesconto.Enabled = false;
                BtnRecebe.Enabled = false;
            }
            else
            {
                TbxSituacao.Text = "A RECEBER";
                BtnRecebe.Enabled = true;
                TbxDesconto.Enabled = true;
                BtnEstorno.Enabled = false;
            }
        }
        private void AtualizaCamposContasMovimento()
        {
            TbxIdMovCaixa.Text = MovimentoGetSet.Id_Mov_Caixa.ToString();
            TbxIdConta.Text = ContaGetSet.Id_Conta_Receber.ToString();
            TbxIdMatricula.Text = ContaGetSet.Matricula.Id_Matricula.ToString();
            AlunoNegocios alunoNegocios = new AlunoNegocios();
            Aluno aluno = alunoNegocios.ConsultarPorId(ContaGetSet.Matricula.Aluno.Id_Aluno);
            TbxNomeAluno.Text = aluno.Pessoa.Nome;
            TbxSobrenomeAluno.Text = aluno.Pessoa.Sobrenome;
            TbxCPF.Text = aluno.Pessoa.CPF;
            TbxSubTotal.Text = ContaGetSet.Valor.ToString();
            TbxTotal.Text = ContaGetSet.Valor.ToString();
            if (ContaGetSet.Situacao_Pg.ToString() == "P")
            {
                TbxSituacao.Text = "PAGO";
                BtnEstorno.Enabled = true;
                TbxDesconto.Enabled = false;
                BtnRecebe.Enabled = false;
            }
            else
            {
                TbxSituacao.Text = "A RECEBER";
                BtnRecebe.Enabled = true;
                TbxDesconto.Enabled = true;
                BtnEstorno.Enabled = false;
            }
        }
        private void LimparCampos()
        {
            TbxIdMovCaixa.Text = "";
            TbxIdConta.Text = "";
            TbxIdMatricula.Text = "";
            TbxNomeAluno.Text = "";
            TbxSobrenomeAluno.Text = "";
            TbxCPF.Text = "";
            TbxSubTotal.Text = "";
            TbxTotal.Text = "";
            TbxSituacao.Text = "";
            TbxDesconto.Text = "";
            TbxDesconto.Enabled = true;
            BtnEstorno.Enabled = false;
            BtnRecebe.Enabled = false;
            BtnSangria.Enabled = false;
        }
        private void AtualizaCaixa()
        {
            CaixaNegocios caixaNegocios = new CaixaNegocios();
            CaixaColecao caixas = new CaixaColecao();
            caixas = caixaNegocios.ConsultarPorFuncRecebe(LoginNegocios.UsuarioLogadoGetSet.Id_Usuario);
            caixaGetSet = caixas[0];
            if(caixaGetSet.Valor_Sangria < caixaGetSet.Saldo)
            {
                LblSangria.Visible = true;
                BtnSangria.Enabled = true;
                LblSangria.Visible = true;
                TbxSangriaValor.Visible = true;
                TbxSangriaValor.Enabled = true;
                BtnEstorno.Enabled = false;
                TbxDesconto.Enabled = false;
                BtnRecebe.Enabled = false;
            }
            else
            {
                LblSangria.Visible = false;
                BtnSangria.Enabled = false;
                LblSangria.Visible = false;
                TbxSangriaValor.Visible = false;
                TbxSangriaValor.Enabled = false;
                BtnEstorno.Enabled = true;
                TbxDesconto.Enabled = true;
                BtnRecebe.Enabled = false;
            }

            AtualizaCamposCaixa();
        }
        private void VerificaSeDecimalDigitado(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("este campo aceita somente numero");
            }
        }


        //-----------Metodos Controles
        private void TbxDesconto_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }

            // checks to make sure only 1 decimal is allowed
            if (e.KeyChar == 46)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
        }
        private void TbxDesconto_Leave(object sender, EventArgs e)
        {
            if (TbxDesconto.Text != "")
            {
                decimal desconto = Convert.ToDecimal(TbxDesconto.Text);
                decimal total = ContaGetSet.Valor - (((ContaGetSet.Valor / 100) * desconto));
                TbxTotal.Text = total.ToString();
            }
        }



        //-------------Timers
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (AtualizaCampos == true)
            {
                AtualizaCamposContas();
                timer1.Enabled = false;
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (AtualizaCamposMovimento == true)
            {
                ContasReceberNegocios contasReceberNegocios = new ContasReceberNegocios();
                ContaGetSet = contasReceberNegocios.ConsultarPorIdContaPaga(MovimentoGetSet.ContasReceber.Id_Conta_Receber)[0];
                AtualizaCamposContasMovimento();
                timer2.Enabled = false;
            }
        }
    }
}
