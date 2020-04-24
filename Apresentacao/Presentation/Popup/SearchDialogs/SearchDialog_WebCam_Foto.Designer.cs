namespace Apresentacao.Presentation.Popup.SearchDialogs
{
    partial class SearchDialog_WebCam_Foto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchDialog_WebCam_Foto));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.PanelCenter = new System.Windows.Forms.Panel();
            this.cbxCameras = new System.Windows.Forms.ComboBox();
            this.picFoto = new System.Windows.Forms.PictureBox();
            this.bunifuMetroTextbox1 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFechar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnTirarFoto = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnLigar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.picFotoTirada = new System.Windows.Forms.PictureBox();
            this.PanelCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFotoTirada)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // PanelCenter
            // 
            this.PanelCenter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(101)))), ((int)(((byte)(255)))));
            this.PanelCenter.Controls.Add(this.picFotoTirada);
            this.PanelCenter.Controls.Add(this.cbxCameras);
            this.PanelCenter.Controls.Add(this.picFoto);
            this.PanelCenter.Controls.Add(this.bunifuMetroTextbox1);
            this.PanelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelCenter.Location = new System.Drawing.Point(0, 0);
            this.PanelCenter.Name = "PanelCenter";
            this.PanelCenter.Size = new System.Drawing.Size(352, 450);
            this.PanelCenter.TabIndex = 4;
            // 
            // cbxCameras
            // 
            this.cbxCameras.FormattingEnabled = true;
            this.cbxCameras.Location = new System.Drawing.Point(189, 12);
            this.cbxCameras.Name = "cbxCameras";
            this.cbxCameras.Size = new System.Drawing.Size(150, 21);
            this.cbxCameras.TabIndex = 1;
            // 
            // picFoto
            // 
            this.picFoto.BackColor = System.Drawing.Color.White;
            this.picFoto.Location = new System.Drawing.Point(8, 42);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(333, 333);
            this.picFoto.TabIndex = 0;
            this.picFoto.TabStop = false;
            // 
            // bunifuMetroTextbox1
            // 
            this.bunifuMetroTextbox1.BorderColorFocused = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox1.BorderColorIdle = System.Drawing.Color.Transparent;
            this.bunifuMetroTextbox1.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox1.BorderThickness = 3;
            this.bunifuMetroTextbox1.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuMetroTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextbox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuMetroTextbox1.ForeColor = System.Drawing.Color.White;
            this.bunifuMetroTextbox1.isPassword = false;
            this.bunifuMetroTextbox1.Location = new System.Drawing.Point(46, 9);
            this.bunifuMetroTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMetroTextbox1.MaxLength = 32767;
            this.bunifuMetroTextbox1.Name = "bunifuMetroTextbox1";
            this.bunifuMetroTextbox1.Size = new System.Drawing.Size(150, 24);
            this.bunifuMetroTextbox1.TabIndex = 2;
            this.bunifuMetroTextbox1.Text = "Selecionar WebCam";
            this.bunifuMetroTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Controls.Add(this.btnTirarFoto);
            this.panel1.Controls.Add(this.btnLigar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 389);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 61);
            this.panel1.TabIndex = 5;
            // 
            // btnFechar
            // 
            this.btnFechar.AllowToggling = false;
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.AnimationSpeed = 220;
            this.btnFechar.AutoGenerateColors = false;
            this.btnFechar.BackColor = System.Drawing.Color.Transparent;
            this.btnFechar.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(101)))), ((int)(((byte)(255)))));
            this.btnFechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFechar.BackgroundImage")));
            this.btnFechar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnFechar.ButtonText = "Fechar";
            this.btnFechar.ButtonTextMarginLeft = 0;
            this.btnFechar.ColorContrastOnClick = 45;
            this.btnFechar.ColorContrastOnHover = 45;
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.btnFechar.CustomizableEdges = borderEdges4;
            this.btnFechar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnFechar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnFechar.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnFechar.DisabledForecolor = System.Drawing.Color.White;
            this.btnFechar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnFechar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.IconMarginLeft = 11;
            this.btnFechar.IconPadding = 10;
            this.btnFechar.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(101)))), ((int)(((byte)(255)))));
            this.btnFechar.IdleBorderRadius = 30;
            this.btnFechar.IdleBorderThickness = 1;
            this.btnFechar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(101)))), ((int)(((byte)(255)))));
            this.btnFechar.IdleIconLeftImage = null;
            this.btnFechar.IdleIconRightImage = null;
            this.btnFechar.IndicateFocus = true;
            this.btnFechar.Location = new System.Drawing.Point(238, 14);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.onHoverState.BorderColor = System.Drawing.Color.Blue;
            this.btnFechar.onHoverState.BorderRadius = 30;
            this.btnFechar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnFechar.onHoverState.BorderThickness = 1;
            this.btnFechar.onHoverState.FillColor = System.Drawing.Color.Blue;
            this.btnFechar.onHoverState.ForeColor = System.Drawing.Color.Empty;
            this.btnFechar.onHoverState.IconLeftImage = null;
            this.btnFechar.onHoverState.IconRightImage = null;
            this.btnFechar.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(101)))), ((int)(((byte)(255)))));
            this.btnFechar.OnIdleState.BorderRadius = 30;
            this.btnFechar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnFechar.OnIdleState.BorderThickness = 1;
            this.btnFechar.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(101)))), ((int)(((byte)(255)))));
            this.btnFechar.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnFechar.OnIdleState.IconLeftImage = null;
            this.btnFechar.OnIdleState.IconRightImage = null;
            this.btnFechar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnFechar.OnPressedState.BorderRadius = 30;
            this.btnFechar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnFechar.OnPressedState.BorderThickness = 1;
            this.btnFechar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnFechar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnFechar.OnPressedState.IconLeftImage = null;
            this.btnFechar.OnPressedState.IconRightImage = null;
            this.btnFechar.Size = new System.Drawing.Size(101, 35);
            this.btnFechar.TabIndex = 15;
            this.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFechar.TextMarginLeft = 0;
            this.btnFechar.UseDefaultRadiusAndThickness = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnTirarFoto
            // 
            this.btnTirarFoto.AllowToggling = false;
            this.btnTirarFoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTirarFoto.AnimationSpeed = 220;
            this.btnTirarFoto.AutoGenerateColors = false;
            this.btnTirarFoto.BackColor = System.Drawing.Color.Transparent;
            this.btnTirarFoto.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(101)))), ((int)(((byte)(255)))));
            this.btnTirarFoto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTirarFoto.BackgroundImage")));
            this.btnTirarFoto.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnTirarFoto.ButtonText = "TirarFoto";
            this.btnTirarFoto.ButtonTextMarginLeft = 0;
            this.btnTirarFoto.ColorContrastOnClick = 45;
            this.btnTirarFoto.ColorContrastOnHover = 45;
            this.btnTirarFoto.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges5.BottomLeft = true;
            borderEdges5.BottomRight = true;
            borderEdges5.TopLeft = true;
            borderEdges5.TopRight = true;
            this.btnTirarFoto.CustomizableEdges = borderEdges5;
            this.btnTirarFoto.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnTirarFoto.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnTirarFoto.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnTirarFoto.DisabledForecolor = System.Drawing.Color.White;
            this.btnTirarFoto.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnTirarFoto.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnTirarFoto.ForeColor = System.Drawing.Color.White;
            this.btnTirarFoto.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnTirarFoto.IconMarginLeft = 11;
            this.btnTirarFoto.IconPadding = 10;
            this.btnTirarFoto.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnTirarFoto.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(101)))), ((int)(((byte)(255)))));
            this.btnTirarFoto.IdleBorderRadius = 30;
            this.btnTirarFoto.IdleBorderThickness = 1;
            this.btnTirarFoto.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(101)))), ((int)(((byte)(255)))));
            this.btnTirarFoto.IdleIconLeftImage = null;
            this.btnTirarFoto.IdleIconRightImage = null;
            this.btnTirarFoto.IndicateFocus = true;
            this.btnTirarFoto.Location = new System.Drawing.Point(125, 13);
            this.btnTirarFoto.Name = "btnTirarFoto";
            this.btnTirarFoto.onHoverState.BorderColor = System.Drawing.Color.Blue;
            this.btnTirarFoto.onHoverState.BorderRadius = 30;
            this.btnTirarFoto.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnTirarFoto.onHoverState.BorderThickness = 1;
            this.btnTirarFoto.onHoverState.FillColor = System.Drawing.Color.Blue;
            this.btnTirarFoto.onHoverState.ForeColor = System.Drawing.Color.Empty;
            this.btnTirarFoto.onHoverState.IconLeftImage = null;
            this.btnTirarFoto.onHoverState.IconRightImage = null;
            this.btnTirarFoto.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(101)))), ((int)(((byte)(255)))));
            this.btnTirarFoto.OnIdleState.BorderRadius = 30;
            this.btnTirarFoto.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnTirarFoto.OnIdleState.BorderThickness = 1;
            this.btnTirarFoto.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(101)))), ((int)(((byte)(255)))));
            this.btnTirarFoto.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnTirarFoto.OnIdleState.IconLeftImage = null;
            this.btnTirarFoto.OnIdleState.IconRightImage = null;
            this.btnTirarFoto.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnTirarFoto.OnPressedState.BorderRadius = 30;
            this.btnTirarFoto.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnTirarFoto.OnPressedState.BorderThickness = 1;
            this.btnTirarFoto.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnTirarFoto.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnTirarFoto.OnPressedState.IconLeftImage = null;
            this.btnTirarFoto.OnPressedState.IconRightImage = null;
            this.btnTirarFoto.Size = new System.Drawing.Size(101, 35);
            this.btnTirarFoto.TabIndex = 14;
            this.btnTirarFoto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTirarFoto.TextMarginLeft = 0;
            this.btnTirarFoto.UseDefaultRadiusAndThickness = true;
            this.btnTirarFoto.Click += new System.EventHandler(this.btnTirarFoto_Click);
            // 
            // btnLigar
            // 
            this.btnLigar.AllowToggling = false;
            this.btnLigar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLigar.AnimationSpeed = 220;
            this.btnLigar.AutoGenerateColors = false;
            this.btnLigar.BackColor = System.Drawing.Color.Transparent;
            this.btnLigar.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(101)))), ((int)(((byte)(255)))));
            this.btnLigar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLigar.BackgroundImage")));
            this.btnLigar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLigar.ButtonText = "Ligar Cam";
            this.btnLigar.ButtonTextMarginLeft = 0;
            this.btnLigar.ColorContrastOnClick = 45;
            this.btnLigar.ColorContrastOnHover = 45;
            this.btnLigar.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges6.BottomLeft = true;
            borderEdges6.BottomRight = true;
            borderEdges6.TopLeft = true;
            borderEdges6.TopRight = true;
            this.btnLigar.CustomizableEdges = borderEdges6;
            this.btnLigar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLigar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnLigar.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLigar.DisabledForecolor = System.Drawing.Color.White;
            this.btnLigar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnLigar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnLigar.ForeColor = System.Drawing.Color.White;
            this.btnLigar.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnLigar.IconMarginLeft = 11;
            this.btnLigar.IconPadding = 10;
            this.btnLigar.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnLigar.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(101)))), ((int)(((byte)(255)))));
            this.btnLigar.IdleBorderRadius = 30;
            this.btnLigar.IdleBorderThickness = 1;
            this.btnLigar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(101)))), ((int)(((byte)(255)))));
            this.btnLigar.IdleIconLeftImage = null;
            this.btnLigar.IdleIconRightImage = null;
            this.btnLigar.IndicateFocus = true;
            this.btnLigar.Location = new System.Drawing.Point(12, 14);
            this.btnLigar.Name = "btnLigar";
            this.btnLigar.onHoverState.BorderColor = System.Drawing.Color.Blue;
            this.btnLigar.onHoverState.BorderRadius = 30;
            this.btnLigar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLigar.onHoverState.BorderThickness = 1;
            this.btnLigar.onHoverState.FillColor = System.Drawing.Color.Blue;
            this.btnLigar.onHoverState.ForeColor = System.Drawing.Color.Empty;
            this.btnLigar.onHoverState.IconLeftImage = null;
            this.btnLigar.onHoverState.IconRightImage = null;
            this.btnLigar.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(101)))), ((int)(((byte)(255)))));
            this.btnLigar.OnIdleState.BorderRadius = 30;
            this.btnLigar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLigar.OnIdleState.BorderThickness = 1;
            this.btnLigar.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(101)))), ((int)(((byte)(255)))));
            this.btnLigar.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnLigar.OnIdleState.IconLeftImage = null;
            this.btnLigar.OnIdleState.IconRightImage = null;
            this.btnLigar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnLigar.OnPressedState.BorderRadius = 30;
            this.btnLigar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLigar.OnPressedState.BorderThickness = 1;
            this.btnLigar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnLigar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnLigar.OnPressedState.IconLeftImage = null;
            this.btnLigar.OnPressedState.IconRightImage = null;
            this.btnLigar.Size = new System.Drawing.Size(101, 35);
            this.btnLigar.TabIndex = 13;
            this.btnLigar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLigar.TextMarginLeft = 0;
            this.btnLigar.UseDefaultRadiusAndThickness = true;
            this.btnLigar.Click += new System.EventHandler(this.btnLigar_Click);
            // 
            // picFotoTirada
            // 
            this.picFotoTirada.BackColor = System.Drawing.Color.White;
            this.picFotoTirada.Location = new System.Drawing.Point(235, 270);
            this.picFotoTirada.Name = "picFotoTirada";
            this.picFotoTirada.Size = new System.Drawing.Size(100, 100);
            this.picFotoTirada.TabIndex = 3;
            this.picFotoTirada.TabStop = false;
            // 
            // SearchDialog_WebCam_Foto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(352, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelCenter);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchDialog_WebCam_Foto";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SearchDialog";
            this.PanelCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picFotoTirada)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel PanelCenter;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnFechar;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnTirarFoto;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnLigar;
        private System.Windows.Forms.PictureBox picFoto;
        private System.Windows.Forms.ComboBox cbxCameras;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextbox1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox picFotoTirada;
    }
}