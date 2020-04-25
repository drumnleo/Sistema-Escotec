using System;
using System.Windows.Forms;
using ObjetoTransferencia;
using AForge.Video;
using AForge.Video.DirectShow;
using Negocios;
using System.Reflection;
using Apresentacao.Presentation.Pages;
using System.Drawing;

namespace Apresentacao.Presentation.Popup.SearchDialogs
{
    
    public partial class SearchDialog_WebCam_Foto : Form
    {
        Foto foto = new Foto();
        private FilterInfoCollection cameras;
        private VideoCaptureDevice cam;

        public SearchDialog_WebCam_Foto()
        {
            InitializeComponent();
            cameras = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo info in cameras)
            {
                cbxCameras.Items.Add(info.Name);
            }
            cbxCameras.SelectedIndex = 0;
            picFotoTirada.Visible = false;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            if (cam != null && cam.IsRunning)
            {
                cam.Stop();
            }
            this.Close();

        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            if (cam != null && cam.IsRunning)
            {
                cam.Stop();
            }
        }

        private void btnLigar_Click(object sender, EventArgs e)
        {
            if (cam != null && cam.IsRunning)
            {
                cam.Stop();
            }
            cam = new VideoCaptureDevice(cameras[cbxCameras.SelectedIndex].MonikerString);
            cam.NewFrame += Cam_NewFrame;
            cam.Start();
            picFotoTirada.Visible = false;
        }

        private void Cam_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            picFoto.Image = bitmap;
        }

        private void btnTirarFoto_Click(object sender, EventArgs e)
        {
            picFotoTirada.Image = picFoto.Image;
            foto.Arquivo_Foto = picFotoTirada.Image;
            picFotoTirada.Visible = true;
        }
    }
}
