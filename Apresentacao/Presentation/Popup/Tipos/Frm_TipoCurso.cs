using System;
using System.Windows.Forms;
using ObjetoTransferencia;
using Negocios;
using Apresentacao.Presentation.Pages;
using System.Linq;

namespace Apresentacao.Presentation.Popup.SearchDialogs
{

    public partial class Frm_TipoCurso : Form
    {
        Pessoa pessoaescolhida = new Pessoa();
        Endereco enderecoSelecionado = new Endereco();
        EnderecoGeralColecao enderecoGeralColecao = new EnderecoGeralColecao();
        string[] controlesEndereco = new string[7];


        public Frm_TipoCurso(Pessoa pessoa)
        {
            InitializeComponent();
            pessoaescolhida = pessoa;
            tbxIdPessoa.Text = Convert.ToString(pessoa.Id_Pessoa);
            tbxNomePessoa.Text = pessoaescolhida.Nome + " " + pessoaescolhida.Sobrenome;
            dataGrid.AutoGenerateColumns = false;
            btnNovo.Text = "Salvar";
            CarregarDataGridporIdPessoa(pessoaescolhida.Id_Pessoa);

        }

        private void SearchDialog_Load(object sender, EventArgs e)
        {
            CarregarDatagrid(pessoaescolhida.Id_Pessoa);
        }
        private void SearchDialog_Shown(object sender, EventArgs e)
        {
            tbxCep.Focus();
        }


        // Métodos Botões
        private void BtnSair_Click(object sender, EventArgs e)
        {
            AdicionarEditarAtendimento.AtualizaEndereco = true;
            this.Close();
        }
        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            Boolean erroPreenchimento = true;
            CarregarControles();
            foreach (string item in controlesEndereco)
            {
                if (item == "")
                {
                    MessageBox.Show("Há campos obrigatórios não preenchidos.");
                    erroPreenchimento = true;
                    return;
                }
            }
            if (erroPreenchimento == true)
            {
                EnderecoNegocios enderecoNegocios = new EnderecoNegocios();
                Endereco endereco = new Endereco
                {

                    Pessoa = pessoaescolhida,
                    Id_Endereco = Convert.ToInt32(tbxIdEndereco.Text),
                    CEP = tbxCep.Text,
                    Logradouro = tbxRua.Text,
                    Numero = Convert.ToInt16(tbxNumero.Text),
                    Complemento = tbxComplemento.Text,
                    Bairro = tbxBairro.Text,
                    Cidade = tbxCidade.Text,
                    Estado = cbxEstado.Text,
                    UF = cbxEstado.SelectedValue.ToString(),
                    Usuario = LoginNegocios.UsuarioLogadoGetSet
                };

                string retorno = enderecoNegocios.AtualizarporId(endereco);

                try
                {
                    int idEndereco = Convert.ToInt32(retorno);
                    Endereco enderecoCadastrado = enderecoNegocios.ConsultarPorId(idEndereco)[0];
                    MessageBox.Show("Cadastro de endereço atualizado com sucesso!");
                    CarregarDataGridporIdPessoa(pessoaescolhida.Id_Pessoa);
                    Atualizarcampos(enderecoCadastrado);
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro ao atualizar. Detalhes: " + retorno);
                }
            }
        }
        private void BtnSearchCep_Click(object sender, EventArgs e)
        {
            EnderecoNegocios enderecoNegocios = new EnderecoNegocios();
            EnderecoGeralColecao enderecoGeralColecao = enderecoNegocios.ConsultarPorCep(Convert.ToInt32(tbxCep.Text));

            if (enderecoGeralColecao.Count > 0)
            {
                tbxRua.Text = enderecoGeralColecao[0].Rua;
                tbxBairro.Text = enderecoGeralColecao[0].Bairro;
                tbxCidade.Text = enderecoGeralColecao[0].Cidade;
                CarregarComboBox(enderecoGeralColecao[0].Estado);
            }
        }
        private void BtnNovo_Click(object sender, EventArgs e)
        {
            if (btnNovo.Text == "Novo")
            {
                ClearTextBoxes(this.Controls);
                btnNovo.Text = "Salvar";
            }
            else if (btnNovo.Text == "Salvar")
            {
                Boolean erroPreenchimento = true;
                CarregarControles();
                foreach (string item in controlesEndereco)
                {
                    if (item == "")
                    {
                        MessageBox.Show("Há campos obrigatórios não preenchidos.");
                        erroPreenchimento = true;
                        return;
                    }
                }
                if (erroPreenchimento == true)
                {
                    EnderecoNegocios enderecoNegocios = new EnderecoNegocios();
                    Endereco endereco = new Endereco
                    {

                        Pessoa = pessoaescolhida,
                        CEP = tbxCep.Text,
                        Logradouro = tbxRua.Text,
                        Numero = Convert.ToInt16(tbxNumero.Text),
                        Complemento = tbxComplemento.Text,
                        Bairro = tbxBairro.Text,
                        Cidade = tbxCidade.Text,
                        Estado = cbxEstado.Text,
                        UF = cbxEstado.SelectedValue.ToString(),
                        Usuario = LoginNegocios.UsuarioLogadoGetSet
                    };

                    string retorno = enderecoNegocios.Inserir(endereco);

                    try
                    {
                        int idEndereco = Convert.ToInt32(retorno);
                        Endereco enderecoCadastrado = enderecoNegocios.ConsultarPorId(idEndereco)[0];
                        MessageBox.Show("Cadastro de endereço inserido com sucesso!");
                        CarregarDataGridporIdPessoa(pessoaescolhida.Id_Pessoa);
                        Atualizarcampos(enderecoCadastrado);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Erro ao cadastrar. Detalhes: " + retorno);
                    }
                }

            }

        }
        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            EnderecoNegocios enderecoNegocios = new EnderecoNegocios();
            if (tbxIdEndereco.Text == "")
            {
                MessageBox.Show("Nenhum cadastro selecionado.");
                return;
            }
            DialogResult resultado = MessageBox.Show("Tem certeza?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.No)
            {
                return;
            }
            Endereco enderecoParaExclusao = new Endereco();
            enderecoParaExclusao.Id_Endereco = Convert.ToInt32(tbxIdEndereco.Text);
            enderecoParaExclusao.Usuario = LoginNegocios.UsuarioLogadoGetSet;
            string retorno = enderecoNegocios.Excluir(enderecoParaExclusao);

            try
            {
                int idEndereco = Convert.ToInt32(retorno);
                MessageBox.Show("Cadastro excluído com sucesso!");
                CarregarDatagrid(pessoaescolhida.Id_Pessoa);
                tbxIdPessoa.Text = Convert.ToString(pessoaescolhida.Id_Pessoa);
                tbxNomePessoa.Text = pessoaescolhida.Nome + " " + pessoaescolhida.Sobrenome;
                enderecoSelecionado = new Endereco();
                ClearTextBoxes(this.Controls);
                btnNovo.Text = "Salvar";
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao excluir. Detalhes: " + retorno);
            }
        }
        private void BtnSelecionar_Click(object sender, EventArgs e)
        {
            AdicionarEditarAtendimento.EnderecoSelecionado = enderecoSelecionado.Id_Endereco;
            AdicionarEditarAtendimento.AtualizaEndereco = true;
            this.Close();
        }


        //Métodos Personalizados
        private void Atualizarcampos(Endereco endereco)
        {
            //EnderecoNegocios enderecoNegocios = new EnderecoNegocios();
            //EnderecoColecao enderecoColecao = enderecoNegocios.ConsultarPorId(Convert.ToInt32(dataGrid.Rows[dataGrid.CurrentRow.Index].Cells[0].Value));
            //enderecoSelecionado = enderecoColecao[0];

            CarregarEnderecoSelecionado(endereco);
            btnAtualizar.Enabled = true;
            btnNovo.Text = "Novo";
        }
        private void CarregarEnderecoSelecionado(Endereco endereco)
        {
            tbxIdEndereco.Text = endereco.Id_Endereco.ToString();
            tbxCep.Text = endereco.CEP;
            tbxRua.Text = endereco.Logradouro;
            tbxNumero.Text = Convert.ToString(endereco.Numero);
            tbxComplemento.Text = endereco.Complemento;
            tbxBairro.Text = endereco.Bairro;
            tbxCidade.Text = endereco.Cidade;
            CarregarComboBox(endereco.Estado);
        }
        private void CarregarControles()
        {
            controlesEndereco[0] = tbxBairro.Text;
            controlesEndereco[1] = tbxRua.Text;
            controlesEndereco[2] = tbxNumero.Text;
            controlesEndereco[3] = tbxBairro.Text;
            controlesEndereco[4] = tbxCidade.Text;
            controlesEndereco[5] = cbxEstado.Text;
            controlesEndereco[6] = tbxCep.Text;
        }


        //Manipulação de controles
        private void ClearTextBoxes(Control.ControlCollection ctrlCollection)
        {
            foreach (Control ctrl in ctrlCollection)
            {
                if (ctrl is TextBoxBase)
                {
                    ctrl.Text = String.Empty;
                    ctrl.Enabled = true;
                }
                else
                {
                    ClearTextBoxes(ctrl.Controls);
                }
            }
            tbxIdPessoa.Text = Convert.ToString(pessoaescolhida.Id_Pessoa);
            tbxNomePessoa.Text = pessoaescolhida.Nome + " " + pessoaescolhida.Sobrenome;
        }
        private void DisableAllConstrols(Control.ControlCollection ctrlCollection)
        {
            foreach (Control ctrl in ctrlCollection)
            {
                if (ctrl is TextBoxBase)
                {
                    ctrl.Enabled = false;
                }
                else
                {
                    DisableAllConstrols(ctrl.Controls);
                }
            }
        }
        private void EnableAllConstrols(Control.ControlCollection ctrlCollection)
        {
            foreach (Control ctrl in ctrlCollection)
            {
                if (ctrl is TextBoxBase)
                {
                    ctrl.Enabled = true;
                }
                else
                {
                    EnableAllConstrols(ctrl.Controls);
                }
            }
        }
        private void tbxCep_Click(object sender, EventArgs e)
        {
            ClearTextBoxes(this.Controls);
        }



        //Métodos Datagrid
        private void CarregarDatagrid(int value)
        {
            EnderecoNegocios enderecoNegocios = new EnderecoNegocios();
            EnderecoColecao enderecoColecao = enderecoNegocios.ConsultarPorIdPessoa(value);
            dataGrid.DataSource = null;
            dataGrid.DataSource = enderecoColecao;
            dataGrid.Update();
            dataGrid.Refresh();
        }
        private void DataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            EnderecoNegocios enderecoNegocios = new EnderecoNegocios();
            EnderecoColecao enderecoColecao = enderecoNegocios.ConsultarPorId(Convert.ToInt32(dataGrid.Rows[dataGrid.CurrentRow.Index].Cells[0].Value));
            enderecoSelecionado = enderecoColecao[0];
            Atualizarcampos(enderecoSelecionado);
        }
        private void CarregarDataGridporIdPessoa(int idPessoa)
        {
            EnderecoNegocios enderecoNegocios = new EnderecoNegocios();
            EnderecoColecao enderecos = enderecoNegocios.ConsultarPorIdPessoa(idPessoa);

            dataGrid.DataSource = null;
            dataGrid.DataSource = enderecos;
            dataGrid.Update();
            dataGrid.Refresh();
        }


        //Método ComboBox
        private void CarregarComboBox(string nome)
        {
            EnderecoNegocios enderecoNegocios = new EnderecoNegocios();
            EstadoColecao estados = enderecoNegocios.ConsultarEstadoPorNome(nome);

            cbxEstado.DataSource = null;
            cbxEstado.DataSource = estados;
            cbxEstado.DisplayMember = "NOME_ESTADO";
            cbxEstado.ValueMember = "ABREVIACAO";
            cbxEstado.SelectedIndex = 0;
        }
        private void cbxEstado_Click(object sender, EventArgs e)
        {
            CarregarComboBox("");
        }


        //Método Time
        private void Verifica_Tick(object sender, EventArgs e)
        {
            if (tbxIdEndereco.Text != "")
            {
                BtnSelecionar.Enabled = true;
            }
            else
            {
                BtnSelecionar.Enabled = false;
            }
        }
    }
}
