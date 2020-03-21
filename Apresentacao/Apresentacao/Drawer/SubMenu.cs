using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KimtToo.VisualReactive;

namespace Apresentacao
{
    public partial class SubMenu : UserControl
    {
        public SubMenu()
        {
            InitializeComponent();

            if (Program.IsInDesignMode()) return;
            hidder.Height = 30;

            VSReactive<int>.Subscribe(VSroute.menu, e => tabControl1.SelectedIndex = e);


        }

        private void subMenuSelected_Click(object sender, EventArgs e)
        {
            //set current page to match selected button
            VSReactive<string>.SetState(VSroute.page, ((Control)sender).Tag.ToString());
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //select the first tab of the page 
            foreach (Bunifu.Framework.UI.BunifuFlatButton item in tabControl1.SelectedTab.Controls)
            {
                if (item.selected)
                {
                    try
                    {
                        int val = int.Parse(item.Tag.ToString());
                        VSReactive<int>.SetState(VSroute.current_wizard_tab, val);

                    }
                    catch (Exception)
                    {
                        VSReactive<string>.SetState(VSroute.page, item.Tag.ToString());
                    }



                    return;
                }
            }
        }

        private void wizard_Click(object sender, EventArgs e)
        {
            VSReactive<int>.SetState(VSroute.current_wizard_tab, int.Parse(((Control)sender).Tag.ToString()));
        }
    }
}
