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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.container = new System.Windows.Forms.Panel();
            this.btnRelatorio = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnSair = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.cbxCurso = new System.Windows.Forms.ComboBox();
            this.cbxUsuario = new System.Windows.Forms.ComboBox();
            this.dtFim = new System.Windows.Forms.DateTimePicker();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnBuscar = new Bunifu.Framework.UI.BunifuImageButton();
            this.rd03 = new System.Windows.Forms.RadioButton();
            this.rd02 = new System.Windows.Forms.RadioButton();
            this.rd01 = new System.Windows.Forms.RadioButton();
            this.bunifuCustomTextbox1 = new Bunifu.Framework.BunifuCustomTextbox();
            this.dataGrid = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.RM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sobrenome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Turma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CURSO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ultima_Alteracao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Situacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario_Cad_Alt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator3 = new Bunifu.Framework.UI.BunifuSeparator();
            this.timerpreenche = new System.Windows.Forms.Timer(this.components);
            this.matriculaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matriculaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.container.Controls.Add(this.btnRelatorio);
            this.container.Controls.Add(this.btnSair);
            this.container.Controls.Add(this.cbxCurso);
            this.container.Controls.Add(this.cbxUsuario);
            this.container.Controls.Add(this.dtFim);
            this.container.Controls.Add(this.textBox2);
            this.container.Controls.Add(this.dtInicio);
            this.container.Controls.Add(this.textBox1);
            this.container.Controls.Add(this.btnBuscar);
            this.container.Controls.Add(this.rd03);
            this.container.Controls.Add(this.rd02);
            this.container.Controls.Add(this.rd01);
            this.container.Controls.Add(this.bunifuCustomTextbox1);
            this.container.Controls.Add(this.dataGrid);
            this.container.Controls.Add(this.bunifuSeparator2);
            this.container.Controls.Add(this.bunifuSeparator1);
            this.container.Controls.Add(this.bunifuSeparator3);
            this.container.Location = new System.Drawing.Point(47, -16);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(860, 892);
            this.container.TabIndex = 0;
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.AllowToggling = false;
            this.btnRelatorio.AnimationSpeed = 220;
            this.btnRelatorio.AutoGenerateColors = false;
            this.btnRelatorio.BackColor = System.Drawing.Color.Transparent;
            this.btnRelatorio.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(101)))), ((int)(((byte)(255)))));
            this.btnRelatorio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRelatorio.BackgroundImage")));
            this.btnRelatorio.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRelatorio.ButtonText = "Gerar Relatório";
            this.btnRelatorio.ButtonTextMarginLeft = 0;
            this.btnRelatorio.ColorContrastOnClick = 45;
            this.btnRelatorio.ColorContrastOnHover = 45;
            this.btnRelatorio.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnRelatorio.CustomizableEdges = borderEdges1;
            this.btnRelatorio.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRelatorio.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnRelatorio.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRelatorio.DisabledForecolor = System.Drawing.Color.White;
            this.btnRelatorio.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnRelatorio.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorio.ForeColor = System.Drawing.Color.White;
            this.btnRelatorio.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnRelatorio.IconMarginLeft = 11;
            this.btnRelatorio.IconPadding = 10;
            this.btnRelatorio.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnRelatorio.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(101)))), ((int)(((byte)(255)))));
            this.btnRelatorio.IdleBorderRadius = 30;
            this.btnRelatorio.IdleBorderThickness = 1;
            this.btnRelatorio.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(101)))), ((int)(((byte)(255)))));
            this.btnRelatorio.IdleIconLeftImage = null;
            this.btnRelatorio.IdleIconRightImage = null;
            this.btnRelatorio.IndicateFocus = true;
            this.btnRelatorio.Location = new System.Drawing.Point(571, 738);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.onHoverState.BorderColor = System.Drawing.Color.Blue;
            this.btnRelatorio.onHoverState.BorderRadius = 30;
            this.btnRelatorio.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRelatorio.onHoverState.BorderThickness = 1;
            this.btnRelatorio.onHoverState.FillColor = System.Drawing.Color.Blue;
            this.btnRelatorio.onHoverState.ForeColor = System.Drawing.Color.Empty;
            this.btnRelatorio.onHoverState.IconLeftImage = null;
            this.btnRelatorio.onHoverState.IconRightImage = null;
            this.btnRelatorio.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(101)))), ((int)(((byte)(255)))));
            this.btnRelatorio.OnIdleState.BorderRadius = 30;
            this.btnRelatorio.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRelatorio.OnIdleState.BorderThickness = 1;
            this.btnRelatorio.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(101)))), ((int)(((byte)(255)))));
            this.btnRelatorio.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnRelatorio.OnIdleState.IconLeftImage = null;
            this.btnRelatorio.OnIdleState.IconRightImage = null;
            this.btnRelatorio.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnRelatorio.OnPressedState.BorderRadius = 30;
            this.btnRelatorio.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRelatorio.OnPressedState.BorderThickness = 1;
            this.btnRelatorio.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnRelatorio.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnRelatorio.OnPressedState.IconLeftImage = null;
            this.btnRelatorio.OnPressedState.IconRightImage = null;
            this.btnRelatorio.Size = new System.Drawing.Size(127, 35);
            this.btnRelatorio.TabIndex = 190;
            this.btnRelatorio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRelatorio.TextMarginLeft = 0;
            this.btnRelatorio.UseDefaultRadiusAndThickness = true;
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
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
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnSair.CustomizableEdges = borderEdges2;
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
            this.btnSair.Location = new System.Drawing.Point(714, 738);
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
            // cbxCurso
            // 
            this.cbxCurso.FormattingEnabled = true;
            this.cbxCurso.Location = new System.Drawing.Point(155, 179);
            this.cbxCurso.Name = "cbxCurso";
            this.cbxCurso.Size = new System.Drawing.Size(358, 21);
            this.cbxCurso.TabIndex = 188;
            this.cbxCurso.Click += new System.EventHandler(this.cbxCurso_Click);
            // 
            // cbxUsuario
            // 
            this.cbxUsuario.FormattingEnabled = true;
            this.cbxUsuario.Location = new System.Drawing.Point(155, 137);
            this.cbxUsuario.Name = "cbxUsuario";
            this.cbxUsuario.Size = new System.Drawing.Size(358, 21);
            this.cbxUsuario.TabIndex = 187;
            this.cbxUsuario.Click += new System.EventHandler(this.cbxUsuario_Click);
            // 
            // dtFim
            // 
            this.dtFim.Location = new System.Drawing.Point(537, 96);
            this.dtFim.Name = "dtFim";
            this.dtFim.Size = new System.Drawing.Size(235, 20);
            this.dtFim.TabIndex = 186;
            this.dtFim.Value = new System.DateTime(2020, 4, 21, 0, 0, 0, 0);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(470, 99);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(73, 15);
            this.textBox2.TabIndex = 185;
            this.textBox2.Text = "Data Fim:";
            // 
            // dtInicio
            // 
            this.dtInicio.Location = new System.Drawing.Point(238, 96);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(228, 20);
            this.dtInicio.TabIndex = 183;
            this.dtInicio.Value = new System.DateTime(2020, 4, 21, 0, 0, 0, 0);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(155, 98);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(87, 15);
            this.textBox1.TabIndex = 184;
            this.textBox1.Text = "Data Início:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageActive = null;
            this.btnBuscar.Location = new System.Drawing.Point(781, 117);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(60, 57);
            this.btnBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBuscar.TabIndex = 182;
            this.btnBuscar.TabStop = false;
            this.btnBuscar.Zoom = 10;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // rd03
            // 
            this.rd03.AutoSize = true;
            this.rd03.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd03.Location = new System.Drawing.Point(3, 181);
            this.rd03.Name = "rd03";
            this.rd03.Size = new System.Drawing.Size(133, 18);
            this.rd03.TabIndex = 179;
            this.rd03.TabStop = true;
            this.rd03.Text = "Consulta por Curso";
            this.rd03.UseVisualStyleBackColor = true;
            // 
            // rd02
            // 
            this.rd02.AutoSize = true;
            this.rd02.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd02.Location = new System.Drawing.Point(3, 137);
            this.rd02.Name = "rd02";
            this.rd02.Size = new System.Drawing.Size(141, 18);
            this.rd02.TabIndex = 178;
            this.rd02.TabStop = true;
            this.rd02.Text = "Consulta por Usuário";
            this.rd02.UseVisualStyleBackColor = true;
            // 
            // rd01
            // 
            this.rd01.AutoSize = true;
            this.rd01.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd01.Location = new System.Drawing.Point(3, 96);
            this.rd01.Name = "rd01";
            this.rd01.Size = new System.Drawing.Size(122, 18);
            this.rd01.TabIndex = 177;
            this.rd01.TabStop = true;
            this.rd01.Text = "Consulta por data";
            this.rd01.UseVisualStyleBackColor = true;
            // 
            // bunifuCustomTextbox1
            // 
            this.bunifuCustomTextbox1.BackColor = System.Drawing.Color.DodgerBlue;
            this.bunifuCustomTextbox1.BorderColor = System.Drawing.Color.White;
            this.bunifuCustomTextbox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomTextbox1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomTextbox1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomTextbox1.Location = new System.Drawing.Point(0, 50);
            this.bunifuCustomTextbox1.Name = "bunifuCustomTextbox1";
            this.bunifuCustomTextbox1.Size = new System.Drawing.Size(851, 34);
            this.bunifuCustomTextbox1.TabIndex = 170;
            this.bunifuCustomTextbox1.Text = "Consulta/Relatórios Matricula";
            this.bunifuCustomTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
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
            this.Ultima_Alteracao,
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
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGrid.EnableHeadersVisualStyles = false;
            this.dataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataGrid.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dataGrid.HeaderBgColor = System.Drawing.Color.Empty;
            this.dataGrid.HeaderForeColor = System.Drawing.Color.White;
            this.dataGrid.Location = new System.Drawing.Point(0, 215);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.RowHeadersVisible = false;
            this.dataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGrid.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGrid.RowTemplate.Height = 40;
            this.dataGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.Size = new System.Drawing.Size(860, 438);
            this.dataGrid.TabIndex = 165;
            this.dataGrid.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dataGrid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGrid_CellFormatting);
            // 
            // RM
            // 
            this.RM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.RM.DataPropertyName = "Id_Matricula";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.RM.DefaultCellStyle = dataGridViewCellStyle3;
            this.RM.FillWeight = 203.0457F;
            this.RM.HeaderText = "RM";
            this.RM.Name = "RM";
            this.RM.ReadOnly = true;
            this.RM.Width = 50;
            // 
            // RA
            // 
            this.RA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.RA.DataPropertyName = "Aluno.Id_Aluno";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.RA.DefaultCellStyle = dataGridViewCellStyle4;
            this.RA.FillWeight = 85.27918F;
            this.RA.HeaderText = "RA";
            this.RA.Name = "RA";
            this.RA.ReadOnly = true;
            this.RA.Width = 50;
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Nome.DataPropertyName = "Aluno.Pessoa.Nome";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Nome.DefaultCellStyle = dataGridViewCellStyle5;
            this.Nome.FillWeight = 221.2442F;
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 90;
            // 
            // Sobrenome
            // 
            this.Sobrenome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Sobrenome.DataPropertyName = "Aluno.Pessoa.Sobrenome";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Sobrenome.DefaultCellStyle = dataGridViewCellStyle6;
            this.Sobrenome.FillWeight = 63.25207F;
            this.Sobrenome.HeaderText = "Sobrenome";
            this.Sobrenome.Name = "Sobrenome";
            this.Sobrenome.ReadOnly = true;
            this.Sobrenome.Width = 160;
            // 
            // ID_Turma
            // 
            this.ID_Turma.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ID_Turma.DataPropertyName = "Turma.Id_Turma";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.ID_Turma.DefaultCellStyle = dataGridViewCellStyle7;
            this.ID_Turma.FillWeight = 63.25207F;
            this.ID_Turma.HeaderText = "Turma";
            this.ID_Turma.Name = "ID_Turma";
            this.ID_Turma.ReadOnly = true;
            this.ID_Turma.Width = 70;
            // 
            // CURSO
            // 
            this.CURSO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CURSO.DataPropertyName = "Turma.Curso.Nome";
            this.CURSO.FillWeight = 63.25207F;
            this.CURSO.HeaderText = "CURSO";
            this.CURSO.Name = "CURSO";
            this.CURSO.ReadOnly = true;
            this.CURSO.Width = 150;
            // 
            // Cadastro
            // 
            this.Cadastro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Cadastro.DataPropertyName = "Data_Cadastro";
            this.Cadastro.FillWeight = 63.25207F;
            this.Cadastro.HeaderText = "Cadastro";
            this.Cadastro.Name = "Cadastro";
            this.Cadastro.ReadOnly = true;
            this.Cadastro.Width = 80;
            // 
            // Ultima_Alteracao
            // 
            this.Ultima_Alteracao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Ultima_Alteracao.DataPropertyName = "Data_Ultima_Alteracao";
            this.Ultima_Alteracao.FillWeight = 63.25207F;
            this.Ultima_Alteracao.HeaderText = "Alteração";
            this.Ultima_Alteracao.Name = "Ultima_Alteracao";
            this.Ultima_Alteracao.ReadOnly = true;
            this.Ultima_Alteracao.Width = 80;
            // 
            // Situacao
            // 
            this.Situacao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Situacao.HeaderText = "Situação";
            this.Situacao.Name = "Situacao";
            this.Situacao.ReadOnly = true;
            this.Situacao.Width = 70;
            // 
            // Usuario_Cad_Alt
            // 
            this.Usuario_Cad_Alt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Usuario_Cad_Alt.FillWeight = 74.17059F;
            this.Usuario_Cad_Alt.HeaderText = "Usuário";
            this.Usuario_Cad_Alt.Name = "Usuario_Cad_Alt";
            this.Usuario_Cad_Alt.ReadOnly = true;
            this.Usuario_Cad_Alt.Width = 70;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(-25, 697);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(915, 35);
            this.bunifuSeparator2.TabIndex = 149;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(-25, 107);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(800, 35);
            this.bunifuSeparator1.TabIndex = 180;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // bunifuSeparator3
            // 
            this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator3.LineThickness = 1;
            this.bunifuSeparator3.Location = new System.Drawing.Point(-25, 150);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Size = new System.Drawing.Size(800, 35);
            this.bunifuSeparator3.TabIndex = 181;
            this.bunifuSeparator3.Transparency = 255;
            this.bunifuSeparator3.Vertical = false;
            // 
            // timerpreenche
            // 
            this.timerpreenche.Enabled = true;
            this.timerpreenche.Interval = 300;
            this.timerpreenche.Tick += new System.EventHandler(this.timerpreenche_Tick);
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
            this.Size = new System.Drawing.Size(933, 937);
            this.container.ResumeLayout(false);
            this.container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matriculaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel container;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.Timer timerpreenche;
        private Bunifu.UI.WinForms.BunifuDataGridView dataGrid;
        private Bunifu.Framework.BunifuCustomTextbox bunifuCustomTextbox1;
        private System.Windows.Forms.RadioButton rd03;
        private System.Windows.Forms.RadioButton rd02;
        private System.Windows.Forms.RadioButton rd01;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator3;
        private Bunifu.Framework.UI.BunifuImageButton btnBuscar;
        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dtFim;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox cbxCurso;
        private System.Windows.Forms.ComboBox cbxUsuario;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnRelatorio;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSair;
        private System.Windows.Forms.BindingSource matriculaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn RM;
        private System.Windows.Forms.DataGridViewTextBoxColumn RA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sobrenome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Turma;
        private System.Windows.Forms.DataGridViewTextBoxColumn CURSO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cadastro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ultima_Alteracao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Situacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario_Cad_Alt;
    }
}
