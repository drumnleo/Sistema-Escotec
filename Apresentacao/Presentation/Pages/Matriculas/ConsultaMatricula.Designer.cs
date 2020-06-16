namespace Apresentacao.Presentation.Pages
{
    partial class ConsultaMatricula
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaMatricula));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.container = new System.Windows.Forms.Panel();
            this.PanelNome = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.TbxSobrenome = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TbxNome = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.PanelCpf = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.TbxCpf = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.PanelUsuario = new System.Windows.Forms.Panel();
            this.CbxUsuario = new System.Windows.Forms.ComboBox();
            this.PanelTurma = new System.Windows.Forms.Panel();
            this.CbxTurma = new System.Windows.Forms.ComboBox();
            this.PanelData = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.DtInicio = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.DtFim = new System.Windows.Forms.DateTimePicker();
            this.CbxBusca = new System.Windows.Forms.ComboBox();
            this.btnSair = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnBuscar = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomTextbox1 = new Bunifu.Framework.BunifuCustomTextbox();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.dataGrid = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.RM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sobrenome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Turma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CURSO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Situacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario_Cad_Alt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matriculaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.container.SuspendLayout();
            this.PanelNome.SuspendLayout();
            this.PanelCpf.SuspendLayout();
            this.PanelUsuario.SuspendLayout();
            this.PanelTurma.SuspendLayout();
            this.PanelData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matriculaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.container.Controls.Add(this.PanelNome);
            this.container.Controls.Add(this.PanelCpf);
            this.container.Controls.Add(this.PanelUsuario);
            this.container.Controls.Add(this.PanelTurma);
            this.container.Controls.Add(this.PanelData);
            this.container.Controls.Add(this.CbxBusca);
            this.container.Controls.Add(this.btnSair);
            this.container.Controls.Add(this.btnBuscar);
            this.container.Controls.Add(this.bunifuCustomTextbox1);
            this.container.Controls.Add(this.bunifuSeparator2);
            this.container.Controls.Add(this.dataGrid);
            this.container.Location = new System.Drawing.Point(69, 5);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(805, 734);
            this.container.TabIndex = 0;
            // 
            // PanelNome
            // 
            this.PanelNome.Controls.Add(this.label4);
            this.PanelNome.Controls.Add(this.TbxSobrenome);
            this.PanelNome.Controls.Add(this.TbxNome);
            this.PanelNome.Controls.Add(this.label3);
            this.PanelNome.Location = new System.Drawing.Point(143, 36);
            this.PanelNome.Name = "PanelNome";
            this.PanelNome.Size = new System.Drawing.Size(543, 46);
            this.PanelNome.TabIndex = 197;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(5, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 229;
            this.label4.Text = "Nome:";
            // 
            // TbxSobrenome
            // 
            this.TbxSobrenome.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TbxSobrenome.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TbxSobrenome.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TbxSobrenome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TbxSobrenome.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.TbxSobrenome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TbxSobrenome.HintForeColor = System.Drawing.Color.Empty;
            this.TbxSobrenome.HintText = "";
            this.TbxSobrenome.isPassword = false;
            this.TbxSobrenome.LineFocusedColor = System.Drawing.Color.Blue;
            this.TbxSobrenome.LineIdleColor = System.Drawing.Color.Gray;
            this.TbxSobrenome.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TbxSobrenome.LineThickness = 2;
            this.TbxSobrenome.Location = new System.Drawing.Point(299, 4);
            this.TbxSobrenome.Margin = new System.Windows.Forms.Padding(4);
            this.TbxSobrenome.MaxLength = 32767;
            this.TbxSobrenome.Name = "TbxSobrenome";
            this.TbxSobrenome.Size = new System.Drawing.Size(228, 27);
            this.TbxSobrenome.TabIndex = 232;
            this.TbxSobrenome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TbxNome
            // 
            this.TbxNome.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TbxNome.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TbxNome.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TbxNome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TbxNome.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.TbxNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TbxNome.HintForeColor = System.Drawing.Color.Empty;
            this.TbxNome.HintText = "";
            this.TbxNome.isPassword = false;
            this.TbxNome.LineFocusedColor = System.Drawing.Color.Blue;
            this.TbxNome.LineIdleColor = System.Drawing.Color.Gray;
            this.TbxNome.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TbxNome.LineThickness = 2;
            this.TbxNome.Location = new System.Drawing.Point(51, 4);
            this.TbxNome.Margin = new System.Windows.Forms.Padding(4);
            this.TbxNome.MaxLength = 32767;
            this.TbxNome.Name = "TbxNome";
            this.TbxNome.Size = new System.Drawing.Size(148, 27);
            this.TbxNome.TabIndex = 231;
            this.TbxNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(206, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 230;
            this.label3.Text = "Sobrenome:";
            // 
            // PanelCpf
            // 
            this.PanelCpf.Controls.Add(this.label5);
            this.PanelCpf.Controls.Add(this.TbxCpf);
            this.PanelCpf.Location = new System.Drawing.Point(143, 36);
            this.PanelCpf.Name = "PanelCpf";
            this.PanelCpf.Size = new System.Drawing.Size(543, 46);
            this.PanelCpf.TabIndex = 233;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(5, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 17);
            this.label5.TabIndex = 229;
            this.label5.Text = "CPF:";
            // 
            // TbxCpf
            // 
            this.TbxCpf.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TbxCpf.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TbxCpf.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TbxCpf.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TbxCpf.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxCpf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TbxCpf.HintForeColor = System.Drawing.Color.Empty;
            this.TbxCpf.HintText = "";
            this.TbxCpf.isPassword = false;
            this.TbxCpf.LineFocusedColor = System.Drawing.Color.Blue;
            this.TbxCpf.LineIdleColor = System.Drawing.Color.Gray;
            this.TbxCpf.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TbxCpf.LineThickness = 2;
            this.TbxCpf.Location = new System.Drawing.Point(36, 4);
            this.TbxCpf.Margin = new System.Windows.Forms.Padding(4);
            this.TbxCpf.MaxLength = 32767;
            this.TbxCpf.Name = "TbxCpf";
            this.TbxCpf.Size = new System.Drawing.Size(210, 27);
            this.TbxCpf.TabIndex = 232;
            this.TbxCpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // PanelUsuario
            // 
            this.PanelUsuario.Controls.Add(this.CbxUsuario);
            this.PanelUsuario.Location = new System.Drawing.Point(143, 36);
            this.PanelUsuario.Name = "PanelUsuario";
            this.PanelUsuario.Size = new System.Drawing.Size(543, 46);
            this.PanelUsuario.TabIndex = 196;
            // 
            // CbxUsuario
            // 
            this.CbxUsuario.FormattingEnabled = true;
            this.CbxUsuario.Location = new System.Drawing.Point(5, 13);
            this.CbxUsuario.Name = "CbxUsuario";
            this.CbxUsuario.Size = new System.Drawing.Size(244, 21);
            this.CbxUsuario.TabIndex = 187;
            this.CbxUsuario.Click += new System.EventHandler(this.cbxUsuario_Click);
            // 
            // PanelTurma
            // 
            this.PanelTurma.Controls.Add(this.CbxTurma);
            this.PanelTurma.Location = new System.Drawing.Point(143, 36);
            this.PanelTurma.Name = "PanelTurma";
            this.PanelTurma.Size = new System.Drawing.Size(543, 46);
            this.PanelTurma.TabIndex = 195;
            // 
            // CbxTurma
            // 
            this.CbxTurma.FormattingEnabled = true;
            this.CbxTurma.Location = new System.Drawing.Point(5, 13);
            this.CbxTurma.Name = "CbxTurma";
            this.CbxTurma.Size = new System.Drawing.Size(244, 21);
            this.CbxTurma.TabIndex = 188;
            this.CbxTurma.Click += new System.EventHandler(this.cbxCurso_Click);
            // 
            // PanelData
            // 
            this.PanelData.Controls.Add(this.label2);
            this.PanelData.Controls.Add(this.DtInicio);
            this.PanelData.Controls.Add(this.label1);
            this.PanelData.Controls.Add(this.DtFim);
            this.PanelData.Location = new System.Drawing.Point(143, 36);
            this.PanelData.Name = "PanelData";
            this.PanelData.Size = new System.Drawing.Size(543, 46);
            this.PanelData.TabIndex = 192;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 194;
            this.label2.Text = "à";
            // 
            // DtInicio
            // 
            this.DtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtInicio.Location = new System.Drawing.Point(32, 11);
            this.DtInicio.Name = "DtInicio";
            this.DtInicio.Size = new System.Drawing.Size(100, 20);
            this.DtInicio.TabIndex = 183;
            this.DtInicio.Value = new System.DateTime(2020, 4, 21, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 193;
            this.label1.Text = "De:";
            // 
            // DtFim
            // 
            this.DtFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtFim.Location = new System.Drawing.Point(163, 11);
            this.DtFim.Name = "DtFim";
            this.DtFim.Size = new System.Drawing.Size(99, 20);
            this.DtFim.TabIndex = 186;
            this.DtFim.Value = new System.DateTime(2020, 4, 21, 0, 0, 0, 0);
            // 
            // CbxBusca
            // 
            this.CbxBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxBusca.FormattingEnabled = true;
            this.CbxBusca.IntegralHeight = false;
            this.CbxBusca.Items.AddRange(new object[] {
            "Por nome:",
            "Por cpf:",
            "Por data:",
            "Por turma:",
            "Por Usuário:",
            ""});
            this.CbxBusca.Location = new System.Drawing.Point(16, 48);
            this.CbxBusca.Name = "CbxBusca";
            this.CbxBusca.Size = new System.Drawing.Size(121, 23);
            this.CbxBusca.TabIndex = 191;
            this.CbxBusca.SelectedIndexChanged += new System.EventHandler(this.CbxBusca_SelectedIndexChanged);
            // 
            // btnSair
            // 
            this.btnSair.AllowToggling = false;
            this.btnSair.AnimationSpeed = 220;
            this.btnSair.AutoGenerateColors = false;
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(101)))), ((int)(((byte)(255)))));
            this.btnSair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSair.BackgroundImage")));
            this.btnSair.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSair.ButtonText = "Sair";
            this.btnSair.ButtonTextMarginLeft = 0;
            this.btnSair.ColorContrastOnClick = 45;
            this.btnSair.ColorContrastOnHover = 45;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnSair.CustomizableEdges = borderEdges1;
            this.btnSair.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSair.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnSair.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSair.DisabledForecolor = System.Drawing.Color.White;
            this.btnSair.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnSair.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.IconMarginLeft = 11;
            this.btnSair.IconPadding = 10;
            this.btnSair.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(101)))), ((int)(((byte)(255)))));
            this.btnSair.IdleBorderRadius = 30;
            this.btnSair.IdleBorderThickness = 1;
            this.btnSair.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(101)))), ((int)(((byte)(255)))));
            this.btnSair.IdleIconLeftImage = null;
            this.btnSair.IdleIconRightImage = null;
            this.btnSair.IndicateFocus = true;
            this.btnSair.Location = new System.Drawing.Point(665, 565);
            this.btnSair.Name = "btnSair";
            this.btnSair.onHoverState.BorderColor = System.Drawing.Color.Blue;
            this.btnSair.onHoverState.BorderRadius = 30;
            this.btnSair.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSair.onHoverState.BorderThickness = 1;
            this.btnSair.onHoverState.FillColor = System.Drawing.Color.Blue;
            this.btnSair.onHoverState.ForeColor = System.Drawing.Color.Empty;
            this.btnSair.onHoverState.IconLeftImage = null;
            this.btnSair.onHoverState.IconRightImage = null;
            this.btnSair.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(101)))), ((int)(((byte)(255)))));
            this.btnSair.OnIdleState.BorderRadius = 30;
            this.btnSair.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSair.OnIdleState.BorderThickness = 1;
            this.btnSair.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(101)))), ((int)(((byte)(255)))));
            this.btnSair.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnSair.OnIdleState.IconLeftImage = null;
            this.btnSair.OnIdleState.IconRightImage = null;
            this.btnSair.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnSair.OnPressedState.BorderRadius = 30;
            this.btnSair.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSair.OnPressedState.BorderThickness = 1;
            this.btnSair.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnSair.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnSair.OnPressedState.IconLeftImage = null;
            this.btnSair.OnPressedState.IconRightImage = null;
            this.btnSair.Size = new System.Drawing.Size(127, 35);
            this.btnSair.TabIndex = 189;
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSair.TextMarginLeft = 0;
            this.btnSair.UseDefaultRadiusAndThickness = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageActive = null;
            this.btnBuscar.Location = new System.Drawing.Point(707, 39);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(47, 41);
            this.btnBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBuscar.TabIndex = 182;
            this.btnBuscar.TabStop = false;
            this.btnBuscar.Zoom = 10;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // bunifuCustomTextbox1
            // 
            this.bunifuCustomTextbox1.BackColor = System.Drawing.Color.DodgerBlue;
            this.bunifuCustomTextbox1.BorderColor = System.Drawing.Color.White;
            this.bunifuCustomTextbox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomTextbox1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomTextbox1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomTextbox1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCustomTextbox1.Name = "bunifuCustomTextbox1";
            this.bunifuCustomTextbox1.Size = new System.Drawing.Size(805, 28);
            this.bunifuCustomTextbox1.TabIndex = 170;
            this.bunifuCustomTextbox1.Text = "Consulta Matricula";
            this.bunifuCustomTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(-25, 538);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(860, 35);
            this.bunifuSeparator2.TabIndex = 149;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // dataGrid
            // 
            this.dataGrid.AllowCustomTheming = false;
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid.BackgroundColor = System.Drawing.Color.White;
            this.dataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid.ColumnHeadersHeight = 40;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RM,
            this.RA,
            this.Nome,
            this.Sobrenome,
            this.ID_Turma,
            this.CURSO,
            this.Cadastro,
            this.Situacao,
            this.Usuario_Cad_Alt});
            this.dataGrid.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dataGrid.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataGrid.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGrid.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataGrid.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGrid.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dataGrid.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataGrid.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dataGrid.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dataGrid.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGrid.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dataGrid.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGrid.CurrentTheme.Name = null;
            this.dataGrid.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGrid.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataGrid.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGrid.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataGrid.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGrid.EnableHeadersVisualStyles = false;
            this.dataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataGrid.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dataGrid.HeaderBgColor = System.Drawing.Color.Empty;
            this.dataGrid.HeaderForeColor = System.Drawing.Color.White;
            this.dataGrid.Location = new System.Drawing.Point(0, 86);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.RowHeadersVisible = false;
            this.dataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGrid.RowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGrid.RowTemplate.Height = 40;
            this.dataGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.Size = new System.Drawing.Size(805, 454);
            this.dataGrid.TabIndex = 165;
            this.dataGrid.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dataGrid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGrid_CellFormatting);
            // 
            // RM
            // 
            this.RM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.RM.DataPropertyName = "Id_Matricula";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.RM.DefaultCellStyle = dataGridViewCellStyle3;
            this.RM.FillWeight = 203.0457F;
            this.RM.HeaderText = "Rm";
            this.RM.Name = "RM";
            this.RM.ReadOnly = true;
            this.RM.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.RM.Width = 50;
            // 
            // RA
            // 
            this.RA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.RA.DataPropertyName = "Aluno.Id_Aluno";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.RA.DefaultCellStyle = dataGridViewCellStyle4;
            this.RA.FillWeight = 85.27918F;
            this.RA.HeaderText = "Ra";
            this.RA.Name = "RA";
            this.RA.ReadOnly = true;
            this.RA.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.RA.Width = 50;
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Nome.DataPropertyName = "Aluno.Pessoa.Nome";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Nome.DefaultCellStyle = dataGridViewCellStyle5;
            this.Nome.FillWeight = 221.2442F;
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Nome.Width = 80;
            // 
            // Sobrenome
            // 
            this.Sobrenome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Sobrenome.DataPropertyName = "Aluno.Pessoa.Sobrenome";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Sobrenome.DefaultCellStyle = dataGridViewCellStyle6;
            this.Sobrenome.FillWeight = 63.25207F;
            this.Sobrenome.HeaderText = "Sobrenome";
            this.Sobrenome.Name = "Sobrenome";
            this.Sobrenome.ReadOnly = true;
            this.Sobrenome.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Sobrenome.Width = 180;
            // 
            // ID_Turma
            // 
            this.ID_Turma.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ID_Turma.DataPropertyName = "Turma.Id_Turma";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ID_Turma.DefaultCellStyle = dataGridViewCellStyle7;
            this.ID_Turma.FillWeight = 63.25207F;
            this.ID_Turma.HeaderText = "Id Tur.";
            this.ID_Turma.Name = "ID_Turma";
            this.ID_Turma.ReadOnly = true;
            this.ID_Turma.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ID_Turma.Width = 70;
            // 
            // CURSO
            // 
            this.CURSO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CURSO.DataPropertyName = "Turma.Nome_Turma";
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.CURSO.DefaultCellStyle = dataGridViewCellStyle8;
            this.CURSO.FillWeight = 63.25207F;
            this.CURSO.HeaderText = "Turma";
            this.CURSO.Name = "CURSO";
            this.CURSO.ReadOnly = true;
            this.CURSO.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CURSO.Width = 200;
            // 
            // Cadastro
            // 
            this.Cadastro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Cadastro.DataPropertyName = "Data_Cadastro";
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Cadastro.DefaultCellStyle = dataGridViewCellStyle9;
            this.Cadastro.FillWeight = 63.25207F;
            this.Cadastro.HeaderText = "Cadastro";
            this.Cadastro.Name = "Cadastro";
            this.Cadastro.ReadOnly = true;
            this.Cadastro.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Cadastro.Width = 80;
            // 
            // Situacao
            // 
            this.Situacao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Situacao.DataPropertyName = "Situacao";
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Situacao.DefaultCellStyle = dataGridViewCellStyle10;
            this.Situacao.HeaderText = "Sit.";
            this.Situacao.Name = "Situacao";
            this.Situacao.ReadOnly = true;
            this.Situacao.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Situacao.Width = 50;
            // 
            // Usuario_Cad_Alt
            // 
            this.Usuario_Cad_Alt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Usuario_Cad_Alt.DataPropertyName = "Usuario.Id_Usuario";
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuario_Cad_Alt.DefaultCellStyle = dataGridViewCellStyle11;
            this.Usuario_Cad_Alt.FillWeight = 74.17059F;
            this.Usuario_Cad_Alt.HeaderText = "Usu.";
            this.Usuario_Cad_Alt.Name = "Usuario_Cad_Alt";
            this.Usuario_Cad_Alt.ReadOnly = true;
            this.Usuario_Cad_Alt.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Usuario_Cad_Alt.Width = 50;
            // 
            // matriculaBindingSource
            // 
            this.matriculaBindingSource.DataSource = typeof(ObjetoTransferencia.Matricula);
            // 
            // ConsultaMatricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.container);
            this.Name = "ConsultaMatricula";
            this.Size = new System.Drawing.Size(933, 756);
            this.container.ResumeLayout(false);
            this.container.PerformLayout();
            this.PanelNome.ResumeLayout(false);
            this.PanelNome.PerformLayout();
            this.PanelCpf.ResumeLayout(false);
            this.PanelCpf.PerformLayout();
            this.PanelUsuario.ResumeLayout(false);
            this.PanelTurma.ResumeLayout(false);
            this.PanelData.ResumeLayout(false);
            this.PanelData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matriculaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel container;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.UI.WinForms.BunifuDataGridView dataGrid;
        private Bunifu.Framework.BunifuCustomTextbox bunifuCustomTextbox1;
        private Bunifu.Framework.UI.BunifuImageButton btnBuscar;
        private System.Windows.Forms.DateTimePicker DtInicio;
        private System.Windows.Forms.DateTimePicker DtFim;
        private System.Windows.Forms.ComboBox CbxTurma;
        private System.Windows.Forms.ComboBox CbxUsuario;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSair;
        private System.Windows.Forms.BindingSource matriculaBindingSource;
        private System.Windows.Forms.ComboBox CbxBusca;
        private System.Windows.Forms.Panel PanelUsuario;
        private System.Windows.Forms.Panel PanelTurma;
        private System.Windows.Forms.Panel PanelData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PanelNome;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TbxSobrenome;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TbxNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel PanelCpf;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TbxCpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn RM;
        private System.Windows.Forms.DataGridViewTextBoxColumn RA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sobrenome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Turma;
        private System.Windows.Forms.DataGridViewTextBoxColumn CURSO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cadastro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Situacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario_Cad_Alt;
    }
}
