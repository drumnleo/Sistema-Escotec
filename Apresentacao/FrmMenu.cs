using System;
using System.Windows.Forms;
using KimtToo.VisualReactive;

namespace Apresentacao
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();

            addPageType(new Paginas.Usuarios.AdicionarEditarUsuario());

            VSReactive<string>.Subscribe(VSroute.page, (e) => setPage(e));
        }

        void setPage(string typeName)
        {
            foreach (Control page in parentContainer.Controls)
                if (page.GetType().Name == typeName)
                {
                    page.Visible = true;
                    page.BringToFront();
                    // page.ResumeLayout();
                }
                else
                {
                    // page.SuspendLayout();
                    page.Visible = false;
                }
        }

        void addPageType(Control page, DockStyle dockStyle = DockStyle.None)
        {
            parentContainer.Controls.Add(page);
            page.Top = 0;
            page.Width = parentContainer.Width;
            page.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            if (dockStyle != DockStyle.None) page.Dock = dockStyle;
            page.SendToBack();
        }

        bool mnuExpanded = false;

        private void MouseDetect_Tick_1(object sender, EventArgs e)
        {
            //Detect if mouse is within the Menu Bounds
            //Expand the panel by Animating
            //else Close the panel by animating
            if (!bunifuTransition1.IsCompleted) return;
            if (pnlMainMenu.ClientRectangle.Contains(PointToClient(Control.MousePosition)))
            {
                if (!mnuExpanded)
                {
                    mnuExpanded = true;
                    pnlMainMenu.Width = 200;
                    //  pnlLbl.Visible = false;
                    bunifuTransition1.Show(logo);
                    sidePanel.Width = pnlMainMenu.Width + 200;
                }
            }
            else
            {
                if (!sidePanel.ClientRectangle.Contains(PointToClient(Control.MousePosition)))
                {
                    if (mnuExpanded)
                    {
                        mnuExpanded = false;
                        pnlMainMenu.Visible = false;
                        pnlMainMenu.Width = 45;
                        bunifuTransition1.Show(pnlMainMenu);
                        logo.Visible = false;
                        //    pnlLbl.Visible = true; 
                        sidePanel.Width = pnlMainMenu.Width + 200;
                    }
                }

            }
        }

        private void sideMenu_Click(object sender, EventArgs e)
        {
            VSReactive<int>.SetState(VSroute.menu, int.Parse(((Control)sender).Tag.ToString()));
            //lblCurTab.Text = ((Control)sender).Text.Trim();

        }

    private void btnDrawerPin_Click(object sender, EventArgs e)
        {
            MouseDetect.Enabled = !MouseDetect.Enabled;
            btnDrawerPin.Image = MouseDetect.Enabled ? pinnerImages.Images[0] : pinnerImages.Images[1];
        }

        private void FrmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {

            FrmLogin_flat.ActiveForm.WindowState = FormWindowState.Maximized;
            this.Close();
        }
    }
}
