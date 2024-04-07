using System;
using System.Drawing;
using System.Windows.Forms;

namespace Camera_Simulator
{
    public class TimerMode : ShootingMode
    {
        public string getImageSize()
        {
            return "1280 x 720 px";
        }
        public void takePhoto(RichTextBox richTextBox)
        {
            richTextBox.AppendText("Taking portrait photo in Portrait mode.\n");
        }
    }
}

