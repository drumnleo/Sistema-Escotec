namespace Apresentacao.Presentation.Pages
{
    partial class AdicionarEditarAtendimento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdicionarEditarAtendimento));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.container = new System.Windows.Forms.Panel();
            this.btnAtualizar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnSalvar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator3 = new Bunifu.Framework.UI.BunifuSeparator();
            this.timerpreenche = new System.Windows.Forms.Timer(this.components);
            this.bunifuCustomTextbox1 = new Bunifu.Framework.BunifuCustomTextbox();
            this.container.SuspendLayout();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.container.Controls.Add(this.bunifuCustomTextbox1);
            this.container.Controls.Add(this.btnAtualizar);
            this.container.Controls.Add(this.btnSalvar);
            this.container.Controls.Add(this.bunifuSeparator2);
            this.container.Controls.Add(this.bunifuSeparator3);
            this.container.Location = new System.Drawing.Point(90, -16);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(754, 892);
            this.container.TabIndex = 0;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.AllowToggling = false;
            this.btnAtualizar.AnimationSpeed = 220;
            this.btnAtualizar.AutoGenerateColors = false;
            this.btnAtualizar.BackColor = System.Drawing.Color.Transparent;
            this.btnAtualizar.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(101)))), ((int)(((byte)(255)))));
            this.btnAtualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAtualizar.BackgroundImage")));
            this.btnAtualizar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAtualizar.ButtonText = "Atualizar";
            this.btnAtualizar.ButtonTextMarginLeft = 0;
            this.btnAtualizar.ColorContrastOnClick = 45;
            this.btnAtualizar.ColorContrastOnHover = 45;
            this.btnAtualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnAtualizar.CustomizableEdges = borderEdges1;
            this.btnAtualizar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAtualizar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnAtualizar.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAtualizar.DisabledForecolor = System.Drawing.Color.White;
            this.btnAtualizar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnAtualizar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.ForeColor = System.Drawing.Color.White;
            this.btnAtualizar.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtualizar.IconMarginLeft = 11;
            this.btnAtualizar.IconPadding = 10;
            this.btnAtualizar.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtualizar.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(101)))), ((int)(((byte)(255)))));
            this.btnAtualizar.IdleBorderRadius = 30;
            this.btnAtualizar.IdleBorderThickness = 1;
            this.btnAtualizar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(101)))), ((int)(((byte)(255)))));
            this.btnAtualizar.IdleIconLeftImage = null;
            this.btnAtualizar.IdleIconRightImage = null;
            this.btnAtualizar.IndicateFocus = true;
            this.btnAtualizar.Location = new System.Drawing.Point(459, 677);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.onHoverState.BorderColor = System.Drawing.Color.Blue;
            this.btnAtualizar.onHoverState.BorderRadius = 30;
            this.btnAtualizar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAtualizar.onHoverState.BorderThickness = 1;
            this.btnAtualizar.onHoverState.FillColor = System.Drawing.Color.Blue;
            this.btnAtualizar.onHoverState.ForeColor = System.Drawing.Color.Empty;
            this.btnAtualizar.onHoverState.IconLeftImage = null;
            this.btnAtualizar.onHoverState.IconRightImage = null;
            this.btnAtualizar.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(101)))), ((int)(((byte)(255)))));
            this.btnAtualizar.OnIdleState.BorderRadius = 30;
            this.btnAtualizar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAtualizar.OnIdleState.BorderThickness = 1;
            this.btnAtualizar.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(101)))), ((int)(((byte)(255)))));
            this.btnAtualizar.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnAtualizar.OnIdleState.IconLeftImage = null;
            this.btnAtualizar.OnIdleState.IconRightImage = null;
            this.btnAtualizar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnAtualizar.OnPressedState.BorderRadius = 30;
            this.btnAtualizar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAtualizar.OnPressedState.BorderThickness = 1;
            this.btnAtualizar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnAtualizar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnAtualizar.OnPressedState.IconLeftImage = null;
            this.btnAtualizar.OnPressedState.IconRightImage = null;
            this.btnAtualizar.Size = new System.Drawing.Size(127, 35);
            this.btnAtualizar.TabIndex = 164;
            this.btnAtualizar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAtualizar.TextMarginLeft = 0;
            this.btnAtualizar.UseDefaultRadiusAndThickness = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.AllowToggling = false;
            this.btnSalvar.AnimationSpeed = 220;
            this.btnSalvar.AutoGenerateColors = false;
            this.btnSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(101)))), ((int)(((byte)(255)))));
            this.btnSalvar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalvar.BackgroundImage")));
            this.btnSalvar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSalvar.ButtonText = "Salvar";
            this.btnSalvar.ButtonTextMarginLeft = 0;
            this.btnSalvar.ColorContrastOnClick = 45;
            this.btnSalvar.ColorContrastOnHover = 45;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnSalvar.CustomizableEdges = borderEdges2;
            this.btnSalvar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSalvar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnSalvar.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSalvar.DisabledForecolor = System.Drawing.Color.White;
            this.btnSalvar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.IconMarginLeft = 11;
            this.btnSalvar.IconPadding = 10;
            this.btnSalvar.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(101)))), ((int)(((byte)(255)))));
            this.btnSalvar.IdleBorderRadius = 30;
            this.btnSalvar.IdleBorderThickness = 1;
            this.btnSalvar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(101)))), ((int)(((byte)(255)))));
            this.btnSalvar.IdleIconLeftImage = null;
            this.btnSalvar.IdleIconRightImage = null;
            this.btnSalvar.IndicateFocus = true;
            this.btnSalvar.Location = new System.Drawing.Point(592, 677);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.onHoverState.BorderColor = System.Drawing.Color.Blue;
            this.btnSalvar.onHoverState.BorderRadius = 30;
            this.btnSalvar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSalvar.onHoverState.BorderThickness = 1;
            this.btnSalvar.onHoverState.FillColor = System.Drawing.Color.Blue;
            this.btnSalvar.onHoverState.ForeColor = System.Drawing.Color.Empty;
            this.btnSalvar.onHoverState.IconLeftImage = null;
            this.btnSalvar.onHoverState.IconRightImage = null;
            this.btnSalvar.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(101)))), ((int)(((byte)(255)))));
            this.btnSalvar.OnIdleState.BorderRadius = 30;
            this.btnSalvar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSalvar.OnIdleState.BorderThickness = 1;
            this.btnSalvar.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(101)))), ((int)(((byte)(255)))));
            this.btnSalvar.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.OnIdleState.IconLeftImage = null;
            this.btnSalvar.OnIdleState.IconRightImage = null;
            this.btnSalvar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnSalvar.OnPressedState.BorderRadius = 30;
            this.btnSalvar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSalvar.OnPressedState.BorderThickness = 1;
            this.btnSalvar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnSalvar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.OnPressedState.IconLeftImage = null;
            this.btnSalvar.OnPressedState.IconRightImage = null;
            this.btnSalvar.Size = new System.Drawing.Size(127, 35);
            this.btnSalvar.TabIndex = 150;
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSalvar.TextMarginLeft = 0;
            this.btnSalvar.UseDefaultRadiusAndThickness = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(-31, 641);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(809, 35);
            this.bunifuSeparator2.TabIndex = 149;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // bunifuSeparator3
            // 
            this.bunifuSeparator3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuSeparator3.LineThickness = 1;
            this.bunifuSeparator3.Location = new System.Drawing.Point(-41, 85);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Size = new System.Drawing.Size(809, 35);
            this.bunifuSeparator3.TabIndex = 126;
            this.bunifuSeparator3.Transparency = 255;
            this.bunifuSeparator3.Vertical = false;
            // 
            // timerpreenche
            // 
            this.timerpreenche.Enabled = true;
            this.timerpreenche.Interval = 500;
            this.timerpreenche.Tick += new System.EventHandler(this.timerpreenche_Tick);
            // 
            // bunifuCustomTextbox1
            // 
            this.bunifuCustomTextbox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.bunifuCustomTextbox1.BorderColor = System.Drawing.Color.White;
            this.bunifuCustomTextbox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomTextbox1.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomTextbox1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.bunifuCustomTextbox1.Location = new System.Drawing.Point(0, 58);
            this.bunifuCustomTextbox1.Name = "bunifuCustomTextbox1";
            this.bunifuCustomTextbox1.Size = new System.Drawing.Size(754, 43);
            this.bunifuCustomTextbox1.TabIndex = 168;
            this.bunifuCustomTextbox1.Text = "ATENDIMENTO";
            this.bunifuCustomTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AdicionarEditarAtendimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.container);
            this.Name = "AdicionarEditarAtendimento";
            this.Size = new System.Drawing.Size(933, 937);
            this.container.ResumeLayout(false);
            this.container.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel container;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator3;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSalvar;
        private System.Windows.Forms.Timer timerpreenche;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAtualizar;
        private Bunifu.Framework.BunifuCustomTextbox bunifuCustomTextbox1;
    }
}
