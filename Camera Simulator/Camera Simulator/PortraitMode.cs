using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camera_Simulator
{
    internal class PortraitMode : ShotingMode
    {
        public string getImageSize()
        {
            return "1080 x 1350 px";
        }
        public void takePhoto(RichTextBox richTextBox)
        {
            richTextBox.AppendText("Taking portrait photo in Portrait mode.\n");
        }
    }
}
