using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camera_Simulator
{
    internal class AutoMode : ShotingMode
    {
        public string getImageSize()
        {
            return "1080 x 1920 px";
        }

        public void takePhoto(RichTextBox richTextBox)
        {
            richTextBox.Text = "Taking photo in Auto mode.";
        }
    }
}
