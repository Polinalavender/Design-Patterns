using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Camera_Simulator
{
    public partial class MainScreenForm : Form
    {
        private Camera camera;
        private List<Image> galleryImages;

        public MainScreenForm()
        {
            InitializeComponent();
            camera = new Camera();
            galleryImages = new List<Image>();
        }

        private void autoMode_Click(object sender, EventArgs e)
        {
            camera.SetMode(new AutoMode());
            modeLabel.Text = "Auto Mode Selected";
        }

        private void portraitMode_Click(object sender, EventArgs e)
        {
            camera.SetMode(new PortraitMode());
            modeLabel.Text = "Portrait Mode Selected";
        }

        private void standardButton_Click(object sender, EventArgs e)
        {
            camera.SetMode(new StandardMode());
            modeLabel.Text = "Standard Mode Selected";
        }

        private void videoMode_Click(object sender, EventArgs e)
        {
            camera.SetMode(new VideoMode());
            modeLabel.Text = "Video Mode Selected";
        }

        private void timerMode_Click(object sender, EventArgs e)
        {
            camera.SetMode(new TimerMode());
            modeLabel.Text = "Timer Mode Selected";
        }

        private void takeShot_Click(object sender, EventArgs e)
        {
            if (!(camera.CurrentMode is AutoMode || camera.CurrentMode is PortraitMode ||
                  camera.CurrentMode is StandardMode || camera.CurrentMode is TimerMode))
            {
                MessageBox.Show("Please select an Auto, Portrait, Standard or Timer modes before taking a shot.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string modeDescription = modeLabel.Text;
            mainScreen.Clear();
            Image photo = camera.PressButton(mainScreen, modeDescription);
            DisplayPhoto(photo);
            galleryImages.Add(photo); // Add taken photo to the galleryImages list
        }


        private void videoRecording_Click(object sender, EventArgs e)
        {
            if (!(camera.CurrentMode is VideoMode))
            {
                MessageBox.Show("Please select Video Mode before recording a video.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string videoFilePath = "C:\\Users\\Toets 1\\Documents\\Design-Patterns\\Camera Simulator\\Camera Simulator\\Photos\\Hybrid.mp4"; // Replace this with the actual video file path

            VideoPlayerForm videoPlayerForm = new VideoPlayerForm();
            videoPlayerForm.PlayVideo(videoFilePath);
            videoPlayerForm.Show();
        }


        private void DisplayPhoto(Image photo)
        {
            pictureBox1.Image = null;
            pictureBox1.Image = photo;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void MainScreenForm_Load(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(1000, 600);
        }

        private void galleryButton_Click(object sender, EventArgs e)
        {
            GalleryForm galleryScreen = new GalleryForm(galleryImages);
            galleryScreen.Show();
        }

        private void offButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
