namespace Apresentacao.Presentation.Popup.SearchDialogs
{
    partial class SearchDialog_ProfessorMinistra
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchDialog_ProfessorMinistra));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.PanelDown = new System.Windows.Forms.Panel();
            this.btnSair = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnSelecionar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.PanelTop = new System.Windows.Forms.Panel();
            this.PanelCenter = new System.Windows.Forms.Panel();
            this.dataGrid = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.Id_professor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome_Professor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sobrenome_Professor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_Cadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TbxTitulo = new Bunifu.Framework.BunifuCustomTextbox();
            this.PanelDown.SuspendLayout();
            this.PanelTop.SuspendLayout();
            this.PanelCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // PanelDown
            // 
            this.PanelDown.Controls.Add(this.btnSair);
            this.PanelDown.Controls.Add(this.btnSelecionar);
            this.PanelDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelDown.Location = new System.Drawing.Point(0, 500);
            this.PanelDown.Name = "PanelDown";
            this.PanelDown.Size = new System.Drawing.Size(722, 67);
            this.PanelDown.TabIndex = 2;
            // 
            // btnSair
            // 
            this.btnSair.AllowToggling = false;
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnSair.CustomizableEdges = borderEdges3;
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
            this.btnSair.Location = new System.Drawing.Point(567, 15);
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
            this.btnSair.TabIndex = 14;
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSair.TextMarginLeft = 0;
            this.btnSair.UseDefaultRadiusAndThickness = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.AllowToggling = false;
            this.btnSelecionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelecionar.AnimationSpeed = 220;
            this.btnSelecionar.AutoGenerateColors = false;
            this.btnSelecionar.BackColor = System.Drawing.Color.Transparent;
            this.btnSelecionar.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(101)))), ((int)(((byte)(255)))));
            this.btnSelecionar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSelecionar.BackgroundImage")));
            this.btnSelecionar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSelecionar.ButtonText = "Selecionar";
            this.btnSelecionar.ButtonTextMarginLeft = 0;
            this.btnSelecionar.ColorContrastOnClick = 45;
            this.btnSelecionar.ColorContrastOnHover = 45;
            this.btnSelecionar.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.btnSelecionar.CustomizableEdges = borderEdges4;
            this.btnSelecionar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSelecionar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnSelecionar.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSelecionar.DisabledForecolor = System.Drawing.Color.White;
            this.btnSelecionar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnSelecionar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSelecionar.ForeColor = System.Drawing.Color.White;
            this.btnSelecionar.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelecionar.IconMarginLeft = 11;
            this.btnSelecionar.IconPadding = 10;
            this.btnSelecionar.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelecionar.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(101)))), ((int)(((byte)(255)))));
            this.btnSelecionar.IdleBorderRadius = 30;
            this.btnSelecionar.IdleBorderThickness = 1;
            this.btnSelecionar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(101)))), ((int)(((byte)(255)))));
            this.btnSelecionar.IdleIconLeftImage = null;
            this.btnSelecionar.IdleIconRightImage = null;
            this.btnSelecionar.IndicateFocus = true;
            this.btnSelecionar.Location = new System.Drawing.Point(416, 15);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.onHoverState.BorderColor = System.Drawing.Color.Blue;
            this.btnSelecionar.onHoverState.BorderRadius = 30;
            this.btnSelecionar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSelecionar.onHoverState.BorderThickness = 1;
            this.btnSelecionar.onHoverState.FillColor = System.Drawing.Color.Blue;
            this.btnSelecionar.onHoverState.ForeColor = System.Drawing.Color.Empty;
            this.btnSelecionar.onHoverState.IconLeftImage = null;
            this.btnSelecionar.onHoverState.IconRightImage = null;
            this.btnSelecionar.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(101)))), ((int)(((byte)(255)))));
            this.btnSelecionar.OnIdleState.BorderRadius = 30;
            this.btnSelecionar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSelecionar.OnIdleState.BorderThickness = 1;
            this.btnSelecionar.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(101)))), ((int)(((byte)(255)))));
            this.btnSelecionar.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnSelecionar.OnIdleState.IconLeftImage = null;
            this.btnSelecionar.OnIdleState.IconRightImage = null;
            this.btnSelecionar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnSelecionar.OnPressedState.BorderRadius = 30;
            this.btnSelecionar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSelecionar.OnPressedState.BorderThickness = 1;
            this.btnSelecionar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnSelecionar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnSelecionar.OnPressedState.IconLeftImage = null;
            this.btnSelecionar.OnPressedState.IconRightImage = null;
            this.btnSelecionar.Size = new System.Drawing.Size(132, 35);
            this.btnSelecionar.TabIndex = 12;
            this.btnSelecionar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSelecionar.TextMarginLeft = 0;
            this.btnSelecionar.UseDefaultRadiusAndThickness = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // PanelTop
            // 
            this.PanelTop.Controls.Add(this.TbxTitulo);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.Location = new System.Drawing.Point(0, 0);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(722, 62);
            this.PanelTop.TabIndex = 3;
            // 
            // PanelCenter
            // 
            this.PanelCenter.Controls.Add(this.dataGrid);
            this.PanelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelCenter.Location = new System.Drawing.Point(0, 62);
            this.PanelCenter.Name = "PanelCenter";
            this.PanelCenter.Size = new System.Drawing.Size(722, 438);
            this.PanelCenter.TabIndex = 4;
            // 
            // dataGrid
            // 
            this.dataGrid.AllowCustomTheming = false;
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.AllowUserToResizeColumns = false;
            this.dataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid.BackgroundColor = System.Drawing.Color.White;
            this.dataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGrid.ColumnHeadersHeight = 40;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_professor,
            this.Nome,
            this.Nome_Professor,
            this.Sobrenome_Professor,
            this.Data_Cadastro});
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
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid.EnableHeadersVisualStyles = false;
            this.dataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataGrid.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dataGrid.HeaderBgColor = System.Drawing.Color.Empty;
            this.dataGrid.HeaderForeColor = System.Drawing.Color.White;
            this.dataGrid.Location = new System.Drawing.Point(0, 0);
            this.dataGrid.MultiSelect = false;
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGrid.RowHeadersVisible = false;
            this.dataGrid.RowHeadersWidth = 35;
            this.dataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGrid.RowTemplate.Height = 40;
            this.dataGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.Size = new System.Drawing.Size(722, 438);
            this.dataGrid.TabIndex = 0;
            this.dataGrid.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellClick);
            this.dataGrid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGrid_CellFormatting);
            // 
            // Id_professor
            // 
            this.Id_professor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Id_professor.DataPropertyName = "Id_Professor_Ministra";
            this.Id_professor.FillWeight = 114.0973F;
            this.Id_professor.HeaderText = "Id Professor";
            this.Id_professor.Name = "Id_professor";
            this.Id_professor.ReadOnly = true;
            this.Id_professor.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Id_professor.Width = 75;
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Nome.DataPropertyName = "Curso.Nome";
            this.Nome.FillWeight = 97.82865F;
            this.Nome.HeaderText = "Nome Curso";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Nome.Width = 200;
            // 
            // Nome_Professor
            // 
            this.Nome_Professor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Nome_Professor.DataPropertyName = "Professor.Funcionario.Pessoa.Nome";
            this.Nome_Professor.FillWeight = 125.8577F;
            this.Nome_Professor.HeaderText = "Nome Professor";
            this.Nome_Professor.Name = "Nome_Professor";
            this.Nome_Professor.ReadOnly = true;
            this.Nome_Professor.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Nome_Professor.Width = 150;
            // 
            // Sobrenome_Professor
            // 
            this.Sobrenome_Professor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Sobrenome_Professor.DataPropertyName = "Professor.Funcionario.Pessoa.Sobrenome";
            this.Sobrenome_Professor.HeaderText = "Sobrenome Professor";
            this.Sobrenome_Professor.Name = "Sobrenome_Professor";
            this.Sobrenome_Professor.ReadOnly = true;
            this.Sobrenome_Professor.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Sobrenome_Professor.Width = 170;
            // 
            // Data_Cadastro
            // 
            this.Data_Cadastro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Data_Cadastro.DataPropertyName = "Data_Cadastro";
            this.Data_Cadastro.FillWeight = 142.6992F;
            this.Data_Cadastro.HeaderText = "Data Cadastro";
            this.Data_Cadastro.Name = "Data_Cadastro";
            this.Data_Cadastro.ReadOnly = true;
            this.Data_Cadastro.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // TbxTitulo
            // 
            this.TbxTitulo.BackColor = System.Drawing.Color.DodgerBlue;
            this.TbxTitulo.BorderColor = System.Drawing.Color.White;
            this.TbxTitulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbxTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.TbxTitulo.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.TbxTitulo.ForeColor = System.Drawing.Color.White;
            this.TbxTitulo.Location = new System.Drawing.Point(0, 0);
            this.TbxTitulo.Name = "TbxTitulo";
            this.TbxTitulo.Size = new System.Drawing.Size(722, 28);
            this.TbxTitulo.TabIndex = 176;
            this.TbxTitulo.TabStop = false;
            this.TbxTitulo.Text = "Consulta cursos ministrados";
            this.TbxTitulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SearchDialog_ProfessorMinistra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(722, 567);
            this.Controls.Add(this.PanelCenter);
            this.Controls.Add(this.PanelTop);
            this.Controls.Add(this.PanelDown);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchDialog_ProfessorMinistra";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SearchDialog";
            this.Shown += new System.EventHandler(this.SearchDialog_Shown);
            this.PanelDown.ResumeLayout(false);
            this.PanelTop.ResumeLayout(false);
            this.PanelTop.PerformLayout();
            this.PanelCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel PanelCenter;
        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.Panel PanelDown;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSair;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSelecionar;
        private Bunifu.UI.WinForms.BunifuDataGridView dataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_professor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome_Professor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sobrenome_Professor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_Cadastro;
        private Bunifu.Framework.BunifuCustomTextbox TbxTitulo;
    }
}