namespace Apresentacao.Presentation.Popup.ConfirmaUsuario
{
    partial class Frm_UsuarioConfirma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_UsuarioConfirma));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.CbxUsuario = new System.Windows.Forms.ComboBox();
            this.TbxSenha = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.BtnAutorizar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.BtnCancelar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CbxUsuario
            // 
            this.CbxUsuario.BackColor = System.Drawing.Color.SteelBlue;
            this.CbxUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxUsuario.ForeColor = System.Drawing.Color.White;
            this.CbxUsuario.FormattingEnabled = true;
            this.CbxUsuario.Location = new System.Drawing.Point(77, 112);
            this.CbxUsuario.Margin = new System.Windows.Forms.Padding(0);
            this.CbxUsuario.Name = "CbxUsuario";
            this.CbxUsuario.Size = new System.Drawing.Size(201, 25);
            this.CbxUsuario.TabIndex = 0;
            // 
            // TbxSenha
            // 
            this.TbxSenha.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TbxSenha.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TbxSenha.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TbxSenha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TbxSenha.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TbxSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TbxSenha.HintForeColor = System.Drawing.Color.Empty;
            this.TbxSenha.HintText = "";
            this.TbxSenha.isPassword = true;
            this.TbxSenha.LineFocusedColor = System.Drawing.Color.SteelBlue;
            this.TbxSenha.LineIdleColor = System.Drawing.Color.SteelBlue;
            this.TbxSenha.LineMouseHoverColor = System.Drawing.Color.SteelBlue;
            this.TbxSenha.LineThickness = 2;
            this.TbxSenha.Location = new System.Drawing.Point(76, 175);
            this.TbxSenha.Margin = new System.Windows.Forms.Padding(4);
            this.TbxSenha.MaxLength = 32767;
            this.TbxSenha.Name = "TbxSenha";
            this.TbxSenha.Size = new System.Drawing.Size(201, 33);
            this.TbxSenha.TabIndex = 1;
            this.TbxSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // BtnAutorizar
            // 
            this.BtnAutorizar.AllowToggling = false;
            this.BtnAutorizar.AnimationSpeed = 200;
            this.BtnAutorizar.AutoGenerateColors = false;
            this.BtnAutorizar.BackColor = System.Drawing.Color.Transparent;
            this.BtnAutorizar.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.BtnAutorizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnAutorizar.BackgroundImage")));
            this.BtnAutorizar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnAutorizar.ButtonText = "Autorizar";
            this.BtnAutorizar.ButtonTextMarginLeft = 0;
            this.BtnAutorizar.ColorContrastOnClick = 45;
            this.BtnAutorizar.ColorContrastOnHover = 45;
            this.BtnAutorizar.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.BtnAutorizar.CustomizableEdges = borderEdges1;
            this.BtnAutorizar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnAutorizar.DisabledBorderColor = System.Drawing.Color.Empty;
            this.BtnAutorizar.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BtnAutorizar.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BtnAutorizar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.BtnAutorizar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.BtnAutorizar.ForeColor = System.Drawing.Color.White;
            this.BtnAutorizar.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAutorizar.IconMarginLeft = 11;
            this.BtnAutorizar.IconPadding = 10;
            this.BtnAutorizar.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAutorizar.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.BtnAutorizar.IdleBorderRadius = 3;
            this.BtnAutorizar.IdleBorderThickness = 1;
            this.BtnAutorizar.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.BtnAutorizar.IdleIconLeftImage = null;
            this.BtnAutorizar.IdleIconRightImage = null;
            this.BtnAutorizar.IndicateFocus = false;
            this.BtnAutorizar.Location = new System.Drawing.Point(72, 239);
            this.BtnAutorizar.Name = "BtnAutorizar";
            this.BtnAutorizar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.BtnAutorizar.onHoverState.BorderRadius = 3;
            this.BtnAutorizar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnAutorizar.onHoverState.BorderThickness = 1;
            this.BtnAutorizar.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.BtnAutorizar.onHoverState.ForeColor = System.Drawing.Color.White;
            this.BtnAutorizar.onHoverState.IconLeftImage = null;
            this.BtnAutorizar.onHoverState.IconRightImage = null;
            this.BtnAutorizar.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.BtnAutorizar.OnIdleState.BorderRadius = 3;
            this.BtnAutorizar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnAutorizar.OnIdleState.BorderThickness = 1;
            this.BtnAutorizar.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.BtnAutorizar.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.BtnAutorizar.OnIdleState.IconLeftImage = null;
            this.BtnAutorizar.OnIdleState.IconRightImage = null;
            this.BtnAutorizar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.BtnAutorizar.OnPressedState.BorderRadius = 3;
            this.BtnAutorizar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnAutorizar.OnPressedState.BorderThickness = 1;
            this.BtnAutorizar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.BtnAutorizar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.BtnAutorizar.OnPressedState.IconLeftImage = null;
            this.BtnAutorizar.OnPressedState.IconRightImage = null;
            this.BtnAutorizar.Size = new System.Drawing.Size(100, 33);
            this.BtnAutorizar.TabIndex = 2;
            this.BtnAutorizar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnAutorizar.TextMarginLeft = 0;
            this.BtnAutorizar.UseDefaultRadiusAndThickness = true;
            this.BtnAutorizar.Click += new System.EventHandler(this.BtnAutorizar_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(73, 212);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(48, 17);
            this.bunifuCustomLabel1.TabIndex = 3;
            this.bunifuCustomLabel1.Text = "Senha:";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(75, 95);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(57, 17);
            this.bunifuCustomLabel2.TabIndex = 4;
            this.bunifuCustomLabel2.Text = "Usuário:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.bunifuCustomLabel3);
            this.panel1.Controls.Add(this.bunifuCustomLabel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 71);
            this.panel1.TabIndex = 5;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Book Antiqua", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(117, 2);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(117, 46);
            this.bunifuCustomLabel3.TabIndex = 7;
            this.bunifuCustomLabel3.Text = "Login";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(40, 49);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(271, 17);
            this.bunifuCustomLabel4.TabIndex = 8;
            this.bunifuCustomLabel4.Text = "Entre com seu usuário e senha para autorizar";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.AllowToggling = false;
            this.BtnCancelar.AnimationSpeed = 200;
            this.BtnCancelar.AutoGenerateColors = false;
            this.BtnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.BtnCancelar.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.BtnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnCancelar.BackgroundImage")));
            this.BtnCancelar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnCancelar.ButtonText = "Cancelar/Sair";
            this.BtnCancelar.ButtonTextMarginLeft = 0;
            this.BtnCancelar.ColorContrastOnClick = 45;
            this.BtnCancelar.ColorContrastOnHover = 45;
            this.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.BtnCancelar.CustomizableEdges = borderEdges2;
            this.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnCancelar.DisabledBorderColor = System.Drawing.Color.Empty;
            this.BtnCancelar.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BtnCancelar.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BtnCancelar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.BtnCancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancelar.IconMarginLeft = 11;
            this.BtnCancelar.IconPadding = 10;
            this.BtnCancelar.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancelar.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.BtnCancelar.IdleBorderRadius = 3;
            this.BtnCancelar.IdleBorderThickness = 1;
            this.BtnCancelar.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.BtnCancelar.IdleIconLeftImage = null;
            this.BtnCancelar.IdleIconRightImage = null;
            this.BtnCancelar.IndicateFocus = false;
            this.BtnCancelar.Location = new System.Drawing.Point(178, 239);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.BtnCancelar.onHoverState.BorderRadius = 3;
            this.BtnCancelar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnCancelar.onHoverState.BorderThickness = 1;
            this.BtnCancelar.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.BtnCancelar.onHoverState.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.onHoverState.IconLeftImage = null;
            this.BtnCancelar.onHoverState.IconRightImage = null;
            this.BtnCancelar.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.BtnCancelar.OnIdleState.BorderRadius = 3;
            this.BtnCancelar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnCancelar.OnIdleState.BorderThickness = 1;
            this.BtnCancelar.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.BtnCancelar.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.OnIdleState.IconLeftImage = null;
            this.BtnCancelar.OnIdleState.IconRightImage = null;
            this.BtnCancelar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.BtnCancelar.OnPressedState.BorderRadius = 3;
            this.BtnCancelar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnCancelar.OnPressedState.BorderThickness = 1;
            this.BtnCancelar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.BtnCancelar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.OnPressedState.IconLeftImage = null;
            this.BtnCancelar.OnPressedState.IconRightImage = null;
            this.BtnCancelar.Size = new System.Drawing.Size(100, 33);
            this.BtnCancelar.TabIndex = 6;
            this.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnCancelar.TextMarginLeft = 0;
            this.BtnCancelar.UseDefaultRadiusAndThickness = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // Frm_UsuarioConfirma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(350, 297);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.BtnAutorizar);
            this.Controls.Add(this.TbxSenha);
            this.Controls.Add(this.CbxUsuario);
            this.Name = "Frm_UsuarioConfirma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autorização Usuário";
            this.Load += new System.EventHandler(this.Frm_UsuarioConfirma_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CbxUsuario;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TbxSenha;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton BtnAutorizar;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton BtnCancelar;
    }
}