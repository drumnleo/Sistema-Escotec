using System;
using System.Windows.Forms;
using ObjetoTransferencia;
using Negocios;
using System.Data;
using System.Reflection;
using Utilities.BunifuButton.Transitions;

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
            CarregarComboBoxPromocao();
            CarregarComboBoxCurso();
            BtnTel1Salvar.ButtonText = "Salvar";
            dtpValidade.Value = DateTime.Now;
            tbxUsuarioGera.Text = LoginNegocios.UsuarioLogadoGetSet.Id_Usuario.ToString(); ;
            dataGrid.AutoGenerateColumns = false;
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
        private static TipoAtendimentoColecao TipoAtendimentoGetSet;
        private static int TipoAtendimentoSel = 0;
        private static MarketingColecao MarketingGetSet;
        private static int MarketingSel = 0;
        private static PromocaoValorColecao PromocaoGetSet;
        private static int PromoSel = 0;
        private static TurmaColecao TurmaGetSet;
        private static int turmaSel = 0;
        public static Atendimento AtendimentoGetset;
        public static Boolean AtualizaAtendimento = false;
        public static Orcamento OrcamentoGetSet;
        public static Boolean AtualizaOrcamento = false;
        public static Curso CursoSelecionado;
        private static TurmaOrcamentoColecao TurmaOrcamentoGetSet;
        private static int TurmaOrcSel = 0;
        private static Boolean AtualizaGridOrcamento = false;



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
        private void BtnTel1Salvar_Click(object sender, EventArgs e)
        {
            if (BtnTel1Salvar.ButtonText == "Salvar")
            {
                CarregaTels();
                if (TelefoneGetSet.Count > 0)
                {
                    TelefoneNegocios telefoneNegocios = new TelefoneNegocios();
                    string retorno = telefoneNegocios.Inserir(TelefoneGetSet[0]);

                    try
                    {
                        int idTelefone = Convert.ToInt32(retorno);
                        TelefoneGetSet = null;
                        TelefoneGetSet = telefoneNegocios.ConsultarPorPessoa(PessoaGetSet.Id_Pessoa);
                        MessageBox.Show("Cadastro de telefone 1 inserido com sucesso!");
                        AtualizaTel = true;
                        BtnTel1Salvar.Name = "Atualizar";
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Erro ao cadastrar. Detalhes: " + retorno);
                    }

                }
                else
                {
                    MessageBox.Show("Verifique os valores digitados em Telefone 1 e Ramal.");
                }
                
            }
            else if (BtnTel1Salvar.ButtonText == "Atualizar")
            {
                CarregaTels();
                if (TelefoneGetSet.Count > 0)
                {
                    TelefoneNegocios telefoneNegocios = new TelefoneNegocios();
                    TelefoneGetSet[0].Id_Telefone = Convert.ToInt32(TbxIdTel1.Text);
                    string retorno = telefoneNegocios.Atualizar(TelefoneGetSet[0]);

                    try
                    {
                        int idTelefone = Convert.ToInt32(retorno);
                        TelefoneGetSet = null;
                        TelefoneGetSet = telefoneNegocios.ConsultarPorPessoa(PessoaGetSet.Id_Pessoa);
                        MessageBox.Show("Cadastro de telefone 1 atualizado com sucesso!");
                        AtualizaTel = true;
                        BtnTel1Salvar.Name = "Atualizar";
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Erro ao cadastrar. Detalhes: " + retorno);
                    }
                }
                else
                {
                    MessageBox.Show("Verifique os valores digitados em Telefone 1 e Ramal.");
                }
            }
            CamposTelefone1();
        }
        private void BtnTel2Salvar_Click(object sender, EventArgs e)
        {
            CarregaTels();
            if (BtnTel2Salvar.ButtonText == "Salvar")
            {
                if (TelefoneGetSet.Count == 2)
                {
                    TelefoneNegocios telefoneNegocios = new TelefoneNegocios();
                    string retorno2 = telefoneNegocios.Inserir(TelefoneGetSet[1]);

                    try
                    {
                        int idTelefone2 = Convert.ToInt32(retorno2);
                        TelefoneGetSet = null;
                        TelefoneGetSet = telefoneNegocios.ConsultarPorPessoa(PessoaGetSet.Id_Pessoa);
                        MessageBox.Show("Cadastro de telefone 2 inserido com sucesso!");
                        AtualizaTel = true;
                        BtnTel2Salvar.Name = "Atualizar";
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Erro ao cadastrar. Detalhes: " + retorno2);
                    }
                }
                else
                {
                    MessageBox.Show("Verifique os valores digitados em Telefone 2 e Ramal.");
                }
            }
            else if (BtnTel2Salvar.ButtonText == "Atualizar")
            {
                CarregaTels();
                if (TelefoneGetSet.Count == 2)
                {
                    TelefoneNegocios telefoneNegocios = new TelefoneNegocios();
                    TelefoneGetSet[1].Id_Telefone = Convert.ToInt32(TbxIdTel2.Text);
                    string retorno = telefoneNegocios.Atualizar(TelefoneGetSet[1]);

                    try
                    {
                        int idTelefone = Convert.ToInt32(retorno);
                        TelefoneGetSet = null;
                        TelefoneGetSet = telefoneNegocios.ConsultarPorPessoa(PessoaGetSet.Id_Pessoa);
                        MessageBox.Show("Cadastro de telefone 2 atualizado com sucesso!");
                        AtualizaTel = true;
                        BtnTel1Salvar.Name = "Atualizar";
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Erro ao cadastrar. Detalhes: " + retorno);
                    }
                }
            }
            CamposTelefone2();
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (TbxIdAtend.Text == "")
            {
                AtendimentoNegocios atendimentoNegocios = new AtendimentoNegocios();

                Atendimento atendimento = GeraAtetndimento();

                string retorno = atendimentoNegocios.Inserir(atendimento);

                try
                {
                    int idAtendimento = Convert.ToInt32(retorno);
                    AtendimentoGetset = atendimentoNegocios.ConsultarPorId(idAtendimento)[0];
                    TbxIdAtend.Text = AtendimentoGetset.Id_Atendimento.ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro: Detalhes: " + retorno);
                }
            }

            if (tbxIdOrc.Text == "")
            {
                OrcamentoNegocios orcamentoNegocios = new OrcamentoNegocios();

                Orcamento orcamento = GeraOrcamento();

                string retornoOrc = orcamentoNegocios.Inserir(orcamento);

                try
                {
                    int idOrcamento = Convert.ToInt32(retornoOrc);
                    OrcamentoGetSet = orcamentoNegocios.ConsultarPorIdOrcamento(idOrcamento)[0];
                    tbxIdOrc.Text = OrcamentoGetSet.Id_Orcamento.ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro: Detalhes: " + retornoOrc);
                }
            }

            TurmaOrcamentoNegocios turmaOrcamentoNegocios = new TurmaOrcamentoNegocios();

            TurmaOrcamento turmaOrcamento = GeraTOrcamento();

            string retornotOrcamento = turmaOrcamentoNegocios.Inserir(turmaOrcamento);

            try
            {
                int idTOrcamento = Convert.ToInt32(retornotOrcamento);
                TurmaOrcamentoGetSet = turmaOrcamentoNegocios.ConsultarPorOrcamento(Convert.ToInt32(tbxIdOrc.Text));
                dataGrid.DataSource = null;
                dataGrid.DataSource = TurmaOrcamentoGetSet;
                dataGrid.Update();
                dataGrid.Refresh();
            }
            catch (Exception)
            {
                MessageBox.Show("Erro: Detalhes: " + retornotOrcamento);
            }
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            PessoaGetSet = null;
            AtendimentoGetset = null;
            OrcamentoGetSet = null;
            EnderecoGetSet = null;
            TelefoneGetSet = null;
            TipoAtendimentoGetSet = null;
            MarketingGetSet = null;
            TurmaGetSet = null;
            PromocaoGetSet = null;
            TurmaOrcamentoGetSet = null;


            ClearTextBoxes(this.Controls);

            CarregarComboBoxTipoAtendimento();
            CarregarComboBoxMarketing();
            CarregarComboBoxTipoTelefone();
            CarregarComboBoxPromocao();
            BtnTel1Salvar.ButtonText = "Salvar";
            dtpValidade.Value = DateTime.Now;
            tbxUsuarioGera.Text = LoginNegocios.UsuarioLogadoGetSet.Id_Usuario.ToString(); ;
            dataGrid.AutoGenerateColumns = false;
            dataGrid.DataSource = null;
            dataGrid.Update();
            dataGrid.Refresh();
        }

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
        }
        private void BtnSearchAtendimento_Click(object sender, EventArgs e)
        {
            new Popup.transparentBg(new Popup.SearchDialogs.SearchDialog_Atendimento());
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
            if (TelefoneGetSet.Count > 0)
            {
                TbxIdTel1.Text = TelefoneGetSet[0].Id_Telefone.ToString();
                TbxTel1.Text = TelefoneGetSet[0].DDD.ToString() + TelefoneGetSet[0].Num_Telefone;
                TbxRamal1.Text = TelefoneGetSet[0].Ramal.ToString();
                CbxTipoTel1.SelectedIndex = 0;
                CbxTipoTel1.Refresh();
                BtnTel1Salvar.ButtonText = "Atualizar";
            }
            else
            {
                TbxIdTel1.Text = "";
                TbxTel1.Text = "";
                TbxRamal1.Text = "";
                CarregarComboBoxTipoTelefone();
                BtnTel1Salvar.ButtonText = "Salvar";
            }
            
        }
        private void CamposTelefone2()
        {
            if (TelefoneGetSet.Count == 2)
            {
                TbxIdTel2.Text = TelefoneGetSet[1].Id_Telefone.ToString();
                TbxTel2.Text = TelefoneGetSet[1].DDD.ToString() + TelefoneGetSet[1].Num_Telefone;
                TbxRamal2.Text = TelefoneGetSet[1].Ramal.ToString();
                CbxTipoTel2.SelectedIndex = 1;
                CbxTipoTel2.Refresh();
                BtnTel2Salvar.ButtonText = "Atualizar";
            }
            else
            {
                TbxIdTel2.Text = "";
                TbxTel2.Text = "";
                TbxRamal2.Text = "";
                CarregarComboBoxTipoTelefone();
                BtnTel2Salvar.ButtonText = "Salvar";
            }
        }
        private void CamposAtendimento()
        {
            TbxIdAtend.Text = AtendimentoGetset.Id_Atendimento.ToString();
            TipoAtendimentoNegocios tipoAtendimentoNegocios = new TipoAtendimentoNegocios();
            TipoAtendimentoGetSet = new TipoAtendimentoColecao();
            TipoAtendimentoGetSet = tipoAtendimentoNegocios.ConsultarPorId(AtendimentoGetset.TipoAtendimento.Id_Tipo_Atendimento);
            cbxTipoAtendimento.DataSource = null;
            cbxTipoAtendimento.DataSource = TipoAtendimentoGetSet;
            cbxTipoAtendimento.DisplayMember = "DESCRICAO";
            cbxTipoAtendimento.ValueMember = "ID_TIPO_ATENDIMENTO";
            cbxTipoAtendimento.SelectedIndex = 0;

            MarketingNegocios marketingNegocios = new MarketingNegocios();
            MarketingGetSet = new MarketingColecao();
            MarketingGetSet = marketingNegocios.ConsultarPorId(AtendimentoGetset.Marketing.Id_Mkt);
            cbxMarketing.DataSource = null;
            cbxMarketing.DataSource = MarketingGetSet;
            cbxMarketing.DisplayMember = "DESCRICAO";
            cbxMarketing.ValueMember = "ID_MKT";
            cbxMarketing.SelectedIndex = 0;
        }
        private void CamposOrcamento()
        {
            if (OrcamentoGetSet != null)
            {
                tbxIdOrc.Text = OrcamentoGetSet.Id_Orcamento.ToString();
                if (OrcamentoGetSet.Validade_Orcamento.ToString() != "01 / 01 / 0001 00:00:00")
                {
                    dtpValidade.Value = OrcamentoGetSet.Validade_Orcamento;
                }            
                tbxUsuarioGera.Text = OrcamentoGetSet.UsuarioGeraOrcamento.Id_Usuario.ToString();
                cboxAprovado.Checked = OrcamentoGetSet.Aprovado;
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
                    telefone0.DDD = Convert.ToInt16(TbxTel1.Text.Substring(0,2));
                    telefone0.Num_Telefone = TbxTel1.Text.Substring(2);
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
                    telefone1.DDD = Convert.ToInt16(TbxTel1.Text.Substring(0, 2));
                    telefone1.Num_Telefone = TbxTel1.Text.Substring(2);
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
                    telefone.DDD = Convert.ToInt16(TbxTel2.Text.Substring(0, 2));
                    telefone.Num_Telefone = TbxTel2.Text.Substring(2);
                    telefone.Ramal = Convert.ToInt16(TbxRamal2.Text);
                    telefone.TipoTelefone = TipoTelefoneGetSet2[TipotelSel2];
                    telefone.Usuario = LoginNegocios.UsuarioLogadoGetSet;
                    TelefoneGetSet.Add(telefone);
                }
                else
                {
                    Telefone telefone = new Telefone();
                    telefone.Pessoa = PessoaGetSet;
                    telefone.DDD = Convert.ToInt16(TbxTel2.Text.Substring(0, 2));
                    telefone.Num_Telefone = TbxTel2.Text.Substring(2);
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
        private Atendimento GeraAtetndimento()
        {
            Atendimento atendimento = new Atendimento();
            atendimento.TipoAtendimento = TipoAtendimentoGetSet[TipoAtendimentoSel];
            atendimento.Pessoa = PessoaGetSet;
            atendimento.Marketing = MarketingGetSet[MarketingSel];
            atendimento.Receptivo = cboxReceptivo.Checked ? 'S' : 'N';
            atendimento.Observacao = rtbxObsOrc.Text;
            atendimento.Usuario = LoginNegocios.UsuarioLogadoGetSet;

            return atendimento;
        }
        private Orcamento GeraOrcamento()
        {
            Orcamento orcamento = new Orcamento();
            orcamento.Atendimento = AtendimentoGetset;
            orcamento.Validade_Orcamento = dtpValidade.Value;
            orcamento.Usuario_Cad_Alt = LoginNegocios.UsuarioLogadoGetSet;

            return orcamento;
        }
        private TurmaOrcamento GeraTOrcamento()
        {
            TurmaOrcamento tOrcamento = new TurmaOrcamento();
            tOrcamento.Orcamento = OrcamentoGetSet;
            tOrcamento.Turma = TurmaGetSet[turmaSel];
            tOrcamento.PromocaoValor = PromocaoGetSet[PromoSel];
            tOrcamento.Usuario = LoginNegocios.UsuarioLogadoGetSet;

            return tOrcamento;
        }



        //Metodos Controles
        private void CarregarComboBoxTipoAtendimento()
        {
            TipoAtendimentoNegocios tipoAtendimentoNegocios = new TipoAtendimentoNegocios();

            TipoAtendimentoGetSet = tipoAtendimentoNegocios.ConsultarPorDescricao("");

            cbxTipoAtendimento.DataSource = null;
            cbxTipoAtendimento.DataSource = TipoAtendimentoGetSet;
            cbxTipoAtendimento.DisplayMember = "DESCRICAO";
            cbxTipoAtendimento.ValueMember = "ID_TIPO_ATENDIMENTO";
        }
        private void CarregarComboBoxMarketing()
        {
            MarketingNegocios marketingNegocios = new MarketingNegocios();

            MarketingGetSet = marketingNegocios.ConsultarPorDescricao("");

            cbxMarketing.DataSource = null;
            cbxMarketing.DataSource = MarketingGetSet;
            cbxMarketing.DisplayMember = "DESCRICAO";
            cbxMarketing.ValueMember = "ID_MKT";
            cbxMarketing.SelectedIndex = 0;
        }
        private void CarregarComboBoxPromocao()
        {
            PromocaoNegocios promocaoNegocios = new PromocaoNegocios();

            PromocaoGetSet = promocaoNegocios.ConsultarPorNome("");

            cbxPromocao.DataSource = null;
            cbxPromocao.DataSource = PromocaoGetSet;
            cbxPromocao.DisplayMember = "NOME_PROMOCAO";
            cbxPromocao.ValueMember = "ID_PROMOCAO_VALOR";
            cbxPromocao.SelectedIndex = 0;
        }
        private void CarregarComboBoxCurso()
        {
            CursoNegocios cursoNegocios = new CursoNegocios();

            CursoColecao cursoColecao = cursoNegocios.ConsultarPorNome("");

            CbxCurso.DataSource = null;
            CbxCurso.DataSource = cursoColecao;
            CbxCurso.DisplayMember = "NOME";
            CbxCurso.ValueMember = "ID_CURSO";
            CbxCurso.SelectedIndex = 0;
        }
        private void CarregarComboBoxTurma(int idCurso)
        {
            if (idCurso > 0)
            {
                TurmaNegocios turmaNegocios = new TurmaNegocios();

                TurmaGetSet = turmaNegocios.ConsultarPorCurso(idCurso);

                cbxTurma.DataSource = null;
                cbxTurma.DataSource = TurmaGetSet;
                cbxTurma.DisplayMember = "NOME_TURMA";
                cbxTurma.ValueMember = "ID_TURMA";
                cbxTurma.SelectedIndex = 0;
            }
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
        private void CbxCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedValue;
            bool parseOK = Int32.TryParse(CbxCurso.SelectedValue.ToString(), out selectedValue);

            if (selectedValue > 0)
            {
                CarregarComboBoxTurma(selectedValue);
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
        private void cbxPromocao_SelectedIndexChanged(object sender, EventArgs e)
        {
            PromoSel = cbxPromocao.SelectedIndex;
        }
        private void cbxTurma_SelectedIndexChanged(object sender, EventArgs e)
        {
            turmaSel = cbxTurma.SelectedIndex;
        }
        private void cbxTipoAtendimento_SelectedIndexChanged(object sender, EventArgs e)
        {
            TipoAtendimentoSel = cbxTipoAtendimento.SelectedIndex;
        }
        private void cbxMarketing_SelectedIndexChanged(object sender, EventArgs e)
        {
            MarketingSel = cbxMarketing.SelectedIndex;
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
                    if (enderecoColecao.Count > 1)
                    {
                        lblAvisoEndereco.Visible = true;
                    }
                    else
                    {
                        lblAvisoEndereco.Visible = false;
                    }
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
                TelefoneGetSet = null;
                TelefoneGetSet = telefoneNegocios.ConsultarPorPessoa(PessoaGetSet.Id_Pessoa);
                if ((TelefoneGetSet.Count == 1))
                {
                    CamposTelefone1();
                }
                if (TelefoneGetSet.Count == 2)
                {
                    CamposTelefone1();
                    CamposTelefone2();
                }
                if(TelefoneGetSet.Count == 0)
                {
                    CamposTelefone1();
                    CamposTelefone2();
                }
                AtualizaTel = false;
            }          
        }
        private void TimerAtend_Tick(object sender, EventArgs e)
        {
            if (AtualizaAtendimento == true)
            {
                PessoaNegocios pessoaNegocios = new PessoaNegocios();
                PessoaGetSet = pessoaNegocios.ConsultarPorId(AtendimentoGetset.Pessoa.Id_Pessoa);
                AtualizaPessoa = true;

                EnderecoNegocios enderecoNegocios = new EnderecoNegocios();
                EnderecoGetSet = enderecoNegocios.ConsultarPorIdPessoa(PessoaGetSet.Id_Pessoa);
                AtualizaEndereco = true;

                TelefoneNegocios telefoneNegocios = new TelefoneNegocios();
                TelefoneGetSet = telefoneNegocios.ConsultarPorPessoa(PessoaGetSet.Id_Pessoa);
                AtualizaTel = true;

                OrcamentoNegocios orcamentoNegocios = new OrcamentoNegocios();
                if(orcamentoNegocios.ConsultarPorIdAtendimento(AtendimentoGetset.Id_Atendimento).Count > 0)
                {
                    OrcamentoGetSet = orcamentoNegocios.ConsultarPorIdAtendimento(AtendimentoGetset.Id_Atendimento)[0];
                };

                AtualizaOrcamento = true;

                TurmaOrcamentoNegocios turmaOrcamentoNegocios = new TurmaOrcamentoNegocios();
                TurmaOrcamentoGetSet = turmaOrcamentoNegocios.ConsultarPorOrcamento(OrcamentoGetSet.Id_Orcamento);
                AtualizaGridOrcamento = true;
                dataGrid.DataSource = null;
                dataGrid.DataSource = TurmaOrcamentoGetSet;
                dataGrid.Update();
                dataGrid.Refresh();
                
                CamposAtendimento();

                AtualizaAtendimento = false;
            }
        }

        

        //DataGrid
        private void dataGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((dataGrid.Rows[e.RowIndex].DataBoundItem != null) && (dataGrid.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
            {
                e.Value = BindProperty(dataGrid.Rows[e.RowIndex].DataBoundItem, dataGrid.Columns[e.ColumnIndex].DataPropertyName);
            }
        }
        private string BindProperty(object property, string propertyName)
        {
            string retValue = "";
            if (propertyName.Contains("."))
            {
                PropertyInfo[] arrayProperties;
                string leftPropertyName;
                leftPropertyName = propertyName.Substring(0, propertyName.IndexOf("."));
                arrayProperties = property.GetType().GetProperties();
                foreach (PropertyInfo propertyInfo in arrayProperties)
                {
                    if (propertyInfo.Name == leftPropertyName)
                    {
                        retValue = BindProperty(
                          propertyInfo.GetValue(property, null),
                          propertyName.Substring(propertyName.IndexOf(".") + 1));
                        break;
                    }
                }
            }
            else
            {
                Type propertyType;
                PropertyInfo propertyInfo;
                propertyType = property.GetType();
                propertyInfo = propertyType.GetProperty(propertyName);
                retValue = propertyInfo.GetValue(property, null).ToString();
            }
            return retValue;
        }

        private void TimerOrc_Tick(object sender, EventArgs e)
        {
            CamposOrcamento();
        }
    }
}
