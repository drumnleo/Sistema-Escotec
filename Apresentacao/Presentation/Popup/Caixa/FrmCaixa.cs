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

namespace Apresentacao.Presentation.Popup
{
    public partial class FrmCaixa : Form
    {
        public static ContasReceber ContaGetSet { get; set; }
        private Caixa caixaGetSet { get; set; }
        private Usuario usuariologado { get; set; }
        public static Boolean AtualizaCampos = false;


        public FrmCaixa()
        {
            InitializeComponent();
        }


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

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (AtualizaCampos == true)
            {
                AtualizaCamposContas();
                timer1.Enabled = false;
            }
        }

        private void AtualizaCamposCaixa()
        {
            TbxIdCaixa.Text = caixaGetSet.Id_Caixa.ToString();
            TbxSaldo.Text = caixaGetSet.Saldo.ToString();
            TbxDataAtual.Text = DateTime.Now.ToShortDateString();
            TbxUsuario.Text = usuariologado.Nome_Usuario;
        }

        private void AtualizaCamposContas()
        {
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
                BtnRecebe.Enabled = false;
            }
            else
            {
                TbxSituacao.Text = "A RECEBER";
                BtnRecebe.Enabled = true;
                BtnEstorno.Enabled = false;
            }
        }

        private void FrmCaixa_Load(object sender, EventArgs e)
        {
            UsuarioNegocios usuarioNegocios = new UsuarioNegocios();
            usuariologado = usuarioNegocios.ConsultarPorId(LoginNegocios.UsuarioLogadoGetSet.Id_Usuario);

            AtualizaCaixa();
        }

        private void AtualizaCaixa()
        {
            CaixaNegocios caixaNegocios = new CaixaNegocios();
            CaixaColecao caixas = new CaixaColecao();
            caixas = caixaNegocios.ConsultarPorFuncRecebe(LoginNegocios.UsuarioLogadoGetSet.Id_Usuario);
            caixaGetSet = caixas[0];

            AtualizaCamposCaixa();
        }

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

        private void BtnRecebe_Click(object sender, EventArgs e)
        {
            CaixaNegocios caixaNegocios = new CaixaNegocios();
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
                TbxSituacao.Text = "PAGO";
                AtualizaCaixa();

            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao abrir caixa. Detalhes: " + retorno);
            }
        }

        private void BtnEstorno_Click(object sender, EventArgs e)
        {
            CaixaNegocios caixaNegocios = new CaixaNegocios();
            MovimentoCaixa movimentoCaixa = new MovimentoCaixa();
            movimentoCaixa.ContasReceber = ContaGetSet;
            movimentoCaixa.TipoMovimentoCaixa = new TipoMovimentoCaixa();
            movimentoCaixa.TipoMovimentoCaixa.Id_Tipo_Movimento = 2;
            movimentoCaixa.Usuario = usuariologado;

            string retorno = caixaNegocios.MovimentoCaixaEstorno(movimentoCaixa);

            try
            {
                int idMovimento = Convert.ToInt32(retorno);
                MessageBox.Show("Estornado com sucesso!", "Confirmado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TbxSituacao.Text = "NÃO PAGO";
                AtualizaCaixa();

            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao abrir caixa. Detalhes: " + retorno);
            }
        }

        private void BtnSangria_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            new Popup.transparentBg(new Popup.ConfirmaUsuario.Frm_UsuarioConfirma(UsuarioAutoriza.caixa));
        }
    }
}
