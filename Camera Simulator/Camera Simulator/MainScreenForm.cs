using System;
using System.Drawing;
using System.Windows.Forms;
using WMPLib;
namespace Camera_Simulator
{
    public partial class MainScreenForm : Form
    {
        private Camera camera;

        public MainScreenForm()
        {
            InitializeComponent();
            camera = new Camera();
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

        private void hydridMode_Click(object sender, EventArgs e)
        {
            camera.SetMode(new HybridMode());
            modeLabel.Text = "Hybrid Mode Selected";
        }

        private void takeShot_Click(object sender, EventArgs e)
        {
            string modeDescription = modeLabel.Text;
            mainScreen.Clear();
            Image photo = camera.PressButton(mainScreen, modeDescription);
            DisplayPhoto(photo);

        }

        private void DisplayPhoto(Image photo)
        {
            // Clear existing image
            pictureBox1.Image = null;
            pictureBox1.Image = photo;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

        }

        private void MainScreenForm_Load(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(1000, 600);
        }
    }
}
