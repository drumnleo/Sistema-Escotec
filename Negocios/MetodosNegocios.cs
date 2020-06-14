using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Negocios
{
    public class MetodosNegocios
    {
        public void MarcaChkBox(Control.ControlCollection ctrlCollection)
        {
            foreach (Control ctrl in ctrlCollection)
            {
                if (ctrl is CheckBox)
                {
                    ((CheckBox)ctrl).Checked = true;
                    ctrl.Enabled = true;
                }
                else
                {
                    MarcaChkBox(ctrl.Controls);
                }
            }
        }
        public void LimpaTextBox(Control.ControlCollection ctrlCollection)
        {
            foreach (Control ctrl in ctrlCollection)
            {
                if (ctrl is TextBoxBase)
                {
                    ctrl.Text = string.Empty;
                    ctrl.Enabled = true;
                }
                else
                {
                    LimpaTextBox(ctrl.Controls);
                }
            }
        }

        public bool ValidaTime(string hora)
        {
            TimeSpan horaextraida = new TimeSpan(); // Passed result if succeed 

            if (TimeSpan.TryParseExact(hora, "hh\\:mm", CultureInfo.CurrentCulture, TimeSpanStyles.None, out horaextraida))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
