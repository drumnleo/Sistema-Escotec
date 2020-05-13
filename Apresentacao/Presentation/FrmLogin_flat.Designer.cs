namespace Apresentacao
{
    partial class FrmLogin_flat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin_flat));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtLogin = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCheckbox1 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnLogin = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnSair = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtSenha = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Book Antiqua", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(22, 156);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(254, 57);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "ESCOTEC";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Apresentacao.Properties.Resources.loginback;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.bunifuCustomLabel2);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 390);
            this.panel1.TabIndex = 0;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(63, 213);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(178, 23);
            this.bunifuCustomLabel2.TabIndex = 1;
            this.bunifuCustomLabel2.Text = "Formação Profissional";
            // 
            // txtLogin
            // 
            this.txtLogin.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtLogin.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtLogin.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLogin.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLogin.HintForeColor = System.Drawing.Color.Empty;
            this.txtLogin.HintText = "";
            this.txtLogin.isPassword = false;
            this.txtLogin.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(96)))), ((int)(((byte)(160)))));
            this.txtLogin.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(105)))), ((int)(((byte)(165)))));
            this.txtLogin.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.txtLogin.LineThickness = 2;
            this.txtLogin.Location = new System.Drawing.Point(353, 141);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(4);
            this.txtLogin.MaxLength = 32767;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(246, 33);
            this.txtLogin.TabIndex = 1;
            this.txtLogin.Text = "Usuário";
            this.txtLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Book Antiqua", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(405, 32);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(149, 58);
            this.bunifuCustomLabel3.TabIndex = 2;
            this.bunifuCustomLabel3.Text = "Login";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(381, 92);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(184, 17);
            this.bunifuCustomLabel4.TabIndex = 4;
            this.bunifuCustomLabel4.Text = "Entre com seu usuário e senha";
            // 
            // bunifuCheckbox1
            // 
            this.bunifuCheckbox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(210)))), ((int)(((byte)(66)))));
            this.bunifuCheckbox1.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.bunifuCheckbox1.Checked = true;
            this.bunifuCheckbox1.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(210)))), ((int)(((byte)(66)))));
            this.bunifuCheckbox1.ForeColor = System.Drawing.Color.White;
            this.bunifuCheckbox1.Location = new System.Drawing.Point(355, 270);
            this.bunifuCheckbox1.Name = "bunifuCheckbox1";
            this.bunifuCheckbox1.Size = new System.Drawing.Size(20, 20);
            this.bunifuCheckbox1.TabIndex = 5;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(381, 274);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(105, 17);
            this.bunifuCustomLabel5.TabIndex = 6;
            this.bunifuCustomLabel5.Text = "Lembrar usuário";
            // 
            // btnLogin
            // 
            this.btnLogin.ActiveBorderThickness = 1;
            this.btnLogin.ActiveCornerRadius = 20;
            this.btnLogin.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnLogin.ActiveForecolor = System.Drawing.Color.White;
            this.btnLogin.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnLogin.BackColor = System.Drawing.Color.White;
            this.btnLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogin.BackgroundImage")));
            this.btnLogin.ButtonText = "Login";
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.IdleBorderThickness = 1;
            this.btnLogin.IdleCornerRadius = 20;
            this.btnLogin.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(210)))), ((int)(((byte)(66)))));
            this.btnLogin.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnLogin.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(210)))), ((int)(((byte)(66)))));
            this.btnLogin.Location = new System.Drawing.Point(488, 322);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(5);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(135, 41);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogin.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // btnSair
            // 
            this.btnSair.ActiveBorderThickness = 1;
            this.btnSair.ActiveCornerRadius = 20;
            this.btnSair.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnSair.ActiveForecolor = System.Drawing.Color.White;
            this.btnSair.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnSair.BackColor = System.Drawing.Color.White;
            this.btnSair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSair.BackgroundImage")));
            this.btnSair.ButtonText = "Sair";
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.IdleBorderThickness = 1;
            this.btnSair.IdleCornerRadius = 20;
            this.btnSair.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(210)))), ((int)(((byte)(66)))));
            this.btnSair.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnSair.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(210)))), ((int)(((byte)(66)))));
            this.btnSair.Location = new System.Drawing.Point(313, 322);
            this.btnSair.Margin = new System.Windows.Forms.Padding(5);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(135, 41);
            this.btnSair.TabIndex = 8;
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtSenha.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtSenha.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSenha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSenha.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSenha.HintForeColor = System.Drawing.Color.Empty;
            this.txtSenha.HintText = "";
            this.txtSenha.isPassword = true;
            this.txtSenha.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(96)))), ((int)(((byte)(160)))));
            this.txtSenha.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(105)))), ((int)(((byte)(165)))));
            this.txtSenha.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.txtSenha.LineThickness = 2;
            this.txtSenha.Location = new System.Drawing.Point(353, 218);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(4);
            this.txtSenha.MaxLength = 32767;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(246, 33);
            this.txtSenha.TabIndex = 3;
            this.txtSenha.Text = "Usuário";
            this.txtSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSenha.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSenha_KeyUp);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmLogin_flat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(649, 390);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.bunifuCheckbox1);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin_flat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin_flat";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtLogin;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLogin;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCheckbox bunifuCheckbox1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSair;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSenha;
        private System.Windows.Forms.Timer timer1;
    }
}