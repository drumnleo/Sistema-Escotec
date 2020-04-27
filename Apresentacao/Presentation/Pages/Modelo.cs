using System;
using System.Windows.Forms;
using ObjetoTransferencia;
using Negocios;

namespace Apresentacao.Presentation.Pages
{
    public partial class Modelo : UserControl
    {
        public Modelo()
        {
            if (Program.IsInDesignMode()) return;
            InitializeComponent();
        }
    }
}
