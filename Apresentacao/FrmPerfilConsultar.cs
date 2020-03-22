using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;
using ObjetoTransferencia;

namespace Apresentacao
{
    public partial class FrmPerfilConsultar : Form
    {
        public FrmPerfilConsultar()
        {
            InitializeComponent();

            dataGridViewPerfil.AutoGenerateColumns = false;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void AtualizarGrid()
        {
            PerfilNegocios perfilNegocios = new PerfilNegocios();

            PerfilMenuColecao perfilTipoColecao = new PerfilMenuColecao();

            perfilTipoColecao = perfilNegocios.ConsultarPorNome(textBoxPesquisa.Text);

            dataGridViewPerfil.DataSource = null;
            dataGridViewPerfil.DataSource = perfilTipoColecao;

            dataGridViewPerfil.Update();
            dataGridViewPerfil.Refresh();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridViewPerfil.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum perfil selecionado","Informação",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }

            DialogResult resultado = MessageBox.Show("Tem certeza?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.No)
            {
                return;
            }


            PerfilMenu perfilSelecionado = dataGridViewPerfil.SelectedRows[0].DataBoundItem as PerfilMenu;

            PerfilNegocios perfilNegocios = new PerfilNegocios();

            string retorno = perfilNegocios.Excluir(perfilSelecionado);

            try
            {
                int idPerfil = Convert.ToInt32(retorno);

                MessageBox.Show("Cliente excluído com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                AtualizarGrid();
            }
            catch 
            {
                MessageBox.Show("Não foi possível excluir. Detalhes:" + retorno, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            FrmPerfilInserir frmPerfilInserir = new FrmPerfilInserir();
            frmPerfilInserir.ShowDialog();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

        }
    }
}
