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

namespace Apresentacao.Presentation.Pages
{
    public partial class AdicionarEditarFuncionario : UserControl
    {
        public AdicionarEditarFuncionario()
        {
            if (Program.IsInDesignMode()) return;
            InitializeComponent();
        }

        private static Pessoa pessoaGetSet;

        public static Pessoa PessoaGetSet
        {
            get { return pessoaGetSet; }
            set { pessoaGetSet = value; }
        }

        private static Funcionario funcionarioGetSet;
        
        public static Funcionario FuncionarioGetSet
        {
            get { return funcionarioGetSet; }
            set { funcionarioGetSet = value; }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            new Apresentacao.Presentation.Popup.transparentBg(new Apresentacao.Presentation.Popup.SearchDialogs.SearchDialog());
        }

        private void timerpreenche_Tick(object sender, EventArgs e)
        {
            if (pessoaGetSet != null)
            {
                tbxCPF.Text = pessoaGetSet.CPF;
                tbxCPF.Enabled = false;
                tbxNome.Text = pessoaGetSet.Nome;
                tbxNome.Enabled = false;
                tbxSobrenome.Text = pessoaGetSet.Sobrenome;
                tbxSobrenome.Enabled = false;
            }

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
