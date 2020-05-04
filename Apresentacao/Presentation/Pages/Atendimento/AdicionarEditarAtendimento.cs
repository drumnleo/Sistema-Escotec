using System;
using System.Windows.Forms;
using ObjetoTransferencia;
using Negocios;

namespace Apresentacao.Presentation.Pages
{
    public partial class AdicionarEditarAtendimento : UserControl
    {
        Pessoa pessaSelecionada = new Pessoa();

        public AdicionarEditarAtendimento()
        {
            if (Program.IsInDesignMode()) return;
            InitializeComponent();
        }
        private void AdicionarEditarAtendimento_Load(object sender, EventArgs e)
        {
            CarregarComboBoxTipoAtendimento();
            CarregarComboBoxMarketing();
            CarregarComboBoxTipoTelefone();
            BtnTelSalvar.ButtonText = "Salvar";
            
        }

        //Propriedades publicas
        public static Pessoa PessoaGetSet;
        public static Boolean AtualizaPessoa = false;
        public static EnderecoColecao EnderecoGetSet;
        public static Boolean AtualizaEndereco = false;
        public static int EnderecoSelecionado = 0;
        public static TelefoneColecao TelefoneGetSet;
        public static Boolean AtualizaTel = false;
        public static int ContaTel = 0;
        private static TipoTelefoneColecao TipoTelefoneGetSet1;
        private static int TipotelSel1 = 0;
        private static TipoTelefoneColecao TipoTelefoneGetSet2;
        private static int TipotelSel2 = 0;



        //Métodos Botões
        private void btnSearchPessoa_Click(object sender, EventArgs e)
        {
            new Popup.transparentBg(new Popup.SearchDialogs.SearchDialog_Pessoa_Atendimento());
        }
        private void btnSearchEnd_Click(object sender, EventArgs e)
        {
            if (PessoaGetSet != null)
            {
                new Popup.transparentBg(new Popup.SearchDialogs.SearchDialog_Endereco(PessoaGetSet));
            }
            else
            {
                MessageBox.Show("Selecione primeiramente o cadastro de Pessoa");
            }

        }
        private void btnSearchOrc_Click(object sender, EventArgs e)
        {

        }



        //Métodos Personalizados
        private void CamposPessoa()
        {
            tbxIdPessoa.Text = PessoaGetSet.Id_Pessoa.ToString();
            tbxCpf.Text = PessoaGetSet.CPF;
            tbxNome.Text = PessoaGetSet.Nome + " " + PessoaGetSet.Sobrenome;
            tbxEmail.Text = PessoaGetSet.Email;
        }
        private void CamposEndereco()
        {
            if (EnderecoSelecionado > 0)
            {
                int index = EnderecoGetSet.FindIndex(x => x.Id_Endereco == EnderecoSelecionado);
                tbxIdEndereco.Text = EnderecoGetSet[index].Id_Endereco.ToString();
                tbxCep.Text = EnderecoGetSet[index].CEP;
            }
            else if (EnderecoGetSet == null)
            {
                tbxIdEndereco.Text = "";
                tbxCep.Text = "";
            }
            else
            {
                tbxIdEndereco.Text = EnderecoGetSet[EnderecoSelecionado].Id_Endereco.ToString();
                tbxCep.Text = EnderecoGetSet[EnderecoSelecionado].CEP;
            }
            
        }
        private void CamposTelefone1()
        {
            if (TelefoneGetSet.Count == 1)
            {
                TbxIdTel1.Text = TelefoneGetSet[0].Id_Telefone.ToString();
                TbxTel1.Text = TelefoneGetSet[0].Num_Telefone;
                TbxRamal1.Text = TelefoneGetSet[0].Ramal.ToString();
                int index = CbxTipoTel1.Items.IndexOf(TelefoneGetSet[0].Id_Telefone);
                CbxTipoTel1.SelectedIndex = index;
            }
            else
            {
                TbxIdTel1.Text = "";
                TbxTel1.Text = "";
                TbxRamal1.Text = "";
                CarregarComboBoxTipoTelefone();
            }
            
        }
        private void CamposTelefone2()
        {
            if (TelefoneGetSet.Count == 2)
            {
                TbxTel2.Text = TelefoneGetSet[1].Id_Telefone.ToString();
                TbxTel2.Text = TelefoneGetSet[1].Num_Telefone;
                TbxRamal2.Text = TelefoneGetSet[1].Ramal.ToString();
                int index = CbxTipoTel1.Items.IndexOf(TelefoneGetSet[1].Id_Telefone);
                CbxTipoTel2.SelectedIndex = index;
            }
            else
            {
                TbxIdTel2.Text = "";
                TbxTel2.Text = "";
                TbxRamal2.Text = "";
                CarregarComboBoxTipoTelefone();
            }
        }
        private void CarregarTel1()
        {
            if (TbxTel1.Text.Length > 9 && TbxTel1.Text.Length < 12)
            {
                if(TbxRamal1.Text != "")
                {
                    TelefoneGetSet = new TelefoneColecao();
                    Telefone telefone0 = new Telefone();
                    telefone0.Pessoa = PessoaGetSet;
                    telefone0.Num_Telefone = TbxTel1.Text;
                    telefone0.Ramal = Convert.ToInt16(TbxRamal1.Text);
                    telefone0.TipoTelefone = TipoTelefoneGetSet1[TipotelSel1];
                    telefone0.Usuario = LoginNegocios.UsuarioLogadoGetSet;
                    TelefoneGetSet.Add(telefone0);
                }
                else
                {
                    TelefoneGetSet = new TelefoneColecao();
                    Telefone telefone1 = new Telefone();
                    telefone1.Pessoa = PessoaGetSet;
                    telefone1.Num_Telefone = TbxTel1.Text;
                    telefone1.Ramal = Convert.ToInt16(0);
                    telefone1.TipoTelefone = TipoTelefoneGetSet1[TipotelSel1];
                    telefone1.Usuario = LoginNegocios.UsuarioLogadoGetSet;
                    TelefoneGetSet.Add(telefone1);
                }
            }
        }
        private void CarregarTel2()
        {
            if (TbxTel2.Text.Length > 9 && TbxTel2.Text.Length < 12)
            {
                if (TbxRamal2.Text != "")
                {
                    Telefone telefone = new Telefone();
                    telefone.Pessoa = PessoaGetSet;
                    telefone.Num_Telefone = TbxTel2.Text;
                    telefone.Ramal = Convert.ToInt16(TbxRamal2.Text);
                    telefone.TipoTelefone = TipoTelefoneGetSet2[TipotelSel2];
                    telefone.Usuario = LoginNegocios.UsuarioLogadoGetSet;
                    TelefoneGetSet.Add(telefone);
                }
                else
                {
                    Telefone telefone = new Telefone();
                    telefone.Pessoa = PessoaGetSet;
                    telefone.Num_Telefone = TbxTel2.Text;
                    telefone.Ramal = Convert.ToInt16(0);
                    telefone.TipoTelefone = TipoTelefoneGetSet2[TipotelSel2];
                    telefone.Usuario = LoginNegocios.UsuarioLogadoGetSet;
                    TelefoneGetSet.Add(telefone);
                }
            }
        }
        private void CarregaTels()
        {
            CarregarTel1();
            CarregarTel2();
        }





        //Metodos Controles
        private void CarregarComboBoxTipoAtendimento()
        {
            TipoAtendimentoNegocios tipoAtendimentoNegocios = new TipoAtendimentoNegocios();

            TipoAtendimentoColecao tipoAtendimentos = tipoAtendimentoNegocios.ConsultarPorDescricao("");

            cbxTipoAtendimento.DataSource = null;
            cbxTipoAtendimento.DataSource = tipoAtendimentos;
            cbxTipoAtendimento.DisplayMember = "DESCRICAO";
            cbxTipoAtendimento.ValueMember = "ID_TIPO_ATENDIMENTO";
        }
        private void CarregarComboBoxMarketing()
        {
            MarketingNegocios marketingNegocios = new MarketingNegocios();

            MarketingColecao marketingColecao = marketingNegocios.ConsultarPorDescricao("");

            cbxMarketing.DataSource = null;
            cbxMarketing.DataSource = marketingColecao;
            cbxMarketing.DisplayMember = "DESCRICAO";
            cbxMarketing.ValueMember = "ID_MKT";
            cbxMarketing.SelectedIndex = 0;
        }
        private void CarregarComboBoxTipoTelefone()
        {
            TelefoneNegocios telefoneNegocios = new TelefoneNegocios();

            TipoTelefoneGetSet1 = telefoneNegocios.ConsultartipoPorDescricao("");
            TipoTelefoneGetSet2 = telefoneNegocios.ConsultartipoPorDescricao("");

            CbxTipoTel1.DataSource = null;
            CbxTipoTel1.DataSource = TipoTelefoneGetSet1;
            CbxTipoTel1.DisplayMember = "DESCRICAO";
            CbxTipoTel1.ValueMember = "ID_TIPO_TELEFONE";
            CbxTipoTel1.SelectedIndex = 0;

            CbxTipoTel2.DataSource = null;
            CbxTipoTel2.DataSource = TipoTelefoneGetSet2;
            CbxTipoTel2.DisplayMember = "DESCRICAO";
            CbxTipoTel2.ValueMember = "ID_TIPO_TELEFONE";
            CbxTipoTel2.SelectedIndex = 0;
        }


        //Métodos Timers
        private void TimerPessoa_Tick(object sender, EventArgs e)
        {
            if (AtualizaPessoa == true)
            {
                CamposPessoa();
                AtualizaPessoa = false;
                AtualizaEndereco = true;
                AtualizaTel = true;
            }
        }
        private void TimerEnd_Tick(object sender, EventArgs e)
        {
            if (AtualizaEndereco == true)
            {
                EnderecoNegocios enderecoNegocios = new EnderecoNegocios();
                EnderecoColecao enderecoColecao = enderecoNegocios.ConsultarPorIdPessoa(PessoaGetSet.Id_Pessoa);
                if (enderecoColecao.Count > 0)
                {
                    EnderecoGetSet = null;
                    EnderecoGetSet = enderecoColecao;
                    CamposEndereco();
                    AtualizaEndereco = false;
                }
                else
                {
                    EnderecoGetSet = null;
                    CamposEndereco();
                }
            }
        }
        private void TimerTel_Tick(object sender, EventArgs e)
        {
            if (AtualizaTel == true)
            {
                TelefoneNegocios telefoneNegocios = new TelefoneNegocios();
                TelefoneColecao telefones = telefoneNegocios.ConsultarPorPessoa(PessoaGetSet.Id_Pessoa);
                TelefoneGetSet = null;
                TelefoneGetSet = telefones;
                if ((TelefoneGetSet.Count == 1))
                {
                    CamposTelefone1();
                }
                if (TelefoneGetSet.Count == 2)
                {
                    CamposTelefone2();
                }
                AtualizaTel = false;
            }          
        }

        private void BtnTelSalvar_Click(object sender, EventArgs e)
        {
            if (BtnTelSalvar.ButtonText == "Salvar")
            {
                CarregaTels();
                if (TelefoneGetSet.Count == 1)
                {
                    TelefoneNegocios telefoneNegocios = new TelefoneNegocios();
                    string retorno = telefoneNegocios.Inserir(TelefoneGetSet[0]);

                    try
                    {
                        int idTelefone = Convert.ToInt32(retorno);
                        TelefoneGetSet = null;
                        TelefoneGetSet = telefoneNegocios.ConsultarPorPessoa(PessoaGetSet.Id_Pessoa);
                        MessageBox.Show("Cadastro de telefone inserido com sucesso!");
                        AtualizaTel = true;
                        BtnTelSalvar.Name = "Atualizar";
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Erro ao cadastrar. Detalhes: " + retorno);
                    }
                    
                }
                if (TelefoneGetSet.Count == 2)
                {
                    TelefoneNegocios telefoneNegocios = new TelefoneNegocios();
                    string retorno1 = telefoneNegocios.Inserir(TelefoneGetSet[0]);
                    string retorno2 = telefoneNegocios.Inserir(TelefoneGetSet[1]);

                    try
                    {
                        int idTelefone1 = Convert.ToInt32(retorno1);
                        int idTelefone2 = Convert.ToInt32(retorno2);
                        TelefoneGetSet = null;
                        TelefoneGetSet = telefoneNegocios.ConsultarPorPessoa(PessoaGetSet.Id_Pessoa);
                        MessageBox.Show("Cadastro de telefone inserido com sucesso!");
                        AtualizaTel = true;
                        BtnTelSalvar.Name = "Atualizar";
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Erro ao cadastrar. Detalhes: Ret1: " + retorno1 + ". Ret2: " + retorno2);
                    }
                }
                else
                {
                    MessageBox.Show("Verifique os valores digitados em Telefone e Ramal.");
                }

            }
        }

        private void TbxRamal1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                MessageBox.Show("este campo aceita somente numero");
            }
        }

        private void TbxRamal2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                MessageBox.Show("este campo aceita somente numero");
            }
        }

        private void CbxTipoTel1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TipotelSel1 = CbxTipoTel1.SelectedIndex;
        }

        private void CbxTipoTel2_SelectedIndexChanged(object sender, EventArgs e)
        {
            TipotelSel2 = CbxTipoTel1.SelectedIndex;
        }
    }
}
