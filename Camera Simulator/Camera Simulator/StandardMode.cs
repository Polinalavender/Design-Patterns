using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camera_Simulator
{
    public class StandardMode : ShotingMode
    {
        public string getImageSize()
        {
            return "1280 x 720 px";
        }
        public void takePhoto(RichTextBox richTextBox)
        {
            richTextBox.Text = "Taking photo in Standard mode.";
        }
    }
}
