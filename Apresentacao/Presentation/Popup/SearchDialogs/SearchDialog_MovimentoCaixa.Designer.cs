namespace Apresentacao.Presentation.Popup.SearchDialogs
{
    partial class SearchDialog_MovimentoCaixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchDialog_MovimentoCaixa));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.PanelDown = new System.Windows.Forms.Panel();
            this.btnSair = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnSelecionar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.PanelTop = new System.Windows.Forms.Panel();
            this.TbxTitulo = new Bunifu.Framework.BunifuCustomTextbox();
            this.PanelCenter = new System.Windows.Forms.Panel();
            this.dataGrid = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.verifica = new System.Windows.Forms.Timer(this.components);
            this.Id_Mov_Caixa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Caixa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_CONTA_RECEBER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_Movimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saida_Entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.PanelDown.Size = new System.Drawing.Size(631, 67);
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
            this.btnSair.Location = new System.Drawing.Point(476, 15);
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
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnSelecionar.CustomizableEdges = borderEdges2;
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
            this.btnSelecionar.Location = new System.Drawing.Point(325, 15);
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
            this.PanelTop.Size = new System.Drawing.Size(631, 66);
            this.PanelTop.TabIndex = 3;
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
            this.TbxTitulo.Size = new System.Drawing.Size(631, 28);
            this.TbxTitulo.TabIndex = 177;
            this.TbxTitulo.TabStop = false;
            this.TbxTitulo.Text = "MOVIMENTO CAIXA";
            this.TbxTitulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PanelCenter
            // 
            this.PanelCenter.Controls.Add(this.dataGrid);
            this.PanelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelCenter.Location = new System.Drawing.Point(0, 66);
            this.PanelCenter.Name = "PanelCenter";
            this.PanelCenter.Size = new System.Drawing.Size(631, 434);
            this.PanelCenter.TabIndex = 4;
            // 
            // dataGrid
            // 
            this.dataGrid.AllowCustomTheming = false;
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.AllowUserToResizeColumns = false;
            this.dataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid.BackgroundColor = System.Drawing.Color.White;
            this.dataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
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
            this.Id_Mov_Caixa,
            this.Id_Caixa,
            this.ID_CONTA_RECEBER,
            this.ValorFinal,
            this.Data_Movimento,
            this.Saida_Entrada});
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid.DefaultCellStyle = dataGridViewCellStyle4;
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
            this.dataGrid.Size = new System.Drawing.Size(631, 434);
            this.dataGrid.TabIndex = 0;
            this.dataGrid.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellClick);
            this.dataGrid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGrid_CellFormatting);
            // 
            // Id_Mov_Caixa
            // 
            this.Id_Mov_Caixa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Id_Mov_Caixa.DataPropertyName = "ID_MOV_CAIXA";
            this.Id_Mov_Caixa.HeaderText = "Id";
            this.Id_Mov_Caixa.Name = "Id_Mov_Caixa";
            this.Id_Mov_Caixa.ReadOnly = true;
            this.Id_Mov_Caixa.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Id_Mov_Caixa.Width = 90;
            // 
            // Id_Caixa
            // 
            this.Id_Caixa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Id_Caixa.DataPropertyName = "Caixa.Id_Caixa";
            this.Id_Caixa.FillWeight = 114.0973F;
            this.Id_Caixa.HeaderText = "Id_Caixa";
            this.Id_Caixa.Name = "Id_Caixa";
            this.Id_Caixa.ReadOnly = true;
            this.Id_Caixa.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Id_Caixa.Width = 80;
            // 
            // ID_CONTA_RECEBER
            // 
            this.ID_CONTA_RECEBER.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ID_CONTA_RECEBER.DataPropertyName = "ContasReceber.Id_Conta_Receber";
            this.ID_CONTA_RECEBER.FillWeight = 125.8577F;
            this.ID_CONTA_RECEBER.HeaderText = "Id_Conta";
            this.ID_CONTA_RECEBER.Name = "ID_CONTA_RECEBER";
            this.ID_CONTA_RECEBER.ReadOnly = true;
            this.ID_CONTA_RECEBER.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ID_CONTA_RECEBER.Width = 150;
            // 
            // ValorFinal
            // 
            this.ValorFinal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ValorFinal.DataPropertyName = "Valor_Final";
            this.ValorFinal.FillWeight = 142.6992F;
            this.ValorFinal.HeaderText = "Valor";
            this.ValorFinal.Name = "ValorFinal";
            this.ValorFinal.ReadOnly = true;
            this.ValorFinal.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ValorFinal.Width = 120;
            // 
            // Data_Movimento
            // 
            this.Data_Movimento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Data_Movimento.DataPropertyName = "Data_Movimento";
            this.Data_Movimento.FillWeight = 73.09843F;
            this.Data_Movimento.HeaderText = "Data_Movimento";
            this.Data_Movimento.Name = "Data_Movimento";
            this.Data_Movimento.ReadOnly = true;
            this.Data_Movimento.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Saida_Entrada
            // 
            this.Saida_Entrada.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Saida_Entrada.DataPropertyName = "SAIDA_ENTRADA";
            dataGridViewCellStyle3.Format = "t";
            dataGridViewCellStyle3.NullValue = null;
            this.Saida_Entrada.DefaultCellStyle = dataGridViewCellStyle3;
            this.Saida_Entrada.FillWeight = 97.82865F;
            this.Saida_Entrada.HeaderText = "S/E";
            this.Saida_Entrada.Name = "Saida_Entrada";
            this.Saida_Entrada.ReadOnly = true;
            this.Saida_Entrada.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Saida_Entrada.Width = 90;
            // 
            // SearchDialog_MovimentoCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(631, 567);
            this.Controls.Add(this.PanelCenter);
            this.Controls.Add(this.PanelTop);
            this.Controls.Add(this.PanelDown);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchDialog_MovimentoCaixa";
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
        private System.Windows.Forms.Timer verifica;
        private Bunifu.UI.WinForms.BunifuDataGridView dataGrid;
        private Bunifu.Framework.BunifuCustomTextbox TbxTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Mov_Caixa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Caixa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_CONTA_RECEBER;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_Movimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saida_Entrada;
    }
}