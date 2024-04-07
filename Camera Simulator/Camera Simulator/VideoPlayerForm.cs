using System;
using System.Windows.Forms;

namespace Camera_Simulator
{
    public partial class VideoPlayerForm : Form
    {
        private MainScreenForm mainScreenForm;

        public VideoPlayerForm()
        {
            InitializeComponent();
        }

        internal void PlayVideo(string videoFilePath)
        {
            axWindowsMediaPlayer1.URL = videoFilePath;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (mainScreenForm != null)
            {
                mainScreenForm.Show();
            }
            this.Close();
        }
    }
}
