using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void takeShot_Click(object sender, EventArgs e)
        {
            camera.PressButton(mainScreen);
        }

    }
}
