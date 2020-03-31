namespace Apresentacao
{
    partial class FrmMenu
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
            Bunifu.UI.WinForms.BunifuAnimatorNS.Animation animation1 = new Bunifu.UI.WinForms.BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.MouseDetect = new System.Windows.Forms.Timer(this.components);
            this.parentContainer = new System.Windows.Forms.Panel();
            this.pinnerImages = new System.Windows.Forms.ImageList(this.components);
            this.bunifuTransition1 = new Bunifu.UI.WinForms.BunifuTransition(this.components);
            this.sidePanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.subMenutab = new Apresentacao.subMenu();
            this.pnlMenuHeader = new System.Windows.Forms.Panel();
            this.btnDrawerPin = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnlMainMenu = new System.Windows.Forms.Panel();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tab6 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tab5 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tab4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tab3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tab2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tab1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.sidePanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlMenuHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDrawerPin)).BeginInit();
            this.pnlMainMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // MouseDetect
            // 
            this.MouseDetect.Enabled = true;
            this.MouseDetect.Tick += new System.EventHandler(this.MouseDetect_Tick_1);
            // 
            // parentContainer
            // 
            this.parentContainer.AutoScroll = true;
            this.bunifuTransition1.SetDecoration(this.parentContainer, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.parentContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parentContainer.Location = new System.Drawing.Point(402, 0);
            this.parentContainer.Name = "parentContainer";
            this.parentContainer.Size = new System.Drawing.Size(775, 708);
            this.parentContainer.TabIndex = 3;
            // 
            // pinnerImages
            // 
            this.pinnerImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("pinnerImages.ImageStream")));
            this.pinnerImages.TransparentColor = System.Drawing.Color.Transparent;
            this.pinnerImages.Images.SetKeyName(0, "Pind_48px.png");
            this.pinnerImages.Images.SetKeyName(1, "Unpin_52px.png");
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.HorizSlide;
            this.bunifuTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation1;
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.sidePanel.Controls.Add(this.panel2);
            this.sidePanel.Controls.Add(this.pnlMainMenu);
            this.bunifuTransition1.SetDecoration(this.sidePanel, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(402, 708);
            this.sidePanel.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.subMenutab);
            this.panel2.Controls.Add(this.pnlMenuHeader);
            this.bunifuTransition1.SetDecoration(this.panel2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(202, 708);
            this.panel2.TabIndex = 3;
            // 
            // subMenutab
            // 
            this.bunifuTransition1.SetDecoration(this.subMenutab, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.subMenutab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subMenutab.Location = new System.Drawing.Point(0, 83);
            this.subMenutab.Name = "subMenutab";
            this.subMenutab.Size = new System.Drawing.Size(202, 625);
            this.subMenutab.TabIndex = 1;
            // 
            // pnlMenuHeader
            // 
            this.pnlMenuHeader.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlMenuHeader.Controls.Add(this.btnDrawerPin);
            this.bunifuTransition1.SetDecoration(this.pnlMenuHeader, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.pnlMenuHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenuHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlMenuHeader.Name = "pnlMenuHeader";
            this.pnlMenuHeader.Size = new System.Drawing.Size(202, 83);
            this.pnlMenuHeader.TabIndex = 5;
            // 
            // btnDrawerPin
            // 
            this.btnDrawerPin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDrawerPin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnDrawerPin, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnDrawerPin.Image = ((System.Drawing.Image)(resources.GetObject("btnDrawerPin.Image")));
            this.btnDrawerPin.ImageActive = null;
            this.btnDrawerPin.Location = new System.Drawing.Point(177, 9);
            this.btnDrawerPin.Name = "btnDrawerPin";
            this.btnDrawerPin.Size = new System.Drawing.Size(15, 15);
            this.btnDrawerPin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDrawerPin.TabIndex = 2;
            this.btnDrawerPin.TabStop = false;
            this.btnDrawerPin.Tag = "";
            this.btnDrawerPin.Zoom = 10;
            this.btnDrawerPin.Click += new System.EventHandler(this.btnDrawerPin_Click);
            // 
            // pnlMainMenu
            // 
            this.pnlMainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.pnlMainMenu.Controls.Add(this.bunifuFlatButton2);
            this.pnlMainMenu.Controls.Add(this.tab6);
            this.pnlMainMenu.Controls.Add(this.tab5);
            this.pnlMainMenu.Controls.Add(this.tab4);
            this.pnlMainMenu.Controls.Add(this.bunifuFlatButton1);
            this.pnlMainMenu.Controls.Add(this.tab3);
            this.pnlMainMenu.Controls.Add(this.tab2);
            this.pnlMainMenu.Controls.Add(this.tab1);
            this.pnlMainMenu.Controls.Add(this.panel1);
            this.bunifuTransition1.SetDecoration(this.pnlMainMenu, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.pnlMainMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMainMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMainMenu.Name = "pnlMainMenu";
            this.pnlMainMenu.Size = new System.Drawing.Size(200, 708);
            this.pnlMainMenu.TabIndex = 3;
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Active = false;
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "      LogOut";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuFlatButton2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 40D;
            this.bunifuFlatButton2.IsTab = true;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(0, 457);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(152)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(200, 51);
            this.bunifuFlatButton2.TabIndex = 9;
            this.bunifuFlatButton2.Tag = "5";
            this.bunifuFlatButton2.Text = "      LogOut";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // tab6
            // 
            this.tab6.Active = false;
            this.tab6.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.tab6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.tab6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tab6.BorderRadius = 0;
            this.tab6.ButtonText = "      Ajuda";
            this.tab6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.tab6, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.tab6.DisabledColor = System.Drawing.Color.Gray;
            this.tab6.Dock = System.Windows.Forms.DockStyle.Top;
            this.tab6.Iconcolor = System.Drawing.Color.Transparent;
            this.tab6.Iconimage = ((System.Drawing.Image)(resources.GetObject("tab6.Iconimage")));
            this.tab6.Iconimage_right = null;
            this.tab6.Iconimage_right_Selected = null;
            this.tab6.Iconimage_Selected = null;
            this.tab6.IconMarginLeft = 0;
            this.tab6.IconMarginRight = 0;
            this.tab6.IconRightVisible = true;
            this.tab6.IconRightZoom = 0D;
            this.tab6.IconVisible = true;
            this.tab6.IconZoom = 40D;
            this.tab6.IsTab = true;
            this.tab6.Location = new System.Drawing.Point(0, 406);
            this.tab6.Name = "tab6";
            this.tab6.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.tab6.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(152)))));
            this.tab6.OnHoverTextColor = System.Drawing.Color.White;
            this.tab6.selected = false;
            this.tab6.Size = new System.Drawing.Size(200, 51);
            this.tab6.TabIndex = 7;
            this.tab6.Tag = "5";
            this.tab6.Text = "      Ajuda";
            this.tab6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tab6.Textcolor = System.Drawing.Color.White;
            this.tab6.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // tab5
            // 
            this.tab5.Active = false;
            this.tab5.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.tab5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.tab5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tab5.BorderRadius = 0;
            this.tab5.ButtonText = "      Turmas";
            this.tab5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.tab5, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.tab5.DisabledColor = System.Drawing.Color.Gray;
            this.tab5.Dock = System.Windows.Forms.DockStyle.Top;
            this.tab5.Iconcolor = System.Drawing.Color.Transparent;
            this.tab5.Iconimage = ((System.Drawing.Image)(resources.GetObject("tab5.Iconimage")));
            this.tab5.Iconimage_right = null;
            this.tab5.Iconimage_right_Selected = null;
            this.tab5.Iconimage_Selected = null;
            this.tab5.IconMarginLeft = 0;
            this.tab5.IconMarginRight = 0;
            this.tab5.IconRightVisible = true;
            this.tab5.IconRightZoom = 0D;
            this.tab5.IconVisible = true;
            this.tab5.IconZoom = 45D;
            this.tab5.IsTab = true;
            this.tab5.Location = new System.Drawing.Point(0, 355);
            this.tab5.Name = "tab5";
            this.tab5.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.tab5.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(152)))));
            this.tab5.OnHoverTextColor = System.Drawing.Color.White;
            this.tab5.selected = false;
            this.tab5.Size = new System.Drawing.Size(200, 51);
            this.tab5.TabIndex = 6;
            this.tab5.Tag = "4";
            this.tab5.Text = "      Turmas";
            this.tab5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tab5.Textcolor = System.Drawing.Color.White;
            this.tab5.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // tab4
            // 
            this.tab4.Active = false;
            this.tab4.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.tab4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.tab4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tab4.BorderRadius = 0;
            this.tab4.ButtonText = "      Cursos";
            this.tab4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.tab4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.tab4.DisabledColor = System.Drawing.Color.Gray;
            this.tab4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tab4.Iconcolor = System.Drawing.Color.Transparent;
            this.tab4.Iconimage = ((System.Drawing.Image)(resources.GetObject("tab4.Iconimage")));
            this.tab4.Iconimage_right = null;
            this.tab4.Iconimage_right_Selected = null;
            this.tab4.Iconimage_Selected = null;
            this.tab4.IconMarginLeft = 0;
            this.tab4.IconMarginRight = 0;
            this.tab4.IconRightVisible = true;
            this.tab4.IconRightZoom = 0D;
            this.tab4.IconVisible = true;
            this.tab4.IconZoom = 40D;
            this.tab4.IsTab = true;
            this.tab4.Location = new System.Drawing.Point(0, 304);
            this.tab4.Name = "tab4";
            this.tab4.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.tab4.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(152)))));
            this.tab4.OnHoverTextColor = System.Drawing.Color.White;
            this.tab4.selected = false;
            this.tab4.Size = new System.Drawing.Size(200, 51);
            this.tab4.TabIndex = 5;
            this.tab4.Tag = "3";
            this.tab4.Text = "      Cursos";
            this.tab4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tab4.Textcolor = System.Drawing.Color.White;
            this.tab4.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Active = false;
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "      Atendimento";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuFlatButton1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 40D;
            this.bunifuFlatButton1.IsTab = true;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(0, 253);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(152)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(200, 51);
            this.bunifuFlatButton1.TabIndex = 8;
            this.bunifuFlatButton1.Tag = "6";
            this.bunifuFlatButton1.Text = "      Atendimento";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // tab3
            // 
            this.tab3.Active = false;
            this.tab3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.tab3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.tab3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tab3.BorderRadius = 0;
            this.tab3.ButtonText = "      Funcionários";
            this.tab3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.tab3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.tab3.DisabledColor = System.Drawing.Color.Gray;
            this.tab3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tab3.Iconcolor = System.Drawing.Color.Transparent;
            this.tab3.Iconimage = ((System.Drawing.Image)(resources.GetObject("tab3.Iconimage")));
            this.tab3.Iconimage_right = null;
            this.tab3.Iconimage_right_Selected = null;
            this.tab3.Iconimage_Selected = null;
            this.tab3.IconMarginLeft = 0;
            this.tab3.IconMarginRight = 0;
            this.tab3.IconRightVisible = true;
            this.tab3.IconRightZoom = 0D;
            this.tab3.IconVisible = true;
            this.tab3.IconZoom = 50D;
            this.tab3.IsTab = true;
            this.tab3.Location = new System.Drawing.Point(0, 202);
            this.tab3.Name = "tab3";
            this.tab3.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.tab3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(152)))));
            this.tab3.OnHoverTextColor = System.Drawing.Color.White;
            this.tab3.selected = false;
            this.tab3.Size = new System.Drawing.Size(200, 51);
            this.tab3.TabIndex = 4;
            this.tab3.Tag = "2";
            this.tab3.Text = "      Funcionários";
            this.tab3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tab3.Textcolor = System.Drawing.Color.White;
            this.tab3.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab3.Click += new System.EventHandler(this.sideMenu_Click);
            // 
            // tab2
            // 
            this.tab2.Active = false;
            this.tab2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.tab2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.tab2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tab2.BorderRadius = 0;
            this.tab2.ButtonText = "      Usuários";
            this.tab2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.tab2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.tab2.DisabledColor = System.Drawing.Color.Gray;
            this.tab2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tab2.Iconcolor = System.Drawing.Color.Transparent;
            this.tab2.Iconimage = ((System.Drawing.Image)(resources.GetObject("tab2.Iconimage")));
            this.tab2.Iconimage_right = null;
            this.tab2.Iconimage_right_Selected = null;
            this.tab2.Iconimage_Selected = null;
            this.tab2.IconMarginLeft = 0;
            this.tab2.IconMarginRight = 0;
            this.tab2.IconRightVisible = true;
            this.tab2.IconRightZoom = 0D;
            this.tab2.IconVisible = true;
            this.tab2.IconZoom = 45D;
            this.tab2.IsTab = true;
            this.tab2.Location = new System.Drawing.Point(0, 151);
            this.tab2.Name = "tab2";
            this.tab2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.tab2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(152)))));
            this.tab2.OnHoverTextColor = System.Drawing.Color.White;
            this.tab2.selected = false;
            this.tab2.Size = new System.Drawing.Size(200, 51);
            this.tab2.TabIndex = 3;
            this.tab2.Tag = "1";
            this.tab2.Text = "      Usuários";
            this.tab2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tab2.Textcolor = System.Drawing.Color.White;
            this.tab2.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab2.Click += new System.EventHandler(this.sideMenu_Click);
            // 
            // tab1
            // 
            this.tab1.Active = true;
            this.tab1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.tab1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.tab1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tab1.BorderRadius = 0;
            this.tab1.ButtonText = "      Dashboard";
            this.tab1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.tab1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.tab1.DisabledColor = System.Drawing.Color.Gray;
            this.tab1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tab1.Iconcolor = System.Drawing.Color.Transparent;
            this.tab1.Iconimage = ((System.Drawing.Image)(resources.GetObject("tab1.Iconimage")));
            this.tab1.Iconimage_right = null;
            this.tab1.Iconimage_right_Selected = null;
            this.tab1.Iconimage_Selected = null;
            this.tab1.IconMarginLeft = 0;
            this.tab1.IconMarginRight = 0;
            this.tab1.IconRightVisible = true;
            this.tab1.IconRightZoom = 0D;
            this.tab1.IconVisible = true;
            this.tab1.IconZoom = 40D;
            this.tab1.IsTab = true;
            this.tab1.Location = new System.Drawing.Point(0, 100);
            this.tab1.Name = "tab1";
            this.tab1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.tab1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(75)))), ((int)(((byte)(152)))));
            this.tab1.OnHoverTextColor = System.Drawing.Color.White;
            this.tab1.selected = true;
            this.tab1.Size = new System.Drawing.Size(200, 51);
            this.tab1.TabIndex = 1;
            this.tab1.Tag = "0";
            this.tab1.Text = "      Dashboard";
            this.tab1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tab1.Textcolor = System.Drawing.Color.White;
            this.tab1.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab1.Click += new System.EventHandler(this.sideMenu_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.logo);
            this.bunifuTransition1.SetDecoration(this.panel1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 2;
            // 
            // logo
            // 
            this.logo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuTransition1.SetDecoration(this.logo, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(43, 12);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(92, 75);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 1;
            this.logo.TabStop = false;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1177, 708);
            this.Controls.Add(this.parentContainer);
            this.Controls.Add(this.sidePanel);
            this.bunifuTransition1.SetDecoration(this, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.DoubleBuffered = true;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SisEscotec";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMenu_FormClosed);
            this.sidePanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnlMenuHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnDrawerPin)).EndInit();
            this.pnlMainMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer MouseDetect;
        private System.Windows.Forms.Panel parentContainer;
        private subMenu subMenutab;
        private System.Windows.Forms.ImageList pinnerImages;
        private Bunifu.UI.WinForms.BunifuTransition bunifuTransition1;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlMenuHeader;
        private Bunifu.Framework.UI.BunifuImageButton btnDrawerPin;
        private System.Windows.Forms.Panel pnlMainMenu;
        private Bunifu.Framework.UI.BunifuFlatButton tab6;
        private Bunifu.Framework.UI.BunifuFlatButton tab5;
        private Bunifu.Framework.UI.BunifuFlatButton tab4;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton tab3;
        private Bunifu.Framework.UI.BunifuFlatButton tab2;
        private Bunifu.Framework.UI.BunifuFlatButton tab1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox logo;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
    }
}